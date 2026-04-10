namespace TDesu.Serialization

open TDesu.Serialization.GeneratedTlWriters

/// Default records for generated writer types.
/// Use `{ WriteDefaults.user with id = ..; firstName = Some ".." }` to construct.
[<AutoOpen>]
module WriteDefaults =

    /// Default WriteUserParams — all bools false, all options None.
    let defaultWriteUser : WriteUserParams = {
        self = false; contact = false; mutualContact = false; deleted = false
        bot = false; botChatHistory = false; botNochats = false; verified = false
        restricted = false; min = false; botInlineGeo = false; support = false
        scam = false; applyMinPhoto = false; fake = false; botAttachMenu = false
        premium = false; attachMenuEnabled = false; botCanEdit = false
        closeFriend = false; storiesHidden = false; storiesUnavailable = false
        contactRequirePremium = false; botBusiness = false; botHasMainApp = false
        botForumView = false; botForumCanManageTopics = false
        id = 0L; accessHash = None; firstName = None; lastName = None
        username = None; phone = None; photo = None; status = None
        botInfoVersion = None; restrictionReason = None
        botInlinePlaceholder = None; langCode = None; emojiStatus = None
        usernames = None; storiesMaxId = None; color = None; profileColor = None
        botActiveUsers = None; botVerificationIcon = None
        sendPaidMessagesStars = None
    }

    /// Default WriteMessageParams — all bools false, all options None.
    let defaultWriteMessage : WriteMessageParams = {
        out = false; mentioned = false; mediaUnread = false; silent = false
        post = false; fromScheduled = false; legacy = false; editHide = false
        pinned = false; noforwards = false; invertMedia = false; offline = false
        videoProcessingPending = false; paidSuggestedPostStars = false
        paidSuggestedPostTon = false
        id = 0; fromId = None; fromBoostsApplied = None
        peerId = WritePeer.PeerUser(0L); savedPeerId = None
        fwdFrom = None; viaBotId = None; viaBusinessBotId = None
        replyTo = None; date = 0; message = ""
        media = None; replyMarkup = None; entities = None
        views = None; forwards = None; replies = None
        editDate = None; postAuthor = None; groupedId = None
        reactions = None; restrictionReason = None; ttlPeriod = None
        quickReplyShortcutId = None; effect = None; factcheck = None
        reportDeliveryUntilDate = None; paidMessageStars = None
        suggestedPost = None
    }

    /// Default WriteMessageServiceParams — all bools false, all options None.
    let defaultWriteMessageService : WriteMessageServiceParams = {
        out = false; mentioned = false; mediaUnread = false; silent = false
        post = false; legacy = false
        id = 0; fromId = None
        peerId = WritePeer.PeerUser(0L); savedPeerId = None
        replyTo = None; date = 0
        action = WriteMessageAction.MessageActionEmpty
        ttlPeriod = None
    }

    /// Convert PeerType + int64 to WritePeer.
    let writePeerFromType (peerType: PeerType) (peerId: int64) : WritePeer =
        match peerType with
        | PeerTypeUser -> WritePeer.PeerUser(peerId)
        | PeerTypeChat -> WritePeer.PeerChat(peerId)
        | PeerTypeChannel -> WritePeer.PeerChannel(peerId)

    /// Convert ReplyToMsgId (int option) to WriteMessageReplyHeaderParams option.
    let writeReplyTo (replyToMsgId: int option) : WriteMessageReplyHeaderParams option =
        replyToMsgId |> Option.map (fun rid ->
            { WriteMessageReplyHeaderParams.replyToScheduled = false; forumTopic = false; quote = false
              replyToMsgId = Some rid; replyToPeerId = None; replyFrom = None
              replyMedia = None; replyToTopId = None; quoteText = None
              quoteEntities = None; quoteOffset = None; todoItemId = None })

    /// Convert ReplyToMsgId with optional topMsgId (forum topic) to WriteMessageReplyHeaderParams option.
    let writeReplyToWithTopic (replyToMsgId: int option) (topMsgId: int option) : WriteMessageReplyHeaderParams option =
        match replyToMsgId, topMsgId with
        | Some rid, topId ->
            Some { WriteMessageReplyHeaderParams.replyToScheduled = false
                   forumTopic = topId.IsSome; quote = false
                   replyToMsgId = Some rid; replyToPeerId = None; replyFrom = None
                   replyMedia = None; replyToTopId = topId; quoteText = None
                   quoteEntities = None; quoteOffset = None; todoItemId = None }
        | None, Some topId ->
            // Topic-only (root message in a forum topic)
            Some { WriteMessageReplyHeaderParams.replyToScheduled = false
                   forumTopic = true; quote = false
                   replyToMsgId = Some topId; replyToPeerId = None; replyFrom = None
                   replyMedia = None; replyToTopId = None; quoteText = None
                   quoteEntities = None; quoteOffset = None; todoItemId = None }
        | None, None -> None

    /// Convert MediaInfo option to WriteMessageMedia option.
    let writeMediaFromInfo (media: MediaInfo option) : WriteMessageMedia option =
        match media with
        | Some(MediaInfo.Photo(photoId, accessHash, dcId, width, height, size)) ->
            let thumbSizes = [|
                { WritePhotoSizeParams.``type`` = "s"; w = min 90 width; h = min 90 height; size = 0 }
                { WritePhotoSizeParams.``type`` = "m"; w = min 320 width; h = min 320 height; size = 0 }
                { WritePhotoSizeParams.``type`` = "x"; w = width; h = height; size = size }
            |]
            Some(WriteMessageMedia.MessageMediaPhoto(
                false,
                Some { WritePhotoParams.hasStickers = false; id = photoId; accessHash = accessHash
                       fileReference = [||]; date = 0; dcId = dcId
                       sizes = thumbSizes; videoSizes = None },
                None))
        | Some(MediaInfo.Document(docId, accessHash, dcId, mime, size, name, docAttrs)) ->
            let isVoice = docAttrs |> List.exists (function DocumentAttribute.Audio(_, _, _, true, _) -> true | _ -> false)
            let isRound = docAttrs |> List.exists (function DocumentAttribute.Video(_, _, _, true, _) -> true | _ -> false)
            let isVideo = docAttrs |> List.exists (function DocumentAttribute.Video _ -> true | _ -> false)
            Some(WriteMessageMedia.MessageMediaDocument(
                false, false, isVideo, isRound, isVoice,
                Some { WriteDocumentParams.id = docId; accessHash = accessHash; fileReference = [||]
                       date = 0; mimeType = mime; size = size; thumbs = None; videoThumbs = None
                       dcId = dcId; attributes = [| { WriteDocumentAttributeFilenameParams.fileName = name } |] },
                None, None, None, None))
        | Some(MediaInfo.Poll(_, pollBytes, resultsBytes)) ->
            Some(WriteMessageMedia.MessageMediaPoll(pollBytes, resultsBytes))
        | Some(MediaInfo.Geo(lat, lon)) ->
            Some(WriteMessageMedia.MessageMediaGeo(lat, lon))
        | Some(MediaInfo.GeoLive(lat, lon, period, heading)) ->
            let h = if heading <> 0 then Some heading else None
            Some(WriteMessageMedia.MessageMediaGeoLive(lat, lon, h, period, None))
        | Some(MediaInfo.Venue(lat, lon, title, address, provider, venueId, venueType)) ->
            Some(WriteMessageMedia.MessageMediaVenue(lat, lon, title, address, provider, venueId, venueType))
        | Some MediaInfo.Empty -> None
        | None -> None

    /// Convert TlMessage to WriteMessageParams.
    let writeMessageFromTlMessage (m: TlMessage) : WriteMessageParams =
        { defaultWriteMessage with
            id = m.MsgId
            fromId = Some(WritePeer.PeerUser(m.FromId))
            peerId = writePeerFromType m.PeerType m.PeerId
            message = m.Text
            date = m.Date
            out = m.IsOutgoing
            replyTo = writeReplyTo m.ReplyToMsgId
            media = writeMediaFromInfo m.Media
            groupedId = m.GroupedId }

    /// Serialize messageFwdHeader#4e4df4bb as raw bytes for the fwdFrom field.
    /// fromId: original sender peer (None if privacy-restricted, use fromName instead).
    /// fromName: sender display name (used when fromId is hidden by privacy).
    /// date: original message date.
    /// channelPost: original message ID if forwarded from a channel.
    /// savedFromPeer: peer where the message was saved from (for Saved Messages).
    /// savedFromMsgId: msg ID in the saved-from peer (for Saved Messages).
    let serializeMessageFwdHeader
        (fromId: WritePeer option) (fromName: string option)
        (date: int) (channelPost: int option)
        (savedFromPeer: WritePeer option) (savedFromMsgId: int option) : byte[] =
        tl {
            write (fun w ->
                w.WriteConstructorId(GeneratedCid.MessageFwdHeader) // 0x4E4DF4BB
                let mutable flags = 0
                if fromId.IsSome then flags <- flags ||| (1 <<< 0)
                if channelPost.IsSome then flags <- flags ||| (1 <<< 2)
                if savedFromPeer.IsSome && savedFromMsgId.IsSome then flags <- flags ||| (1 <<< 4)
                if fromName.IsSome then flags <- flags ||| (1 <<< 5)
                w.WriteInt32(flags)
                // from_id (flags.0)
                fromId |> Option.iter (fun p -> writePeer w p)
                // from_name (flags.5)
                fromName |> Option.iter (fun n -> w.WriteString(n))
                // date (always)
                w.WriteInt32(date)
                // channel_post (flags.2)
                channelPost |> Option.iter (fun cp -> w.WriteInt32(cp))
                // post_author (flags.3) — not set
                // saved_from_peer + saved_from_msg_id (flags.4)
                match savedFromPeer, savedFromMsgId with
                | Some p, Some mid ->
                    writePeer w p
                    w.WriteInt32(mid)
                | _ -> ()
            )
        }

    /// Serialize rpc_error#2144ca19 as standalone byte[].
    let rpcError (code: int) (message: string) : byte[] =
        tl {
            write (fun w ->
                w.WriteConstructorId(0x2144CA19u)
                w.WriteInt32(code)
                w.WriteString(message))
        }

    /// Default WritePeerNotifySettingsParams — all options None.
    let defaultWriteNotifySettings : WritePeerNotifySettingsParams = {
        showPreviews = None; silent = None; muteUntil = None
        iosSound = None; androidSound = None; otherSound = None
        storiesMuted = None; storiesHideSender = None
        storiesIosSound = None; storiesAndroidSound = None; storiesOtherSound = None
    }

    /// Default WriteDialogParams — all bools false, all options None.
    let defaultWriteDialog : WriteDialogParams = {
        pinned = false; unreadMark = false; viewForumAsMessages = false
        peer = WritePeer.PeerUser(0L); topMessage = 0
        readInboxMaxId = 0; readOutboxMaxId = 0
        unreadCount = 0; unreadMentionsCount = 0; unreadReactionsCount = 0
        notifySettings = defaultWriteNotifySettings
        pts = None; draft = None; folderId = None; ttlPeriod = None
    }

    /// Convert TlUser-style photo tuple (photoId, accessHash, dcId) to WriteUserProfilePhotoParams.
    let writePhotoFromTuple (photo: (int64 * int64 * int) option) : WriteUserProfilePhotoParams option =
        photo |> Option.map (fun (photoId, _, dcId) ->
            { WriteUserProfilePhotoParams.hasVideo = false; personal = false
              photoId = photoId; strippedThumb = None; dcId = dcId })

    /// Convert TlUserStatus to WriteUserStatus.
    let writeStatusFromTlStatus (status: UserStatus option) : WriteUserStatus option =
        status |> Option.map (fun s ->
            match s with
            | UserStatus.Online expires -> WriteUserStatus.UserStatusOnline(expires)
            | UserStatus.Offline wasOnline -> WriteUserStatus.UserStatusOffline(wasOnline)
            | UserStatus.Recently | UserStatus.LastWeek | UserStatus.LastMonth ->
                WriteUserStatus.UserStatusRecently(false))

    /// Convert photo tuple (photoId, accessHash, dcId) to WriteChatPhoto.
    let writeChatPhotoFromTuple (photo: (int64 * int64 * int) option) : WriteChatPhoto =
        match photo with
        | Some(photoId, _, dcId) -> WriteChatPhoto.ChatPhoto(false, photoId, None, dcId)
        | None -> WriteChatPhoto.ChatPhotoEmpty

    /// Create a simple WriteChat.Chat with minimal fields.
    let simpleChat (chatId: int64) (title: string) (membersCount: int) (date: int) (photo: WriteChatPhoto) : WriteChat =
        WriteChat.Chat(
            false, false, false, false, false, false,
            chatId, title, photo, membersCount, date, 1,
            None, None, None)

    /// Create a simple WriteChat.Channel with minimal fields.
    let simpleChannel
        (channelId: int64) (accessHash: int64) (title: string) (date: int)
        (isBroadcast: bool) (isMegagroup: bool) (membersCount: int option)
        (username: string option) (photo: WriteChatPhoto) : WriteChat =
        WriteChat.Channel(
            false, false, isBroadcast, false, isMegagroup, false,
            false, false, false, false, false, false,
            false, false, false, false, false, false,
            false, false, false, false, false, false,
            false, false, false, false,
            channelId, Some accessHash, title, username, photo, date,
            None, None, None, None, membersCount,
            None, None, None, None, None, None, None, None, None, None)
