namespace TDesu.Serialization

open System
open System.Buffers.Binary
open System.Text
open TDesu.FSharp
open TDesu.FSharp.Buffers

/// <summary>
/// The single exception every malformed TL read raises: a length prefix, a vector count, or a
/// raw byte count the buffer cannot actually satisfy, or an unrecognised bool/vector constructor
/// id.
/// </summary>
/// <remarks>
/// 0.3.2 mixed three unrelated BCL exception types for these — <c>ArgumentOutOfRangeException</c>
/// from the shared bounds check in <c>take</c>, <c>IndexOutOfRangeException</c> from
/// <c>ReadBytes</c>'s own unchecked prefix read, <c>InvalidOperationException</c> from
/// <c>ReadBool</c> and <c>ReadVector</c> — so a caller (a framing layer deciding whether a socket
/// error means "reconnect" or "the session is corrupt") could not catch "this frame is short or
/// lying" with one <c>with</c> clause. Declared as an F# <c>exception</c> rather than a class:
/// this is a single case with one payload, which is exactly what the union-style declaration is
/// for, and it still derives from <see cref="System.Exception"/> so <c>try</c>/<c>with</c> and
/// <c>raise</c> work exactly as they would for any other exception.
///
/// Reserved for content the buffer cannot honour. A bad argument to the reader's own API — a
/// negative <c>Position</c>, an out-of-range <c>(data, offset, count)</c> — is the caller
/// misusing the type, not Telegram sending something malformed, and stays an
/// <see cref="System.ArgumentException"/>/<see cref="System.ArgumentOutOfRangeException"/> raised
/// through <c>Guard</c>.
/// </remarks>
exception TlFormatException of message: string
    with
        override this.Message = this.message

