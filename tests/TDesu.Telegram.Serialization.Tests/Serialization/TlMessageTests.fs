namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

/// Verify that TlMessage per-layer serialize functions produce deterministic bytes.
[<TestFixture>]
type TlMessageTests() =

    let serializeWithTlMessage (m: TlMessage) (layer: int) : byte[] =
        use w = new TlWriteBuffer()
        TlMessage.serializeInt w m layer
        w.ToArray()

    let basicMsg: TlMessage = {
        MsgId = 1
        FromId = 100L
        PeerId = 200L
        PeerType = PeerTypeUser
        Text = "Hello"
        Date = 1710000000
        IsOutgoing = false
        ReplyToMsgId = None
        Media = None
        GroupedId = None
    }

    [<Test>]
    member _.``Basic message serializeLayer216 is deterministic``() =
        use w1 = new TlWriteBuffer()
        TlMessage.serializeLayer216 w1 basicMsg
        let first = w1.ToArray()
        use w2 = new TlWriteBuffer()
        TlMessage.serializeLayer216 w2 basicMsg
        let second = w2.ToArray()
        equals first second

    [<Test>]
    member _.``Basic message serializeLayer223 is deterministic``() =
        use w1 = new TlWriteBuffer()
        TlMessage.serializeLayer223 w1 basicMsg
        let first = w1.ToArray()
        use w2 = new TlWriteBuffer()
        TlMessage.serializeLayer223 w2 basicMsg
        let second = w2.ToArray()
        equals first second

    [<Test>]
    member _.``Basic message serialize dispatches correctly - layer 216``() =
        use w = new TlWriteBuffer()
        TlMessage.serializeLayer216 w basicMsg
        let expected = w.ToArray()
        let actual = serializeWithTlMessage basicMsg 216
        equals actual expected

    [<Test>]
    member _.``Basic message serialize dispatches correctly - layer 223``() =
        use w = new TlWriteBuffer()
        TlMessage.serializeLayer223 w basicMsg
        let expected = w.ToArray()
        let actual = serializeWithTlMessage basicMsg 223
        equals actual expected

    [<Test>]
    member _.``Outgoing message is deterministic - layer 223``() =
        let msg = { basicMsg with IsOutgoing = true }
        let first = serializeWithTlMessage msg 223
        let second = serializeWithTlMessage msg 223
        equals first second

    [<Test>]
    member _.``Message with reply is deterministic - layer 223``() =
        let msg = { basicMsg with ReplyToMsgId = Some 5 }
        let first = serializeWithTlMessage msg 223
        let second = serializeWithTlMessage msg 223
        equals first second

    [<Test>]
    member _.``Message with reply is deterministic - layer 216``() =
        let msg = { basicMsg with ReplyToMsgId = Some 5 }
        let first = serializeWithTlMessage msg 216
        let second = serializeWithTlMessage msg 216
        equals first second

    [<Test>]
    member _.``Message to chat is deterministic - layer 223``() =
        let msg = { basicMsg with PeerType = PeerTypeChat; PeerId = 300L }
        let first = serializeWithTlMessage msg 223
        let second = serializeWithTlMessage msg 223
        equals first second

    [<Test>]
    member _.``Message to channel is deterministic - layer 216``() =
        let msg = { basicMsg with PeerType = PeerTypeChannel; PeerId = 400L }
        let first = serializeWithTlMessage msg 216
        let second = serializeWithTlMessage msg 216
        equals first second

    [<Test>]
    member _.``Message with photo media is deterministic - layer 223``() =
        let msg = { basicMsg with Media = Some(MediaInfo.Photo(1001L, 2002L, 2, 640, 480, 50000)) }
        let first = serializeWithTlMessage msg 223
        let second = serializeWithTlMessage msg 223
        equals first second

    [<Test>]
    member _.``Message with document media is deterministic - layer 223``() =
        let msg = { basicMsg with Media = Some(MediaInfo.Document(3003L, 4004L, 2, "application/pdf", 100000L, "test.pdf", [DocumentAttribute.Filename "test.pdf"])) }
        let first = serializeWithTlMessage msg 223
        let second = serializeWithTlMessage msg 223
        equals first second

    [<Test>]
    member _.``Message with document media is deterministic - layer 216``() =
        let msg = { basicMsg with Media = Some(MediaInfo.Document(3003L, 4004L, 2, "application/pdf", 100000L, "test.pdf", [DocumentAttribute.Filename "test.pdf"])) }
        let first = serializeWithTlMessage msg 216
        let second = serializeWithTlMessage msg 216
        equals first second

    [<Test>]
    member _.``Message with grouped_id is deterministic - layer 223``() =
        let msg = { basicMsg with GroupedId = Some 999999L }
        let first = serializeWithTlMessage msg 223
        let second = serializeWithTlMessage msg 223
        equals first second

    [<Test>]
    member _.``Full message (all fields) is deterministic - layer 223``() =
        let msg: TlMessage = {
            MsgId = 42
            FromId = 777L
            PeerId = 888L
            PeerType = PeerTypeUser
            Text = "Full message test"
            Date = 1710001000
            IsOutgoing = true
            ReplyToMsgId = Some 10
            Media = Some(MediaInfo.Photo(5005L, 6006L, 2, 1920, 1080, 200000))
            GroupedId = Some 123456L
        }
        let first = serializeWithTlMessage msg 223
        let second = serializeWithTlMessage msg 223
        equals first second

    [<Test>]
    member _.``Layer 216 and 223 differ only in CID``() =
        // Both have flags2, so length is the same — only the 4-byte CID differs
        let b216 = serializeWithTlMessage basicMsg 216
        let b223 = serializeWithTlMessage basicMsg 223
        equals b216.Length b223.Length
        // CID bytes differ (first 4 bytes)
        Assert.That(b216.[0..3] <> b223.[0..3], "CIDs should differ between layers")
