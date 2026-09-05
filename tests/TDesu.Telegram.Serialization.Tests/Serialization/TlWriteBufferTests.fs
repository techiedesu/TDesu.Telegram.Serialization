namespace TDesu.Serialization.Tests

open System
open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

/// Covers what 0.4.0 changes on `TlWriteBuffer`: the `ReadOnlySpan<byte>` overload of
/// `WriteRawBytes`, the length guard `WriteBytes`/`WriteString` now raise instead of silently
/// wrapping at, `WriteString`'s rewrite around the 254-byte header threshold, and that
/// `TlConstants` is public.
[<TestFixture>]
type TlWriteBufferTests() =

    [<Test>]
    member _.``WriteRawBytes span overload writes the same bytes as the array overload``() =
        let data = [| 1uy; 2uy; 3uy; 4uy |]
        use w1 = new TlWriteBuffer()
        w1.WriteRawBytes(data)

        use w2 = new TlWriteBuffer()
        w2.WriteRawBytes(ReadOnlySpan<byte>(data))

        equals (w2.ToArray()) (w1.ToArray())

    [<Test>]
    member _.``WriteRawBytes span overload writes a slice of someone else's buffer without a copy``() =
        let backing = [| 0xAAuy; 1uy; 2uy; 3uy; 0xBBuy |]
        use w = new TlWriteBuffer()
        w.WriteRawBytes(ReadOnlySpan<byte>(backing, 1, 3))
        equals (w.ToArray()) [| 1uy; 2uy; 3uy |]

    [<Test>]
    member _.``WriteBytes refuses a length of 2^24 or more instead of truncating``() =
        use w = new TlWriteBuffer()
        let tooLong = Array.zeroCreate<byte> TlConstants.MaxByteLength
        Assert.Throws<ArgumentException>(fun () -> w.WriteBytes(tooLong)) |> ignore

    [<Test>]
    member _.``WriteBytes accepts the largest length the header can encode``() =
        // One byte under the 2^24 boundary: allocates ~16 MiB but must not raise, and must
        // round-trip through ReadBytes.
        let almostTooLong = Array.zeroCreate<byte> (TlConstants.MaxByteLength - 1)
        use w = new TlWriteBuffer()
        w.WriteBytes(almostTooLong)
        let r = new TlReadBuffer(w.ToArray())
        equals (r.ReadBytes().Length) almostTooLong.Length

    [<Test>]
    member _.``WriteString refuses a length of 2^24 or more instead of truncating``() =
        use w = new TlWriteBuffer()
        let tooLong = String('x', TlConstants.MaxByteLength) // 'x' is one UTF-8 byte
        Assert.Throws<ArgumentException>(fun () -> w.WriteString(tooLong)) |> ignore

    [<Test>]
    member _.``WriteString accepts the largest length the header can encode``() =
        let almostTooLong = String('x', TlConstants.MaxByteLength - 1)
        use w = new TlWriteBuffer()
        w.WriteString(almostTooLong)
        let r = new TlReadBuffer(w.ToArray())
        equals (r.ReadString().Length) almostTooLong.Length

    [<Test>]
    member _.``WriteString round-trips lengths either side of the 254-byte header threshold``() =
        for len in [ 0; 1; 252; 253; 254; 255; 256; 300 ] do
            let s = String('x', len)
            use w = new TlWriteBuffer()
            w.WriteString(s)
            let r = new TlReadBuffer(w.ToArray())
            equals (r.ReadString()) s

    [<Test>]
    member _.``TlConstants is public and matches the well-known wire values``() =
        equals TlConstants.BoolTrue 0x997275b5u
        equals TlConstants.BoolFalse 0xbc799737u
        equals TlConstants.VectorConstructorId 0x1cb5c415u
