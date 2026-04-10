namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

[<TestFixture>]
module ResponseEnvelopeTests =

    let private readCid (data: byte[]) =
        let reader = new TlReadBuffer(data)
        reader.ReadConstructorId()

    // ── updates ──

    [<Test>]
    let ``emptyUpdates has Updates CID`` () =
        let data = emptyUpdates 1000 1
        equals (readCid data) GeneratedCid.Updates

    [<Test>]
    let ``emptyUpdates contains date and seq`` () =
        let data = emptyUpdates 1000 42
        let r = new TlReadBuffer(data)
        r.ReadConstructorId() |> ignore // CID
        // 3 empty vectors (each = vectorCid + count=0 = 8 bytes)
        for _ in 1..3 do
            r.ReadConstructorId() |> ignore
            equals (r.ReadInt32()) 0
        equals (r.ReadInt32()) 1000 // date
        equals (r.ReadInt32()) 42   // seq

    [<Test>]
    let ``singleUpdateResponse has one update in vector`` () =
        let data = singleUpdateResponse (fun w -> w.WriteInt32(999)) 100 1
        let r = new TlReadBuffer(data)
        r.ReadConstructorId() |> ignore // Updates CID
        r.ReadConstructorId() |> ignore // vector CID
        equals (r.ReadInt32()) 1        // count = 1

    // ── messages ──

    [<Test>]
    let ``emptyMessages has Messages CID`` () =
        let data = emptyMessages ()
        equals (readCid data) GeneratedCid.Messages

    [<Test>]
    let ``emptyMessages has 4 empty vectors`` () =
        let data = emptyMessages ()
        let r = new TlReadBuffer(data)
        r.ReadConstructorId() |> ignore
        for _ in 1..4 do
            r.ReadConstructorId() |> ignore
            equals (r.ReadInt32()) 0

    [<Test>]
    let ``messagesSliceResponse has MessagesSlice CID and count`` () =
        let data = messagesSliceResponse 42 noItems noItems noItems noItems
        let r = new TlReadBuffer(data)
        equals (r.ReadConstructorId()) GeneratedCid.MessagesSlice
        r.ReadInt32() |> ignore // flags
        equals (r.ReadInt32()) 42 // count

    [<Test>]
    let ``channelMessagesResponse has correct CID, pts, count`` () =
        let data = channelMessagesResponse 100 50 noItems noItems noItems
        let r = new TlReadBuffer(data)
        equals (r.ReadConstructorId()) GeneratedCid.MessagesChannelMessages
        r.ReadInt32() |> ignore // flags
        equals (r.ReadInt32()) 100 // pts
        equals (r.ReadInt32()) 50  // count

    [<Test>]
    let ``messagesChatsResponse has MessagesChats CID`` () =
        let data = messagesChatsResponse noItems
        equals (readCid data) GeneratedCid.MessagesChats

    [<Test>]
    let ``dialogsResponse has MessagesDialogs CID`` () =
        let data = dialogsResponse noItems noItems noItems noItems
        equals (readCid data) GeneratedCid.MessagesDialogs

    [<Test>]
    let ``peerDialogsResponse has MessagesPeerDialogs CID`` () =
        let data = peerDialogsResponse noItems noItems noItems noItems (fun _ -> ())
        equals (readCid data) GeneratedCid.MessagesPeerDialogs

    [<Test>]
    let ``authAuthorizationResponse has AuthAuthorization CID and flags=0`` () =
        let data = authAuthorizationResponse (fun _ -> ())
        let r = new TlReadBuffer(data)
        equals (r.ReadConstructorId()) GeneratedCid.AuthAuthorization
        equals (r.ReadInt32()) 0 // flags

    [<Test>]
    let ``contactsFoundResponse has ContactsFound CID`` () =
        let data = contactsFoundResponse noItems noItems noItems noItems
        equals (readCid data) GeneratedCid.ContactsFound

    [<Test>]
    let ``rpcError has correct CID, code, message`` () =
        let data = rpcError 400 "PEER_ID_INVALID"
        let r = new TlReadBuffer(data)
        equals (r.ReadConstructorId()) 0x2144CA19u
        equals (r.ReadInt32()) 400
        equals (r.ReadString()) "PEER_ID_INVALID"

    // ── zero-copy variants ──

    [<Test>]
    let ``writeUpdatesTo matches updatesResponse`` () =
        let allocating = updatesResponse noItems noItems noItems 500 10
        use w = new TlWriteBuffer()
        writeUpdatesTo w noItems noItems noItems 500 10
        let zeroCopy = w.ToArray()
        equals zeroCopy allocating

    [<Test>]
    let ``writeMessagesTo matches messagesResponse`` () =
        let allocating = messagesResponse noItems noItems noItems noItems
        use w = new TlWriteBuffer()
        writeMessagesTo w noItems noItems noItems noItems
        let zeroCopy = w.ToArray()
        equals zeroCopy allocating