/// <summary>
/// Stateful reader over a TL-encoded <c>byte[]</c>, or a bounded view over part of one.
/// </summary>
/// <remarks>
/// No longer <see cref="IDisposable"/>: 0.3.2's <c>Dispose()</c> was an empty implementation the
/// type carried from its first version, and it forced <c>use r = new TlReadBuffer(...)</c> at
/// every one of the 52 call sites the audit counted across the two consumers, for a type that
/// owns no resource to release.
/// </remarks>
type TlReadBuffer(data: byte[], offset: int, count: int) =
    do
        Guard.inRange "offset" 0 data.Length offset
        Guard.inRange "count" 0 (data.Length - offset) count

    let limit = offset + count
    let mutable pos = offset

    /// Every variable-length read bottoms out here. F# array slicing clamps an out-of-range
    /// slice instead of throwing, so `data[pos .. pos + n - 1]` over a short buffer used to hand
    /// back whatever was left and still advance the cursor by the declared count: a TL `bytes`
    /// of length 10 over a 3-byte tail read as 3 bytes with the position at 12 of 4, and a
    /// negative count moved the cursor backwards (measured against 0.3.1). Nothing downstream
    /// can tell a truncated value from a real one, so the shortfall is raised here — the one
    /// format exception every other malformed read raises too.
    let ensureRemaining (n: int) =
        if n < 0 || n > limit - pos then
            raise (TlFormatException $"{n} bytes at position {pos - offset} overruns the {count}-byte buffer")

    let take (n: int) : byte[] =
        ensureRemaining n
        let result = Bytes.slice data pos n
        pos <- pos + n
        result

    let readByte () : byte =
        ensureRemaining 1
        let b = data[pos]
        pos <- pos + 1
        b

    let peekUInt32 () =
        ensureRemaining 4
        BinaryPrimitives.ReadUInt32LittleEndian(ReadOnlySpan(data, pos, 4))

    /// Reads a TL `bytes` length prefix (1 byte under 254, else a 4-byte `0xFE` tag plus a
    /// 24-bit length) and the trailing zero padding that rounds the field to 4 bytes, and
    /// returns where the payload starts and how long it is. 0.3.2's `ReadBytes` advanced past
    /// the prefix *before* validating the payload length, so a short buffer left `Position`
    /// mid-value instead of restoring it, and the padding skip that followed a successful read
    /// had no bound at all. Every exit here restores `pos` on failure, and the padding skip goes
    /// through `ensureRemaining` exactly like the payload does.
    let readBytesHeader () : struct (int * int) =
        let start = pos
        try
            let firstByte = readByte ()

            let payloadLen, headerLen =
                if int firstByte < 254 then
                    int firstByte, 1
                else
                    let b0 = readByte ()
                    let b1 = readByte ()
                    let b2 = readByte ()
                    (int b0 ||| (int b1 <<< 8) ||| (int b2 <<< 16)), 4

            ensureRemaining payloadLen
            let payloadStart = pos
            pos <- pos + payloadLen
            let padding = (4 - (headerLen + payloadLen) % 4) % 4
            ensureRemaining padding
            pos <- pos + padding
            struct (payloadStart, payloadLen)
        with _ ->
            pos <- start
            reraise ()

    /// Reads the whole array from offset 0 — the common case, and everything 0.3.2 supported.
    new(data: byte[]) = TlReadBuffer(data, 0, data.Length)

    /// Reads a little-endian 32-bit integer.
    member _.ReadInt32() : int32 =
        ensureRemaining 4
        let v = BinaryPrimitives.ReadInt32LittleEndian(ReadOnlySpan(data, pos, 4))
        pos <- pos + 4
        v

    /// Reads a little-endian 64-bit integer.
    member _.ReadInt64() : int64 =
        ensureRemaining 8
        let v = BinaryPrimitives.ReadInt64LittleEndian(ReadOnlySpan(data, pos, 8))
        pos <- pos + 8
        v

    /// Reads a little-endian 64-bit IEEE 754 double.
    member _.ReadDouble() : double =
        ensureRemaining 8
        let v = BinaryPrimitives.ReadInt64LittleEndian(ReadOnlySpan(data, pos, 8))
        pos <- pos + 8
        BitConverter.Int64BitsToDouble(v)

    /// Stays a `byte[]` copy: an int128 is small and fixed-size, and every consumer either
    /// stores or hashes it, so there is little a span would save. `ReadSpan(16)` covers the
    /// caller that wants none.
    member _.ReadInt128() : byte[] = take 16

    /// Same trade-off as `ReadInt128`; `ReadSpan(32)` is the zero-copy form.
    member _.ReadInt256() : byte[] = take 32

    /// Reads a little-endian 32-bit TL constructor id.
    member _.ReadConstructorId() : uint32 =
        let v = peekUInt32 ()
        pos <- pos + 4
        v

    /// Reads the next constructor id without advancing, bounded like every other read. Lets a
    /// caller decide *how* to parse a value from its id before choosing which `Deserialize` to
    /// call — five call sites across the two consumers hand-rolled this by reading 4 bytes with
    /// `BitConverter` (two of them inside the client that forbids exactly that) because 0.3.2 had
    /// no way to look at a constructor id without consuming it.
    member _.PeekConstructorId() : uint32 = peekUInt32 ()

    /// `PeekConstructorId` for a caller that would rather branch on "not enough bytes yet" than
    /// catch an exception for it — a framing layer peeking at a buffer that may not hold a full
    /// frame yet.
    member _.TryPeekConstructorId() : uint32 voption =
        if limit - pos < 4 then
            ValueNone
        else
            ValueSome(BinaryPrimitives.ReadUInt32LittleEndian(ReadOnlySpan(data, pos, 4)))

    /// Reads a TL `bytes` value: a length-prefixed, zero-padded byte string.
    member _.ReadBytes() : byte[] =
        let struct (start, len) = readBytesHeader ()
        Bytes.slice data start len

    /// Decodes straight from the span instead of materialising a `byte[]` first: 0.3.2's
    /// `ReadString` was `Encoding.UTF8.GetString(this.ReadBytes())`, an allocation
    /// `Encoding.UTF8.GetString(ReadOnlySpan<byte>)` — available on netstandard2.1, which this
    /// package already targets — does not need.
    member _.ReadString() : string =
        let struct (start, len) = readBytesHeader ()
        Encoding.UTF8.GetString(ReadOnlySpan(data, start, len))

    /// Reads a TL `Bool`: the `boolTrue`/`boolFalse` constructor id.
    member this.ReadBool() : bool =
        let ctorId = this.ReadConstructorId()

        if ctorId = TlConstants.BoolTrue then true
        elif ctorId = TlConstants.BoolFalse then false
        else raise (TlFormatException $"Unknown bool constructor id: 0x%08X{ctorId}")

    /// Reads a TL `Vector<T>`: the vector constructor id, an element count, then `readItem`
    /// applied that many times.
    member this.ReadVector(readItem: TlReadBuffer -> 'a) : 'a[] =
        let ctorId = this.ReadConstructorId()

        if ctorId <> TlConstants.VectorConstructorId then
            raise (TlFormatException $"Expected vector constructor id 0x1cb5c415, got 0x%08X{ctorId}")

        let itemCount = this.ReadInt32()
        // A TL element is never smaller than 4 bytes, so a count over remaining/4 cannot be
        // honest; catching it here avoids Array.init allocating gigabytes for a lying count
        // (measured: 200_000_000 declared elements over a 12-byte body allocated ~1.5 GiB
        // before failing, against a 0.3.0 baseline).
        if itemCount < 0 || itemCount > (limit - pos) / 4 then
            raise (
                TlFormatException
                    $"Vector declares {itemCount} elements but only {this.Remaining} bytes remain in the buffer"
            )

        Array.init itemCount (fun _ -> readItem this)

    /// Reads exactly `count` raw bytes with no TL framing (no length prefix, no padding).
    member _.ReadRawBytes(count: int) : byte[] = take count

    /// Zero-copy view of the next `count` bytes, for a caller that only needs to hash or forward
    /// them (a message key, a ciphertext body) rather than own a copy.
    member _.ReadSpan(count: int) : ReadOnlySpan<byte> =
        ensureRemaining count
        let span = ReadOnlySpan(data, pos, count)
        pos <- pos + count
        span

    /// Hands back a second reader over the *same* array, spanning the next `count` bytes, and
    /// advances this reader past them. Replaces the copy every nested TL payload used to pay:
    /// 0.3.2's `TlReadBuffer` only ever took a whole `byte[]`, so parsing a nested object out of
    /// an outer one meant slicing it into a fresh array first just to get a reader over it.
    member _.Slice(count: int) : TlReadBuffer =
        ensureRemaining count
        let view = TlReadBuffer(data, pos, count)
        pos <- pos + count
        view

    /// 0-based within this reader's own view (0 at construction, `Length` at the end) — not an
    /// index into the shared array a `Slice` was cut from. Range-checked: an unbounded setter
    /// let a negative `Position` reopen the truncation `take` exists to prevent, by making
    /// `Remaining` compute something other than what is actually left in the buffer.
    member _.Position
        with get () = pos - offset
        and set (v) =
            Guard.inRange "value" 0 count v
            pos <- offset + v

    /// Same bound as a read: skipping past the end is a malformed frame, not an empty one.
    member _.Skip(count: int) =
        ensureRemaining count
        pos <- pos + count

    /// The logical length of this view: `data.Length` for the whole-array constructor, or the
    /// `count` passed to the `(data, offset, count)` view.
    member _.Length : int = count

    /// Bytes left to read in this view.
    member _.Remaining : int = limit - pos

    /// `true` while `Remaining > 0`.
    member _.HasMore : bool = pos < limit
