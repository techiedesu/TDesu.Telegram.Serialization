namespace TDesu.Serialization

open System
open System.Buffers
open System.Buffers.Binary
open System.Text
open TDesu.FSharp
open TDesu.FSharp.Buffers

/// <summary>
/// Wire-format constants shared by <see cref="TlReadBuffer"/> and <see cref="TlWriteBuffer"/>.
/// </summary>
/// <remarks>
/// Public since 0.4.0. 0.3.2 kept this module <c>internal</c>, so the vector constructor id
/// alone was retyped as a bare literal in at least two places outside this assembly — one of
/// them inside the MTProto client, which otherwise forbids hand-rolled TL constants entirely —
/// because there was no public name to reference instead.
/// </remarks>
module TlConstants =
    /// The `boolTrue#997275b5` constructor id.
    [<Literal>]
    let BoolTrue = 0x997275b5u

    /// The `boolFalse#bc799737` constructor id.
    [<Literal>]
    let BoolFalse = 0xbc799737u

    /// The TL `Vector<T>` constructor id, `0x1cb5c415`.
    [<Literal>]
    let VectorConstructorId = 0x1cb5c415u

    /// One past the largest length a TL `bytes`/`string` header can encode: the extended form
    /// reserves 3 bytes (24 bits) for the length. `WriteBytes`/`WriteString` used to wrap
    /// silently at this boundary instead of rejecting it.
    [<Literal>]
    let MaxByteLength = 16777216

