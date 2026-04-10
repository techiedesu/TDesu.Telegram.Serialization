// Auto-generated at 3/30/2026 1:55:16 PM +07:00
// Do not edit manually.

namespace TDesu.Serialization.Requests

open TDesu.Serialization

type AccountDaysTTL = {
    days: int32
}
with
    static member ConstructorId: uint32 = 3100684255u

    static member Serialize(writer: TlWriteBuffer, value: AccountDaysTTL) : unit =
        writer.WriteConstructorId(3100684255u)
        writer.WriteInt32(value.days)

    static member Deserialize(reader: TlReadBuffer) : AccountDaysTTL =
        let _cid = reader.ReadConstructorId()
        let days = reader.ReadInt32()
        {
            days = days
        }

type Birthday = {
    day: int32
    month: int32
    year: int32 option
}
with
    static member ConstructorId: uint32 = 1821253126u

    static member Serialize(writer: TlWriteBuffer, value: Birthday) : unit =
        writer.WriteConstructorId(1821253126u)
        let mutable flags = 0
        if value.year.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.day)
        writer.WriteInt32(value.month)
        match value.year with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : Birthday =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let day = reader.ReadInt32()
        let month = reader.ReadInt32()
        let year = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        {
            day = day
            month = month
            year = year
        }

type ChannelParticipantsFilter =
    | ChannelParticipantsRecent
    | ChannelParticipantsAdmins
    | ChannelParticipantsKicked of q: string
    | ChannelParticipantsBots
    | ChannelParticipantsBanned of q: string
    | ChannelParticipantsSearch of q: string
    | ChannelParticipantsContacts of q: string
    | ChannelParticipantsMentions of q: string option * topMsgId: int32 option
with
    static member Serialize(writer: TlWriteBuffer, value: ChannelParticipantsFilter) : unit =
        match value with
        | ChannelParticipantsRecent ->
            writer.WriteConstructorId(3728686201u)
        | ChannelParticipantsAdmins ->
            writer.WriteConstructorId(3026225513u)
        | ChannelParticipantsKicked(q) ->
            writer.WriteConstructorId(2746567045u)
            writer.WriteString(q)
        | ChannelParticipantsBots ->
            writer.WriteConstructorId(2966521435u)
        | ChannelParticipantsBanned(q) ->
            writer.WriteConstructorId(338142689u)
            writer.WriteString(q)
        | ChannelParticipantsSearch(q) ->
            writer.WriteConstructorId(106343499u)
            writer.WriteString(q)
        | ChannelParticipantsContacts(q) ->
            writer.WriteConstructorId(3144345741u)
            writer.WriteString(q)
        | ChannelParticipantsMentions(q, topMsgId) ->
            writer.WriteConstructorId(3763035371u)
            match q with Some v -> writer.WriteString(v) | None -> ()
            match topMsgId with Some v -> writer.WriteInt32(v) | None -> ()

    static member Deserialize(reader: TlReadBuffer) : ChannelParticipantsFilter =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 3728686201u ->
            ChannelParticipantsRecent
        | 3026225513u ->
            ChannelParticipantsAdmins
        | 2746567045u ->
            let q = reader.ReadString()
            ChannelParticipantsKicked(q)
        | 2966521435u ->
            ChannelParticipantsBots
        | 338142689u ->
            let q = reader.ReadString()
            ChannelParticipantsBanned(q)
        | 106343499u ->
            let q = reader.ReadString()
            ChannelParticipantsSearch(q)
        | 3144345741u ->
            let q = reader.ReadString()
            ChannelParticipantsContacts(q)
        | 3763035371u ->
            let flags = reader.ReadInt32()
            let q = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
            let topMsgId = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
            ChannelParticipantsMentions(q, topMsgId)
        | _ -> failwith $"Unknown constructor id for ChannelParticipantsFilter: 0x{ctorId:X08}"

type ChatAdminRights = {
    changeInfo: bool
    postMessages: bool
    editMessages: bool
    deleteMessages: bool
    banUsers: bool
    inviteUsers: bool
    pinMessages: bool
    addAdmins: bool
    anonymous: bool
    manageCall: bool
    other: bool
    manageTopics: bool
    postStories: bool
    editStories: bool
    deleteStories: bool
    manageDirectMessages: bool
}
with
    static member ConstructorId: uint32 = 1605510357u

    static member Serialize(writer: TlWriteBuffer, value: ChatAdminRights) : unit =
        writer.WriteConstructorId(1605510357u)
        let mutable flags = 0
        if value.changeInfo then flags <- flags ||| (1 <<< 0)
        if value.postMessages then flags <- flags ||| (1 <<< 1)
        if value.editMessages then flags <- flags ||| (1 <<< 2)
        if value.deleteMessages then flags <- flags ||| (1 <<< 3)
        if value.banUsers then flags <- flags ||| (1 <<< 4)
        if value.inviteUsers then flags <- flags ||| (1 <<< 5)
        if value.pinMessages then flags <- flags ||| (1 <<< 7)
        if value.addAdmins then flags <- flags ||| (1 <<< 9)
        if value.anonymous then flags <- flags ||| (1 <<< 10)
        if value.manageCall then flags <- flags ||| (1 <<< 11)
        if value.other then flags <- flags ||| (1 <<< 12)
        if value.manageTopics then flags <- flags ||| (1 <<< 13)
        if value.postStories then flags <- flags ||| (1 <<< 14)
        if value.editStories then flags <- flags ||| (1 <<< 15)
        if value.deleteStories then flags <- flags ||| (1 <<< 16)
        if value.manageDirectMessages then flags <- flags ||| (1 <<< 17)
        writer.WriteInt32(flags)

    static member Deserialize(reader: TlReadBuffer) : ChatAdminRights =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let changeInfo = flags &&& (1 <<< 0) <> 0
        let postMessages = flags &&& (1 <<< 1) <> 0
        let editMessages = flags &&& (1 <<< 2) <> 0
        let deleteMessages = flags &&& (1 <<< 3) <> 0
        let banUsers = flags &&& (1 <<< 4) <> 0
        let inviteUsers = flags &&& (1 <<< 5) <> 0
        let pinMessages = flags &&& (1 <<< 7) <> 0
        let addAdmins = flags &&& (1 <<< 9) <> 0
        let anonymous = flags &&& (1 <<< 10) <> 0
        let manageCall = flags &&& (1 <<< 11) <> 0
        let other = flags &&& (1 <<< 12) <> 0
        let manageTopics = flags &&& (1 <<< 13) <> 0
        let postStories = flags &&& (1 <<< 14) <> 0
        let editStories = flags &&& (1 <<< 15) <> 0
        let deleteStories = flags &&& (1 <<< 16) <> 0
        let manageDirectMessages = flags &&& (1 <<< 17) <> 0
        {
            changeInfo = changeInfo
            postMessages = postMessages
            editMessages = editMessages
            deleteMessages = deleteMessages
            banUsers = banUsers
            inviteUsers = inviteUsers
            pinMessages = pinMessages
            addAdmins = addAdmins
            anonymous = anonymous
            manageCall = manageCall
            other = other
            manageTopics = manageTopics
            postStories = postStories
            editStories = editStories
            deleteStories = deleteStories
            manageDirectMessages = manageDirectMessages
        }

type ChatBannedRights = {
    viewMessages: bool
    sendMessages: bool
    sendMedia: bool
    sendStickers: bool
    sendGifs: bool
    sendGames: bool
    sendInline: bool
    embedLinks: bool
    sendPolls: bool
    changeInfo: bool
    inviteUsers: bool
    pinMessages: bool
    manageTopics: bool
    sendPhotos: bool
    sendVideos: bool
    sendRoundvideos: bool
    sendAudios: bool
    sendVoices: bool
    sendDocs: bool
    sendPlain: bool
    untilDate: int32
}
with
    static member ConstructorId: uint32 = 2668758040u

    static member Serialize(writer: TlWriteBuffer, value: ChatBannedRights) : unit =
        writer.WriteConstructorId(2668758040u)
        let mutable flags = 0
        if value.viewMessages then flags <- flags ||| (1 <<< 0)
        if value.sendMessages then flags <- flags ||| (1 <<< 1)
        if value.sendMedia then flags <- flags ||| (1 <<< 2)
        if value.sendStickers then flags <- flags ||| (1 <<< 3)
        if value.sendGifs then flags <- flags ||| (1 <<< 4)
        if value.sendGames then flags <- flags ||| (1 <<< 5)
        if value.sendInline then flags <- flags ||| (1 <<< 6)
        if value.embedLinks then flags <- flags ||| (1 <<< 7)
        if value.sendPolls then flags <- flags ||| (1 <<< 8)
        if value.changeInfo then flags <- flags ||| (1 <<< 10)
        if value.inviteUsers then flags <- flags ||| (1 <<< 15)
        if value.pinMessages then flags <- flags ||| (1 <<< 17)
        if value.manageTopics then flags <- flags ||| (1 <<< 18)
        if value.sendPhotos then flags <- flags ||| (1 <<< 19)
        if value.sendVideos then flags <- flags ||| (1 <<< 20)
        if value.sendRoundvideos then flags <- flags ||| (1 <<< 21)
        if value.sendAudios then flags <- flags ||| (1 <<< 22)
        if value.sendVoices then flags <- flags ||| (1 <<< 23)
        if value.sendDocs then flags <- flags ||| (1 <<< 24)
        if value.sendPlain then flags <- flags ||| (1 <<< 25)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.untilDate)

    static member Deserialize(reader: TlReadBuffer) : ChatBannedRights =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let viewMessages = flags &&& (1 <<< 0) <> 0
        let sendMessages = flags &&& (1 <<< 1) <> 0
        let sendMedia = flags &&& (1 <<< 2) <> 0
        let sendStickers = flags &&& (1 <<< 3) <> 0
        let sendGifs = flags &&& (1 <<< 4) <> 0
        let sendGames = flags &&& (1 <<< 5) <> 0
        let sendInline = flags &&& (1 <<< 6) <> 0
        let embedLinks = flags &&& (1 <<< 7) <> 0
        let sendPolls = flags &&& (1 <<< 8) <> 0
        let changeInfo = flags &&& (1 <<< 10) <> 0
        let inviteUsers = flags &&& (1 <<< 15) <> 0
        let pinMessages = flags &&& (1 <<< 17) <> 0
        let manageTopics = flags &&& (1 <<< 18) <> 0
        let sendPhotos = flags &&& (1 <<< 19) <> 0
        let sendVideos = flags &&& (1 <<< 20) <> 0
        let sendRoundvideos = flags &&& (1 <<< 21) <> 0
        let sendAudios = flags &&& (1 <<< 22) <> 0
        let sendVoices = flags &&& (1 <<< 23) <> 0
        let sendDocs = flags &&& (1 <<< 24) <> 0
        let sendPlain = flags &&& (1 <<< 25) <> 0
        let untilDate = reader.ReadInt32()
        {
            viewMessages = viewMessages
            sendMessages = sendMessages
            sendMedia = sendMedia
            sendStickers = sendStickers
            sendGifs = sendGifs
            sendGames = sendGames
            sendInline = sendInline
            embedLinks = embedLinks
            sendPolls = sendPolls
            changeInfo = changeInfo
            inviteUsers = inviteUsers
            pinMessages = pinMessages
            manageTopics = manageTopics
            sendPhotos = sendPhotos
            sendVideos = sendVideos
            sendRoundvideos = sendRoundvideos
            sendAudios = sendAudios
            sendVoices = sendVoices
            sendDocs = sendDocs
            sendPlain = sendPlain
            untilDate = untilDate
        }

type ChatPhoto =
    | ChatPhotoEmpty
    | ChatPhoto of hasVideo: bool * photoId: int64 * strippedThumb: byte[] option * dcId: int32
with
    static member Serialize(writer: TlWriteBuffer, value: ChatPhoto) : unit =
        match value with
        | ChatPhotoEmpty ->
            writer.WriteConstructorId(935395612u)
        | ChatPhoto(hasVideo, photoId, strippedThumb, dcId) ->
            writer.WriteConstructorId(476978193u)
            writer.WriteBool(hasVideo)
            writer.WriteInt64(photoId)
            match strippedThumb with Some v -> writer.WriteBytes(v) | None -> ()
            writer.WriteInt32(dcId)

    static member Deserialize(reader: TlReadBuffer) : ChatPhoto =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 935395612u ->
            ChatPhotoEmpty
        | 476978193u ->
            let flags = reader.ReadInt32()
            let hasVideo = flags &&& (1 <<< 0) <> 0
            let photoId = reader.ReadInt64()
            let strippedThumb = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadBytes()) else None
            let dcId = reader.ReadInt32()
            ChatPhoto(hasVideo, photoId, strippedThumb, dcId)
        | _ -> failwith $"Unknown constructor id for ChatPhoto: 0x{ctorId:X08}"

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
}
with
    static member ConstructorId: uint32 = 2904898936u

    static member Serialize(writer: TlWriteBuffer, value: CodeSettings) : unit =
        writer.WriteConstructorId(2904898936u)
        let mutable flags = 0
        if value.allowFlashcall then flags <- flags ||| (1 <<< 0)
        if value.currentNumber then flags <- flags ||| (1 <<< 1)
        if value.allowAppHash then flags <- flags ||| (1 <<< 4)
        if value.allowMissedCall then flags <- flags ||| (1 <<< 5)
        if value.allowFirebase then flags <- flags ||| (1 <<< 7)
        if value.unknownNumber then flags <- flags ||| (1 <<< 9)
        if value.logoutTokens.IsSome then flags <- flags ||| (1 <<< 6)
        if value.token.IsSome then flags <- flags ||| (1 <<< 8)
        if value.appSandbox.IsSome then flags <- flags ||| (1 <<< 8)
        writer.WriteInt32(flags)
        match value.logoutTokens with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in writer.WriteBytes(item))
        | None -> ()
        match value.token with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.appSandbox with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : CodeSettings =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let allowFlashcall = flags &&& (1 <<< 0) <> 0
        let currentNumber = flags &&& (1 <<< 1) <> 0
        let allowAppHash = flags &&& (1 <<< 4) <> 0
        let allowMissedCall = flags &&& (1 <<< 5) <> 0
        let allowFirebase = flags &&& (1 <<< 7) <> 0
        let unknownNumber = flags &&& (1 <<< 9) <> 0
        let logoutTokens = if flags &&& (1 <<< 6) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in reader.ReadBytes())) else None
        let token = if flags &&& (1 <<< 8) <> 0 then Some(reader.ReadString()) else None
        let appSandbox = if flags &&& (1 <<< 8) <> 0 then Some(reader.ReadBool()) else None
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

type DataJSON = {
    data: string
}
with
    static member ConstructorId: uint32 = 2104790276u

    static member Serialize(writer: TlWriteBuffer, value: DataJSON) : unit =
        writer.WriteConstructorId(2104790276u)
        writer.WriteString(value.data)

    static member Deserialize(reader: TlReadBuffer) : DataJSON =
        let _cid = reader.ReadConstructorId()
        let data = reader.ReadString()
        {
            data = data
        }

type DisallowedGiftsSettings = {
    disallowUnlimitedStargifts: bool
    disallowLimitedStargifts: bool
    disallowUniqueStargifts: bool
    disallowPremiumGifts: bool
}
with
    static member ConstructorId: uint32 = 1911715524u

    static member Serialize(writer: TlWriteBuffer, value: DisallowedGiftsSettings) : unit =
        writer.WriteConstructorId(1911715524u)
        let mutable flags = 0
        if value.disallowUnlimitedStargifts then flags <- flags ||| (1 <<< 0)
        if value.disallowLimitedStargifts then flags <- flags ||| (1 <<< 1)
        if value.disallowUniqueStargifts then flags <- flags ||| (1 <<< 2)
        if value.disallowPremiumGifts then flags <- flags ||| (1 <<< 3)
        writer.WriteInt32(flags)

    static member Deserialize(reader: TlReadBuffer) : DisallowedGiftsSettings =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let disallowUnlimitedStargifts = flags &&& (1 <<< 0) <> 0
        let disallowLimitedStargifts = flags &&& (1 <<< 1) <> 0
        let disallowUniqueStargifts = flags &&& (1 <<< 2) <> 0
        let disallowPremiumGifts = flags &&& (1 <<< 3) <> 0
        {
            disallowUnlimitedStargifts = disallowUnlimitedStargifts
            disallowLimitedStargifts = disallowLimitedStargifts
            disallowUniqueStargifts = disallowUniqueStargifts
            disallowPremiumGifts = disallowPremiumGifts
        }

type EmailVerification =
    | EmailVerificationCode of code: string
    | EmailVerificationGoogle of token: string
    | EmailVerificationApple of token: string
with
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

type Folder = {
    autofillNewBroadcasts: bool
    autofillPublicGroups: bool
    autofillNewCorrespondents: bool
    id: int32
    title: string
    photo: ChatPhoto option
}
with
    static member ConstructorId: uint32 = 4283715173u

    static member Serialize(writer: TlWriteBuffer, value: Folder) : unit =
        writer.WriteConstructorId(4283715173u)
        let mutable flags = 0
        if value.autofillNewBroadcasts then flags <- flags ||| (1 <<< 0)
        if value.autofillPublicGroups then flags <- flags ||| (1 <<< 1)
        if value.autofillNewCorrespondents then flags <- flags ||| (1 <<< 2)
        if value.photo.IsSome then flags <- flags ||| (1 <<< 3)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.id)
        writer.WriteString(value.title)
        match value.photo with
        | Some v ->
            ChatPhoto.Serialize(writer, v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : Folder =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let autofillNewBroadcasts = flags &&& (1 <<< 0) <> 0
        let autofillPublicGroups = flags &&& (1 <<< 1) <> 0
        let autofillNewCorrespondents = flags &&& (1 <<< 2) <> 0
        let id = reader.ReadInt32()
        let title = reader.ReadString()
        let photo = if flags &&& (1 <<< 3) <> 0 then Some(ChatPhoto.Deserialize(reader)) else None
        {
            autofillNewBroadcasts = autofillNewBroadcasts
            autofillPublicGroups = autofillPublicGroups
            autofillNewCorrespondents = autofillNewCorrespondents
            id = id
            title = title
            photo = photo
        }

type GlobalPrivacySettings = {
    archiveAndMuteNewNoncontactPeers: bool
    keepArchivedUnmuted: bool
    keepArchivedFolders: bool
    hideReadMarks: bool
    newNoncontactPeersRequirePremium: bool
    displayGiftsButton: bool
    noncontactPeersPaidStars: int64 option
    disallowedGifts: DisallowedGiftsSettings option
}
with
    static member ConstructorId: uint32 = 4265718607u

    static member Serialize(writer: TlWriteBuffer, value: GlobalPrivacySettings) : unit =
        writer.WriteConstructorId(4265718607u)
        let mutable flags = 0
        if value.archiveAndMuteNewNoncontactPeers then flags <- flags ||| (1 <<< 0)
        if value.keepArchivedUnmuted then flags <- flags ||| (1 <<< 1)
        if value.keepArchivedFolders then flags <- flags ||| (1 <<< 2)
        if value.hideReadMarks then flags <- flags ||| (1 <<< 3)
        if value.newNoncontactPeersRequirePremium then flags <- flags ||| (1 <<< 4)
        if value.displayGiftsButton then flags <- flags ||| (1 <<< 7)
        if value.noncontactPeersPaidStars.IsSome then flags <- flags ||| (1 <<< 5)
        if value.disallowedGifts.IsSome then flags <- flags ||| (1 <<< 6)
        writer.WriteInt32(flags)
        match value.noncontactPeersPaidStars with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        match value.disallowedGifts with
        | Some v ->
            DisallowedGiftsSettings.Serialize(writer, v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : GlobalPrivacySettings =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let archiveAndMuteNewNoncontactPeers = flags &&& (1 <<< 0) <> 0
        let keepArchivedUnmuted = flags &&& (1 <<< 1) <> 0
        let keepArchivedFolders = flags &&& (1 <<< 2) <> 0
        let hideReadMarks = flags &&& (1 <<< 3) <> 0
        let newNoncontactPeersRequirePremium = flags &&& (1 <<< 4) <> 0
        let displayGiftsButton = flags &&& (1 <<< 7) <> 0
        let noncontactPeersPaidStars = if flags &&& (1 <<< 5) <> 0 then Some(reader.ReadInt64()) else None
        let disallowedGifts = if flags &&& (1 <<< 6) <> 0 then Some(DisallowedGiftsSettings.Deserialize(reader)) else None
        {
            archiveAndMuteNewNoncontactPeers = archiveAndMuteNewNoncontactPeers
            keepArchivedUnmuted = keepArchivedUnmuted
            keepArchivedFolders = keepArchivedFolders
            hideReadMarks = hideReadMarks
            newNoncontactPeersRequirePremium = newNoncontactPeersRequirePremium
            displayGiftsButton = displayGiftsButton
            noncontactPeersPaidStars = noncontactPeersPaidStars
            disallowedGifts = disallowedGifts
        }

type InlineQueryPeerType =
    | InlineQueryPeerTypeSameBotPM
    | InlineQueryPeerTypePM
    | InlineQueryPeerTypeChat
    | InlineQueryPeerTypeMegagroup
    | InlineQueryPeerTypeBroadcast
    | InlineQueryPeerTypeBotPM
with
    static member Serialize(writer: TlWriteBuffer, value: InlineQueryPeerType) : unit =
        match value with
        | InlineQueryPeerTypeSameBotPM ->
            writer.WriteConstructorId(813821341u)
        | InlineQueryPeerTypePM ->
            writer.WriteConstructorId(2201751468u)
        | InlineQueryPeerTypeChat ->
            writer.WriteConstructorId(3613836554u)
        | InlineQueryPeerTypeMegagroup ->
            writer.WriteConstructorId(1589952067u)
        | InlineQueryPeerTypeBroadcast ->
            writer.WriteConstructorId(1664413338u)
        | InlineQueryPeerTypeBotPM ->
            writer.WriteConstructorId(238759180u)

    static member Deserialize(reader: TlReadBuffer) : InlineQueryPeerType =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 813821341u ->
            InlineQueryPeerTypeSameBotPM
        | 2201751468u ->
            InlineQueryPeerTypePM
        | 3613836554u ->
            InlineQueryPeerTypeChat
        | 1589952067u ->
            InlineQueryPeerTypeMegagroup
        | 1664413338u ->
            InlineQueryPeerTypeBroadcast
        | 238759180u ->
            InlineQueryPeerTypeBotPM
        | _ -> failwith $"Unknown constructor id for InlineQueryPeerType: 0x{ctorId:X08}"

type InputCheckPasswordSRP =
    | InputCheckPasswordEmpty
    | InputCheckPasswordSRP of srpId: int64 * a: byte[] * m1: byte[]
with
    static member Serialize(writer: TlWriteBuffer, value: InputCheckPasswordSRP) : unit =
        match value with
        | InputCheckPasswordEmpty ->
            writer.WriteConstructorId(2558588504u)
        | InputCheckPasswordSRP(srpId, a, m1) ->
            writer.WriteConstructorId(3531600002u)
            writer.WriteInt64(srpId)
            writer.WriteBytes(a)
            writer.WriteBytes(m1)

    static member Deserialize(reader: TlReadBuffer) : InputCheckPasswordSRP =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2558588504u ->
            InputCheckPasswordEmpty
        | 3531600002u ->
            let srpId = reader.ReadInt64()
            let a = reader.ReadBytes()
            let m1 = reader.ReadBytes()
            InputCheckPasswordSRP(srpId, a, m1)
        | _ -> failwith $"Unknown constructor id for InputCheckPasswordSRP: 0x{ctorId:X08}"

type InputContact = {
    clientId: int64
    phone: string
    firstName: string
    lastName: string
}
with
    static member ConstructorId: uint32 = 4086478836u

    static member Serialize(writer: TlWriteBuffer, value: InputContact) : unit =
        writer.WriteConstructorId(4086478836u)
        writer.WriteInt64(value.clientId)
        writer.WriteString(value.phone)
        writer.WriteString(value.firstName)
        writer.WriteString(value.lastName)

    static member Deserialize(reader: TlReadBuffer) : InputContact =
        let _cid = reader.ReadConstructorId()
        let clientId = reader.ReadInt64()
        let phone = reader.ReadString()
        let firstName = reader.ReadString()
        let lastName = reader.ReadString()
        {
            clientId = clientId
            phone = phone
            firstName = firstName
            lastName = lastName
        }

type InputDocument =
    | InputDocumentEmpty
    | InputDocument of id: int64 * accessHash: int64 * fileReference: byte[]
with
    static member Serialize(writer: TlWriteBuffer, value: InputDocument) : unit =
        match value with
        | InputDocumentEmpty ->
            writer.WriteConstructorId(1928391342u)
        | InputDocument(id, accessHash, fileReference) ->
            writer.WriteConstructorId(448771445u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
            writer.WriteBytes(fileReference)

    static member Deserialize(reader: TlReadBuffer) : InputDocument =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 1928391342u ->
            InputDocumentEmpty
        | 448771445u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            let fileReference = reader.ReadBytes()
            InputDocument(id, accessHash, fileReference)
        | _ -> failwith $"Unknown constructor id for InputDocument: 0x{ctorId:X08}"

type InputEncryptedChat = {
    chatId: int32
    accessHash: int64
}
with
    static member ConstructorId: uint32 = 4047615457u

    static member Serialize(writer: TlWriteBuffer, value: InputEncryptedChat) : unit =
        writer.WriteConstructorId(4047615457u)
        writer.WriteInt32(value.chatId)
        writer.WriteInt64(value.accessHash)

    static member Deserialize(reader: TlReadBuffer) : InputEncryptedChat =
        let _cid = reader.ReadConstructorId()
        let chatId = reader.ReadInt32()
        let accessHash = reader.ReadInt64()
        {
            chatId = chatId
            accessHash = accessHash
        }

type InputEncryptedFile =
    | InputEncryptedFileEmpty
    | InputEncryptedFileUploaded of id: int64 * parts: int32 * md5Checksum: string * keyFingerprint: int32
    | InputEncryptedFile of id: int64 * accessHash: int64
    | InputEncryptedFileBigUploaded of id: int64 * parts: int32 * keyFingerprint: int32
with
    static member Serialize(writer: TlWriteBuffer, value: InputEncryptedFile) : unit =
        match value with
        | InputEncryptedFileEmpty ->
            writer.WriteConstructorId(406307684u)
        | InputEncryptedFileUploaded(id, parts, md5Checksum, keyFingerprint) ->
            writer.WriteConstructorId(1690108678u)
            writer.WriteInt64(id)
            writer.WriteInt32(parts)
            writer.WriteString(md5Checksum)
            writer.WriteInt32(keyFingerprint)
        | InputEncryptedFile(id, accessHash) ->
            writer.WriteConstructorId(1511503333u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
        | InputEncryptedFileBigUploaded(id, parts, keyFingerprint) ->
            writer.WriteConstructorId(767652808u)
            writer.WriteInt64(id)
            writer.WriteInt32(parts)
            writer.WriteInt32(keyFingerprint)

    static member Deserialize(reader: TlReadBuffer) : InputEncryptedFile =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 406307684u ->
            InputEncryptedFileEmpty
        | 1690108678u ->
            let id = reader.ReadInt64()
            let parts = reader.ReadInt32()
            let md5Checksum = reader.ReadString()
            let keyFingerprint = reader.ReadInt32()
            InputEncryptedFileUploaded(id, parts, md5Checksum, keyFingerprint)
        | 1511503333u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputEncryptedFile(id, accessHash)
        | 767652808u ->
            let id = reader.ReadInt64()
            let parts = reader.ReadInt32()
            let keyFingerprint = reader.ReadInt32()
            InputEncryptedFileBigUploaded(id, parts, keyFingerprint)
        | _ -> failwith $"Unknown constructor id for InputEncryptedFile: 0x{ctorId:X08}"

type InputFile =
    | InputFile of id: int64 * parts: int32 * name: string * md5Checksum: string
    | InputFileBig of id: int64 * parts: int32 * name: string
    | InputFileStoryDocument of id: InputDocument
with
    static member Serialize(writer: TlWriteBuffer, value: InputFile) : unit =
        match value with
        | InputFile(id, parts, name, md5Checksum) ->
            writer.WriteConstructorId(4113560191u)
            writer.WriteInt64(id)
            writer.WriteInt32(parts)
            writer.WriteString(name)
            writer.WriteString(md5Checksum)
        | InputFileBig(id, parts, name) ->
            writer.WriteConstructorId(4199484341u)
            writer.WriteInt64(id)
            writer.WriteInt32(parts)
            writer.WriteString(name)
        | InputFileStoryDocument(id) ->
            writer.WriteConstructorId(1658620744u)
            InputDocument.Serialize(writer, id)

    static member Deserialize(reader: TlReadBuffer) : InputFile =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 4113560191u ->
            let id = reader.ReadInt64()
            let parts = reader.ReadInt32()
            let name = reader.ReadString()
            let md5Checksum = reader.ReadString()
            InputFile(id, parts, name, md5Checksum)
        | 4199484341u ->
            let id = reader.ReadInt64()
            let parts = reader.ReadInt32()
            let name = reader.ReadString()
            InputFileBig(id, parts, name)
        | 1658620744u ->
            let id = InputDocument.Deserialize(reader)
            InputFileStoryDocument(id)
        | _ -> failwith $"Unknown constructor id for InputFile: 0x{ctorId:X08}"

type InputGeoPoint =
    | InputGeoPointEmpty
    | InputGeoPoint of lat: double * long: double * accuracyRadius: int32 option
with
    static member Serialize(writer: TlWriteBuffer, value: InputGeoPoint) : unit =
        match value with
        | InputGeoPointEmpty ->
            writer.WriteConstructorId(3837862870u)
        | InputGeoPoint(lat, long, accuracyRadius) ->
            writer.WriteConstructorId(1210199983u)
            writer.WriteDouble(lat)
            writer.WriteDouble(long)
            match accuracyRadius with Some v -> writer.WriteInt32(v) | None -> ()

    static member Deserialize(reader: TlReadBuffer) : InputGeoPoint =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 3837862870u ->
            InputGeoPointEmpty
        | 1210199983u ->
            let flags = reader.ReadInt32()
            let lat = reader.ReadDouble()
            let long = reader.ReadDouble()
            let accuracyRadius = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            InputGeoPoint(lat, long, accuracyRadius)
        | _ -> failwith $"Unknown constructor id for InputGeoPoint: 0x{ctorId:X08}"

type InputGroupCall =
    | InputGroupCall of id: int64 * accessHash: int64
    | InputGroupCallSlug of slug: string
    | InputGroupCallInviteMessage of msgId: int32
with
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

type InputMessage =
    | InputMessageID of id: int32
    | InputMessageReplyTo of id: int32
    | InputMessagePinned
    | InputMessageCallbackQuery of id: int32 * queryId: int64
with
    static member Serialize(writer: TlWriteBuffer, value: InputMessage) : unit =
        match value with
        | InputMessageID(id) ->
            writer.WriteConstructorId(2792792866u)
            writer.WriteInt32(id)
        | InputMessageReplyTo(id) ->
            writer.WriteConstructorId(3134751637u)
            writer.WriteInt32(id)
        | InputMessagePinned ->
            writer.WriteConstructorId(2257003832u)
        | InputMessageCallbackQuery(id, queryId) ->
            writer.WriteConstructorId(2902071934u)
            writer.WriteInt32(id)
            writer.WriteInt64(queryId)

    static member Deserialize(reader: TlReadBuffer) : InputMessage =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2792792866u ->
            let id = reader.ReadInt32()
            InputMessageID(id)
        | 3134751637u ->
            let id = reader.ReadInt32()
            InputMessageReplyTo(id)
        | 2257003832u ->
            InputMessagePinned
        | 2902071934u ->
            let id = reader.ReadInt32()
            let queryId = reader.ReadInt64()
            InputMessageCallbackQuery(id, queryId)
        | _ -> failwith $"Unknown constructor id for InputMessage: 0x{ctorId:X08}"

type InputPeer =
    | InputPeerEmpty
    | InputPeerSelf
    | InputPeerChat of chatId: int64
    | InputPeerUser of userId: int64 * accessHash: int64
    | InputPeerChannel of channelId: int64 * accessHash: int64
    | InputPeerUserFromMessage of peer: InputPeer * msgId: int32 * userId: int64
    | InputPeerChannelFromMessage of peer: InputPeer * msgId: int32 * channelId: int64
with
    static member Serialize(writer: TlWriteBuffer, value: InputPeer) : unit =
        match value with
        | InputPeerEmpty ->
            writer.WriteConstructorId(2134579434u)
        | InputPeerSelf ->
            writer.WriteConstructorId(2107670217u)
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
        | 2134579434u ->
            InputPeerEmpty
        | 2107670217u ->
            InputPeerSelf
        | 900291769u ->
            let chatId = reader.ReadInt64()
            InputPeerChat(chatId)
        | 3723011404u | 2072935910u ->
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
with
    static member Serialize(writer: TlWriteBuffer, value: InputChannel) : unit =
        match value with
        | InputChannelEmpty ->
            writer.WriteConstructorId(4002160262u)
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
        | 4002160262u ->
            InputChannelEmpty
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

type InputDialogPeer =
    | InputDialogPeer of peer: InputPeer
    | InputDialogPeerFolder of folderId: int32
with
    static member Serialize(writer: TlWriteBuffer, value: InputDialogPeer) : unit =
        match value with
        | InputDialogPeer(peer) ->
            writer.WriteConstructorId(4239064759u)
            InputPeer.Serialize(writer, peer)
        | InputDialogPeerFolder(folderId) ->
            writer.WriteConstructorId(1684014375u)
            writer.WriteInt32(folderId)

    static member Deserialize(reader: TlReadBuffer) : InputDialogPeer =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 4239064759u ->
            let peer = InputPeer.Deserialize(reader)
            InputDialogPeer(peer)
        | 1684014375u ->
            let folderId = reader.ReadInt32()
            InputDialogPeerFolder(folderId)
        | _ -> failwith $"Unknown constructor id for InputDialogPeer: 0x{ctorId:X08}"

type InputFolderPeer = {
    peer: InputPeer
    folderId: int32
}
with
    static member ConstructorId: uint32 = 4224893590u

    static member Serialize(writer: TlWriteBuffer, value: InputFolderPeer) : unit =
        writer.WriteConstructorId(4224893590u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.folderId)

    static member Deserialize(reader: TlReadBuffer) : InputFolderPeer =
        let _cid = reader.ReadConstructorId()
        let peer = InputPeer.Deserialize(reader)
        let folderId = reader.ReadInt32()
        {
            peer = peer
            folderId = folderId
        }

type InputNotifyPeer =
    | InputNotifyPeer of peer: InputPeer
    | InputNotifyUsers
    | InputNotifyChats
    | InputNotifyBroadcasts
    | InputNotifyForumTopic of peer: InputPeer * topMsgId: int32
with
    static member Serialize(writer: TlWriteBuffer, value: InputNotifyPeer) : unit =
        match value with
        | InputNotifyPeer(peer) ->
            writer.WriteConstructorId(3099351820u)
            InputPeer.Serialize(writer, peer)
        | InputNotifyUsers ->
            writer.WriteConstructorId(423314455u)
        | InputNotifyChats ->
            writer.WriteConstructorId(1251338318u)
        | InputNotifyBroadcasts ->
            writer.WriteConstructorId(2983951486u)
        | InputNotifyForumTopic(peer, topMsgId) ->
            writer.WriteConstructorId(1548122514u)
            InputPeer.Serialize(writer, peer)
            writer.WriteInt32(topMsgId)

    static member Deserialize(reader: TlReadBuffer) : InputNotifyPeer =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 3099351820u ->
            let peer = InputPeer.Deserialize(reader)
            InputNotifyPeer(peer)
        | 423314455u ->
            InputNotifyUsers
        | 1251338318u ->
            InputNotifyChats
        | 2983951486u ->
            InputNotifyBroadcasts
        | 1548122514u ->
            let peer = InputPeer.Deserialize(reader)
            let topMsgId = reader.ReadInt32()
            InputNotifyForumTopic(peer, topMsgId)
        | _ -> failwith $"Unknown constructor id for InputNotifyPeer: 0x{ctorId:X08}"

type InputPhoneCall = {
    id: int64
    accessHash: int64
}
with
    static member ConstructorId: uint32 = 506920429u

    static member Serialize(writer: TlWriteBuffer, value: InputPhoneCall) : unit =
        writer.WriteConstructorId(506920429u)
        writer.WriteInt64(value.id)
        writer.WriteInt64(value.accessHash)

    static member Deserialize(reader: TlReadBuffer) : InputPhoneCall =
        let _cid = reader.ReadConstructorId()
        let id = reader.ReadInt64()
        let accessHash = reader.ReadInt64()
        {
            id = id
            accessHash = accessHash
        }

type InputPhoto =
    | InputPhotoEmpty
    | InputPhoto of id: int64 * accessHash: int64 * fileReference: byte[]
with
    static member Serialize(writer: TlWriteBuffer, value: InputPhoto) : unit =
        match value with
        | InputPhotoEmpty ->
            writer.WriteConstructorId(483901197u)
        | InputPhoto(id, accessHash, fileReference) ->
            writer.WriteConstructorId(1001634122u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
            writer.WriteBytes(fileReference)

    static member Deserialize(reader: TlReadBuffer) : InputPhoto =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 483901197u ->
            InputPhotoEmpty
        | 1001634122u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            let fileReference = reader.ReadBytes()
            InputPhoto(id, accessHash, fileReference)
        | _ -> failwith $"Unknown constructor id for InputPhoto: 0x{ctorId:X08}"

type InputPrivacyKey =
    | InputPrivacyKeyStatusTimestamp
    | InputPrivacyKeyChatInvite
    | InputPrivacyKeyPhoneCall
    | InputPrivacyKeyPhoneP2P
    | InputPrivacyKeyForwards
    | InputPrivacyKeyProfilePhoto
    | InputPrivacyKeyPhoneNumber
    | InputPrivacyKeyAddedByPhone
    | InputPrivacyKeyVoiceMessages
    | InputPrivacyKeyAbout
    | InputPrivacyKeyBirthday
    | InputPrivacyKeyStarGiftsAutoSave
    | InputPrivacyKeyNoPaidMessages
with
    static member Serialize(writer: TlWriteBuffer, value: InputPrivacyKey) : unit =
        match value with
        | InputPrivacyKeyStatusTimestamp ->
            writer.WriteConstructorId(1335282456u)
        | InputPrivacyKeyChatInvite ->
            writer.WriteConstructorId(3187344422u)
        | InputPrivacyKeyPhoneCall ->
            writer.WriteConstructorId(4206550111u)
        | InputPrivacyKeyPhoneP2P ->
            writer.WriteConstructorId(3684593874u)
        | InputPrivacyKeyForwards ->
            writer.WriteConstructorId(2765966344u)
        | InputPrivacyKeyProfilePhoto ->
            writer.WriteConstructorId(1461304012u)
        | InputPrivacyKeyPhoneNumber ->
            writer.WriteConstructorId(55761658u)
        | InputPrivacyKeyAddedByPhone ->
            writer.WriteConstructorId(3508640733u)
        | InputPrivacyKeyVoiceMessages ->
            writer.WriteConstructorId(2934349160u)
        | InputPrivacyKeyAbout ->
            writer.WriteConstructorId(941870144u)
        | InputPrivacyKeyBirthday ->
            writer.WriteConstructorId(3596227020u)
        | InputPrivacyKeyStarGiftsAutoSave ->
            writer.WriteConstructorId(3782419265u)
        | InputPrivacyKeyNoPaidMessages ->
            writer.WriteConstructorId(3183843252u)

    static member Deserialize(reader: TlReadBuffer) : InputPrivacyKey =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 1335282456u ->
            InputPrivacyKeyStatusTimestamp
        | 3187344422u ->
            InputPrivacyKeyChatInvite
        | 4206550111u ->
            InputPrivacyKeyPhoneCall
        | 3684593874u ->
            InputPrivacyKeyPhoneP2P
        | 2765966344u ->
            InputPrivacyKeyForwards
        | 1461304012u ->
            InputPrivacyKeyProfilePhoto
        | 55761658u ->
            InputPrivacyKeyPhoneNumber
        | 3508640733u ->
            InputPrivacyKeyAddedByPhone
        | 2934349160u ->
            InputPrivacyKeyVoiceMessages
        | 941870144u ->
            InputPrivacyKeyAbout
        | 3596227020u ->
            InputPrivacyKeyBirthday
        | 3782419265u ->
            InputPrivacyKeyStarGiftsAutoSave
        | 3183843252u ->
            InputPrivacyKeyNoPaidMessages
        | _ -> failwith $"Unknown constructor id for InputPrivacyKey: 0x{ctorId:X08}"

type InputQuickReplyShortcut =
    | InputQuickReplyShortcut of shortcut: string
    | InputQuickReplyShortcutId of shortcutId: int32
with
    static member Serialize(writer: TlWriteBuffer, value: InputQuickReplyShortcut) : unit =
        match value with
        | InputQuickReplyShortcut(shortcut) ->
            writer.WriteConstructorId(609840449u)
            writer.WriteString(shortcut)
        | InputQuickReplyShortcutId(shortcutId) ->
            writer.WriteConstructorId(18418929u)
            writer.WriteInt32(shortcutId)

    static member Deserialize(reader: TlReadBuffer) : InputQuickReplyShortcut =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 609840449u ->
            let shortcut = reader.ReadString()
            InputQuickReplyShortcut(shortcut)
        | 18418929u ->
            let shortcutId = reader.ReadInt32()
            InputQuickReplyShortcutId(shortcutId)
        | _ -> failwith $"Unknown constructor id for InputQuickReplyShortcut: 0x{ctorId:X08}"

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
with
    static member Serialize(writer: TlWriteBuffer, value: InputStickerSet) : unit =
        match value with
        | InputStickerSetEmpty ->
            writer.WriteConstructorId(4290128789u)
        | InputStickerSetID(id, accessHash) ->
            writer.WriteConstructorId(2649203305u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
        | InputStickerSetShortName(shortName) ->
            writer.WriteConstructorId(2250033312u)
            writer.WriteString(shortName)
        | InputStickerSetAnimatedEmoji ->
            writer.WriteConstructorId(42402760u)
        | InputStickerSetDice(emoticon) ->
            writer.WriteConstructorId(3867103758u)
            writer.WriteString(emoticon)
        | InputStickerSetAnimatedEmojiAnimations ->
            writer.WriteConstructorId(215889721u)
        | InputStickerSetPremiumGifts ->
            writer.WriteConstructorId(3364567810u)
        | InputStickerSetEmojiGenericAnimations ->
            writer.WriteConstructorId(80008398u)
        | InputStickerSetEmojiDefaultStatuses ->
            writer.WriteConstructorId(701560302u)
        | InputStickerSetEmojiDefaultTopicIcons ->
            writer.WriteConstructorId(1153562857u)
        | InputStickerSetEmojiChannelDefaultStatuses ->
            writer.WriteConstructorId(1232373075u)
        | InputStickerSetTonGifts ->
            writer.WriteConstructorId(485912992u)

    static member Deserialize(reader: TlReadBuffer) : InputStickerSet =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 4290128789u ->
            InputStickerSetEmpty
        | 2649203305u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputStickerSetID(id, accessHash)
        | 2250033312u ->
            let shortName = reader.ReadString()
            InputStickerSetShortName(shortName)
        | 42402760u ->
            InputStickerSetAnimatedEmoji
        | 3867103758u ->
            let emoticon = reader.ReadString()
            InputStickerSetDice(emoticon)
        | 215889721u ->
            InputStickerSetAnimatedEmojiAnimations
        | 3364567810u ->
            InputStickerSetPremiumGifts
        | 80008398u ->
            InputStickerSetEmojiGenericAnimations
        | 701560302u ->
            InputStickerSetEmojiDefaultStatuses
        | 1153562857u ->
            InputStickerSetEmojiDefaultTopicIcons
        | 1232373075u ->
            InputStickerSetEmojiChannelDefaultStatuses
        | 485912992u ->
            InputStickerSetTonGifts
        | _ -> failwith $"Unknown constructor id for InputStickerSet: 0x{ctorId:X08}"

type InputFileLocation =
    | InputFileLocation of volumeId: int64 * localId: int32 * secret: int64 * fileReference: byte[]
    | InputEncryptedFileLocation of id: int64 * accessHash: int64
    | InputDocumentFileLocation of id: int64 * accessHash: int64 * fileReference: byte[] * thumbSize: string
    | InputSecureFileLocation of id: int64 * accessHash: int64
    | InputTakeoutFileLocation
    | InputPhotoFileLocation of id: int64 * accessHash: int64 * fileReference: byte[] * thumbSize: string
    | InputPhotoLegacyFileLocation of id: int64 * accessHash: int64 * fileReference: byte[] * volumeId: int64 * localId: int32 * secret: int64
    | InputPeerPhotoFileLocation of big: bool * peer: InputPeer * photoId: int64
    | InputStickerSetThumb of stickerset: InputStickerSet * thumbVersion: int32
    | InputGroupCallStream of call: InputGroupCall * timeMs: int64 * scale: int32 * videoChannel: int32 option * videoQuality: int32 option
with
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
        | InputTakeoutFileLocation ->
            writer.WriteConstructorId(700340377u)
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
            match videoChannel with Some v -> writer.WriteInt32(v) | None -> ()
            match videoQuality with Some v -> writer.WriteInt32(v) | None -> ()

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
        | 700340377u ->
            InputTakeoutFileLocation
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
            let videoChannel = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            let videoQuality = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            InputGroupCallStream(call, timeMs, scale, videoChannel, videoQuality)
        | _ -> failwith $"Unknown constructor id for InputFileLocation: 0x{ctorId:X08}"

type InputUser =
    | InputUserEmpty
    | InputUserSelf
    | InputUser of userId: int64 * accessHash: int64
    | InputUserFromMessage of peer: InputPeer * msgId: int32 * userId: int64
with
    static member Serialize(writer: TlWriteBuffer, value: InputUser) : unit =
        match value with
        | InputUserEmpty ->
            writer.WriteConstructorId(3112732367u)
        | InputUserSelf ->
            writer.WriteConstructorId(4156666175u)
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
        | 3112732367u ->
            InputUserEmpty
        | 4156666175u ->
            InputUserSelf
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

type InputGame =
    | InputGameID of id: int64 * accessHash: int64
    | InputGameShortName of botId: InputUser * shortName: string
with
    static member Serialize(writer: TlWriteBuffer, value: InputGame) : unit =
        match value with
        | InputGameID(id, accessHash) ->
            writer.WriteConstructorId(53231223u)
            writer.WriteInt64(id)
            writer.WriteInt64(accessHash)
        | InputGameShortName(botId, shortName) ->
            writer.WriteConstructorId(3274827786u)
            InputUser.Serialize(writer, botId)
            writer.WriteString(shortName)

    static member Deserialize(reader: TlReadBuffer) : InputGame =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 53231223u ->
            let id = reader.ReadInt64()
            let accessHash = reader.ReadInt64()
            InputGameID(id, accessHash)
        | 3274827786u ->
            let botId = InputUser.Deserialize(reader)
            let shortName = reader.ReadString()
            InputGameShortName(botId, shortName)
        | _ -> failwith $"Unknown constructor id for InputGame: 0x{ctorId:X08}"

type InputPrivacyRule =
    | InputPrivacyValueAllowContacts
    | InputPrivacyValueAllowAll
    | InputPrivacyValueAllowUsers of users: InputUser array
    | InputPrivacyValueDisallowContacts
    | InputPrivacyValueDisallowAll
    | InputPrivacyValueDisallowUsers of users: InputUser array
    | InputPrivacyValueAllowChatParticipants of chats: int64 array
    | InputPrivacyValueDisallowChatParticipants of chats: int64 array
    | InputPrivacyValueAllowCloseFriends
    | InputPrivacyValueAllowPremium
    | InputPrivacyValueAllowBots
    | InputPrivacyValueDisallowBots
with
    static member Serialize(writer: TlWriteBuffer, value: InputPrivacyRule) : unit =
        match value with
        | InputPrivacyValueAllowContacts ->
            writer.WriteConstructorId(218751099u)
        | InputPrivacyValueAllowAll ->
            writer.WriteConstructorId(407582158u)
        | InputPrivacyValueAllowUsers(users) ->
            writer.WriteConstructorId(320652927u)
            writer.WriteVector(users, fun w item -> let writer = w in InputUser.Serialize(writer, item))
        | InputPrivacyValueDisallowContacts ->
            writer.WriteConstructorId(195371015u)
        | InputPrivacyValueDisallowAll ->
            writer.WriteConstructorId(3597362889u)
        | InputPrivacyValueDisallowUsers(users) ->
            writer.WriteConstructorId(2417034343u)
            writer.WriteVector(users, fun w item -> let writer = w in InputUser.Serialize(writer, item))
        | InputPrivacyValueAllowChatParticipants(chats) ->
            writer.WriteConstructorId(2215004623u)
            writer.WriteVector(chats, fun w item -> let writer = w in writer.WriteInt64(item))
        | InputPrivacyValueDisallowChatParticipants(chats) ->
            writer.WriteConstructorId(3914272646u)
            writer.WriteVector(chats, fun w item -> let writer = w in writer.WriteInt64(item))
        | InputPrivacyValueAllowCloseFriends ->
            writer.WriteConstructorId(793067081u)
        | InputPrivacyValueAllowPremium ->
            writer.WriteConstructorId(2009975281u)
        | InputPrivacyValueAllowBots ->
            writer.WriteConstructorId(1515179237u)
        | InputPrivacyValueDisallowBots ->
            writer.WriteConstructorId(3303373077u)

    static member Deserialize(reader: TlReadBuffer) : InputPrivacyRule =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 218751099u ->
            InputPrivacyValueAllowContacts
        | 407582158u ->
            InputPrivacyValueAllowAll
        | 320652927u ->
            let users = reader.ReadVector(fun r -> let reader = r in InputUser.Deserialize(reader))
            InputPrivacyValueAllowUsers(users)
        | 195371015u ->
            InputPrivacyValueDisallowContacts
        | 3597362889u ->
            InputPrivacyValueDisallowAll
        | 2417034343u ->
            let users = reader.ReadVector(fun r -> let reader = r in InputUser.Deserialize(reader))
            InputPrivacyValueDisallowUsers(users)
        | 2215004623u ->
            let chats = reader.ReadVector(fun r -> let reader = r in reader.ReadInt64())
            InputPrivacyValueAllowChatParticipants(chats)
        | 3914272646u ->
            let chats = reader.ReadVector(fun r -> let reader = r in reader.ReadInt64())
            InputPrivacyValueDisallowChatParticipants(chats)
        | 793067081u ->
            InputPrivacyValueAllowCloseFriends
        | 2009975281u ->
            InputPrivacyValueAllowPremium
        | 1515179237u ->
            InputPrivacyValueAllowBots
        | 3303373077u ->
            InputPrivacyValueDisallowBots
        | _ -> failwith $"Unknown constructor id for InputPrivacyRule: 0x{ctorId:X08}"

type LabeledPrice = {
    label: string
    amount: int64
}
with
    static member ConstructorId: uint32 = 3408489464u

    static member Serialize(writer: TlWriteBuffer, value: LabeledPrice) : unit =
        writer.WriteConstructorId(3408489464u)
        writer.WriteString(value.label)
        writer.WriteInt64(value.amount)

    static member Deserialize(reader: TlReadBuffer) : LabeledPrice =
        let _cid = reader.ReadConstructorId()
        let label = reader.ReadString()
        let amount = reader.ReadInt64()
        {
            label = label
            amount = amount
        }

type Invoice = {
    test: bool
    nameRequested: bool
    phoneRequested: bool
    emailRequested: bool
    shippingAddressRequested: bool
    flexible: bool
    phoneToProvider: bool
    emailToProvider: bool
    recurring: bool
    currency: string
    prices: LabeledPrice array
    maxTipAmount: int64 option
    suggestedTipAmounts: int64 array option
    termsUrl: string option
    subscriptionPeriod: int32 option
}
with
    static member ConstructorId: uint32 = 77522308u

    static member Serialize(writer: TlWriteBuffer, value: Invoice) : unit =
        writer.WriteConstructorId(77522308u)
        let mutable flags = 0
        if value.test then flags <- flags ||| (1 <<< 0)
        if value.nameRequested then flags <- flags ||| (1 <<< 1)
        if value.phoneRequested then flags <- flags ||| (1 <<< 2)
        if value.emailRequested then flags <- flags ||| (1 <<< 3)
        if value.shippingAddressRequested then flags <- flags ||| (1 <<< 4)
        if value.flexible then flags <- flags ||| (1 <<< 5)
        if value.phoneToProvider then flags <- flags ||| (1 <<< 6)
        if value.emailToProvider then flags <- flags ||| (1 <<< 7)
        if value.recurring then flags <- flags ||| (1 <<< 9)
        if value.maxTipAmount.IsSome then flags <- flags ||| (1 <<< 8)
        if value.suggestedTipAmounts.IsSome then flags <- flags ||| (1 <<< 8)
        if value.termsUrl.IsSome then flags <- flags ||| (1 <<< 10)
        if value.subscriptionPeriod.IsSome then flags <- flags ||| (1 <<< 11)
        writer.WriteInt32(flags)
        writer.WriteString(value.currency)
        writer.WriteVector(value.prices, fun w item -> let writer = w in LabeledPrice.Serialize(writer, item))
        match value.maxTipAmount with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        match value.suggestedTipAmounts with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in writer.WriteInt64(item))
        | None -> ()
        match value.termsUrl with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.subscriptionPeriod with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : Invoice =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let test = flags &&& (1 <<< 0) <> 0
        let nameRequested = flags &&& (1 <<< 1) <> 0
        let phoneRequested = flags &&& (1 <<< 2) <> 0
        let emailRequested = flags &&& (1 <<< 3) <> 0
        let shippingAddressRequested = flags &&& (1 <<< 4) <> 0
        let flexible = flags &&& (1 <<< 5) <> 0
        let phoneToProvider = flags &&& (1 <<< 6) <> 0
        let emailToProvider = flags &&& (1 <<< 7) <> 0
        let recurring = flags &&& (1 <<< 9) <> 0
        let currency = reader.ReadString()
        let prices = reader.ReadVector(fun r -> let reader = r in LabeledPrice.Deserialize(reader))
        let maxTipAmount = if flags &&& (1 <<< 8) <> 0 then Some(reader.ReadInt64()) else None
        let suggestedTipAmounts = if flags &&& (1 <<< 8) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in reader.ReadInt64())) else None
        let termsUrl = if flags &&& (1 <<< 10) <> 0 then Some(reader.ReadString()) else None
        let subscriptionPeriod = if flags &&& (1 <<< 11) <> 0 then Some(reader.ReadInt32()) else None
        {
            test = test
            nameRequested = nameRequested
            phoneRequested = phoneRequested
            emailRequested = emailRequested
            shippingAddressRequested = shippingAddressRequested
            flexible = flexible
            phoneToProvider = phoneToProvider
            emailToProvider = emailToProvider
            recurring = recurring
            currency = currency
            prices = prices
            maxTipAmount = maxTipAmount
            suggestedTipAmounts = suggestedTipAmounts
            termsUrl = termsUrl
            subscriptionPeriod = subscriptionPeriod
        }

type MaskCoords = {
    n: int32
    x: double
    y: double
    zoom: double
}
with
    static member ConstructorId: uint32 = 2933316530u

    static member Serialize(writer: TlWriteBuffer, value: MaskCoords) : unit =
        writer.WriteConstructorId(2933316530u)
        writer.WriteInt32(value.n)
        writer.WriteDouble(value.x)
        writer.WriteDouble(value.y)
        writer.WriteDouble(value.zoom)

    static member Deserialize(reader: TlReadBuffer) : MaskCoords =
        let _cid = reader.ReadConstructorId()
        let n = reader.ReadInt32()
        let x = reader.ReadDouble()
        let y = reader.ReadDouble()
        let zoom = reader.ReadDouble()
        {
            n = n
            x = x
            y = y
            zoom = zoom
        }

type DocumentAttribute =
    | DocumentAttributeImageSize of w: int32 * h: int32
    | DocumentAttributeAnimated
    | DocumentAttributeSticker of mask: bool * alt: string * stickerset: InputStickerSet * maskCoords: MaskCoords option
    | DocumentAttributeVideo of roundMessage: bool * supportsStreaming: bool * nosound: bool * duration: double * w: int32 * h: int32 * preloadPrefixSize: int32 option * videoStartTs: double option * videoCodec: string option
    | DocumentAttributeAudio of voice: bool * duration: int32 * title: string option * performer: string option * waveform: byte[] option
    | DocumentAttributeFilename of fileName: string
    | DocumentAttributeHasStickers
    | DocumentAttributeCustomEmoji of free: bool * textColor: bool * alt: string * stickerset: InputStickerSet
with
    static member Serialize(writer: TlWriteBuffer, value: DocumentAttribute) : unit =
        match value with
        | DocumentAttributeImageSize(w, h) ->
            writer.WriteConstructorId(1815593308u)
            writer.WriteInt32(w)
            writer.WriteInt32(h)
        | DocumentAttributeAnimated ->
            writer.WriteConstructorId(297109817u)
        | DocumentAttributeSticker(mask, alt, stickerset, maskCoords) ->
            writer.WriteConstructorId(1662637586u)
            writer.WriteBool(mask)
            writer.WriteString(alt)
            InputStickerSet.Serialize(writer, stickerset)
            match maskCoords with Some v -> MaskCoords.Serialize(writer, v) | None -> ()
        | DocumentAttributeVideo(roundMessage, supportsStreaming, nosound, duration, w, h, preloadPrefixSize, videoStartTs, videoCodec) ->
            writer.WriteConstructorId(1137015880u)
            writer.WriteBool(roundMessage)
            writer.WriteBool(supportsStreaming)
            writer.WriteBool(nosound)
            writer.WriteDouble(duration)
            writer.WriteInt32(w)
            writer.WriteInt32(h)
            match preloadPrefixSize with Some v -> writer.WriteInt32(v) | None -> ()
            match videoStartTs with Some v -> writer.WriteDouble(v) | None -> ()
            match videoCodec with Some v -> writer.WriteString(v) | None -> ()
        | DocumentAttributeAudio(voice, duration, title, performer, waveform) ->
            writer.WriteConstructorId(2555574726u)
            writer.WriteBool(voice)
            writer.WriteInt32(duration)
            match title with Some v -> writer.WriteString(v) | None -> ()
            match performer with Some v -> writer.WriteString(v) | None -> ()
            match waveform with Some v -> writer.WriteBytes(v) | None -> ()
        | DocumentAttributeFilename(fileName) ->
            writer.WriteConstructorId(358154344u)
            writer.WriteString(fileName)
        | DocumentAttributeHasStickers ->
            writer.WriteConstructorId(2550256375u)
        | DocumentAttributeCustomEmoji(free, textColor, alt, stickerset) ->
            writer.WriteConstructorId(4245985433u)
            writer.WriteBool(free)
            writer.WriteBool(textColor)
            writer.WriteString(alt)
            InputStickerSet.Serialize(writer, stickerset)

    static member Deserialize(reader: TlReadBuffer) : DocumentAttribute =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 1815593308u ->
            let w = reader.ReadInt32()
            let h = reader.ReadInt32()
            DocumentAttributeImageSize(w, h)
        | 297109817u ->
            DocumentAttributeAnimated
        | 1662637586u ->
            let flags = reader.ReadInt32()
            let mask = flags &&& (1 <<< 1) <> 0
            let alt = reader.ReadString()
            let stickerset = InputStickerSet.Deserialize(reader)
            let maskCoords = if flags &&& (1 <<< 0) <> 0 then Some(MaskCoords.Deserialize(reader)) else None
            DocumentAttributeSticker(mask, alt, stickerset, maskCoords)
        | 1137015880u ->
            let flags = reader.ReadInt32()
            let roundMessage = flags &&& (1 <<< 0) <> 0
            let supportsStreaming = flags &&& (1 <<< 1) <> 0
            let nosound = flags &&& (1 <<< 3) <> 0
            let duration = reader.ReadDouble()
            let w = reader.ReadInt32()
            let h = reader.ReadInt32()
            let preloadPrefixSize = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadInt32()) else None
            let videoStartTs = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadDouble()) else None
            let videoCodec = if flags &&& (1 <<< 5) <> 0 then Some(reader.ReadString()) else None
            DocumentAttributeVideo(roundMessage, supportsStreaming, nosound, duration, w, h, preloadPrefixSize, videoStartTs, videoCodec)
        | 2555574726u ->
            let flags = reader.ReadInt32()
            let voice = flags &&& (1 <<< 10) <> 0
            let duration = reader.ReadInt32()
            let title = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
            let performer = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
            let waveform = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadBytes()) else None
            DocumentAttributeAudio(voice, duration, title, performer, waveform)
        | 358154344u ->
            let fileName = reader.ReadString()
            DocumentAttributeFilename(fileName)
        | 2550256375u ->
            DocumentAttributeHasStickers
        | 4245985433u ->
            let flags = reader.ReadInt32()
            let free = flags &&& (1 <<< 0) <> 0
            let textColor = flags &&& (1 <<< 1) <> 0
            let alt = reader.ReadString()
            let stickerset = InputStickerSet.Deserialize(reader)
            DocumentAttributeCustomEmoji(free, textColor, alt, stickerset)
        | _ -> failwith $"Unknown constructor id for DocumentAttribute: 0x{ctorId:X08}"

type InputWebDocument = {
    url: string
    size: int32
    mimeType: string
    attributes: DocumentAttribute array
}
with
    static member ConstructorId: uint32 = 2616017741u

    static member Serialize(writer: TlWriteBuffer, value: InputWebDocument) : unit =
        writer.WriteConstructorId(2616017741u)
        writer.WriteString(value.url)
        writer.WriteInt32(value.size)
        writer.WriteString(value.mimeType)
        writer.WriteVector(value.attributes, fun w item -> let writer = w in DocumentAttribute.Serialize(writer, item))

    static member Deserialize(reader: TlReadBuffer) : InputWebDocument =
        let _cid = reader.ReadConstructorId()
        let url = reader.ReadString()
        let size = reader.ReadInt32()
        let mimeType = reader.ReadString()
        let attributes = reader.ReadVector(fun r -> let reader = r in DocumentAttribute.Deserialize(reader))
        {
            url = url
            size = size
            mimeType = mimeType
            attributes = attributes
        }

type MessageEntity =
    | MessageEntityUnknown of offset: int32 * length: int32
    | MessageEntityMention of offset: int32 * length: int32
    | MessageEntityHashtag of offset: int32 * length: int32
    | MessageEntityBotCommand of offset: int32 * length: int32
    | MessageEntityUrl of offset: int32 * length: int32
    | MessageEntityEmail of offset: int32 * length: int32
    | MessageEntityBold of offset: int32 * length: int32
    | MessageEntityItalic of offset: int32 * length: int32
    | MessageEntityCode of offset: int32 * length: int32
    | MessageEntityPre of offset: int32 * length: int32 * language: string
    | MessageEntityTextUrl of offset: int32 * length: int32 * url: string
    | MessageEntityMentionName of offset: int32 * length: int32 * userId: int64
    | InputMessageEntityMentionName of offset: int32 * length: int32 * userId: InputUser
    | MessageEntityPhone of offset: int32 * length: int32
    | MessageEntityCashtag of offset: int32 * length: int32
    | MessageEntityUnderline of offset: int32 * length: int32
    | MessageEntityStrike of offset: int32 * length: int32
    | MessageEntityBankCard of offset: int32 * length: int32
    | MessageEntitySpoiler of offset: int32 * length: int32
    | MessageEntityCustomEmoji of offset: int32 * length: int32 * documentId: int64
    | MessageEntityBlockquote of collapsed: bool * offset: int32 * length: int32
with
    static member Serialize(writer: TlWriteBuffer, value: MessageEntity) : unit =
        match value with
        | MessageEntityUnknown(offset, length) ->
            writer.WriteConstructorId(3146955413u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityMention(offset, length) ->
            writer.WriteConstructorId(4194588573u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityHashtag(offset, length) ->
            writer.WriteConstructorId(1868782349u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityBotCommand(offset, length) ->
            writer.WriteConstructorId(1827637959u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityUrl(offset, length) ->
            writer.WriteConstructorId(1859134776u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityEmail(offset, length) ->
            writer.WriteConstructorId(1692693954u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityBold(offset, length) ->
            writer.WriteConstructorId(3177253833u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityItalic(offset, length) ->
            writer.WriteConstructorId(2188348256u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityCode(offset, length) ->
            writer.WriteConstructorId(681706865u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityPre(offset, length, language) ->
            writer.WriteConstructorId(1938967520u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
            writer.WriteString(language)
        | MessageEntityTextUrl(offset, length, url) ->
            writer.WriteConstructorId(1990644519u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
            writer.WriteString(url)
        | MessageEntityMentionName(offset, length, userId) ->
            writer.WriteConstructorId(3699052864u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
            writer.WriteInt64(userId)
        | InputMessageEntityMentionName(offset, length, userId) ->
            writer.WriteConstructorId(546203849u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
            InputUser.Serialize(writer, userId)
        | MessageEntityPhone(offset, length) ->
            writer.WriteConstructorId(2607407947u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityCashtag(offset, length) ->
            writer.WriteConstructorId(1280209983u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityUnderline(offset, length) ->
            writer.WriteConstructorId(2622389899u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityStrike(offset, length) ->
            writer.WriteConstructorId(3204879316u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityBankCard(offset, length) ->
            writer.WriteConstructorId(1981704948u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntitySpoiler(offset, length) ->
            writer.WriteConstructorId(852137487u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
        | MessageEntityCustomEmoji(offset, length, documentId) ->
            writer.WriteConstructorId(3369010680u)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)
            writer.WriteInt64(documentId)
        | MessageEntityBlockquote(collapsed, offset, length) ->
            writer.WriteConstructorId(4056722092u)
            writer.WriteBool(collapsed)
            writer.WriteInt32(offset)
            writer.WriteInt32(length)

    static member Deserialize(reader: TlReadBuffer) : MessageEntity =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 3146955413u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityUnknown(offset, length)
        | 4194588573u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityMention(offset, length)
        | 1868782349u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityHashtag(offset, length)
        | 1827637959u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityBotCommand(offset, length)
        | 1859134776u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityUrl(offset, length)
        | 1692693954u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityEmail(offset, length)
        | 3177253833u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityBold(offset, length)
        | 2188348256u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityItalic(offset, length)
        | 681706865u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityCode(offset, length)
        | 1938967520u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            let language = reader.ReadString()
            MessageEntityPre(offset, length, language)
        | 1990644519u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            let url = reader.ReadString()
            MessageEntityTextUrl(offset, length, url)
        | 3699052864u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            let userId = reader.ReadInt64()
            MessageEntityMentionName(offset, length, userId)
        | 546203849u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            let userId = InputUser.Deserialize(reader)
            InputMessageEntityMentionName(offset, length, userId)
        | 2607407947u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityPhone(offset, length)
        | 1280209983u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityCashtag(offset, length)
        | 2622389899u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityUnderline(offset, length)
        | 3204879316u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityStrike(offset, length)
        | 1981704948u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityBankCard(offset, length)
        | 852137487u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntitySpoiler(offset, length)
        | 3369010680u ->
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            let documentId = reader.ReadInt64()
            MessageEntityCustomEmoji(offset, length, documentId)
        | 4056722092u ->
            let flags = reader.ReadInt32()
            let collapsed = flags &&& (1 <<< 0) <> 0
            let offset = reader.ReadInt32()
            let length = reader.ReadInt32()
            MessageEntityBlockquote(collapsed, offset, length)
        | _ -> failwith $"Unknown constructor id for MessageEntity: 0x{ctorId:X08}"

type InputReplyTo =
    | InputReplyToMessage of replyToMsgId: int32 * topMsgId: int32 option * replyToPeerId: InputPeer option * quoteText: string option * quoteEntities: MessageEntity array option * quoteOffset: int32 option * monoforumPeerId: InputPeer option * todoItemId: int32 option
    | InputReplyToStory of peer: InputPeer * storyId: int32
    | InputReplyToMonoForum of monoforumPeerId: InputPeer
with
    static member Serialize(writer: TlWriteBuffer, value: InputReplyTo) : unit =
        match value with
        | InputReplyToMessage(replyToMsgId, topMsgId, replyToPeerId, quoteText, quoteEntities, quoteOffset, monoforumPeerId, todoItemId) ->
            writer.WriteConstructorId(2258615824u)
            writer.WriteInt32(replyToMsgId)
            match topMsgId with Some v -> writer.WriteInt32(v) | None -> ()
            match replyToPeerId with Some v -> InputPeer.Serialize(writer, v) | None -> ()
            match quoteText with Some v -> writer.WriteString(v) | None -> ()
            match quoteEntities with Some v -> writer.WriteVector(v, fun w item -> let writer = w in MessageEntity.Serialize(writer, item)) | None -> ()
            match quoteOffset with Some v -> writer.WriteInt32(v) | None -> ()
            match monoforumPeerId with Some v -> InputPeer.Serialize(writer, v) | None -> ()
            match todoItemId with Some v -> writer.WriteInt32(v) | None -> ()
        | InputReplyToStory(peer, storyId) ->
            writer.WriteConstructorId(1484862010u)
            InputPeer.Serialize(writer, peer)
            writer.WriteInt32(storyId)
        | InputReplyToMonoForum(monoforumPeerId) ->
            writer.WriteConstructorId(1775660101u)
            InputPeer.Serialize(writer, monoforumPeerId)

    static member Deserialize(reader: TlReadBuffer) : InputReplyTo =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2258615824u | 1944879197u | 583071445u ->
            let flags = reader.ReadInt32()
            let replyToMsgId = reader.ReadInt32()
            let topMsgId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            let replyToPeerId = if flags &&& (1 <<< 1) <> 0 then Some(InputPeer.Deserialize(reader)) else None
            let quoteText = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadString()) else None
            let quoteEntities = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in MessageEntity.Deserialize(reader))) else None
            let quoteOffset = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadInt32()) else None
            let monoforumPeerId = if flags &&& (1 <<< 5) <> 0 then Some(InputPeer.Deserialize(reader)) else None
            let todoItemId = if flags &&& (1 <<< 6) <> 0 then Some(reader.ReadInt32()) else None
            InputReplyToMessage(replyToMsgId, topMsgId, replyToPeerId, quoteText, quoteEntities, quoteOffset, monoforumPeerId, todoItemId)
        | 1484862010u ->
            let peer = InputPeer.Deserialize(reader)
            let storyId = reader.ReadInt32()
            InputReplyToStory(peer, storyId)
        | 1775660101u ->
            let monoforumPeerId = InputPeer.Deserialize(reader)
            InputReplyToMonoForum(monoforumPeerId)
        | _ -> failwith $"Unknown constructor id for InputReplyTo: 0x{ctorId:X08}"

type MessageRange = {
    minId: int32
    maxId: int32
}
with
    static member ConstructorId: uint32 = 182649427u

    static member Serialize(writer: TlWriteBuffer, value: MessageRange) : unit =
        writer.WriteConstructorId(182649427u)
        writer.WriteInt32(value.minId)
        writer.WriteInt32(value.maxId)

    static member Deserialize(reader: TlReadBuffer) : MessageRange =
        let _cid = reader.ReadConstructorId()
        let minId = reader.ReadInt32()
        let maxId = reader.ReadInt32()
        {
            minId = minId
            maxId = maxId
        }

type ChannelMessagesFilter =
    | ChannelMessagesFilterEmpty
    | ChannelMessagesFilter of excludeNewMessages: bool * ranges: MessageRange array
with
    static member Serialize(writer: TlWriteBuffer, value: ChannelMessagesFilter) : unit =
        match value with
        | ChannelMessagesFilterEmpty ->
            writer.WriteConstructorId(2496933607u)
        | ChannelMessagesFilter(excludeNewMessages, ranges) ->
            writer.WriteConstructorId(3447183703u)
            writer.WriteBool(excludeNewMessages)
            writer.WriteVector(ranges, fun w item -> let writer = w in MessageRange.Serialize(writer, item))

    static member Deserialize(reader: TlReadBuffer) : ChannelMessagesFilter =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2496933607u ->
            ChannelMessagesFilterEmpty
        | 3447183703u ->
            let flags = reader.ReadInt32()
            let excludeNewMessages = flags &&& (1 <<< 1) <> 0
            let ranges = reader.ReadVector(fun r -> let reader = r in MessageRange.Deserialize(reader))
            ChannelMessagesFilter(excludeNewMessages, ranges)
        | _ -> failwith $"Unknown constructor id for ChannelMessagesFilter: 0x{ctorId:X08}"

type MessagesFilter =
    | InputMessagesFilterEmpty
    | InputMessagesFilterPhotos
    | InputMessagesFilterVideo
    | InputMessagesFilterPhotoVideo
    | InputMessagesFilterDocument
    | InputMessagesFilterUrl
    | InputMessagesFilterGif
    | InputMessagesFilterVoice
    | InputMessagesFilterMusic
    | InputMessagesFilterChatPhotos
    | InputMessagesFilterPhoneCalls of missed: bool
    | InputMessagesFilterRoundVoice
    | InputMessagesFilterRoundVideo
    | InputMessagesFilterMyMentions
    | InputMessagesFilterGeo
    | InputMessagesFilterContacts
    | InputMessagesFilterPinned
with
    static member Serialize(writer: TlWriteBuffer, value: MessagesFilter) : unit =
        match value with
        | InputMessagesFilterEmpty ->
            writer.WriteConstructorId(1474492012u)
        | InputMessagesFilterPhotos ->
            writer.WriteConstructorId(2517214492u)
        | InputMessagesFilterVideo ->
            writer.WriteConstructorId(2680163941u)
        | InputMessagesFilterPhotoVideo ->
            writer.WriteConstructorId(1458172132u)
        | InputMessagesFilterDocument ->
            writer.WriteConstructorId(2665345416u)
        | InputMessagesFilterUrl ->
            writer.WriteConstructorId(2129714567u)
        | InputMessagesFilterGif ->
            writer.WriteConstructorId(4291323271u)
        | InputMessagesFilterVoice ->
            writer.WriteConstructorId(1358283666u)
        | InputMessagesFilterMusic ->
            writer.WriteConstructorId(928101534u)
        | InputMessagesFilterChatPhotos ->
            writer.WriteConstructorId(975236280u)
        | InputMessagesFilterPhoneCalls(missed) ->
            writer.WriteConstructorId(2160695144u)
            writer.WriteBool(missed)
        | InputMessagesFilterRoundVoice ->
            writer.WriteConstructorId(2054952868u)
        | InputMessagesFilterRoundVideo ->
            writer.WriteConstructorId(3041516115u)
        | InputMessagesFilterMyMentions ->
            writer.WriteConstructorId(3254314650u)
        | InputMessagesFilterGeo ->
            writer.WriteConstructorId(3875695885u)
        | InputMessagesFilterContacts ->
            writer.WriteConstructorId(3764575107u)
        | InputMessagesFilterPinned ->
            writer.WriteConstructorId(464520273u)

    static member Deserialize(reader: TlReadBuffer) : MessagesFilter =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 1474492012u ->
            InputMessagesFilterEmpty
        | 2517214492u ->
            InputMessagesFilterPhotos
        | 2680163941u ->
            InputMessagesFilterVideo
        | 1458172132u ->
            InputMessagesFilterPhotoVideo
        | 2665345416u ->
            InputMessagesFilterDocument
        | 2129714567u ->
            InputMessagesFilterUrl
        | 4291323271u ->
            InputMessagesFilterGif
        | 1358283666u ->
            InputMessagesFilterVoice
        | 928101534u ->
            InputMessagesFilterMusic
        | 975236280u ->
            InputMessagesFilterChatPhotos
        | 2160695144u ->
            let flags = reader.ReadInt32()
            let missed = flags &&& (1 <<< 0) <> 0
            InputMessagesFilterPhoneCalls(missed)
        | 2054952868u ->
            InputMessagesFilterRoundVoice
        | 3041516115u ->
            InputMessagesFilterRoundVideo
        | 3254314650u ->
            InputMessagesFilterMyMentions
        | 3875695885u ->
            InputMessagesFilterGeo
        | 3764575107u ->
            InputMessagesFilterContacts
        | 464520273u ->
            InputMessagesFilterPinned
        | _ -> failwith $"Unknown constructor id for MessagesFilter: 0x{ctorId:X08}"

type NotificationSound =
    | NotificationSoundDefault
    | NotificationSoundNone
    | NotificationSoundLocal of title: string * data: string
    | NotificationSoundRingtone of id: int64
with
    static member Serialize(writer: TlWriteBuffer, value: NotificationSound) : unit =
        match value with
        | NotificationSoundDefault ->
            writer.WriteConstructorId(2548612798u)
        | NotificationSoundNone ->
            writer.WriteConstructorId(1863070943u)
        | NotificationSoundLocal(title, data) ->
            writer.WriteConstructorId(2198575844u)
            writer.WriteString(title)
            writer.WriteString(data)
        | NotificationSoundRingtone(id) ->
            writer.WriteConstructorId(4285300809u)
            writer.WriteInt64(id)

    static member Deserialize(reader: TlReadBuffer) : NotificationSound =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2548612798u ->
            NotificationSoundDefault
        | 1863070943u ->
            NotificationSoundNone
        | 2198575844u ->
            let title = reader.ReadString()
            let data = reader.ReadString()
            NotificationSoundLocal(title, data)
        | 4285300809u ->
            let id = reader.ReadInt64()
            NotificationSoundRingtone(id)
        | _ -> failwith $"Unknown constructor id for NotificationSound: 0x{ctorId:X08}"

type InputPeerNotifySettings = {
    showPreviews: bool option
    silent: bool option
    muteUntil: int32 option
    sound: NotificationSound option
    storiesMuted: bool option
    storiesHideSender: bool option
    storiesSound: NotificationSound option
}
with
    static member ConstructorId: uint32 = 3402328802u

    static member Serialize(writer: TlWriteBuffer, value: InputPeerNotifySettings) : unit =
        writer.WriteConstructorId(3402328802u)
        let mutable flags = 0
        if value.showPreviews.IsSome then flags <- flags ||| (1 <<< 0)
        if value.silent.IsSome then flags <- flags ||| (1 <<< 1)
        if value.muteUntil.IsSome then flags <- flags ||| (1 <<< 2)
        if value.sound.IsSome then flags <- flags ||| (1 <<< 3)
        if value.storiesMuted.IsSome then flags <- flags ||| (1 <<< 6)
        if value.storiesHideSender.IsSome then flags <- flags ||| (1 <<< 7)
        if value.storiesSound.IsSome then flags <- flags ||| (1 <<< 8)
        writer.WriteInt32(flags)
        match value.showPreviews with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.silent with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.muteUntil with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.sound with
        | Some v ->
            NotificationSound.Serialize(writer, v)
        | None -> ()
        match value.storiesMuted with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.storiesHideSender with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.storiesSound with
        | Some v ->
            NotificationSound.Serialize(writer, v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : InputPeerNotifySettings =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let showPreviews = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadBool()) else None
        let silent = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadBool()) else None
        let muteUntil = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadInt32()) else None
        let sound = if flags &&& (1 <<< 3) <> 0 then Some(NotificationSound.Deserialize(reader)) else None
        let storiesMuted = if flags &&& (1 <<< 6) <> 0 then Some(reader.ReadBool()) else None
        let storiesHideSender = if flags &&& (1 <<< 7) <> 0 then Some(reader.ReadBool()) else None
        let storiesSound = if flags &&& (1 <<< 8) <> 0 then Some(NotificationSound.Deserialize(reader)) else None
        {
            showPreviews = showPreviews
            silent = silent
            muteUntil = muteUntil
            sound = sound
            storiesMuted = storiesMuted
            storiesHideSender = storiesHideSender
            storiesSound = storiesSound
        }

type Peer =
    | PeerUser of userId: int64
    | PeerChat of chatId: int64
    | PeerChannel of channelId: int64
with
    static member Serialize(writer: TlWriteBuffer, value: Peer) : unit =
        match value with
        | PeerUser(userId) ->
            writer.WriteConstructorId(1498486562u)
            writer.WriteInt64(userId)
        | PeerChat(chatId) ->
            writer.WriteConstructorId(918946202u)
            writer.WriteInt64(chatId)
        | PeerChannel(channelId) ->
            writer.WriteConstructorId(2728736542u)
            writer.WriteInt64(channelId)

    static member Deserialize(reader: TlReadBuffer) : Peer =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 1498486562u ->
            let userId = reader.ReadInt64()
            PeerUser(userId)
        | 918946202u ->
            let chatId = reader.ReadInt64()
            PeerChat(chatId)
        | 2728736542u ->
            let channelId = reader.ReadInt64()
            PeerChannel(channelId)
        | _ -> failwith $"Unknown constructor id for Peer: 0x{ctorId:X08}"

type PeerNotifySettings = {
    showPreviews: bool option
    silent: bool option
    muteUntil: int32 option
    iosSound: NotificationSound option
    androidSound: NotificationSound option
    otherSound: NotificationSound option
    storiesMuted: bool option
    storiesHideSender: bool option
    storiesIosSound: NotificationSound option
    storiesAndroidSound: NotificationSound option
    storiesOtherSound: NotificationSound option
}
with
    static member ConstructorId: uint32 = 2573347852u

    static member Serialize(writer: TlWriteBuffer, value: PeerNotifySettings) : unit =
        writer.WriteConstructorId(2573347852u)
        let mutable flags = 0
        if value.showPreviews.IsSome then flags <- flags ||| (1 <<< 0)
        if value.silent.IsSome then flags <- flags ||| (1 <<< 1)
        if value.muteUntil.IsSome then flags <- flags ||| (1 <<< 2)
        if value.iosSound.IsSome then flags <- flags ||| (1 <<< 3)
        if value.androidSound.IsSome then flags <- flags ||| (1 <<< 4)
        if value.otherSound.IsSome then flags <- flags ||| (1 <<< 5)
        if value.storiesMuted.IsSome then flags <- flags ||| (1 <<< 6)
        if value.storiesHideSender.IsSome then flags <- flags ||| (1 <<< 7)
        if value.storiesIosSound.IsSome then flags <- flags ||| (1 <<< 8)
        if value.storiesAndroidSound.IsSome then flags <- flags ||| (1 <<< 9)
        if value.storiesOtherSound.IsSome then flags <- flags ||| (1 <<< 10)
        writer.WriteInt32(flags)
        match value.showPreviews with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.silent with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.muteUntil with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.iosSound with
        | Some v ->
            NotificationSound.Serialize(writer, v)
        | None -> ()
        match value.androidSound with
        | Some v ->
            NotificationSound.Serialize(writer, v)
        | None -> ()
        match value.otherSound with
        | Some v ->
            NotificationSound.Serialize(writer, v)
        | None -> ()
        match value.storiesMuted with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.storiesHideSender with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.storiesIosSound with
        | Some v ->
            NotificationSound.Serialize(writer, v)
        | None -> ()
        match value.storiesAndroidSound with
        | Some v ->
            NotificationSound.Serialize(writer, v)
        | None -> ()
        match value.storiesOtherSound with
        | Some v ->
            NotificationSound.Serialize(writer, v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : PeerNotifySettings =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let showPreviews = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadBool()) else None
        let silent = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadBool()) else None
        let muteUntil = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadInt32()) else None
        let iosSound = if flags &&& (1 <<< 3) <> 0 then Some(NotificationSound.Deserialize(reader)) else None
        let androidSound = if flags &&& (1 <<< 4) <> 0 then Some(NotificationSound.Deserialize(reader)) else None
        let otherSound = if flags &&& (1 <<< 5) <> 0 then Some(NotificationSound.Deserialize(reader)) else None
        let storiesMuted = if flags &&& (1 <<< 6) <> 0 then Some(reader.ReadBool()) else None
        let storiesHideSender = if flags &&& (1 <<< 7) <> 0 then Some(reader.ReadBool()) else None
        let storiesIosSound = if flags &&& (1 <<< 8) <> 0 then Some(NotificationSound.Deserialize(reader)) else None
        let storiesAndroidSound = if flags &&& (1 <<< 9) <> 0 then Some(NotificationSound.Deserialize(reader)) else None
        let storiesOtherSound = if flags &&& (1 <<< 10) <> 0 then Some(NotificationSound.Deserialize(reader)) else None
        {
            showPreviews = showPreviews
            silent = silent
            muteUntil = muteUntil
            iosSound = iosSound
            androidSound = androidSound
            otherSound = otherSound
            storiesMuted = storiesMuted
            storiesHideSender = storiesHideSender
            storiesIosSound = storiesIosSound
            storiesAndroidSound = storiesAndroidSound
            storiesOtherSound = storiesOtherSound
        }

type PhoneCallDiscardReason =
    | PhoneCallDiscardReasonMissed
    | PhoneCallDiscardReasonDisconnect
    | PhoneCallDiscardReasonHangup
    | PhoneCallDiscardReasonBusy
    | PhoneCallDiscardReasonMigrateConferenceCall of slug: string
with
    static member Serialize(writer: TlWriteBuffer, value: PhoneCallDiscardReason) : unit =
        match value with
        | PhoneCallDiscardReasonMissed ->
            writer.WriteConstructorId(2246320897u)
        | PhoneCallDiscardReasonDisconnect ->
            writer.WriteConstructorId(3767910816u)
        | PhoneCallDiscardReasonHangup ->
            writer.WriteConstructorId(1471006352u)
        | PhoneCallDiscardReasonBusy ->
            writer.WriteConstructorId(4210550985u)
        | PhoneCallDiscardReasonMigrateConferenceCall(slug) ->
            writer.WriteConstructorId(2679894519u)
            writer.WriteString(slug)

    static member Deserialize(reader: TlReadBuffer) : PhoneCallDiscardReason =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2246320897u ->
            PhoneCallDiscardReasonMissed
        | 3767910816u ->
            PhoneCallDiscardReasonDisconnect
        | 1471006352u ->
            PhoneCallDiscardReasonHangup
        | 4210550985u ->
            PhoneCallDiscardReasonBusy
        | 2679894519u ->
            let slug = reader.ReadString()
            PhoneCallDiscardReasonMigrateConferenceCall(slug)
        | _ -> failwith $"Unknown constructor id for PhoneCallDiscardReason: 0x{ctorId:X08}"

type PhoneCallProtocol = {
    udpP2p: bool
    udpReflector: bool
    minLayer: int32
    maxLayer: int32
    libraryVersions: string array
}
with
    static member ConstructorId: uint32 = 4236742600u

    static member Serialize(writer: TlWriteBuffer, value: PhoneCallProtocol) : unit =
        writer.WriteConstructorId(4236742600u)
        let mutable flags = 0
        if value.udpP2p then flags <- flags ||| (1 <<< 0)
        if value.udpReflector then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.minLayer)
        writer.WriteInt32(value.maxLayer)
        writer.WriteVector(value.libraryVersions, fun w item -> let writer = w in writer.WriteString(item))

    static member Deserialize(reader: TlReadBuffer) : PhoneCallProtocol =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let udpP2p = flags &&& (1 <<< 0) <> 0
        let udpReflector = flags &&& (1 <<< 1) <> 0
        let minLayer = reader.ReadInt32()
        let maxLayer = reader.ReadInt32()
        let libraryVersions = reader.ReadVector(fun r -> let reader = r in reader.ReadString())
        {
            udpP2p = udpP2p
            udpReflector = udpReflector
            minLayer = minLayer
            maxLayer = maxLayer
            libraryVersions = libraryVersions
        }

type Reaction =
    | ReactionEmpty
    | ReactionEmoji of emoticon: string
    | ReactionCustomEmoji of documentId: int64
    | ReactionPaid
with
    static member Serialize(writer: TlWriteBuffer, value: Reaction) : unit =
        match value with
        | ReactionEmpty ->
            writer.WriteConstructorId(2046153753u)
        | ReactionEmoji(emoticon) ->
            writer.WriteConstructorId(455247544u)
            writer.WriteString(emoticon)
        | ReactionCustomEmoji(documentId) ->
            writer.WriteConstructorId(2302016627u)
            writer.WriteInt64(documentId)
        | ReactionPaid ->
            writer.WriteConstructorId(1379771627u)

    static member Deserialize(reader: TlReadBuffer) : Reaction =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2046153753u ->
            ReactionEmpty
        | 455247544u ->
            let emoticon = reader.ReadString()
            ReactionEmoji(emoticon)
        | 2302016627u ->
            let documentId = reader.ReadInt64()
            ReactionCustomEmoji(documentId)
        | 1379771627u ->
            ReactionPaid
        | _ -> failwith $"Unknown constructor id for Reaction: 0x{ctorId:X08}"

type ChatReactions =
    | ChatReactionsNone
    | ChatReactionsAll of allowCustom: bool
    | ChatReactionsSome of reactions: Reaction array
with
    static member Serialize(writer: TlWriteBuffer, value: ChatReactions) : unit =
        match value with
        | ChatReactionsNone ->
            writer.WriteConstructorId(3942396604u)
        | ChatReactionsAll(allowCustom) ->
            writer.WriteConstructorId(1385335754u)
            writer.WriteBool(allowCustom)
        | ChatReactionsSome(reactions) ->
            writer.WriteConstructorId(1713193015u)
            writer.WriteVector(reactions, fun w item -> let writer = w in Reaction.Serialize(writer, item))

    static member Deserialize(reader: TlReadBuffer) : ChatReactions =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 3942396604u ->
            ChatReactionsNone
        | 1385335754u ->
            let flags = reader.ReadInt32()
            let allowCustom = flags &&& (1 <<< 0) <> 0
            ChatReactionsAll(allowCustom)
        | 1713193015u ->
            let reactions = reader.ReadVector(fun r -> let reader = r in Reaction.Deserialize(reader))
            ChatReactionsSome(reactions)
        | _ -> failwith $"Unknown constructor id for ChatReactions: 0x{ctorId:X08}"

type RequestPeerType =
    | RequestPeerTypeUser of bot: bool option * premium: bool option
    | RequestPeerTypeChat of creator: bool * botParticipant: bool * hasUsername: bool option * forum: bool option * userAdminRights: ChatAdminRights option * botAdminRights: ChatAdminRights option
    | RequestPeerTypeBroadcast of creator: bool * hasUsername: bool option * userAdminRights: ChatAdminRights option * botAdminRights: ChatAdminRights option
with
    static member Serialize(writer: TlWriteBuffer, value: RequestPeerType) : unit =
        match value with
        | RequestPeerTypeUser(bot, premium) ->
            writer.WriteConstructorId(1597737472u)
            match bot with Some v -> writer.WriteBool(v) | None -> ()
            match premium with Some v -> writer.WriteBool(v) | None -> ()
        | RequestPeerTypeChat(creator, botParticipant, hasUsername, forum, userAdminRights, botAdminRights) ->
            writer.WriteConstructorId(3387977243u)
            writer.WriteBool(creator)
            writer.WriteBool(botParticipant)
            match hasUsername with Some v -> writer.WriteBool(v) | None -> ()
            match forum with Some v -> writer.WriteBool(v) | None -> ()
            match userAdminRights with Some v -> ChatAdminRights.Serialize(writer, v) | None -> ()
            match botAdminRights with Some v -> ChatAdminRights.Serialize(writer, v) | None -> ()
        | RequestPeerTypeBroadcast(creator, hasUsername, userAdminRights, botAdminRights) ->
            writer.WriteConstructorId(865857388u)
            writer.WriteBool(creator)
            match hasUsername with Some v -> writer.WriteBool(v) | None -> ()
            match userAdminRights with Some v -> ChatAdminRights.Serialize(writer, v) | None -> ()
            match botAdminRights with Some v -> ChatAdminRights.Serialize(writer, v) | None -> ()

    static member Deserialize(reader: TlReadBuffer) : RequestPeerType =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 1597737472u ->
            let flags = reader.ReadInt32()
            let bot = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadBool()) else None
            let premium = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadBool()) else None
            RequestPeerTypeUser(bot, premium)
        | 3387977243u ->
            let flags = reader.ReadInt32()
            let creator = flags &&& (1 <<< 0) <> 0
            let botParticipant = flags &&& (1 <<< 5) <> 0
            let hasUsername = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadBool()) else None
            let forum = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadBool()) else None
            let userAdminRights = if flags &&& (1 <<< 1) <> 0 then Some(ChatAdminRights.Deserialize(reader)) else None
            let botAdminRights = if flags &&& (1 <<< 2) <> 0 then Some(ChatAdminRights.Deserialize(reader)) else None
            RequestPeerTypeChat(creator, botParticipant, hasUsername, forum, userAdminRights, botAdminRights)
        | 865857388u ->
            let flags = reader.ReadInt32()
            let creator = flags &&& (1 <<< 0) <> 0
            let hasUsername = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadBool()) else None
            let userAdminRights = if flags &&& (1 <<< 1) <> 0 then Some(ChatAdminRights.Deserialize(reader)) else None
            let botAdminRights = if flags &&& (1 <<< 2) <> 0 then Some(ChatAdminRights.Deserialize(reader)) else None
            RequestPeerTypeBroadcast(creator, hasUsername, userAdminRights, botAdminRights)
        | _ -> failwith $"Unknown constructor id for RequestPeerType: 0x{ctorId:X08}"

type KeyboardButton =
    | KeyboardButton of text: string
    | KeyboardButtonUrl of text: string * url: string
    | KeyboardButtonCallback of requiresPassword: bool * text: string * data: byte[]
    | KeyboardButtonRequestPhone of text: string
    | KeyboardButtonRequestGeoLocation of text: string
    | KeyboardButtonSwitchInline of samePeer: bool * text: string * query: string * peerTypes: InlineQueryPeerType array option
    | KeyboardButtonGame of text: string
    | KeyboardButtonBuy of text: string
    | KeyboardButtonUrlAuth of text: string * fwdText: string option * url: string * buttonId: int32
    | InputKeyboardButtonUrlAuth of requestWriteAccess: bool * text: string * fwdText: string option * url: string * bot: InputUser
    | KeyboardButtonRequestPoll of quiz: bool option * text: string
    | InputKeyboardButtonUserProfile of text: string * userId: InputUser
    | KeyboardButtonUserProfile of text: string * userId: int64
    | KeyboardButtonWebView of text: string * url: string
    | KeyboardButtonSimpleWebView of text: string * url: string
    | KeyboardButtonRequestPeer of text: string * buttonId: int32 * peerType: RequestPeerType * maxQuantity: int32
    | InputKeyboardButtonRequestPeer of nameRequested: bool * usernameRequested: bool * photoRequested: bool * text: string * buttonId: int32 * peerType: RequestPeerType * maxQuantity: int32
    | KeyboardButtonCopy of text: string * copyText: string
with
    static member Serialize(writer: TlWriteBuffer, value: KeyboardButton) : unit =
        match value with
        | KeyboardButton(text) ->
            writer.WriteConstructorId(2734311552u)
            writer.WriteString(text)
        | KeyboardButtonUrl(text, url) ->
            writer.WriteConstructorId(629866245u)
            writer.WriteString(text)
            writer.WriteString(url)
        | KeyboardButtonCallback(requiresPassword, text, data) ->
            writer.WriteConstructorId(901503851u)
            writer.WriteBool(requiresPassword)
            writer.WriteString(text)
            writer.WriteBytes(data)
        | KeyboardButtonRequestPhone(text) ->
            writer.WriteConstructorId(2976541737u)
            writer.WriteString(text)
        | KeyboardButtonRequestGeoLocation(text) ->
            writer.WriteConstructorId(4235815743u)
            writer.WriteString(text)
        | KeyboardButtonSwitchInline(samePeer, text, query, peerTypes) ->
            writer.WriteConstructorId(2478439349u)
            writer.WriteBool(samePeer)
            writer.WriteString(text)
            writer.WriteString(query)
            match peerTypes with Some v -> writer.WriteVector(v, fun w item -> let writer = w in InlineQueryPeerType.Serialize(writer, item)) | None -> ()
        | KeyboardButtonGame(text) ->
            writer.WriteConstructorId(1358175439u)
            writer.WriteString(text)
        | KeyboardButtonBuy(text) ->
            writer.WriteConstructorId(2950250427u)
            writer.WriteString(text)
        | KeyboardButtonUrlAuth(text, fwdText, url, buttonId) ->
            writer.WriteConstructorId(280464681u)
            writer.WriteString(text)
            match fwdText with Some v -> writer.WriteString(v) | None -> ()
            writer.WriteString(url)
            writer.WriteInt32(buttonId)
        | InputKeyboardButtonUrlAuth(requestWriteAccess, text, fwdText, url, bot) ->
            writer.WriteConstructorId(3492708308u)
            writer.WriteBool(requestWriteAccess)
            writer.WriteString(text)
            match fwdText with Some v -> writer.WriteString(v) | None -> ()
            writer.WriteString(url)
            InputUser.Serialize(writer, bot)
        | KeyboardButtonRequestPoll(quiz, text) ->
            writer.WriteConstructorId(3150401885u)
            match quiz with Some v -> writer.WriteBool(v) | None -> ()
            writer.WriteString(text)
        | InputKeyboardButtonUserProfile(text, userId) ->
            writer.WriteConstructorId(3918005115u)
            writer.WriteString(text)
            InputUser.Serialize(writer, userId)
        | KeyboardButtonUserProfile(text, userId) ->
            writer.WriteConstructorId(814112961u)
            writer.WriteString(text)
            writer.WriteInt64(userId)
        | KeyboardButtonWebView(text, url) ->
            writer.WriteConstructorId(326529584u)
            writer.WriteString(text)
            writer.WriteString(url)
        | KeyboardButtonSimpleWebView(text, url) ->
            writer.WriteConstructorId(2696958044u)
            writer.WriteString(text)
            writer.WriteString(url)
        | KeyboardButtonRequestPeer(text, buttonId, peerType, maxQuantity) ->
            writer.WriteConstructorId(1406648280u)
            writer.WriteString(text)
            writer.WriteInt32(buttonId)
            RequestPeerType.Serialize(writer, peerType)
            writer.WriteInt32(maxQuantity)
        | InputKeyboardButtonRequestPeer(nameRequested, usernameRequested, photoRequested, text, buttonId, peerType, maxQuantity) ->
            writer.WriteConstructorId(3378916613u)
            writer.WriteBool(nameRequested)
            writer.WriteBool(usernameRequested)
            writer.WriteBool(photoRequested)
            writer.WriteString(text)
            writer.WriteInt32(buttonId)
            RequestPeerType.Serialize(writer, peerType)
            writer.WriteInt32(maxQuantity)
        | KeyboardButtonCopy(text, copyText) ->
            writer.WriteConstructorId(1976723854u)
            writer.WriteString(text)
            writer.WriteString(copyText)

    static member Deserialize(reader: TlReadBuffer) : KeyboardButton =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2734311552u ->
            let text = reader.ReadString()
            KeyboardButton(text)
        | 629866245u ->
            let text = reader.ReadString()
            let url = reader.ReadString()
            KeyboardButtonUrl(text, url)
        | 901503851u ->
            let flags = reader.ReadInt32()
            let requiresPassword = flags &&& (1 <<< 0) <> 0
            let text = reader.ReadString()
            let data = reader.ReadBytes()
            KeyboardButtonCallback(requiresPassword, text, data)
        | 2976541737u ->
            let text = reader.ReadString()
            KeyboardButtonRequestPhone(text)
        | 4235815743u ->
            let text = reader.ReadString()
            KeyboardButtonRequestGeoLocation(text)
        | 2478439349u ->
            let flags = reader.ReadInt32()
            let samePeer = flags &&& (1 <<< 0) <> 0
            let text = reader.ReadString()
            let query = reader.ReadString()
            let peerTypes = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in InlineQueryPeerType.Deserialize(reader))) else None
            KeyboardButtonSwitchInline(samePeer, text, query, peerTypes)
        | 1358175439u ->
            let text = reader.ReadString()
            KeyboardButtonGame(text)
        | 2950250427u ->
            let text = reader.ReadString()
            KeyboardButtonBuy(text)
        | 280464681u ->
            let flags = reader.ReadInt32()
            let text = reader.ReadString()
            let fwdText = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
            let url = reader.ReadString()
            let buttonId = reader.ReadInt32()
            KeyboardButtonUrlAuth(text, fwdText, url, buttonId)
        | 3492708308u ->
            let flags = reader.ReadInt32()
            let requestWriteAccess = flags &&& (1 <<< 0) <> 0
            let text = reader.ReadString()
            let fwdText = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
            let url = reader.ReadString()
            let bot = InputUser.Deserialize(reader)
            InputKeyboardButtonUrlAuth(requestWriteAccess, text, fwdText, url, bot)
        | 3150401885u ->
            let flags = reader.ReadInt32()
            let quiz = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadBool()) else None
            let text = reader.ReadString()
            KeyboardButtonRequestPoll(quiz, text)
        | 3918005115u ->
            let text = reader.ReadString()
            let userId = InputUser.Deserialize(reader)
            InputKeyboardButtonUserProfile(text, userId)
        | 814112961u ->
            let text = reader.ReadString()
            let userId = reader.ReadInt64()
            KeyboardButtonUserProfile(text, userId)
        | 326529584u ->
            let text = reader.ReadString()
            let url = reader.ReadString()
            KeyboardButtonWebView(text, url)
        | 2696958044u ->
            let text = reader.ReadString()
            let url = reader.ReadString()
            KeyboardButtonSimpleWebView(text, url)
        | 1406648280u ->
            let text = reader.ReadString()
            let buttonId = reader.ReadInt32()
            let peerType = RequestPeerType.Deserialize(reader)
            let maxQuantity = reader.ReadInt32()
            KeyboardButtonRequestPeer(text, buttonId, peerType, maxQuantity)
        | 3378916613u ->
            let flags = reader.ReadInt32()
            let nameRequested = flags &&& (1 <<< 0) <> 0
            let usernameRequested = flags &&& (1 <<< 1) <> 0
            let photoRequested = flags &&& (1 <<< 2) <> 0
            let text = reader.ReadString()
            let buttonId = reader.ReadInt32()
            let peerType = RequestPeerType.Deserialize(reader)
            let maxQuantity = reader.ReadInt32()
            InputKeyboardButtonRequestPeer(nameRequested, usernameRequested, photoRequested, text, buttonId, peerType, maxQuantity)
        | 1976723854u ->
            let text = reader.ReadString()
            let copyText = reader.ReadString()
            KeyboardButtonCopy(text, copyText)
        | _ -> failwith $"Unknown constructor id for KeyboardButton: 0x{ctorId:X08}"

type KeyboardButtonRow = {
    buttons: KeyboardButton array
}
with
    static member ConstructorId: uint32 = 2002815875u

    static member Serialize(writer: TlWriteBuffer, value: KeyboardButtonRow) : unit =
        writer.WriteConstructorId(2002815875u)
        writer.WriteVector(value.buttons, fun w item -> let writer = w in KeyboardButton.Serialize(writer, item))

    static member Deserialize(reader: TlReadBuffer) : KeyboardButtonRow =
        let _cid = reader.ReadConstructorId()
        let buttons = reader.ReadVector(fun r -> let reader = r in KeyboardButton.Deserialize(reader))
        {
            buttons = buttons
        }

type ReplyMarkup =
    | ReplyKeyboardHide of selective: bool
    | ReplyKeyboardForceReply of singleUse: bool * selective: bool * placeholder: string option
    | ReplyKeyboardMarkup of resize: bool * singleUse: bool * selective: bool * persistent: bool * rows: KeyboardButtonRow array * placeholder: string option
    | ReplyInlineMarkup of rows: KeyboardButtonRow array
with
    static member Serialize(writer: TlWriteBuffer, value: ReplyMarkup) : unit =
        match value with
        | ReplyKeyboardHide(selective) ->
            writer.WriteConstructorId(2688441221u)
            writer.WriteBool(selective)
        | ReplyKeyboardForceReply(singleUse, selective, placeholder) ->
            writer.WriteConstructorId(2259946248u)
            writer.WriteBool(singleUse)
            writer.WriteBool(selective)
            match placeholder with Some v -> writer.WriteString(v) | None -> ()
        | ReplyKeyboardMarkup(resize, singleUse, selective, persistent, rows, placeholder) ->
            writer.WriteConstructorId(2245892561u)
            writer.WriteBool(resize)
            writer.WriteBool(singleUse)
            writer.WriteBool(selective)
            writer.WriteBool(persistent)
            writer.WriteVector(rows, fun w item -> let writer = w in KeyboardButtonRow.Serialize(writer, item))
            match placeholder with Some v -> writer.WriteString(v) | None -> ()
        | ReplyInlineMarkup(rows) ->
            writer.WriteConstructorId(1218642516u)
            writer.WriteVector(rows, fun w item -> let writer = w in KeyboardButtonRow.Serialize(writer, item))

    static member Deserialize(reader: TlReadBuffer) : ReplyMarkup =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2688441221u ->
            let flags = reader.ReadInt32()
            let selective = flags &&& (1 <<< 2) <> 0
            ReplyKeyboardHide(selective)
        | 2259946248u ->
            let flags = reader.ReadInt32()
            let singleUse = flags &&& (1 <<< 1) <> 0
            let selective = flags &&& (1 <<< 2) <> 0
            let placeholder = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadString()) else None
            ReplyKeyboardForceReply(singleUse, selective, placeholder)
        | 2245892561u ->
            let flags = reader.ReadInt32()
            let resize = flags &&& (1 <<< 0) <> 0
            let singleUse = flags &&& (1 <<< 1) <> 0
            let selective = flags &&& (1 <<< 2) <> 0
            let persistent = flags &&& (1 <<< 4) <> 0
            let rows = reader.ReadVector(fun r -> let reader = r in KeyboardButtonRow.Deserialize(reader))
            let placeholder = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadString()) else None
            ReplyKeyboardMarkup(resize, singleUse, selective, persistent, rows, placeholder)
        | 1218642516u ->
            let rows = reader.ReadVector(fun r -> let reader = r in KeyboardButtonRow.Deserialize(reader))
            ReplyInlineMarkup(rows)
        | _ -> failwith $"Unknown constructor id for ReplyMarkup: 0x{ctorId:X08}"

type SendMessageAction =
    | SendMessageTypingAction
    | SendMessageCancelAction
    | SendMessageRecordVideoAction
    | SendMessageUploadVideoAction of progress: int32
    | SendMessageRecordAudioAction
    | SendMessageUploadAudioAction of progress: int32
    | SendMessageUploadPhotoAction of progress: int32
    | SendMessageUploadDocumentAction of progress: int32
    | SendMessageGeoLocationAction
    | SendMessageChooseContactAction
    | SendMessageGamePlayAction
    | SendMessageRecordRoundAction
    | SendMessageUploadRoundAction of progress: int32
    | SpeakingInGroupCallAction
    | SendMessageHistoryImportAction of progress: int32
    | SendMessageChooseStickerAction
    | SendMessageEmojiInteraction of emoticon: string * msgId: int32 * interaction: DataJSON
    | SendMessageEmojiInteractionSeen of emoticon: string
with
    static member Serialize(writer: TlWriteBuffer, value: SendMessageAction) : unit =
        match value with
        | SendMessageTypingAction ->
            writer.WriteConstructorId(381645902u)
        | SendMessageCancelAction ->
            writer.WriteConstructorId(4250847477u)
        | SendMessageRecordVideoAction ->
            writer.WriteConstructorId(2710034031u)
        | SendMessageUploadVideoAction(progress) ->
            writer.WriteConstructorId(3916839660u)
            writer.WriteInt32(progress)
        | SendMessageRecordAudioAction ->
            writer.WriteConstructorId(3576656887u)
        | SendMessageUploadAudioAction(progress) ->
            writer.WriteConstructorId(4082227115u)
            writer.WriteInt32(progress)
        | SendMessageUploadPhotoAction(progress) ->
            writer.WriteConstructorId(3520285222u)
            writer.WriteInt32(progress)
        | SendMessageUploadDocumentAction(progress) ->
            writer.WriteConstructorId(2852968932u)
            writer.WriteInt32(progress)
        | SendMessageGeoLocationAction ->
            writer.WriteConstructorId(393186209u)
        | SendMessageChooseContactAction ->
            writer.WriteConstructorId(1653390447u)
        | SendMessageGamePlayAction ->
            writer.WriteConstructorId(3714748232u)
        | SendMessageRecordRoundAction ->
            writer.WriteConstructorId(2297593788u)
        | SendMessageUploadRoundAction(progress) ->
            writer.WriteConstructorId(608050278u)
            writer.WriteInt32(progress)
        | SpeakingInGroupCallAction ->
            writer.WriteConstructorId(3643548293u)
        | SendMessageHistoryImportAction(progress) ->
            writer.WriteConstructorId(3688534598u)
            writer.WriteInt32(progress)
        | SendMessageChooseStickerAction ->
            writer.WriteConstructorId(2958739121u)
        | SendMessageEmojiInteraction(emoticon, msgId, interaction) ->
            writer.WriteConstructorId(630664139u)
            writer.WriteString(emoticon)
            writer.WriteInt32(msgId)
            DataJSON.Serialize(writer, interaction)
        | SendMessageEmojiInteractionSeen(emoticon) ->
            writer.WriteConstructorId(3060109358u)
            writer.WriteString(emoticon)

    static member Deserialize(reader: TlReadBuffer) : SendMessageAction =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 381645902u ->
            SendMessageTypingAction
        | 4250847477u ->
            SendMessageCancelAction
        | 2710034031u ->
            SendMessageRecordVideoAction
        | 3916839660u ->
            let progress = reader.ReadInt32()
            SendMessageUploadVideoAction(progress)
        | 3576656887u ->
            SendMessageRecordAudioAction
        | 4082227115u ->
            let progress = reader.ReadInt32()
            SendMessageUploadAudioAction(progress)
        | 3520285222u ->
            let progress = reader.ReadInt32()
            SendMessageUploadPhotoAction(progress)
        | 2852968932u ->
            let progress = reader.ReadInt32()
            SendMessageUploadDocumentAction(progress)
        | 393186209u ->
            SendMessageGeoLocationAction
        | 1653390447u ->
            SendMessageChooseContactAction
        | 3714748232u ->
            SendMessageGamePlayAction
        | 2297593788u ->
            SendMessageRecordRoundAction
        | 608050278u ->
            let progress = reader.ReadInt32()
            SendMessageUploadRoundAction(progress)
        | 3643548293u ->
            SpeakingInGroupCallAction
        | 3688534598u ->
            let progress = reader.ReadInt32()
            SendMessageHistoryImportAction(progress)
        | 2958739121u ->
            SendMessageChooseStickerAction
        | 630664139u ->
            let emoticon = reader.ReadString()
            let msgId = reader.ReadInt32()
            let interaction = DataJSON.Deserialize(reader)
            SendMessageEmojiInteraction(emoticon, msgId, interaction)
        | 3060109358u ->
            let emoticon = reader.ReadString()
            SendMessageEmojiInteractionSeen(emoticon)
        | _ -> failwith $"Unknown constructor id for SendMessageAction: 0x{ctorId:X08}"

type StarsAmount =
    | StarsAmount of amount: int64 * nanos: int32
    | StarsTonAmount of amount: int64
with
    static member Serialize(writer: TlWriteBuffer, value: StarsAmount) : unit =
        match value with
        | StarsAmount(amount, nanos) ->
            writer.WriteConstructorId(3149313187u)
            writer.WriteInt64(amount)
            writer.WriteInt32(nanos)
        | StarsTonAmount(amount) ->
            writer.WriteConstructorId(1957618656u)
            writer.WriteInt64(amount)

    static member Deserialize(reader: TlReadBuffer) : StarsAmount =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 3149313187u ->
            let amount = reader.ReadInt64()
            let nanos = reader.ReadInt32()
            StarsAmount(amount, nanos)
        | 1957618656u ->
            let amount = reader.ReadInt64()
            StarsTonAmount(amount)
        | _ -> failwith $"Unknown constructor id for StarsAmount: 0x{ctorId:X08}"

type StarsSubscriptionPricing = {
    period: int32
    amount: int64
}
with
    static member ConstructorId: uint32 = 88173912u

    static member Serialize(writer: TlWriteBuffer, value: StarsSubscriptionPricing) : unit =
        writer.WriteConstructorId(88173912u)
        writer.WriteInt32(value.period)
        writer.WriteInt64(value.amount)

    static member Deserialize(reader: TlReadBuffer) : StarsSubscriptionPricing =
        let _cid = reader.ReadConstructorId()
        let period = reader.ReadInt32()
        let amount = reader.ReadInt64()
        {
            period = period
            amount = amount
        }

type SuggestedPost = {
    accepted: bool
    rejected: bool
    price: StarsAmount option
    scheduleDate: int32 option
}
with
    static member ConstructorId: uint32 = 244201445u

    static member Serialize(writer: TlWriteBuffer, value: SuggestedPost) : unit =
        writer.WriteConstructorId(244201445u)
        let mutable flags = 0
        if value.accepted then flags <- flags ||| (1 <<< 1)
        if value.rejected then flags <- flags ||| (1 <<< 2)
        if value.price.IsSome then flags <- flags ||| (1 <<< 3)
        if value.scheduleDate.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        match value.price with
        | Some v ->
            StarsAmount.Serialize(writer, v)
        | None -> ()
        match value.scheduleDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : SuggestedPost =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let accepted = flags &&& (1 <<< 1) <> 0
        let rejected = flags &&& (1 <<< 2) <> 0
        let price = if flags &&& (1 <<< 3) <> 0 then Some(StarsAmount.Deserialize(reader)) else None
        let scheduleDate = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        {
            accepted = accepted
            rejected = rejected
            price = price
            scheduleDate = scheduleDate
        }

type TextWithEntities = {
    text: string
    entities: MessageEntity array
}
with
    static member ConstructorId: uint32 = 1964978502u

    static member Serialize(writer: TlWriteBuffer, value: TextWithEntities) : unit =
        writer.WriteConstructorId(1964978502u)
        writer.WriteString(value.text)
        writer.WriteVector(value.entities, fun w item -> let writer = w in MessageEntity.Serialize(writer, item))

    static member Deserialize(reader: TlReadBuffer) : TextWithEntities =
        let _cid = reader.ReadConstructorId()
        let text = reader.ReadString()
        let entities = reader.ReadVector(fun r -> let reader = r in MessageEntity.Deserialize(reader))
        {
            text = text
            entities = entities
        }

type DialogFilter =
    | DialogFilter of contacts: bool * nonContacts: bool * groups: bool * broadcasts: bool * bots: bool * excludeMuted: bool * excludeRead: bool * excludeArchived: bool * titleNoanimate: bool * id: int32 * title: TextWithEntities * emoticon: string option * color: int32 option * pinnedPeers: InputPeer array * includePeers: InputPeer array * excludePeers: InputPeer array
    | DialogFilterDefault
    | DialogFilterChatlist of hasMyInvites: bool * titleNoanimate: bool * id: int32 * title: TextWithEntities * emoticon: string option * color: int32 option * pinnedPeers: InputPeer array * includePeers: InputPeer array
with
    static member Serialize(writer: TlWriteBuffer, value: DialogFilter) : unit =
        match value with
        | DialogFilter(contacts, nonContacts, groups, broadcasts, bots, excludeMuted, excludeRead, excludeArchived, titleNoanimate, id, title, emoticon, color, pinnedPeers, includePeers, excludePeers) ->
            writer.WriteConstructorId(2856789585u)
            writer.WriteBool(contacts)
            writer.WriteBool(nonContacts)
            writer.WriteBool(groups)
            writer.WriteBool(broadcasts)
            writer.WriteBool(bots)
            writer.WriteBool(excludeMuted)
            writer.WriteBool(excludeRead)
            writer.WriteBool(excludeArchived)
            writer.WriteBool(titleNoanimate)
            writer.WriteInt32(id)
            TextWithEntities.Serialize(writer, title)
            match emoticon with Some v -> writer.WriteString(v) | None -> ()
            match color with Some v -> writer.WriteInt32(v) | None -> ()
            writer.WriteVector(pinnedPeers, fun w item -> let writer = w in InputPeer.Serialize(writer, item))
            writer.WriteVector(includePeers, fun w item -> let writer = w in InputPeer.Serialize(writer, item))
            writer.WriteVector(excludePeers, fun w item -> let writer = w in InputPeer.Serialize(writer, item))
        | DialogFilterDefault ->
            writer.WriteConstructorId(909284270u)
        | DialogFilterChatlist(hasMyInvites, titleNoanimate, id, title, emoticon, color, pinnedPeers, includePeers) ->
            writer.WriteConstructorId(2522053591u)
            writer.WriteBool(hasMyInvites)
            writer.WriteBool(titleNoanimate)
            writer.WriteInt32(id)
            TextWithEntities.Serialize(writer, title)
            match emoticon with Some v -> writer.WriteString(v) | None -> ()
            match color with Some v -> writer.WriteInt32(v) | None -> ()
            writer.WriteVector(pinnedPeers, fun w item -> let writer = w in InputPeer.Serialize(writer, item))
            writer.WriteVector(includePeers, fun w item -> let writer = w in InputPeer.Serialize(writer, item))

    static member Deserialize(reader: TlReadBuffer) : DialogFilter =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2856789585u ->
            let flags = reader.ReadInt32()
            let contacts = flags &&& (1 <<< 0) <> 0
            let nonContacts = flags &&& (1 <<< 1) <> 0
            let groups = flags &&& (1 <<< 2) <> 0
            let broadcasts = flags &&& (1 <<< 3) <> 0
            let bots = flags &&& (1 <<< 4) <> 0
            let excludeMuted = flags &&& (1 <<< 11) <> 0
            let excludeRead = flags &&& (1 <<< 12) <> 0
            let excludeArchived = flags &&& (1 <<< 13) <> 0
            let titleNoanimate = flags &&& (1 <<< 28) <> 0
            let id = reader.ReadInt32()
            let title = TextWithEntities.Deserialize(reader)
            let emoticon = if flags &&& (1 <<< 25) <> 0 then Some(reader.ReadString()) else None
            let color = if flags &&& (1 <<< 27) <> 0 then Some(reader.ReadInt32()) else None
            let pinnedPeers = reader.ReadVector(fun r -> let reader = r in InputPeer.Deserialize(reader))
            let includePeers = reader.ReadVector(fun r -> let reader = r in InputPeer.Deserialize(reader))
            let excludePeers = reader.ReadVector(fun r -> let reader = r in InputPeer.Deserialize(reader))
            DialogFilter(contacts, nonContacts, groups, broadcasts, bots, excludeMuted, excludeRead, excludeArchived, titleNoanimate, id, title, emoticon, color, pinnedPeers, includePeers, excludePeers)
        | 909284270u ->
            DialogFilterDefault
        | 2522053591u ->
            let flags = reader.ReadInt32()
            let hasMyInvites = flags &&& (1 <<< 26) <> 0
            let titleNoanimate = flags &&& (1 <<< 28) <> 0
            let id = reader.ReadInt32()
            let title = TextWithEntities.Deserialize(reader)
            let emoticon = if flags &&& (1 <<< 25) <> 0 then Some(reader.ReadString()) else None
            let color = if flags &&& (1 <<< 27) <> 0 then Some(reader.ReadInt32()) else None
            let pinnedPeers = reader.ReadVector(fun r -> let reader = r in InputPeer.Deserialize(reader))
            let includePeers = reader.ReadVector(fun r -> let reader = r in InputPeer.Deserialize(reader))
            DialogFilterChatlist(hasMyInvites, titleNoanimate, id, title, emoticon, color, pinnedPeers, includePeers)
        | _ -> failwith $"Unknown constructor id for DialogFilter: 0x{ctorId:X08}"

type PollAnswer = {
    text: TextWithEntities
    option: byte[]
}
with
    static member ConstructorId: uint32 = 4279689930u

    static member Serialize(writer: TlWriteBuffer, value: PollAnswer) : unit =
        writer.WriteConstructorId(4279689930u)
        TextWithEntities.Serialize(writer, value.text)
        writer.WriteBytes(value.option)

    static member Deserialize(reader: TlReadBuffer) : PollAnswer =
        let _cid = reader.ReadConstructorId()
        let text = TextWithEntities.Deserialize(reader)
        let option = reader.ReadBytes()
        {
            text = text
            option = option
        }

type Poll = {
    id: int64
    closed: bool
    publicVoters: bool
    multipleChoice: bool
    quiz: bool
    question: TextWithEntities
    answers: PollAnswer array
    closePeriod: int32 option
    closeDate: int32 option
}
with
    static member ConstructorId: uint32 = 1484026161u

    static member Serialize(writer: TlWriteBuffer, value: Poll) : unit =
        writer.WriteConstructorId(1484026161u)
        let mutable flags = 0
        if value.closed then flags <- flags ||| (1 <<< 0)
        if value.publicVoters then flags <- flags ||| (1 <<< 1)
        if value.multipleChoice then flags <- flags ||| (1 <<< 2)
        if value.quiz then flags <- flags ||| (1 <<< 3)
        if value.closePeriod.IsSome then flags <- flags ||| (1 <<< 4)
        if value.closeDate.IsSome then flags <- flags ||| (1 <<< 5)
        writer.WriteInt32(flags)
        writer.WriteInt64(value.id)
        TextWithEntities.Serialize(writer, value.question)
        writer.WriteVector(value.answers, fun w item -> let writer = w in PollAnswer.Serialize(writer, item))
        match value.closePeriod with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.closeDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : Poll =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let id = reader.ReadInt64()
        let closed = flags &&& (1 <<< 0) <> 0
        let publicVoters = flags &&& (1 <<< 1) <> 0
        let multipleChoice = flags &&& (1 <<< 2) <> 0
        let quiz = flags &&& (1 <<< 3) <> 0
        let question = TextWithEntities.Deserialize(reader)
        let answers = reader.ReadVector(fun r -> let reader = r in PollAnswer.Deserialize(reader))
        let closePeriod = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadInt32()) else None
        let closeDate = if flags &&& (1 <<< 5) <> 0 then Some(reader.ReadInt32()) else None
        {
            id = id
            closed = closed
            publicVoters = publicVoters
            multipleChoice = multipleChoice
            quiz = quiz
            question = question
            answers = answers
            closePeriod = closePeriod
            closeDate = closeDate
        }

type TodoItem = {
    id: int32
    title: TextWithEntities
}
with
    static member ConstructorId: uint32 = 3416892719u

    static member Serialize(writer: TlWriteBuffer, value: TodoItem) : unit =
        writer.WriteConstructorId(3416892719u)
        writer.WriteInt32(value.id)
        TextWithEntities.Serialize(writer, value.title)

    static member Deserialize(reader: TlReadBuffer) : TodoItem =
        let _cid = reader.ReadConstructorId()
        let id = reader.ReadInt32()
        let title = TextWithEntities.Deserialize(reader)
        {
            id = id
            title = title
        }

type TodoList = {
    othersCanAppend: bool
    othersCanComplete: bool
    title: TextWithEntities
    list: TodoItem array
}
with
    static member ConstructorId: uint32 = 1236871718u

    static member Serialize(writer: TlWriteBuffer, value: TodoList) : unit =
        writer.WriteConstructorId(1236871718u)
        let mutable flags = 0
        if value.othersCanAppend then flags <- flags ||| (1 <<< 0)
        if value.othersCanComplete then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        TextWithEntities.Serialize(writer, value.title)
        writer.WriteVector(value.list, fun w item -> let writer = w in TodoItem.Serialize(writer, item))

    static member Deserialize(reader: TlReadBuffer) : TodoList =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let othersCanAppend = flags &&& (1 <<< 0) <> 0
        let othersCanComplete = flags &&& (1 <<< 1) <> 0
        let title = TextWithEntities.Deserialize(reader)
        let list = reader.ReadVector(fun r -> let reader = r in TodoItem.Deserialize(reader))
        {
            othersCanAppend = othersCanAppend
            othersCanComplete = othersCanComplete
            title = title
            list = list
        }

type InputMedia =
    | InputMediaEmpty
    | InputMediaUploadedPhoto of spoiler: bool * file: InputFile * stickers: InputDocument array option * ttlSeconds: int32 option
    | InputMediaPhoto of spoiler: bool * id: InputPhoto * ttlSeconds: int32 option
    | InputMediaGeoPoint of geoPoint: InputGeoPoint
    | InputMediaContact of phoneNumber: string * firstName: string * lastName: string * vcard: string
    | InputMediaUploadedDocument of nosoundVideo: bool * forceFile: bool * spoiler: bool * file: InputFile * thumb: InputFile option * mimeType: string * attributes: DocumentAttribute array * stickers: InputDocument array option * videoCover: InputPhoto option * videoTimestamp: int32 option * ttlSeconds: int32 option
    | InputMediaDocument of spoiler: bool * id: InputDocument * videoCover: InputPhoto option * videoTimestamp: int32 option * ttlSeconds: int32 option * query: string option
    | InputMediaVenue of geoPoint: InputGeoPoint * title: string * address: string * provider: string * venueId: string * venueType: string
    | InputMediaPhotoExternal of spoiler: bool * url: string * ttlSeconds: int32 option
    | InputMediaDocumentExternal of spoiler: bool * url: string * ttlSeconds: int32 option * videoCover: InputPhoto option * videoTimestamp: int32 option
    | InputMediaGame of id: InputGame
    | InputMediaInvoice of title: string * description: string * photo: InputWebDocument option * invoice: Invoice * payload: byte[] * provider: string option * providerData: DataJSON * startParam: string option * extendedMedia: InputMedia option
    | InputMediaGeoLive of stopped: bool * geoPoint: InputGeoPoint * heading: int32 option * period: int32 option * proximityNotificationRadius: int32 option
    | InputMediaPoll of poll: Poll * correctAnswers: byte[] array option * solution: string option * solutionEntities: MessageEntity array option
    | InputMediaDice of emoticon: string
    | InputMediaStory of peer: InputPeer * id: int32
    | InputMediaWebPage of forceLargeMedia: bool * forceSmallMedia: bool * optional: bool * url: string
    | InputMediaPaidMedia of starsAmount: int64 * extendedMedia: InputMedia array * payload: string option
    | InputMediaTodo of todo: TodoList
with
    static member Serialize(writer: TlWriteBuffer, value: InputMedia) : unit =
        match value with
        | InputMediaEmpty ->
            writer.WriteConstructorId(2523198847u)
        | InputMediaUploadedPhoto(spoiler, file, stickers, ttlSeconds) ->
            writer.WriteConstructorId(505969924u)
            writer.WriteBool(spoiler)
            InputFile.Serialize(writer, file)
            match stickers with Some v -> writer.WriteVector(v, fun w item -> let writer = w in InputDocument.Serialize(writer, item)) | None -> ()
            match ttlSeconds with Some v -> writer.WriteInt32(v) | None -> ()
        | InputMediaPhoto(spoiler, id, ttlSeconds) ->
            writer.WriteConstructorId(3015312949u)
            writer.WriteBool(spoiler)
            InputPhoto.Serialize(writer, id)
            match ttlSeconds with Some v -> writer.WriteInt32(v) | None -> ()
        | InputMediaGeoPoint(geoPoint) ->
            writer.WriteConstructorId(4190388548u)
            InputGeoPoint.Serialize(writer, geoPoint)
        | InputMediaContact(phoneNumber, firstName, lastName, vcard) ->
            writer.WriteConstructorId(4171988475u)
            writer.WriteString(phoneNumber)
            writer.WriteString(firstName)
            writer.WriteString(lastName)
            writer.WriteString(vcard)
        | InputMediaUploadedDocument(nosoundVideo, forceFile, spoiler, file, thumb, mimeType, attributes, stickers, videoCover, videoTimestamp, ttlSeconds) ->
            writer.WriteConstructorId(58495792u)
            writer.WriteBool(nosoundVideo)
            writer.WriteBool(forceFile)
            writer.WriteBool(spoiler)
            InputFile.Serialize(writer, file)
            match thumb with Some v -> InputFile.Serialize(writer, v) | None -> ()
            writer.WriteString(mimeType)
            writer.WriteVector(attributes, fun w item -> let writer = w in DocumentAttribute.Serialize(writer, item))
            match stickers with Some v -> writer.WriteVector(v, fun w item -> let writer = w in InputDocument.Serialize(writer, item)) | None -> ()
            match videoCover with Some v -> InputPhoto.Serialize(writer, v) | None -> ()
            match videoTimestamp with Some v -> writer.WriteInt32(v) | None -> ()
            match ttlSeconds with Some v -> writer.WriteInt32(v) | None -> ()
        | InputMediaDocument(spoiler, id, videoCover, videoTimestamp, ttlSeconds, query) ->
            writer.WriteConstructorId(2826320565u)
            writer.WriteBool(spoiler)
            InputDocument.Serialize(writer, id)
            match videoCover with Some v -> InputPhoto.Serialize(writer, v) | None -> ()
            match videoTimestamp with Some v -> writer.WriteInt32(v) | None -> ()
            match ttlSeconds with Some v -> writer.WriteInt32(v) | None -> ()
            match query with Some v -> writer.WriteString(v) | None -> ()
        | InputMediaVenue(geoPoint, title, address, provider, venueId, venueType) ->
            writer.WriteConstructorId(3242007569u)
            InputGeoPoint.Serialize(writer, geoPoint)
            writer.WriteString(title)
            writer.WriteString(address)
            writer.WriteString(provider)
            writer.WriteString(venueId)
            writer.WriteString(venueType)
        | InputMediaPhotoExternal(spoiler, url, ttlSeconds) ->
            writer.WriteConstructorId(3854302746u)
            writer.WriteBool(spoiler)
            writer.WriteString(url)
            match ttlSeconds with Some v -> writer.WriteInt32(v) | None -> ()
        | InputMediaDocumentExternal(spoiler, url, ttlSeconds, videoCover, videoTimestamp) ->
            writer.WriteConstructorId(2006319353u)
            writer.WriteBool(spoiler)
            writer.WriteString(url)
            match ttlSeconds with Some v -> writer.WriteInt32(v) | None -> ()
            match videoCover with Some v -> InputPhoto.Serialize(writer, v) | None -> ()
            match videoTimestamp with Some v -> writer.WriteInt32(v) | None -> ()
        | InputMediaGame(id) ->
            writer.WriteConstructorId(3544138739u)
            InputGame.Serialize(writer, id)
        | InputMediaInvoice(title, description, photo, invoice, payload, provider, providerData, startParam, extendedMedia) ->
            writer.WriteConstructorId(1080028941u)
            writer.WriteString(title)
            writer.WriteString(description)
            match photo with Some v -> InputWebDocument.Serialize(writer, v) | None -> ()
            Invoice.Serialize(writer, invoice)
            writer.WriteBytes(payload)
            match provider with Some v -> writer.WriteString(v) | None -> ()
            DataJSON.Serialize(writer, providerData)
            match startParam with Some v -> writer.WriteString(v) | None -> ()
            match extendedMedia with Some v -> InputMedia.Serialize(writer, v) | None -> ()
        | InputMediaGeoLive(stopped, geoPoint, heading, period, proximityNotificationRadius) ->
            writer.WriteConstructorId(2535434307u)
            writer.WriteBool(stopped)
            InputGeoPoint.Serialize(writer, geoPoint)
            match heading with Some v -> writer.WriteInt32(v) | None -> ()
            match period with Some v -> writer.WriteInt32(v) | None -> ()
            match proximityNotificationRadius with Some v -> writer.WriteInt32(v) | None -> ()
        | InputMediaPoll(poll, correctAnswers, solution, solutionEntities) ->
            writer.WriteConstructorId(261416433u)
            Poll.Serialize(writer, poll)
            match correctAnswers with Some v -> writer.WriteVector(v, fun w item -> let writer = w in writer.WriteBytes(item)) | None -> ()
            match solution with Some v -> writer.WriteString(v) | None -> ()
            match solutionEntities with Some v -> writer.WriteVector(v, fun w item -> let writer = w in MessageEntity.Serialize(writer, item)) | None -> ()
        | InputMediaDice(emoticon) ->
            writer.WriteConstructorId(3866083195u)
            writer.WriteString(emoticon)
        | InputMediaStory(peer, id) ->
            writer.WriteConstructorId(2315114360u)
            InputPeer.Serialize(writer, peer)
            writer.WriteInt32(id)
        | InputMediaWebPage(forceLargeMedia, forceSmallMedia, optional, url) ->
            writer.WriteConstructorId(3256584265u)
            writer.WriteBool(forceLargeMedia)
            writer.WriteBool(forceSmallMedia)
            writer.WriteBool(optional)
            writer.WriteString(url)
        | InputMediaPaidMedia(starsAmount, extendedMedia, payload) ->
            writer.WriteConstructorId(3289396102u)
            writer.WriteInt64(starsAmount)
            writer.WriteVector(extendedMedia, fun w item -> let writer = w in InputMedia.Serialize(writer, item))
            match payload with Some v -> writer.WriteString(v) | None -> ()
        | InputMediaTodo(todo) ->
            writer.WriteConstructorId(2680512478u)
            TodoList.Serialize(writer, todo)

    static member Deserialize(reader: TlReadBuffer) : InputMedia =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 2523198847u ->
            InputMediaEmpty
        | 505969924u ->
            let flags = reader.ReadInt32()
            let spoiler = flags &&& (1 <<< 2) <> 0
            let file = InputFile.Deserialize(reader)
            let stickers = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in InputDocument.Deserialize(reader))) else None
            let ttlSeconds = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
            InputMediaUploadedPhoto(spoiler, file, stickers, ttlSeconds)
        | 3015312949u ->
            let flags = reader.ReadInt32()
            let spoiler = flags &&& (1 <<< 1) <> 0
            let id = InputPhoto.Deserialize(reader)
            let ttlSeconds = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            InputMediaPhoto(spoiler, id, ttlSeconds)
        | 4190388548u ->
            let geoPoint = InputGeoPoint.Deserialize(reader)
            InputMediaGeoPoint(geoPoint)
        | 4171988475u ->
            let phoneNumber = reader.ReadString()
            let firstName = reader.ReadString()
            let lastName = reader.ReadString()
            let vcard = reader.ReadString()
            InputMediaContact(phoneNumber, firstName, lastName, vcard)
        | 58495792u ->
            let flags = reader.ReadInt32()
            let nosoundVideo = flags &&& (1 <<< 3) <> 0
            let forceFile = flags &&& (1 <<< 4) <> 0
            let spoiler = flags &&& (1 <<< 5) <> 0
            let file = InputFile.Deserialize(reader)
            let thumb = if flags &&& (1 <<< 2) <> 0 then Some(InputFile.Deserialize(reader)) else None
            let mimeType = reader.ReadString()
            let attributes = reader.ReadVector(fun r -> let reader = r in DocumentAttribute.Deserialize(reader))
            let stickers = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in InputDocument.Deserialize(reader))) else None
            let videoCover = if flags &&& (1 <<< 6) <> 0 then Some(InputPhoto.Deserialize(reader)) else None
            let videoTimestamp = if flags &&& (1 <<< 7) <> 0 then Some(reader.ReadInt32()) else None
            let ttlSeconds = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
            InputMediaUploadedDocument(nosoundVideo, forceFile, spoiler, file, thumb, mimeType, attributes, stickers, videoCover, videoTimestamp, ttlSeconds)
        | 2826320565u ->
            let flags = reader.ReadInt32()
            let spoiler = flags &&& (1 <<< 2) <> 0
            let id = InputDocument.Deserialize(reader)
            let videoCover = if flags &&& (1 <<< 3) <> 0 then Some(InputPhoto.Deserialize(reader)) else None
            let videoTimestamp = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadInt32()) else None
            let ttlSeconds = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            let query = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
            InputMediaDocument(spoiler, id, videoCover, videoTimestamp, ttlSeconds, query)
        | 3242007569u ->
            let geoPoint = InputGeoPoint.Deserialize(reader)
            let title = reader.ReadString()
            let address = reader.ReadString()
            let provider = reader.ReadString()
            let venueId = reader.ReadString()
            let venueType = reader.ReadString()
            InputMediaVenue(geoPoint, title, address, provider, venueId, venueType)
        | 3854302746u ->
            let flags = reader.ReadInt32()
            let spoiler = flags &&& (1 <<< 1) <> 0
            let url = reader.ReadString()
            let ttlSeconds = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            InputMediaPhotoExternal(spoiler, url, ttlSeconds)
        | 2006319353u ->
            let flags = reader.ReadInt32()
            let spoiler = flags &&& (1 <<< 1) <> 0
            let url = reader.ReadString()
            let ttlSeconds = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            let videoCover = if flags &&& (1 <<< 2) <> 0 then Some(InputPhoto.Deserialize(reader)) else None
            let videoTimestamp = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadInt32()) else None
            InputMediaDocumentExternal(spoiler, url, ttlSeconds, videoCover, videoTimestamp)
        | 3544138739u ->
            let id = InputGame.Deserialize(reader)
            InputMediaGame(id)
        | 1080028941u ->
            let flags = reader.ReadInt32()
            let title = reader.ReadString()
            let description = reader.ReadString()
            let photo = if flags &&& (1 <<< 0) <> 0 then Some(InputWebDocument.Deserialize(reader)) else None
            let invoice = Invoice.Deserialize(reader)
            let payload = reader.ReadBytes()
            let provider = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadString()) else None
            let providerData = DataJSON.Deserialize(reader)
            let startParam = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
            let extendedMedia = if flags &&& (1 <<< 2) <> 0 then Some(InputMedia.Deserialize(reader)) else None
            InputMediaInvoice(title, description, photo, invoice, payload, provider, providerData, startParam, extendedMedia)
        | 2535434307u ->
            let flags = reader.ReadInt32()
            let stopped = flags &&& (1 <<< 0) <> 0
            let geoPoint = InputGeoPoint.Deserialize(reader)
            let heading = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadInt32()) else None
            let period = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
            let proximityNotificationRadius = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadInt32()) else None
            InputMediaGeoLive(stopped, geoPoint, heading, period, proximityNotificationRadius)
        | 261416433u ->
            let flags = reader.ReadInt32()
            let poll = Poll.Deserialize(reader)
            let correctAnswers = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in reader.ReadBytes())) else None
            let solution = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
            let solutionEntities = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in MessageEntity.Deserialize(reader))) else None
            InputMediaPoll(poll, correctAnswers, solution, solutionEntities)
        | 3866083195u ->
            let emoticon = reader.ReadString()
            InputMediaDice(emoticon)
        | 2315114360u ->
            let peer = InputPeer.Deserialize(reader)
            let id = reader.ReadInt32()
            InputMediaStory(peer, id)
        | 3256584265u ->
            let flags = reader.ReadInt32()
            let forceLargeMedia = flags &&& (1 <<< 0) <> 0
            let forceSmallMedia = flags &&& (1 <<< 1) <> 0
            let optional = flags &&& (1 <<< 2) <> 0
            let url = reader.ReadString()
            InputMediaWebPage(forceLargeMedia, forceSmallMedia, optional, url)
        | 3289396102u ->
            let flags = reader.ReadInt32()
            let starsAmount = reader.ReadInt64()
            let extendedMedia = reader.ReadVector(fun r -> let reader = r in InputMedia.Deserialize(reader))
            let payload = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
            InputMediaPaidMedia(starsAmount, extendedMedia, payload)
        | 2680512478u ->
            let todo = TodoList.Deserialize(reader)
            InputMediaTodo(todo)
        | _ -> failwith $"Unknown constructor id for InputMedia: 0x{ctorId:X08}"

type DraftMessage =
    | DraftMessageEmpty of date: int32 option
    | DraftMessage of noWebpage: bool * invertMedia: bool * replyTo: InputReplyTo option * message: string * entities: MessageEntity array option * media: InputMedia option * date: int32 * effect: int64 option * suggestedPost: SuggestedPost option
with
    static member Serialize(writer: TlWriteBuffer, value: DraftMessage) : unit =
        match value with
        | DraftMessageEmpty(date) ->
            writer.WriteConstructorId(453805082u)
            match date with Some v -> writer.WriteInt32(v) | None -> ()
        | DraftMessage(noWebpage, invertMedia, replyTo, message, entities, media, date, effect, suggestedPost) ->
            writer.WriteConstructorId(2531960299u)
            writer.WriteBool(noWebpage)
            writer.WriteBool(invertMedia)
            match replyTo with Some v -> InputReplyTo.Serialize(writer, v) | None -> ()
            writer.WriteString(message)
            match entities with Some v -> writer.WriteVector(v, fun w item -> let writer = w in MessageEntity.Serialize(writer, item)) | None -> ()
            match media with Some v -> InputMedia.Serialize(writer, v) | None -> ()
            writer.WriteInt32(date)
            match effect with Some v -> writer.WriteInt64(v) | None -> ()
            match suggestedPost with Some v -> SuggestedPost.Serialize(writer, v) | None -> ()

    static member Deserialize(reader: TlReadBuffer) : DraftMessage =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 453805082u ->
            let flags = reader.ReadInt32()
            let date = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            DraftMessageEmpty(date)
        | 2531960299u ->
            let flags = reader.ReadInt32()
            let noWebpage = flags &&& (1 <<< 1) <> 0
            let invertMedia = flags &&& (1 <<< 6) <> 0
            let replyTo = if flags &&& (1 <<< 4) <> 0 then Some(InputReplyTo.Deserialize(reader)) else None
            let message = reader.ReadString()
            let entities = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in MessageEntity.Deserialize(reader))) else None
            let media = if flags &&& (1 <<< 5) <> 0 then Some(InputMedia.Deserialize(reader)) else None
            let date = reader.ReadInt32()
            let effect = if flags &&& (1 <<< 7) <> 0 then Some(reader.ReadInt64()) else None
            let suggestedPost = if flags &&& (1 <<< 8) <> 0 then Some(SuggestedPost.Deserialize(reader)) else None
            DraftMessage(noWebpage, invertMedia, replyTo, message, entities, media, date, effect, suggestedPost)
        | _ -> failwith $"Unknown constructor id for DraftMessage: 0x{ctorId:X08}"

type Dialog =
    | Dialog of pinned: bool * unreadMark: bool * viewForumAsMessages: bool * peer: Peer * topMessage: int32 * readInboxMaxId: int32 * readOutboxMaxId: int32 * unreadCount: int32 * unreadMentionsCount: int32 * unreadReactionsCount: int32 * notifySettings: PeerNotifySettings * pts: int32 option * draft: DraftMessage option * folderId: int32 option * ttlPeriod: int32 option
    | DialogFolder of pinned: bool * folder: Folder * peer: Peer * topMessage: int32 * unreadMutedPeersCount: int32 * unreadUnmutedPeersCount: int32 * unreadMutedMessagesCount: int32 * unreadUnmutedMessagesCount: int32
with
    static member Serialize(writer: TlWriteBuffer, value: Dialog) : unit =
        match value with
        | Dialog(pinned, unreadMark, viewForumAsMessages, peer, topMessage, readInboxMaxId, readOutboxMaxId, unreadCount, unreadMentionsCount, unreadReactionsCount, notifySettings, pts, draft, folderId, ttlPeriod) ->
            writer.WriteConstructorId(3582593222u)
            writer.WriteBool(pinned)
            writer.WriteBool(unreadMark)
            writer.WriteBool(viewForumAsMessages)
            Peer.Serialize(writer, peer)
            writer.WriteInt32(topMessage)
            writer.WriteInt32(readInboxMaxId)
            writer.WriteInt32(readOutboxMaxId)
            writer.WriteInt32(unreadCount)
            writer.WriteInt32(unreadMentionsCount)
            writer.WriteInt32(unreadReactionsCount)
            PeerNotifySettings.Serialize(writer, notifySettings)
            match pts with Some v -> writer.WriteInt32(v) | None -> ()
            match draft with Some v -> DraftMessage.Serialize(writer, v) | None -> ()
            match folderId with Some v -> writer.WriteInt32(v) | None -> ()
            match ttlPeriod with Some v -> writer.WriteInt32(v) | None -> ()
        | DialogFolder(pinned, folder, peer, topMessage, unreadMutedPeersCount, unreadUnmutedPeersCount, unreadMutedMessagesCount, unreadUnmutedMessagesCount) ->
            writer.WriteConstructorId(1908216652u)
            writer.WriteBool(pinned)
            Folder.Serialize(writer, folder)
            Peer.Serialize(writer, peer)
            writer.WriteInt32(topMessage)
            writer.WriteInt32(unreadMutedPeersCount)
            writer.WriteInt32(unreadUnmutedPeersCount)
            writer.WriteInt32(unreadMutedMessagesCount)
            writer.WriteInt32(unreadUnmutedMessagesCount)

    static member Deserialize(reader: TlReadBuffer) : Dialog =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 3582593222u ->
            let flags = reader.ReadInt32()
            let pinned = flags &&& (1 <<< 2) <> 0
            let unreadMark = flags &&& (1 <<< 3) <> 0
            let viewForumAsMessages = flags &&& (1 <<< 6) <> 0
            let peer = Peer.Deserialize(reader)
            let topMessage = reader.ReadInt32()
            let readInboxMaxId = reader.ReadInt32()
            let readOutboxMaxId = reader.ReadInt32()
            let unreadCount = reader.ReadInt32()
            let unreadMentionsCount = reader.ReadInt32()
            let unreadReactionsCount = reader.ReadInt32()
            let notifySettings = PeerNotifySettings.Deserialize(reader)
            let pts = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
            let draft = if flags &&& (1 <<< 1) <> 0 then Some(DraftMessage.Deserialize(reader)) else None
            let folderId = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadInt32()) else None
            let ttlPeriod = if flags &&& (1 <<< 5) <> 0 then Some(reader.ReadInt32()) else None
            Dialog(pinned, unreadMark, viewForumAsMessages, peer, topMessage, readInboxMaxId, readOutboxMaxId, unreadCount, unreadMentionsCount, unreadReactionsCount, notifySettings, pts, draft, folderId, ttlPeriod)
        | 1908216652u ->
            let flags = reader.ReadInt32()
            let pinned = flags &&& (1 <<< 2) <> 0
            let folder = Folder.Deserialize(reader)
            let peer = Peer.Deserialize(reader)
            let topMessage = reader.ReadInt32()
            let unreadMutedPeersCount = reader.ReadInt32()
            let unreadUnmutedPeersCount = reader.ReadInt32()
            let unreadMutedMessagesCount = reader.ReadInt32()
            let unreadUnmutedMessagesCount = reader.ReadInt32()
            DialogFolder(pinned, folder, peer, topMessage, unreadMutedPeersCount, unreadUnmutedPeersCount, unreadMutedMessagesCount, unreadUnmutedMessagesCount)
        | _ -> failwith $"Unknown constructor id for Dialog: 0x{ctorId:X08}"

type InputSingleMedia = {
    media: InputMedia
    randomId: int64
    message: string
    entities: MessageEntity array option
}
with
    static member ConstructorId: uint32 = 482797855u

    static member Serialize(writer: TlWriteBuffer, value: InputSingleMedia) : unit =
        writer.WriteConstructorId(482797855u)
        let mutable flags = 0
        if value.entities.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputMedia.Serialize(writer, value.media)
        writer.WriteInt64(value.randomId)
        writer.WriteString(value.message)
        match value.entities with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in MessageEntity.Serialize(writer, item))
        | None -> ()

    static member Deserialize(reader: TlReadBuffer) : InputSingleMedia =
        let _cid = reader.ReadConstructorId()
        let flags = reader.ReadInt32()
        let media = InputMedia.Deserialize(reader)
        let randomId = reader.ReadInt64()
        let message = reader.ReadString()
        let entities = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in MessageEntity.Deserialize(reader))) else None
        {
            media = media
            randomId = randomId
            message = message
            entities = entities
        }

type UserProfilePhoto =
    | UserProfilePhotoEmpty
    | UserProfilePhoto of hasVideo: bool * personal: bool * photoId: int64 * strippedThumb: byte[] option * dcId: int32
with
    static member Serialize(writer: TlWriteBuffer, value: UserProfilePhoto) : unit =
        match value with
        | UserProfilePhotoEmpty ->
            writer.WriteConstructorId(1326562017u)
        | UserProfilePhoto(hasVideo, personal, photoId, strippedThumb, dcId) ->
            writer.WriteConstructorId(2194798342u)
            writer.WriteBool(hasVideo)
            writer.WriteBool(personal)
            writer.WriteInt64(photoId)
            match strippedThumb with Some v -> writer.WriteBytes(v) | None -> ()
            writer.WriteInt32(dcId)

    static member Deserialize(reader: TlReadBuffer) : UserProfilePhoto =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 1326562017u ->
            UserProfilePhotoEmpty
        | 2194798342u ->
            let flags = reader.ReadInt32()
            let hasVideo = flags &&& (1 <<< 0) <> 0
            let personal = flags &&& (1 <<< 2) <> 0
            let photoId = reader.ReadInt64()
            let strippedThumb = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadBytes()) else None
            let dcId = reader.ReadInt32()
            UserProfilePhoto(hasVideo, personal, photoId, strippedThumb, dcId)
        | _ -> failwith $"Unknown constructor id for UserProfilePhoto: 0x{ctorId:X08}"

type VideoSize =
    | VideoSize of ``type``: string * w: int32 * h: int32 * size: int32 * videoStartTs: double option
    | VideoSizeEmojiMarkup of emojiId: int64 * backgroundColors: int32 array
    | VideoSizeStickerMarkup of stickerset: InputStickerSet * stickerId: int64 * backgroundColors: int32 array
with
    static member Serialize(writer: TlWriteBuffer, value: VideoSize) : unit =
        match value with
        | VideoSize(``type``, w, h, size, videoStartTs) ->
            writer.WriteConstructorId(3727929492u)
            writer.WriteString(``type``)
            writer.WriteInt32(w)
            writer.WriteInt32(h)
            writer.WriteInt32(size)
            match videoStartTs with Some v -> writer.WriteDouble(v) | None -> ()
        | VideoSizeEmojiMarkup(emojiId, backgroundColors) ->
            writer.WriteConstructorId(4166795580u)
            writer.WriteInt64(emojiId)
            writer.WriteVector(backgroundColors, fun w item -> let writer = w in writer.WriteInt32(item))
        | VideoSizeStickerMarkup(stickerset, stickerId, backgroundColors) ->
            writer.WriteConstructorId(228623102u)
            InputStickerSet.Serialize(writer, stickerset)
            writer.WriteInt64(stickerId)
            writer.WriteVector(backgroundColors, fun w item -> let writer = w in writer.WriteInt32(item))

    static member Deserialize(reader: TlReadBuffer) : VideoSize =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 3727929492u ->
            let flags = reader.ReadInt32()
            let ``type`` = reader.ReadString()
            let w = reader.ReadInt32()
            let h = reader.ReadInt32()
            let size = reader.ReadInt32()
            let videoStartTs = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadDouble()) else None
            VideoSize(``type``, w, h, size, videoStartTs)
        | 4166795580u ->
            let emojiId = reader.ReadInt64()
            let backgroundColors = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
            VideoSizeEmojiMarkup(emojiId, backgroundColors)
        | 228623102u ->
            let stickerset = InputStickerSet.Deserialize(reader)
            let stickerId = reader.ReadInt64()
            let backgroundColors = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
            VideoSizeStickerMarkup(stickerset, stickerId, backgroundColors)
        | _ -> failwith $"Unknown constructor id for VideoSize: 0x{ctorId:X08}"

type InputChatPhoto =
    | InputChatPhotoEmpty
    | InputChatUploadedPhoto of file: InputFile option * video: InputFile option * videoStartTs: double option * videoEmojiMarkup: VideoSize option
    | InputChatPhoto of id: InputPhoto
with
    static member Serialize(writer: TlWriteBuffer, value: InputChatPhoto) : unit =
        match value with
        | InputChatPhotoEmpty ->
            writer.WriteConstructorId(480546647u)
        | InputChatUploadedPhoto(file, video, videoStartTs, videoEmojiMarkup) ->
            writer.WriteConstructorId(3184373440u)
            match file with Some v -> InputFile.Serialize(writer, v) | None -> ()
            match video with Some v -> InputFile.Serialize(writer, v) | None -> ()
            match videoStartTs with Some v -> writer.WriteDouble(v) | None -> ()
            match videoEmojiMarkup with Some v -> VideoSize.Serialize(writer, v) | None -> ()
        | InputChatPhoto(id) ->
            writer.WriteConstructorId(2303962423u)
            InputPhoto.Serialize(writer, id)

    static member Deserialize(reader: TlReadBuffer) : InputChatPhoto =
        let ctorId = reader.ReadConstructorId()
        match ctorId with
        | 480546647u ->
            InputChatPhotoEmpty
        | 3184373440u ->
            let flags = reader.ReadInt32()
            let file = if flags &&& (1 <<< 0) <> 0 then Some(InputFile.Deserialize(reader)) else None
            let video = if flags &&& (1 <<< 1) <> 0 then Some(InputFile.Deserialize(reader)) else None
            let videoStartTs = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadDouble()) else None
            let videoEmojiMarkup = if flags &&& (1 <<< 3) <> 0 then Some(VideoSize.Deserialize(reader)) else None
            InputChatUploadedPhoto(file, video, videoStartTs, videoEmojiMarkup)
        | 2303962423u ->
            let id = InputPhoto.Deserialize(reader)
            InputChatPhoto(id)
        | _ -> failwith $"Unknown constructor id for InputChatPhoto: 0x{ctorId:X08}"

type AuthSendCode = {
    phoneNumber: string
    apiId: int32
    apiHash: string
    settings: CodeSettings
}
with
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
}
with
    static member ConstructorId: uint32 = 2865215255u

    static member Serialize(writer: TlWriteBuffer, value: AuthSignUp) : unit =
        writer.WriteConstructorId(2865215255u)
        let mutable flags = 0
        if value.noJoinedNotifications then flags <- flags ||| (1 <<< 0)
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
}
with
    static member ConstructorId: uint32 = 2371004753u

    static member Serialize(writer: TlWriteBuffer, value: AuthSignIn) : unit =
        writer.WriteConstructorId(2371004753u)
        let mutable flags = 0
        if value.phoneCode.IsSome then flags <- flags ||| (1 <<< 0)
        if value.emailVerification.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        writer.WriteString(value.phoneNumber)
        writer.WriteString(value.phoneCodeHash)
        match value.phoneCode with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.emailVerification with
        | Some v ->
            EmailVerification.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : AuthSignIn =
        let flags = reader.ReadInt32()
        let phoneNumber = reader.ReadString()
        let phoneCodeHash = reader.ReadString()
        let phoneCode = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
        let emailVerification = if flags &&& (1 <<< 1) <> 0 then Some(EmailVerification.Deserialize(reader)) else None
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

type AuthExportAuthorization = {
    dcId: int32
}
with
    static member ConstructorId: uint32 = 3854565325u

    static member Serialize(writer: TlWriteBuffer, value: AuthExportAuthorization) : unit =
        writer.WriteConstructorId(3854565325u)
        writer.WriteInt32(value.dcId)

    static member DeserializeFields(reader: TlReadBuffer) : AuthExportAuthorization =
        let dcId = reader.ReadInt32()
        {
            dcId = dcId
        }

    static member Deserialize(body: byte[]) : AuthExportAuthorization =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthExportAuthorization.DeserializeFields(reader)

type AuthImportAuthorization = {
    id: int64
    bytes: byte[]
}
with
    static member ConstructorId: uint32 = 2776268205u

    static member Serialize(writer: TlWriteBuffer, value: AuthImportAuthorization) : unit =
        writer.WriteConstructorId(2776268205u)
        writer.WriteInt64(value.id)
        writer.WriteBytes(value.bytes)

    static member DeserializeFields(reader: TlReadBuffer) : AuthImportAuthorization =
        let id = reader.ReadInt64()
        let bytes = reader.ReadBytes()
        {
            id = id
            bytes = bytes
        }

    static member Deserialize(body: byte[]) : AuthImportAuthorization =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthImportAuthorization.DeserializeFields(reader)

type AuthBindTempAuthKey = {
    permAuthKeyId: int64
    nonce: int64
    expiresAt: int32
    encryptedMessage: byte[]
}
with
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
}
with
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

type AuthCheckPassword = {
    password: InputCheckPasswordSRP
}
with
    static member ConstructorId: uint32 = 3515567382u

    static member Serialize(writer: TlWriteBuffer, value: AuthCheckPassword) : unit =
        writer.WriteConstructorId(3515567382u)
        InputCheckPasswordSRP.Serialize(writer, value.password)

    static member DeserializeFields(reader: TlReadBuffer) : AuthCheckPassword =
        let password = InputCheckPasswordSRP.Deserialize(reader)
        {
            password = password
        }

    static member Deserialize(body: byte[]) : AuthCheckPassword =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthCheckPassword.DeserializeFields(reader)

type AuthResendCode = {
    phoneNumber: string
    phoneCodeHash: string
    reason: string option
}
with
    static member ConstructorId: uint32 = 3403969827u

    static member Serialize(writer: TlWriteBuffer, value: AuthResendCode) : unit =
        writer.WriteConstructorId(3403969827u)
        let mutable flags = 0
        if value.reason.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteString(value.phoneNumber)
        writer.WriteString(value.phoneCodeHash)
        match value.reason with
        | Some v ->
            writer.WriteString(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : AuthResendCode =
        let flags = reader.ReadInt32()
        let phoneNumber = reader.ReadString()
        let phoneCodeHash = reader.ReadString()
        let reason = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
        {
            phoneNumber = phoneNumber
            phoneCodeHash = phoneCodeHash
            reason = reason
        }

    static member Deserialize(body: byte[]) : AuthResendCode =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthResendCode.DeserializeFields(reader)

type AuthCancelCode = {
    phoneNumber: string
    phoneCodeHash: string
}
with
    static member ConstructorId: uint32 = 520357240u

    static member Serialize(writer: TlWriteBuffer, value: AuthCancelCode) : unit =
        writer.WriteConstructorId(520357240u)
        writer.WriteString(value.phoneNumber)
        writer.WriteString(value.phoneCodeHash)

    static member DeserializeFields(reader: TlReadBuffer) : AuthCancelCode =
        let phoneNumber = reader.ReadString()
        let phoneCodeHash = reader.ReadString()
        {
            phoneNumber = phoneNumber
            phoneCodeHash = phoneCodeHash
        }

    static member Deserialize(body: byte[]) : AuthCancelCode =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AuthCancelCode.DeserializeFields(reader)

type AuthExportLoginToken = {
    apiId: int32
    apiHash: string
    exceptIds: int64 array
}
with
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

type AccountUpdateNotifySettings = {
    peer: InputNotifyPeer
    settings: InputPeerNotifySettings
}
with
    static member ConstructorId: uint32 = 2227067795u

    static member Serialize(writer: TlWriteBuffer, value: AccountUpdateNotifySettings) : unit =
        writer.WriteConstructorId(2227067795u)
        InputNotifyPeer.Serialize(writer, value.peer)
        InputPeerNotifySettings.Serialize(writer, value.settings)

    static member DeserializeFields(reader: TlReadBuffer) : AccountUpdateNotifySettings =
        let peer = InputNotifyPeer.Deserialize(reader)
        let settings = InputPeerNotifySettings.Deserialize(reader)
        {
            peer = peer
            settings = settings
        }

    static member Deserialize(body: byte[]) : AccountUpdateNotifySettings =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountUpdateNotifySettings.DeserializeFields(reader)

type AccountGetNotifySettings = {
    peer: InputNotifyPeer
}
with
    static member ConstructorId: uint32 = 313765169u

    static member Serialize(writer: TlWriteBuffer, value: AccountGetNotifySettings) : unit =
        writer.WriteConstructorId(313765169u)
        InputNotifyPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : AccountGetNotifySettings =
        let peer = InputNotifyPeer.Deserialize(reader)
        {
            peer = peer
        }

    static member Deserialize(body: byte[]) : AccountGetNotifySettings =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountGetNotifySettings.DeserializeFields(reader)

type AccountUpdateProfile = {
    firstName: string option
    lastName: string option
    about: string option
}
with
    static member ConstructorId: uint32 = 2018596725u

    static member Serialize(writer: TlWriteBuffer, value: AccountUpdateProfile) : unit =
        writer.WriteConstructorId(2018596725u)
        let mutable flags = 0
        if value.firstName.IsSome then flags <- flags ||| (1 <<< 0)
        if value.lastName.IsSome then flags <- flags ||| (1 <<< 1)
        if value.about.IsSome then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)
        match value.firstName with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.lastName with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.about with
        | Some v ->
            writer.WriteString(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : AccountUpdateProfile =
        let flags = reader.ReadInt32()
        let firstName = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
        let lastName = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
        let about = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadString()) else None
        {
            firstName = firstName
            lastName = lastName
            about = about
        }

    static member Deserialize(body: byte[]) : AccountUpdateProfile =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountUpdateProfile.DeserializeFields(reader)

type AccountUpdateStatus = {
    offline: bool
}
with
    static member ConstructorId: uint32 = 1713919532u

    static member Serialize(writer: TlWriteBuffer, value: AccountUpdateStatus) : unit =
        writer.WriteConstructorId(1713919532u)
        writer.WriteBool(value.offline)

    static member DeserializeFields(reader: TlReadBuffer) : AccountUpdateStatus =
        let offline = reader.ReadBool()
        {
            offline = offline
        }

    static member Deserialize(body: byte[]) : AccountUpdateStatus =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountUpdateStatus.DeserializeFields(reader)

type AccountCheckUsername = {
    username: string
}
with
    static member ConstructorId: uint32 = 655677548u

    static member Serialize(writer: TlWriteBuffer, value: AccountCheckUsername) : unit =
        writer.WriteConstructorId(655677548u)
        writer.WriteString(value.username)

    static member DeserializeFields(reader: TlReadBuffer) : AccountCheckUsername =
        let username = reader.ReadString()
        {
            username = username
        }

    static member Deserialize(body: byte[]) : AccountCheckUsername =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountCheckUsername.DeserializeFields(reader)

type AccountUpdateUsername = {
    username: string
}
with
    static member ConstructorId: uint32 = 1040964988u

    static member Serialize(writer: TlWriteBuffer, value: AccountUpdateUsername) : unit =
        writer.WriteConstructorId(1040964988u)
        writer.WriteString(value.username)

    static member DeserializeFields(reader: TlReadBuffer) : AccountUpdateUsername =
        let username = reader.ReadString()
        {
            username = username
        }

    static member Deserialize(body: byte[]) : AccountUpdateUsername =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountUpdateUsername.DeserializeFields(reader)

type AccountGetPrivacy = {
    key: InputPrivacyKey
}
with
    static member ConstructorId: uint32 = 3671837008u

    static member Serialize(writer: TlWriteBuffer, value: AccountGetPrivacy) : unit =
        writer.WriteConstructorId(3671837008u)
        InputPrivacyKey.Serialize(writer, value.key)

    static member DeserializeFields(reader: TlReadBuffer) : AccountGetPrivacy =
        let key = InputPrivacyKey.Deserialize(reader)
        {
            key = key
        }

    static member Deserialize(body: byte[]) : AccountGetPrivacy =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountGetPrivacy.DeserializeFields(reader)

type AccountSetPrivacy = {
    key: InputPrivacyKey
    rules: InputPrivacyRule array
}
with
    static member ConstructorId: uint32 = 3388480744u

    static member Serialize(writer: TlWriteBuffer, value: AccountSetPrivacy) : unit =
        writer.WriteConstructorId(3388480744u)
        InputPrivacyKey.Serialize(writer, value.key)
        writer.WriteVector(value.rules, fun w item -> let writer = w in InputPrivacyRule.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : AccountSetPrivacy =
        let key = InputPrivacyKey.Deserialize(reader)
        let rules = reader.ReadVector(fun r -> let reader = r in InputPrivacyRule.Deserialize(reader))
        {
            key = key
            rules = rules
        }

    static member Deserialize(body: byte[]) : AccountSetPrivacy =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountSetPrivacy.DeserializeFields(reader)

type AccountGetAccountTTL = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 150761757u

    static member Serialize(writer: TlWriteBuffer, value: AccountGetAccountTTL) : unit =
        writer.WriteConstructorId(150761757u)

    static member DeserializeFields(reader: TlReadBuffer) : AccountGetAccountTTL =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : AccountGetAccountTTL =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountGetAccountTTL.DeserializeFields(reader)

type AccountSetAccountTTL = {
    ttl: AccountDaysTTL
}
with
    static member ConstructorId: uint32 = 608323678u

    static member Serialize(writer: TlWriteBuffer, value: AccountSetAccountTTL) : unit =
        writer.WriteConstructorId(608323678u)
        AccountDaysTTL.Serialize(writer, value.ttl)

    static member DeserializeFields(reader: TlReadBuffer) : AccountSetAccountTTL =
        let ttl = AccountDaysTTL.Deserialize(reader)
        {
            ttl = ttl
        }

    static member Deserialize(body: byte[]) : AccountSetAccountTTL =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountSetAccountTTL.DeserializeFields(reader)

type AccountGetAuthorizations = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 3810574680u

    static member Serialize(writer: TlWriteBuffer, value: AccountGetAuthorizations) : unit =
        writer.WriteConstructorId(3810574680u)

    static member DeserializeFields(reader: TlReadBuffer) : AccountGetAuthorizations =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : AccountGetAuthorizations =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountGetAuthorizations.DeserializeFields(reader)

type AccountGetContentSettings = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 2342210990u

    static member Serialize(writer: TlWriteBuffer, value: AccountGetContentSettings) : unit =
        writer.WriteConstructorId(2342210990u)

    static member DeserializeFields(reader: TlReadBuffer) : AccountGetContentSettings =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : AccountGetContentSettings =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountGetContentSettings.DeserializeFields(reader)

type AccountGetGlobalPrivacySettings = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 3945483510u

    static member Serialize(writer: TlWriteBuffer, value: AccountGetGlobalPrivacySettings) : unit =
        writer.WriteConstructorId(3945483510u)

    static member DeserializeFields(reader: TlReadBuffer) : AccountGetGlobalPrivacySettings =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : AccountGetGlobalPrivacySettings =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountGetGlobalPrivacySettings.DeserializeFields(reader)

type AccountSetGlobalPrivacySettings = {
    settings: GlobalPrivacySettings
}
with
    static member ConstructorId: uint32 = 517647042u

    static member Serialize(writer: TlWriteBuffer, value: AccountSetGlobalPrivacySettings) : unit =
        writer.WriteConstructorId(517647042u)
        GlobalPrivacySettings.Serialize(writer, value.settings)

    static member DeserializeFields(reader: TlReadBuffer) : AccountSetGlobalPrivacySettings =
        let settings = GlobalPrivacySettings.Deserialize(reader)
        {
            settings = settings
        }

    static member Deserialize(body: byte[]) : AccountSetGlobalPrivacySettings =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountSetGlobalPrivacySettings.DeserializeFields(reader)

type AccountUpdateBirthday = {
    birthday: Birthday option
}
with
    static member ConstructorId: uint32 = 3429764113u

    static member Serialize(writer: TlWriteBuffer, value: AccountUpdateBirthday) : unit =
        writer.WriteConstructorId(3429764113u)
        let mutable flags = 0
        if value.birthday.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        match value.birthday with
        | Some v ->
            Birthday.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : AccountUpdateBirthday =
        let flags = reader.ReadInt32()
        let birthday = if flags &&& (1 <<< 0) <> 0 then Some(Birthday.Deserialize(reader)) else None
        {
            birthday = birthday
        }

    static member Deserialize(body: byte[]) : AccountUpdateBirthday =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        AccountUpdateBirthday.DeserializeFields(reader)

type UsersGetUsers = {
    id: InputUser array
}
with
    static member ConstructorId: uint32 = 227648840u

    static member Serialize(writer: TlWriteBuffer, value: UsersGetUsers) : unit =
        writer.WriteConstructorId(227648840u)
        writer.WriteVector(value.id, fun w item -> let writer = w in InputUser.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : UsersGetUsers =
        let id = reader.ReadVector(fun r -> let reader = r in InputUser.Deserialize(reader))
        {
            id = id
        }

    static member Deserialize(body: byte[]) : UsersGetUsers =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UsersGetUsers.DeserializeFields(reader)

type UsersGetFullUser = {
    id: InputUser
}
with
    static member ConstructorId: uint32 = 3054459160u

    static member Serialize(writer: TlWriteBuffer, value: UsersGetFullUser) : unit =
        writer.WriteConstructorId(3054459160u)
        InputUser.Serialize(writer, value.id)

    static member DeserializeFields(reader: TlReadBuffer) : UsersGetFullUser =
        let id = InputUser.Deserialize(reader)
        {
            id = id
        }

    static member Deserialize(body: byte[]) : UsersGetFullUser =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UsersGetFullUser.DeserializeFields(reader)

type ContactsGetContactIDs = {
    hash: int64
}
with
    static member ConstructorId: uint32 = 2061264541u

    static member Serialize(writer: TlWriteBuffer, value: ContactsGetContactIDs) : unit =
        writer.WriteConstructorId(2061264541u)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : ContactsGetContactIDs =
        let hash = reader.ReadInt64()
        {
            hash = hash
        }

    static member Deserialize(body: byte[]) : ContactsGetContactIDs =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsGetContactIDs.DeserializeFields(reader)

type ContactsGetStatuses = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 3299038190u

    static member Serialize(writer: TlWriteBuffer, value: ContactsGetStatuses) : unit =
        writer.WriteConstructorId(3299038190u)

    static member DeserializeFields(reader: TlReadBuffer) : ContactsGetStatuses =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : ContactsGetStatuses =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsGetStatuses.DeserializeFields(reader)

type ContactsGetContacts = {
    hash: int64
}
with
    static member ConstructorId: uint32 = 1574346258u

    static member Serialize(writer: TlWriteBuffer, value: ContactsGetContacts) : unit =
        writer.WriteConstructorId(1574346258u)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : ContactsGetContacts =
        let hash = reader.ReadInt64()
        {
            hash = hash
        }

    static member Deserialize(body: byte[]) : ContactsGetContacts =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsGetContacts.DeserializeFields(reader)

type ContactsImportContacts = {
    contacts: InputContact array
}
with
    static member ConstructorId: uint32 = 746589157u

    static member Serialize(writer: TlWriteBuffer, value: ContactsImportContacts) : unit =
        writer.WriteConstructorId(746589157u)
        writer.WriteVector(value.contacts, fun w item -> let writer = w in InputContact.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : ContactsImportContacts =
        let contacts = reader.ReadVector(fun r -> let reader = r in InputContact.Deserialize(reader))
        {
            contacts = contacts
        }

    static member Deserialize(body: byte[]) : ContactsImportContacts =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsImportContacts.DeserializeFields(reader)

type ContactsDeleteContacts = {
    id: InputUser array
}
with
    static member ConstructorId: uint32 = 157945344u

    static member Serialize(writer: TlWriteBuffer, value: ContactsDeleteContacts) : unit =
        writer.WriteConstructorId(157945344u)
        writer.WriteVector(value.id, fun w item -> let writer = w in InputUser.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : ContactsDeleteContacts =
        let id = reader.ReadVector(fun r -> let reader = r in InputUser.Deserialize(reader))
        {
            id = id
        }

    static member Deserialize(body: byte[]) : ContactsDeleteContacts =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsDeleteContacts.DeserializeFields(reader)

type ContactsBlock = {
    myStoriesFrom: bool
    id: InputPeer
}
with
    static member ConstructorId: uint32 = 774801204u

    static member Serialize(writer: TlWriteBuffer, value: ContactsBlock) : unit =
        writer.WriteConstructorId(774801204u)
        let mutable flags = 0
        if value.myStoriesFrom then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.id)

    static member DeserializeFields(reader: TlReadBuffer) : ContactsBlock =
        let flags = reader.ReadInt32()
        let myStoriesFrom = flags &&& (1 <<< 0) <> 0
        let id = InputPeer.Deserialize(reader)
        {
            myStoriesFrom = myStoriesFrom
            id = id
        }

    static member Deserialize(body: byte[]) : ContactsBlock =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsBlock.DeserializeFields(reader)

type ContactsUnblock = {
    myStoriesFrom: bool
    id: InputPeer
}
with
    static member ConstructorId: uint32 = 3041973032u

    static member Serialize(writer: TlWriteBuffer, value: ContactsUnblock) : unit =
        writer.WriteConstructorId(3041973032u)
        let mutable flags = 0
        if value.myStoriesFrom then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.id)

    static member DeserializeFields(reader: TlReadBuffer) : ContactsUnblock =
        let flags = reader.ReadInt32()
        let myStoriesFrom = flags &&& (1 <<< 0) <> 0
        let id = InputPeer.Deserialize(reader)
        {
            myStoriesFrom = myStoriesFrom
            id = id
        }

    static member Deserialize(body: byte[]) : ContactsUnblock =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsUnblock.DeserializeFields(reader)

type ContactsGetBlocked = {
    myStoriesFrom: bool
    offset: int32
    limit: int32
}
with
    static member ConstructorId: uint32 = 2592509824u

    static member Serialize(writer: TlWriteBuffer, value: ContactsGetBlocked) : unit =
        writer.WriteConstructorId(2592509824u)
        let mutable flags = 0
        if value.myStoriesFrom then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.offset)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : ContactsGetBlocked =
        let flags = reader.ReadInt32()
        let myStoriesFrom = flags &&& (1 <<< 0) <> 0
        let offset = reader.ReadInt32()
        let limit = reader.ReadInt32()
        {
            myStoriesFrom = myStoriesFrom
            offset = offset
            limit = limit
        }

    static member Deserialize(body: byte[]) : ContactsGetBlocked =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsGetBlocked.DeserializeFields(reader)

type ContactsSearch = {
    q: string
    limit: int32
}
with
    static member ConstructorId: uint32 = 301470424u

    static member Serialize(writer: TlWriteBuffer, value: ContactsSearch) : unit =
        writer.WriteConstructorId(301470424u)
        writer.WriteString(value.q)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : ContactsSearch =
        let q = reader.ReadString()
        let limit = reader.ReadInt32()
        {
            q = q
            limit = limit
        }

    static member Deserialize(body: byte[]) : ContactsSearch =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsSearch.DeserializeFields(reader)

type ContactsResolveUsername = {
    username: string
    referer: string option
}
with
    static member ConstructorId: uint32 = 1918565308u

    static member Serialize(writer: TlWriteBuffer, value: ContactsResolveUsername) : unit =
        writer.WriteConstructorId(1918565308u)
        let mutable flags = 0
        if value.referer.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteString(value.username)
        match value.referer with
        | Some v ->
            writer.WriteString(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : ContactsResolveUsername =
        let flags = reader.ReadInt32()
        let username = reader.ReadString()
        let referer = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
        {
            username = username
            referer = referer
        }

    static member Deserialize(body: byte[]) : ContactsResolveUsername =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsResolveUsername.DeserializeFields(reader)

type ContactsGetTopPeers = {
    correspondents: bool
    botsPm: bool
    botsInline: bool
    phoneCalls: bool
    forwardUsers: bool
    forwardChats: bool
    groups: bool
    channels: bool
    botsApp: bool
    offset: int32
    limit: int32
    hash: int64
}
with
    static member ConstructorId: uint32 = 2536798390u

    static member Serialize(writer: TlWriteBuffer, value: ContactsGetTopPeers) : unit =
        writer.WriteConstructorId(2536798390u)
        let mutable flags = 0
        if value.correspondents then flags <- flags ||| (1 <<< 0)
        if value.botsPm then flags <- flags ||| (1 <<< 1)
        if value.botsInline then flags <- flags ||| (1 <<< 2)
        if value.phoneCalls then flags <- flags ||| (1 <<< 3)
        if value.forwardUsers then flags <- flags ||| (1 <<< 4)
        if value.forwardChats then flags <- flags ||| (1 <<< 5)
        if value.groups then flags <- flags ||| (1 <<< 10)
        if value.channels then flags <- flags ||| (1 <<< 15)
        if value.botsApp then flags <- flags ||| (1 <<< 16)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.offset)
        writer.WriteInt32(value.limit)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : ContactsGetTopPeers =
        let flags = reader.ReadInt32()
        let correspondents = flags &&& (1 <<< 0) <> 0
        let botsPm = flags &&& (1 <<< 1) <> 0
        let botsInline = flags &&& (1 <<< 2) <> 0
        let phoneCalls = flags &&& (1 <<< 3) <> 0
        let forwardUsers = flags &&& (1 <<< 4) <> 0
        let forwardChats = flags &&& (1 <<< 5) <> 0
        let groups = flags &&& (1 <<< 10) <> 0
        let channels = flags &&& (1 <<< 15) <> 0
        let botsApp = flags &&& (1 <<< 16) <> 0
        let offset = reader.ReadInt32()
        let limit = reader.ReadInt32()
        let hash = reader.ReadInt64()
        {
            correspondents = correspondents
            botsPm = botsPm
            botsInline = botsInline
            phoneCalls = phoneCalls
            forwardUsers = forwardUsers
            forwardChats = forwardChats
            groups = groups
            channels = channels
            botsApp = botsApp
            offset = offset
            limit = limit
            hash = hash
        }

    static member Deserialize(body: byte[]) : ContactsGetTopPeers =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ContactsGetTopPeers.DeserializeFields(reader)

type ContactsAddContact = {
    addPhonePrivacyException: bool
    id: InputUser
    firstName: string
    lastName: string
    phone: string
}
with
    static member ConstructorId: uint32 = 3908330448u

    static member Serialize(writer: TlWriteBuffer, value: ContactsAddContact) : unit =
        writer.WriteConstructorId(3908330448u)
        let mutable flags = 0
        if value.addPhonePrivacyException then flags <- flags ||| (1 <<< 0)
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

type MessagesGetMessages = {
    id: InputMessage array
}
with
    static member ConstructorId: uint32 = 1673946374u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetMessages) : unit =
        writer.WriteConstructorId(1673946374u)
        writer.WriteVector(value.id, fun w item -> let writer = w in InputMessage.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetMessages =
        let id = reader.ReadVector(fun r -> let reader = r in InputMessage.Deserialize(reader))
        {
            id = id
        }

    static member Deserialize(body: byte[]) : MessagesGetMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetMessages.DeserializeFields(reader)

type MessagesGetDialogs = {
    excludePinned: bool
    folderId: int32 option
    offsetDate: int32
    offsetId: int32
    offsetPeer: InputPeer
    limit: int32
    hash: int64
}
with
    static member ConstructorId: uint32 = 2700397391u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetDialogs) : unit =
        writer.WriteConstructorId(2700397391u)
        let mutable flags = 0
        if value.excludePinned then flags <- flags ||| (1 <<< 0)
        if value.folderId.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        match value.folderId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        writer.WriteInt32(value.offsetDate)
        writer.WriteInt32(value.offsetId)
        InputPeer.Serialize(writer, value.offsetPeer)
        writer.WriteInt32(value.limit)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetDialogs =
        let flags = reader.ReadInt32()
        let excludePinned = flags &&& (1 <<< 0) <> 0
        let folderId = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
        let offsetDate = reader.ReadInt32()
        let offsetId = reader.ReadInt32()
        let offsetPeer = InputPeer.Deserialize(reader)
        let limit = reader.ReadInt32()
        let hash = reader.ReadInt64()
        {
            excludePinned = excludePinned
            folderId = folderId
            offsetDate = offsetDate
            offsetId = offsetId
            offsetPeer = offsetPeer
            limit = limit
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesGetDialogs =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetDialogs.DeserializeFields(reader)

type MessagesGetHistory = {
    peer: InputPeer
    offsetId: int32
    offsetDate: int32
    addOffset: int32
    limit: int32
    maxId: int32
    minId: int32
    hash: int64
}
with
    static member ConstructorId: uint32 = 1143203525u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetHistory) : unit =
        writer.WriteConstructorId(1143203525u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.offsetDate)
        writer.WriteInt32(value.addOffset)
        writer.WriteInt32(value.limit)
        writer.WriteInt32(value.maxId)
        writer.WriteInt32(value.minId)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetHistory =
        let peer = InputPeer.Deserialize(reader)
        let offsetId = reader.ReadInt32()
        let offsetDate = reader.ReadInt32()
        let addOffset = reader.ReadInt32()
        let limit = reader.ReadInt32()
        let maxId = reader.ReadInt32()
        let minId = reader.ReadInt32()
        let hash = reader.ReadInt64()
        {
            peer = peer
            offsetId = offsetId
            offsetDate = offsetDate
            addOffset = addOffset
            limit = limit
            maxId = maxId
            minId = minId
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesGetHistory =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetHistory.DeserializeFields(reader)

type MessagesSearch = {
    peer: InputPeer
    q: string
    fromId: InputPeer option
    savedPeerId: InputPeer option
    savedReaction: Reaction array option
    topMsgId: int32 option
    filter: MessagesFilter
    minDate: int32
    maxDate: int32
    offsetId: int32
    addOffset: int32
    limit: int32
    maxId: int32
    minId: int32
    hash: int64
}
with
    static member ConstructorId: uint32 = 703497338u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSearch) : unit =
        writer.WriteConstructorId(703497338u)
        let mutable flags = 0
        if value.fromId.IsSome then flags <- flags ||| (1 <<< 0)
        if value.savedPeerId.IsSome then flags <- flags ||| (1 <<< 2)
        if value.savedReaction.IsSome then flags <- flags ||| (1 <<< 3)
        if value.topMsgId.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteString(value.q)
        match value.fromId with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        match value.savedPeerId with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        match value.savedReaction with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in Reaction.Serialize(writer, item))
        | None -> ()
        match value.topMsgId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        MessagesFilter.Serialize(writer, value.filter)
        writer.WriteInt32(value.minDate)
        writer.WriteInt32(value.maxDate)
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.addOffset)
        writer.WriteInt32(value.limit)
        writer.WriteInt32(value.maxId)
        writer.WriteInt32(value.minId)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSearch =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let q = reader.ReadString()
        let fromId = if flags &&& (1 <<< 0) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let savedPeerId = if flags &&& (1 <<< 2) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let savedReaction = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in Reaction.Deserialize(reader))) else None
        let topMsgId = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
        let filter = MessagesFilter.Deserialize(reader)
        let minDate = reader.ReadInt32()
        let maxDate = reader.ReadInt32()
        let offsetId = reader.ReadInt32()
        let addOffset = reader.ReadInt32()
        let limit = reader.ReadInt32()
        let maxId = reader.ReadInt32()
        let minId = reader.ReadInt32()
        let hash = reader.ReadInt64()
        {
            peer = peer
            q = q
            fromId = fromId
            savedPeerId = savedPeerId
            savedReaction = savedReaction
            topMsgId = topMsgId
            filter = filter
            minDate = minDate
            maxDate = maxDate
            offsetId = offsetId
            addOffset = addOffset
            limit = limit
            maxId = maxId
            minId = minId
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesSearch =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSearch.DeserializeFields(reader)

type MessagesReadHistory = {
    peer: InputPeer
    maxId: int32
}
with
    static member ConstructorId: uint32 = 238054714u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReadHistory) : unit =
        writer.WriteConstructorId(238054714u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.maxId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReadHistory =
        let peer = InputPeer.Deserialize(reader)
        let maxId = reader.ReadInt32()
        {
            peer = peer
            maxId = maxId
        }

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
}
with
    static member ConstructorId: uint32 = 2962199082u

    static member Serialize(writer: TlWriteBuffer, value: MessagesDeleteHistory) : unit =
        writer.WriteConstructorId(2962199082u)
        let mutable flags = 0
        if value.justClear then flags <- flags ||| (1 <<< 0)
        if value.revoke then flags <- flags ||| (1 <<< 1)
        if value.minDate.IsSome then flags <- flags ||| (1 <<< 2)
        if value.maxDate.IsSome then flags <- flags ||| (1 <<< 3)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.maxId)
        match value.minDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.maxDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesDeleteHistory =
        let flags = reader.ReadInt32()
        let justClear = flags &&& (1 <<< 0) <> 0
        let revoke = flags &&& (1 <<< 1) <> 0
        let peer = InputPeer.Deserialize(reader)
        let maxId = reader.ReadInt32()
        let minDate = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadInt32()) else None
        let maxDate = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadInt32()) else None
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
}
with
    static member ConstructorId: uint32 = 3851326930u

    static member Serialize(writer: TlWriteBuffer, value: MessagesDeleteMessages) : unit =
        writer.WriteConstructorId(3851326930u)
        let mutable flags = 0
        if value.revoke then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesDeleteMessages =
        let flags = reader.ReadInt32()
        let revoke = flags &&& (1 <<< 0) <> 0
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            revoke = revoke
            id = id
        }

    static member Deserialize(body: byte[]) : MessagesDeleteMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesDeleteMessages.DeserializeFields(reader)

type MessagesSetTyping = {
    peer: InputPeer
    topMsgId: int32 option
    action: SendMessageAction
}
with
    static member ConstructorId: uint32 = 1486110434u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSetTyping) : unit =
        writer.WriteConstructorId(1486110434u)
        let mutable flags = 0
        if value.topMsgId.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.topMsgId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        SendMessageAction.Serialize(writer, value.action)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSetTyping =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let topMsgId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let action = SendMessageAction.Deserialize(reader)
        {
            peer = peer
            topMsgId = topMsgId
            action = action
        }

    static member Deserialize(body: byte[]) : MessagesSetTyping =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSetTyping.DeserializeFields(reader)

type MessagesSendMessage = {
    noWebpage: bool
    silent: bool
    background: bool
    clearDraft: bool
    noforwards: bool
    updateStickersetsOrder: bool
    invertMedia: bool
    allowPaidFloodskip: bool
    peer: InputPeer
    replyTo: InputReplyTo option
    message: string
    randomId: int64
    replyMarkup: ReplyMarkup option
    entities: MessageEntity array option
    scheduleDate: int32 option
    sendAs: InputPeer option
    quickReplyShortcut: InputQuickReplyShortcut option
    effect: int64 option
    allowPaidStars: int64 option
    suggestedPost: SuggestedPost option
}
with
    static member ConstructorId: uint32 = 4261797018u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendMessage) : unit =
        writer.WriteConstructorId(4261797018u)
        let mutable flags = 0
        if value.noWebpage then flags <- flags ||| (1 <<< 1)
        if value.silent then flags <- flags ||| (1 <<< 5)
        if value.background then flags <- flags ||| (1 <<< 6)
        if value.clearDraft then flags <- flags ||| (1 <<< 7)
        if value.noforwards then flags <- flags ||| (1 <<< 14)
        if value.updateStickersetsOrder then flags <- flags ||| (1 <<< 15)
        if value.invertMedia then flags <- flags ||| (1 <<< 16)
        if value.allowPaidFloodskip then flags <- flags ||| (1 <<< 19)
        if value.replyTo.IsSome then flags <- flags ||| (1 <<< 0)
        if value.replyMarkup.IsSome then flags <- flags ||| (1 <<< 2)
        if value.entities.IsSome then flags <- flags ||| (1 <<< 3)
        if value.scheduleDate.IsSome then flags <- flags ||| (1 <<< 10)
        if value.sendAs.IsSome then flags <- flags ||| (1 <<< 13)
        if value.quickReplyShortcut.IsSome then flags <- flags ||| (1 <<< 17)
        if value.effect.IsSome then flags <- flags ||| (1 <<< 18)
        if value.allowPaidStars.IsSome then flags <- flags ||| (1 <<< 21)
        if value.suggestedPost.IsSome then flags <- flags ||| (1 <<< 22)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.replyTo with
        | Some v ->
            InputReplyTo.Serialize(writer, v)
        | None -> ()
        writer.WriteString(value.message)
        writer.WriteInt64(value.randomId)
        match value.replyMarkup with
        | Some v ->
            ReplyMarkup.Serialize(writer, v)
        | None -> ()
        match value.entities with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in MessageEntity.Serialize(writer, item))
        | None -> ()
        match value.scheduleDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.sendAs with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        match value.quickReplyShortcut with
        | Some v ->
            InputQuickReplyShortcut.Serialize(writer, v)
        | None -> ()
        match value.effect with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        match value.allowPaidStars with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        match value.suggestedPost with
        | Some v ->
            SuggestedPost.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendMessage =
        let flags = reader.ReadInt32()
        let noWebpage = flags &&& (1 <<< 1) <> 0
        let silent = flags &&& (1 <<< 5) <> 0
        let background = flags &&& (1 <<< 6) <> 0
        let clearDraft = flags &&& (1 <<< 7) <> 0
        let noforwards = flags &&& (1 <<< 14) <> 0
        let updateStickersetsOrder = flags &&& (1 <<< 15) <> 0
        let invertMedia = flags &&& (1 <<< 16) <> 0
        let allowPaidFloodskip = flags &&& (1 <<< 19) <> 0
        let peer = InputPeer.Deserialize(reader)
        let replyTo = if flags &&& (1 <<< 0) <> 0 then Some(InputReplyTo.Deserialize(reader)) else None
        let message = reader.ReadString()
        let randomId = reader.ReadInt64()
        let replyMarkup = if flags &&& (1 <<< 2) <> 0 then Some(ReplyMarkup.Deserialize(reader)) else None
        let entities = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in MessageEntity.Deserialize(reader))) else None
        let scheduleDate = if flags &&& (1 <<< 10) <> 0 then Some(reader.ReadInt32()) else None
        let sendAs = if flags &&& (1 <<< 13) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let quickReplyShortcut = if flags &&& (1 <<< 17) <> 0 then Some(InputQuickReplyShortcut.Deserialize(reader)) else None
        let effect = if flags &&& (1 <<< 18) <> 0 then Some(reader.ReadInt64()) else None
        let allowPaidStars = if flags &&& (1 <<< 21) <> 0 then Some(reader.ReadInt64()) else None
        let suggestedPost = if flags &&& (1 <<< 22) <> 0 then Some(SuggestedPost.Deserialize(reader)) else None
        {
            noWebpage = noWebpage
            silent = silent
            background = background
            clearDraft = clearDraft
            noforwards = noforwards
            updateStickersetsOrder = updateStickersetsOrder
            invertMedia = invertMedia
            allowPaidFloodskip = allowPaidFloodskip
            peer = peer
            replyTo = replyTo
            message = message
            randomId = randomId
            replyMarkup = replyMarkup
            entities = entities
            scheduleDate = scheduleDate
            sendAs = sendAs
            quickReplyShortcut = quickReplyShortcut
            effect = effect
            allowPaidStars = allowPaidStars
            suggestedPost = suggestedPost
        }

    static member Deserialize(body: byte[]) : MessagesSendMessage =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendMessage.DeserializeFields(reader)

type MessagesSendMedia = {
    silent: bool
    background: bool
    clearDraft: bool
    noforwards: bool
    updateStickersetsOrder: bool
    invertMedia: bool
    allowPaidFloodskip: bool
    peer: InputPeer
    replyTo: InputReplyTo option
    media: InputMedia
    message: string
    randomId: int64
    replyMarkup: ReplyMarkup option
    entities: MessageEntity array option
    scheduleDate: int32 option
    sendAs: InputPeer option
    quickReplyShortcut: InputQuickReplyShortcut option
    effect: int64 option
    allowPaidStars: int64 option
    suggestedPost: SuggestedPost option
}
with
    static member ConstructorId: uint32 = 2891307457u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendMedia) : unit =
        writer.WriteConstructorId(2891307457u)
        let mutable flags = 0
        if value.silent then flags <- flags ||| (1 <<< 5)
        if value.background then flags <- flags ||| (1 <<< 6)
        if value.clearDraft then flags <- flags ||| (1 <<< 7)
        if value.noforwards then flags <- flags ||| (1 <<< 14)
        if value.updateStickersetsOrder then flags <- flags ||| (1 <<< 15)
        if value.invertMedia then flags <- flags ||| (1 <<< 16)
        if value.allowPaidFloodskip then flags <- flags ||| (1 <<< 19)
        if value.replyTo.IsSome then flags <- flags ||| (1 <<< 0)
        if value.replyMarkup.IsSome then flags <- flags ||| (1 <<< 2)
        if value.entities.IsSome then flags <- flags ||| (1 <<< 3)
        if value.scheduleDate.IsSome then flags <- flags ||| (1 <<< 10)
        if value.sendAs.IsSome then flags <- flags ||| (1 <<< 13)
        if value.quickReplyShortcut.IsSome then flags <- flags ||| (1 <<< 17)
        if value.effect.IsSome then flags <- flags ||| (1 <<< 18)
        if value.allowPaidStars.IsSome then flags <- flags ||| (1 <<< 21)
        if value.suggestedPost.IsSome then flags <- flags ||| (1 <<< 22)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.replyTo with
        | Some v ->
            InputReplyTo.Serialize(writer, v)
        | None -> ()
        InputMedia.Serialize(writer, value.media)
        writer.WriteString(value.message)
        writer.WriteInt64(value.randomId)
        match value.replyMarkup with
        | Some v ->
            ReplyMarkup.Serialize(writer, v)
        | None -> ()
        match value.entities with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in MessageEntity.Serialize(writer, item))
        | None -> ()
        match value.scheduleDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.sendAs with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        match value.quickReplyShortcut with
        | Some v ->
            InputQuickReplyShortcut.Serialize(writer, v)
        | None -> ()
        match value.effect with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        match value.allowPaidStars with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        match value.suggestedPost with
        | Some v ->
            SuggestedPost.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendMedia =
        let flags = reader.ReadInt32()
        let silent = flags &&& (1 <<< 5) <> 0
        let background = flags &&& (1 <<< 6) <> 0
        let clearDraft = flags &&& (1 <<< 7) <> 0
        let noforwards = flags &&& (1 <<< 14) <> 0
        let updateStickersetsOrder = flags &&& (1 <<< 15) <> 0
        let invertMedia = flags &&& (1 <<< 16) <> 0
        let allowPaidFloodskip = flags &&& (1 <<< 19) <> 0
        let peer = InputPeer.Deserialize(reader)
        let replyTo = if flags &&& (1 <<< 0) <> 0 then Some(InputReplyTo.Deserialize(reader)) else None
        let media = InputMedia.Deserialize(reader)
        let message = reader.ReadString()
        let randomId = reader.ReadInt64()
        let replyMarkup = if flags &&& (1 <<< 2) <> 0 then Some(ReplyMarkup.Deserialize(reader)) else None
        let entities = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in MessageEntity.Deserialize(reader))) else None
        let scheduleDate = if flags &&& (1 <<< 10) <> 0 then Some(reader.ReadInt32()) else None
        let sendAs = if flags &&& (1 <<< 13) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let quickReplyShortcut = if flags &&& (1 <<< 17) <> 0 then Some(InputQuickReplyShortcut.Deserialize(reader)) else None
        let effect = if flags &&& (1 <<< 18) <> 0 then Some(reader.ReadInt64()) else None
        let allowPaidStars = if flags &&& (1 <<< 21) <> 0 then Some(reader.ReadInt64()) else None
        let suggestedPost = if flags &&& (1 <<< 22) <> 0 then Some(SuggestedPost.Deserialize(reader)) else None
        {
            silent = silent
            background = background
            clearDraft = clearDraft
            noforwards = noforwards
            updateStickersetsOrder = updateStickersetsOrder
            invertMedia = invertMedia
            allowPaidFloodskip = allowPaidFloodskip
            peer = peer
            replyTo = replyTo
            media = media
            message = message
            randomId = randomId
            replyMarkup = replyMarkup
            entities = entities
            scheduleDate = scheduleDate
            sendAs = sendAs
            quickReplyShortcut = quickReplyShortcut
            effect = effect
            allowPaidStars = allowPaidStars
            suggestedPost = suggestedPost
        }

    static member Deserialize(body: byte[]) : MessagesSendMedia =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendMedia.DeserializeFields(reader)

type MessagesForwardMessages = {
    silent: bool
    background: bool
    withMyScore: bool
    dropAuthor: bool
    dropMediaCaptions: bool
    noforwards: bool
    allowPaidFloodskip: bool
    fromPeer: InputPeer
    id: int32 array
    randomId: int64 array
    toPeer: InputPeer
    topMsgId: int32 option
    replyTo: InputReplyTo option
    scheduleDate: int32 option
    sendAs: InputPeer option
    quickReplyShortcut: InputQuickReplyShortcut option
    videoTimestamp: int32 option
    allowPaidStars: int64 option
    suggestedPost: SuggestedPost option
}
with
    static member ConstructorId: uint32 = 2542348490u

    static member Serialize(writer: TlWriteBuffer, value: MessagesForwardMessages) : unit =
        writer.WriteConstructorId(2542348490u)
        let mutable flags = 0
        if value.silent then flags <- flags ||| (1 <<< 5)
        if value.background then flags <- flags ||| (1 <<< 6)
        if value.withMyScore then flags <- flags ||| (1 <<< 8)
        if value.dropAuthor then flags <- flags ||| (1 <<< 11)
        if value.dropMediaCaptions then flags <- flags ||| (1 <<< 12)
        if value.noforwards then flags <- flags ||| (1 <<< 14)
        if value.allowPaidFloodskip then flags <- flags ||| (1 <<< 19)
        if value.topMsgId.IsSome then flags <- flags ||| (1 <<< 9)
        if value.replyTo.IsSome then flags <- flags ||| (1 <<< 22)
        if value.scheduleDate.IsSome then flags <- flags ||| (1 <<< 10)
        if value.sendAs.IsSome then flags <- flags ||| (1 <<< 13)
        if value.quickReplyShortcut.IsSome then flags <- flags ||| (1 <<< 17)
        if value.videoTimestamp.IsSome then flags <- flags ||| (1 <<< 20)
        if value.allowPaidStars.IsSome then flags <- flags ||| (1 <<< 21)
        if value.suggestedPost.IsSome then flags <- flags ||| (1 <<< 23)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.fromPeer)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))
        writer.WriteVector(value.randomId, fun w item -> let writer = w in writer.WriteInt64(item))
        InputPeer.Serialize(writer, value.toPeer)
        match value.topMsgId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.replyTo with
        | Some v ->
            InputReplyTo.Serialize(writer, v)
        | None -> ()
        match value.scheduleDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.sendAs with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        match value.quickReplyShortcut with
        | Some v ->
            InputQuickReplyShortcut.Serialize(writer, v)
        | None -> ()
        match value.videoTimestamp with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.allowPaidStars with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        match value.suggestedPost with
        | Some v ->
            SuggestedPost.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesForwardMessages =
        let flags = reader.ReadInt32()
        let silent = flags &&& (1 <<< 5) <> 0
        let background = flags &&& (1 <<< 6) <> 0
        let withMyScore = flags &&& (1 <<< 8) <> 0
        let dropAuthor = flags &&& (1 <<< 11) <> 0
        let dropMediaCaptions = flags &&& (1 <<< 12) <> 0
        let noforwards = flags &&& (1 <<< 14) <> 0
        let allowPaidFloodskip = flags &&& (1 <<< 19) <> 0
        let fromPeer = InputPeer.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        let randomId = reader.ReadVector(fun r -> let reader = r in reader.ReadInt64())
        let toPeer = InputPeer.Deserialize(reader)
        let topMsgId = if flags &&& (1 <<< 9) <> 0 then Some(reader.ReadInt32()) else None
        let replyTo = if flags &&& (1 <<< 22) <> 0 then Some(InputReplyTo.Deserialize(reader)) else None
        let scheduleDate = if flags &&& (1 <<< 10) <> 0 then Some(reader.ReadInt32()) else None
        let sendAs = if flags &&& (1 <<< 13) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let quickReplyShortcut = if flags &&& (1 <<< 17) <> 0 then Some(InputQuickReplyShortcut.Deserialize(reader)) else None
        let videoTimestamp = if flags &&& (1 <<< 20) <> 0 then Some(reader.ReadInt32()) else None
        let allowPaidStars = if flags &&& (1 <<< 21) <> 0 then Some(reader.ReadInt64()) else None
        let suggestedPost = if flags &&& (1 <<< 23) <> 0 then Some(SuggestedPost.Deserialize(reader)) else None
        {
            silent = silent
            background = background
            withMyScore = withMyScore
            dropAuthor = dropAuthor
            dropMediaCaptions = dropMediaCaptions
            noforwards = noforwards
            allowPaidFloodskip = allowPaidFloodskip
            fromPeer = fromPeer
            id = id
            randomId = randomId
            toPeer = toPeer
            topMsgId = topMsgId
            replyTo = replyTo
            scheduleDate = scheduleDate
            sendAs = sendAs
            quickReplyShortcut = quickReplyShortcut
            videoTimestamp = videoTimestamp
            allowPaidStars = allowPaidStars
            suggestedPost = suggestedPost
        }

    static member Deserialize(body: byte[]) : MessagesForwardMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesForwardMessages.DeserializeFields(reader)

type MessagesReportSpam = {
    peer: InputPeer
}
with
    static member ConstructorId: uint32 = 3474297563u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReportSpam) : unit =
        writer.WriteConstructorId(3474297563u)
        InputPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReportSpam =
        let peer = InputPeer.Deserialize(reader)
        {
            peer = peer
        }

    static member Deserialize(body: byte[]) : MessagesReportSpam =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReportSpam.DeserializeFields(reader)

type MessagesReport = {
    peer: InputPeer
    id: int32 array
    option: byte[]
    message: string
}
with
    static member ConstructorId: uint32 = 4235767707u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReport) : unit =
        writer.WriteConstructorId(4235767707u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))
        writer.WriteBytes(value.option)
        writer.WriteString(value.message)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReport =
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        let option = reader.ReadBytes()
        let message = reader.ReadString()
        {
            peer = peer
            id = id
            option = option
            message = message
        }

    static member Deserialize(body: byte[]) : MessagesReport =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReport.DeserializeFields(reader)

type MessagesGetChats = {
    id: int64 array
}
with
    static member ConstructorId: uint32 = 1240027791u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetChats) : unit =
        writer.WriteConstructorId(1240027791u)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt64(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetChats =
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt64())
        {
            id = id
        }

    static member Deserialize(body: byte[]) : MessagesGetChats =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetChats.DeserializeFields(reader)

type MessagesGetFullChat = {
    chatId: int64
}
with
    static member ConstructorId: uint32 = 2930772788u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetFullChat) : unit =
        writer.WriteConstructorId(2930772788u)
        writer.WriteInt64(value.chatId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetFullChat =
        let chatId = reader.ReadInt64()
        {
            chatId = chatId
        }

    static member Deserialize(body: byte[]) : MessagesGetFullChat =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetFullChat.DeserializeFields(reader)

type MessagesEditChatTitle = {
    chatId: int64
    title: string
}
with
    static member ConstructorId: uint32 = 1937260541u

    static member Serialize(writer: TlWriteBuffer, value: MessagesEditChatTitle) : unit =
        writer.WriteConstructorId(1937260541u)
        writer.WriteInt64(value.chatId)
        writer.WriteString(value.title)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesEditChatTitle =
        let chatId = reader.ReadInt64()
        let title = reader.ReadString()
        {
            chatId = chatId
            title = title
        }

    static member Deserialize(body: byte[]) : MessagesEditChatTitle =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesEditChatTitle.DeserializeFields(reader)

type MessagesEditChatPhoto = {
    chatId: int64
    photo: InputChatPhoto
}
with
    static member ConstructorId: uint32 = 903730804u

    static member Serialize(writer: TlWriteBuffer, value: MessagesEditChatPhoto) : unit =
        writer.WriteConstructorId(903730804u)
        writer.WriteInt64(value.chatId)
        InputChatPhoto.Serialize(writer, value.photo)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesEditChatPhoto =
        let chatId = reader.ReadInt64()
        let photo = InputChatPhoto.Deserialize(reader)
        {
            chatId = chatId
            photo = photo
        }

    static member Deserialize(body: byte[]) : MessagesEditChatPhoto =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesEditChatPhoto.DeserializeFields(reader)

type MessagesAddChatUser = {
    chatId: int64
    userId: InputUser
    fwdLimit: int32
}
with
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
}
with
    static member ConstructorId: uint32 = 2719505579u

    static member Serialize(writer: TlWriteBuffer, value: MessagesDeleteChatUser) : unit =
        writer.WriteConstructorId(2719505579u)
        let mutable flags = 0
        if value.revokeHistory then flags <- flags ||| (1 <<< 0)
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
}
with
    static member ConstructorId: uint32 = 2463030740u

    static member Serialize(writer: TlWriteBuffer, value: MessagesCreateChat) : unit =
        writer.WriteConstructorId(2463030740u)
        let mutable flags = 0
        if value.ttlPeriod.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteVector(value.users, fun w item -> let writer = w in InputUser.Serialize(writer, item))
        writer.WriteString(value.title)
        match value.ttlPeriod with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesCreateChat =
        let flags = reader.ReadInt32()
        let users = reader.ReadVector(fun r -> let reader = r in InputUser.Deserialize(reader))
        let title = reader.ReadString()
        let ttlPeriod = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        {
            users = users
            title = title
            ttlPeriod = ttlPeriod
        }

    static member Deserialize(body: byte[]) : MessagesCreateChat =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesCreateChat.DeserializeFields(reader)

type MessagesGetDhConfig = {
    version: int32
    randomLength: int32
}
with
    static member ConstructorId: uint32 = 651135312u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetDhConfig) : unit =
        writer.WriteConstructorId(651135312u)
        writer.WriteInt32(value.version)
        writer.WriteInt32(value.randomLength)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetDhConfig =
        let version = reader.ReadInt32()
        let randomLength = reader.ReadInt32()
        {
            version = version
            randomLength = randomLength
        }

    static member Deserialize(body: byte[]) : MessagesGetDhConfig =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetDhConfig.DeserializeFields(reader)

type MessagesRequestEncryption = {
    userId: InputUser
    randomId: int32
    gA: byte[]
}
with
    static member ConstructorId: uint32 = 4132286275u

    static member Serialize(writer: TlWriteBuffer, value: MessagesRequestEncryption) : unit =
        writer.WriteConstructorId(4132286275u)
        InputUser.Serialize(writer, value.userId)
        writer.WriteInt32(value.randomId)
        writer.WriteBytes(value.gA)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesRequestEncryption =
        let userId = InputUser.Deserialize(reader)
        let randomId = reader.ReadInt32()
        let gA = reader.ReadBytes()
        {
            userId = userId
            randomId = randomId
            gA = gA
        }

    static member Deserialize(body: byte[]) : MessagesRequestEncryption =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesRequestEncryption.DeserializeFields(reader)

type MessagesAcceptEncryption = {
    peer: InputEncryptedChat
    gB: byte[]
    keyFingerprint: int64
}
with
    static member ConstructorId: uint32 = 1035731989u

    static member Serialize(writer: TlWriteBuffer, value: MessagesAcceptEncryption) : unit =
        writer.WriteConstructorId(1035731989u)
        InputEncryptedChat.Serialize(writer, value.peer)
        writer.WriteBytes(value.gB)
        writer.WriteInt64(value.keyFingerprint)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesAcceptEncryption =
        let peer = InputEncryptedChat.Deserialize(reader)
        let gB = reader.ReadBytes()
        let keyFingerprint = reader.ReadInt64()
        {
            peer = peer
            gB = gB
            keyFingerprint = keyFingerprint
        }

    static member Deserialize(body: byte[]) : MessagesAcceptEncryption =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesAcceptEncryption.DeserializeFields(reader)

type MessagesDiscardEncryption = {
    deleteHistory: bool
    chatId: int32
}
with
    static member ConstructorId: uint32 = 4086541984u

    static member Serialize(writer: TlWriteBuffer, value: MessagesDiscardEncryption) : unit =
        writer.WriteConstructorId(4086541984u)
        let mutable flags = 0
        if value.deleteHistory then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.chatId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesDiscardEncryption =
        let flags = reader.ReadInt32()
        let deleteHistory = flags &&& (1 <<< 0) <> 0
        let chatId = reader.ReadInt32()
        {
            deleteHistory = deleteHistory
            chatId = chatId
        }

    static member Deserialize(body: byte[]) : MessagesDiscardEncryption =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesDiscardEncryption.DeserializeFields(reader)

type MessagesSetEncryptedTyping = {
    peer: InputEncryptedChat
    typing: bool
}
with
    static member ConstructorId: uint32 = 2031374829u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSetEncryptedTyping) : unit =
        writer.WriteConstructorId(2031374829u)
        InputEncryptedChat.Serialize(writer, value.peer)
        writer.WriteBool(value.typing)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSetEncryptedTyping =
        let peer = InputEncryptedChat.Deserialize(reader)
        let typing = reader.ReadBool()
        {
            peer = peer
            typing = typing
        }

    static member Deserialize(body: byte[]) : MessagesSetEncryptedTyping =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSetEncryptedTyping.DeserializeFields(reader)

type MessagesReadEncryptedHistory = {
    peer: InputEncryptedChat
    maxDate: int32
}
with
    static member ConstructorId: uint32 = 2135648522u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReadEncryptedHistory) : unit =
        writer.WriteConstructorId(2135648522u)
        InputEncryptedChat.Serialize(writer, value.peer)
        writer.WriteInt32(value.maxDate)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReadEncryptedHistory =
        let peer = InputEncryptedChat.Deserialize(reader)
        let maxDate = reader.ReadInt32()
        {
            peer = peer
            maxDate = maxDate
        }

    static member Deserialize(body: byte[]) : MessagesReadEncryptedHistory =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReadEncryptedHistory.DeserializeFields(reader)

type MessagesSendEncrypted = {
    silent: bool
    peer: InputEncryptedChat
    randomId: int64
    data: byte[]
}
with
    static member ConstructorId: uint32 = 1157265941u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendEncrypted) : unit =
        writer.WriteConstructorId(1157265941u)
        let mutable flags = 0
        if value.silent then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputEncryptedChat.Serialize(writer, value.peer)
        writer.WriteInt64(value.randomId)
        writer.WriteBytes(value.data)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendEncrypted =
        let flags = reader.ReadInt32()
        let silent = flags &&& (1 <<< 0) <> 0
        let peer = InputEncryptedChat.Deserialize(reader)
        let randomId = reader.ReadInt64()
        let data = reader.ReadBytes()
        {
            silent = silent
            peer = peer
            randomId = randomId
            data = data
        }

    static member Deserialize(body: byte[]) : MessagesSendEncrypted =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendEncrypted.DeserializeFields(reader)

type MessagesSendEncryptedFile = {
    silent: bool
    peer: InputEncryptedChat
    randomId: int64
    data: byte[]
    file: InputEncryptedFile
}
with
    static member ConstructorId: uint32 = 1431914525u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendEncryptedFile) : unit =
        writer.WriteConstructorId(1431914525u)
        let mutable flags = 0
        if value.silent then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputEncryptedChat.Serialize(writer, value.peer)
        writer.WriteInt64(value.randomId)
        writer.WriteBytes(value.data)
        InputEncryptedFile.Serialize(writer, value.file)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendEncryptedFile =
        let flags = reader.ReadInt32()
        let silent = flags &&& (1 <<< 0) <> 0
        let peer = InputEncryptedChat.Deserialize(reader)
        let randomId = reader.ReadInt64()
        let data = reader.ReadBytes()
        let file = InputEncryptedFile.Deserialize(reader)
        {
            silent = silent
            peer = peer
            randomId = randomId
            data = data
            file = file
        }

    static member Deserialize(body: byte[]) : MessagesSendEncryptedFile =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendEncryptedFile.DeserializeFields(reader)

type MessagesSendEncryptedService = {
    peer: InputEncryptedChat
    randomId: int64
    data: byte[]
}
with
    static member ConstructorId: uint32 = 852769188u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendEncryptedService) : unit =
        writer.WriteConstructorId(852769188u)
        InputEncryptedChat.Serialize(writer, value.peer)
        writer.WriteInt64(value.randomId)
        writer.WriteBytes(value.data)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendEncryptedService =
        let peer = InputEncryptedChat.Deserialize(reader)
        let randomId = reader.ReadInt64()
        let data = reader.ReadBytes()
        {
            peer = peer
            randomId = randomId
            data = data
        }

    static member Deserialize(body: byte[]) : MessagesSendEncryptedService =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendEncryptedService.DeserializeFields(reader)

type MessagesReceivedQueue = {
    maxQts: int32
}
with
    static member ConstructorId: uint32 = 1436924774u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReceivedQueue) : unit =
        writer.WriteConstructorId(1436924774u)
        writer.WriteInt32(value.maxQts)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReceivedQueue =
        let maxQts = reader.ReadInt32()
        {
            maxQts = maxQts
        }

    static member Deserialize(body: byte[]) : MessagesReceivedQueue =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReceivedQueue.DeserializeFields(reader)

type MessagesReadMessageContents = {
    id: int32 array
}
with
    static member ConstructorId: uint32 = 916930423u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReadMessageContents) : unit =
        writer.WriteConstructorId(916930423u)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReadMessageContents =
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            id = id
        }

    static member Deserialize(body: byte[]) : MessagesReadMessageContents =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReadMessageContents.DeserializeFields(reader)

type MessagesExportChatInvite = {
    legacyRevokePermanent: bool
    requestNeeded: bool
    peer: InputPeer
    expireDate: int32 option
    usageLimit: int32 option
    title: string option
    subscriptionPricing: StarsSubscriptionPricing option
}
with
    static member ConstructorId: uint32 = 2757090960u

    static member Serialize(writer: TlWriteBuffer, value: MessagesExportChatInvite) : unit =
        writer.WriteConstructorId(2757090960u)
        let mutable flags = 0
        if value.legacyRevokePermanent then flags <- flags ||| (1 <<< 2)
        if value.requestNeeded then flags <- flags ||| (1 <<< 3)
        if value.expireDate.IsSome then flags <- flags ||| (1 <<< 0)
        if value.usageLimit.IsSome then flags <- flags ||| (1 <<< 1)
        if value.title.IsSome then flags <- flags ||| (1 <<< 4)
        if value.subscriptionPricing.IsSome then flags <- flags ||| (1 <<< 5)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.expireDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.usageLimit with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.title with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.subscriptionPricing with
        | Some v ->
            StarsSubscriptionPricing.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesExportChatInvite =
        let flags = reader.ReadInt32()
        let legacyRevokePermanent = flags &&& (1 <<< 2) <> 0
        let requestNeeded = flags &&& (1 <<< 3) <> 0
        let peer = InputPeer.Deserialize(reader)
        let expireDate = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let usageLimit = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
        let title = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadString()) else None
        let subscriptionPricing = if flags &&& (1 <<< 5) <> 0 then Some(StarsSubscriptionPricing.Deserialize(reader)) else None
        {
            legacyRevokePermanent = legacyRevokePermanent
            requestNeeded = requestNeeded
            peer = peer
            expireDate = expireDate
            usageLimit = usageLimit
            title = title
            subscriptionPricing = subscriptionPricing
        }

    static member Deserialize(body: byte[]) : MessagesExportChatInvite =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesExportChatInvite.DeserializeFields(reader)

type MessagesCheckChatInvite = {
    hash: string
}
with
    static member ConstructorId: uint32 = 1051570619u

    static member Serialize(writer: TlWriteBuffer, value: MessagesCheckChatInvite) : unit =
        writer.WriteConstructorId(1051570619u)
        writer.WriteString(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesCheckChatInvite =
        let hash = reader.ReadString()
        {
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesCheckChatInvite =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesCheckChatInvite.DeserializeFields(reader)

type MessagesImportChatInvite = {
    hash: string
}
with
    static member ConstructorId: uint32 = 1817183516u

    static member Serialize(writer: TlWriteBuffer, value: MessagesImportChatInvite) : unit =
        writer.WriteConstructorId(1817183516u)
        writer.WriteString(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesImportChatInvite =
        let hash = reader.ReadString()
        {
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesImportChatInvite =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesImportChatInvite.DeserializeFields(reader)

type MessagesStartBot = {
    bot: InputUser
    peer: InputPeer
    randomId: int64
    startParam: string
}
with
    static member ConstructorId: uint32 = 3873403768u

    static member Serialize(writer: TlWriteBuffer, value: MessagesStartBot) : unit =
        writer.WriteConstructorId(3873403768u)
        InputUser.Serialize(writer, value.bot)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt64(value.randomId)
        writer.WriteString(value.startParam)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesStartBot =
        let bot = InputUser.Deserialize(reader)
        let peer = InputPeer.Deserialize(reader)
        let randomId = reader.ReadInt64()
        let startParam = reader.ReadString()
        {
            bot = bot
            peer = peer
            randomId = randomId
            startParam = startParam
        }

    static member Deserialize(body: byte[]) : MessagesStartBot =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesStartBot.DeserializeFields(reader)

type MessagesGetMessagesViews = {
    peer: InputPeer
    id: int32 array
    increment: bool
}
with
    static member ConstructorId: uint32 = 1468322785u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetMessagesViews) : unit =
        writer.WriteConstructorId(1468322785u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))
        writer.WriteBool(value.increment)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetMessagesViews =
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        let increment = reader.ReadBool()
        {
            peer = peer
            id = id
            increment = increment
        }

    static member Deserialize(body: byte[]) : MessagesGetMessagesViews =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetMessagesViews.DeserializeFields(reader)

type MessagesEditChatAdmin = {
    chatId: int64
    userId: InputUser
    isAdmin: bool
}
with
    static member ConstructorId: uint32 = 2824589762u

    static member Serialize(writer: TlWriteBuffer, value: MessagesEditChatAdmin) : unit =
        writer.WriteConstructorId(2824589762u)
        writer.WriteInt64(value.chatId)
        InputUser.Serialize(writer, value.userId)
        writer.WriteBool(value.isAdmin)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesEditChatAdmin =
        let chatId = reader.ReadInt64()
        let userId = InputUser.Deserialize(reader)
        let isAdmin = reader.ReadBool()
        {
            chatId = chatId
            userId = userId
            isAdmin = isAdmin
        }

    static member Deserialize(body: byte[]) : MessagesEditChatAdmin =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesEditChatAdmin.DeserializeFields(reader)

type MessagesMigrateChat = {
    chatId: int64
}
with
    static member ConstructorId: uint32 = 2726777625u

    static member Serialize(writer: TlWriteBuffer, value: MessagesMigrateChat) : unit =
        writer.WriteConstructorId(2726777625u)
        writer.WriteInt64(value.chatId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesMigrateChat =
        let chatId = reader.ReadInt64()
        {
            chatId = chatId
        }

    static member Deserialize(body: byte[]) : MessagesMigrateChat =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesMigrateChat.DeserializeFields(reader)

type MessagesSearchGlobal = {
    broadcastsOnly: bool
    groupsOnly: bool
    usersOnly: bool
    folderId: int32 option
    q: string
    filter: MessagesFilter
    minDate: int32
    maxDate: int32
    offsetRate: int32
    offsetPeer: InputPeer
    offsetId: int32
    limit: int32
}
with
    static member ConstructorId: uint32 = 1271290010u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSearchGlobal) : unit =
        writer.WriteConstructorId(1271290010u)
        let mutable flags = 0
        if value.broadcastsOnly then flags <- flags ||| (1 <<< 1)
        if value.groupsOnly then flags <- flags ||| (1 <<< 2)
        if value.usersOnly then flags <- flags ||| (1 <<< 3)
        if value.folderId.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        match value.folderId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        writer.WriteString(value.q)
        MessagesFilter.Serialize(writer, value.filter)
        writer.WriteInt32(value.minDate)
        writer.WriteInt32(value.maxDate)
        writer.WriteInt32(value.offsetRate)
        InputPeer.Serialize(writer, value.offsetPeer)
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSearchGlobal =
        let flags = reader.ReadInt32()
        let broadcastsOnly = flags &&& (1 <<< 1) <> 0
        let groupsOnly = flags &&& (1 <<< 2) <> 0
        let usersOnly = flags &&& (1 <<< 3) <> 0
        let folderId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let q = reader.ReadString()
        let filter = MessagesFilter.Deserialize(reader)
        let minDate = reader.ReadInt32()
        let maxDate = reader.ReadInt32()
        let offsetRate = reader.ReadInt32()
        let offsetPeer = InputPeer.Deserialize(reader)
        let offsetId = reader.ReadInt32()
        let limit = reader.ReadInt32()
        {
            broadcastsOnly = broadcastsOnly
            groupsOnly = groupsOnly
            usersOnly = usersOnly
            folderId = folderId
            q = q
            filter = filter
            minDate = minDate
            maxDate = maxDate
            offsetRate = offsetRate
            offsetPeer = offsetPeer
            offsetId = offsetId
            limit = limit
        }

    static member Deserialize(body: byte[]) : MessagesSearchGlobal =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSearchGlobal.DeserializeFields(reader)

type MessagesGetInlineBotResults = {
    bot: InputUser
    peer: InputPeer
    geoPoint: InputGeoPoint option
    query: string
    offset: string
}
with
    static member ConstructorId: uint32 = 1364105629u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetInlineBotResults) : unit =
        writer.WriteConstructorId(1364105629u)
        let mutable flags = 0
        if value.geoPoint.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputUser.Serialize(writer, value.bot)
        InputPeer.Serialize(writer, value.peer)
        match value.geoPoint with
        | Some v ->
            InputGeoPoint.Serialize(writer, v)
        | None -> ()
        writer.WriteString(value.query)
        writer.WriteString(value.offset)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetInlineBotResults =
        let flags = reader.ReadInt32()
        let bot = InputUser.Deserialize(reader)
        let peer = InputPeer.Deserialize(reader)
        let geoPoint = if flags &&& (1 <<< 0) <> 0 then Some(InputGeoPoint.Deserialize(reader)) else None
        let query = reader.ReadString()
        let offset = reader.ReadString()
        {
            bot = bot
            peer = peer
            geoPoint = geoPoint
            query = query
            offset = offset
        }

    static member Deserialize(body: byte[]) : MessagesGetInlineBotResults =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetInlineBotResults.DeserializeFields(reader)

type MessagesSendInlineBotResult = {
    silent: bool
    background: bool
    clearDraft: bool
    hideVia: bool
    peer: InputPeer
    replyTo: InputReplyTo option
    randomId: int64
    queryId: int64
    id: string
    scheduleDate: int32 option
    sendAs: InputPeer option
    quickReplyShortcut: InputQuickReplyShortcut option
    allowPaidStars: int64 option
}
with
    static member ConstructorId: uint32 = 3234821702u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendInlineBotResult) : unit =
        writer.WriteConstructorId(3234821702u)
        let mutable flags = 0
        if value.silent then flags <- flags ||| (1 <<< 5)
        if value.background then flags <- flags ||| (1 <<< 6)
        if value.clearDraft then flags <- flags ||| (1 <<< 7)
        if value.hideVia then flags <- flags ||| (1 <<< 11)
        if value.replyTo.IsSome then flags <- flags ||| (1 <<< 0)
        if value.scheduleDate.IsSome then flags <- flags ||| (1 <<< 10)
        if value.sendAs.IsSome then flags <- flags ||| (1 <<< 13)
        if value.quickReplyShortcut.IsSome then flags <- flags ||| (1 <<< 17)
        if value.allowPaidStars.IsSome then flags <- flags ||| (1 <<< 21)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.replyTo with
        | Some v ->
            InputReplyTo.Serialize(writer, v)
        | None -> ()
        writer.WriteInt64(value.randomId)
        writer.WriteInt64(value.queryId)
        writer.WriteString(value.id)
        match value.scheduleDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.sendAs with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        match value.quickReplyShortcut with
        | Some v ->
            InputQuickReplyShortcut.Serialize(writer, v)
        | None -> ()
        match value.allowPaidStars with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendInlineBotResult =
        let flags = reader.ReadInt32()
        let silent = flags &&& (1 <<< 5) <> 0
        let background = flags &&& (1 <<< 6) <> 0
        let clearDraft = flags &&& (1 <<< 7) <> 0
        let hideVia = flags &&& (1 <<< 11) <> 0
        let peer = InputPeer.Deserialize(reader)
        let replyTo = if flags &&& (1 <<< 0) <> 0 then Some(InputReplyTo.Deserialize(reader)) else None
        let randomId = reader.ReadInt64()
        let queryId = reader.ReadInt64()
        let id = reader.ReadString()
        let scheduleDate = if flags &&& (1 <<< 10) <> 0 then Some(reader.ReadInt32()) else None
        let sendAs = if flags &&& (1 <<< 13) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let quickReplyShortcut = if flags &&& (1 <<< 17) <> 0 then Some(InputQuickReplyShortcut.Deserialize(reader)) else None
        let allowPaidStars = if flags &&& (1 <<< 21) <> 0 then Some(reader.ReadInt64()) else None
        {
            silent = silent
            background = background
            clearDraft = clearDraft
            hideVia = hideVia
            peer = peer
            replyTo = replyTo
            randomId = randomId
            queryId = queryId
            id = id
            scheduleDate = scheduleDate
            sendAs = sendAs
            quickReplyShortcut = quickReplyShortcut
            allowPaidStars = allowPaidStars
        }

    static member Deserialize(body: byte[]) : MessagesSendInlineBotResult =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendInlineBotResult.DeserializeFields(reader)

type MessagesEditMessage = {
    noWebpage: bool
    invertMedia: bool
    peer: InputPeer
    id: int32
    message: string option
    media: InputMedia option
    replyMarkup: ReplyMarkup option
    entities: MessageEntity array option
    scheduleDate: int32 option
    quickReplyShortcutId: int32 option
}
with
    static member ConstructorId: uint32 = 3755032581u

    static member Serialize(writer: TlWriteBuffer, value: MessagesEditMessage) : unit =
        writer.WriteConstructorId(3755032581u)
        let mutable flags = 0
        if value.noWebpage then flags <- flags ||| (1 <<< 1)
        if value.invertMedia then flags <- flags ||| (1 <<< 16)
        if value.message.IsSome then flags <- flags ||| (1 <<< 11)
        if value.media.IsSome then flags <- flags ||| (1 <<< 14)
        if value.replyMarkup.IsSome then flags <- flags ||| (1 <<< 2)
        if value.entities.IsSome then flags <- flags ||| (1 <<< 3)
        if value.scheduleDate.IsSome then flags <- flags ||| (1 <<< 15)
        if value.quickReplyShortcutId.IsSome then flags <- flags ||| (1 <<< 17)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.id)
        match value.message with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.media with
        | Some v ->
            InputMedia.Serialize(writer, v)
        | None -> ()
        match value.replyMarkup with
        | Some v ->
            ReplyMarkup.Serialize(writer, v)
        | None -> ()
        match value.entities with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in MessageEntity.Serialize(writer, item))
        | None -> ()
        match value.scheduleDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.quickReplyShortcutId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesEditMessage =
        let flags = reader.ReadInt32()
        let noWebpage = flags &&& (1 <<< 1) <> 0
        let invertMedia = flags &&& (1 <<< 16) <> 0
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadInt32()
        let message = if flags &&& (1 <<< 11) <> 0 then Some(reader.ReadString()) else None
        let media = if flags &&& (1 <<< 14) <> 0 then Some(InputMedia.Deserialize(reader)) else None
        let replyMarkup = if flags &&& (1 <<< 2) <> 0 then Some(ReplyMarkup.Deserialize(reader)) else None
        let entities = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in MessageEntity.Deserialize(reader))) else None
        let scheduleDate = if flags &&& (1 <<< 15) <> 0 then Some(reader.ReadInt32()) else None
        let quickReplyShortcutId = if flags &&& (1 <<< 17) <> 0 then Some(reader.ReadInt32()) else None
        {
            noWebpage = noWebpage
            invertMedia = invertMedia
            peer = peer
            id = id
            message = message
            media = media
            replyMarkup = replyMarkup
            entities = entities
            scheduleDate = scheduleDate
            quickReplyShortcutId = quickReplyShortcutId
        }

    static member Deserialize(body: byte[]) : MessagesEditMessage =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesEditMessage.DeserializeFields(reader)

type MessagesGetBotCallbackAnswer = {
    game: bool
    peer: InputPeer
    msgId: int32
    data: byte[] option
    password: InputCheckPasswordSRP option
}
with
    static member ConstructorId: uint32 = 2470627847u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetBotCallbackAnswer) : unit =
        writer.WriteConstructorId(2470627847u)
        let mutable flags = 0
        if value.game then flags <- flags ||| (1 <<< 1)
        if value.data.IsSome then flags <- flags ||| (1 <<< 0)
        if value.password.IsSome then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.msgId)
        match value.data with
        | Some v ->
            writer.WriteBytes(v)
        | None -> ()
        match value.password with
        | Some v ->
            InputCheckPasswordSRP.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetBotCallbackAnswer =
        let flags = reader.ReadInt32()
        let game = flags &&& (1 <<< 1) <> 0
        let peer = InputPeer.Deserialize(reader)
        let msgId = reader.ReadInt32()
        let data = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadBytes()) else None
        let password = if flags &&& (1 <<< 2) <> 0 then Some(InputCheckPasswordSRP.Deserialize(reader)) else None
        {
            game = game
            peer = peer
            msgId = msgId
            data = data
            password = password
        }

    static member Deserialize(body: byte[]) : MessagesGetBotCallbackAnswer =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetBotCallbackAnswer.DeserializeFields(reader)

type MessagesGetPeerDialogs = {
    peers: InputDialogPeer array
}
with
    static member ConstructorId: uint32 = 3832593661u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetPeerDialogs) : unit =
        writer.WriteConstructorId(3832593661u)
        writer.WriteVector(value.peers, fun w item -> let writer = w in InputDialogPeer.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetPeerDialogs =
        let peers = reader.ReadVector(fun r -> let reader = r in InputDialogPeer.Deserialize(reader))
        {
            peers = peers
        }

    static member Deserialize(body: byte[]) : MessagesGetPeerDialogs =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetPeerDialogs.DeserializeFields(reader)

type MessagesSaveDraft = {
    noWebpage: bool
    invertMedia: bool
    replyTo: InputReplyTo option
    peer: InputPeer
    message: string
    entities: MessageEntity array option
    media: InputMedia option
    effect: int64 option
    suggestedPost: SuggestedPost option
}
with
    static member ConstructorId: uint32 = 1420701838u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSaveDraft) : unit =
        writer.WriteConstructorId(1420701838u)
        let mutable flags = 0
        if value.noWebpage then flags <- flags ||| (1 <<< 1)
        if value.invertMedia then flags <- flags ||| (1 <<< 6)
        if value.replyTo.IsSome then flags <- flags ||| (1 <<< 4)
        if value.entities.IsSome then flags <- flags ||| (1 <<< 3)
        if value.media.IsSome then flags <- flags ||| (1 <<< 5)
        if value.effect.IsSome then flags <- flags ||| (1 <<< 7)
        if value.suggestedPost.IsSome then flags <- flags ||| (1 <<< 8)
        writer.WriteInt32(flags)
        match value.replyTo with
        | Some v ->
            InputReplyTo.Serialize(writer, v)
        | None -> ()
        InputPeer.Serialize(writer, value.peer)
        writer.WriteString(value.message)
        match value.entities with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in MessageEntity.Serialize(writer, item))
        | None -> ()
        match value.media with
        | Some v ->
            InputMedia.Serialize(writer, v)
        | None -> ()
        match value.effect with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        match value.suggestedPost with
        | Some v ->
            SuggestedPost.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSaveDraft =
        let flags = reader.ReadInt32()
        let noWebpage = flags &&& (1 <<< 1) <> 0
        let invertMedia = flags &&& (1 <<< 6) <> 0
        let replyTo = if flags &&& (1 <<< 4) <> 0 then Some(InputReplyTo.Deserialize(reader)) else None
        let peer = InputPeer.Deserialize(reader)
        let message = reader.ReadString()
        let entities = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in MessageEntity.Deserialize(reader))) else None
        let media = if flags &&& (1 <<< 5) <> 0 then Some(InputMedia.Deserialize(reader)) else None
        let effect = if flags &&& (1 <<< 7) <> 0 then Some(reader.ReadInt64()) else None
        let suggestedPost = if flags &&& (1 <<< 8) <> 0 then Some(SuggestedPost.Deserialize(reader)) else None
        {
            noWebpage = noWebpage
            invertMedia = invertMedia
            replyTo = replyTo
            peer = peer
            message = message
            entities = entities
            media = media
            effect = effect
            suggestedPost = suggestedPost
        }

    static member Deserialize(body: byte[]) : MessagesSaveDraft =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSaveDraft.DeserializeFields(reader)

type MessagesGetAllDrafts = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 1782549861u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetAllDrafts) : unit =
        writer.WriteConstructorId(1782549861u)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetAllDrafts =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : MessagesGetAllDrafts =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetAllDrafts.DeserializeFields(reader)

type MessagesGetCommonChats = {
    userId: InputUser
    maxId: int64
    limit: int32
}
with
    static member ConstructorId: uint32 = 3826032900u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetCommonChats) : unit =
        writer.WriteConstructorId(3826032900u)
        InputUser.Serialize(writer, value.userId)
        writer.WriteInt64(value.maxId)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetCommonChats =
        let userId = InputUser.Deserialize(reader)
        let maxId = reader.ReadInt64()
        let limit = reader.ReadInt32()
        {
            userId = userId
            maxId = maxId
            limit = limit
        }

    static member Deserialize(body: byte[]) : MessagesGetCommonChats =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetCommonChats.DeserializeFields(reader)

type MessagesGetWebPage = {
    url: string
    hash: int32
}
with
    static member ConstructorId: uint32 = 2375455395u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetWebPage) : unit =
        writer.WriteConstructorId(2375455395u)
        writer.WriteString(value.url)
        writer.WriteInt32(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetWebPage =
        let url = reader.ReadString()
        let hash = reader.ReadInt32()
        {
            url = url
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesGetWebPage =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetWebPage.DeserializeFields(reader)

type MessagesToggleDialogPin = {
    pinned: bool
    peer: InputDialogPeer
}
with
    static member ConstructorId: uint32 = 2805064279u

    static member Serialize(writer: TlWriteBuffer, value: MessagesToggleDialogPin) : unit =
        writer.WriteConstructorId(2805064279u)
        let mutable flags = 0
        if value.pinned then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputDialogPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesToggleDialogPin =
        let flags = reader.ReadInt32()
        let pinned = flags &&& (1 <<< 0) <> 0
        let peer = InputDialogPeer.Deserialize(reader)
        {
            pinned = pinned
            peer = peer
        }

    static member Deserialize(body: byte[]) : MessagesToggleDialogPin =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesToggleDialogPin.DeserializeFields(reader)

type MessagesReorderPinnedDialogs = {
    force: bool
    folderId: int32
    order: InputDialogPeer array
}
with
    static member ConstructorId: uint32 = 991616823u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReorderPinnedDialogs) : unit =
        writer.WriteConstructorId(991616823u)
        let mutable flags = 0
        if value.force then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.folderId)
        writer.WriteVector(value.order, fun w item -> let writer = w in InputDialogPeer.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReorderPinnedDialogs =
        let flags = reader.ReadInt32()
        let force = flags &&& (1 <<< 0) <> 0
        let folderId = reader.ReadInt32()
        let order = reader.ReadVector(fun r -> let reader = r in InputDialogPeer.Deserialize(reader))
        {
            force = force
            folderId = folderId
            order = order
        }

    static member Deserialize(body: byte[]) : MessagesReorderPinnedDialogs =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReorderPinnedDialogs.DeserializeFields(reader)

type MessagesGetPinnedDialogs = {
    folderId: int32
}
with
    static member ConstructorId: uint32 = 3602468338u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetPinnedDialogs) : unit =
        writer.WriteConstructorId(3602468338u)
        writer.WriteInt32(value.folderId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetPinnedDialogs =
        let folderId = reader.ReadInt32()
        {
            folderId = folderId
        }

    static member Deserialize(body: byte[]) : MessagesGetPinnedDialogs =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetPinnedDialogs.DeserializeFields(reader)

type MessagesUploadMedia = {
    businessConnectionId: string option
    peer: InputPeer
    media: InputMedia
}
with
    static member ConstructorId: uint32 = 345405816u

    static member Serialize(writer: TlWriteBuffer, value: MessagesUploadMedia) : unit =
        writer.WriteConstructorId(345405816u)
        let mutable flags = 0
        if value.businessConnectionId.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        match value.businessConnectionId with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        InputPeer.Serialize(writer, value.peer)
        InputMedia.Serialize(writer, value.media)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesUploadMedia =
        let flags = reader.ReadInt32()
        let businessConnectionId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
        let peer = InputPeer.Deserialize(reader)
        let media = InputMedia.Deserialize(reader)
        {
            businessConnectionId = businessConnectionId
            peer = peer
            media = media
        }

    static member Deserialize(body: byte[]) : MessagesUploadMedia =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesUploadMedia.DeserializeFields(reader)

type MessagesGetUnreadMentions = {
    peer: InputPeer
    topMsgId: int32 option
    offsetId: int32
    addOffset: int32
    limit: int32
    maxId: int32
    minId: int32
}
with
    static member ConstructorId: uint32 = 4043827088u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetUnreadMentions) : unit =
        writer.WriteConstructorId(4043827088u)
        let mutable flags = 0
        if value.topMsgId.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.topMsgId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.addOffset)
        writer.WriteInt32(value.limit)
        writer.WriteInt32(value.maxId)
        writer.WriteInt32(value.minId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetUnreadMentions =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let topMsgId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let offsetId = reader.ReadInt32()
        let addOffset = reader.ReadInt32()
        let limit = reader.ReadInt32()
        let maxId = reader.ReadInt32()
        let minId = reader.ReadInt32()
        {
            peer = peer
            topMsgId = topMsgId
            offsetId = offsetId
            addOffset = addOffset
            limit = limit
            maxId = maxId
            minId = minId
        }

    static member Deserialize(body: byte[]) : MessagesGetUnreadMentions =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetUnreadMentions.DeserializeFields(reader)

type MessagesReadMentions = {
    peer: InputPeer
    topMsgId: int32 option
}
with
    static member ConstructorId: uint32 = 921026381u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReadMentions) : unit =
        writer.WriteConstructorId(921026381u)
        let mutable flags = 0
        if value.topMsgId.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.topMsgId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReadMentions =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let topMsgId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        {
            peer = peer
            topMsgId = topMsgId
        }

    static member Deserialize(body: byte[]) : MessagesReadMentions =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReadMentions.DeserializeFields(reader)

type MessagesSendMultiMedia = {
    silent: bool
    background: bool
    clearDraft: bool
    noforwards: bool
    updateStickersetsOrder: bool
    invertMedia: bool
    allowPaidFloodskip: bool
    peer: InputPeer
    replyTo: InputReplyTo option
    multiMedia: InputSingleMedia array
    scheduleDate: int32 option
    sendAs: InputPeer option
    quickReplyShortcut: InputQuickReplyShortcut option
    effect: int64 option
    allowPaidStars: int64 option
}
with
    static member ConstructorId: uint32 = 469278068u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendMultiMedia) : unit =
        writer.WriteConstructorId(469278068u)
        let mutable flags = 0
        if value.silent then flags <- flags ||| (1 <<< 5)
        if value.background then flags <- flags ||| (1 <<< 6)
        if value.clearDraft then flags <- flags ||| (1 <<< 7)
        if value.noforwards then flags <- flags ||| (1 <<< 14)
        if value.updateStickersetsOrder then flags <- flags ||| (1 <<< 15)
        if value.invertMedia then flags <- flags ||| (1 <<< 16)
        if value.allowPaidFloodskip then flags <- flags ||| (1 <<< 19)
        if value.replyTo.IsSome then flags <- flags ||| (1 <<< 0)
        if value.scheduleDate.IsSome then flags <- flags ||| (1 <<< 10)
        if value.sendAs.IsSome then flags <- flags ||| (1 <<< 13)
        if value.quickReplyShortcut.IsSome then flags <- flags ||| (1 <<< 17)
        if value.effect.IsSome then flags <- flags ||| (1 <<< 18)
        if value.allowPaidStars.IsSome then flags <- flags ||| (1 <<< 21)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.replyTo with
        | Some v ->
            InputReplyTo.Serialize(writer, v)
        | None -> ()
        writer.WriteVector(value.multiMedia, fun w item -> let writer = w in InputSingleMedia.Serialize(writer, item))
        match value.scheduleDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.sendAs with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        match value.quickReplyShortcut with
        | Some v ->
            InputQuickReplyShortcut.Serialize(writer, v)
        | None -> ()
        match value.effect with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        match value.allowPaidStars with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendMultiMedia =
        let flags = reader.ReadInt32()
        let silent = flags &&& (1 <<< 5) <> 0
        let background = flags &&& (1 <<< 6) <> 0
        let clearDraft = flags &&& (1 <<< 7) <> 0
        let noforwards = flags &&& (1 <<< 14) <> 0
        let updateStickersetsOrder = flags &&& (1 <<< 15) <> 0
        let invertMedia = flags &&& (1 <<< 16) <> 0
        let allowPaidFloodskip = flags &&& (1 <<< 19) <> 0
        let peer = InputPeer.Deserialize(reader)
        let replyTo = if flags &&& (1 <<< 0) <> 0 then Some(InputReplyTo.Deserialize(reader)) else None
        let multiMedia = reader.ReadVector(fun r -> let reader = r in InputSingleMedia.Deserialize(reader))
        let scheduleDate = if flags &&& (1 <<< 10) <> 0 then Some(reader.ReadInt32()) else None
        let sendAs = if flags &&& (1 <<< 13) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let quickReplyShortcut = if flags &&& (1 <<< 17) <> 0 then Some(InputQuickReplyShortcut.Deserialize(reader)) else None
        let effect = if flags &&& (1 <<< 18) <> 0 then Some(reader.ReadInt64()) else None
        let allowPaidStars = if flags &&& (1 <<< 21) <> 0 then Some(reader.ReadInt64()) else None
        {
            silent = silent
            background = background
            clearDraft = clearDraft
            noforwards = noforwards
            updateStickersetsOrder = updateStickersetsOrder
            invertMedia = invertMedia
            allowPaidFloodskip = allowPaidFloodskip
            peer = peer
            replyTo = replyTo
            multiMedia = multiMedia
            scheduleDate = scheduleDate
            sendAs = sendAs
            quickReplyShortcut = quickReplyShortcut
            effect = effect
            allowPaidStars = allowPaidStars
        }

    static member Deserialize(body: byte[]) : MessagesSendMultiMedia =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendMultiMedia.DeserializeFields(reader)

type MessagesMarkDialogUnread = {
    unread: bool
    parentPeer: InputPeer option
    peer: InputDialogPeer
}
with
    static member ConstructorId: uint32 = 2354054904u

    static member Serialize(writer: TlWriteBuffer, value: MessagesMarkDialogUnread) : unit =
        writer.WriteConstructorId(2354054904u)
        let mutable flags = 0
        if value.unread then flags <- flags ||| (1 <<< 0)
        if value.parentPeer.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        match value.parentPeer with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        InputDialogPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesMarkDialogUnread =
        let flags = reader.ReadInt32()
        let unread = flags &&& (1 <<< 0) <> 0
        let parentPeer = if flags &&& (1 <<< 1) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let peer = InputDialogPeer.Deserialize(reader)
        {
            unread = unread
            parentPeer = parentPeer
            peer = peer
        }

    static member Deserialize(body: byte[]) : MessagesMarkDialogUnread =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesMarkDialogUnread.DeserializeFields(reader)

type MessagesClearAllDrafts = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 2119757468u

    static member Serialize(writer: TlWriteBuffer, value: MessagesClearAllDrafts) : unit =
        writer.WriteConstructorId(2119757468u)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesClearAllDrafts =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : MessagesClearAllDrafts =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesClearAllDrafts.DeserializeFields(reader)

type MessagesUpdatePinnedMessage = {
    silent: bool
    unpin: bool
    pmOneside: bool
    peer: InputPeer
    id: int32
}
with
    static member ConstructorId: uint32 = 3534419948u

    static member Serialize(writer: TlWriteBuffer, value: MessagesUpdatePinnedMessage) : unit =
        writer.WriteConstructorId(3534419948u)
        let mutable flags = 0
        if value.silent then flags <- flags ||| (1 <<< 0)
        if value.unpin then flags <- flags ||| (1 <<< 1)
        if value.pmOneside then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.id)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesUpdatePinnedMessage =
        let flags = reader.ReadInt32()
        let silent = flags &&& (1 <<< 0) <> 0
        let unpin = flags &&& (1 <<< 1) <> 0
        let pmOneside = flags &&& (1 <<< 2) <> 0
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadInt32()
        {
            silent = silent
            unpin = unpin
            pmOneside = pmOneside
            peer = peer
            id = id
        }

    static member Deserialize(body: byte[]) : MessagesUpdatePinnedMessage =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesUpdatePinnedMessage.DeserializeFields(reader)

type MessagesSendVote = {
    peer: InputPeer
    msgId: int32
    options: byte[] array
}
with
    static member ConstructorId: uint32 = 283795844u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendVote) : unit =
        writer.WriteConstructorId(283795844u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.msgId)
        writer.WriteVector(value.options, fun w item -> let writer = w in writer.WriteBytes(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendVote =
        let peer = InputPeer.Deserialize(reader)
        let msgId = reader.ReadInt32()
        let options = reader.ReadVector(fun r -> let reader = r in reader.ReadBytes())
        {
            peer = peer
            msgId = msgId
            options = options
        }

    static member Deserialize(body: byte[]) : MessagesSendVote =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendVote.DeserializeFields(reader)

type MessagesGetPollResults = {
    peer: InputPeer
    msgId: int32
}
with
    static member ConstructorId: uint32 = 1941660731u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetPollResults) : unit =
        writer.WriteConstructorId(1941660731u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.msgId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetPollResults =
        let peer = InputPeer.Deserialize(reader)
        let msgId = reader.ReadInt32()
        {
            peer = peer
            msgId = msgId
        }

    static member Deserialize(body: byte[]) : MessagesGetPollResults =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetPollResults.DeserializeFields(reader)

type MessagesEditChatAbout = {
    peer: InputPeer
    about: string
}
with
    static member ConstructorId: uint32 = 3740665751u

    static member Serialize(writer: TlWriteBuffer, value: MessagesEditChatAbout) : unit =
        writer.WriteConstructorId(3740665751u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteString(value.about)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesEditChatAbout =
        let peer = InputPeer.Deserialize(reader)
        let about = reader.ReadString()
        {
            peer = peer
            about = about
        }

    static member Deserialize(body: byte[]) : MessagesEditChatAbout =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesEditChatAbout.DeserializeFields(reader)

type MessagesEditChatDefaultBannedRights = {
    peer: InputPeer
    bannedRights: ChatBannedRights
}
with
    static member ConstructorId: uint32 = 2777049921u

    static member Serialize(writer: TlWriteBuffer, value: MessagesEditChatDefaultBannedRights) : unit =
        writer.WriteConstructorId(2777049921u)
        InputPeer.Serialize(writer, value.peer)
        ChatBannedRights.Serialize(writer, value.bannedRights)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesEditChatDefaultBannedRights =
        let peer = InputPeer.Deserialize(reader)
        let bannedRights = ChatBannedRights.Deserialize(reader)
        {
            peer = peer
            bannedRights = bannedRights
        }

    static member Deserialize(body: byte[]) : MessagesEditChatDefaultBannedRights =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesEditChatDefaultBannedRights.DeserializeFields(reader)

type MessagesGetSearchCounters = {
    peer: InputPeer
    savedPeerId: InputPeer option
    topMsgId: int32 option
    filters: MessagesFilter array
}
with
    static member ConstructorId: uint32 = 465367808u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetSearchCounters) : unit =
        writer.WriteConstructorId(465367808u)
        let mutable flags = 0
        if value.savedPeerId.IsSome then flags <- flags ||| (1 <<< 2)
        if value.topMsgId.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.savedPeerId with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        match value.topMsgId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        writer.WriteVector(value.filters, fun w item -> let writer = w in MessagesFilter.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetSearchCounters =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let savedPeerId = if flags &&& (1 <<< 2) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let topMsgId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let filters = reader.ReadVector(fun r -> let reader = r in MessagesFilter.Deserialize(reader))
        {
            peer = peer
            savedPeerId = savedPeerId
            topMsgId = topMsgId
            filters = filters
        }

    static member Deserialize(body: byte[]) : MessagesGetSearchCounters =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetSearchCounters.DeserializeFields(reader)

type MessagesGetScheduledHistory = {
    peer: InputPeer
    hash: int64
}
with
    static member ConstructorId: uint32 = 4111889931u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetScheduledHistory) : unit =
        writer.WriteConstructorId(4111889931u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetScheduledHistory =
        let peer = InputPeer.Deserialize(reader)
        let hash = reader.ReadInt64()
        {
            peer = peer
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesGetScheduledHistory =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetScheduledHistory.DeserializeFields(reader)

type MessagesGetScheduledMessages = {
    peer: InputPeer
    id: int32 array
}
with
    static member ConstructorId: uint32 = 3183150180u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetScheduledMessages) : unit =
        writer.WriteConstructorId(3183150180u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetScheduledMessages =
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            peer = peer
            id = id
        }

    static member Deserialize(body: byte[]) : MessagesGetScheduledMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetScheduledMessages.DeserializeFields(reader)

type MessagesSendScheduledMessages = {
    peer: InputPeer
    id: int32 array
}
with
    static member ConstructorId: uint32 = 3174597898u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendScheduledMessages) : unit =
        writer.WriteConstructorId(3174597898u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendScheduledMessages =
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            peer = peer
            id = id
        }

    static member Deserialize(body: byte[]) : MessagesSendScheduledMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendScheduledMessages.DeserializeFields(reader)

type MessagesDeleteScheduledMessages = {
    peer: InputPeer
    id: int32 array
}
with
    static member ConstructorId: uint32 = 1504586518u

    static member Serialize(writer: TlWriteBuffer, value: MessagesDeleteScheduledMessages) : unit =
        writer.WriteConstructorId(1504586518u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesDeleteScheduledMessages =
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            peer = peer
            id = id
        }

    static member Deserialize(body: byte[]) : MessagesDeleteScheduledMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesDeleteScheduledMessages.DeserializeFields(reader)

type MessagesGetPollVotes = {
    peer: InputPeer
    id: int32
    option: byte[] option
    offset: string option
    limit: int32
}
with
    static member ConstructorId: uint32 = 3094231054u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetPollVotes) : unit =
        writer.WriteConstructorId(3094231054u)
        let mutable flags = 0
        if value.option.IsSome then flags <- flags ||| (1 <<< 0)
        if value.offset.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.id)
        match value.option with
        | Some v ->
            writer.WriteBytes(v)
        | None -> ()
        match value.offset with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetPollVotes =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadInt32()
        let option = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadBytes()) else None
        let offset = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
        let limit = reader.ReadInt32()
        {
            peer = peer
            id = id
            option = option
            offset = offset
            limit = limit
        }

    static member Deserialize(body: byte[]) : MessagesGetPollVotes =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetPollVotes.DeserializeFields(reader)

type MessagesGetDialogFilters = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 4023684233u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetDialogFilters) : unit =
        writer.WriteConstructorId(4023684233u)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetDialogFilters =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : MessagesGetDialogFilters =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetDialogFilters.DeserializeFields(reader)

type MessagesUpdateDialogFilter = {
    id: int32
    filter: DialogFilter option
}
with
    static member ConstructorId: uint32 = 450142282u

    static member Serialize(writer: TlWriteBuffer, value: MessagesUpdateDialogFilter) : unit =
        writer.WriteConstructorId(450142282u)
        let mutable flags = 0
        if value.filter.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.id)
        match value.filter with
        | Some v ->
            DialogFilter.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesUpdateDialogFilter =
        let flags = reader.ReadInt32()
        let id = reader.ReadInt32()
        let filter = if flags &&& (1 <<< 0) <> 0 then Some(DialogFilter.Deserialize(reader)) else None
        {
            id = id
            filter = filter
        }

    static member Deserialize(body: byte[]) : MessagesUpdateDialogFilter =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesUpdateDialogFilter.DeserializeFields(reader)

type MessagesUpdateDialogFiltersOrder = {
    order: int32 array
}
with
    static member ConstructorId: uint32 = 3311649252u

    static member Serialize(writer: TlWriteBuffer, value: MessagesUpdateDialogFiltersOrder) : unit =
        writer.WriteConstructorId(3311649252u)
        writer.WriteVector(value.order, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesUpdateDialogFiltersOrder =
        let order = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            order = order
        }

    static member Deserialize(body: byte[]) : MessagesUpdateDialogFiltersOrder =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesUpdateDialogFiltersOrder.DeserializeFields(reader)

type MessagesGetReplies = {
    peer: InputPeer
    msgId: int32
    offsetId: int32
    offsetDate: int32
    addOffset: int32
    limit: int32
    maxId: int32
    minId: int32
    hash: int64
}
with
    static member ConstructorId: uint32 = 584962828u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetReplies) : unit =
        writer.WriteConstructorId(584962828u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.msgId)
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.offsetDate)
        writer.WriteInt32(value.addOffset)
        writer.WriteInt32(value.limit)
        writer.WriteInt32(value.maxId)
        writer.WriteInt32(value.minId)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetReplies =
        let peer = InputPeer.Deserialize(reader)
        let msgId = reader.ReadInt32()
        let offsetId = reader.ReadInt32()
        let offsetDate = reader.ReadInt32()
        let addOffset = reader.ReadInt32()
        let limit = reader.ReadInt32()
        let maxId = reader.ReadInt32()
        let minId = reader.ReadInt32()
        let hash = reader.ReadInt64()
        {
            peer = peer
            msgId = msgId
            offsetId = offsetId
            offsetDate = offsetDate
            addOffset = addOffset
            limit = limit
            maxId = maxId
            minId = minId
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesGetReplies =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetReplies.DeserializeFields(reader)

type MessagesGetDiscussionMessage = {
    peer: InputPeer
    msgId: int32
}
with
    static member ConstructorId: uint32 = 1147761405u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetDiscussionMessage) : unit =
        writer.WriteConstructorId(1147761405u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.msgId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetDiscussionMessage =
        let peer = InputPeer.Deserialize(reader)
        let msgId = reader.ReadInt32()
        {
            peer = peer
            msgId = msgId
        }

    static member Deserialize(body: byte[]) : MessagesGetDiscussionMessage =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetDiscussionMessage.DeserializeFields(reader)

type MessagesReadDiscussion = {
    peer: InputPeer
    msgId: int32
    readMaxId: int32
}
with
    static member ConstructorId: uint32 = 4147227124u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReadDiscussion) : unit =
        writer.WriteConstructorId(4147227124u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.msgId)
        writer.WriteInt32(value.readMaxId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReadDiscussion =
        let peer = InputPeer.Deserialize(reader)
        let msgId = reader.ReadInt32()
        let readMaxId = reader.ReadInt32()
        {
            peer = peer
            msgId = msgId
            readMaxId = readMaxId
        }

    static member Deserialize(body: byte[]) : MessagesReadDiscussion =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReadDiscussion.DeserializeFields(reader)

type MessagesUnpinAllMessages = {
    peer: InputPeer
    topMsgId: int32 option
    savedPeerId: InputPeer option
}
with
    static member ConstructorId: uint32 = 103667527u

    static member Serialize(writer: TlWriteBuffer, value: MessagesUnpinAllMessages) : unit =
        writer.WriteConstructorId(103667527u)
        let mutable flags = 0
        if value.topMsgId.IsSome then flags <- flags ||| (1 <<< 0)
        if value.savedPeerId.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.topMsgId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.savedPeerId with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesUnpinAllMessages =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let topMsgId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let savedPeerId = if flags &&& (1 <<< 1) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        {
            peer = peer
            topMsgId = topMsgId
            savedPeerId = savedPeerId
        }

    static member Deserialize(body: byte[]) : MessagesUnpinAllMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesUnpinAllMessages.DeserializeFields(reader)

type MessagesDeleteChat = {
    chatId: int64
}
with
    static member ConstructorId: uint32 = 1540419152u

    static member Serialize(writer: TlWriteBuffer, value: MessagesDeleteChat) : unit =
        writer.WriteConstructorId(1540419152u)
        writer.WriteInt64(value.chatId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesDeleteChat =
        let chatId = reader.ReadInt64()
        {
            chatId = chatId
        }

    static member Deserialize(body: byte[]) : MessagesDeleteChat =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesDeleteChat.DeserializeFields(reader)

type MessagesGetExportedChatInvites = {
    revoked: bool
    peer: InputPeer
    adminId: InputUser
    offsetDate: int32 option
    offsetLink: string option
    limit: int32
}
with
    static member ConstructorId: uint32 = 2729812982u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetExportedChatInvites) : unit =
        writer.WriteConstructorId(2729812982u)
        let mutable flags = 0
        if value.revoked then flags <- flags ||| (1 <<< 3)
        if value.offsetDate.IsSome then flags <- flags ||| (1 <<< 2)
        if value.offsetLink.IsSome then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        InputUser.Serialize(writer, value.adminId)
        match value.offsetDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.offsetLink with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetExportedChatInvites =
        let flags = reader.ReadInt32()
        let revoked = flags &&& (1 <<< 3) <> 0
        let peer = InputPeer.Deserialize(reader)
        let adminId = InputUser.Deserialize(reader)
        let offsetDate = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadInt32()) else None
        let offsetLink = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadString()) else None
        let limit = reader.ReadInt32()
        {
            revoked = revoked
            peer = peer
            adminId = adminId
            offsetDate = offsetDate
            offsetLink = offsetLink
            limit = limit
        }

    static member Deserialize(body: byte[]) : MessagesGetExportedChatInvites =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetExportedChatInvites.DeserializeFields(reader)

type MessagesEditExportedChatInvite = {
    revoked: bool
    peer: InputPeer
    link: string
    expireDate: int32 option
    usageLimit: int32 option
    requestNeeded: bool option
    title: string option
}
with
    static member ConstructorId: uint32 = 3184144245u

    static member Serialize(writer: TlWriteBuffer, value: MessagesEditExportedChatInvite) : unit =
        writer.WriteConstructorId(3184144245u)
        let mutable flags = 0
        if value.revoked then flags <- flags ||| (1 <<< 2)
        if value.expireDate.IsSome then flags <- flags ||| (1 <<< 0)
        if value.usageLimit.IsSome then flags <- flags ||| (1 <<< 1)
        if value.requestNeeded.IsSome then flags <- flags ||| (1 <<< 3)
        if value.title.IsSome then flags <- flags ||| (1 <<< 4)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteString(value.link)
        match value.expireDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.usageLimit with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.requestNeeded with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.title with
        | Some v ->
            writer.WriteString(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesEditExportedChatInvite =
        let flags = reader.ReadInt32()
        let revoked = flags &&& (1 <<< 2) <> 0
        let peer = InputPeer.Deserialize(reader)
        let link = reader.ReadString()
        let expireDate = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let usageLimit = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
        let requestNeeded = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadBool()) else None
        let title = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadString()) else None
        {
            revoked = revoked
            peer = peer
            link = link
            expireDate = expireDate
            usageLimit = usageLimit
            requestNeeded = requestNeeded
            title = title
        }

    static member Deserialize(body: byte[]) : MessagesEditExportedChatInvite =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesEditExportedChatInvite.DeserializeFields(reader)

type MessagesGetAdminsWithInvites = {
    peer: InputPeer
}
with
    static member ConstructorId: uint32 = 958457583u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetAdminsWithInvites) : unit =
        writer.WriteConstructorId(958457583u)
        InputPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetAdminsWithInvites =
        let peer = InputPeer.Deserialize(reader)
        {
            peer = peer
        }

    static member Deserialize(body: byte[]) : MessagesGetAdminsWithInvites =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetAdminsWithInvites.DeserializeFields(reader)

type MessagesSetHistoryTTL = {
    peer: InputPeer
    period: int32
}
with
    static member ConstructorId: uint32 = 3087949796u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSetHistoryTTL) : unit =
        writer.WriteConstructorId(3087949796u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.period)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSetHistoryTTL =
        let peer = InputPeer.Deserialize(reader)
        let period = reader.ReadInt32()
        {
            peer = peer
            period = period
        }

    static member Deserialize(body: byte[]) : MessagesSetHistoryTTL =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSetHistoryTTL.DeserializeFields(reader)

type MessagesGetMessageReadParticipants = {
    peer: InputPeer
    msgId: int32
}
with
    static member ConstructorId: uint32 = 834782287u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetMessageReadParticipants) : unit =
        writer.WriteConstructorId(834782287u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.msgId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetMessageReadParticipants =
        let peer = InputPeer.Deserialize(reader)
        let msgId = reader.ReadInt32()
        {
            peer = peer
            msgId = msgId
        }

    static member Deserialize(body: byte[]) : MessagesGetMessageReadParticipants =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetMessageReadParticipants.DeserializeFields(reader)

type MessagesGetSearchResultsCalendar = {
    peer: InputPeer
    savedPeerId: InputPeer option
    filter: MessagesFilter
    offsetId: int32
    offsetDate: int32
}
with
    static member ConstructorId: uint32 = 1789130429u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetSearchResultsCalendar) : unit =
        writer.WriteConstructorId(1789130429u)
        let mutable flags = 0
        if value.savedPeerId.IsSome then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.savedPeerId with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        MessagesFilter.Serialize(writer, value.filter)
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.offsetDate)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetSearchResultsCalendar =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let savedPeerId = if flags &&& (1 <<< 2) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let filter = MessagesFilter.Deserialize(reader)
        let offsetId = reader.ReadInt32()
        let offsetDate = reader.ReadInt32()
        {
            peer = peer
            savedPeerId = savedPeerId
            filter = filter
            offsetId = offsetId
            offsetDate = offsetDate
        }

    static member Deserialize(body: byte[]) : MessagesGetSearchResultsCalendar =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetSearchResultsCalendar.DeserializeFields(reader)

type MessagesHideChatJoinRequest = {
    approved: bool
    peer: InputPeer
    userId: InputUser
}
with
    static member ConstructorId: uint32 = 2145904661u

    static member Serialize(writer: TlWriteBuffer, value: MessagesHideChatJoinRequest) : unit =
        writer.WriteConstructorId(2145904661u)
        let mutable flags = 0
        if value.approved then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        InputUser.Serialize(writer, value.userId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesHideChatJoinRequest =
        let flags = reader.ReadInt32()
        let approved = flags &&& (1 <<< 0) <> 0
        let peer = InputPeer.Deserialize(reader)
        let userId = InputUser.Deserialize(reader)
        {
            approved = approved
            peer = peer
            userId = userId
        }

    static member Deserialize(body: byte[]) : MessagesHideChatJoinRequest =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesHideChatJoinRequest.DeserializeFields(reader)

type MessagesToggleNoForwards = {
    peer: InputPeer
    enabled: bool
}
with
    static member ConstructorId: uint32 = 2971578274u

    static member Serialize(writer: TlWriteBuffer, value: MessagesToggleNoForwards) : unit =
        writer.WriteConstructorId(2971578274u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteBool(value.enabled)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesToggleNoForwards =
        let peer = InputPeer.Deserialize(reader)
        let enabled = reader.ReadBool()
        {
            peer = peer
            enabled = enabled
        }

    static member Deserialize(body: byte[]) : MessagesToggleNoForwards =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesToggleNoForwards.DeserializeFields(reader)

type MessagesSaveDefaultSendAs = {
    peer: InputPeer
    sendAs: InputPeer
}
with
    static member ConstructorId: uint32 = 3439189910u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSaveDefaultSendAs) : unit =
        writer.WriteConstructorId(3439189910u)
        InputPeer.Serialize(writer, value.peer)
        InputPeer.Serialize(writer, value.sendAs)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSaveDefaultSendAs =
        let peer = InputPeer.Deserialize(reader)
        let sendAs = InputPeer.Deserialize(reader)
        {
            peer = peer
            sendAs = sendAs
        }

    static member Deserialize(body: byte[]) : MessagesSaveDefaultSendAs =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSaveDefaultSendAs.DeserializeFields(reader)

type MessagesSendReaction = {
    big: bool
    addToRecent: bool
    peer: InputPeer
    msgId: int32
    reaction: Reaction array option
}
with
    static member ConstructorId: uint32 = 3540875476u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSendReaction) : unit =
        writer.WriteConstructorId(3540875476u)
        let mutable flags = 0
        if value.big then flags <- flags ||| (1 <<< 1)
        if value.addToRecent then flags <- flags ||| (1 <<< 2)
        if value.reaction.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.msgId)
        match value.reaction with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in Reaction.Serialize(writer, item))
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSendReaction =
        let flags = reader.ReadInt32()
        let big = flags &&& (1 <<< 1) <> 0
        let addToRecent = flags &&& (1 <<< 2) <> 0
        let peer = InputPeer.Deserialize(reader)
        let msgId = reader.ReadInt32()
        let reaction = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in Reaction.Deserialize(reader))) else None
        {
            big = big
            addToRecent = addToRecent
            peer = peer
            msgId = msgId
            reaction = reaction
        }

    static member Deserialize(body: byte[]) : MessagesSendReaction =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSendReaction.DeserializeFields(reader)

type MessagesGetMessagesReactions = {
    peer: InputPeer
    id: int32 array
}
with
    static member ConstructorId: uint32 = 2344259814u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetMessagesReactions) : unit =
        writer.WriteConstructorId(2344259814u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetMessagesReactions =
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            peer = peer
            id = id
        }

    static member Deserialize(body: byte[]) : MessagesGetMessagesReactions =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetMessagesReactions.DeserializeFields(reader)

type MessagesGetMessageReactionsList = {
    peer: InputPeer
    id: int32
    reaction: Reaction option
    offset: string option
    limit: int32
}
with
    static member ConstructorId: uint32 = 1176190792u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetMessageReactionsList) : unit =
        writer.WriteConstructorId(1176190792u)
        let mutable flags = 0
        if value.reaction.IsSome then flags <- flags ||| (1 <<< 0)
        if value.offset.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.id)
        match value.reaction with
        | Some v ->
            Reaction.Serialize(writer, v)
        | None -> ()
        match value.offset with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetMessageReactionsList =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let id = reader.ReadInt32()
        let reaction = if flags &&& (1 <<< 0) <> 0 then Some(Reaction.Deserialize(reader)) else None
        let offset = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
        let limit = reader.ReadInt32()
        {
            peer = peer
            id = id
            reaction = reaction
            offset = offset
            limit = limit
        }

    static member Deserialize(body: byte[]) : MessagesGetMessageReactionsList =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetMessageReactionsList.DeserializeFields(reader)

type MessagesSetChatAvailableReactions = {
    peer: InputPeer
    availableReactions: ChatReactions
    reactionsLimit: int32 option
    paidEnabled: bool option
}
with
    static member ConstructorId: uint32 = 2253071745u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSetChatAvailableReactions) : unit =
        writer.WriteConstructorId(2253071745u)
        let mutable flags = 0
        if value.reactionsLimit.IsSome then flags <- flags ||| (1 <<< 0)
        if value.paidEnabled.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        ChatReactions.Serialize(writer, value.availableReactions)
        match value.reactionsLimit with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.paidEnabled with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSetChatAvailableReactions =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let availableReactions = ChatReactions.Deserialize(reader)
        let reactionsLimit = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let paidEnabled = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadBool()) else None
        {
            peer = peer
            availableReactions = availableReactions
            reactionsLimit = reactionsLimit
            paidEnabled = paidEnabled
        }

    static member Deserialize(body: byte[]) : MessagesSetChatAvailableReactions =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSetChatAvailableReactions.DeserializeFields(reader)

type MessagesGetAvailableReactions = {
    hash: int32
}
with
    static member ConstructorId: uint32 = 417243308u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetAvailableReactions) : unit =
        writer.WriteConstructorId(417243308u)
        writer.WriteInt32(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetAvailableReactions =
        let hash = reader.ReadInt32()
        {
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesGetAvailableReactions =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetAvailableReactions.DeserializeFields(reader)

type MessagesSetDefaultReaction = {
    reaction: Reaction
}
with
    static member ConstructorId: uint32 = 1330094102u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSetDefaultReaction) : unit =
        writer.WriteConstructorId(1330094102u)
        Reaction.Serialize(writer, value.reaction)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSetDefaultReaction =
        let reaction = Reaction.Deserialize(reader)
        {
            reaction = reaction
        }

    static member Deserialize(body: byte[]) : MessagesSetDefaultReaction =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSetDefaultReaction.DeserializeFields(reader)

type MessagesTranslateText = {
    peer: InputPeer option
    id: int32 array option
    text: TextWithEntities array option
    toLang: string
}
with
    static member ConstructorId: uint32 = 1662529584u

    static member Serialize(writer: TlWriteBuffer, value: MessagesTranslateText) : unit =
        writer.WriteConstructorId(1662529584u)
        let mutable flags = 0
        if value.peer.IsSome then flags <- flags ||| (1 <<< 0)
        if value.id.IsSome then flags <- flags ||| (1 <<< 0)
        if value.text.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        match value.peer with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        match value.id with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in writer.WriteInt32(item))
        | None -> ()
        match value.text with
        | Some v ->
            writer.WriteVector(v, fun w item -> let writer = w in TextWithEntities.Serialize(writer, item))
        | None -> ()
        writer.WriteString(value.toLang)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesTranslateText =
        let flags = reader.ReadInt32()
        let peer = if flags &&& (1 <<< 0) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let id = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())) else None
        let text = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadVector(fun r -> let reader = r in TextWithEntities.Deserialize(reader))) else None
        let toLang = reader.ReadString()
        {
            peer = peer
            id = id
            text = text
            toLang = toLang
        }

    static member Deserialize(body: byte[]) : MessagesTranslateText =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesTranslateText.DeserializeFields(reader)

type MessagesGetUnreadReactions = {
    peer: InputPeer
    topMsgId: int32 option
    savedPeerId: InputPeer option
    offsetId: int32
    addOffset: int32
    limit: int32
    maxId: int32
    minId: int32
}
with
    static member ConstructorId: uint32 = 3179253932u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetUnreadReactions) : unit =
        writer.WriteConstructorId(3179253932u)
        let mutable flags = 0
        if value.topMsgId.IsSome then flags <- flags ||| (1 <<< 0)
        if value.savedPeerId.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.topMsgId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.savedPeerId with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.addOffset)
        writer.WriteInt32(value.limit)
        writer.WriteInt32(value.maxId)
        writer.WriteInt32(value.minId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetUnreadReactions =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let topMsgId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let savedPeerId = if flags &&& (1 <<< 1) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let offsetId = reader.ReadInt32()
        let addOffset = reader.ReadInt32()
        let limit = reader.ReadInt32()
        let maxId = reader.ReadInt32()
        let minId = reader.ReadInt32()
        {
            peer = peer
            topMsgId = topMsgId
            savedPeerId = savedPeerId
            offsetId = offsetId
            addOffset = addOffset
            limit = limit
            maxId = maxId
            minId = minId
        }

    static member Deserialize(body: byte[]) : MessagesGetUnreadReactions =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetUnreadReactions.DeserializeFields(reader)

type MessagesReadReactions = {
    peer: InputPeer
    topMsgId: int32 option
    savedPeerId: InputPeer option
}
with
    static member ConstructorId: uint32 = 2663665555u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReadReactions) : unit =
        writer.WriteConstructorId(2663665555u)
        let mutable flags = 0
        if value.topMsgId.IsSome then flags <- flags ||| (1 <<< 0)
        if value.savedPeerId.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        match value.topMsgId with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.savedPeerId with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReadReactions =
        let flags = reader.ReadInt32()
        let peer = InputPeer.Deserialize(reader)
        let topMsgId = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let savedPeerId = if flags &&& (1 <<< 1) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        {
            peer = peer
            topMsgId = topMsgId
            savedPeerId = savedPeerId
        }

    static member Deserialize(body: byte[]) : MessagesReadReactions =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReadReactions.DeserializeFields(reader)

type MessagesGetTopReactions = {
    limit: int32
    hash: int64
}
with
    static member ConstructorId: uint32 = 3145803194u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetTopReactions) : unit =
        writer.WriteConstructorId(3145803194u)
        writer.WriteInt32(value.limit)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetTopReactions =
        let limit = reader.ReadInt32()
        let hash = reader.ReadInt64()
        {
            limit = limit
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesGetTopReactions =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetTopReactions.DeserializeFields(reader)

type MessagesGetRecentReactions = {
    limit: int32
    hash: int64
}
with
    static member ConstructorId: uint32 = 960896434u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetRecentReactions) : unit =
        writer.WriteConstructorId(960896434u)
        writer.WriteInt32(value.limit)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetRecentReactions =
        let limit = reader.ReadInt32()
        let hash = reader.ReadInt64()
        {
            limit = limit
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesGetRecentReactions =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetRecentReactions.DeserializeFields(reader)

type MessagesSetDefaultHistoryTTL = {
    period: int32
}
with
    static member ConstructorId: uint32 = 2662667333u

    static member Serialize(writer: TlWriteBuffer, value: MessagesSetDefaultHistoryTTL) : unit =
        writer.WriteConstructorId(2662667333u)
        writer.WriteInt32(value.period)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesSetDefaultHistoryTTL =
        let period = reader.ReadInt32()
        {
            period = period
        }

    static member Deserialize(body: byte[]) : MessagesSetDefaultHistoryTTL =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesSetDefaultHistoryTTL.DeserializeFields(reader)

type MessagesGetDefaultHistoryTTL = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 1703637384u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetDefaultHistoryTTL) : unit =
        writer.WriteConstructorId(1703637384u)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetDefaultHistoryTTL =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : MessagesGetDefaultHistoryTTL =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetDefaultHistoryTTL.DeserializeFields(reader)

type MessagesTogglePeerTranslations = {
    disabled: bool
    peer: InputPeer
}
with
    static member ConstructorId: uint32 = 3833378169u

    static member Serialize(writer: TlWriteBuffer, value: MessagesTogglePeerTranslations) : unit =
        writer.WriteConstructorId(3833378169u)
        let mutable flags = 0
        if value.disabled then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesTogglePeerTranslations =
        let flags = reader.ReadInt32()
        let disabled = flags &&& (1 <<< 0) <> 0
        let peer = InputPeer.Deserialize(reader)
        {
            disabled = disabled
            peer = peer
        }

    static member Deserialize(body: byte[]) : MessagesTogglePeerTranslations =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesTogglePeerTranslations.DeserializeFields(reader)

type MessagesGetSavedHistory = {
    parentPeer: InputPeer option
    peer: InputPeer
    offsetId: int32
    offsetDate: int32
    addOffset: int32
    limit: int32
    maxId: int32
    minId: int32
    hash: int64
}
with
    static member ConstructorId: uint32 = 2576003081u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetSavedHistory) : unit =
        writer.WriteConstructorId(2576003081u)
        let mutable flags = 0
        if value.parentPeer.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        match value.parentPeer with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.offsetDate)
        writer.WriteInt32(value.addOffset)
        writer.WriteInt32(value.limit)
        writer.WriteInt32(value.maxId)
        writer.WriteInt32(value.minId)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetSavedHistory =
        let flags = reader.ReadInt32()
        let parentPeer = if flags &&& (1 <<< 0) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        let peer = InputPeer.Deserialize(reader)
        let offsetId = reader.ReadInt32()
        let offsetDate = reader.ReadInt32()
        let addOffset = reader.ReadInt32()
        let limit = reader.ReadInt32()
        let maxId = reader.ReadInt32()
        let minId = reader.ReadInt32()
        let hash = reader.ReadInt64()
        {
            parentPeer = parentPeer
            peer = peer
            offsetId = offsetId
            offsetDate = offsetDate
            addOffset = addOffset
            limit = limit
            maxId = maxId
            minId = minId
            hash = hash
        }

    static member Deserialize(body: byte[]) : MessagesGetSavedHistory =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetSavedHistory.DeserializeFields(reader)

type MessagesToggleSavedDialogPin = {
    pinned: bool
    peer: InputDialogPeer
}
with
    static member ConstructorId: uint32 = 2894183390u

    static member Serialize(writer: TlWriteBuffer, value: MessagesToggleSavedDialogPin) : unit =
        writer.WriteConstructorId(2894183390u)
        let mutable flags = 0
        if value.pinned then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputDialogPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesToggleSavedDialogPin =
        let flags = reader.ReadInt32()
        let pinned = flags &&& (1 <<< 0) <> 0
        let peer = InputDialogPeer.Deserialize(reader)
        {
            pinned = pinned
            peer = peer
        }

    static member Deserialize(body: byte[]) : MessagesToggleSavedDialogPin =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesToggleSavedDialogPin.DeserializeFields(reader)

type MessagesReorderPinnedSavedDialogs = {
    force: bool
    order: InputDialogPeer array
}
with
    static member ConstructorId: uint32 = 2339464583u

    static member Serialize(writer: TlWriteBuffer, value: MessagesReorderPinnedSavedDialogs) : unit =
        writer.WriteConstructorId(2339464583u)
        let mutable flags = 0
        if value.force then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        writer.WriteVector(value.order, fun w item -> let writer = w in InputDialogPeer.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : MessagesReorderPinnedSavedDialogs =
        let flags = reader.ReadInt32()
        let force = flags &&& (1 <<< 0) <> 0
        let order = reader.ReadVector(fun r -> let reader = r in InputDialogPeer.Deserialize(reader))
        {
            force = force
            order = order
        }

    static member Deserialize(body: byte[]) : MessagesReorderPinnedSavedDialogs =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesReorderPinnedSavedDialogs.DeserializeFields(reader)

type MessagesGetOutboxReadDate = {
    peer: InputPeer
    msgId: int32
}
with
    static member ConstructorId: uint32 = 2353790557u

    static member Serialize(writer: TlWriteBuffer, value: MessagesGetOutboxReadDate) : unit =
        writer.WriteConstructorId(2353790557u)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.msgId)

    static member DeserializeFields(reader: TlReadBuffer) : MessagesGetOutboxReadDate =
        let peer = InputPeer.Deserialize(reader)
        let msgId = reader.ReadInt32()
        {
            peer = peer
            msgId = msgId
        }

    static member Deserialize(body: byte[]) : MessagesGetOutboxReadDate =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        MessagesGetOutboxReadDate.DeserializeFields(reader)

type UpdatesGetState = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 3990128682u

    static member Serialize(writer: TlWriteBuffer, value: UpdatesGetState) : unit =
        writer.WriteConstructorId(3990128682u)

    static member DeserializeFields(reader: TlReadBuffer) : UpdatesGetState =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : UpdatesGetState =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UpdatesGetState.DeserializeFields(reader)

type UpdatesGetDifference = {
    pts: int32
    ptsLimit: int32 option
    ptsTotalLimit: int32 option
    date: int32
    qts: int32
    qtsLimit: int32 option
}
with
    static member ConstructorId: uint32 = 432207715u

    static member Serialize(writer: TlWriteBuffer, value: UpdatesGetDifference) : unit =
        writer.WriteConstructorId(432207715u)
        let mutable flags = 0
        if value.ptsLimit.IsSome then flags <- flags ||| (1 <<< 1)
        if value.ptsTotalLimit.IsSome then flags <- flags ||| (1 <<< 0)
        if value.qtsLimit.IsSome then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)
        writer.WriteInt32(value.pts)
        match value.ptsLimit with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.ptsTotalLimit with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        writer.WriteInt32(value.date)
        writer.WriteInt32(value.qts)
        match value.qtsLimit with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : UpdatesGetDifference =
        let flags = reader.ReadInt32()
        let pts = reader.ReadInt32()
        let ptsLimit = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
        let ptsTotalLimit = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let date = reader.ReadInt32()
        let qts = reader.ReadInt32()
        let qtsLimit = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadInt32()) else None
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

type UpdatesGetChannelDifference = {
    force: bool
    channel: InputChannel
    filter: ChannelMessagesFilter
    pts: int32
    limit: int32
}
with
    static member ConstructorId: uint32 = 51854712u

    static member Serialize(writer: TlWriteBuffer, value: UpdatesGetChannelDifference) : unit =
        writer.WriteConstructorId(51854712u)
        let mutable flags = 0
        if value.force then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputChannel.Serialize(writer, value.channel)
        ChannelMessagesFilter.Serialize(writer, value.filter)
        writer.WriteInt32(value.pts)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : UpdatesGetChannelDifference =
        let flags = reader.ReadInt32()
        let force = flags &&& (1 <<< 0) <> 0
        let channel = InputChannel.Deserialize(reader)
        let filter = ChannelMessagesFilter.Deserialize(reader)
        let pts = reader.ReadInt32()
        let limit = reader.ReadInt32()
        {
            force = force
            channel = channel
            filter = filter
            pts = pts
            limit = limit
        }

    static member Deserialize(body: byte[]) : UpdatesGetChannelDifference =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        UpdatesGetChannelDifference.DeserializeFields(reader)

type PhotosUpdateProfilePhoto = {
    fallback: bool
    bot: InputUser option
    id: InputPhoto
}
with
    static member ConstructorId: uint32 = 166207545u

    static member Serialize(writer: TlWriteBuffer, value: PhotosUpdateProfilePhoto) : unit =
        writer.WriteConstructorId(166207545u)
        let mutable flags = 0
        if value.fallback then flags <- flags ||| (1 <<< 0)
        if value.bot.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        match value.bot with
        | Some v ->
            InputUser.Serialize(writer, v)
        | None -> ()
        InputPhoto.Serialize(writer, value.id)

    static member DeserializeFields(reader: TlReadBuffer) : PhotosUpdateProfilePhoto =
        let flags = reader.ReadInt32()
        let fallback = flags &&& (1 <<< 0) <> 0
        let bot = if flags &&& (1 <<< 1) <> 0 then Some(InputUser.Deserialize(reader)) else None
        let id = InputPhoto.Deserialize(reader)
        {
            fallback = fallback
            bot = bot
            id = id
        }

    static member Deserialize(body: byte[]) : PhotosUpdateProfilePhoto =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhotosUpdateProfilePhoto.DeserializeFields(reader)

type PhotosUploadProfilePhoto = {
    fallback: bool
    bot: InputUser option
    file: InputFile option
    video: InputFile option
    videoStartTs: double option
    videoEmojiMarkup: VideoSize option
}
with
    static member ConstructorId: uint32 = 59286453u

    static member Serialize(writer: TlWriteBuffer, value: PhotosUploadProfilePhoto) : unit =
        writer.WriteConstructorId(59286453u)
        let mutable flags = 0
        if value.fallback then flags <- flags ||| (1 <<< 3)
        if value.bot.IsSome then flags <- flags ||| (1 <<< 5)
        if value.file.IsSome then flags <- flags ||| (1 <<< 0)
        if value.video.IsSome then flags <- flags ||| (1 <<< 1)
        if value.videoStartTs.IsSome then flags <- flags ||| (1 <<< 2)
        if value.videoEmojiMarkup.IsSome then flags <- flags ||| (1 <<< 4)
        writer.WriteInt32(flags)
        match value.bot with
        | Some v ->
            InputUser.Serialize(writer, v)
        | None -> ()
        match value.file with
        | Some v ->
            InputFile.Serialize(writer, v)
        | None -> ()
        match value.video with
        | Some v ->
            InputFile.Serialize(writer, v)
        | None -> ()
        match value.videoStartTs with
        | Some v ->
            writer.WriteDouble(v)
        | None -> ()
        match value.videoEmojiMarkup with
        | Some v ->
            VideoSize.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : PhotosUploadProfilePhoto =
        let flags = reader.ReadInt32()
        let fallback = flags &&& (1 <<< 3) <> 0
        let bot = if flags &&& (1 <<< 5) <> 0 then Some(InputUser.Deserialize(reader)) else None
        let file = if flags &&& (1 <<< 0) <> 0 then Some(InputFile.Deserialize(reader)) else None
        let video = if flags &&& (1 <<< 1) <> 0 then Some(InputFile.Deserialize(reader)) else None
        let videoStartTs = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadDouble()) else None
        let videoEmojiMarkup = if flags &&& (1 <<< 4) <> 0 then Some(VideoSize.Deserialize(reader)) else None
        {
            fallback = fallback
            bot = bot
            file = file
            video = video
            videoStartTs = videoStartTs
            videoEmojiMarkup = videoEmojiMarkup
        }

    static member Deserialize(body: byte[]) : PhotosUploadProfilePhoto =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhotosUploadProfilePhoto.DeserializeFields(reader)

type PhotosDeletePhotos = {
    id: InputPhoto array
}
with
    static member ConstructorId: uint32 = 2278522671u

    static member Serialize(writer: TlWriteBuffer, value: PhotosDeletePhotos) : unit =
        writer.WriteConstructorId(2278522671u)
        writer.WriteVector(value.id, fun w item -> let writer = w in InputPhoto.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : PhotosDeletePhotos =
        let id = reader.ReadVector(fun r -> let reader = r in InputPhoto.Deserialize(reader))
        {
            id = id
        }

    static member Deserialize(body: byte[]) : PhotosDeletePhotos =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhotosDeletePhotos.DeserializeFields(reader)

type PhotosGetUserPhotos = {
    userId: InputUser
    offset: int32
    maxId: int64
    limit: int32
}
with
    static member ConstructorId: uint32 = 2446144168u

    static member Serialize(writer: TlWriteBuffer, value: PhotosGetUserPhotos) : unit =
        writer.WriteConstructorId(2446144168u)
        InputUser.Serialize(writer, value.userId)
        writer.WriteInt32(value.offset)
        writer.WriteInt64(value.maxId)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : PhotosGetUserPhotos =
        let userId = InputUser.Deserialize(reader)
        let offset = reader.ReadInt32()
        let maxId = reader.ReadInt64()
        let limit = reader.ReadInt32()
        {
            userId = userId
            offset = offset
            maxId = maxId
            limit = limit
        }

    static member Deserialize(body: byte[]) : PhotosGetUserPhotos =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhotosGetUserPhotos.DeserializeFields(reader)

type UploadSaveFilePart = {
    fileId: int64
    filePart: int32
    bytes: byte[]
}
with
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
}
with
    static member ConstructorId: uint32 = 3193124286u

    static member Serialize(writer: TlWriteBuffer, value: UploadGetFile) : unit =
        writer.WriteConstructorId(3193124286u)
        let mutable flags = 0
        if value.precise then flags <- flags ||| (1 <<< 0)
        if value.cdnSupported then flags <- flags ||| (1 <<< 1)
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
}
with
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

type ChannelsReadHistory = {
    channel: InputChannel
    maxId: int32
}
with
    static member ConstructorId: uint32 = 3423619383u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsReadHistory) : unit =
        writer.WriteConstructorId(3423619383u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteInt32(value.maxId)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsReadHistory =
        let channel = InputChannel.Deserialize(reader)
        let maxId = reader.ReadInt32()
        {
            channel = channel
            maxId = maxId
        }

    static member Deserialize(body: byte[]) : ChannelsReadHistory =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsReadHistory.DeserializeFields(reader)

type ChannelsDeleteMessages = {
    channel: InputChannel
    id: int32 array
}
with
    static member ConstructorId: uint32 = 2227305806u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsDeleteMessages) : unit =
        writer.WriteConstructorId(2227305806u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsDeleteMessages =
        let channel = InputChannel.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            channel = channel
            id = id
        }

    static member Deserialize(body: byte[]) : ChannelsDeleteMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsDeleteMessages.DeserializeFields(reader)

type ChannelsGetMessages = {
    channel: InputChannel
    id: InputMessage array
}
with
    static member ConstructorId: uint32 = 2911672867u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetMessages) : unit =
        writer.WriteConstructorId(2911672867u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteVector(value.id, fun w item -> let writer = w in InputMessage.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetMessages =
        let channel = InputChannel.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in InputMessage.Deserialize(reader))
        {
            channel = channel
            id = id
        }

    static member Deserialize(body: byte[]) : ChannelsGetMessages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetMessages.DeserializeFields(reader)

type ChannelsGetParticipants = {
    channel: InputChannel
    filter: ChannelParticipantsFilter
    offset: int32
    limit: int32
    hash: int64
}
with
    static member ConstructorId: uint32 = 2010044880u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetParticipants) : unit =
        writer.WriteConstructorId(2010044880u)
        InputChannel.Serialize(writer, value.channel)
        ChannelParticipantsFilter.Serialize(writer, value.filter)
        writer.WriteInt32(value.offset)
        writer.WriteInt32(value.limit)
        writer.WriteInt64(value.hash)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetParticipants =
        let channel = InputChannel.Deserialize(reader)
        let filter = ChannelParticipantsFilter.Deserialize(reader)
        let offset = reader.ReadInt32()
        let limit = reader.ReadInt32()
        let hash = reader.ReadInt64()
        {
            channel = channel
            filter = filter
            offset = offset
            limit = limit
            hash = hash
        }

    static member Deserialize(body: byte[]) : ChannelsGetParticipants =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetParticipants.DeserializeFields(reader)

type ChannelsGetParticipant = {
    channel: InputChannel
    participant: InputPeer
}
with
    static member ConstructorId: uint32 = 2695589062u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetParticipant) : unit =
        writer.WriteConstructorId(2695589062u)
        InputChannel.Serialize(writer, value.channel)
        InputPeer.Serialize(writer, value.participant)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetParticipant =
        let channel = InputChannel.Deserialize(reader)
        let participant = InputPeer.Deserialize(reader)
        {
            channel = channel
            participant = participant
        }

    static member Deserialize(body: byte[]) : ChannelsGetParticipant =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetParticipant.DeserializeFields(reader)

type ChannelsGetChannels = {
    id: InputChannel array
}
with
    static member ConstructorId: uint32 = 176122811u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetChannels) : unit =
        writer.WriteConstructorId(176122811u)
        writer.WriteVector(value.id, fun w item -> let writer = w in InputChannel.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetChannels =
        let id = reader.ReadVector(fun r -> let reader = r in InputChannel.Deserialize(reader))
        {
            id = id
        }

    static member Deserialize(body: byte[]) : ChannelsGetChannels =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetChannels.DeserializeFields(reader)

type ChannelsGetFullChannel = {
    channel: InputChannel
}
with
    static member ConstructorId: uint32 = 141781513u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetFullChannel) : unit =
        writer.WriteConstructorId(141781513u)
        InputChannel.Serialize(writer, value.channel)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetFullChannel =
        let channel = InputChannel.Deserialize(reader)
        {
            channel = channel
        }

    static member Deserialize(body: byte[]) : ChannelsGetFullChannel =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetFullChannel.DeserializeFields(reader)

type ChannelsCreateChannel = {
    broadcast: bool
    megagroup: bool
    forImport: bool
    forum: bool
    title: string
    about: string
    geoPoint: InputGeoPoint option
    address: string option
    ttlPeriod: int32 option
}
with
    static member ConstructorId: uint32 = 2432722695u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsCreateChannel) : unit =
        writer.WriteConstructorId(2432722695u)
        let mutable flags = 0
        if value.broadcast then flags <- flags ||| (1 <<< 0)
        if value.megagroup then flags <- flags ||| (1 <<< 1)
        if value.forImport then flags <- flags ||| (1 <<< 3)
        if value.forum then flags <- flags ||| (1 <<< 5)
        if value.geoPoint.IsSome then flags <- flags ||| (1 <<< 2)
        if value.address.IsSome then flags <- flags ||| (1 <<< 2)
        if value.ttlPeriod.IsSome then flags <- flags ||| (1 <<< 4)
        writer.WriteInt32(flags)
        writer.WriteString(value.title)
        writer.WriteString(value.about)
        match value.geoPoint with
        | Some v ->
            InputGeoPoint.Serialize(writer, v)
        | None -> ()
        match value.address with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.ttlPeriod with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsCreateChannel =
        let flags = reader.ReadInt32()
        let broadcast = flags &&& (1 <<< 0) <> 0
        let megagroup = flags &&& (1 <<< 1) <> 0
        let forImport = flags &&& (1 <<< 3) <> 0
        let forum = flags &&& (1 <<< 5) <> 0
        let title = reader.ReadString()
        let about = reader.ReadString()
        let geoPoint = if flags &&& (1 <<< 2) <> 0 then Some(InputGeoPoint.Deserialize(reader)) else None
        let address = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadString()) else None
        let ttlPeriod = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadInt32()) else None
        {
            broadcast = broadcast
            megagroup = megagroup
            forImport = forImport
            forum = forum
            title = title
            about = about
            geoPoint = geoPoint
            address = address
            ttlPeriod = ttlPeriod
        }

    static member Deserialize(body: byte[]) : ChannelsCreateChannel =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsCreateChannel.DeserializeFields(reader)

type ChannelsEditAdmin = {
    channel: InputChannel
    userId: InputUser
    adminRights: ChatAdminRights
    rank: string
}
with
    static member ConstructorId: uint32 = 3543959810u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsEditAdmin) : unit =
        writer.WriteConstructorId(3543959810u)
        InputChannel.Serialize(writer, value.channel)
        InputUser.Serialize(writer, value.userId)
        ChatAdminRights.Serialize(writer, value.adminRights)
        writer.WriteString(value.rank)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsEditAdmin =
        let channel = InputChannel.Deserialize(reader)
        let userId = InputUser.Deserialize(reader)
        let adminRights = ChatAdminRights.Deserialize(reader)
        let rank = reader.ReadString()
        {
            channel = channel
            userId = userId
            adminRights = adminRights
            rank = rank
        }

    static member Deserialize(body: byte[]) : ChannelsEditAdmin =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsEditAdmin.DeserializeFields(reader)

type ChannelsEditTitle = {
    channel: InputChannel
    title: string
}
with
    static member ConstructorId: uint32 = 1450044624u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsEditTitle) : unit =
        writer.WriteConstructorId(1450044624u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteString(value.title)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsEditTitle =
        let channel = InputChannel.Deserialize(reader)
        let title = reader.ReadString()
        {
            channel = channel
            title = title
        }

    static member Deserialize(body: byte[]) : ChannelsEditTitle =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsEditTitle.DeserializeFields(reader)

type ChannelsEditPhoto = {
    channel: InputChannel
    photo: InputChatPhoto
}
with
    static member ConstructorId: uint32 = 4046346185u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsEditPhoto) : unit =
        writer.WriteConstructorId(4046346185u)
        InputChannel.Serialize(writer, value.channel)
        InputChatPhoto.Serialize(writer, value.photo)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsEditPhoto =
        let channel = InputChannel.Deserialize(reader)
        let photo = InputChatPhoto.Deserialize(reader)
        {
            channel = channel
            photo = photo
        }

    static member Deserialize(body: byte[]) : ChannelsEditPhoto =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsEditPhoto.DeserializeFields(reader)

type ChannelsCheckUsername = {
    channel: InputChannel
    username: string
}
with
    static member ConstructorId: uint32 = 283557164u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsCheckUsername) : unit =
        writer.WriteConstructorId(283557164u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteString(value.username)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsCheckUsername =
        let channel = InputChannel.Deserialize(reader)
        let username = reader.ReadString()
        {
            channel = channel
            username = username
        }

    static member Deserialize(body: byte[]) : ChannelsCheckUsername =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsCheckUsername.DeserializeFields(reader)

type ChannelsUpdateUsername = {
    channel: InputChannel
    username: string
}
with
    static member ConstructorId: uint32 = 890549214u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsUpdateUsername) : unit =
        writer.WriteConstructorId(890549214u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteString(value.username)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsUpdateUsername =
        let channel = InputChannel.Deserialize(reader)
        let username = reader.ReadString()
        {
            channel = channel
            username = username
        }

    static member Deserialize(body: byte[]) : ChannelsUpdateUsername =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsUpdateUsername.DeserializeFields(reader)

type ChannelsJoinChannel = {
    channel: InputChannel
}
with
    static member ConstructorId: uint32 = 615851205u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsJoinChannel) : unit =
        writer.WriteConstructorId(615851205u)
        InputChannel.Serialize(writer, value.channel)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsJoinChannel =
        let channel = InputChannel.Deserialize(reader)
        {
            channel = channel
        }

    static member Deserialize(body: byte[]) : ChannelsJoinChannel =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsJoinChannel.DeserializeFields(reader)

type ChannelsLeaveChannel = {
    channel: InputChannel
}
with
    static member ConstructorId: uint32 = 4164332181u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsLeaveChannel) : unit =
        writer.WriteConstructorId(4164332181u)
        InputChannel.Serialize(writer, value.channel)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsLeaveChannel =
        let channel = InputChannel.Deserialize(reader)
        {
            channel = channel
        }

    static member Deserialize(body: byte[]) : ChannelsLeaveChannel =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsLeaveChannel.DeserializeFields(reader)

type ChannelsInviteToChannel = {
    channel: InputChannel
    users: InputUser array
}
with
    static member ConstructorId: uint32 = 3387112788u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsInviteToChannel) : unit =
        writer.WriteConstructorId(3387112788u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteVector(value.users, fun w item -> let writer = w in InputUser.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsInviteToChannel =
        let channel = InputChannel.Deserialize(reader)
        let users = reader.ReadVector(fun r -> let reader = r in InputUser.Deserialize(reader))
        {
            channel = channel
            users = users
        }

    static member Deserialize(body: byte[]) : ChannelsInviteToChannel =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsInviteToChannel.DeserializeFields(reader)

type ChannelsDeleteChannel = {
    channel: InputChannel
}
with
    static member ConstructorId: uint32 = 3222347747u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsDeleteChannel) : unit =
        writer.WriteConstructorId(3222347747u)
        InputChannel.Serialize(writer, value.channel)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsDeleteChannel =
        let channel = InputChannel.Deserialize(reader)
        {
            channel = channel
        }

    static member Deserialize(body: byte[]) : ChannelsDeleteChannel =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsDeleteChannel.DeserializeFields(reader)

type ChannelsToggleSignatures = {
    signaturesEnabled: bool
    profilesEnabled: bool
    channel: InputChannel
}
with
    static member ConstructorId: uint32 = 1099781276u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsToggleSignatures) : unit =
        writer.WriteConstructorId(1099781276u)
        let mutable flags = 0
        if value.signaturesEnabled then flags <- flags ||| (1 <<< 0)
        if value.profilesEnabled then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        InputChannel.Serialize(writer, value.channel)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsToggleSignatures =
        let flags = reader.ReadInt32()
        let signaturesEnabled = flags &&& (1 <<< 0) <> 0
        let profilesEnabled = flags &&& (1 <<< 1) <> 0
        let channel = InputChannel.Deserialize(reader)
        {
            signaturesEnabled = signaturesEnabled
            profilesEnabled = profilesEnabled
            channel = channel
        }

    static member Deserialize(body: byte[]) : ChannelsToggleSignatures =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsToggleSignatures.DeserializeFields(reader)

type ChannelsGetAdminedPublicChannels = {
    byLocation: bool
    checkLimit: bool
    forPersonal: bool
}
with
    static member ConstructorId: uint32 = 4172297903u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetAdminedPublicChannels) : unit =
        writer.WriteConstructorId(4172297903u)
        let mutable flags = 0
        if value.byLocation then flags <- flags ||| (1 <<< 0)
        if value.checkLimit then flags <- flags ||| (1 <<< 1)
        if value.forPersonal then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetAdminedPublicChannels =
        let flags = reader.ReadInt32()
        let byLocation = flags &&& (1 <<< 0) <> 0
        let checkLimit = flags &&& (1 <<< 1) <> 0
        let forPersonal = flags &&& (1 <<< 2) <> 0
        {
            byLocation = byLocation
            checkLimit = checkLimit
            forPersonal = forPersonal
        }

    static member Deserialize(body: byte[]) : ChannelsGetAdminedPublicChannels =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetAdminedPublicChannels.DeserializeFields(reader)

type ChannelsEditBanned = {
    channel: InputChannel
    participant: InputPeer
    bannedRights: ChatBannedRights
}
with
    static member ConstructorId: uint32 = 2531708289u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsEditBanned) : unit =
        writer.WriteConstructorId(2531708289u)
        InputChannel.Serialize(writer, value.channel)
        InputPeer.Serialize(writer, value.participant)
        ChatBannedRights.Serialize(writer, value.bannedRights)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsEditBanned =
        let channel = InputChannel.Deserialize(reader)
        let participant = InputPeer.Deserialize(reader)
        let bannedRights = ChatBannedRights.Deserialize(reader)
        {
            channel = channel
            participant = participant
            bannedRights = bannedRights
        }

    static member Deserialize(body: byte[]) : ChannelsEditBanned =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsEditBanned.DeserializeFields(reader)

type ChannelsReadMessageContents = {
    channel: InputChannel
    id: int32 array
}
with
    static member ConstructorId: uint32 = 3937786936u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsReadMessageContents) : unit =
        writer.WriteConstructorId(3937786936u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteVector(value.id, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsReadMessageContents =
        let channel = InputChannel.Deserialize(reader)
        let id = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            channel = channel
            id = id
        }

    static member Deserialize(body: byte[]) : ChannelsReadMessageContents =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsReadMessageContents.DeserializeFields(reader)

type ChannelsTogglePreHistoryHidden = {
    channel: InputChannel
    enabled: bool
}
with
    static member ConstructorId: uint32 = 3938171212u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsTogglePreHistoryHidden) : unit =
        writer.WriteConstructorId(3938171212u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteBool(value.enabled)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsTogglePreHistoryHidden =
        let channel = InputChannel.Deserialize(reader)
        let enabled = reader.ReadBool()
        {
            channel = channel
            enabled = enabled
        }

    static member Deserialize(body: byte[]) : ChannelsTogglePreHistoryHidden =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsTogglePreHistoryHidden.DeserializeFields(reader)

type ChannelsGetGroupsForDiscussion = {
    _placeholder: unit
}
with
    static member ConstructorId: uint32 = 4124758904u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetGroupsForDiscussion) : unit =
        writer.WriteConstructorId(4124758904u)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetGroupsForDiscussion =
        { _placeholder = () }

    static member Deserialize(body: byte[]) : ChannelsGetGroupsForDiscussion =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetGroupsForDiscussion.DeserializeFields(reader)

type ChannelsSetDiscussionGroup = {
    broadcast: InputChannel
    group: InputChannel
}
with
    static member ConstructorId: uint32 = 1079520178u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsSetDiscussionGroup) : unit =
        writer.WriteConstructorId(1079520178u)
        InputChannel.Serialize(writer, value.broadcast)
        InputChannel.Serialize(writer, value.group)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsSetDiscussionGroup =
        let broadcast = InputChannel.Deserialize(reader)
        let group = InputChannel.Deserialize(reader)
        {
            broadcast = broadcast
            group = group
        }

    static member Deserialize(body: byte[]) : ChannelsSetDiscussionGroup =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsSetDiscussionGroup.DeserializeFields(reader)

type ChannelsToggleSlowMode = {
    channel: InputChannel
    seconds: int32
}
with
    static member ConstructorId: uint32 = 3990134512u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsToggleSlowMode) : unit =
        writer.WriteConstructorId(3990134512u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteInt32(value.seconds)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsToggleSlowMode =
        let channel = InputChannel.Deserialize(reader)
        let seconds = reader.ReadInt32()
        {
            channel = channel
            seconds = seconds
        }

    static member Deserialize(body: byte[]) : ChannelsToggleSlowMode =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsToggleSlowMode.DeserializeFields(reader)

type ChannelsGetSendAs = {
    forPaidReactions: bool
    peer: InputPeer
}
with
    static member ConstructorId: uint32 = 3884295231u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetSendAs) : unit =
        writer.WriteConstructorId(3884295231u)
        let mutable flags = 0
        if value.forPaidReactions then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetSendAs =
        let flags = reader.ReadInt32()
        let forPaidReactions = flags &&& (1 <<< 0) <> 0
        let peer = InputPeer.Deserialize(reader)
        {
            forPaidReactions = forPaidReactions
            peer = peer
        }

    static member Deserialize(body: byte[]) : ChannelsGetSendAs =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetSendAs.DeserializeFields(reader)

type ChannelsToggleJoinToSend = {
    channel: InputChannel
    enabled: bool
}
with
    static member ConstructorId: uint32 = 3838547328u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsToggleJoinToSend) : unit =
        writer.WriteConstructorId(3838547328u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteBool(value.enabled)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsToggleJoinToSend =
        let channel = InputChannel.Deserialize(reader)
        let enabled = reader.ReadBool()
        {
            channel = channel
            enabled = enabled
        }

    static member Deserialize(body: byte[]) : ChannelsToggleJoinToSend =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsToggleJoinToSend.DeserializeFields(reader)

type ChannelsToggleJoinRequest = {
    channel: InputChannel
    enabled: bool
}
with
    static member ConstructorId: uint32 = 1277789622u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsToggleJoinRequest) : unit =
        writer.WriteConstructorId(1277789622u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteBool(value.enabled)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsToggleJoinRequest =
        let channel = InputChannel.Deserialize(reader)
        let enabled = reader.ReadBool()
        {
            channel = channel
            enabled = enabled
        }

    static member Deserialize(body: byte[]) : ChannelsToggleJoinRequest =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsToggleJoinRequest.DeserializeFields(reader)

type ChannelsToggleUsername = {
    channel: InputChannel
    username: string
    active: bool
}
with
    static member ConstructorId: uint32 = 1358053637u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsToggleUsername) : unit =
        writer.WriteConstructorId(1358053637u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteString(value.username)
        writer.WriteBool(value.active)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsToggleUsername =
        let channel = InputChannel.Deserialize(reader)
        let username = reader.ReadString()
        let active = reader.ReadBool()
        {
            channel = channel
            username = username
            active = active
        }

    static member Deserialize(body: byte[]) : ChannelsToggleUsername =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsToggleUsername.DeserializeFields(reader)

type ChannelsToggleForum = {
    channel: InputChannel
    enabled: bool
    tabs: bool
}
with
    static member ConstructorId: uint32 = 1073174324u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsToggleForum) : unit =
        writer.WriteConstructorId(1073174324u)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteBool(value.enabled)
        writer.WriteBool(value.tabs)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsToggleForum =
        let channel = InputChannel.Deserialize(reader)
        let enabled = reader.ReadBool()
        let tabs = reader.ReadBool()
        {
            channel = channel
            enabled = enabled
            tabs = tabs
        }

    static member Deserialize(body: byte[]) : ChannelsToggleForum =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsToggleForum.DeserializeFields(reader)

type ChannelsCreateForumTopic = {
    channel: InputChannel
    title: string
    iconColor: int32 option
    iconEmojiId: int64 option
    randomId: int64
    sendAs: InputPeer option
}
with
    static member ConstructorId: uint32 = 4094427684u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsCreateForumTopic) : unit =
        writer.WriteConstructorId(4094427684u)
        let mutable flags = 0
        if value.iconColor.IsSome then flags <- flags ||| (1 <<< 0)
        if value.iconEmojiId.IsSome then flags <- flags ||| (1 <<< 3)
        if value.sendAs.IsSome then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)
        InputChannel.Serialize(writer, value.channel)
        writer.WriteString(value.title)
        match value.iconColor with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.iconEmojiId with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()
        writer.WriteInt64(value.randomId)
        match value.sendAs with
        | Some v ->
            InputPeer.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsCreateForumTopic =
        let flags = reader.ReadInt32()
        let channel = InputChannel.Deserialize(reader)
        let title = reader.ReadString()
        let iconColor = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadInt32()) else None
        let iconEmojiId = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadInt64()) else None
        let randomId = reader.ReadInt64()
        let sendAs = if flags &&& (1 <<< 2) <> 0 then Some(InputPeer.Deserialize(reader)) else None
        {
            channel = channel
            title = title
            iconColor = iconColor
            iconEmojiId = iconEmojiId
            randomId = randomId
            sendAs = sendAs
        }

    static member Deserialize(body: byte[]) : ChannelsCreateForumTopic =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsCreateForumTopic.DeserializeFields(reader)

type ChannelsGetForumTopics = {
    channel: InputChannel
    q: string option
    offsetDate: int32
    offsetId: int32
    offsetTopic: int32
    limit: int32
}
with
    static member ConstructorId: uint32 = 233136337u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetForumTopics) : unit =
        writer.WriteConstructorId(233136337u)
        let mutable flags = 0
        if value.q.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputChannel.Serialize(writer, value.channel)
        match value.q with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        writer.WriteInt32(value.offsetDate)
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.offsetTopic)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetForumTopics =
        let flags = reader.ReadInt32()
        let channel = InputChannel.Deserialize(reader)
        let q = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
        let offsetDate = reader.ReadInt32()
        let offsetId = reader.ReadInt32()
        let offsetTopic = reader.ReadInt32()
        let limit = reader.ReadInt32()
        {
            channel = channel
            q = q
            offsetDate = offsetDate
            offsetId = offsetId
            offsetTopic = offsetTopic
            limit = limit
        }

    static member Deserialize(body: byte[]) : ChannelsGetForumTopics =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetForumTopics.DeserializeFields(reader)

type ChannelsGetChannelRecommendations = {
    channel: InputChannel option
}
with
    static member ConstructorId: uint32 = 631707458u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsGetChannelRecommendations) : unit =
        writer.WriteConstructorId(631707458u)
        let mutable flags = 0
        if value.channel.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        match value.channel with
        | Some v ->
            InputChannel.Serialize(writer, v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsGetChannelRecommendations =
        let flags = reader.ReadInt32()
        let channel = if flags &&& (1 <<< 0) <> 0 then Some(InputChannel.Deserialize(reader)) else None
        {
            channel = channel
        }

    static member Deserialize(body: byte[]) : ChannelsGetChannelRecommendations =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsGetChannelRecommendations.DeserializeFields(reader)

type ChannelsSearchPosts = {
    hashtag: string option
    query: string option
    offsetRate: int32
    offsetPeer: InputPeer
    offsetId: int32
    limit: int32
    allowPaidStars: int64 option
}
with
    static member ConstructorId: uint32 = 4072993357u

    static member Serialize(writer: TlWriteBuffer, value: ChannelsSearchPosts) : unit =
        writer.WriteConstructorId(4072993357u)
        let mutable flags = 0
        if value.hashtag.IsSome then flags <- flags ||| (1 <<< 0)
        if value.query.IsSome then flags <- flags ||| (1 <<< 1)
        if value.allowPaidStars.IsSome then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)
        match value.hashtag with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.query with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        writer.WriteInt32(value.offsetRate)
        InputPeer.Serialize(writer, value.offsetPeer)
        writer.WriteInt32(value.offsetId)
        writer.WriteInt32(value.limit)
        match value.allowPaidStars with
        | Some v ->
            writer.WriteInt64(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : ChannelsSearchPosts =
        let flags = reader.ReadInt32()
        let hashtag = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
        let query = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
        let offsetRate = reader.ReadInt32()
        let offsetPeer = InputPeer.Deserialize(reader)
        let offsetId = reader.ReadInt32()
        let limit = reader.ReadInt32()
        let allowPaidStars = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadInt64()) else None
        {
            hashtag = hashtag
            query = query
            offsetRate = offsetRate
            offsetPeer = offsetPeer
            offsetId = offsetId
            limit = limit
            allowPaidStars = allowPaidStars
        }

    static member Deserialize(body: byte[]) : ChannelsSearchPosts =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        ChannelsSearchPosts.DeserializeFields(reader)

type PhoneRequestCall = {
    video: bool
    userId: InputUser
    randomId: int32
    gAHash: byte[]
    protocol: PhoneCallProtocol
}
with
    static member ConstructorId: uint32 = 1124046573u

    static member Serialize(writer: TlWriteBuffer, value: PhoneRequestCall) : unit =
        writer.WriteConstructorId(1124046573u)
        let mutable flags = 0
        if value.video then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputUser.Serialize(writer, value.userId)
        writer.WriteInt32(value.randomId)
        writer.WriteBytes(value.gAHash)
        PhoneCallProtocol.Serialize(writer, value.protocol)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneRequestCall =
        let flags = reader.ReadInt32()
        let video = flags &&& (1 <<< 0) <> 0
        let userId = InputUser.Deserialize(reader)
        let randomId = reader.ReadInt32()
        let gAHash = reader.ReadBytes()
        let protocol = PhoneCallProtocol.Deserialize(reader)
        {
            video = video
            userId = userId
            randomId = randomId
            gAHash = gAHash
            protocol = protocol
        }

    static member Deserialize(body: byte[]) : PhoneRequestCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneRequestCall.DeserializeFields(reader)

type PhoneAcceptCall = {
    peer: InputPhoneCall
    gB: byte[]
    protocol: PhoneCallProtocol
}
with
    static member ConstructorId: uint32 = 1003664544u

    static member Serialize(writer: TlWriteBuffer, value: PhoneAcceptCall) : unit =
        writer.WriteConstructorId(1003664544u)
        InputPhoneCall.Serialize(writer, value.peer)
        writer.WriteBytes(value.gB)
        PhoneCallProtocol.Serialize(writer, value.protocol)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneAcceptCall =
        let peer = InputPhoneCall.Deserialize(reader)
        let gB = reader.ReadBytes()
        let protocol = PhoneCallProtocol.Deserialize(reader)
        {
            peer = peer
            gB = gB
            protocol = protocol
        }

    static member Deserialize(body: byte[]) : PhoneAcceptCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneAcceptCall.DeserializeFields(reader)

type PhoneConfirmCall = {
    peer: InputPhoneCall
    gA: byte[]
    keyFingerprint: int64
    protocol: PhoneCallProtocol
}
with
    static member ConstructorId: uint32 = 788404002u

    static member Serialize(writer: TlWriteBuffer, value: PhoneConfirmCall) : unit =
        writer.WriteConstructorId(788404002u)
        InputPhoneCall.Serialize(writer, value.peer)
        writer.WriteBytes(value.gA)
        writer.WriteInt64(value.keyFingerprint)
        PhoneCallProtocol.Serialize(writer, value.protocol)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneConfirmCall =
        let peer = InputPhoneCall.Deserialize(reader)
        let gA = reader.ReadBytes()
        let keyFingerprint = reader.ReadInt64()
        let protocol = PhoneCallProtocol.Deserialize(reader)
        {
            peer = peer
            gA = gA
            keyFingerprint = keyFingerprint
            protocol = protocol
        }

    static member Deserialize(body: byte[]) : PhoneConfirmCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneConfirmCall.DeserializeFields(reader)

type PhoneDiscardCall = {
    video: bool
    peer: InputPhoneCall
    duration: int32
    reason: PhoneCallDiscardReason
    connectionId: int64
}
with
    static member ConstructorId: uint32 = 2999697856u

    static member Serialize(writer: TlWriteBuffer, value: PhoneDiscardCall) : unit =
        writer.WriteConstructorId(2999697856u)
        let mutable flags = 0
        if value.video then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputPhoneCall.Serialize(writer, value.peer)
        writer.WriteInt32(value.duration)
        PhoneCallDiscardReason.Serialize(writer, value.reason)
        writer.WriteInt64(value.connectionId)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneDiscardCall =
        let flags = reader.ReadInt32()
        let video = flags &&& (1 <<< 0) <> 0
        let peer = InputPhoneCall.Deserialize(reader)
        let duration = reader.ReadInt32()
        let reason = PhoneCallDiscardReason.Deserialize(reader)
        let connectionId = reader.ReadInt64()
        {
            video = video
            peer = peer
            duration = duration
            reason = reason
            connectionId = connectionId
        }

    static member Deserialize(body: byte[]) : PhoneDiscardCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneDiscardCall.DeserializeFields(reader)

type PhoneSaveCallDebug = {
    peer: InputPhoneCall
    debug: DataJSON
}
with
    static member ConstructorId: uint32 = 662363518u

    static member Serialize(writer: TlWriteBuffer, value: PhoneSaveCallDebug) : unit =
        writer.WriteConstructorId(662363518u)
        InputPhoneCall.Serialize(writer, value.peer)
        DataJSON.Serialize(writer, value.debug)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneSaveCallDebug =
        let peer = InputPhoneCall.Deserialize(reader)
        let debug = DataJSON.Deserialize(reader)
        {
            peer = peer
            debug = debug
        }

    static member Deserialize(body: byte[]) : PhoneSaveCallDebug =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneSaveCallDebug.DeserializeFields(reader)

type PhoneSendSignalingData = {
    peer: InputPhoneCall
    data: byte[]
}
with
    static member ConstructorId: uint32 = 4286223235u

    static member Serialize(writer: TlWriteBuffer, value: PhoneSendSignalingData) : unit =
        writer.WriteConstructorId(4286223235u)
        InputPhoneCall.Serialize(writer, value.peer)
        writer.WriteBytes(value.data)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneSendSignalingData =
        let peer = InputPhoneCall.Deserialize(reader)
        let data = reader.ReadBytes()
        {
            peer = peer
            data = data
        }

    static member Deserialize(body: byte[]) : PhoneSendSignalingData =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneSendSignalingData.DeserializeFields(reader)

type PhoneCreateGroupCall = {
    rtmpStream: bool
    peer: InputPeer
    randomId: int32
    title: string option
    scheduleDate: int32 option
}
with
    static member ConstructorId: uint32 = 1221445336u

    static member Serialize(writer: TlWriteBuffer, value: PhoneCreateGroupCall) : unit =
        writer.WriteConstructorId(1221445336u)
        let mutable flags = 0
        if value.rtmpStream then flags <- flags ||| (1 <<< 2)
        if value.title.IsSome then flags <- flags ||| (1 <<< 0)
        if value.scheduleDate.IsSome then flags <- flags ||| (1 <<< 1)
        writer.WriteInt32(flags)
        InputPeer.Serialize(writer, value.peer)
        writer.WriteInt32(value.randomId)
        match value.title with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.scheduleDate with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : PhoneCreateGroupCall =
        let flags = reader.ReadInt32()
        let rtmpStream = flags &&& (1 <<< 2) <> 0
        let peer = InputPeer.Deserialize(reader)
        let randomId = reader.ReadInt32()
        let title = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
        let scheduleDate = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
        {
            rtmpStream = rtmpStream
            peer = peer
            randomId = randomId
            title = title
            scheduleDate = scheduleDate
        }

    static member Deserialize(body: byte[]) : PhoneCreateGroupCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneCreateGroupCall.DeserializeFields(reader)

type PhoneJoinGroupCall = {
    muted: bool
    videoStopped: bool
    call: InputGroupCall
    joinAs: InputPeer
    inviteHash: string option
    publicKey: byte[] option
    block: byte[] option
    ``params``: DataJSON
}
with
    static member ConstructorId: uint32 = 2411016279u

    static member Serialize(writer: TlWriteBuffer, value: PhoneJoinGroupCall) : unit =
        writer.WriteConstructorId(2411016279u)
        let mutable flags = 0
        if value.muted then flags <- flags ||| (1 <<< 0)
        if value.videoStopped then flags <- flags ||| (1 <<< 2)
        if value.inviteHash.IsSome then flags <- flags ||| (1 <<< 1)
        if value.publicKey.IsSome then flags <- flags ||| (1 <<< 3)
        if value.block.IsSome then flags <- flags ||| (1 <<< 3)
        writer.WriteInt32(flags)
        InputGroupCall.Serialize(writer, value.call)
        InputPeer.Serialize(writer, value.joinAs)
        match value.inviteHash with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.publicKey with
        | Some v ->
            writer.WriteBytes(v)
        | None -> ()
        match value.block with
        | Some v ->
            writer.WriteBytes(v)
        | None -> ()
        DataJSON.Serialize(writer, value.``params``)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneJoinGroupCall =
        let flags = reader.ReadInt32()
        let muted = flags &&& (1 <<< 0) <> 0
        let videoStopped = flags &&& (1 <<< 2) <> 0
        let call = InputGroupCall.Deserialize(reader)
        let joinAs = InputPeer.Deserialize(reader)
        let inviteHash = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
        let publicKey = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadBytes()) else None
        let block = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadBytes()) else None
        let ``params`` = DataJSON.Deserialize(reader)
        {
            muted = muted
            videoStopped = videoStopped
            call = call
            joinAs = joinAs
            inviteHash = inviteHash
            publicKey = publicKey
            block = block
            ``params`` = ``params``
        }

    static member Deserialize(body: byte[]) : PhoneJoinGroupCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneJoinGroupCall.DeserializeFields(reader)

type PhoneLeaveGroupCall = {
    call: InputGroupCall
    source: int32
}
with
    static member ConstructorId: uint32 = 1342404601u

    static member Serialize(writer: TlWriteBuffer, value: PhoneLeaveGroupCall) : unit =
        writer.WriteConstructorId(1342404601u)
        InputGroupCall.Serialize(writer, value.call)
        writer.WriteInt32(value.source)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneLeaveGroupCall =
        let call = InputGroupCall.Deserialize(reader)
        let source = reader.ReadInt32()
        {
            call = call
            source = source
        }

    static member Deserialize(body: byte[]) : PhoneLeaveGroupCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneLeaveGroupCall.DeserializeFields(reader)

type PhoneInviteToGroupCall = {
    call: InputGroupCall
    users: InputUser array
}
with
    static member ConstructorId: uint32 = 2067345760u

    static member Serialize(writer: TlWriteBuffer, value: PhoneInviteToGroupCall) : unit =
        writer.WriteConstructorId(2067345760u)
        InputGroupCall.Serialize(writer, value.call)
        writer.WriteVector(value.users, fun w item -> let writer = w in InputUser.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : PhoneInviteToGroupCall =
        let call = InputGroupCall.Deserialize(reader)
        let users = reader.ReadVector(fun r -> let reader = r in InputUser.Deserialize(reader))
        {
            call = call
            users = users
        }

    static member Deserialize(body: byte[]) : PhoneInviteToGroupCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneInviteToGroupCall.DeserializeFields(reader)

type PhoneDiscardGroupCall = {
    call: InputGroupCall
}
with
    static member ConstructorId: uint32 = 2054648117u

    static member Serialize(writer: TlWriteBuffer, value: PhoneDiscardGroupCall) : unit =
        writer.WriteConstructorId(2054648117u)
        InputGroupCall.Serialize(writer, value.call)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneDiscardGroupCall =
        let call = InputGroupCall.Deserialize(reader)
        {
            call = call
        }

    static member Deserialize(body: byte[]) : PhoneDiscardGroupCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneDiscardGroupCall.DeserializeFields(reader)

type PhoneToggleGroupCallSettings = {
    resetInviteHash: bool
    call: InputGroupCall
    joinMuted: bool option
}
with
    static member ConstructorId: uint32 = 1958458429u

    static member Serialize(writer: TlWriteBuffer, value: PhoneToggleGroupCallSettings) : unit =
        writer.WriteConstructorId(1958458429u)
        let mutable flags = 0
        if value.resetInviteHash then flags <- flags ||| (1 <<< 1)
        if value.joinMuted.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputGroupCall.Serialize(writer, value.call)
        match value.joinMuted with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : PhoneToggleGroupCallSettings =
        let flags = reader.ReadInt32()
        let resetInviteHash = flags &&& (1 <<< 1) <> 0
        let call = InputGroupCall.Deserialize(reader)
        let joinMuted = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadBool()) else None
        {
            resetInviteHash = resetInviteHash
            call = call
            joinMuted = joinMuted
        }

    static member Deserialize(body: byte[]) : PhoneToggleGroupCallSettings =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneToggleGroupCallSettings.DeserializeFields(reader)

type PhoneGetGroupCall = {
    call: InputGroupCall
    limit: int32
}
with
    static member ConstructorId: uint32 = 68699611u

    static member Serialize(writer: TlWriteBuffer, value: PhoneGetGroupCall) : unit =
        writer.WriteConstructorId(68699611u)
        InputGroupCall.Serialize(writer, value.call)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneGetGroupCall =
        let call = InputGroupCall.Deserialize(reader)
        let limit = reader.ReadInt32()
        {
            call = call
            limit = limit
        }

    static member Deserialize(body: byte[]) : PhoneGetGroupCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneGetGroupCall.DeserializeFields(reader)

type PhoneGetGroupParticipants = {
    call: InputGroupCall
    ids: InputPeer array
    sources: int32 array
    offset: string
    limit: int32
}
with
    static member ConstructorId: uint32 = 3310934187u

    static member Serialize(writer: TlWriteBuffer, value: PhoneGetGroupParticipants) : unit =
        writer.WriteConstructorId(3310934187u)
        InputGroupCall.Serialize(writer, value.call)
        writer.WriteVector(value.ids, fun w item -> let writer = w in InputPeer.Serialize(writer, item))
        writer.WriteVector(value.sources, fun w item -> let writer = w in writer.WriteInt32(item))
        writer.WriteString(value.offset)
        writer.WriteInt32(value.limit)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneGetGroupParticipants =
        let call = InputGroupCall.Deserialize(reader)
        let ids = reader.ReadVector(fun r -> let reader = r in InputPeer.Deserialize(reader))
        let sources = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        let offset = reader.ReadString()
        let limit = reader.ReadInt32()
        {
            call = call
            ids = ids
            sources = sources
            offset = offset
            limit = limit
        }

    static member Deserialize(body: byte[]) : PhoneGetGroupParticipants =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneGetGroupParticipants.DeserializeFields(reader)

type PhoneCheckGroupCall = {
    call: InputGroupCall
    sources: int32 array
}
with
    static member ConstructorId: uint32 = 3046963575u

    static member Serialize(writer: TlWriteBuffer, value: PhoneCheckGroupCall) : unit =
        writer.WriteConstructorId(3046963575u)
        InputGroupCall.Serialize(writer, value.call)
        writer.WriteVector(value.sources, fun w item -> let writer = w in writer.WriteInt32(item))

    static member DeserializeFields(reader: TlReadBuffer) : PhoneCheckGroupCall =
        let call = InputGroupCall.Deserialize(reader)
        let sources = reader.ReadVector(fun r -> let reader = r in reader.ReadInt32())
        {
            call = call
            sources = sources
        }

    static member Deserialize(body: byte[]) : PhoneCheckGroupCall =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneCheckGroupCall.DeserializeFields(reader)

type PhoneToggleGroupCallRecord = {
    start: bool
    video: bool
    call: InputGroupCall
    title: string option
    videoPortrait: bool option
}
with
    static member ConstructorId: uint32 = 4045981448u

    static member Serialize(writer: TlWriteBuffer, value: PhoneToggleGroupCallRecord) : unit =
        writer.WriteConstructorId(4045981448u)
        let mutable flags = 0
        if value.start then flags <- flags ||| (1 <<< 0)
        if value.video then flags <- flags ||| (1 <<< 2)
        if value.title.IsSome then flags <- flags ||| (1 <<< 1)
        if value.videoPortrait.IsSome then flags <- flags ||| (1 <<< 2)
        writer.WriteInt32(flags)
        InputGroupCall.Serialize(writer, value.call)
        match value.title with
        | Some v ->
            writer.WriteString(v)
        | None -> ()
        match value.videoPortrait with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : PhoneToggleGroupCallRecord =
        let flags = reader.ReadInt32()
        let start = flags &&& (1 <<< 0) <> 0
        let video = flags &&& (1 <<< 2) <> 0
        let call = InputGroupCall.Deserialize(reader)
        let title = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadString()) else None
        let videoPortrait = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadBool()) else None
        {
            start = start
            video = video
            call = call
            title = title
            videoPortrait = videoPortrait
        }

    static member Deserialize(body: byte[]) : PhoneToggleGroupCallRecord =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneToggleGroupCallRecord.DeserializeFields(reader)

type PhoneEditGroupCallParticipant = {
    call: InputGroupCall
    participant: InputPeer
    muted: bool option
    volume: int32 option
    raiseHand: bool option
    videoStopped: bool option
    videoPaused: bool option
    presentationPaused: bool option
}
with
    static member ConstructorId: uint32 = 2770811583u

    static member Serialize(writer: TlWriteBuffer, value: PhoneEditGroupCallParticipant) : unit =
        writer.WriteConstructorId(2770811583u)
        let mutable flags = 0
        if value.muted.IsSome then flags <- flags ||| (1 <<< 0)
        if value.volume.IsSome then flags <- flags ||| (1 <<< 1)
        if value.raiseHand.IsSome then flags <- flags ||| (1 <<< 2)
        if value.videoStopped.IsSome then flags <- flags ||| (1 <<< 3)
        if value.videoPaused.IsSome then flags <- flags ||| (1 <<< 4)
        if value.presentationPaused.IsSome then flags <- flags ||| (1 <<< 5)
        writer.WriteInt32(flags)
        InputGroupCall.Serialize(writer, value.call)
        InputPeer.Serialize(writer, value.participant)
        match value.muted with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.volume with
        | Some v ->
            writer.WriteInt32(v)
        | None -> ()
        match value.raiseHand with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.videoStopped with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.videoPaused with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()
        match value.presentationPaused with
        | Some v ->
            writer.WriteBool(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : PhoneEditGroupCallParticipant =
        let flags = reader.ReadInt32()
        let call = InputGroupCall.Deserialize(reader)
        let participant = InputPeer.Deserialize(reader)
        let muted = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadBool()) else None
        let volume = if flags &&& (1 <<< 1) <> 0 then Some(reader.ReadInt32()) else None
        let raiseHand = if flags &&& (1 <<< 2) <> 0 then Some(reader.ReadBool()) else None
        let videoStopped = if flags &&& (1 <<< 3) <> 0 then Some(reader.ReadBool()) else None
        let videoPaused = if flags &&& (1 <<< 4) <> 0 then Some(reader.ReadBool()) else None
        let presentationPaused = if flags &&& (1 <<< 5) <> 0 then Some(reader.ReadBool()) else None
        {
            call = call
            participant = participant
            muted = muted
            volume = volume
            raiseHand = raiseHand
            videoStopped = videoStopped
            videoPaused = videoPaused
            presentationPaused = presentationPaused
        }

    static member Deserialize(body: byte[]) : PhoneEditGroupCallParticipant =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneEditGroupCallParticipant.DeserializeFields(reader)

type PhoneEditGroupCallTitle = {
    call: InputGroupCall
    title: string
}
with
    static member ConstructorId: uint32 = 480685066u

    static member Serialize(writer: TlWriteBuffer, value: PhoneEditGroupCallTitle) : unit =
        writer.WriteConstructorId(480685066u)
        InputGroupCall.Serialize(writer, value.call)
        writer.WriteString(value.title)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneEditGroupCallTitle =
        let call = InputGroupCall.Deserialize(reader)
        let title = reader.ReadString()
        {
            call = call
            title = title
        }

    static member Deserialize(body: byte[]) : PhoneEditGroupCallTitle =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneEditGroupCallTitle.DeserializeFields(reader)

type PhoneGetGroupCallJoinAs = {
    peer: InputPeer
}
with
    static member ConstructorId: uint32 = 4017889594u

    static member Serialize(writer: TlWriteBuffer, value: PhoneGetGroupCallJoinAs) : unit =
        writer.WriteConstructorId(4017889594u)
        InputPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneGetGroupCallJoinAs =
        let peer = InputPeer.Deserialize(reader)
        {
            peer = peer
        }

    static member Deserialize(body: byte[]) : PhoneGetGroupCallJoinAs =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneGetGroupCallJoinAs.DeserializeFields(reader)

type PhoneExportGroupCallInvite = {
    canSelfUnmute: bool
    call: InputGroupCall
}
with
    static member ConstructorId: uint32 = 3869926527u

    static member Serialize(writer: TlWriteBuffer, value: PhoneExportGroupCallInvite) : unit =
        writer.WriteConstructorId(3869926527u)
        let mutable flags = 0
        if value.canSelfUnmute then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        InputGroupCall.Serialize(writer, value.call)

    static member DeserializeFields(reader: TlReadBuffer) : PhoneExportGroupCallInvite =
        let flags = reader.ReadInt32()
        let canSelfUnmute = flags &&& (1 <<< 0) <> 0
        let call = InputGroupCall.Deserialize(reader)
        {
            canSelfUnmute = canSelfUnmute
            call = call
        }

    static member Deserialize(body: byte[]) : PhoneExportGroupCallInvite =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        PhoneExportGroupCallInvite.DeserializeFields(reader)

type LangpackGetLangPack = {
    langPack: string
    langCode: string
}
with
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
}
with
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
}
with
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
}
with
    static member ConstructorId: uint32 = 1120311183u

    static member Serialize(writer: TlWriteBuffer, value: LangpackGetLanguages) : unit =
        writer.WriteConstructorId(1120311183u)
        writer.WriteString(value.langPack)

    static member DeserializeFields(reader: TlReadBuffer) : LangpackGetLanguages =
        let langPack = reader.ReadString()
        {
            langPack = langPack
        }

    static member Deserialize(body: byte[]) : LangpackGetLanguages =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        LangpackGetLanguages.DeserializeFields(reader)

type LangpackGetLanguage = {
    langPack: string
    langCode: string
}
with
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

type FoldersEditPeerFolders = {
    folderPeers: InputFolderPeer array
}
with
    static member ConstructorId: uint32 = 1749536939u

    static member Serialize(writer: TlWriteBuffer, value: FoldersEditPeerFolders) : unit =
        writer.WriteConstructorId(1749536939u)
        writer.WriteVector(value.folderPeers, fun w item -> let writer = w in InputFolderPeer.Serialize(writer, item))

    static member DeserializeFields(reader: TlReadBuffer) : FoldersEditPeerFolders =
        let folderPeers = reader.ReadVector(fun r -> let reader = r in InputFolderPeer.Deserialize(reader))
        {
            folderPeers = folderPeers
        }

    static member Deserialize(body: byte[]) : FoldersEditPeerFolders =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        FoldersEditPeerFolders.DeserializeFields(reader)

type StoriesGetAllStories = {
    next: bool
    hidden: bool
    state: string option
}
with
    static member ConstructorId: uint32 = 4004566565u

    static member Serialize(writer: TlWriteBuffer, value: StoriesGetAllStories) : unit =
        writer.WriteConstructorId(4004566565u)
        let mutable flags = 0
        if value.next then flags <- flags ||| (1 <<< 1)
        if value.hidden then flags <- flags ||| (1 <<< 2)
        if value.state.IsSome then flags <- flags ||| (1 <<< 0)
        writer.WriteInt32(flags)
        match value.state with
        | Some v ->
            writer.WriteString(v)
        | None -> ()

    static member DeserializeFields(reader: TlReadBuffer) : StoriesGetAllStories =
        let flags = reader.ReadInt32()
        let next = flags &&& (1 <<< 1) <> 0
        let hidden = flags &&& (1 <<< 2) <> 0
        let state = if flags &&& (1 <<< 0) <> 0 then Some(reader.ReadString()) else None
        {
            next = next
            hidden = hidden
            state = state
        }

    static member Deserialize(body: byte[]) : StoriesGetAllStories =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        StoriesGetAllStories.DeserializeFields(reader)

type StoriesGetPeerStories = {
    peer: InputPeer
}
with
    static member ConstructorId: uint32 = 743103056u

    static member Serialize(writer: TlWriteBuffer, value: StoriesGetPeerStories) : unit =
        writer.WriteConstructorId(743103056u)
        InputPeer.Serialize(writer, value.peer)

    static member DeserializeFields(reader: TlReadBuffer) : StoriesGetPeerStories =
        let peer = InputPeer.Deserialize(reader)
        {
            peer = peer
        }

    static member Deserialize(body: byte[]) : StoriesGetPeerStories =
        use reader = new TlReadBuffer(body)
        let _cid = reader.ReadConstructorId()
        StoriesGetPeerStories.DeserializeFields(reader)

