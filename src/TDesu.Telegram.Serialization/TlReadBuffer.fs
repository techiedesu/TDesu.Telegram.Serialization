namespace TDesu.Serialization

open System
open System.Buffers.Binary
open System.Text

type TlReadBuffer(data: byte[]) =
    let mutable pos = 0

    /// Every variable-length read goes through here. F# array slicing clamps an out-of-range
    /// slice instead of throwing, so `data[pos .. pos + count - 1]` over a short buffer used to
    /// hand back whatever was left and still advance the cursor by the declared count: a TL
    /// `bytes` of length 10 over a 3-byte tail read as 3 bytes with the position at 12 of 4, and
    /// a negative count moved the cursor backwards (measured against 0.3.1). Nothing downstream
    /// can tell a truncated value from a real one, so the shortfall has to be raised here.
    let take (count: int) : byte[] =
        if count < 0 || count > data.Length - pos then
            raise (
                ArgumentOutOfRangeException(
                    "count",
                    count,
                    $"Read of {count} bytes at position {pos} overruns the {data.Length}-byte buffer"
                )
            )

        let result = data[pos .. pos + count - 1]
        pos <- pos + count
        result

    member _.ReadInt32() : int32 =
        let v = BinaryPrimitives.ReadInt32LittleEndian(ReadOnlySpan(data, pos, 4))
        pos <- pos + 4
        v

    member _.ReadInt64() : int64 =
        let v = BinaryPrimitives.ReadInt64LittleEndian(ReadOnlySpan(data, pos, 8))
        pos <- pos + 8
        v

    member _.ReadDouble() : double =
        let v = BinaryPrimitives.ReadInt64LittleEndian(ReadOnlySpan(data, pos, 8))
        pos <- pos + 8
        BitConverter.Int64BitsToDouble(v)

    member _.ReadInt128() : byte[] = take 16

    member _.ReadInt256() : byte[] = take 32

    member _.ReadConstructorId() : uint32 =
        let v = BinaryPrimitives.ReadUInt32LittleEndian(ReadOnlySpan(data, pos, 4))
        pos <- pos + 4
        v

    member _.ReadBytes() : byte[] =
        let firstByte = int data[pos]
        pos <- pos + 1
        if firstByte < 254 then
            let len = firstByte
            let result = take len
            let padding = (4 - (1 + len) % 4) % 4
            pos <- pos + padding
            result
        else
            let len = int data[pos] ||| (int data[pos + 1] <<< 8) ||| (int data[pos + 2] <<< 16)
            pos <- pos + 3
            let result = take len
            let padding = (4 - (4 + len) % 4) % 4
            pos <- pos + padding
            result

    member this.ReadString() : string =
        Encoding.UTF8.GetString(this.ReadBytes())

    member this.ReadBool() : bool =
        let ctorId = this.ReadConstructorId()
        if ctorId = TlConstants.BoolTrue then true
        elif ctorId = TlConstants.BoolFalse then false
        else invalidOp $"Unknown bool constructor id: 0x%08X{ctorId}"

    member this.ReadVector(readItem: TlReadBuffer -> 'a) : 'a[] =
        let ctorId = this.ReadConstructorId()
        if ctorId <> TlConstants.VectorConstructorId then
            invalidOp $"Expected vector constructor id 0x1cb5c415, got 0x%08X{ctorId}"
        let count = this.ReadInt32()
        let remaining = data.Length - pos
        // A TL element is never smaller than 4 bytes, so a count over remaining/4 cannot be
        // honest; catching it here avoids Array.init allocating gigabytes for a lying count
        // (measured: 200_000_000 declared elements over a 12-byte body allocated ~1.5 GiB
        // before failing, against a 0.3.0 baseline).
        if count < 0 || count > remaining / 4 then
            raise (ArgumentOutOfRangeException("count", count, $"Vector declares {count} elements but only {remaining} bytes remain in the buffer"))
        Array.init count (fun _ -> readItem this)

    member _.ReadRawBytes(count: int) : byte[] = take count

    member _.Position
        with get() = pos
        and set(v) = pos <- v

    /// Same bound as a read: skipping past the end is a malformed frame, not an empty one.
    member _.Skip(count: int) =
        if count < 0 || count > data.Length - pos then
            raise (
                ArgumentOutOfRangeException(
                    "count",
                    count,
                    $"Skip of {count} bytes at position {pos} overruns the {data.Length}-byte buffer"
                )
            )

        pos <- pos + count

    member _.Length : int = data.Length

    member _.HasMore : bool = pos < data.Length

    interface IDisposable with
        member _.Dispose() = ()