/// <summary>
/// Pooled, resizable write buffer backed by <see cref="ArrayPool{T}"/>. <see cref="IDisposable"/> —
/// returns the buffer to the pool on dispose.
/// </summary>
type TlWriteBuffer(?initialCapacity: int) =
    let mutable buffer = ArrayPool.rentBytes (defaultArg initialCapacity 256)
    let mutable pos = 0

    let ensureCapacity needed =
        if pos + needed > buffer.Length then
            let newBuf = ArrayPool.rentBytes (max (buffer.Length * 2) (pos + needed))
            Buffer.BlockCopy(buffer, 0, newBuf, 0, pos)
            // Cleared: a buffer this writer just grew away from can still hold a session key or
            // a plaintext body from whatever was serialised into it, and the pool otherwise hands
            // a rented array back to its next renter with whatever the previous one left inside.
            ArrayPool<byte>.Shared.Return(buffer, clearArray = true)
            buffer <- newBuf

    /// Writes the TL length prefix — one byte for a value under 254, else a 4-byte `0xFE` tag
    /// followed by a 24-bit length — shared by `WriteBytes` and `WriteString` so the header
    /// format exists in exactly one place. 0.3.2 carried two copies: `WriteString`'s short-string
    /// branch duplicated this byte for byte instead of delegating to `WriteBytes`.
    let writeHeader (len: int) =
        if len < 254 then
            buffer[pos] <- byte len
            pos <- pos + 1
        else
            buffer[pos] <- 0xFEuy
            buffer[pos + 1] <- byte (len &&& 0xFF)
            buffer[pos + 2] <- byte ((len >>> 8) &&& 0xFF)
            buffer[pos + 3] <- byte ((len >>> 16) &&& 0xFF)
            pos <- pos + 4

    let headerLength (len: int) = if len < 254 then 1 else 4

    /// Writes the zero padding that rounds a `bytes`/`string` field up to a 4-byte boundary.
    let writePadding (headerLen: int) (len: int) =
        let padding = (4 - (headerLen + len) % 4) % 4

        for i in 0 .. padding - 1 do
            buffer[pos + i] <- 0uy

        pos <- pos + padding

    /// Writes a little-endian 32-bit integer.
    member _.WriteInt32(value: int32) : unit =
        ensureCapacity 4
        BinaryPrimitives.WriteInt32LittleEndian(buffer.AsSpan(pos), value)
        pos <- pos + 4

    /// Writes a little-endian 64-bit integer.
    member _.WriteInt64(value: int64) : unit =
        ensureCapacity 8
        BinaryPrimitives.WriteInt64LittleEndian(buffer.AsSpan(pos), value)
        pos <- pos + 8

    /// Writes a little-endian 64-bit IEEE 754 double.
    member _.WriteDouble(value: double) : unit =
        ensureCapacity 8
        BinaryPrimitives.WriteInt64LittleEndian(buffer.AsSpan(pos), BitConverter.DoubleToInt64Bits(value))
        pos <- pos + 8

    /// Writes a raw 128-bit value (16 bytes) with no length prefix.
    member _.WriteInt128(value: byte[]) : unit =
        if value.Length <> 16 then
            invalidArg (nameof value) "Int128 must be exactly 16 bytes"

        ensureCapacity 16
        value.AsSpan().CopyTo(buffer.AsSpan(pos, 16))
        pos <- pos + 16

    /// Writes a raw 256-bit value (32 bytes) with no length prefix.
    member _.WriteInt256(value: byte[]) : unit =
        if value.Length <> 32 then
            invalidArg (nameof value) "Int256 must be exactly 32 bytes"

        ensureCapacity 32
        value.AsSpan().CopyTo(buffer.AsSpan(pos, 32))
        pos <- pos + 32

    /// Writes a little-endian 32-bit TL constructor id.
    member this.WriteConstructorId(id: uint32) : unit = this.WriteInt32(int32 id)

    /// Writes a TL `bytes` value: a length-prefixed, zero-padded byte string.
    member _.WriteBytes(value: byte[]) : unit =
        let len = value.Length

        Guard.isTrue
            (nameof value)
            $"Value is {len} bytes; TL `bytes` cannot encode a length of {TlConstants.MaxByteLength} or more."
            (len < TlConstants.MaxByteLength)

        let hLen = headerLength len
        ensureCapacity (hLen + len + 3)
        writeHeader len
        value.AsSpan().CopyTo(buffer.AsSpan(pos, len))
        pos <- pos + len
        writePadding hLen len

    /// <summary>Writes a TL `string` — the same `bytes` encoding, over UTF-8.</summary>
    /// <remarks>
    /// Rewritten against the audit: 0.3.2 rented a pool buffer for every string under 256 UTF-8
    /// bytes purely to hold the encoded bytes long enough to copy them a second time into
    /// <c>buffer</c>, and the long-form branch it kept for a string whose encoding needed more
    /// than that was dead code — <c>GetMaxByteCount</c> only exceeds 256 past 84 three-byte
    /// UTF-8 characters, which is 252 encoded bytes and still under the rental cap, so that
    /// branch could never run. <c>GetByteCount</c> sizes the header once and <c>GetBytes</c>
    /// encodes straight into <c>buffer</c>, so there is nothing left to rent.
    /// </remarks>
    member _.WriteString(value: string) : unit =
        let len = if String.IsNullOrEmpty value then 0 else Encoding.UTF8.GetByteCount(value)

        Guard.isTrue
            (nameof value)
            $"Value is {len} UTF-8 bytes; TL `bytes` cannot encode a length of {TlConstants.MaxByteLength} or more."
            (len < TlConstants.MaxByteLength)

        let hLen = headerLength len
        ensureCapacity (hLen + len + 3)
        writeHeader len

        if len > 0 then
            Encoding.UTF8.GetBytes(value, 0, value.Length, buffer, pos) |> ignore
            pos <- pos + len

        writePadding hLen len

    /// Writes a TL `Bool`: the `boolTrue`/`boolFalse` constructor id.
    member this.WriteBool(value: bool) : unit =
        if value then
            this.WriteConstructorId(TlConstants.BoolTrue)
        else
            this.WriteConstructorId(TlConstants.BoolFalse)

    /// Writes a TL `Vector<T>`: the vector constructor id, the element count, then `writeItem`
    /// applied to each element in order.
    member this.WriteVector(items: 'a[], writeItem: TlWriteBuffer -> 'a -> unit) : unit =
        this.WriteConstructorId(TlConstants.VectorConstructorId)
        this.WriteInt32(items.Length)

        for item in items do
            writeItem this item

    /// Writes raw bytes with no TL framing (no length prefix, no padding).
    member _.WriteRawBytes(value: byte[]) : unit =
        ensureCapacity value.Length
        value.AsSpan().CopyTo(buffer.AsSpan(pos, value.Length))
        pos <- pos + value.Length

    /// Span overload: a caller holding a `ReadOnlySpan<byte>` — a slice of someone else's
    /// buffer, or `TlReadBuffer.ReadSpan`'s own result — used to have to copy it into a
    /// `byte[]` first just to call this.
    member _.WriteRawBytes(value: ReadOnlySpan<byte>) : unit =
        ensureCapacity value.Length
        value.CopyTo(buffer.AsSpan(pos, value.Length))
        pos <- pos + value.Length

    /// Bytes written so far.
    member _.Length : int = pos

    /// Copies the written bytes out as a new array.
    member _.ToArray() : byte[] = buffer.AsSpan(0, pos).ToArray()

    /// Zero-copy view of written data. Valid only while buffer is not disposed/reset.
    member _.WrittenSpan : ReadOnlySpan<byte> = ReadOnlySpan(buffer, 0, pos)

    /// Zero-copy Memory view. Valid only while buffer is not disposed/reset.
    member _.WrittenMemory : ReadOnlyMemory<byte> = ReadOnlyMemory(buffer, 0, pos)

    /// Reset position to zero for reuse. Buffer stays rented from ArrayPool.
    member _.Reset() = pos <- 0

    interface IDisposable with
        member _.Dispose() =
            if buffer.Length > 0 then
                ArrayPool<byte>.Shared.Return(buffer, clearArray = true)
                buffer <- Array.empty
