namespace TDesu.Serialization

/// Generic vector header writer. Use this when emitting a TL `Vector<T>` payload
/// instead of hand-rolling the constructor + count.
module TlWriters =

    /// Write the standard TL vector constructor (`0x1cb5c415`) followed by `count`.
    let writeVectorHeader (w: TlWriteBuffer) (count: int) =
        w.WriteConstructorId(TlConstants.VectorConstructorId)
        w.WriteInt32(count)
