namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

[<TestFixture>]
type VectorTests() =

    [<Test>]
    member _.``WriteVector and ReadVector int32 round-trip``() =
        let items = [| 1; 2; 3; 4; 5 |]
        use w = new TlWriteBuffer()
        w.WriteVector(items, fun w v -> w.WriteInt32(v))
        let data = w.ToArray()

        let r = new TlReadBuffer(data)
        let result = r.ReadVector(fun r -> r.ReadInt32())
        equals result items

    [<Test>]
    member _.``WriteVector and ReadVector int64 round-trip``() =
        let items = [| 100L; 200L; 300L |]
        use w = new TlWriteBuffer()
        w.WriteVector(items, fun w v -> w.WriteInt64(v))
        let data = w.ToArray()

        let r = new TlReadBuffer(data)
        let result = r.ReadVector(fun r -> r.ReadInt64())
        equals result items

    [<Test>]
    member _.``WriteVector empty array``() =
        let items: int32 array = [||]
        use w = new TlWriteBuffer()
        w.WriteVector(items, fun w v -> w.WriteInt32(v))
        let data = w.ToArray()

        let r = new TlReadBuffer(data)
        let result = r.ReadVector(fun r -> r.ReadInt32())
        Assert.That(result, Is.Empty)

    [<Test>]
    member _.``WriteVector strings round-trip``() =
        let items = [| "hello"; "world"; "test" |]
        use w = new TlWriteBuffer()
        w.WriteVector(items, fun w v -> w.WriteString(v))
        let data = w.ToArray()

        let r = new TlReadBuffer(data)
        let result = r.ReadVector(fun r -> r.ReadString())
        equals result items

    [<Test>]
    member _.``Vector starts with correct constructor id``() =
        use w = new TlWriteBuffer()
        w.WriteVector([| 1 |], fun w v -> w.WriteInt32(v))
        let data = w.ToArray()

        // First 4 bytes should be vector constructor id 0x1cb5c415
        let constructorId = System.BitConverter.ToUInt32(data, 0)
        equals constructorId 0x1cb5c415u

    [<Test>]
    member _.``ReadVector rejects a lying count without allocating``() =
        // Body: vector ctor id (4 bytes) + a count claiming 200_000_000 elements (4 bytes),
        // with zero element bytes following - the reported repro underrun shape.
        use w = new TlWriteBuffer()
        w.WriteConstructorId(0x1cb5c415u)
        w.WriteInt32(200_000_000)
        let data = w.ToArray()

        let r = new TlReadBuffer(data)
        let ex = Assert.Throws<TlFormatException>(fun () ->
            r.ReadVector(fun r -> r.ReadInt32()) |> ignore)
        Assert.That(ex.Message, Does.Contain("200000000"))
        Assert.That(ex.Message, Does.Contain("0 bytes remain"))

    [<Test>]
    member _.``ReadVector rejects an unknown constructor id``() =
        use w = new TlWriteBuffer()
        w.WriteConstructorId(0xDEADBEEFu)
        let data = w.ToArray()

        let r = new TlReadBuffer(data)
        Assert.Throws<TlFormatException>(fun () -> r.ReadVector(fun r -> r.ReadInt32()) |> ignore)
        |> ignore
