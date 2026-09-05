namespace TDesu.Serialization

/// <summary>
/// The three lines every generated <c>Serialize</c> call site was retyping:
/// rent a <see cref="TlWriteBuffer"/>, write into it, copy the result out, dispose it.
/// </summary>
/// <remarks>
/// Every consumer of a generated TL type ended up writing
/// <c>use w = new TlWriteBuffer()</c> / <c>X.Serialize(w, v)</c> / <c>w.ToArray()</c> at each of
/// its own request sites — one project counted 11 copies of exactly that plus one private SRTP
/// helper reproducing <c>bytesOf</c> — because this package provided the buffer but not the
/// pattern of using it once and giving it back.
/// </remarks>
[<RequireQualifiedAccess>]
module Tl =
    /// Runs `write` against a fresh pooled `TlWriteBuffer` and returns the bytes it produced.
    /// The buffer is always returned to the pool, even if `write` throws.
    let build (write: TlWriteBuffer -> unit) : byte[] =
        use w = new TlWriteBuffer()
        write w
        w.ToArray()

    /// The TL encoding of `value`, for any generated type exposing
    /// `static member Serialize: TlWriteBuffer * ^T -> unit`.
    let inline bytesOf (value: ^T) : byte[] when ^T: (static member Serialize: TlWriteBuffer * ^T -> unit) =
        build (fun w -> (^T: (static member Serialize: TlWriteBuffer * ^T -> unit) (w, value)))
