// Auto-generated at 3/21/2026 8:49:27 AM +07:00
// Hand-written per-layer serialize functions for TL response types.
// Types below line 150 (request deserialization) are auto-generated — do not edit.

namespace TDesu.Serialization

open TDesu.Serialization

// ---------------------------------------------------------------------------
// Per-layer response serialization types. AOT-friendly: no generics, no
// reflection. Each layered type has serializeLayer216 + serializeLayer223 +
// inline dispatch. Non-layered types have a single serialize function.
// ---------------------------------------------------------------------------

// ===== TlLayer (exhaustive DU — compiler warns on incomplete match) =====

/// Supported TL layers. Exhaustive match ensures all layers handled.
/// Adding a new layer here produces compiler warnings on all incomplete matches.
[<Struct>]
type TlLayer =
    | Layer216  // Telethon
    | Layer223  // tdesktop

module TlLayer =
    let fromInt = function
        | n when n <= 216 -> Layer216
        | _ -> Layer223

    let toInt = function
        | Layer216 -> 216
        | Layer223 -> 223

// ===== TlUserProfilePhoto (no layer variants) =====

/// userProfilePhoto#82d1f706 flags:# photo_id:long stripped_thumb:flags.1?bytes dc_id:int
type TlUserProfilePhoto = {
    PhotoId: int64
    StrippedThumb: byte[] option
    DcId: int32
}

module TlUserProfilePhoto =

    [<Literal>]
    let private Cid = 0x82D1F706u

    /// Serialize userProfilePhoto#82d1f706. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlUserProfilePhoto) =
        w.WriteConstructorId(Cid)
        let mutable flags = 0
        if v.StrippedThumb.IsSome then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        w.WriteInt64(v.PhotoId)
        match v.StrippedThumb with
        | Some bytes -> w.WriteBytes(bytes)
        | None -> ()
        w.WriteInt32(v.DcId)

// ===== TlUserStatus (no layer variants) =====

/// UserStatus variants for TlUser serialization.
[<RequireQualifiedAccess>]
type TlUserStatus =
    /// userStatusOnline#edb93949 expires:int
    | Online of expires: int32
    /// userStatusOffline#008c703f was_online:int
    | Offline of wasOnline: int32
    /// userStatusRecently#7b197dc8 flags:# by_me:flags.0?true
    | Recently of byMe: bool
    /// userStatusLastWeek#541a1d1a flags:# by_me:flags.0?true
    | LastWeek of byMe: bool
    /// userStatusLastMonth#65899777 flags:# by_me:flags.0?true
    | LastMonth of byMe: bool
    /// userStatusEmpty#09d05049
    | Empty

module TlUserStatus =

    [<Literal>]
    let private CidOnline = 0xEDB93949u
    [<Literal>]
    let private CidOffline = 0x008C703Fu
    [<Literal>]
    let private CidRecently = 0x7B197DC8u
    [<Literal>]
    let private CidLastWeek = 0x541A1D1Au
    [<Literal>]
    let private CidLastMonth = 0x65899777u
    [<Literal>]
    let private CidEmpty = 0x09D05049u

    /// Serialize any UserStatus variant. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlUserStatus) =
        match v with
        | TlUserStatus.Online expires ->
            w.WriteConstructorId(CidOnline)
            w.WriteInt32(expires)
        | TlUserStatus.Offline wasOnline ->
            w.WriteConstructorId(CidOffline)
            w.WriteInt32(wasOnline)
        | TlUserStatus.Recently byMe ->
            w.WriteConstructorId(CidRecently)
            let mutable flags = 0
            if byMe then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
        | TlUserStatus.LastWeek byMe ->
            w.WriteConstructorId(CidLastWeek)
            let mutable flags = 0
            if byMe then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
        | TlUserStatus.LastMonth byMe ->
            w.WriteConstructorId(CidLastMonth)
            let mutable flags = 0
            if byMe then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
        | TlUserStatus.Empty ->
            w.WriteConstructorId(CidEmpty)

// ===== TlChatPhoto (no layer variants — same CID across all layers) =====

/// chatPhoto#1c6e1c11 flags:# has_video:flags.0?true photo_id:long stripped_thumb:flags.1?bytes dc_id:int
type TlChatPhoto = {
    PhotoId: int64
    StrippedThumb: byte[] option
    DcId: int32
}

module TlChatPhoto =

    [<Literal>]
    let private Cid = 0x1C6E1C11u

    [<Literal>]
    let private CidEmpty = 0x37C1011Cu

    /// Serialize chatPhoto#1c6e1c11. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlChatPhoto) =
        w.WriteConstructorId(Cid)
        let mutable flags = 0
        if v.StrippedThumb.IsSome then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        w.WriteInt64(v.PhotoId)
        match v.StrippedThumb with
        | Some bytes -> w.WriteBytes(bytes)
        | None -> ()
        w.WriteInt32(v.DcId)

    /// Serialize chatPhotoEmpty#37c1011c.
    let serializeEmpty (w: TlWriteBuffer) =
        w.WriteConstructorId(CidEmpty)

// ===== TlUser (layer 216 vs 223) =====

/// Layer-aware User type for response serialization.
/// user#020b1422 (layer <=216) / user#31774388 (layer >=217)
type TlUser = {
    UserId: int64
    AccessHash: int64 option
    FirstName: string
    LastName: string option
    Username: string option
    Phone: string option
    IsSelf: bool
    IsBot: bool
    BotInfoVersion: int32 option
    Photo: TlUserProfilePhoto option
    Status: TlUserStatus option
}

module TlUser =

    [<Literal>]
    let private CidLayer216 = 0x020B1422u
    [<Literal>]
    let private CidLayer223 = 0x31774388u

    /// Compute flags (shared between both layers).
    let private computeFlags (u: TlUser) =
        let mutable flags = 0
        if u.AccessHash.IsSome then flags <- flags ||| (1 <<< 0)
        flags <- flags ||| (1 <<< 1) // first_name always present
        if u.LastName.IsSome then flags <- flags ||| (1 <<< 2)
        if u.Username.IsSome then flags <- flags ||| (1 <<< 3)
        if u.Phone.IsSome then flags <- flags ||| (1 <<< 4)
        if u.Photo.IsSome then flags <- flags ||| (1 <<< 5)
        if u.Status.IsSome then flags <- flags ||| (1 <<< 6)
        if u.IsSelf then flags <- flags ||| (1 <<< 10)
        if u.IsBot then flags <- flags ||| (1 <<< 14)
        flags <- flags ||| (1 <<< 28) // premium (flags.28) — all test-server users are premium
        flags

    /// Write fields after flags/flags2 (shared between both layers).
    let private writeFields (w: TlWriteBuffer) (u: TlUser) =
        w.WriteInt64(u.UserId)
        match u.AccessHash with Some ah -> w.WriteInt64(ah) | None -> ()
        w.WriteString(u.FirstName)
        match u.LastName with Some ln -> w.WriteString(ln) | None -> ()
        match u.Username with Some un -> w.WriteString(un) | None -> ()
        match u.Phone with Some ph -> w.WriteString(ph) | None -> ()
        match u.Photo with Some photo -> TlUserProfilePhoto.serialize w photo | None -> ()
        match u.Status with Some status -> TlUserStatus.serialize w status | None -> ()
        if u.IsBot then
            w.WriteInt32(defaultArg u.BotInfoVersion 1)

    /// Layer 216 (Telethon): user#020b1422, WITH flags2.
    /// Telethon 1.42 (layer 216) schema for CID 0x020b1422 includes flags2.
    let serializeLayer216 (w: TlWriteBuffer) (u: TlUser) =
        w.WriteConstructorId(CidLayer216)
        w.WriteInt32(computeFlags u)
        w.WriteInt32(0) // flags2 — no flags2-gated fields needed
        writeFields w u

    /// Layer 217-222: user#31774388, WITH flags2.
    let serializeLayer217 (w: TlWriteBuffer) (u: TlUser) =
        w.WriteConstructorId(CidLayer223)
        w.WriteInt32(computeFlags u)
        w.WriteInt32(0) // flags2 — no flags2-gated fields needed
        writeFields w u

    /// Layer 223 (tdesktop): user#31774388, WITH flags2.
    /// premium is flags.28 (already set in computeFlags), NOT flags2.
    let serializeLayer223 (w: TlWriteBuffer) (u: TlUser) =
        w.WriteConstructorId(CidLayer223)
        w.WriteInt32(computeFlags u)
        w.WriteInt32(0) // flags2 — no flags2-gated fields needed (premium is flags.28)
        writeFields w u

    /// Dispatch by TlLayer DU (exhaustive match).
    let serialize (w: TlWriteBuffer) (u: TlUser) (layer: TlLayer) =
        match layer with
        | Layer216 -> serializeLayer216 w u
        | Layer223 -> serializeLayer223 w u

    /// Backward-compat dispatch by int layer number.
    let serializeInt (w: TlWriteBuffer) (u: TlUser) (layer: int) =
        if layer <= 216 then serializeLayer216 w u
        elif layer < 223 then serializeLayer217 w u
        else serializeLayer223 w u

    /// Convert old-style photo tuple (photoId, stripedThumb, dcId) to TlUserProfilePhoto.
    let photoFromTuple (photo: (int64 * int64 * int) option) : TlUserProfilePhoto option =
        match photo with
        | Some(pid, _, dc) -> Some { TlUserProfilePhoto.PhotoId = pid; StrippedThumb = None; DcId = dc }
        | None -> None

    /// Convert old-style UserStatus to TlUserStatus.
    let statusFromLegacy (status: UserStatus option) : TlUserStatus option =
        match status with
        | Some(UserStatus.Online e) -> Some(TlUserStatus.Online e)
        | Some(UserStatus.Offline w) -> Some(TlUserStatus.Offline w)
        | Some UserStatus.Recently -> Some(TlUserStatus.Recently false)
        | Some UserStatus.LastWeek -> Some(TlUserStatus.LastWeek false)
        | Some UserStatus.LastMonth -> Some(TlUserStatus.LastMonth false)
        | None -> None

// ===== TlMessage (layer 216 vs 223) =====

/// Layer-aware Message type for response serialization.
/// message#9815cec8 (layer <=216) / message#3ae56482 (layer 217-221) / message#9cb490e9 (layer 222)
type TlMessage = {
    MsgId: int
    FromId: int64
    PeerId: int64
    PeerType: PeerType
    Text: string
    Date: int
    IsOutgoing: bool
    ReplyToMsgId: int option
    Media: MediaInfo option
    GroupedId: int64 option
}

