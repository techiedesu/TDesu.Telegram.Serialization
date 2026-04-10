namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.GeneratedTlWriters
open TDesu.Serialization.Tests

[<TestFixture>]
module WriteDefaultsTests =

    // ── writePeerFromType ──

    [<Test>]
    let ``writePeerFromType User`` () =
        let result = writePeerFromType PeerTypeUser 42L
        equals result (WritePeer.PeerUser 42L)

    [<Test>]
    let ``writePeerFromType Chat`` () =
        let result = writePeerFromType PeerTypeChat 99L
        equals result (WritePeer.PeerChat 99L)

    [<Test>]
    let ``writePeerFromType Channel`` () =
        let result = writePeerFromType PeerTypeChannel 77L
        equals result (WritePeer.PeerChannel 77L)

    // ── writeReplyTo ──

    [<Test>]
    let ``writeReplyTo None returns None`` () =
        equals (writeReplyTo None) None

    [<Test>]
    let ``writeReplyTo Some returns header with replyToMsgId`` () =
        match writeReplyTo (Some 42) with
        | Some h ->
            equals h.replyToMsgId (Some 42)
            equals h.forumTopic false
        | None -> Assert.Fail("Expected Some")

    // ── writeReplyToWithTopic ──

    [<Test>]
    let ``writeReplyToWithTopic None None returns None`` () =
        equals (writeReplyToWithTopic None None) None

    [<Test>]
    let ``writeReplyToWithTopic with reply and topic`` () =
        match writeReplyToWithTopic (Some 42) (Some 10) with
        | Some h ->
            equals h.replyToMsgId (Some 42)
            equals h.replyToTopId (Some 10)
            equals h.forumTopic true
        | None -> Assert.Fail("Expected Some")

    [<Test>]
    let ``writeReplyToWithTopic topic only`` () =
        match writeReplyToWithTopic None (Some 10) with
        | Some h ->
            equals h.replyToMsgId (Some 10)
            equals h.forumTopic true
        | None -> Assert.Fail("Expected Some")

    // ── writeMediaFromInfo ──

    [<Test>]
    let ``writeMediaFromInfo None returns None`` () =
        equals (writeMediaFromInfo None) None

    [<Test>]
    let ``writeMediaFromInfo Empty returns None`` () =
        equals (writeMediaFromInfo (Some MediaInfo.Empty)) None

    [<Test>]
    let ``writeMediaFromInfo Photo returns MessageMediaPhoto`` () =
        let media = writeMediaFromInfo (Some(MediaInfo.Photo(1L, 2L, 3, 640, 480, 50000)))
        match media with
        | Some(WriteMessageMedia.MessageMediaPhoto _) -> ()
        | other -> Assert.Fail($"Expected MessageMediaPhoto, got {other}")

    [<Test>]
    let ``writeMediaFromInfo Document returns MessageMediaDocument`` () =
        let media = writeMediaFromInfo (Some(MediaInfo.Document(1L, 2L, 3, "video/mp4", 1000L, "test.mp4", [])))
        match media with
        | Some(WriteMessageMedia.MessageMediaDocument _) -> ()
        | other -> Assert.Fail($"Expected MessageMediaDocument, got {other}")

    [<Test>]
    let ``writeMediaFromInfo Geo returns MessageMediaGeo`` () =
        let media = writeMediaFromInfo (Some(MediaInfo.Geo(55.75, 37.62)))
        match media with
        | Some(WriteMessageMedia.MessageMediaGeo(lat, lon)) ->
            equals lat 55.75
            equals lon 37.62
        | other -> Assert.Fail($"Expected MessageMediaGeo, got {other}")

    // ── writePhotoFromTuple ──

    [<Test>]
    let ``writePhotoFromTuple None returns None`` () =
        equals (writePhotoFromTuple None) None

    [<Test>]
    let ``writePhotoFromTuple Some returns params`` () =
        match writePhotoFromTuple (Some(100L, 200L, 2)) with
        | Some p ->
            equals p.photoId 100L
            equals p.dcId 2
        | None -> Assert.Fail("Expected Some")

    // ── writeStatusFromTlStatus ──

    [<Test>]
    let ``writeStatusFromTlStatus None returns None`` () =
        equals (writeStatusFromTlStatus None) None

    [<Test>]
    let ``writeStatusFromTlStatus Online`` () =
        match writeStatusFromTlStatus (Some(UserStatus.Online 1700000000)) with
        | Some(WriteUserStatus.UserStatusOnline expires) ->
            equals expires 1700000000
        | other -> Assert.Fail($"Expected UserStatusOnline, got {other}")

    [<Test>]
    let ``writeStatusFromTlStatus Offline`` () =
        match writeStatusFromTlStatus (Some(UserStatus.Offline 1699999999)) with
        | Some(WriteUserStatus.UserStatusOffline wasOnline) ->
            equals wasOnline 1699999999
        | other -> Assert.Fail($"Expected UserStatusOffline, got {other}")

    [<Test>]
    let ``writeStatusFromTlStatus Recently`` () =
        match writeStatusFromTlStatus (Some UserStatus.Recently) with
        | Some(WriteUserStatus.UserStatusRecently _) -> ()
        | other -> Assert.Fail($"Expected UserStatusRecently, got {other}")

    // ── writeChatPhotoFromTuple ──

    [<Test>]
    let ``writeChatPhotoFromTuple None returns ChatPhotoEmpty`` () =
        match writeChatPhotoFromTuple None with
        | WriteChatPhoto.ChatPhotoEmpty -> ()
        | other -> Assert.Fail($"Expected ChatPhotoEmpty, got {other}")

    [<Test>]
    let ``writeChatPhotoFromTuple Some returns ChatPhoto`` () =
        match writeChatPhotoFromTuple (Some(100L, 200L, 2)) with
        | WriteChatPhoto.ChatPhoto(_, photoId, _, dcId) ->
            equals photoId 100L
            equals dcId 2
        | other -> Assert.Fail($"Expected ChatPhoto, got {other}")

    // ── rpcError ──

    [<Test>]
    let ``rpcError serializes correctly`` () =
        let data = rpcError 400 "FLOOD_WAIT_60"
        let r = new TlReadBuffer(data)
        equals (r.ReadConstructorId()) 0x2144CA19u
        equals (r.ReadInt32()) 400
        equals (r.ReadString()) "FLOOD_WAIT_60"

    // ── defaults have expected structure ──

    [<Test>]
    let ``defaultWriteUser has id=0`` () =
        equals defaultWriteUser.id 0L

    [<Test>]
    let ``defaultWriteMessage has id=0 and empty message`` () =
        equals defaultWriteMessage.id 0
        equals defaultWriteMessage.message ""
