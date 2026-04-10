namespace TDesu.Serialization

open System
open System.Buffers.Binary
open System.Text

type TlReadBuffer(data: byte[]) =
    let mutable pos = 0

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

    member _.ReadInt128() : byte[] =
        let result = data[pos .. pos + 15]
        pos <- pos + 16
        result

    member _.ReadInt256() : byte[] =
        let result = data[pos .. pos + 31]
        pos <- pos + 32
        result

    member _.ReadConstructorId() : uint32 =
        let v = BinaryPrimitives.ReadUInt32LittleEndian(ReadOnlySpan(data, pos, 4))
        pos <- pos + 4
        v

    member _.ReadBytes() : byte[] =
        let firstByte = int data[pos]
        pos <- pos + 1
        if firstByte < 254 then
            let len = firstByte
            let result = data[pos .. pos + len - 1]
            pos <- pos + len
            let padding = (4 - (1 + len) % 4) % 4
            pos <- pos + padding
            result
        else
            let len = int data[pos] ||| (int data[pos + 1] <<< 8) ||| (int data[pos + 2] <<< 16)
            pos <- pos + 3
            let result = data[pos .. pos + len - 1]
            pos <- pos + len
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
        Array.init count (fun _ -> readItem this)

    member _.ReadRawBytes(count: int) : byte[] =
        let result = data[pos .. pos + count - 1]
        pos <- pos + count
        result

    member _.Position
        with get() = pos
        and set(v) = pos <- v

    member _.Skip(count: int) = pos <- pos + count

    member _.Length : int = data.Length

    member _.HasMore : bool = pos < data.Length

    interface IDisposable with
        member _.Dispose() = ()