module TlMessage =

    [<Literal>]
    let private CidLayer216 = 0x9815CEC8u
    [<Literal>]
    let private CidLayer223 = 0x3AE56482u
    [<Literal>]
    let private CidLayer222 = 0x9CB490E9u

    [<Literal>]
    let private CidMessageReplyHeader = 0x6917560Bu
    [<Literal>]
    let private CidPeerUser = 0x59511722u
    [<Literal>]
    let private CidPeerChat = 0x36C6019Au
    [<Literal>]
    let private CidPeerChannel = 0xA2A5371Eu
    [<Literal>]
    let private CidMessageMediaEmpty = 0x3DED6320u
    [<Literal>]
    let private CidMessageMediaPhoto = 0x695150D7u
    [<Literal>]
    let private CidPhoto = 0xFB197A65u
    [<Literal>]
    let private CidPhotoSize = 0x75C78E60u
    [<Literal>]
    let private CidVectorCid = 0x1CB5C415u
    [<Literal>]
    let private CidDocument = 0x8FD4C4D8u
    [<Literal>]
    let private CidDocumentAttributeFilename = 0x15590068u
    [<Literal>]
    let private CidDocumentAttributeImageSize = 0x6C37C15Cu
    [<Literal>]
    let private CidDocumentAttributeVideo = 0x17399FADu
    [<Literal>]
    let private CidDocumentAttributeAudio = 0x9852F9C6u
    [<Literal>]
    let private CidDocumentAttributeSticker = 0x6319D612u
    [<Literal>]
    let private CidDocumentAttributeAnimated = 0x11B58939u
    [<Literal>]
    let private CidDocumentAttributeHasStickers = 0x9801D2F7u
    [<Literal>]
    let private CidInputStickerSetEmpty = 0xFFB62B95u

    /// Write a single document attribute (local helper to avoid forward reference to TlDocument).
    let private writeDocAttribute (w: TlWriteBuffer) (attr: DocumentAttribute) =
        match attr with
        | DocumentAttribute.Filename name ->
            w.WriteConstructorId(CidDocumentAttributeFilename)
            w.WriteString(name)
        | DocumentAttribute.ImageSize(width, height) ->
            w.WriteConstructorId(CidDocumentAttributeImageSize)
            w.WriteInt32(width)
            w.WriteInt32(height)
        | DocumentAttribute.Video(duration, width, height, roundMessage, supportsStreaming) ->
            w.WriteConstructorId(CidDocumentAttributeVideo)
            let mutable flags = 0
            if roundMessage then flags <- flags ||| (1 <<< 0)
            if supportsStreaming then flags <- flags ||| (1 <<< 1)
            w.WriteInt32(flags)
            w.WriteDouble(duration)
            w.WriteInt32(width)
            w.WriteInt32(height)
        | DocumentAttribute.Audio(duration, title, performer, voice, waveform) ->
            w.WriteConstructorId(CidDocumentAttributeAudio)
            let mutable flags = 0
            if voice then flags <- flags ||| (1 <<< 10)
            if title.IsSome then flags <- flags ||| (1 <<< 0)
            if performer.IsSome then flags <- flags ||| (1 <<< 1)
            if waveform.IsSome then flags <- flags ||| (1 <<< 2)
            w.WriteInt32(flags)
            w.WriteInt32(duration)
            match title with Some t -> w.WriteString(t) | None -> ()
            match performer with Some p -> w.WriteString(p) | None -> ()
            match waveform with Some wf -> w.WriteBytes(wf) | None -> ()
        | DocumentAttribute.Sticker alt ->
            w.WriteConstructorId(CidDocumentAttributeSticker)
            w.WriteInt32(0) // flags (no mask)
            w.WriteString(alt)
            w.WriteConstructorId(CidInputStickerSetEmpty)
        | DocumentAttribute.Animated ->
            w.WriteConstructorId(CidDocumentAttributeAnimated)
        | DocumentAttribute.HasStickers ->
            w.WriteConstructorId(CidDocumentAttributeHasStickers)

    [<Literal>]
    let private CidMessageMediaDocumentOld = 0x52D8CCD9u
    [<Literal>]
    let private CidMessageMediaDocumentNew = 0x4CF4D72Du

    /// Write messageReplyHeader#6917560b (minimal: just reply_to_msg_id).
    let private writeReplyHeader (w: TlWriteBuffer) (replyToMsgId: int) =
        w.WriteConstructorId(CidMessageReplyHeader)
        w.WriteInt32(1 <<< 4) // flags: reply_to_msg_id present
        w.WriteInt32(replyToMsgId)

    /// Write peer (peerUser/peerChat/peerChannel).
    let private writePeer (w: TlWriteBuffer) (peerType: PeerType) (peerId: int64) =
        match peerType with
        | PeerTypeUser -> w.WriteConstructorId(CidPeerUser); w.WriteInt64(peerId)
        | PeerTypeChat -> w.WriteConstructorId(CidPeerChat); w.WriteInt64(peerId)
        | PeerTypeChannel -> w.WriteConstructorId(CidPeerChannel); w.WriteInt64(peerId)

    /// Scale dimensions proportionally to fit within maxDim.
    let private scaleDim (width: int) (height: int) (maxDim: int) =
        if width <= maxDim && height <= maxDim then (width, height)
        elif width >= height then (maxDim, max 1 (height * maxDim / width))
        else (max 1 (width * maxDim / height), maxDim)

    /// Write a photo TL object with proper s/m/x thumbnail sizes.
    let private writePhoto (w: TlWriteBuffer) (photoId: int64) (accessHash: int64) (dcId: int) (date: int) (width: int) (height: int) (size: int) =
        w.WriteConstructorId(CidPhoto)
        w.WriteInt32(0) // flags
        w.WriteInt64(photoId)
        w.WriteInt64(accessHash)
        w.WriteBytes([||]) // file_reference
        w.WriteInt32(date)
        // sizes: Vector<PhotoSize> — s (90px), m (320px), x (original)
        let sw, sh = scaleDim width height 90
        let mw, mh = scaleDim width height 320
        w.WriteConstructorId(CidVectorCid)
        w.WriteInt32(3)
        w.WriteConstructorId(CidPhotoSize)
        w.WriteString("s")
        w.WriteInt32(sw)
        w.WriteInt32(sh)
        w.WriteInt32(0) // estimated size
        w.WriteConstructorId(CidPhotoSize)
        w.WriteString("m")
        w.WriteInt32(mw)
        w.WriteInt32(mh)
        w.WriteInt32(0)
        w.WriteConstructorId(CidPhotoSize)
        w.WriteString("x")
        w.WriteInt32(width)
        w.WriteInt32(height)
        w.WriteInt32(size)
        w.WriteInt32(dcId) // dc_id

    /// Write a document TL object with proper attributes.
    let private writeDocument (w: TlWriteBuffer) (docId: int64) (accessHash: int64) (dcId: int) (date: int) (mime: string) (size: int64) (name: string) (attributes: DocumentAttribute list) =
        w.WriteConstructorId(CidDocument)
        w.WriteInt32(0) // flags
        w.WriteInt64(docId)
        w.WriteInt64(accessHash)
        w.WriteBytes([||]) // file_reference
        w.WriteInt32(date)
        w.WriteString(mime)
        w.WriteInt64(size)
        w.WriteInt32(dcId)
        // attributes: Vector<DocumentAttribute>
        let hasFilename = attributes |> List.exists (function DocumentAttribute.Filename _ -> true | _ -> false)
        let attrs = if hasFilename then attributes elif name <> "" then DocumentAttribute.Filename name :: attributes else attributes
        w.WriteConstructorId(CidVectorCid)
        w.WriteInt32(attrs.Length)
        for attr in attrs do
            writeDocAttribute w attr

    /// Write media for a message based on MediaInfo.
    let private writeMedia (w: TlWriteBuffer) (mediaDocCid: uint32) (date: int) (media: MediaInfo) =
        match media with
        | MediaInfo.Photo(photoId, accessHash, dcId, width, height, size) ->
            w.WriteConstructorId(CidMessageMediaPhoto)
            w.WriteInt32(1) // flags: has photo
            writePhoto w photoId accessHash dcId date width height size
        | MediaInfo.Document(docId, accessHash, dcId, mime, size, name, attributes) ->
            w.WriteConstructorId(mediaDocCid)
            w.WriteInt32(1) // flags: has document
            writeDocument w docId accessHash dcId date mime size name attributes
        | MediaInfo.Poll(_, pollBytes, resultsBytes) ->
            w.WriteConstructorId(0xA4C498D8u) // messageMediaPoll
            w.WriteRawBytes(pollBytes)
            w.WriteRawBytes(resultsBytes)
        | MediaInfo.Geo(lat, lon) ->
            w.WriteConstructorId(0x56E0D474u) // messageMediaGeo
            w.WriteConstructorId(0xB2A2F663u) // geoPoint
            w.WriteInt32(0) // flags
            w.WriteDouble(lon)
            w.WriteDouble(lat)
            w.WriteInt64(0L) // access_hash
            w.WriteInt32(0) // accuracy_radius
        | MediaInfo.GeoLive(lat, lon, period, heading) ->
            w.WriteConstructorId(0xB940C666u) // messageMediaGeoLive
            let flags = 1 // has heading
            w.WriteInt32(flags)
            w.WriteConstructorId(0xB2A2F663u) // geoPoint
            w.WriteInt32(0)
            w.WriteDouble(lon)
            w.WriteDouble(lat)
            w.WriteInt64(0L)
            w.WriteInt32(0)
            w.WriteInt32(heading)
            w.WriteInt32(period)
            w.WriteInt32(0) // proximity_notification_radius
        | MediaInfo.Venue(lat, lon, title, address, provider, venueId, venueType) ->
            w.WriteConstructorId(0x2EC0533Fu) // messageMediaVenue
            w.WriteConstructorId(0xB2A2F663u) // geoPoint
            w.WriteInt32(0)
            w.WriteDouble(lon)
            w.WriteDouble(lat)
            w.WriteInt64(0L)
            w.WriteInt32(0)
            w.WriteString(title)
            w.WriteString(address)
            w.WriteString(provider)
            w.WriteString(venueId)
            w.WriteString(venueType)
        | MediaInfo.Empty ->
            w.WriteConstructorId(CidMessageMediaEmpty)

    /// Compute message flags.
    let private computeFlags (m: TlMessage) =
        let mutable flags = 1 <<< 8 // from_id
        if m.IsOutgoing then flags <- flags ||| (1 <<< 1)
        if m.ReplyToMsgId.IsSome then flags <- flags ||| (1 <<< 3)
        let hasMedia = match m.Media with Some mm -> mm <> MediaInfo.Empty | None -> false
        if hasMedia then flags <- flags ||| (1 <<< 9)
        if m.GroupedId.IsSome then flags <- flags ||| (1 <<< 17)
        flags

    /// Write message body after CID + flags + flags2.
    let private writeBody (w: TlWriteBuffer) (mediaDocCid: uint32) (m: TlMessage) =
        let hasMedia = match m.Media with Some mm -> mm <> MediaInfo.Empty | None -> false
        w.WriteInt32(m.MsgId)
        // from_id: peerUser
        w.WriteConstructorId(CidPeerUser)
        w.WriteInt64(m.FromId)
        // peer_id
        writePeer w m.PeerType m.PeerId
        // reply_to
        match m.ReplyToMsgId with
        | Some replyId -> writeReplyHeader w replyId
        | None -> ()
        w.WriteInt32(m.Date)
        w.WriteString(m.Text)
        // media (flag bit 9)
        match m.Media with
        | Some media when hasMedia -> writeMedia w mediaDocCid m.Date media
        | _ -> ()
        // grouped_id (flag bit 17)
        match m.GroupedId with
        | Some gid -> w.WriteInt64(gid)
        | None -> ()

    /// Get messageMediaDocument CID for given layer.
    let private mediaDocCid (layer: int) =
        if layer < 217 then CidMessageMediaDocumentOld
        elif layer < 222 then CidMessageMediaDocumentNew
        else CidMessageMediaDocumentOld // telegram-tt (222+) uses old CID

    /// Get message CID for given layer.
    let private messageCid (layer: int) =
        if layer <= 216 then CidLayer216
        elif layer = 222 then CidLayer222
        else CidLayer223

    /// Layer 216 (Telethon): message#9815cec8, WITH flags2 (all message CIDs have flags2).
    let serializeLayer216 (w: TlWriteBuffer) (m: TlMessage) =
        w.WriteConstructorId(CidLayer216)
        w.WriteInt32(computeFlags m)
        w.WriteInt32(0) // flags2
        writeBody w CidMessageMediaDocumentOld m

    /// Layer 223 (tdesktop): message#3ae56482, WITH flags2.
    /// Uses old messageMediaDocument CID (layer 222+ reverted to old).
    let serializeLayer223 (w: TlWriteBuffer) (m: TlMessage) =
        w.WriteConstructorId(CidLayer223)
        w.WriteInt32(computeFlags m)
        w.WriteInt32(0) // flags2
        writeBody w CidMessageMediaDocumentOld m

    /// Layer 222 (telegram-tt): message#9cb490e9, WITH flags2.
    let serializeLayer222 (w: TlWriteBuffer) (m: TlMessage) =
        w.WriteConstructorId(CidLayer222)
        w.WriteInt32(computeFlags m)
        w.WriteInt32(0) // flags2
        writeBody w CidMessageMediaDocumentOld m

    /// Dispatch by TlLayer DU (exhaustive match).
    let serialize (w: TlWriteBuffer) (m: TlMessage) (layer: TlLayer) =
        match layer with
        | Layer216 -> serializeLayer216 w m
        | Layer223 -> serializeLayer223 w m

    /// Backward-compat dispatch by int layer number.
    let serializeInt (w: TlWriteBuffer) (m: TlMessage) (layer: int) =
        w.WriteConstructorId(messageCid layer)
        w.WriteInt32(computeFlags m)
        w.WriteInt32(0) // flags2
        writeBody w (mediaDocCid layer) m

