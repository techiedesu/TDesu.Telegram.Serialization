namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

[<TestFixture>]
module TypedResponsesTests =

    [<Test>]
    let ``boolTrue has correct CID`` () =
        let reader = new TlReadBuffer(boolTrue)
        let cid = reader.ReadConstructorId()
        equals cid GeneratedCid.BoolTrue

    [<Test>]
    let ``boolFalse has correct CID`` () =
        let reader = new TlReadBuffer(boolFalse)
        let cid = reader.ReadConstructorId()
        equals cid GeneratedCid.BoolFalse

    [<Test>]
    let ``boolTrue is exactly 4 bytes`` () =
        equals boolTrue.Length 4

    [<Test>]
    let ``boolFalse is exactly 4 bytes`` () =
        equals boolFalse.Length 4

    [<Test>]
    let ``boolTrue and boolFalse differ`` () =
        notEquals boolTrue boolFalse

    [<Test>]
    let ``boolResponse true returns boolTrue`` () =
        Assert.That(boolResponse true, Is.SameAs(boolTrue))

    [<Test>]
    let ``boolResponse false returns boolFalse`` () =
        Assert.That(boolResponse false, Is.SameAs(boolFalse))

    [<Test>]
    let ``updatesTooLong has correct CID`` () =
        let reader = new TlReadBuffer(updatesTooLong)
        let cid = reader.ReadConstructorId()
        equals cid GeneratedCid.UpdatesTooLong

    [<Test>]
    let ``updatesTooLong is exactly 4 bytes`` () =
        equals updatesTooLong.Length 4
