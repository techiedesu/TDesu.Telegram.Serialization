namespace TDesu.Serialization.Tests

open System
open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

/// Covers the members 0.4.0 adds to `TlReadBuffer`: the bounded `(data, offset, count)` view,
/// `Slice`, `ReadSpan`, `PeekConstructorId`/`TryPeekConstructorId`, and the range-checked
/// `Position` setter. `PrimitiveTests`/`VectorTests` cover the members that already existed.
[<TestFixture>]
type TlReadBufferTests() =

    [<Test>]
    member _.``(data, offset, count) reads only the requested window``() =
        use w = new TlWriteBuffer()
        w.WriteRawBytes([| 0xFFuy; 0xFFuy |]) // leading noise outside the window
        w.WriteInt32(123456)
        w.WriteRawBytes([| 0xFFuy; 0xFFuy |]) // trailing noise outside the window
        let data = w.ToArray()

        let r = new TlReadBuffer(data, 2, 4) // exactly the int32's 4 bytes
        equals r.Length 4
        equals r.Remaining 4
        equals (r.ReadInt32()) 123456
        Assert.That(r.HasMore, Is.False)

    [<Test>]
    member _.``(data, offset, count) rejects an out-of-range window``() =
        let data = [| 1uy; 2uy; 3uy; 4uy |]
        Assert.Throws<ArgumentOutOfRangeException>(fun () -> TlReadBuffer(data, -1, 2) |> ignore) |> ignore
        Assert.Throws<ArgumentOutOfRangeException>(fun () -> TlReadBuffer(data, 0, -1) |> ignore) |> ignore
        Assert.Throws<ArgumentOutOfRangeException>(fun () -> TlReadBuffer(data, 3, 2) |> ignore) |> ignore
        Assert.Throws<ArgumentOutOfRangeException>(fun () -> TlReadBuffer(data, 5, 0) |> ignore) |> ignore

    [<Test>]
    member _.``Position is 0-based within the view, not an index into the shared array``() =
        let data = [| 9uy; 9uy; 1uy; 2uy; 3uy |]
        let r = new TlReadBuffer(data, 2, 3)
        equals r.Position 0
        r.ReadRawBytes(1) |> ignore
        equals r.Position 1

    [<Test>]
    member _.``Slice shares the array and advances the parent past the sliced region``() =
        let data = Array.init 8 (fun i -> byte i)
        let r = new TlReadBuffer(data)
        r.ReadRawBytes(2) |> ignore // parent now at position 2
        let slice = r.Slice(4) // covers data[2..5]
        equals r.Position 6 // parent advanced past the sliced region
        equals slice.Length 4

        // Mutate the original array in place; the slice reads through the same backing array
        // rather than a copy taken at Slice() time, so it must observe the mutation.
        data[2] <- 0xFFuy
        equals (slice.ReadRawBytes(1)) [| 0xFFuy |]

    [<Test>]
    member _.``Slice is bounded like every other read, and restores Position on failure``() =
        let r = new TlReadBuffer([| 1uy; 2uy |])
        Assert.Throws<TlFormatException>(fun () -> r.Slice(3) |> ignore) |> ignore
        equals r.Position 0

    [<Test>]
    member _.``ReadSpan reads without copying and advances the cursor``() =
        let data = [| 1uy; 2uy; 3uy; 4uy |]
        let r = new TlReadBuffer(data)
        let span = r.ReadSpan(2)
        equals (span.ToArray()) [| 1uy; 2uy |]
        equals r.Position 2

    [<Test>]
    member _.``ReadSpan is bounded like every other read``() =
        let r = new TlReadBuffer([| 1uy; 2uy |])
        Assert.Throws<TlFormatException>(fun () -> (r.ReadSpan 10).Length |> ignore) |> ignore
        equals r.Position 0

    [<Test>]
    member _.``PeekConstructorId does not advance and matches the following ReadConstructorId``() =
        use w = new TlWriteBuffer()
        w.WriteConstructorId(0x12345678u)
        w.WriteInt32(42)
        let data = w.ToArray()

        let r = new TlReadBuffer(data)
        equals (r.PeekConstructorId()) 0x12345678u
        equals r.Position 0 // still at the start
        equals (r.PeekConstructorId()) 0x12345678u // repeatable
        equals (r.ReadConstructorId()) 0x12345678u // actually consumes it
        equals r.Position 4

    [<Test>]
    member _.``PeekConstructorId is bounded``() =
        let r = new TlReadBuffer([| 1uy; 2uy; 3uy |])
        Assert.Throws<TlFormatException>(fun () -> r.PeekConstructorId() |> ignore) |> ignore
        equals r.Position 0

    [<Test>]
    member _.``TryPeekConstructorId returns ValueNone on a short buffer without advancing``() =
        let r = new TlReadBuffer([| 1uy; 2uy; 3uy |])
        equals (r.TryPeekConstructorId ()) ValueNone
        equals r.Position 0

    [<Test>]
    member _.``TryPeekConstructorId returns ValueSome without advancing``() =
        use w = new TlWriteBuffer()
        w.WriteConstructorId(0xABCDEF01u)
        let data = w.ToArray()

        let r = new TlReadBuffer(data)
        equals (r.TryPeekConstructorId ()) (ValueSome 0xABCDEF01u)
        equals r.Position 0