// ===== TlChat (no layer variants) =====

/// chat#41cbf256 flags:# id:long title:string photo:ChatPhoto participants_count:int date:int version:int
type TlChat = {
    ChatId: int64
    Title: string
    MembersCount: int
    Date: int
    /// Photo: Some = chatPhoto, None = chatPhotoEmpty.
    Photo: TlChatPhoto option
}

module TlChat =

    [<Literal>]
    let private Cid = 0x41CBF256u

    /// Serialize chat#41cbf256. No layer variants.
    /// Note: chat#41cbf256 does NOT have flags2 (unlike User/Channel/Message).
    let serialize (w: TlWriteBuffer) (c: TlChat) =
        w.WriteConstructorId(Cid)
        w.WriteInt32(0) // flags
        w.WriteInt64(c.ChatId)
        w.WriteString(c.Title)
        match c.Photo with
        | Some photo -> TlChatPhoto.serialize w photo
        | None -> TlChatPhoto.serializeEmpty w
        w.WriteInt32(c.MembersCount)
        w.WriteInt32(c.Date)
        w.WriteInt32(1) // version

// ===== TlChannel (layer 216 vs 223) =====

/// Layer-aware Channel type for response serialization.
/// channel#fe685355 (layer <=216) / channel#1c32b11c (layer >=217)
type TlChannel = {
    ChannelId: int64
    AccessHash: int64
    Title: string
    Date: int
    IsBroadcast: bool
    IsMegagroup: bool
    MembersCount: int
    Photo: TlChatPhoto option
    Username: string option
}

module TlChannel =

    [<Literal>]
    let private CidLayer216 = 0xFE685355u
    [<Literal>]
    let private CidLayer223 = 0x1C32B11Cu

    /// Compute channel flags.
    let private computeFlags (c: TlChannel) =
        let mutable flags = 0
        if c.IsBroadcast then flags <- flags ||| (1 <<< 5)
        if c.Username.IsSome then flags <- flags ||| (1 <<< 6)
        if c.IsMegagroup then flags <- flags ||| (1 <<< 8)
        flags <- flags ||| (1 <<< 13) // has access_hash
        flags <- flags ||| (1 <<< 17) // has participants_count
        flags

    /// Write channel body after CID + flags + flags2.
    let private writeBody (w: TlWriteBuffer) (c: TlChannel) =
        w.WriteInt64(c.ChannelId)
        w.WriteInt64(c.AccessHash)
        w.WriteString(c.Title)
        match c.Username with
        | Some uname -> w.WriteString(uname)
        | None -> ()
        match c.Photo with
        | Some photo -> TlChatPhoto.serialize w photo
        | None -> TlChatPhoto.serializeEmpty w
        w.WriteInt32(c.Date)
        w.WriteInt32(c.MembersCount)

    /// Layer 216 (Telethon): channel#fe685355.
    let serializeLayer216 (w: TlWriteBuffer) (c: TlChannel) =
        w.WriteConstructorId(CidLayer216)
        w.WriteInt32(computeFlags c)
        w.WriteInt32(0) // flags2
        writeBody w c

    /// Layer 223 (tdesktop): channel#1c32b11c.
    let serializeLayer223 (w: TlWriteBuffer) (c: TlChannel) =
        w.WriteConstructorId(CidLayer223)
        w.WriteInt32(computeFlags c)
        w.WriteInt32(0) // flags2
        writeBody w c

    /// Dispatch by TlLayer DU (exhaustive match).
    let serialize (w: TlWriteBuffer) (c: TlChannel) (layer: TlLayer) =
        match layer with
        | Layer216 -> serializeLayer216 w c
        | Layer223 -> serializeLayer223 w c

    /// Backward-compat dispatch by int layer number.
    let serializeInt (w: TlWriteBuffer) (c: TlChannel) (layer: int) =
        if layer <= 216 then serializeLayer216 w c
        else serializeLayer223 w c

// ===== TlPeer (no layer variants) =====

/// Peer discriminated union: peerUser / peerChat / peerChannel.
[<Struct>]
[<RequireQualifiedAccess>]
type TlPeer =
    | User of userId: int64
    | Chat of chatId: int64
    | Channel of channelId: int64

module TlPeer =

    [<Literal>]
    let private CidPeerUser = 0x59511722u
    [<Literal>]
    let private CidPeerChat = 0x36C6019Au
    [<Literal>]
    let private CidPeerChannel = 0xA2A5371Eu

    /// Convert PeerType + id to TlPeer DU.
    let ofPeerType (peerType: PeerType) (peerId: int64) : TlPeer =
        match peerType with
        | PeerTypeUser -> TlPeer.User peerId
        | PeerTypeChat -> TlPeer.Chat peerId
        | PeerTypeChannel -> TlPeer.Channel peerId

    /// Serialize any Peer variant. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlPeer) =
        match v with
        | TlPeer.User userId ->
            w.WriteConstructorId(CidPeerUser)
            w.WriteInt64(userId)
        | TlPeer.Chat chatId ->
            w.WriteConstructorId(CidPeerChat)
            w.WriteInt64(chatId)
        | TlPeer.Channel channelId ->
            w.WriteConstructorId(CidPeerChannel)
            w.WriteInt64(channelId)

// ===== TlUpdatesState (no layer variants) =====

/// updates.state#a56c2a3e — current update state.
[<Struct>]
type TlUpdatesState = {
    Pts: int
    Qts: int
    Date: int
    Seq: int
}

module TlUpdatesState =

    [<Literal>]
    let private Cid = 0xA56C2A3Eu

    /// Serialize updates.state#a56c2a3e. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlUpdatesState) =
        w.WriteConstructorId(Cid)
        w.WriteInt32(v.Pts)
        w.WriteInt32(v.Qts)
        w.WriteInt32(v.Date)
        w.WriteInt32(v.Seq)
        w.WriteInt32(0) // unread_count

// ===== TlUpdateNewMessage (no layer variants) =====

/// updateNewMessage#1f2b0afd — wraps a pre-serialized message byte[].
type TlUpdateNewMessage = {
    /// Pre-serialized message bytes (CID + fields already written).
    Message: byte[]
    Pts: int
    PtsCount: int
}

module TlUpdateNewMessage =

    [<Literal>]
    let private Cid = 0x1F2B0AFDu

    /// Serialize updateNewMessage#1f2b0afd. No layer variants.
    /// Message is written as raw bytes (already serialized).
    let serialize (w: TlWriteBuffer) (v: TlUpdateNewMessage) =
        w.WriteConstructorId(Cid)
        w.WriteRawBytes(v.Message)
        w.WriteInt32(v.Pts)
        w.WriteInt32(v.PtsCount)

    /// Serialize updateNewMessage with inline TlMessage serialization (convenience).
    let serializeInline (w: TlWriteBuffer) (msg: TlMessage) (layer: int) (pts: int) (ptsCount: int) =
        w.WriteConstructorId(Cid)
        TlMessage.serializeInt w msg layer
        w.WriteInt32(pts)
        w.WriteInt32(ptsCount)

// ===== TlPhoneCallDiscarded (no layer variants) =====

/// phoneCallDiscarded#50ca4de1 — ended/missed call.
[<Struct>]
type TlPhoneCallDiscarded = {
    CallId: int64
    Duration: int voption
}

module TlPhoneCallDiscarded =

    [<Literal>]
    let private Cid = 0x50CA4DE1u

    /// Serialize phoneCallDiscarded#50ca4de1. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlPhoneCallDiscarded) =
        w.WriteConstructorId(Cid)
        let mutable flags = 0
        if v.Duration.IsSome then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        w.WriteInt64(v.CallId)
        // reason: absent (flags.0 not set)
        match v.Duration with
        | ValueSome d -> w.WriteInt32(d)
        | ValueNone -> ()

// ===== TlPhoto (no layer variants) =====

/// Photo thumbnail size entry.
type TlPhotoSize = {
    ThumbType: string
    Width: int
    Height: int
    Size: int
}

/// photo#fb197a65 — photo with multiple sizes and file_reference.
type TlPhoto = {
    PhotoId: int64
    AccessHash: int64
    FileReference: byte[]
    DcId: int
    Date: int
    Sizes: TlPhotoSize array
}

module TlPhoto =

    [<Literal>]
    let private Cid = 0xFB197A65u

    [<Literal>]
    let private CidVector = 0x1CB5C415u

    [<Literal>]
    let private CidPhotoSize = 0x75C78E60u

    /// Create a TlPhoto with a single "x" size (backward compat helper).
    let ofSingle (photoId: int64) (accessHash: int64) (dcId: int) (date: int) (width: int) (height: int) (size: int) =
        { PhotoId = photoId; AccessHash = accessHash; FileReference = [||]; DcId = dcId; Date = date
          Sizes = [| { ThumbType = "x"; Width = width; Height = height; Size = size } |] }

    /// Serialize photo#fb197a65 with multiple photoSize entries.
    let serialize (w: TlWriteBuffer) (v: TlPhoto) =
        w.WriteConstructorId(Cid)
        w.WriteInt32(0) // flags
        w.WriteInt64(v.PhotoId)
        w.WriteInt64(v.AccessHash)
        w.WriteBytes(v.FileReference) // file_reference
        w.WriteInt32(v.Date)
        // sizes: Vector<PhotoSize>
        w.WriteConstructorId(CidVector)
        w.WriteInt32(v.Sizes.Length)
        for s in v.Sizes do
            w.WriteConstructorId(CidPhotoSize)
            w.WriteString(s.ThumbType)
            w.WriteInt32(s.Width)
            w.WriteInt32(s.Height)
            w.WriteInt32(s.Size)
        w.WriteInt32(v.DcId) // dc_id

// ===== TlDocument (no layer variants) =====

/// document#8fd4c4d8 — generic document with attributes.
type TlDocument = {
    DocId: int64
    AccessHash: int64
    FileReference: byte[]
    DcId: int
    Date: int
    Mime: string
    Size: int64
    Name: string
    Attributes: DocumentAttribute list
}

