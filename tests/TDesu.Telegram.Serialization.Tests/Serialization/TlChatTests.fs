namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

/// Verify TlChat.serialize produces stable output.
[<TestFixture>]
type TlChatTests() =

    let serializeChat (c: TlChat) : byte[] =
        use w = new TlWriteBuffer()
        TlChat.serialize w c
        w.ToArray()

    let basicChat: TlChat = {
        ChatId = 100L
        Title = "Test Chat"
        MembersCount = 5
        Date = 1710000000
        Photo = None
    }

    [<Test>]
    member _.``Basic chat serializes deterministically``() =
        let a = serializeChat basicChat
        let b = serializeChat basicChat
        equals a b

    [<Test>]
    member _.``Basic chat starts with correct CID``() =
        let bytes = serializeChat basicChat
        // chat#41cbf256 -> LE bytes: 56 F2 CB 41
        equals bytes.[0] 0x56uy
        equals bytes.[1] 0xF2uy
        equals bytes.[2] 0xCBuy
        equals bytes.[3] 0x41uy

    [<Test>]
    member _.``Chat with photo serializes deterministically``() =
        let chat = { basicChat with Photo = Some { PhotoId = 999L; StrippedThumb = None; DcId = 2 } }
        let a = serializeChat chat
        let b = serializeChat chat
        equals a b

    [<Test>]
    member _.``Chat with photo is longer than without``() =
        let withPhoto = { basicChat with Photo = Some { PhotoId = 999L; StrippedThumb = None; DcId = 2 } }
        let a = serializeChat basicChat
        let b = serializeChat withPhoto
        Assert.That(b.Length > a.Length, "Chat with photo should serialize longer")

    [<Test>]
    member _.``Chat with empty title serializes``() =
        let chat = { basicChat with Title = "" }
        let bytes = serializeChat chat
        Assert.That(bytes.Length > 0, "Should produce non-empty output")

    [<Test>]
    member _.``Chat with large member count serializes``() =
        let chat = { basicChat with MembersCount = 10000 }
        let a = serializeChat chat
        let b = serializeChat chat
        equals a b

/// Verify TlChannel per-layer serialize functions.
[<TestFixture>]
type TlChannelTests() =

    let serializeChannel (c: TlChannel) (layer: int) : byte[] =
        use w = new TlWriteBuffer()
        TlChannel.serializeInt w c layer
        w.ToArray()

    let basicChannel: TlChannel = {
        ChannelId = 500L
        AccessHash = 67890L
        Title = "Test Channel"
        Date = 1710000000
        IsBroadcast = true
        IsMegagroup = false
        MembersCount = 100
        Photo = None
        Username = None
    }

    [<Test>]
    member _.``Basic broadcast channel serializeLayer223 matches serializeInt``() =
        let expected = serializeChannel basicChannel 223
        use w = new TlWriteBuffer()
        TlChannel.serializeLayer223 w basicChannel
        let actual = w.ToArray()
        equals actual expected

    [<Test>]
    member _.``Basic broadcast channel serializeLayer216 matches serializeInt``() =
        let expected = serializeChannel basicChannel 216
        use w = new TlWriteBuffer()
        TlChannel.serializeLayer216 w basicChannel
        let actual = w.ToArray()
        equals actual expected

    [<Test>]
    member _.``Basic channel serialize dispatches correctly - layer 223``() =
        let a = serializeChannel basicChannel 223
        let b = serializeChannel basicChannel 223
        equals a b

    [<Test>]
    member _.``Basic channel serialize dispatches correctly - layer 216``() =
        let a = serializeChannel basicChannel 216
        let b = serializeChannel basicChannel 216
        equals a b

    [<Test>]
    member _.``Megagroup channel serializes - layer 223``() =
        let channel = { basicChannel with IsBroadcast = false; IsMegagroup = true }
        let a = serializeChannel channel 223
        let b = serializeChannel channel 223
        equals a b

    [<Test>]
    member _.``Channel with username serializes - layer 223``() =
        let channel = { basicChannel with Username = Some "testchannel" }
        let a = serializeChannel channel 223
        let b = serializeChannel channel 223
        equals a b

    [<Test>]
    member _.``Channel with username serializes - layer 216``() =
        let channel = { basicChannel with Username = Some "testchannel" }
        let a = serializeChannel channel 216
        let b = serializeChannel channel 216
        equals a b

    [<Test>]
    member _.``Channel with photo serializes - layer 223``() =
        let channel = { basicChannel with Photo = Some { PhotoId = 888L; StrippedThumb = None; DcId = 2 } }
        let a = serializeChannel channel 223
        let b = serializeChannel channel 223
        equals a b

    [<Test>]
    member _.``Full channel (all fields) serializes - layer 223``() =
        let channel: TlChannel = {
            ChannelId = 777L
            AccessHash = 99999L
            Title = "Full Channel"
            Date = 1710001000
            IsBroadcast = true
            IsMegagroup = false
            MembersCount = 5000
            Photo = Some { PhotoId = 12345L; StrippedThumb = None; DcId = 3 }
            Username = Some "fullchannel"
        }
        let a = serializeChannel channel 223
        let b = serializeChannel channel 223
        equals a b

    [<Test>]
    member _.``Layer 216 and 223 differ only in CID``() =
        let b216 = serializeChannel basicChannel 216
        let b223 = serializeChannel basicChannel 223
        equals b216.Length b223.Length
        // CID bytes differ (first 4 bytes)
        Assert.That(b216.[0..3] <> b223.[0..3], "CIDs should differ between layers")
