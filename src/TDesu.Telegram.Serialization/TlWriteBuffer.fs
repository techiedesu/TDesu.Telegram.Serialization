namespace TDesu.Serialization

open System
open System.Buffers
open System.Buffers.Binary

module internal TlConstants =
    [<Literal>]
    let BoolTrue = 0x997275b5u
    [<Literal>]
    let BoolFalse = 0xbc799737u
    [<Literal>]
    let VectorConstructorId = 0x1cb5c415u

/// Owns a pooled byte[] buffer. Returns to pool on Dispose.
/// Use instead of byte[] to avoid allocation when lifetime is bounded.
[<Struct>]
type PooledBytes =
    val Buffer: byte[]
    val Length: int
    new(buffer: byte[], length: int) = { Buffer = buffer; Length = length }
    member this.Span = ReadOnlySpan(this.Buffer, 0, this.Length)
    member this.Memory = ReadOnlyMemory(this.Buffer, 0, this.Length)
    member this.ToArray() = this.Span.ToArray()
    /// Return buffer to pool. Call exactly once when done.
    member this.Return() =
        if this.Buffer.Length > 0 then
            ArrayPool<byte>.Shared.Return(this.Buffer)

type TlWriteBuffer(?initialCapacity: int) =
    let mutable buffer = ArrayPool<byte>.Shared.Rent(defaultArg initialCapacity 256)
    let mutable pos = 0

    let ensureCapacity needed =
        if pos + needed > buffer.Length then
            let newBuf = ArrayPool<byte>.Shared.Rent(max (buffer.Length * 2) (pos + needed))
            Buffer.BlockCopy(buffer, 0, newBuf, 0, pos)
            ArrayPool<byte>.Shared.Return(buffer)
            buffer <- newBuf

    member _.WriteInt32(value: int32) : unit =
        ensureCapacity 4
        BinaryPrimitives.WriteInt32LittleEndian(buffer.AsSpan(pos), value)
        pos <- pos + 4

    member _.WriteInt64(value: int64) : unit =
        ensureCapacity 8
        BinaryPrimitives.WriteInt64LittleEndian(buffer.AsSpan(pos), value)
        pos <- pos + 8

    member _.WriteDouble(value: double) : unit =
        ensureCapacity 8
        BinaryPrimitives.WriteInt64LittleEndian(buffer.AsSpan(pos), BitConverter.DoubleToInt64Bits(value))
        pos <- pos + 8

    member _.WriteInt128(value: byte[]) : unit =
        if value.Length <> 16 then
            invalidArg (nameof value) "Int128 must be exactly 16 bytes"
        ensureCapacity 16
        value.AsSpan().CopyTo(buffer.AsSpan(pos, 16))
        pos <- pos + 16

    member _.WriteInt256(value: byte[]) : unit =
        if value.Length <> 32 then
            invalidArg (nameof value) "Int256 must be exactly 32 bytes"
        ensureCapacity 32
        value.AsSpan().CopyTo(buffer.AsSpan(pos, 32))
        pos <- pos + 32

    member this.WriteConstructorId(id: uint32) : unit =
        this.WriteInt32(int32 id)

    member _.WriteBytes(value: byte[]) : unit =
        let len = value.Length
        if len < 254 then
            ensureCapacity (1 + len + 3)
            buffer[pos] <- byte len
            pos <- pos + 1
            value.AsSpan().CopyTo(buffer.AsSpan(pos, len))
            pos <- pos + len
            let padding = (4 - (1 + len) % 4) % 4
            for _ in 1..padding do
                buffer[pos] <- 0uy
                pos <- pos + 1
        else
            ensureCapacity (4 + len + 3)
            buffer[pos] <- 0xFEuy
            buffer[pos + 1] <- byte (len &&& 0xFF)
            buffer[pos + 2] <- byte ((len >>> 8) &&& 0xFF)
            buffer[pos + 3] <- byte ((len >>> 16) &&& 0xFF)
            pos <- pos + 4
            value.AsSpan().CopyTo(buffer.AsSpan(pos, len))
            pos <- pos + len
            let padding = (4 - (4 + len) % 4) % 4
            for _ in 1..padding do
                buffer[pos] <- 0uy
                pos <- pos + 1

    member this.WriteString(value: string) : unit =
        if System.String.IsNullOrEmpty(value) then
            this.WriteBytes(Array.empty)
        else
            let maxByteCount = System.Text.Encoding.UTF8.GetMaxByteCount(value.Length)
            if maxByteCount <= 256 then
                // Short strings: rent from pool to avoid per-call allocation
                let rentedBuf = ArrayPool<byte>.Shared.Rent(maxByteCount)
                let actualLen = System.Text.Encoding.UTF8.GetBytes(value, 0, value.Length, rentedBuf, 0)
                let len = actualLen
                if len < 254 then
                    ensureCapacity (1 + len + 3)
                    buffer[pos] <- byte len
                    pos <- pos + 1
                    System.Buffer.BlockCopy(rentedBuf, 0, buffer, pos, len)
                    pos <- pos + len
                    let padding = (4 - (1 + len) % 4) % 4
                    for _ in 1..padding do
                        buffer[pos] <- 0uy
                        pos <- pos + 1
                else
                    ensureCapacity (4 + len + 3)
                    buffer[pos] <- 0xFEuy
                    buffer[pos + 1] <- byte (len &&& 0xFF)
                    buffer[pos + 2] <- byte ((len >>> 8) &&& 0xFF)
                    buffer[pos + 3] <- byte ((len >>> 16) &&& 0xFF)
                    pos <- pos + 4
                    System.Buffer.BlockCopy(rentedBuf, 0, buffer, pos, len)
                    pos <- pos + len
                    let padding = (4 - (4 + len) % 4) % 4
                    for _ in 1..padding do
                        buffer[pos] <- 0uy
                        pos <- pos + 1
                ArrayPool<byte>.Shared.Return(rentedBuf)
            else
                this.WriteBytes(System.Text.Encoding.UTF8.GetBytes(value))

    member this.WriteBool(value: bool) : unit =
        if value then
            this.WriteConstructorId(TlConstants.BoolTrue)
        else
            this.WriteConstructorId(TlConstants.BoolFalse)

    member this.WriteVector(items: 'a[], writeItem: TlWriteBuffer -> 'a -> unit) : unit =
        this.WriteConstructorId(TlConstants.VectorConstructorId)
        this.WriteInt32(items.Length)
        for item in items do
            writeItem this item

    member _.WriteRawBytes(value: byte[]) : unit =
        ensureCapacity value.Length
        value.AsSpan().CopyTo(buffer.AsSpan(pos, value.Length))
        pos <- pos + value.Length

    member _.StreamPosition : int64 = int64 pos

    member _.Length : int = pos

    member _.PatchInt32(position: int64, value: int32) =
        BinaryPrimitives.WriteInt32LittleEndian(buffer.AsSpan(int position), value)

    member _.ToArray() : byte[] =
        buffer.AsSpan(0, pos).ToArray()

    /// Zero-copy view of written data. Valid only while buffer is not disposed/reset.
    member _.WrittenSpan : ReadOnlySpan<byte> = ReadOnlySpan(buffer, 0, pos)

    /// Zero-copy Memory view. Valid only while buffer is not disposed/reset.
    member _.WrittenMemory : ReadOnlyMemory<byte> = ReadOnlyMemory(buffer, 0, pos)

    /// Detach the buffer — caller takes ownership, buffer is NOT returned to pool.
    /// Use when you need the data to outlive the TlWriteBuffer.
    member _.DetachBuffer() : byte[] * int =
        let buf = buffer
        let len = pos
        buffer <- Array.empty  // prevent double-return
        pos <- 0
        (buf, len)

    /// Reset position to zero for reuse. Buffer stays rented from ArrayPool.
    member _.Reset() = pos <- 0

    interface IDisposable with
        member _.Dispose() =
            if buffer.Length > 0 then
                ArrayPool<byte>.Shared.Return(buffer)
                buffer <- Array.empty