module TlDocument =

    [<Literal>]
    let private Cid = 0x8FD4C4D8u

    [<Literal>]
    let private CidVector = 0x1CB5C415u

    [<Literal>]
    let private CidDocumentAttributeFilename = 0x15590068u

    [<Literal>]
    let private CidDocumentAttributeImageSize = 0x6C37C15Cu

    [<Literal>]
    let private CidDocumentAttributeVideo = 0x43C57C48u

    [<Literal>]
    let private CidDocumentAttributeAudio = 0x9852F9C6u

    [<Literal>]
    let private CidDocumentAttributeSticker = 0x6319D612u

    [<Literal>]
    let private CidDocumentAttributeAnimated = 0x11B58939u

    [<Literal>]
    let private CidDocumentAttributeHasStickers = 0x9801D2F7u

    [<Literal>]
    let private CidInputStickerSetEmpty = 0xFFB62B95u

    /// Write a single document attribute.
    let internal writeAttribute (w: TlWriteBuffer) (attr: DocumentAttribute) =
        match attr with
        | DocumentAttribute.Filename name ->
            w.WriteConstructorId(CidDocumentAttributeFilename)
            w.WriteString(name)
        | DocumentAttribute.ImageSize(width, height) ->
            w.WriteConstructorId(CidDocumentAttributeImageSize)
            w.WriteInt32(width)
            w.WriteInt32(height)
        | DocumentAttribute.Video(duration, width, height, roundMessage, supportsStreaming) ->
            w.WriteConstructorId(CidDocumentAttributeVideo)
            let mutable flags = 0
            if roundMessage then flags <- flags ||| (1 <<< 0)
            if supportsStreaming then flags <- flags ||| (1 <<< 1)
            w.WriteInt32(flags)
            w.WriteDouble(duration)
            w.WriteInt32(width)
            w.WriteInt32(height)
        | DocumentAttribute.Audio(duration, title, performer, voice, waveform) ->
            w.WriteConstructorId(CidDocumentAttributeAudio)
            let mutable flags = 0
            if voice then flags <- flags ||| (1 <<< 10)
            if title.IsSome then flags <- flags ||| (1 <<< 0)
            if performer.IsSome then flags <- flags ||| (1 <<< 1)
            if waveform.IsSome then flags <- flags ||| (1 <<< 2)
            w.WriteInt32(flags)
            w.WriteInt32(duration)
            match title with Some t -> w.WriteString(t) | None -> ()
            match performer with Some p -> w.WriteString(p) | None -> ()
            match waveform with Some wf -> w.WriteBytes(wf) | None -> ()
        | DocumentAttribute.Sticker alt ->
            w.WriteConstructorId(CidDocumentAttributeSticker)
            w.WriteInt32(0) // flags (no mask)
            w.WriteString(alt)
            w.WriteConstructorId(CidInputStickerSetEmpty) // stickerset: inputStickerSetEmpty
        | DocumentAttribute.Animated ->
            w.WriteConstructorId(CidDocumentAttributeAnimated)
        | DocumentAttribute.HasStickers ->
            w.WriteConstructorId(CidDocumentAttributeHasStickers)

    /// Build the attributes list, ensuring Filename is always present.
    let private buildAttributes (v: TlDocument) =
        let hasFilename = v.Attributes |> List.exists (function DocumentAttribute.Filename _ -> true | _ -> false)
        if hasFilename then v.Attributes
        elif v.Name <> "" then DocumentAttribute.Filename v.Name :: v.Attributes
        else v.Attributes

    /// Serialize document#8fd4c4d8 with proper attributes. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlDocument) =
        w.WriteConstructorId(Cid)
        w.WriteInt32(0) // flags
        w.WriteInt64(v.DocId)
        w.WriteInt64(v.AccessHash)
        w.WriteBytes(v.FileReference) // file_reference
        w.WriteInt32(v.Date)
        w.WriteString(v.Mime)
        w.WriteInt64(v.Size)
        w.WriteInt32(v.DcId)
        // attributes: Vector<DocumentAttribute>
        let attrs = buildAttributes v
        w.WriteConstructorId(CidVector)
        w.WriteInt32(attrs.Length)
        for attr in attrs do
            writeAttribute w attr

// ===== TlMessageMediaPhoto (no layer variants) =====

/// messageMediaPhoto#695150d7 — photo media attachment.
type TlMessageMediaPhoto = {
    Photo: TlPhoto
}

module TlMessageMediaPhoto =

    [<Literal>]
    let private Cid = 0x695150D7u

    /// Serialize messageMediaPhoto#695150d7. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlMessageMediaPhoto) =
        w.WriteConstructorId(Cid)
        w.WriteInt32(1) // flags: has photo
        TlPhoto.serialize w v.Photo

// ===== TlMessageMediaDocument (layer-dependent CID) =====

/// messageMediaDocument — document media attachment.
type TlMessageMediaDocument = {
    Document: TlDocument
}

module TlMessageMediaDocument =

    [<Literal>]
    let private CidOld = 0x52D8CCD9u

    [<Literal>]
    let private CidNew = 0x4CF4D72Du

    /// Get CID for given layer.
    let private cidForLayer (layer: int) =
        if layer < 217 then CidOld
        elif layer < 222 then CidNew
        else CidOld // layer 222+ reverted to old CID

    /// Serialize messageMediaDocument (layer-dependent CID).
    let serializeInt (w: TlWriteBuffer) (v: TlMessageMediaDocument) (layer: int) =
        w.WriteConstructorId(cidForLayer layer)
        w.WriteInt32(1) // flags: has document
        TlDocument.serialize w v.Document

// ===== TlMessageReplyHeader (no layer variants) =====

/// messageReplyHeader#6917560b (minimal: just reply_to_msg_id).
[<Struct>]
type TlMessageReplyHeader = {
    ReplyToMsgId: int
}

module TlMessageReplyHeader =

    [<Literal>]
    let private Cid = 0x6917560Bu

    /// Serialize messageReplyHeader#6917560b (minimal). No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlMessageReplyHeader) =
        w.WriteConstructorId(Cid)
        w.WriteInt32(1 <<< 4) // flags: reply_to_msg_id present
        w.WriteInt32(v.ReplyToMsgId)

// ===== TlUpdateReadHistoryOutbox (no layer variants) =====

/// updateReadHistoryOutbox#2f2f21bf peer:Peer max_id:int pts:int pts_count:int.
[<Struct>]
type TlUpdateReadHistoryOutbox = {
    PeerId: int64
    PeerType: PeerType
    MaxId: int
    Pts: int
    PtsCount: int
}

module TlUpdateReadHistoryOutbox =

    [<Literal>]
    let private Cid = 0x2F2F21BFu

    /// Serialize updateReadHistoryOutbox#2f2f21bf. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlUpdateReadHistoryOutbox) =
        w.WriteConstructorId(Cid)
        TlPeer.serialize w (
            match v.PeerType with
            | PeerTypeUser -> TlPeer.User v.PeerId
            | PeerTypeChat -> TlPeer.Chat v.PeerId
            | PeerTypeChannel -> TlPeer.Channel v.PeerId)
        w.WriteInt32(v.MaxId)
        w.WriteInt32(v.Pts)
        w.WriteInt32(v.PtsCount)

// ===== TlUpdateReadHistoryInbox (no layer variants) =====

/// updateReadHistoryInbox#9e84bc99 flags:# folder_id:flags.0?int peer:Peer top_msg_id:flags.1?int max_id:int still_unread_count:int pts:int pts_count:int.
[<Struct>]
type TlUpdateReadHistoryInbox = {
    PeerId: int64
    PeerType: PeerType
    MaxId: int
    Pts: int
    PtsCount: int
}

module TlUpdateReadHistoryInbox =

    [<Literal>]
    let private Cid = 0x9E84BC99u

    /// Serialize updateReadHistoryInbox#9e84bc99. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlUpdateReadHistoryInbox) =
        w.WriteConstructorId(Cid)
        w.WriteInt32(0) // flags (no folder_id, no top_msg_id)
        TlPeer.serialize w (
            match v.PeerType with
            | PeerTypeUser -> TlPeer.User v.PeerId
            | PeerTypeChat -> TlPeer.Chat v.PeerId
            | PeerTypeChannel -> TlPeer.Channel v.PeerId)
        w.WriteInt32(v.MaxId) // max_id
        w.WriteInt32(0) // still_unread_count
        w.WriteInt32(v.Pts)
        w.WriteInt32(v.PtsCount)

// ===== TlUpdateReadChannelInbox (no layer variants) =====

/// updateReadChannelInbox#922e6e10 flags:# folder_id:flags.0?int channel_id:long max_id:int still_unread_count:int pts:int.
[<Struct>]
type TlUpdateReadChannelInbox = {
    ChannelId: int64
    MaxId: int
    Pts: int
}

module TlUpdateReadChannelInbox =

    [<Literal>]
    let private Cid = 0x922E6E10u

    /// Serialize updateReadChannelInbox#922e6e10. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlUpdateReadChannelInbox) =
        w.WriteConstructorId(Cid)
        w.WriteInt32(0) // flags (no folder_id)
        w.WriteInt64(v.ChannelId) // channel_id
        w.WriteInt32(v.MaxId) // max_id
        w.WriteInt32(0) // still_unread_count
        w.WriteInt32(v.Pts) // pts

// ===== TlGroupCall (no layer variants) =====

/// groupCall#553b0ba1 (active group call).
type TlGroupCall = {
    CallId: int64
    AccessHash: int64
    Title: string
    ParticipantsCount: int
    JoinMuted: bool
    Date: int
    Version: int
}

module TlGroupCall =

    [<Literal>]
    let private Cid = 0x553B0BA1u

    /// Serialize groupCall#553b0ba1. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlGroupCall) =
        w.WriteConstructorId(Cid)
        let mutable flags = 0
        if v.JoinMuted then flags <- flags ||| (1 <<< 1) // join_muted
        flags <- flags ||| (1 <<< 2) // can_change_join_muted
        if v.Title <> "" then flags <- flags ||| (1 <<< 3) // has title
        flags <- flags ||| (1 <<< 4) // has stream_dc_id
        w.WriteInt32(flags)
        w.WriteInt64(v.CallId)
        w.WriteInt64(v.AccessHash)
        w.WriteInt32(v.ParticipantsCount)
        if v.Title <> "" then w.WriteString(v.Title)
        w.WriteInt32(2) // stream_dc_id
        // record_start_date: absent (flag 5 not set)
        // schedule_date: absent (flag 7 not set)
        // unmuted_video_count: absent (flag 10 not set)
        w.WriteInt32(0) // unmuted_video_limit
        w.WriteInt32(v.Version)

// ===== TlGroupCallDiscarded (no layer variants) =====

/// groupCallDiscarded#7780bcb4 (ended group call).
[<Struct>]
type TlGroupCallDiscarded = {
    CallId: int64
    AccessHash: int64
}

module TlGroupCallDiscarded =

    [<Literal>]
    let private Cid = 0x7780BCB4u

    /// Serialize groupCallDiscarded#7780bcb4. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlGroupCallDiscarded) =
        w.WriteConstructorId(Cid)
        w.WriteInt64(v.CallId)
        w.WriteInt64(v.AccessHash)
        w.WriteInt32(0) // duration

// ===== TlGroupCallParticipant (no layer variants) =====

/// groupCallParticipant#eba636fe.
type TlGroupCallParticipant = {
    UserId: int64
    Ssrc: uint32
    JoinDate: int
    IsMuted: bool
    CanSelfUnmute: bool
    Volume: int
    RaisedHand: bool
    Left: bool
}

module TlGroupCallParticipant =

    [<Literal>]
    let private Cid = 0xEBA636FEu

    [<Literal>]
    let private CidPeerUser = 0x59511722u

    /// Serialize groupCallParticipant#eba636fe. No layer variants.
    let serialize (w: TlWriteBuffer) (v: TlGroupCallParticipant) =
        w.WriteConstructorId(Cid)
        let mutable flags = 0
        if v.IsMuted then flags <- flags ||| (1 <<< 0)
        if v.Left then flags <- flags ||| (1 <<< 1)
        if v.CanSelfUnmute then flags <- flags ||| (1 <<< 2)
        // active_date: flag bit 3 -- omitted
        if v.Volume <> 10000 then flags <- flags ||| (1 <<< 7)
        if v.RaisedHand then flags <- flags ||| (1 <<< 13) // raise_hand_rating (flag 13)
        w.WriteInt32(flags)
        // peer: peerUser
        w.WriteConstructorId(CidPeerUser)
        w.WriteInt64(v.UserId)
        w.WriteInt32(v.JoinDate) // date
        // active_date: absent (flag 3 not set)
        w.WriteInt32(int v.Ssrc) // source
        if v.Volume <> 10000 then w.WriteInt32(v.Volume) // volume (flag bit 7)
        // about: absent (flag 11 not set)
        if v.RaisedHand then w.WriteInt64(1L) // raise_hand_rating (flag 13): nonzero = hand raised

