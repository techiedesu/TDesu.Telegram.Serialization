namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

[<TestFixture>]
module TlParsersTests =

    let private writeAndParse (writeFn: TlWriteBuffer -> unit) (parseFn: TlReadBuffer -> 'a) =
        use w = new TlWriteBuffer()
        writeFn w
        let reader = new TlReadBuffer(w.ToArray())
        parseFn reader

    // ── readInputPeer ──

    [<Test>]
    let ``readInputPeer: Self`` () =
        let result = writeAndParse
                        (fun w -> w.WriteConstructorId(GeneratedCid.InputPeerSelf))
                        TlParsers.readInputPeer
        equals result Self

    [<Test>]
    let ``readInputPeer: Empty`` () =
        let result = writeAndParse
                        (fun w -> w.WriteConstructorId(0x7f3b18eau))
                        TlParsers.readInputPeer
        equals result PeerEmpty

    [<Test>]
    let ``readInputPeer: User`` () =
        let result = writeAndParse
                        (fun w ->
                            w.WriteConstructorId(GeneratedCid.InputPeerUser)
                            w.WriteInt64(42L)
                            w.WriteInt64(123L))
                        TlParsers.readInputPeer
        equals result (User(42L, 123L))

    [<Test>]
    let ``readInputPeer: Chat`` () =
        let result = writeAndParse
                        (fun w ->
                            w.WriteConstructorId(GeneratedCid.InputPeerChat)
                            w.WriteInt64(99L))
                        TlParsers.readInputPeer
        equals result (Chat 99L)

    [<Test>]
    let ``readInputPeer: Channel`` () =
        let result = writeAndParse
                        (fun w ->
                            w.WriteConstructorId(GeneratedCid.InputPeerChannel)
                            w.WriteInt64(77L)
                            w.WriteInt64(456L))
                        TlParsers.readInputPeer
        equals result (Channel(77L, 456L))

    [<Test>]
    let ``readInputPeer: unknown CID`` () =
        let result = writeAndParse
                        (fun w -> w.WriteConstructorId(0xDEADBEEFu))
                        TlParsers.readInputPeer
        equals result (PeerUnknown 0xDEADBEEFu)

    // ── readInputReplyTo ──

    [<Test>]
    let ``readInputReplyTo: minimal (no optional fields)`` () =
        let result = writeAndParse
                        (fun w ->
                            w.WriteConstructorId(GeneratedCid.InputReplyToMessage)
                            w.WriteInt32(0) // flags = 0
                            w.WriteInt32(42)) // replyToMsgId
                        TlParsers.readInputReplyTo
        equals result (ReplyToMessage(42, None))

    [<Test>]
    let ``readInputReplyTo: with topMsgId (flag bit 0)`` () =
        let result = writeAndParse
                        (fun w ->
                            w.WriteConstructorId(GeneratedCid.InputReplyToMessage)
                            w.WriteInt32(1) // flags = bit 0 set
                            w.WriteInt32(42) // replyToMsgId
                            w.WriteInt32(10)) // topMsgId
                        TlParsers.readInputReplyTo
        equals result (ReplyToMessage(42, Some 10))

    [<Test>]
    let ``readInputReplyTo: unknown CID returns ReplyToNone`` () =
        let result = writeAndParse
                        (fun w -> w.WriteConstructorId(0xDEADBEEFu))
                        TlParsers.readInputReplyTo
        equals result ReplyToNone

    [<Test>]
    let ``readInputReplyTo: alternate CIDs work`` () =
        for cid in [ GeneratedCid.InputReplyToMessage1; GeneratedCid.InputReplyToMessage2 ] do
            let result = writeAndParse
                            (fun w ->
                                w.WriteConstructorId(cid)
                                w.WriteInt32(0)
                                w.WriteInt32(7))
                            TlParsers.readInputReplyTo
            equals result (ReplyToMessage(7, None))

    // ── readInputFile ──

    [<Test>]
    let ``readInputFile: InputFile`` () =
        let result = writeAndParse
                        (fun w ->
                            w.WriteConstructorId(GeneratedCid.InputFile)
                            w.WriteInt64(100L)
                            w.WriteInt32(5)
                            w.WriteString("photo.jpg")
                            w.WriteString("abc123"))
                        TlParsers.readInputFile
        equals result (TlParsers.InputFile(100L, 5, "photo.jpg", "abc123"))

    [<Test>]
    let ``readInputFile: InputFileBig`` () =
        let result = writeAndParse
                        (fun w ->
                            w.WriteConstructorId(GeneratedCid.InputFileBig)
                            w.WriteInt64(200L)
                            w.WriteInt32(10)
                            w.WriteString("video.mp4"))
                        TlParsers.readInputFile
        equals result (TlParsers.InputFileBig(200L, 10, "video.mp4"))

    [<Test>]
    let ``readInputFile: unknown CID throws`` () =
        Assert.Throws<System.Exception>(fun () ->
            writeAndParse
                (fun w -> w.WriteConstructorId(0xDEADBEEFu))
                TlParsers.readInputFile
            |> ignore)
        |> ignore

    // ── readSendMessage (via generated Deserialize) ──

    [<Test>]
    let ``readSendMessage: minimal message`` () =
        use w = new TlWriteBuffer()
        Requests.MessagesSendMessage.Serialize(w,
            { noWebpage = false; silent = false; background = false
              clearDraft = false; noforwards = false; updateStickersetsOrder = false; invertMedia = false
              allowPaidFloodskip = false
              peer = Requests.InputPeer.InputPeerSelf
              replyTo = None; message = "hello"; randomId = 777L
              replyMarkup = None; entities = None; scheduleDate = None
              sendAs = None; quickReplyShortcut = None; effect = None
              allowPaidStars = None; suggestedPost = None })
        let body = w.ToArray()
        let parsed = TlParsers.readSendMessage body
        equals parsed.Peer Self
        equals parsed.Message "hello"
        equals parsed.RandomId 777L
        equals parsed.ReplyTo ReplyToNone
        equals parsed.ScheduleDate None
        equals parsed.ReplyMarkupBytes None

    [<Test>]
    let ``readSendMessage: with schedule date`` () =
        use w = new TlWriteBuffer()
        Requests.MessagesSendMessage.Serialize(w,
            { noWebpage = false; silent = false; background = false
              clearDraft = false; noforwards = false; updateStickersetsOrder = false; invertMedia = false
              allowPaidFloodskip = false
              peer = Requests.InputPeer.InputPeerChat(42L)
              replyTo = None; message = "later"; randomId = 888L
              replyMarkup = None; entities = None; scheduleDate = Some 1700000000
              sendAs = None; quickReplyShortcut = None; effect = None
              allowPaidStars = None; suggestedPost = None })
        let body = w.ToArray()
        let parsed = TlParsers.readSendMessage body
        equals parsed.Peer (Chat 42L)
        equals parsed.ScheduleDate (Some 1700000000)

    // ── readGetHistory ──

    [<Test>]
    let ``readGetHistory: round-trip via Serialize`` () =
        use w = new TlWriteBuffer()
        Requests.MessagesGetHistory.Serialize(w,
            { peer = Requests.InputPeer.InputPeerUser(10L, 20L)
              offsetId = 100; offsetDate = 500; addOffset = -50
              limit = 25; maxId = 200; minId = 0; hash = 999L })
        let body = w.ToArray()
        let parsed = TlParsers.readGetHistory body
        equals parsed.Peer (User(10L, 20L))
        equals parsed.OffsetId 100
        equals parsed.OffsetDate 500
        equals parsed.AddOffset -50
        equals parsed.Limit 25
        equals parsed.MaxId 200
        equals parsed.MinId 0
        equals parsed.Hash 999L
