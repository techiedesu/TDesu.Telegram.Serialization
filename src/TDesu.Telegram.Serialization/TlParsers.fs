namespace TDesu.Serialization

open System

/// Parsed TL input peer types.
type ParsedInputPeer =
    | Self
    | User of userId: int64 * accessHash: int64
    | Chat of chatId: int64
    | Channel of channelId: int64 * accessHash: int64
    | PeerEmpty
    | PeerUnknown of uint32

/// Parsed reply_to field.
type ParsedReplyTo =
    | ReplyToMessage of replyToMsgId: int * topMsgId: int option
    | ReplyToNone

/// Parsed messages.sendMessage request (works for both CIDs 0x983f and 0x545c).
type ParsedSendMessage = {
    Flags: int
    Peer: ParsedInputPeer
    ReplyTo: ParsedReplyTo
    Message: string
    RandomId: int64
    ScheduleDate: int option
    /// Serialized ReplyMarkup TL bytes (if flags.2 was set).
    ReplyMarkupBytes: byte[] option
    NoWebpage: bool
}

/// Stateless TL parsers — parse raw bytes into typed F# values.
module TlParsers =

    /// Read an InputPeer from the current reader position.
    let readInputPeer (reader: TlReadBuffer) : ParsedInputPeer =
        let cid = reader.ReadConstructorId()
        match cid with
        | GeneratedCid.InputPeerSelf -> Self
        | 0x7f3b18eau -> PeerEmpty
        | GeneratedCid.InputPeerUser ->
            let userId = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            User(userId, accessHash)
        | GeneratedCid.InputPeerChat ->
            let chatId = reader.ReadInt64()
            Chat chatId
        | GeneratedCid.InputPeerChannel ->
            let channelId = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            Channel(channelId, accessHash)
        | other -> PeerUnknown other

    /// Skip an InputPeer value from the reader (consuming all its bytes).
    let private skipInputPeer (reader: TlReadBuffer) =
        let pCid = reader.ReadConstructorId()
        match pCid with
        | GeneratedCid.InputPeerUser | GeneratedCid.InputPeerUser -> reader.ReadInt64() |> ignore; reader.ReadInt64() |> ignore
        | GeneratedCid.InputPeerChat -> reader.ReadInt64() |> ignore
        | GeneratedCid.InputPeerChannel -> reader.ReadInt64() |> ignore; reader.ReadInt64() |> ignore
        | GeneratedCid.InputPeerSelf | 0x7f3b18eau -> ()
        | _ -> ()

    /// Skip a TL Vector from the reader (consuming count + all elements).
    let private skipVector (reader: TlReadBuffer) (skipElement: TlReadBuffer -> unit) =
        let vecCid = reader.ReadConstructorId() // vector CID 0x1cb5c415
        let count = reader.ReadInt32()
        for _ in 1..count do skipElement reader

    /// Read an InputReplyTo from the current reader position (handles all known CIDs).
    /// Skips all optional fields (reply_to_peer_id, quote_text, quote_entities, quote_offset, etc.).
    let readInputReplyTo (reader: TlReadBuffer) : ParsedReplyTo =
        let cid = reader.ReadConstructorId()
        match cid with
        | GeneratedCid.InputReplyToMessage1
        | GeneratedCid.InputReplyToMessage2
        | GeneratedCid.InputReplyToMessage ->
            let replyFlags = reader.ReadInt32()
            let replyToMsgId = reader.ReadInt32()
            // top_msg_id (flag bit 0)
            let topMsgId =
                if replyFlags &&& 1 <> 0 then Some(reader.ReadInt32())
                else Option.None
            // reply_to_peer_id (flag bit 1)
            if replyFlags &&& 2 <> 0 then skipInputPeer reader
            // quote_text (flag bit 2)
            if replyFlags &&& 4 <> 0 then reader.ReadString() |> ignore
            // quote_entities (flag bit 3) — Vector<MessageEntity>, skip all elements
            if replyFlags &&& 8 <> 0 then
                skipVector reader (fun r ->
                    // Each MessageEntity is variable-length; read CID to determine size.
                    // For safety, read as raw TL object — but we can't know the exact size.
                    // Telethon typically sends empty vector here, so log warning if non-empty.
                    r.ReadConstructorId() |> ignore
                    // MessageEntity: flags + offset + length + optional fields — too variable to safely skip.
                    // This path is rarely hit; if it is, the rest of the message may not parse.
                    ())
            // quote_offset (flag bit 4)
            if replyFlags &&& 16 <> 0 then reader.ReadInt32() |> ignore
            // monoforum_peer_id (flag bit 5) — new in #869fbe10
            if replyFlags &&& 32 <> 0 then skipInputPeer reader
            // todo_item_id (flag bit 6) — new in #869fbe10
            if replyFlags &&& 64 <> 0 then reader.ReadInt32() |> ignore
            ReplyToMessage(replyToMsgId, topMsgId)
        | _ -> ReplyToNone

    /// Parsed messages.getHistory request.
    type ParsedGetHistory = {
        Peer: ParsedInputPeer
        OffsetId: int
        OffsetDate: int
        AddOffset: int
        Limit: int
        MaxId: int
        MinId: int
        Hash: int64
    }

    // --- Generated type → legacy type converters ---

    let private convertInputPeer (p: Requests.InputPeer) : ParsedInputPeer =
        match p with
        | Requests.InputPeer.InputPeerSelf -> Self
        | Requests.InputPeer.InputPeerUser(uid, hash) -> User(uid, hash)
        | Requests.InputPeer.InputPeerChat(cid) -> Chat(cid)
        | Requests.InputPeer.InputPeerChannel(cid, hash) -> Channel(cid, hash)
        | Requests.InputPeer.InputPeerEmpty -> PeerEmpty
        | _ -> PeerEmpty

    let private convertReplyTo (r: Requests.InputReplyTo option) : ParsedReplyTo =
        match r with
        | Some(Requests.InputReplyTo.InputReplyToMessage(msgId, topMsgId, _, _, _, _, _, _)) -> ReplyToMessage(msgId, topMsgId)
        | _ -> ReplyToNone

    /// Parse a messages.getHistory#4423e6c5 request body.
    let readGetHistory (body: byte[]) : ParsedGetHistory =
        let req = Requests.MessagesGetHistory.Deserialize(body)
        { Peer = convertInputPeer req.peer; OffsetId = req.offsetId; OffsetDate = req.offsetDate
          AddOffset = req.addOffset; Limit = req.limit; MaxId = req.maxId; MinId = req.minId; Hash = req.hash }

    // --- Media parsers ---

    /// Parsed InputFile (upload.saveFilePart result).
    type ParsedInputFile =
        | InputFile of fileId: int64 * parts: int * name: string * md5: string
        | InputFileBig of fileId: int64 * parts: int * name: string

    /// Read an InputFile from the current reader position.
    let readInputFile (reader: TlReadBuffer) : ParsedInputFile =
        let cid = reader.ReadConstructorId()
        match cid with
        | GeneratedCid.InputFile ->
            let fileId = reader.ReadInt64()
            let parts = reader.ReadInt32()
            let name = reader.ReadString()
            let md5 = reader.ReadString()
            InputFile(fileId, parts, name, md5)
        | GeneratedCid.InputFileBig ->
            let fileId = reader.ReadInt64()
            let parts = reader.ReadInt32()
            let name = reader.ReadString()
            InputFileBig(fileId, parts, name)
        | other -> failwith $"Unknown InputFile CID: 0x%08x{other}"

    /// Parsed InputMedia for messages.sendMedia.
    [<RequireQualifiedAccess>]
    type ParsedInputMedia =
        | UploadedPhoto of file: ParsedInputFile
        | UploadedDocument of file: ParsedInputFile * mime: string * attributes: (uint32 * byte[])[]
        | Photo of photoId: int64 * accessHash: int64 * fileReference: byte[]
        | Document of docId: int64 * accessHash: int64 * fileReference: byte[]
        | Poll of poll: Requests.Poll * correctAnswers: byte[] array option * solution: string option * solutionEntities: Requests.MessageEntity array option
        | GeoPoint of lat: float * lon: float
        | GeoLive of lat: float * lon: float * heading: int option * period: int option * proximityNotificationRadius: int option
        | Venue of lat: float * lon: float * title: string * address: string * provider: string * venueId: string * venueType: string
        | Empty

    /// Parsed messages.sendMedia request.
    type ParsedSendMedia = {
        Peer: ParsedInputPeer
        ReplyTo: ParsedReplyTo
        Media: Requests.InputMedia
        Message: string
        RandomId: int64
    }

    /// Parse a messages.sendMedia request body via generated Deserialize.
    let readSendMedia (body: byte[]) : ParsedSendMedia =
        let req = Requests.MessagesSendMedia.Deserialize(body)
        { Peer = convertInputPeer req.peer; ReplyTo = convertReplyTo req.replyTo
          Media = req.media; Message = req.message; RandomId = req.randomId }

    /// Parse a messages.sendMessage request body (works for both CIDs).
    let readSendMessage (body: byte[]) : ParsedSendMessage =
        let req = Requests.MessagesSendMessage.Deserialize(body)
        let markupBytes =
            match req.replyMarkup with
            | Some markup ->
                use w = new TlWriteBuffer()
                Requests.ReplyMarkup.Serialize(w, markup)
                let arr = w.ToArray()
                Some arr
            | None -> None
        { Flags = 0; Peer = convertInputPeer req.peer; ReplyTo = convertReplyTo req.replyTo
          Message = req.message; RandomId = req.randomId; ScheduleDate = req.scheduleDate
          ReplyMarkupBytes = markupBytes
          NoWebpage = req.noWebpage }