type CodeSettings = {
    allowFlashcall: bool
    currentNumber: bool
    allowAppHash: bool
    allowMissedCall: bool
    allowFirebase: bool
    unknownNumber: bool
    logoutTokens: byte[] array option
    token: string option
    appSandbox: bool option
} with

    static member ConstructorId: uint32 = 2904898936u

    static member Serialize(writer: TlWriteBuffer, value: CodeSettings) : unit =
        writer.WriteConstructorId(2904898936u)
        let mutable flags = 0

        if value.allowFlashcall then
            flags <- flags ||| (1 <<< 0)

        if value.currentNumber then
            flags <- flags ||| (1 <<< 1)

        if value.allowAppHash then
            flags <- flags ||| (1 <<< 4)

        if value.allowMissedCall then
            flags <- flags ||| (1 <<< 5)

        if value.allowFirebase then
            flags <- flags ||| (1 <<< 7)

        if value.unknownNumber then
            flags <- flags ||| (1 <<< 9)

        if value.logoutTokens.IsSome then
            flags <- flags ||| (1 <<< 6)

        if value.token.IsSome then
            flags <- flags ||| (1 <<< 8)

        if value.appSandbox.IsSome then
            flags <- flags ||| (1 <<< 10)

        writer.WriteInt32(flags)

        match value.logoutTokens with
        | Some v -> writer.WriteVector(v, fun w item -> let writer = w in writer.WriteBytes(item))
        | None -> ()

        match value.token with
        | Some v -> writer.WriteString(v)
        | None -> ()

        match value.appSandbox with
        | Some v -> writer.WriteBool(v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : CodeSettings =
        let flags = reader.ReadInt32()
        let allowFlashcall = flags &&& (1 <<< 0) <> 0
        let currentNumber = flags &&& (1 <<< 1) <> 0
        let allowAppHash = flags &&& (1 <<< 4) <> 0
        let allowMissedCall = flags &&& (1 <<< 5) <> 0
        let allowFirebase = flags &&& (1 <<< 7) <> 0
        let unknownNumber = flags &&& (1 <<< 9) <> 0

        let logoutTokens =
            if flags &&& (1 <<< 6) <> 0 then
                Some(reader.ReadVector(fun r -> let reader = r in reader.ReadBytes()))
            else
                None

        let token =
            if flags &&& (1 <<< 8) <> 0 then
                Some(reader.ReadString())
            else
                None

        let appSandbox =
            if flags &&& (1 <<< 10) <> 0 then
                Some(reader.ReadBool())
            else
                None

        {
            allowFlashcall = allowFlashcall
            currentNumber = currentNumber
            allowAppHash = allowAppHash
            allowMissedCall = allowMissedCall
            allowFirebase = allowFirebase
            unknownNumber = unknownNumber
            logoutTokens = logoutTokens
            token = token
            appSandbox = appSandbox
        }

type EmailVerification =
    | EmailVerificationCode of code: string
    | EmailVerificationGoogle of token: string
    | EmailVerificationApple of token: string

    static member Serialize(writer: TlWriteBuffer, value: EmailVerification) : unit =
        match value with
        | EmailVerificationCode(code) ->
            writer.WriteConstructorId(2452510121u)
            writer.WriteString(code)
        | EmailVerificationGoogle(token) ->
            writer.WriteConstructorId(3683688130u)
            writer.WriteString(token)
        | EmailVerificationApple(token) ->
            writer.WriteConstructorId(2530243837u)
            writer.WriteString(token)

    static member Deserialize(reader: TlReadBuffer) : EmailVerification =
        let ctorId = reader.ReadConstructorId()

        match ctorId with
        | 2452510121u ->
            let code = reader.ReadString()
            EmailVerificationCode(code)
        | 3683688130u ->
            let token = reader.ReadString()
            EmailVerificationGoogle(token)
        | 2530243837u ->
            let token = reader.ReadString()
            EmailVerificationApple(token)
        | _ -> failwith $"Unknown constructor id for EmailVerification: 0x{ctorId:X08}"

type InputGroupCall =
    | InputGroupCall of id: int64 * accessHash: int64
    | InputGroupCallSlug of slug: string
    | InputGroupCallInviteMessage of msgId: int32

    static member Serialize(writer: TlWriteBuffer, value: InputGroupCall) : unit =
        match value with
        | InputGroupCall(id, accessHash) ->
            writer.WriteConstructorId(3635053583u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
        | InputGroupCallSlug(slug) ->
            writer.WriteConstructorId(4261839423u)
            writer.WriteString(slug)
        | InputGroupCallInviteMessage(msgId) ->
            writer.WriteConstructorId(2349883455u)
            writer.WriteInt32(msgId)

    static member Deserialize(reader: TlReadBuffer) : InputGroupCall =
        let ctorId = reader.ReadConstructorId()

        match ctorId with
        | 3635053583u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputGroupCall(id, accessHash)
        | 4261839423u ->
            let slug = reader.ReadString()
            InputGroupCallSlug(slug)
        | 2349883455u ->
            let msgId = reader.ReadInt32()
            InputGroupCallInviteMessage(msgId)
        | _ -> failwith $"Unknown constructor id for InputGroupCall: 0x{ctorId:X08}"

type InputPeer =
    | InputPeerEmpty
    | InputPeerSelf
    | InputPeerChat of chatId: int64
    | InputPeerUser of userId: int64 * accessHash: int64
    | InputPeerChannel of channelId: int64 * accessHash: int64
    | InputPeerUserFromMessage of peer: InputPeer * msgId: int32 * userId: int64
    | InputPeerChannelFromMessage of peer: InputPeer * msgId: int32 * channelId: int64

    static member Serialize(writer: TlWriteBuffer, value: InputPeer) : unit =
        match value with
        | InputPeerEmpty -> writer.WriteConstructorId(2134579434u)
        | InputPeerSelf -> writer.WriteConstructorId(2107670217u)
        | InputPeerChat(chatId) ->
            writer.WriteConstructorId(900291769u)
            writer.WriteInt64(chatId)
        | InputPeerUser(userId, accessHash) ->
            writer.WriteConstructorId(3723011404u)
            writer.WriteInt64(userId)
            writer.WriteInt64(accessHash)
        | InputPeerChannel(channelId, accessHash) ->
            writer.WriteConstructorId(666680316u)
            writer.WriteInt64(channelId)
            writer.WriteInt64(accessHash)
        | InputPeerUserFromMessage(peer, msgId, userId) ->
            writer.WriteConstructorId(2826635804u)
            InputPeer.Serialize(writer, peer)
            writer.WriteInt32(msgId)
            writer.WriteInt64(userId)
        | InputPeerChannelFromMessage(peer, msgId, channelId) ->
            writer.WriteConstructorId(3173648448u)
            InputPeer.Serialize(writer, peer)
            writer.WriteInt32(msgId)
            writer.WriteInt64(channelId)

    static member Deserialize(reader: TlReadBuffer) : InputPeer =
        let ctorId = reader.ReadConstructorId()

        match ctorId with
        | 2134579434u -> InputPeerEmpty
        | 2107670217u -> InputPeerSelf
        | 900291769u ->
            let chatId = reader.ReadInt64()
            InputPeerChat(chatId)
        | 3723011404u
        | 2072935910u ->
            let userId = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputPeerUser(userId, accessHash)
        | 666680316u ->
            let channelId = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputPeerChannel(channelId, accessHash)
        | 2826635804u ->
            let peer = InputPeer.Deserialize(reader)
            let msgId = reader.ReadInt32()
            let userId = reader.ReadInt64()
            InputPeerUserFromMessage(peer, msgId, userId)
        | 3173648448u ->
            let peer = InputPeer.Deserialize(reader)
            let msgId = reader.ReadInt32()
            let channelId = reader.ReadInt64()
            InputPeerChannelFromMessage(peer, msgId, channelId)
        | _ -> failwith $"Unknown constructor id for InputPeer: 0x{ctorId:X08}"

type InputChannel =
    | InputChannelEmpty
    | InputChannel of channelId: int64 * accessHash: int64
    | InputChannelFromMessage of peer: InputPeer * msgId: int32 * channelId: int64

    static member Serialize(writer: TlWriteBuffer, value: InputChannel) : unit =
        match value with
        | InputChannelEmpty -> writer.WriteConstructorId(4002160262u)
        | InputChannel(channelId, accessHash) ->
            writer.WriteConstructorId(4082822184u)
            writer.WriteInt64(channelId)
            writer.WriteInt64(accessHash)
        | InputChannelFromMessage(peer, msgId, channelId) ->
            writer.WriteConstructorId(1536380829u)
            InputPeer.Serialize(writer, peer)
            writer.WriteInt32(msgId)
            writer.WriteInt64(channelId)

    static member Deserialize(reader: TlReadBuffer) : InputChannel =
        let ctorId = reader.ReadConstructorId()

        match ctorId with
        | 4002160262u -> InputChannelEmpty
        | 4082822184u ->
            let channelId = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputChannel(channelId, accessHash)
        | 1536380829u ->
            let peer = InputPeer.Deserialize(reader)
            let msgId = reader.ReadInt32()
            let channelId = reader.ReadInt64()
            InputChannelFromMessage(peer, msgId, channelId)
        | _ -> failwith $"Unknown constructor id for InputChannel: 0x{ctorId:X08}"

type InputStickerSet =
    | InputStickerSetEmpty
    | InputStickerSetID of id: int64 * accessHash: int64
    | InputStickerSetShortName of shortName: string
    | InputStickerSetAnimatedEmoji
    | InputStickerSetDice of emoticon: string
    | InputStickerSetAnimatedEmojiAnimations
    | InputStickerSetPremiumGifts
    | InputStickerSetEmojiGenericAnimations
    | InputStickerSetEmojiDefaultStatuses
    | InputStickerSetEmojiDefaultTopicIcons
    | InputStickerSetEmojiChannelDefaultStatuses
    | InputStickerSetTonGifts

    static member Serialize(writer: TlWriteBuffer, value: InputStickerSet) : unit =
        match value with
        | InputStickerSetEmpty -> writer.WriteConstructorId(4290128789u)
        | InputStickerSetID(id, accessHash) ->
            writer.WriteConstructorId(2649203305u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
        | InputStickerSetShortName(shortName) ->
            writer.WriteConstructorId(2250033312u)
            writer.WriteString(shortName)
        | InputStickerSetAnimatedEmoji -> writer.WriteConstructorId(42402760u)
        | InputStickerSetDice(emoticon) ->
            writer.WriteConstructorId(3867103758u)
            writer.WriteString(emoticon)
        | InputStickerSetAnimatedEmojiAnimations -> writer.WriteConstructorId(215889721u)
        | InputStickerSetPremiumGifts -> writer.WriteConstructorId(3364567810u)
        | InputStickerSetEmojiGenericAnimations -> writer.WriteConstructorId(80008398u)
        | InputStickerSetEmojiDefaultStatuses -> writer.WriteConstructorId(701560302u)
        | InputStickerSetEmojiDefaultTopicIcons -> writer.WriteConstructorId(1153562857u)
        | InputStickerSetEmojiChannelDefaultStatuses -> writer.WriteConstructorId(1232373075u)
        | InputStickerSetTonGifts -> writer.WriteConstructorId(485912992u)

    static member Deserialize(reader: TlReadBuffer) : InputStickerSet =
        let ctorId = reader.ReadConstructorId()

        match ctorId with
        | 4290128789u -> InputStickerSetEmpty
        | 2649203305u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputStickerSetID(id, accessHash)
        | 2250033312u ->
            let shortName = reader.ReadString()
            InputStickerSetShortName(shortName)
        | 42402760u -> InputStickerSetAnimatedEmoji
        | 3867103758u ->
            let emoticon = reader.ReadString()
            InputStickerSetDice(emoticon)
        | 215889721u -> InputStickerSetAnimatedEmojiAnimations
        | 3364567810u -> InputStickerSetPremiumGifts
        | 80008398u -> InputStickerSetEmojiGenericAnimations
        | 701560302u -> InputStickerSetEmojiDefaultStatuses
        | 1153562857u -> InputStickerSetEmojiDefaultTopicIcons
        | 1232373075u -> InputStickerSetEmojiChannelDefaultStatuses
        | 485912992u -> InputStickerSetTonGifts
        | _ -> failwith $"Unknown constructor id for InputStickerSet: 0x{ctorId:X08}"

type InputFileLocation =
    | InputFileLocation of volumeId: int64 * localId: int32 * secret: int64 * fileReference: byte[]
    | InputEncryptedFileLocation of id: int64 * accessHash: int64
    | InputDocumentFileLocation of id: int64 * accessHash: int64 * fileReference: byte[] * thumbSize: string
    | InputSecureFileLocation of id: int64 * accessHash: int64
    | InputTakeoutFileLocation
    | InputPhotoFileLocation of id: int64 * accessHash: int64 * fileReference: byte[] * thumbSize: string
    | InputPhotoLegacyFileLocation of
        id: int64 *
        accessHash: int64 *
        fileReference: byte[] *
        volumeId: int64 *
        localId: int32 *
        secret: int64
    | InputPeerPhotoFileLocation of big: bool * peer: InputPeer * photoId: int64
    | InputStickerSetThumb of stickerset: InputStickerSet * thumbVersion: int32
    | InputGroupCallStream of
        call: InputGroupCall *
        timeMs: int64 *
        scale: int32 *
        videoChannel: int32 option *
        videoQuality: int32 option

    static member Serialize(writer: TlWriteBuffer, value: InputFileLocation) : unit =
        match value with
        | InputFileLocation(volumeId, localId, secret, fileReference) ->
            writer.WriteConstructorId(3755650017u)
            writer.WriteInt64(volumeId)
            writer.WriteInt32(localId)
            writer.WriteInt64(secret)
            writer.WriteBytes(fileReference)
        | InputEncryptedFileLocation(id, accessHash) ->
            writer.WriteConstructorId(4112735573u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
        | InputDocumentFileLocation(id, accessHash, fileReference, thumbSize) ->
            writer.WriteConstructorId(3134223748u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
            writer.WriteBytes(fileReference)
            writer.WriteString(thumbSize)
        | InputSecureFileLocation(id, accessHash) ->
            writer.WriteConstructorId(3418877480u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
        | InputTakeoutFileLocation -> writer.WriteConstructorId(700340377u)
        | InputPhotoFileLocation(id, accessHash, fileReference, thumbSize) ->
            writer.WriteConstructorId(1075322878u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
            writer.WriteBytes(fileReference)
            writer.WriteString(thumbSize)
        | InputPhotoLegacyFileLocation(id, accessHash, fileReference, volumeId, localId, secret) ->
            writer.WriteConstructorId(3627312883u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
            writer.WriteBytes(fileReference)
            writer.WriteInt64(volumeId)
            writer.WriteInt32(localId)
            writer.WriteInt64(secret)
        | InputPeerPhotoFileLocation(big, peer, photoId) ->
            writer.WriteConstructorId(925204121u)
            writer.WriteBool(big)
            InputPeer.Serialize(writer, peer)
            writer.WriteInt64(photoId)
        | InputStickerSetThumb(stickerset, thumbVersion) ->
            writer.WriteConstructorId(2642736091u)
            InputStickerSet.Serialize(writer, stickerset)
            writer.WriteInt32(thumbVersion)
        | InputGroupCallStream(call, timeMs, scale, videoChannel, videoQuality) ->
            writer.WriteConstructorId(93890858u)
            InputGroupCall.Serialize(writer, call)
            writer.WriteInt64(timeMs)
            writer.WriteInt32(scale)

            match videoChannel with
            | Some v -> writer.WriteInt32(v)
            | None -> ()

            match videoQuality with
            | Some v -> writer.WriteInt32(v)
            | None -> ()

    static member Deserialize(reader: TlReadBuffer) : InputFileLocation =
        let ctorId = reader.ReadConstructorId()

        match ctorId with
        | 3755650017u ->
            let volumeId = reader.ReadInt64()
            let localId = reader.ReadInt32()
            let secret = reader.ReadInt64()
            let fileReference = reader.ReadBytes()
            InputFileLocation(volumeId, localId, secret, fileReference)
        | 4112735573u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputEncryptedFileLocation(id, accessHash)
        | 3134223748u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            let fileReference = reader.ReadBytes()
            let thumbSize = reader.ReadString()
            InputDocumentFileLocation(id, accessHash, fileReference, thumbSize)
        | 3418877480u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputSecureFileLocation(id, accessHash)
        | 700340377u -> InputTakeoutFileLocation
        | 1075322878u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            let fileReference = reader.ReadBytes()
            let thumbSize = reader.ReadString()
            InputPhotoFileLocation(id, accessHash, fileReference, thumbSize)
        | 3627312883u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            let fileReference = reader.ReadBytes()
            let volumeId = reader.ReadInt64()
            let localId = reader.ReadInt32()
            let secret = reader.ReadInt64()
            InputPhotoLegacyFileLocation(id, accessHash, fileReference, volumeId, localId, secret)
        | 925204121u ->
            let flags = reader.ReadInt32()
            let big = flags &&& (1 <<< 0) <> 0
            let peer = InputPeer.Deserialize(reader)
            let photoId = reader.ReadInt64()
            InputPeerPhotoFileLocation(big, peer, photoId)
        | 2642736091u ->
            let stickerset = InputStickerSet.Deserialize(reader)
            let thumbVersion = reader.ReadInt32()
            InputStickerSetThumb(stickerset, thumbVersion)
        | 93890858u ->
            let flags = reader.ReadInt32()
            let call = InputGroupCall.Deserialize(reader)
            let timeMs = reader.ReadInt64()
            let scale = reader.ReadInt32()

            let videoChannel =
                if flags &&& (1 <<< 0) <> 0 then
                    Some(reader.ReadInt32())
                else
                    None

            let videoQuality =
                if flags &&& (1 <<< 0) <> 0 then
                    Some(reader.ReadInt32())
                else
                    None

            InputGroupCallStream(call, timeMs, scale, videoChannel, videoQuality)
        | _ -> failwith $"Unknown constructor id for InputFileLocation: 0x{ctorId:X08}"

type InputUser =
    | InputUserEmpty
    | InputUserSelf
    | InputUser of userId: int64 * accessHash: int64
    | InputUserFromMessage of peer: InputPeer * msgId: int32 * userId: int64

    static member Serialize(writer: TlWriteBuffer, value: InputUser) : unit =
        match value with
        | InputUserEmpty -> writer.WriteConstructorId(3112732367u)
        | InputUserSelf -> writer.WriteConstructorId(4156666175u)
        | InputUser(userId, accessHash) ->
            writer.WriteConstructorId(4061223110u)
            writer.WriteInt64(userId)
            writer.WriteInt64(accessHash)
        | InputUserFromMessage(peer, msgId, userId) ->
            writer.WriteConstructorId(497305826u)
            InputPeer.Serialize(writer, peer)
            writer.WriteInt32(msgId)
            writer.WriteInt64(userId)

    static member Deserialize(reader: TlReadBuffer) : InputUser =
        let ctorId = reader.ReadConstructorId()

        match ctorId with
        | 3112732367u -> InputUserEmpty
        | 4156666175u -> InputUserSelf
        | 4061223110u ->
            let userId = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputUser(userId, accessHash)
        | 497305826u ->
            let peer = InputPeer.Deserialize(reader)
            let msgId = reader.ReadInt32()
            let userId = reader.ReadInt64()
            InputUserFromMessage(peer, msgId, userId)
        | _ -> failwith $"Unknown constructor id for InputUser: 0x{ctorId:X08}"

type AuthSendCode = {
    phoneNumber: string
    apiId: int32
    apiHash: string
    settings: CodeSettings
} with

    static member ConstructorId: uint32 = 2792825935u

    static member Serialize(writer: TlWriteBuffer, value: AuthSendCode) : unit =
        writer.WriteConstructorId(2792825935u)
        writer.WriteString(value.phoneNumber)
        writer.WriteInt32(value.apiId)
        writer.WriteString(value.apiHash)
        CodeSettings.Serialize(writer, value.settings)

    static member DeserializeFields(reader: TlReadBuffer) : AuthSendCode =
        let phoneNumber = reader.ReadString()
        let apiId = reader.ReadInt32()
        let apiHash = reader.ReadString()
        let settings = CodeSettings.Deserialize(reader)

        {
            phoneNumber = phoneNumber
            apiId = apiId
            apiHash = apiHash
            settings = settings
        }

    static member Deserialize(body: byte[]) : AuthSendCode =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthSendCode.DeserializeFields(reader)

type AuthSignUp = {
    noJoinedNotifications: bool
    phoneNumber: string
    phoneCodeHash: string
    firstName: string
    lastName: string
} with

    static member ConstructorId: uint32 = 2865215255u

    static member Serialize(writer: TlWriteBuffer, value: AuthSignUp) : unit =
        writer.WriteConstructorId(2865215255u)
        let mutable flags = 0

        if value.noJoinedNotifications then
            flags <- flags ||| (1 <<< 0)

        writer.WriteInt32(flags)
        writer.WriteString(value.phoneNumber)
        writer.WriteString(value.phoneCodeHash)
        writer.WriteString(value.firstName)
        writer.WriteString(value.lastName)

    static member DeserializeFields(reader: TlReadBuffer) : AuthSignUp =
        let flags = reader.ReadInt32()
        let noJoinedNotifications = flags &&& (1 <<< 0) <> 0
        let phoneNumber = reader.ReadString()
        let phoneCodeHash = reader.ReadString()
        let firstName = reader.ReadString()
        let lastName = reader.ReadString()

        {
            noJoinedNotifications = noJoinedNotifications
            phoneNumber = phoneNumber
            phoneCodeHash = phoneCodeHash
            firstName = firstName
            lastName = lastName
        }

    static member Deserialize(body: byte[]) : AuthSignUp =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthSignUp.DeserializeFields(reader)

type AuthSignIn = {
    phoneNumber: string
    phoneCodeHash: string
    phoneCode: string option
    emailVerification: EmailVerification option
} with

    static member ConstructorId: uint32 = 2371004753u

    static member Serialize(writer: TlWriteBuffer, value: AuthSignIn) : unit =
        writer.WriteConstructorId(2371004753u)
        let mutable flags = 0

        if value.phoneCode.IsSome then
            flags <- flags ||| (1 <<< 0)

        if value.emailVerification.IsSome then
            flags <- flags ||| (1 <<< 1)

        writer.WriteInt32(flags)
        writer.WriteString(value.phoneNumber)
        writer.WriteString(value.phoneCodeHash)

        match value.phoneCode with
        | Some v -> writer.WriteString(v)
        | None -> ()

        match value.emailVerification with
        | Some v -> EmailVerification.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : AuthSignIn =
        let flags = reader.ReadInt32()
        let phoneNumber = reader.ReadString()
        let phoneCodeHash = reader.ReadString()

        let phoneCode =
            if flags &&& (1 <<< 0) <> 0 then
                Some(reader.ReadString())
            else
                None

        let emailVerification =
            if flags &&& (1 <<< 1) <> 0 then
                Some(EmailVerification.Deserialize(reader))
            else
                None

        {
            phoneNumber = phoneNumber
            phoneCodeHash = phoneCodeHash
            phoneCode = phoneCode
            emailVerification = emailVerification
        }

    static member Deserialize(body: byte[]) : AuthSignIn =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthSignIn.DeserializeFields(reader)

type AuthBindTempAuthKey = {
    permAuthKeyId: int64
    nonce: int64
    expiresAt: int32
    encryptedMessage: byte[]
} with

    static member ConstructorId: uint32 = 3453233669u

    static member Serialize(writer: TlWriteBuffer, value: AuthBindTempAuthKey) : unit =
        writer.WriteConstructorId(3453233669u)
        writer.WriteInt64(value.permAuthKeyId)
        writer.WriteInt64(value.nonce)
        writer.WriteInt32(value.expiresAt)
        writer.WriteBytes(value.encryptedMessage)

    static member DeserializeFields(reader: TlReadBuffer) : AuthBindTempAuthKey =
        let permAuthKeyId = reader.ReadInt64()
        let nonce = reader.ReadInt64()
        let expiresAt = reader.ReadInt32()
        let encryptedMessage = reader.ReadBytes()

        {
            permAuthKeyId = permAuthKeyId
            nonce = nonce
            expiresAt = expiresAt
            encryptedMessage = encryptedMessage
        }

    static member Deserialize(body: byte[]) : AuthBindTempAuthKey =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthBindTempAuthKey.DeserializeFields(reader)

type AuthImportBotAuthorization = {
    flags: int32
    apiId: int32
    apiHash: string
    botAuthToken: string
} with

    static member ConstructorId: uint32 = 1738800940u

    static member Serialize(writer: TlWriteBuffer, value: AuthImportBotAuthorization) : unit =
        writer.WriteConstructorId(1738800940u)
        writer.WriteInt32(value.flags)
        writer.WriteInt32(value.apiId)
        writer.WriteString(value.apiHash)
        writer.WriteString(value.botAuthToken)

    static member DeserializeFields(reader: TlReadBuffer) : AuthImportBotAuthorization =
        let flags = reader.ReadInt32()
        let apiId = reader.ReadInt32()
        let apiHash = reader.ReadString()
        let botAuthToken = reader.ReadString()

        {
            flags = flags
            apiId = apiId
            apiHash = apiHash
            botAuthToken = botAuthToken
        }

    static member Deserialize(body: byte[]) : AuthImportBotAuthorization =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthImportBotAuthorization.DeserializeFields(reader)

type AuthExportLoginToken = {
    apiId: int32
    apiHash: string
    exceptIds: int64 array
} with

    static member ConstructorId: uint32 = 3084944894u

    static member Serialize(writer: TlWriteBuffer, value: AuthExportLoginToken) : unit =
        writer.WriteConstructorId(3084944894u)
        writer.WriteInt32(value.apiId)
        writer.WriteString(value.apiHash)
        writer.WriteVector(value.exceptIds, fun w item -> let writer = w in writer.WriteInt64(item))

    static member DeserializeFields(reader: TlReadBuffer) : AuthExportLoginToken =
        let apiId = reader.ReadInt32()
        let apiHash = reader.ReadString()
        let exceptIds = reader.ReadVector(fun r -> let reader = r in reader.ReadInt64())

        {
            apiId = apiId
            apiHash = apiHash
            exceptIds = exceptIds
        }

    static member Deserialize(body: byte[]) : AuthExportLoginToken =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthExportLoginToken.DeserializeFields(reader)

type AccountUpdateProfile = {
    firstName: string option
    lastName: string option
    about: string option
} with

    static member ConstructorId: uint32 = 2018596725u

    static member Serialize(writer: TlWriteBuffer, value: AccountUpdateProfile) : unit =
        writer.WriteConstructorId(2018596725u)
        let mutable flags = 0

        if value.firstName.IsSome then
            flags <- flags ||| (1 <<< 0)

        if value.lastName.IsSome then
            flags <- flags ||| (1 <<< 1)

        if value.about.IsSome then
            flags <- flags ||| (1 <<< 2)

        writer.WriteInt32(flags)

        match value.firstName with
        | Some v -> writer.WriteString(v)
        | None -> ()

        match value.lastName with
        | Some v -> writer.WriteString(v)
        | None -> ()

        match value.about with
        | Some v -> writer.WriteString(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : AccountUpdateProfile =
        let flags = reader.ReadInt32()

        let firstName =
            if flags &&& (1 <<< 0) <> 0 then
                Some(reader.ReadString())
            else
                None

        let lastName =
            if flags &&& (1 <<< 1) <> 0 then
                Some(reader.ReadString())
            else
                None

        let about =
            if flags &&& (1 <<< 2) <> 0 then
                Some(reader.ReadString())
            else
                None

        {
            firstName = firstName
            lastName = lastName
            about = about
        }

    static member Deserialize(body: byte[]) : AccountUpdateProfile =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountUpdateProfile.DeserializeFields(reader)

type UsersGetUsers = {
    id: InputUser array
} with

    static member ConstructorId: uint32 = 227648840u

    static member Serialize(writer: TlWriteBuffer, value: UsersGetUsers) : unit =
        writer.WriteConstructorId(227648840u)
        writer.WriteVector(value.id, fun w item -> let writer = w in InputUser.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : UsersGetUsers =
        let id = reader.ReadVector(fun r -> let reader = r in InputUser.Deserialize(reader))
        { id = id }

    static member Deserialize(body: byte[]) : UsersGetUsers =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UsersGetUsers.DeserializeFields(reader)

type UsersGetFullUser = {
    id: InputUser
} with

    static member ConstructorId: uint32 = 3054459160u

    static member Serialize(writer: TlWriteBuffer, value: UsersGetFullUser) : unit =
        writer.WriteConstructorId(3054459160u)
        InputUser.Serialize(writer, value.id)

    static member DeserializeFields(reader: TlReadBuffer) : UsersGetFullUser =
        let id = InputUser.Deserialize(reader)
        { id = id }

    static member Deserialize(body: byte[]) : UsersGetFullUser =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UsersGetFullUser.DeserializeFields(reader)

type ContactsAddContact = {
    addPhonePrivacyException: bool
    id: InputUser
    firstName: string
    lastName: string
    phone: string
} with

    static member ConstructorId: uint32 = 3908330448u

    static member Serialize(writer: TlWriteBuffer, value: ContactsAddContact) : unit =
        writer.WriteConstructorId(3908330448u)
        let mutable flags = 0

        if value.addPhonePrivacyException then
            flags <- flags ||| (1 <<< 0)

        writer.WriteInt32(flags)
        InputUser.Serialize(writer, value.id)
        writer.WriteString(value.firstName)
        writer.WriteString(value.lastName)
        writer.WriteString(value.phone)

    static member DeserializeFields(reader: TlReadBuffer) : ContactsAddContact =
        let flags = reader.ReadInt32()
        let addPhonePrivacyException = flags &&& (1 <<< 0) <> 0
        let id = InputUser.Deserialize(reader)
        let firstName = reader.ReadString()
        let lastName = reader.ReadString()
        let phone = reader.ReadString()

        {
            addPhonePrivacyException = addPhonePrivacyException
            id = id
            firstName = firstName
            lastName = lastName
            phone = phone
        }

    static member Deserialize(body: byte[]) : ContactsAddContact =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsAddContact.DeserializeFields(reader)

type MessagesReadHistory = {
    peer: InputPeer
    maxId: int32
} with

    static member ConstructorId: uint32 = 238054714u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReadHistory) : unit =
        writer.WriteConstructorId(238054714u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.maxId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReadHistory =
        let peer = InputPeer.Deserialize(reader)
        let maxId = reader.ReadInt32()
        { peer = peer; maxId = maxId }

    static member Deserialize(body: byte[]) : MessagesReadHistory =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReadHistory.DeserializeFields(reader)

type MessagesDeleteHistory = {
    justClear: bool
    revoke: bool
    peer: InputPeer
    maxId: int32
    minDate: int32 option
    maxDate: int32 option
} with

    static member ConstructorId: uint32 = 2962199082u

    static member Serialize(writer: TlWriteBuffer, value: MessagesDeleteHistory) : unit =
        writer.WriteConstructorId(2962199082u)
        let mutable flags = 0

        if value.justClear then
            flags <- flags ||| (1 <<< 0)

        if value.revoke then
            flags <- flags ||| (1 <<< 1)

        if value.minDate.IsSome then
            flags <- flags ||| (1 <<< 2)

        if value.maxDate.IsSome then
            flags <- flags ||| (1 <<< 3)

        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.maxId)

        match value.minDate with
        | Some v -> writer.WriteInt32(v)
        | None -> ()

        match value.maxDate with
        | Some v -> writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesDeleteHistory =
        let flags = reader.ReadInt32()
        let justClear = flags &&& (1 <<< 0) <> 0
        let revoke = flags &&& (1 <<< 1) <> 0
        let peer = InputPeer.Deserialize(reader)
        let maxId = reader.ReadInt32()

        let minDate =
            if flags &&& (1 <<< 2) <> 0 then
                Some(reader.ReadInt32())
            else
                None

        let maxDate =
            if flags &&& (1 <<< 3) <> 0 then
                Some(reader.ReadInt32())
            else
                None

        {
            justClear = justClear
            revoke = revoke
            peer = peer
            maxId = maxId
            minDate = minDate
            maxDate = maxDate
        }

    static member Deserialize(body: byte[]) : MessagesDeleteHistory =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesDeleteHistory.DeserializeFields(reader)

type MessagesDeleteMessages = {
    revoke: bool
    id: int32 array
} with

    static member ConstructorId: uint32 = 3851326930u

    static member Serialize(writer: TlWriteBuffer, value: MessagesDeleteMessages) : unit =
        writer.WriteConstructorId(3851326930u)
        let mutable flags = 0

        if value.revoke then
            flags <- flags ||| (1 <<< 0)

        writer.WriteInt32(flags)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesDeleteMessages =
        let flags = reader.ReadInt32()
        let revoke = flags &&& (1 <<< 0) <> 0
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        { revoke = revoke; id = id }

    static member Deserialize(body: byte[]) : MessagesDeleteMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesDeleteMessages.DeserializeFields(reader)

type MessagesGetFullChat = {
    chatId: int64
} with

    static member ConstructorId: uint32 = 2930772788u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetFullChat) : unit =
        writer.WriteConstructorId(2930772788u)
        writer.WriteInt64(value.chatId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetFullChat =
        let chatId = reader.ReadInt64()
        { chatId = chatId }

    static member Deserialize(body: byte[]) : MessagesGetFullChat =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetFullChat.DeserializeFields(reader)

type MessagesAddChatUser = {
    chatId: int64
    userId: InputUser
    fwdLimit: int32
} with

    static member ConstructorId: uint32 = 3418804487u

    static member Serialize(writer: TlWriteBuffer, value: MessagesAddChatUser) : unit =
        writer.WriteConstructorId(3418804487u)
        writer.WriteInt64(value.chatId)
        InputUser.Serialize(writer, value.userId)
        writer.WriteInt32(value.fwdLimit)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesAddChatUser =
        let chatId = reader.ReadInt64()
        let userId = InputUser.Deserialize(reader)
        let fwdLimit = reader.ReadInt32()

        {
            chatId = chatId
            userId = userId
            fwdLimit = fwdLimit
        }

    static member Deserialize(body: byte[]) : MessagesAddChatUser =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesAddChatUser.DeserializeFields(reader)

type MessagesDeleteChatUser = {
    revokeHistory: bool
    chatId: int64
    userId: InputUser
} with

    static member ConstructorId: uint32 = 2719505579u

    static member Serialize(writer: TlWriteBuffer, value: MessagesDeleteChatUser) : unit =
        writer.WriteConstructorId(2719505579u)
        let mutable flags = 0

        if value.revokeHistory then
            flags <- flags ||| (1 <<< 0)

        writer.WriteInt32(flags)
        writer.WriteInt64(value.chatId)
        InputUser.Serialize(writer, value.userId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesDeleteChatUser =
        let flags = reader.ReadInt32()
        let revokeHistory = flags &&& (1 <<< 0) <> 0
        let chatId = reader.ReadInt64()
        let userId = InputUser.Deserialize(reader)

        {
            revokeHistory = revokeHistory
            chatId = chatId
            userId = userId
        }

    static member Deserialize(body: byte[]) : MessagesDeleteChatUser =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesDeleteChatUser.DeserializeFields(reader)

type MessagesCreateChat = {
    users: InputUser array
    title: string
    ttlPeriod: int32 option
} with

    static member ConstructorId: uint32 = 2463030740u

    static member Serialize(writer: TlWriteBuffer, value: MessagesCreateChat) : unit =
        writer.WriteConstructorId(2463030740u)
        let mutable flags = 0

        if value.ttlPeriod.IsSome then
            flags <- flags ||| (1 <<< 0)

        writer.WriteInt32(flags)
        writer.WriteVector(value.users, fun w item -> let writer = w in InputUser.Serialize(writer, item))
        writer.WriteString(value.title)

        match value.ttlPeriod with
        | Some v -> writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesCreateChat =
        let flags = reader.ReadInt32()

        let users =
            reader.ReadVector(fun r -> let reader = r in InputUser.Deserialize(reader))

        let title = reader.ReadString()

        let ttlPeriod =
            if flags &&& (1 <<< 0) <> 0 then
                Some(reader.ReadInt32())
            else
                None

        {
            users = users
            title = title
            ttlPeriod = ttlPeriod
        }

    static member Deserialize(body: byte[]) : MessagesCreateChat =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesCreateChat.DeserializeFields(reader)

type UpdatesGetDifference = {
    pts: int32
    ptsLimit: int32 option
    ptsTotalLimit: int32 option
    date: int32
    qts: int32
    qtsLimit: int32 option
} with

    static member ConstructorId: uint32 = 432207715u

    static member Serialize(writer: TlWriteBuffer, value: UpdatesGetDifference) : unit =
        writer.WriteConstructorId(432207715u)
        let mutable flags = 0

        if value.ptsLimit.IsSome then
            flags <- flags ||| (1 <<< 1)

        if value.ptsTotalLimit.IsSome then
            flags <- flags ||| (1 <<< 0)

        if value.qtsLimit.IsSome then
            flags <- flags ||| (1 <<< 2)

        writer.WriteInt32(flags)
        writer.WriteInt32(value.pts)

        match value.ptsLimit with
        | Some v -> writer.WriteInt32(v)
        | None -> ()

        match value.ptsTotalLimit with
        | Some v -> writer.WriteInt32(v)
        | None -> ()

        writer.WriteInt32(value.date)
        writer.WriteInt32(value.qts)

        match value.qtsLimit with
        | Some v -> writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : UpdatesGetDifference =
        let flags = reader.ReadInt32()
        let pts = reader.ReadInt32()

        let ptsLimit =
            if flags &&& (1 <<< 1) <> 0 then
                Some(reader.ReadInt32())
            else
                None

        let ptsTotalLimit =
            if flags &&& (1 <<< 0) <> 0 then
                Some(reader.ReadInt32())
            else
                None

        let date = reader.ReadInt32()
        let qts = reader.ReadInt32()

        let qtsLimit =
            if flags &&& (1 <<< 2) <> 0 then
                Some(reader.ReadInt32())
            else
                None

        {
            pts = pts
            ptsLimit = ptsLimit
            ptsTotalLimit = ptsTotalLimit
            date = date
            qts = qts
            qtsLimit = qtsLimit
        }

    static member Deserialize(body: byte[]) : UpdatesGetDifference =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UpdatesGetDifference.DeserializeFields(reader)

type UploadSaveFilePart = {
    fileId: int64
    filePart: int32
    bytes: byte[]
} with

    static member ConstructorId: uint32 = 3003426337u

    static member Serialize(writer: TlWriteBuffer, value: UploadSaveFilePart) : unit =
        writer.WriteConstructorId(3003426337u)
        writer.WriteInt64(value.fileId)
        writer.WriteInt32(value.filePart)
        writer.WriteBytes(value.bytes)

    static member DeserializeFields(reader: TlReadBuffer) : UploadSaveFilePart =
        let fileId = reader.ReadInt64()
        let filePart = reader.ReadInt32()
        let bytes = reader.ReadBytes()

        {
            fileId = fileId
            filePart = filePart
            bytes = bytes
        }

    static member Deserialize(body: byte[]) : UploadSaveFilePart =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UploadSaveFilePart.DeserializeFields(reader)

type UploadGetFile = {
    precise: bool
    cdnSupported: bool
    location: InputFileLocation
    offset: int64
    limit: int32
} with

    static member ConstructorId: uint32 = 3193124286u

    static member Serialize(writer: TlWriteBuffer, value: UploadGetFile) : unit =
        writer.WriteConstructorId(3193124286u)
        let mutable flags = 0

        if value.precise then
            flags <- flags ||| (1 <<< 0)

        if value.cdnSupported then
            flags <- flags ||| (1 <<< 1)

        writer.WriteInt32(flags)
        InputFileLocation.Serialize(writer, value.location)
        writer.WriteInt64(value.offset)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : UploadGetFile =
        let flags = reader.ReadInt32()
        let precise = flags &&& (1 <<< 0) <> 0
        let cdnSupported = flags &&& (1 <<< 1) <> 0
        let location = InputFileLocation.Deserialize(reader)
        let offset = reader.ReadInt64()
        let limit = reader.ReadInt32()

        {
            precise = precise
            cdnSupported = cdnSupported
            location = location
            offset = offset
            limit = limit
        }

    static member Deserialize(body: byte[]) : UploadGetFile =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UploadGetFile.DeserializeFields(reader)

type UploadSaveBigFilePart = {
    fileId: int64
    filePart: int32
    fileTotalParts: int32
    bytes: byte[]
} with

    static member ConstructorId: uint32 = 3732629309u

    static member Serialize(writer: TlWriteBuffer, value: UploadSaveBigFilePart) : unit =
        writer.WriteConstructorId(3732629309u)
        writer.WriteInt64(value.fileId)
        writer.WriteInt32(value.filePart)
        writer.WriteInt32(value.fileTotalParts)
        writer.WriteBytes(value.bytes)

    static member DeserializeFields(reader: TlReadBuffer) : UploadSaveBigFilePart =
        let fileId = reader.ReadInt64()
        let filePart = reader.ReadInt32()
        let fileTotalParts = reader.ReadInt32()
        let bytes = reader.ReadBytes()

        {
            fileId = fileId
            filePart = filePart
            fileTotalParts = fileTotalParts
            bytes = bytes
        }

    static member Deserialize(body: byte[]) : UploadSaveBigFilePart =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UploadSaveBigFilePart.DeserializeFields(reader)

type ChannelsEditTitle = {
    channel: InputChannel
    title: string
} with

    static member ConstructorId: uint32 = 1450044624u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsEditTitle) : unit =
        writer.WriteConstructorId(1450044624u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteString(value.title)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsEditTitle =
        let channel = InputChannel.Deserialize(reader)
        let title = reader.ReadString()
        { channel = channel; title = title }

    static member Deserialize(body: byte[]) : ChannelsEditTitle =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsEditTitle.DeserializeFields(reader)

type ChannelsJoinChannel = {
    channel: InputChannel
} with

    static member ConstructorId: uint32 = 615851205u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsJoinChannel) : unit =
        writer.WriteConstructorId(615851205u)
        InputChannel.Serialize(writer, value.channel)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsJoinChannel =
        let channel = InputChannel.Deserialize(reader)
        { channel = channel }

    static member Deserialize(body: byte[]) : ChannelsJoinChannel =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsJoinChannel.DeserializeFields(reader)

type ChannelsLeaveChannel = {
    channel: InputChannel
} with

    static member ConstructorId: uint32 = 4164332181u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsLeaveChannel) : unit =
        writer.WriteConstructorId(4164332181u)
        InputChannel.Serialize(writer, value.channel)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsLeaveChannel =
        let channel = InputChannel.Deserialize(reader)
        { channel = channel }

    static member Deserialize(body: byte[]) : ChannelsLeaveChannel =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsLeaveChannel.DeserializeFields(reader)

type LangpackGetLangPack = {
    langPack: string
    langCode: string
} with

    static member ConstructorId: uint32 = 4075959050u

    static member Serialize(writer: TlWriteBuffer, value: LangpackGetLangPack) : unit =
        writer.WriteConstructorId(4075959050u)
        writer.WriteString(value.langPack)
        writer.WriteString(value.langCode)

    static member DeserializeFields(reader: TlReadBuffer) : LangpackGetLangPack =
        let langPack = reader.ReadString()
        let langCode = reader.ReadString()

        {
            langPack = langPack
            langCode = langCode
        }

    static member Deserialize(body: byte[]) : LangpackGetLangPack =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        LangpackGetLangPack.DeserializeFields(reader)

type LangpackGetStrings = {
    langPack: string
    langCode: string
    keys: string array
} with

    static member ConstructorId: uint32 = 4025104387u

    static member Serialize(writer: TlWriteBuffer, value: LangpackGetStrings) : unit =
        writer.WriteConstructorId(4025104387u)
        writer.WriteString(value.langPack)
        writer.WriteString(value.langCode)
        writer.WriteVector(value.keys, fun w item -> let writer = w in writer.WriteString(item))

    static member DeserializeFields(reader: TlReadBuffer) : LangpackGetStrings =
        let langPack = reader.ReadString()
        let langCode = reader.ReadString()
        let keys = reader.ReadVector(fun r -> let reader = r in reader.ReadString())

        {
            langPack = langPack
            langCode = langCode
            keys = keys
        }

    static member Deserialize(body: byte[]) : LangpackGetStrings =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        LangpackGetStrings.DeserializeFields(reader)

type LangpackGetDifference = {
    langPack: string
    langCode: string
    fromVersion: int32
} with

    static member ConstructorId: uint32 = 3449309861u

    static member Serialize(writer: TlWriteBuffer, value: LangpackGetDifference) : unit =
        writer.WriteConstructorId(3449309861u)
        writer.WriteString(value.langPack)
        writer.WriteString(value.langCode)
        writer.WriteInt32(value.fromVersion)

    static member DeserializeFields(reader: TlReadBuffer) : LangpackGetDifference =
        let langPack = reader.ReadString()
        let langCode = reader.ReadString()
        let fromVersion = reader.ReadInt32()

        {
            langPack = langPack
            langCode = langCode
            fromVersion = fromVersion
        }

    static member Deserialize(body: byte[]) : LangpackGetDifference =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        LangpackGetDifference.DeserializeFields(reader)

type LangpackGetLanguages = {
    langPack: string
} with

    static member ConstructorId: uint32 = 1120311183u

    static member Serialize(writer: TlWriteBuffer, value: LangpackGetLanguages) : unit =
        writer.WriteConstructorId(1120311183u)
        writer.WriteString(value.langPack)

    static member DeserializeFields(reader: TlReadBuffer) : LangpackGetLanguages =
        let langPack = reader.ReadString()
        { langPack = langPack }

    static member Deserialize(body: byte[]) : LangpackGetLanguages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        LangpackGetLanguages.DeserializeFields(reader)

type LangpackGetLanguage = {
    langPack: string
    langCode: string
} with

    static member ConstructorId: uint32 = 1784243458u

    static member Serialize(writer: TlWriteBuffer, value: LangpackGetLanguage) : unit =
        writer.WriteConstructorId(1784243458u)
        writer.WriteString(value.langPack)
        writer.WriteString(value.langCode)

    static member DeserializeFields(reader: TlReadBuffer) : LangpackGetLanguage =
        let langPack = reader.ReadString()
        let langCode = reader.ReadString()

        {
            langPack = langPack
            langCode = langCode
        }

    static member Deserialize(body: byte[]) : LangpackGetLanguage =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        LangpackGetLanguage.DeserializeFields(reader)
