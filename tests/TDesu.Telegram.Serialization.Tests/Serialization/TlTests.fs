namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

/// A stand-in for a generated TL type: the shape `Tl.bytesOf`'s SRTP constraint requires
/// (`static member Serialize: TlWriteBuffer * ^T -> unit`), without depending on a generator.
type SamplePoint = { X: int32; Y: int32 } with

    static member Serialize(w: TlWriteBuffer, value: SamplePoint) : unit =
        w.WriteInt32(value.X)
        w.WriteInt32(value.Y)

[<TestFixture>]
type TlTests() =

    [<Test>]
    member _.``build runs write against a fresh writer and returns exactly what it wrote``() =
        let bytes = Tl.build (fun w ->
            w.WriteInt32(1)
            w.WriteInt32(2))

        use expected = new TlWriteBuffer()
        expected.WriteInt32(1)
        expected.WriteInt32(2)

        equals bytes (expected.ToArray())

    [<Test>]
    member _.``build of an empty write is an empty array``() =
        equals (Tl.build (fun _ -> ())) Array.empty<byte>

    [<Test>]
    member _.``build returns an independent writer on each call``() =
        let first = Tl.build (fun w -> w.WriteInt32(1))
        let second = Tl.build (fun w -> w.WriteInt32(2))

        equals first [| 1uy; 0uy; 0uy; 0uy |]
        equals second [| 2uy; 0uy; 0uy; 0uy |]

    [<Test>]
    member _.``bytesOf matches build over the same writes``() =
        let point = { X = 7; Y = -3 }

        let expected =
            Tl.build (fun w ->
                w.WriteInt32(point.X)
                w.WriteInt32(point.Y))

        equals (Tl.bytesOf point) expected
