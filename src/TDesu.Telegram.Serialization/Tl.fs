namespace TDesu.Serialization

/// The three lines every generated `Serialize` call site was retyping: rent a `TlWriteBuffer`,
/// write into it, copy the result out, give it back. One consumer counted 11 copies of exactly that
/// plus a private SRTP helper reproducing `bytesOf`, because this package provided the pooled buffer
/// but never the pattern of using it once and returning it.
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
