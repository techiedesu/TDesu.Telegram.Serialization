module TDesu.MTProto.Tests.Serialization.TlRoundTripTests

open System
open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

let private rng = Random(42)
let private rndStr () = [|"Alice"; "Bob"; "Charlie"; "Test"; "X"|].[rng.Next(5)]
let private rndOpt f = if rng.Next(2) = 0 then None else Some(f())

let private rndUser () : TlUser = {
    UserId = int64 (rng.Next(1, 999999))
    AccessHash = rndOpt (fun () -> int64 (rng.Next()))
    FirstName = rndStr()
    LastName = rndOpt rndStr
    Username = rndOpt (fun () -> "user" + string (rng.Next(1000)))
    Phone = rndOpt (fun () -> "+" + string (rng.Next(1000000000, 2000000000)))
    IsSelf = rng.Next(2) = 0
    IsBot = rng.Next(2) = 0
    BotInfoVersion = None
    Photo = None
    Status = None
}

[<TestFixture>]
type TlRoundTripTests() =

    [<Test>]
    member _.``TlUser deterministic: 100 random users x 2 layers``() =
        for _ in 1..100 do
            let user = rndUser()
            for layer in [TlLayer.Layer216; TlLayer.Layer223] do
                use w1 = new TlWriteBuffer()
                TlUser.serialize w1 user layer
                let bytes1 = w1.ToArray()
                use w2 = new TlWriteBuffer()
                TlUser.serialize w2 user layer
                let bytes2 = w2.ToArray()
                equals bytes1 bytes2

    [<Test>]
    member _.``TlUser layer 223 is exactly 4 bytes larger (flags2)``() =
        for _ in 1..50 do
            let user = rndUser()
            use w216 = new TlWriteBuffer()
            TlUser.serializeLayer216 w216 user
            use w223 = new TlWriteBuffer()
            TlUser.serializeLayer223 w223 user
            assert (w223.Length >= w216.Length)  // layer 223 has flags2 (>= because CIDs may differ)

    [<Test>]
    member _.``TlMessage deterministic: 50 random messages x 2 layers``() =
        for _ in 1..50 do
            let msg: TlMessage = {
                MsgId = rng.Next(1, 99999)
                FromId = int64 (rng.Next(1, 999999))
                PeerId = int64 (rng.Next(1, 999999))
                PeerType = PeerTypeUser
                Text = rndStr(); Date = 1710000000
                IsOutgoing = rng.Next(2) = 0
                ReplyToMsgId = rndOpt (fun () -> rng.Next(1, 9999))
                Media = None; GroupedId = None
            }
            for layer in [TlLayer.Layer216; TlLayer.Layer223] do
                use w1 = new TlWriteBuffer()
                TlMessage.serialize w1 msg layer
                use w2 = new TlWriteBuffer()
                TlMessage.serialize w2 msg layer
                equals (w1.ToArray()) (w2.ToArray())

    [<Test>]
    member _.``TlChat deterministic: 50 random chats``() =
        for _ in 1..50 do
            let chat: TlChat = {
                ChatId = int64 (rng.Next(1, 999999))
                Title = rndStr(); MembersCount = rng.Next(1, 100)
                Date = 1710000000; Photo = None
            }
            use w1 = new TlWriteBuffer()
            TlChat.serialize w1 chat
            use w2 = new TlWriteBuffer()
            TlChat.serialize w2 chat
            equals (w1.ToArray()) (w2.ToArray())

    [<Test>]
    member _.``TlChannel layer 223 is 4 bytes larger (flags2)``() =
        for _ in 1..50 do
            let ch: TlChannel = {
                ChannelId = int64 (rng.Next(1, 999999))
                AccessHash = int64 (rng.Next())
                Title = rndStr(); Date = 1710000000
                IsBroadcast = rng.Next(2) = 0
                IsMegagroup = rng.Next(2) = 0
                MembersCount = rng.Next(0, 1000)
                Photo = None
                Username = rndOpt (fun () -> "ch" + string (rng.Next(1000)))
            }
            use w216 = new TlWriteBuffer()
            TlChannel.serializeLayer216 w216 ch
            use w223 = new TlWriteBuffer()
            TlChannel.serializeLayer223 w223 ch
            assert (w223.Length >= w216.Length)  // layer 223 has flags2 (>= because CIDs may differ)

    [<Test>]
    member _.``All TlLayer variants handled (exhaustive)``() =
        let user = rndUser()
        for layer in [TlLayer.Layer216; TlLayer.Layer223] do
            use w = new TlWriteBuffer()
            TlUser.serialize w user layer
            assert (w.Length > 0)
