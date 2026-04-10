namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

[<TestFixture>]
type PrimitiveTests() =

    [<Test>]
    member _.``WriteInt32 and ReadInt32 round-trip``() =
        use w = new TlWriteBuffer()
        w.WriteInt32(42)
        w.WriteInt32(-1)
        w.WriteInt32(0)
        w.WriteInt32(System.Int32.MaxValue)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        equals (r.ReadInt32()) 42
        equals (r.ReadInt32()) -1
        equals (r.ReadInt32()) 0
        equals (r.ReadInt32()) System.Int32.MaxValue

    [<Test>]
    member _.``WriteInt64 and ReadInt64 round-trip``() =
        use w = new TlWriteBuffer()
        w.WriteInt64(123456789L)
        w.WriteInt64(-1L)
        w.WriteInt64(System.Int64.MaxValue)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        equals (r.ReadInt64()) 123456789L
        equals (r.ReadInt64()) -1L
        equals (r.ReadInt64()) System.Int64.MaxValue

    [<Test>]
    member _.``WriteDouble and ReadDouble round-trip``() =
        use w = new TlWriteBuffer()
        w.WriteDouble(3.14)
        w.WriteDouble(-0.0)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        equals (r.ReadDouble()) 3.14
        equals (r.ReadDouble()) -0.0

    [<Test>]
    member _.``WriteString and ReadString round-trip short string``() =
        use w = new TlWriteBuffer()
        w.WriteString("hello")
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        equals (r.ReadString()) "hello"

    [<Test>]
    member _.``WriteString empty string``() =
        use w = new TlWriteBuffer()
        w.WriteString("")
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        equals (r.ReadString()) ""

    [<Test>]
    member _.``WriteBytes and ReadBytes short bytes (len=253)``() =
        let original = Array.init 253 (fun i -> byte (i % 256))
        use w = new TlWriteBuffer()
        w.WriteBytes(original)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        let result = r.ReadBytes()
        equals result original

    [<Test>]
    member _.``WriteBytes and ReadBytes long bytes (len=254)``() =
        let original = Array.init 254 (fun i -> byte (i % 256))
        use w = new TlWriteBuffer()
        w.WriteBytes(original)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        let result = r.ReadBytes()
        equals result original

    [<Test>]
    member _.``WriteBytes and ReadBytes very long bytes (len=1000)``() =
        let original = Array.init 1000 (fun i -> byte (i % 256))
        use w = new TlWriteBuffer()
        w.WriteBytes(original)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        let result = r.ReadBytes()
        equals result original

    [<Test>]
    member _.``WriteBool true and false round-trip``() =
        use w = new TlWriteBuffer()
        w.WriteBool(true)
        w.WriteBool(false)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        Assert.That(r.ReadBool(), Is.True)
        Assert.That(r.ReadBool(), Is.False)

    [<Test>]
    member _.``WriteInt128 and ReadInt128 round-trip``() =
        let original = Array.init 16 (fun i -> byte i)
        use w = new TlWriteBuffer()
        w.WriteInt128(original)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        let result = r.ReadInt128()
        equals result original

    [<Test>]
    member _.``WriteInt256 and ReadInt256 round-trip``() =
        let original = Array.init 32 (fun i -> byte i)
        use w = new TlWriteBuffer()
        w.WriteInt256(original)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        let result = r.ReadInt256()
        equals result original

    [<Test>]
    member _.``WriteConstructorId and ReadConstructorId round-trip``() =
        use w = new TlWriteBuffer()
        w.WriteConstructorId(0x997275b5u)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        equals (r.ReadConstructorId()) 0x997275b5u

    [<Test>]
    member _.``Buffer alignment - string data is 4-byte aligned``() =
        use w = new TlWriteBuffer()
        w.WriteString("hi")  // 2 bytes + 1 byte length = 3 bytes, pad to 4
        w.WriteInt32(42)
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        equals (r.ReadString()) "hi"
        equals (r.ReadInt32()) 42

    [<Test>]
    member _.``Multiple types in sequence``() =
        use w = new TlWriteBuffer()
        w.WriteInt32(1)
        w.WriteString("test")
        w.WriteInt64(999L)
        w.WriteBool(true)
        w.WriteBytes([| 0xAAuy; 0xBBuy |])
        let data = w.ToArray()

        use r = new TlReadBuffer(data)
        equals (r.ReadInt32()) 1
        equals (r.ReadString()) "test"
        equals (r.ReadInt64()) 999L
        Assert.That(r.ReadBool(), Is.True)
        equals (r.ReadBytes()) [| 0xAAuy; 0xBBuy |]
