// Auto-generated TL writer functions. Do not edit manually.
// Re-generate with: dotnet run --project src/MTProto.TL.Generator -- --writers

namespace TDesu.Serialization

/// Auto-generated TL writer functions from schema.
module GeneratedTlWriters =

    [<RequireQualifiedAccess>]
    type WriteChannelParticipant =
        | ChannelParticipant of userId: int64 * date: int32 * subscriptionUntilDate: int32 option
        | ChannelParticipantCreator of userId: int64 * adminRights: WriteChatAdminRightsParams * rank: string option
        | ChannelParticipantAdmin of canEdit: bool * self: bool * userId: int64 * inviterId: int64 option * promotedBy: int64 * date: int32 * adminRights: WriteChatAdminRightsParams * rank: string option
    and [<RequireQualifiedAccess>] WriteChat =
        | Chat of creator: bool * left: bool * deactivated: bool * callActive: bool * callNotEmpty: bool * noforwards: bool * id: int64 * title: string * photo: WriteChatPhoto * participantsCount: int32 * date: int32 * version: int32 * migratedTo: byte[] option * adminRights: WriteChatAdminRightsParams option * defaultBannedRights: WriteChatBannedRightsParams option
        | Channel of creator: bool * left: bool * broadcast: bool * verified: bool * megagroup: bool * restricted: bool * signatures: bool * min: bool * scam: bool * hasLink: bool * hasGeo: bool * slowmodeEnabled: bool * callActive: bool * callNotEmpty: bool * fake: bool * gigagroup: bool * noforwards: bool * joinToSend: bool * joinRequest: bool * forum: bool * storiesHidden: bool * storiesHiddenMin: bool * storiesUnavailable: bool * signatureProfiles: bool * autotranslation: bool * broadcastMessagesAllowed: bool * monoforum: bool * forumTabs: bool * id: int64 * accessHash: int64 option * title: string * username: string option * photo: WriteChatPhoto * date: int32 * restrictionReason: byte[] array option * adminRights: WriteChatAdminRightsParams option * bannedRights: WriteChatBannedRightsParams option * defaultBannedRights: WriteChatBannedRightsParams option * participantsCount: int32 option * usernames: byte[] array option * storiesMaxId: int32 option * color: byte[] option * profileColor: byte[] option * emojiStatus: byte[] option * level: int32 option * subscriptionUntilDate: int32 option * botVerificationIcon: int64 option * sendPaidMessagesStars: int64 option * linkedMonoforumId: int64 option
    and [<RequireQualifiedAccess>] WriteChatParticipant =
        | ChatParticipant of userId: int64 * inviterId: int64 * date: int32
        | ChatParticipantCreator of userId: int64
        | ChatParticipantAdmin of userId: int64 * inviterId: int64 * date: int32
    and [<RequireQualifiedAccess>] WriteChatPhoto =
        | ChatPhotoEmpty
        | ChatPhoto of hasVideo: bool * photoId: int64 * strippedThumb: byte[] option * dcId: int32
    and [<RequireQualifiedAccess>] WriteEncryptedChat =
        | EncryptedChatEmpty of id: int32
        | EncryptedChatWaiting of id: int32 * accessHash: int64 * date: int32 * adminId: int64 * participantId: int64
        | EncryptedChatRequested of folderId: int32 option * id: int32 * accessHash: int64 * date: int32 * adminId: int64 * participantId: int64 * gA: byte[]
        | EncryptedChat of id: int32 * accessHash: int64 * date: int32 * adminId: int64 * participantId: int64 * gAOrB: byte[] * keyFingerprint: int64
        | EncryptedChatDiscarded of historyDeleted: bool * id: int32
    and [<RequireQualifiedAccess>] WriteEncryptedFile =
        | EncryptedFileEmpty
        | EncryptedFile of id: int64 * accessHash: int64 * size: int64 * dcId: int32 * keyFingerprint: int32
    and [<RequireQualifiedAccess>] WriteEncryptedMessage =
        | EncryptedMessage of randomId: int64 * chatId: int32 * date: int32 * bytes: byte[] * file: WriteEncryptedFile
        | EncryptedMessageService of randomId: int64 * chatId: int32 * date: int32 * bytes: byte[]
    and [<RequireQualifiedAccess>] WriteGroupCall =
        | GroupCallDiscarded of id: int64 * accessHash: int64 * duration: int32
        | GroupCall of joinMuted: bool * canChangeJoinMuted: bool * joinDateAsc: bool * scheduleStartSubscribed: bool * canStartVideo: bool * recordVideoActive: bool * rtmpStream: bool * listenersHidden: bool * conference: bool * creator: bool * id: int64 * accessHash: int64 * participantsCount: int32 * title: string option * streamDcId: int32 option * recordStartDate: int32 option * scheduleDate: int32 option * unmutedVideoCount: int32 option * unmutedVideoLimit: int32 * version: int32 * inviteLink: string option
    and [<RequireQualifiedAccess>] WriteMessageAction =
        /// messageActionEmpty#b6aef7b0
        | MessageActionEmpty
        /// messageActionChatCreate#bd47cbad title:string users:Vector<long>
        | MessageActionChatCreate of title: string * users: int64 array
        /// messageActionChatEditTitle#b5a1ce5a title:string
        | MessageActionChatEditTitle of title: string
        /// messageActionChatEditPhoto#7fcb13a8 photo:Photo (pre-serialized)
        | MessageActionChatEditPhoto of photoBytes: byte[]
        /// messageActionChatDeletePhoto#95e3fbef
        | MessageActionChatDeletePhoto
        /// messageActionChatAddUser#15cefd00 users:Vector<long>
        | MessageActionChatAddUser of users: int64 array
        /// messageActionChatDeleteUser#a43f30cc user_id:long
        | MessageActionChatDeleteUser of userId: int64
        /// messageActionChatJoinedByLink#031224c3 inviter_id:long
        | MessageActionChatJoinedByLink of inviterId: int64
        /// messageActionChannelCreate#95d2ac92 title:string
        | MessageActionChannelCreate of title: string
        /// messageActionPinMessage#94bd38ed
        | MessageActionPinMessage
        /// messageActionHistoryClear#9fbab604
        | MessageActionHistoryClear
        /// messageActionGroupCall#7a0d7f42 flags:# call:InputGroupCall duration:flags.0?int
        | MessageActionGroupCall of callId: int64 * callAccessHash: int64 * duration: int option
        /// messageActionSetMessagesTTL#3c134d7b flags:# period:int auto_setting_from:flags.0?long
        | MessageActionSetMessagesTTL of period: int * autoSettingFrom: int64 option
        /// messageActionPhoneCall#80e11a7f flags:# video:flags.2?true call_id:long reason:flags.0?PhoneCallDiscardReason duration:flags.1?int
        | MessageActionPhoneCall of video: bool * callId: int64 * reason: byte[] option * duration: int option
        /// messageActionChatJoinedByRequest#ebbca3cb
        | MessageActionChatJoinedByRequest
    and WriteMessageServiceParams = {
        out: bool
        mentioned: bool
        mediaUnread: bool
        silent: bool
        post: bool
        legacy: bool
        id: int32
        fromId: WritePeer option
        peerId: WritePeer
        savedPeerId: WritePeer option
        replyTo: WriteMessageReplyHeaderParams option
        date: int32
        action: WriteMessageAction
        ttlPeriod: int32 option
    }
    and [<RequireQualifiedAccess>] WriteMessageMedia =
        | MessageMediaPhoto of spoiler: bool * photo: WritePhotoParams option * ttlSeconds: int32 option
        | MessageMediaDocument of nopremium: bool * spoiler: bool * video: bool * round: bool * voice: bool * document: WriteDocumentParams option * altDocuments: WriteDocumentParams array option * videoCover: WritePhotoParams option * videoTimestamp: int32 option * ttlSeconds: int32 option
        /// messageMediaPoll#4bd6e798 poll:Poll results:PollResults — poll and results are pre-serialized TL bytes
        | MessageMediaPoll of pollBytes: byte[] * resultsBytes: byte[]
        /// messageMediaGeo#56e0d474 geo:GeoPoint
        | MessageMediaGeo of lat: float * lon: float
        /// messageMediaGeoLive#b940c666 flags:# geo:GeoPoint heading:flags.0?int period:int proximity_notification_radius:flags.1?int
        | MessageMediaGeoLive of lat: float * lon: float * heading: int option * period: int * proximityNotificationRadius: int option
        /// messageMediaVenue#2ec0533f geo:GeoPoint title:string address:string provider:string venue_id:string venue_type:string
        | MessageMediaVenue of lat: float * lon: float * title: string * address: string * provider: string * venueId: string * venueType: string
        | MessageMediaWebPage of webPageBytes: byte[]
    and [<RequireQualifiedAccess>] WriteMessagesSentEncryptedMessage =
        | MessagesSentEncryptedMessage of date: int32
        | MessagesSentEncryptedFile of date: int32 * file: WriteEncryptedFile
    and [<RequireQualifiedAccess>] WritePeer =
        | PeerUser of userId: int64
        | PeerChat of chatId: int64
        | PeerChannel of channelId: int64
    and [<RequireQualifiedAccess>] WritePhoneCall =
        | PhoneCallWaiting of video: bool * id: int64 * accessHash: int64 * date: int32 * adminId: int64 * participantId: int64 * protocol: WritePhoneCallProtocolParams * receiveDate: int32 option
        | PhoneCallAccepted of video: bool * id: int64 * accessHash: int64 * date: int32 * adminId: int64 * participantId: int64 * gB: byte[] * protocol: WritePhoneCallProtocolParams
        | PhoneCall of p2pAllowed: bool * video: bool * conferenceSupported: bool * id: int64 * accessHash: int64 * date: int32 * adminId: int64 * participantId: int64 * gAOrB: byte[] * keyFingerprint: int64 * protocol: WritePhoneCallProtocolParams * connections: WritePhoneConnection array * startDate: int32 * customParameters: byte[] option
        | PhoneCallDiscarded of needRating: bool * needDebug: bool * video: bool * id: int64 * reason: byte[] option * duration: int32 option
    and [<RequireQualifiedAccess>] WritePhoneConnection =
        | PhoneConnection of tcp: bool * id: int64 * ip: string * ipv6: string * port: int32 * peerTag: byte[]
        | PhoneConnectionWebrtc of turn: bool * stun: bool * id: int64 * ip: string * ipv6: string * port: int32 * username: string * password: string
    and [<RequireQualifiedAccess>] WriteReaction =
        | ReactionEmoji of emoticon: string
        | ReactionCustomEmoji of documentId: int64
    and [<RequireQualifiedAccess>] WriteUpdate =
        | UpdateNewMessage of message: WriteMessageParams * pts: int32 * ptsCount: int32
        | UpdateMessageID of id: int32 * randomId: int64
        | UpdateDeleteMessages of messages: int32 array * pts: int32 * ptsCount: int32
        | UpdateUserStatus of userId: int64 * status: WriteUserStatus
        | UpdateNewEncryptedMessage of message: WriteEncryptedMessage * qts: int32
        | UpdateEncryptedChatTyping of chatId: int32
        | UpdateEncryption of chat: WriteEncryptedChat * date: int32
        | UpdateReadHistoryInbox of folderId: int32 option * peer: WritePeer * maxId: int32 * stillUnreadCount: int32 * pts: int32 * ptsCount: int32
        | UpdateReadHistoryOutbox of peer: WritePeer * maxId: int32 * pts: int32 * ptsCount: int32
        | UpdateChannel of channelId: int64
        | UpdateNewChannelMessage of message: WriteMessageParams * pts: int32 * ptsCount: int32
        | UpdateReadChannelInbox of folderId: int32 option * channelId: int64 * maxId: int32 * stillUnreadCount: int32 * pts: int32
        | UpdateDeleteChannelMessages of channelId: int64 * messages: int32 array * pts: int32 * ptsCount: int32
        | UpdateEditMessage of message: WriteMessageParams * pts: int32 * ptsCount: int32
        | UpdateReadChannelOutbox of channelId: int64 * maxId: int32
        | UpdateDraftMessage of peer: WritePeer * topMsgId: int32 option * savedPeerId: WritePeer option * draft: WriteDraftMessageParams
        | UpdatePhoneCall of phoneCall: WritePhoneCall
        | UpdateMessagePoll of pollId: int64 * poll: byte[] option * results: WritePollResultsParams
        | UpdatePeerSettings of peer: WritePeer * settings: WritePeerSettingsParams
        | UpdateNewScheduledMessage of message: WriteMessageParams
        | UpdatePinnedMessages of pinned: bool * peer: WritePeer * messages: int32 array * pts: int32 * ptsCount: int32
        | UpdateChat of chatId: int64
        | UpdateGroupCallParticipants of call: WriteInputGroupCallParams * participants: WriteGroupCallParticipantParams array * version: int32
        | UpdateGroupCall of chatId: int64 option * call: WriteGroupCall
        | UpdateMessageReactions of peer: WritePeer * msgId: int32 * topMsgId: int32 option * savedPeerId: WritePeer option * reactions: WriteMessageReactionsParams
        /// updateNewMessage with messageService instead of message
        | UpdateNewServiceMessage of message: WriteMessageServiceParams * pts: int32 * ptsCount: int32
        /// updateNewChannelMessage with messageService instead of message
        | UpdateNewChannelServiceMessage of message: WriteMessageServiceParams * pts: int32 * ptsCount: int32
    and [<RequireQualifiedAccess>] WriteUserStatus =
        | UserStatusOnline of expires: int32
        | UserStatusOffline of wasOnline: int32
        | UserStatusRecently of byMe: bool
    and WriteAuthLoggedOutParams = {
        futureAuthToken: byte[] option
    }
    and WriteAuthSentCodeTypeAppParams = {
        length: int32
    }
    and WriteAuthSentCodeParams = {
        ``type``: WriteAuthSentCodeTypeAppParams
        phoneCodeHash: string
        nextType: byte[] option
        timeout: int32 option
    }
    and WriteAuthorizationParams = {
        current: bool
        officialApp: bool
        passwordPending: bool
        encryptedRequestsDisabled: bool
        callRequestsDisabled: bool
        unconfirmed: bool
        hash: int64
        deviceModel: string
        platform: string
        systemVersion: string
        apiId: int32
        appName: string
        appVersion: string
        dateCreated: int32
        dateActive: int32
        ip: string
        country: string
        region: string
    }
    and WriteChatAdminRightsParams = {
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
    and WriteChatBannedRightsParams = {
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
    and WriteContactParams = {
        userId: int64
        mutual: bool
    }
    and WriteContactStatusParams = {
        userId: int64
        status: WriteUserStatus
    }
    and WriteDcOptionParams = {
        ipv6: bool
        mediaOnly: bool
        tcpoOnly: bool
        cdn: bool
        ``static``: bool
        thisPortOnly: bool
        id: int32
        ipAddress: string
        port: int32
        secret: byte[] option
    }
    and WriteDialogPeerParams = {
        peer: WritePeer
    }
    and WriteDocumentAttributeFilenameParams = {
        fileName: string
    }
    and WriteDraftMessageParams = {
        noWebpage: bool
        invertMedia: bool
        replyTo: byte[] option
        message: string
        entities: byte[] array option
        media: byte[] option
        date: int32
        effect: int64 option
        suggestedPost: byte[] option
    }
    and WriteGroupCallParticipantParams = {
        muted: bool
        left: bool
        canSelfUnmute: bool
        justJoined: bool
        versioned: bool
        min: bool
        mutedByYou: bool
        volumeByAdmin: bool
        self: bool
        videoJoined: bool
        peer: WritePeer
        date: int32
        activeDate: int32 option
        source: int32
        volume: int32 option
        about: string option
        raiseHandRating: int64 option
        video: byte[] option
        presentation: byte[] option
    }
    and WriteImportedContactParams = {
        userId: int64
        clientId: int64
    }
    and WriteInputGroupCallParams = {
        id: int64
        accessHash: int64
    }
    and WriteLangPackLanguageParams = {
        official: bool
        rtl: bool
        beta: bool
        name: string
        nativeName: string
        langCode: string
        baseLangCode: string option
        pluralCode: string
        stringsCount: int32
        translatedCount: int32
        translationsUrl: string
    }
    and WriteMessagePeerReactionParams = {
        big: bool
        unread: bool
        my: bool
        peerId: WritePeer
        date: int32
        reaction: WriteReaction
    }
    and WriteMessageReplyHeaderParams = {
        replyToScheduled: bool
        forumTopic: bool
        quote: bool
        replyToMsgId: int32 option
        replyToPeerId: WritePeer option
        replyFrom: byte[] option
        replyMedia: WriteMessageMedia option
        replyToTopId: int32 option
        quoteText: string option
        quoteEntities: byte[] array option
        quoteOffset: int32 option
        todoItemId: int32 option
    }
    and WriteMessageViewsParams = {
        views: int32 option
        forwards: int32 option
        replies: byte[] option
    }
    and WriteMessagesAffectedHistoryParams = {
        pts: int32
        ptsCount: int32
        offset: int32
    }
    and WriteMessagesAffectedMessagesParams = {
        pts: int32
        ptsCount: int32
    }
    and WritePeerBlockedParams = {
        peerId: WritePeer
        date: int32
    }
    and WritePeerNotifySettingsParams = {
        showPreviews: bool option
        silent: bool option
        muteUntil: int32 option
        iosSound: byte[] option
        androidSound: byte[] option
        otherSound: byte[] option
        storiesMuted: bool option
        storiesHideSender: bool option
        storiesIosSound: byte[] option
        storiesAndroidSound: byte[] option
        storiesOtherSound: byte[] option
    }
    and WriteDialogParams = {
        pinned: bool
        unreadMark: bool
        viewForumAsMessages: bool
        peer: WritePeer
        topMessage: int32
        readInboxMaxId: int32
        readOutboxMaxId: int32
        unreadCount: int32
        unreadMentionsCount: int32
        unreadReactionsCount: int32
        notifySettings: WritePeerNotifySettingsParams
        pts: int32 option
        draft: WriteDraftMessageParams option
        folderId: int32 option
        ttlPeriod: int32 option
    }
    and WriteForumTopicParams = {
        my: bool
        closed: bool
        pinned: bool
        short: bool
        hidden: bool
        id: int32
        date: int32
        title: string
        iconColor: int32
        iconEmojiId: int64 option
        topMessage: int32
        readInboxMaxId: int32
        readOutboxMaxId: int32
        unreadCount: int32
        unreadMentionsCount: int32
        unreadReactionsCount: int32
        fromId: WritePeer
        notifySettings: WritePeerNotifySettingsParams
        draft: WriteDraftMessageParams option
    }
    and WritePeerSettingsParams = {
        reportSpam: bool
        addContact: bool
        blockContact: bool
        shareContact: bool
        needContactsException: bool
        reportGeo: bool
        autoarchived: bool
        inviteMembers: bool
        requestChatBroadcast: bool
        businessBotPaused: bool
        businessBotCanReply: bool
        geoDistance: int32 option
        requestChatTitle: string option
        requestChatDate: int32 option
        businessBotId: int64 option
        businessBotManageUrl: string option
        chargePaidMessageStars: int64 option
        registrationMonth: string option
        phoneCountry: string option
        nameChangeDate: int32 option
        photoChangeDate: int32 option
    }
    and WritePhoneCallProtocolParams = {
        udpP2p: bool
        udpReflector: bool
        minLayer: int32
        maxLayer: int32
        libraryVersions: string array
    }
    and WritePhotoSizeParams = {
        ``type``: string
        w: int32
        h: int32
        size: int32
    }
    and WriteDocumentParams = {
        id: int64
        accessHash: int64
        fileReference: byte[]
        date: int32
        mimeType: string
        size: int64
        thumbs: WritePhotoSizeParams array option
        videoThumbs: byte[] array option
        dcId: int32
        attributes: WriteDocumentAttributeFilenameParams array
    }
    and WritePhotoParams = {
        hasStickers: bool
        id: int64
        accessHash: int64
        fileReference: byte[]
        date: int32
        sizes: WritePhotoSizeParams array
        videoSizes: byte[] array option
        dcId: int32
    }
    and WriteChannelFullParams = {
        canViewParticipants: bool
        canSetUsername: bool
        canSetStickers: bool
        hiddenPrehistory: bool
        canSetLocation: bool
        hasScheduled: bool
        canViewStats: bool
        blocked: bool
        canDeleteChannel: bool
        antispam: bool
        participantsHidden: bool
        translationsDisabled: bool
        storiesPinnedAvailable: bool
        viewForumAsMessages: bool
        restrictedSponsored: bool
        canViewRevenue: bool
        paidMediaAllowed: bool
        canViewStarsRevenue: bool
        paidReactionsAvailable: bool
        stargiftsAvailable: bool
        paidMessagesAvailable: bool
        id: int64
        about: string
        participantsCount: int32 option
        adminsCount: int32 option
        kickedCount: int32 option
        bannedCount: int32 option
        onlineCount: int32 option
        readInboxMaxId: int32
        readOutboxMaxId: int32
        unreadCount: int32
        chatPhoto: WritePhotoParams
        notifySettings: WritePeerNotifySettingsParams
        exportedInvite: byte[] option
        botInfo: byte[] array
        migratedFromChatId: int64 option
        migratedFromMaxId: int32 option
        pinnedMsgId: int32 option
        stickerset: byte[] option
        availableMinId: int32 option
        folderId: int32 option
        linkedChatId: int64 option
        location: byte[] option
        slowmodeSeconds: int32 option
        slowmodeNextSendDate: int32 option
        statsDc: int32 option
        pts: int32
        call: WriteInputGroupCallParams option
        ttlPeriod: int32 option
        pendingSuggestions: string array option
        groupcallDefaultJoinAs: WritePeer option
        themeEmoticon: string option
        requestsPending: int32 option
        recentRequesters: int64 array option
        defaultSendAs: WritePeer option
        availableReactions: byte[] option
        reactionsLimit: int32 option
        stories: byte[] option
        wallpaper: byte[] option
        boostsApplied: int32 option
        boostsUnrestrict: int32 option
        emojiset: byte[] option
        botVerification: byte[] option
        stargiftsCount: int32 option
        sendPaidMessagesStars: int64 option
        mainTab: byte[] option
    }
    and WritePollAnswerVotersParams = {
        chosen: bool
        correct: bool
        option: byte[]
        voters: int32
    }
    and WritePollResultsParams = {
        min: bool
        results: WritePollAnswerVotersParams array option
        totalVoters: int32 option
        recentVoters: WritePeer array option
        solution: string option
        solutionEntities: byte[] array option
    }
    and WriteReactionCountParams = {
        chosenOrder: int32 option
        reaction: WriteReaction
        count: int32
    }
    and WriteMessageReactionsParams = {
        min: bool
        canSeeList: bool
        reactionsAsTags: bool
        results: WriteReactionCountParams array
        recentReactions: WriteMessagePeerReactionParams array option
        topReactors: byte[] array option
    }
    and WriteMessageParams = {
        out: bool
        mentioned: bool
        mediaUnread: bool
        silent: bool
        post: bool
        fromScheduled: bool
        legacy: bool
        editHide: bool
        pinned: bool
        noforwards: bool
        invertMedia: bool
        offline: bool
        videoProcessingPending: bool
        paidSuggestedPostStars: bool
        paidSuggestedPostTon: bool
        id: int32
        fromId: WritePeer option
        fromBoostsApplied: int32 option
        peerId: WritePeer
        savedPeerId: WritePeer option
        fwdFrom: byte[] option
        viaBotId: int64 option
        viaBusinessBotId: int64 option
        replyTo: WriteMessageReplyHeaderParams option
        date: int32
        message: string
        media: WriteMessageMedia option
        replyMarkup: byte[] option
        entities: byte[] array option
        views: int32 option
        forwards: int32 option
        replies: byte[] option
        editDate: int32 option
        postAuthor: string option
        groupedId: int64 option
        reactions: WriteMessageReactionsParams option
        restrictionReason: byte[] array option
        ttlPeriod: int32 option
        quickReplyShortcutId: int32 option
        effect: int64 option
        factcheck: byte[] option
        reportDeliveryUntilDate: int32 option
        paidMessageStars: int64 option
        suggestedPost: byte[] option
    }
    and WriteStoriesStealthModeParams = {
        activeUntilDate: int32 option
        cooldownUntilDate: int32 option
    }
    and WriteUpdateShortSentMessageParams = {
        out: bool
        id: int32
        pts: int32
        ptsCount: int32
        date: int32
        media: WriteMessageMedia option
        entities: byte[] array option
        ttlPeriod: int32 option
    }
    and WriteUpdatesDifferenceEmptyParams = {
        date: int32
        seq: int32
    }
    and WriteUpdatesStateParams = {
        pts: int32
        qts: int32
        date: int32
        seq: int32
        unreadCount: int32
    }
    and WriteUserProfilePhotoParams = {
        hasVideo: bool
        personal: bool
        photoId: int64
        strippedThumb: byte[] option
        dcId: int32
    }
    and WriteUserParams = {
        self: bool
        contact: bool
        mutualContact: bool
        deleted: bool
        bot: bool
        botChatHistory: bool
        botNochats: bool
        verified: bool
        restricted: bool
        min: bool
        botInlineGeo: bool
        support: bool
        scam: bool
        applyMinPhoto: bool
        fake: bool
        botAttachMenu: bool
        premium: bool
        attachMenuEnabled: bool
        botCanEdit: bool
        closeFriend: bool
        storiesHidden: bool
        storiesUnavailable: bool
        contactRequirePremium: bool
        botBusiness: bool
        botHasMainApp: bool
        botForumView: bool
        botForumCanManageTopics: bool
        id: int64
        accessHash: int64 option
        firstName: string option
        lastName: string option
        username: string option
        phone: string option
        photo: WriteUserProfilePhotoParams option
        status: WriteUserStatus option
        botInfoVersion: int32 option
        restrictionReason: byte[] array option
        botInlinePlaceholder: string option
        langCode: string option
        emojiStatus: byte[] option
        usernames: byte[] array option
        storiesMaxId: int32 option
        color: byte[] option
        profileColor: byte[] option
        botActiveUsers: int32 option
        botVerificationIcon: int64 option
        sendPaidMessagesStars: int64 option
    }
    and WriteAuthAuthorizationParams = {
        setupPasswordRequired: bool
        otherwiseReloginDays: int32 option
        tmpSessions: int32 option
        futureAuthToken: byte[] option
        user: WriteUserParams
    }

    let rec writeChannelParticipant (w: TlWriteBuffer) (p: WriteChannelParticipant) =
        match p with
        | WriteChannelParticipant.ChannelParticipant(userId, date, subscriptionUntilDate) ->
            w.WriteConstructorId(0xCB397619u)
            let mutable flags = 0
            if subscriptionUntilDate.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            w.WriteInt64(userId)
            w.WriteInt32(date)
            subscriptionUntilDate |> Option.iter (fun v -> w.WriteInt32(v))
        | WriteChannelParticipant.ChannelParticipantCreator(userId, adminRights, rank) ->
            w.WriteConstructorId(0x2FE601D3u)
            let mutable flags = 0
            if rank.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            w.WriteInt64(userId)
            writeChatAdminRights w adminRights
            rank |> Option.iter (fun v -> w.WriteString(v))
        | WriteChannelParticipant.ChannelParticipantAdmin(canEdit, self, userId, inviterId, promotedBy, date, adminRights, rank) ->
            w.WriteConstructorId(0x34C3BB53u)
            let mutable flags = 0
            if canEdit then flags <- flags ||| (1 <<< 0)
            if self then flags <- flags ||| (1 <<< 1)
            if inviterId.IsSome then flags <- flags ||| (1 <<< 1)
            if rank.IsSome then flags <- flags ||| (1 <<< 2)
            w.WriteInt32(flags)
            w.WriteInt64(userId)
            inviterId |> Option.iter (fun v -> w.WriteInt64(v))
            w.WriteInt64(promotedBy)
            w.WriteInt32(date)
            writeChatAdminRights w adminRights
            rank |> Option.iter (fun v -> w.WriteString(v))

    and writeChat (w: TlWriteBuffer) (layer: int) (p: WriteChat) =
        match p with
        | WriteChat.Chat(creator, left, deactivated, callActive, callNotEmpty, noforwards, id, title, photo, participantsCount, date, version, migratedTo, adminRights, defaultBannedRights) ->
            w.WriteConstructorId(0x41CBF256u)
            let mutable flags = 0
            if creator then flags <- flags ||| (1 <<< 0)
            if left then flags <- flags ||| (1 <<< 2)
            if deactivated then flags <- flags ||| (1 <<< 5)
            if callActive then flags <- flags ||| (1 <<< 23)
            if callNotEmpty then flags <- flags ||| (1 <<< 24)
            if noforwards then flags <- flags ||| (1 <<< 25)
            if migratedTo.IsSome then flags <- flags ||| (1 <<< 6)
            if adminRights.IsSome then flags <- flags ||| (1 <<< 14)
            if defaultBannedRights.IsSome then flags <- flags ||| (1 <<< 18)
            w.WriteInt32(flags)
            w.WriteInt64(id)
            w.WriteString(title)
            writeChatPhoto w photo
            w.WriteInt32(participantsCount)
            w.WriteInt32(date)
            w.WriteInt32(version)
            migratedTo |> Option.iter (fun v -> w.WriteBytes(v))
            adminRights |> Option.iter (fun v -> writeChatAdminRights w v)
            defaultBannedRights |> Option.iter (fun v -> writeChatBannedRights w v)
        | WriteChat.Channel(creator, left, broadcast, verified, megagroup, restricted, signatures, min, scam, hasLink, hasGeo, slowmodeEnabled, callActive, callNotEmpty, fake, gigagroup, noforwards, joinToSend, joinRequest, forum, storiesHidden, storiesHiddenMin, storiesUnavailable, signatureProfiles, autotranslation, broadcastMessagesAllowed, monoforum, forumTabs, id, accessHash, title, username, photo, date, restrictionReason, adminRights, bannedRights, defaultBannedRights, participantsCount, usernames, storiesMaxId, color, profileColor, emojiStatus, level, subscriptionUntilDate, botVerificationIcon, sendPaidMessagesStars, linkedMonoforumId) ->
            w.WriteConstructorId(GeneratedLayerCid.channel layer)
            let mutable flags = 0
            if creator then flags <- flags ||| (1 <<< 0)
            if left then flags <- flags ||| (1 <<< 2)
            if broadcast then flags <- flags ||| (1 <<< 5)
            if verified then flags <- flags ||| (1 <<< 7)
            if megagroup then flags <- flags ||| (1 <<< 8)
            if restricted then flags <- flags ||| (1 <<< 9)
            if signatures then flags <- flags ||| (1 <<< 11)
            if min then flags <- flags ||| (1 <<< 12)
            if scam then flags <- flags ||| (1 <<< 19)
            if hasLink then flags <- flags ||| (1 <<< 20)
            if hasGeo then flags <- flags ||| (1 <<< 21)
            if slowmodeEnabled then flags <- flags ||| (1 <<< 22)
            if callActive then flags <- flags ||| (1 <<< 23)
            if callNotEmpty then flags <- flags ||| (1 <<< 24)
            if fake then flags <- flags ||| (1 <<< 25)
            if gigagroup then flags <- flags ||| (1 <<< 26)
            if noforwards then flags <- flags ||| (1 <<< 27)
            if joinToSend then flags <- flags ||| (1 <<< 28)
            if joinRequest then flags <- flags ||| (1 <<< 29)
            if forum then flags <- flags ||| (1 <<< 30)
            if accessHash.IsSome then flags <- flags ||| (1 <<< 13)
            if username.IsSome then flags <- flags ||| (1 <<< 6)
            if restrictionReason.IsSome then flags <- flags ||| (1 <<< 9)
            if adminRights.IsSome then flags <- flags ||| (1 <<< 14)
            if bannedRights.IsSome then flags <- flags ||| (1 <<< 15)
            if defaultBannedRights.IsSome then flags <- flags ||| (1 <<< 18)
            if participantsCount.IsSome then flags <- flags ||| (1 <<< 17)
            w.WriteInt32(flags)
            let mutable flags2 = 0
            if storiesHidden then flags2 <- flags2 ||| (1 <<< 1)
            if storiesHiddenMin then flags2 <- flags2 ||| (1 <<< 2)
            if storiesUnavailable then flags2 <- flags2 ||| (1 <<< 3)
            if signatureProfiles then flags2 <- flags2 ||| (1 <<< 12)
            if autotranslation then flags2 <- flags2 ||| (1 <<< 15)
            if broadcastMessagesAllowed then flags2 <- flags2 ||| (1 <<< 16)
            if monoforum then flags2 <- flags2 ||| (1 <<< 17)
            if forumTabs then flags2 <- flags2 ||| (1 <<< 19)
            if usernames.IsSome then flags2 <- flags2 ||| (1 <<< 0)
            if storiesMaxId.IsSome then flags2 <- flags2 ||| (1 <<< 4)
            if color.IsSome then flags2 <- flags2 ||| (1 <<< 7)
            if profileColor.IsSome then flags2 <- flags2 ||| (1 <<< 8)
            if emojiStatus.IsSome then flags2 <- flags2 ||| (1 <<< 9)
            if level.IsSome then flags2 <- flags2 ||| (1 <<< 10)
            if subscriptionUntilDate.IsSome then flags2 <- flags2 ||| (1 <<< 11)
            if botVerificationIcon.IsSome then flags2 <- flags2 ||| (1 <<< 13)
            if sendPaidMessagesStars.IsSome then flags2 <- flags2 ||| (1 <<< 14)
            if linkedMonoforumId.IsSome then flags2 <- flags2 ||| (1 <<< 18)
            w.WriteInt32(flags2)
            w.WriteInt64(id)
            accessHash |> Option.iter (fun v -> w.WriteInt64(v))
            w.WriteString(title)
            username |> Option.iter (fun v -> w.WriteString(v))
            writeChatPhoto w photo
            w.WriteInt32(date)
            match restrictionReason with
            | Some arr ->
                w.WriteConstructorId(0x1CB5C415u)
                w.WriteInt32(arr.Length)
                for item in arr do w.WriteBytes(item)
            | None -> ()
            adminRights |> Option.iter (fun v -> writeChatAdminRights w v)
            bannedRights |> Option.iter (fun v -> writeChatBannedRights w v)
            defaultBannedRights |> Option.iter (fun v -> writeChatBannedRights w v)
            participantsCount |> Option.iter (fun v -> w.WriteInt32(v))
            match usernames with
            | Some arr ->
                w.WriteConstructorId(0x1CB5C415u)
                w.WriteInt32(arr.Length)
                for item in arr do w.WriteBytes(item)
            | None -> ()
            storiesMaxId |> Option.iter (fun v -> w.WriteInt32(v))
            color |> Option.iter (fun v -> w.WriteBytes(v))
            profileColor |> Option.iter (fun v -> w.WriteBytes(v))
            emojiStatus |> Option.iter (fun v -> w.WriteBytes(v))
            level |> Option.iter (fun v -> w.WriteInt32(v))
            subscriptionUntilDate |> Option.iter (fun v -> w.WriteInt32(v))
            botVerificationIcon |> Option.iter (fun v -> w.WriteInt64(v))
            sendPaidMessagesStars |> Option.iter (fun v -> w.WriteInt64(v))
            linkedMonoforumId |> Option.iter (fun v -> w.WriteInt64(v))

    and writeChatParticipant (w: TlWriteBuffer) (p: WriteChatParticipant) =
        match p with
        | WriteChatParticipant.ChatParticipant(userId, inviterId, date) ->
            w.WriteConstructorId(0xC02D4007u)
            w.WriteInt64(userId)
            w.WriteInt64(inviterId)
            w.WriteInt32(date)
        | WriteChatParticipant.ChatParticipantCreator(userId) ->
            w.WriteConstructorId(0xE46BCEE4u)
            w.WriteInt64(userId)
        | WriteChatParticipant.ChatParticipantAdmin(userId, inviterId, date) ->
            w.WriteConstructorId(0xA0933F5Bu)
            w.WriteInt64(userId)
            w.WriteInt64(inviterId)
            w.WriteInt32(date)

    and writeChatPhoto (w: TlWriteBuffer) (p: WriteChatPhoto) =
        match p with
        | WriteChatPhoto.ChatPhotoEmpty ->
            w.WriteConstructorId(0x37C1011Cu)
        | WriteChatPhoto.ChatPhoto(hasVideo, photoId, strippedThumb, dcId) ->
            w.WriteConstructorId(0x1C6E1C11u)
            let mutable flags = 0
            if hasVideo then flags <- flags ||| (1 <<< 0)
            if strippedThumb.IsSome then flags <- flags ||| (1 <<< 1)
            w.WriteInt32(flags)
            w.WriteInt64(photoId)
            strippedThumb |> Option.iter (fun v -> w.WriteBytes(v))
            w.WriteInt32(dcId)

    and writeEncryptedChat (w: TlWriteBuffer) (p: WriteEncryptedChat) =
        match p with
        | WriteEncryptedChat.EncryptedChatEmpty(id) ->
            w.WriteConstructorId(0xAB7EC0A0u)
            w.WriteInt32(id)
        | WriteEncryptedChat.EncryptedChatWaiting(id, accessHash, date, adminId, participantId) ->
            w.WriteConstructorId(0x66B25953u)
            w.WriteInt32(id)
            w.WriteInt64(accessHash)
            w.WriteInt32(date)
            w.WriteInt64(adminId)
            w.WriteInt64(participantId)
        | WriteEncryptedChat.EncryptedChatRequested(folderId, id, accessHash, date, adminId, participantId, gA) ->
            w.WriteConstructorId(0x48F1D94Cu)
            let mutable flags = 0
            if folderId.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            folderId |> Option.iter (fun v -> w.WriteInt32(v))
            w.WriteInt32(id)
            w.WriteInt64(accessHash)
            w.WriteInt32(date)
            w.WriteInt64(adminId)
            w.WriteInt64(participantId)
            w.WriteBytes(gA)
        | WriteEncryptedChat.EncryptedChat(id, accessHash, date, adminId, participantId, gAOrB, keyFingerprint) ->
            w.WriteConstructorId(0x61F0D4C7u)
            w.WriteInt32(id)
            w.WriteInt64(accessHash)
            w.WriteInt32(date)
            w.WriteInt64(adminId)
            w.WriteInt64(participantId)
            w.WriteBytes(gAOrB)
            w.WriteInt64(keyFingerprint)
        | WriteEncryptedChat.EncryptedChatDiscarded(historyDeleted, id) ->
            w.WriteConstructorId(0x1E1C7C45u)
            let mutable flags = 0
            if historyDeleted then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            w.WriteInt32(id)

    and writeEncryptedFile (w: TlWriteBuffer) (p: WriteEncryptedFile) =
        match p with
        | WriteEncryptedFile.EncryptedFileEmpty ->
            w.WriteConstructorId(0xC21F497Eu)
        | WriteEncryptedFile.EncryptedFile(id, accessHash, size, dcId, keyFingerprint) ->
            w.WriteConstructorId(0xA8008CD8u)
            w.WriteInt64(id)
            w.WriteInt64(accessHash)
            w.WriteInt64(size)
            w.WriteInt32(dcId)
            w.WriteInt32(keyFingerprint)

    and writeEncryptedMessage (w: TlWriteBuffer) (p: WriteEncryptedMessage) =
        match p with
        | WriteEncryptedMessage.EncryptedMessage(randomId, chatId, date, bytes, file) ->
            w.WriteConstructorId(0xED18C118u)
            w.WriteInt64(randomId)
            w.WriteInt32(chatId)
            w.WriteInt32(date)
            w.WriteBytes(bytes)
            writeEncryptedFile w file
        | WriteEncryptedMessage.EncryptedMessageService(randomId, chatId, date, bytes) ->
            w.WriteConstructorId(0x23734B06u)
            w.WriteInt64(randomId)
            w.WriteInt32(chatId)
            w.WriteInt32(date)
            w.WriteBytes(bytes)

    and writeGroupCall (w: TlWriteBuffer) (p: WriteGroupCall) =
        match p with
        | WriteGroupCall.GroupCallDiscarded(id, accessHash, duration) ->
            w.WriteConstructorId(0x7780BCB4u)
            w.WriteInt64(id)
            w.WriteInt64(accessHash)
            w.WriteInt32(duration)
        | WriteGroupCall.GroupCall(joinMuted, canChangeJoinMuted, joinDateAsc, scheduleStartSubscribed, canStartVideo, recordVideoActive, rtmpStream, listenersHidden, conference, creator, id, accessHash, participantsCount, title, streamDcId, recordStartDate, scheduleDate, unmutedVideoCount, unmutedVideoLimit, version, inviteLink) ->
            w.WriteConstructorId(0x553B0BA1u)
            let mutable flags = 0
            if joinMuted then flags <- flags ||| (1 <<< 1)
            if canChangeJoinMuted then flags <- flags ||| (1 <<< 2)
            if joinDateAsc then flags <- flags ||| (1 <<< 6)
            if scheduleStartSubscribed then flags <- flags ||| (1 <<< 8)
            if canStartVideo then flags <- flags ||| (1 <<< 9)
            if recordVideoActive then flags <- flags ||| (1 <<< 11)
            if rtmpStream then flags <- flags ||| (1 <<< 12)
            if listenersHidden then flags <- flags ||| (1 <<< 13)
            if conference then flags <- flags ||| (1 <<< 14)
            if creator then flags <- flags ||| (1 <<< 15)
            if title.IsSome then flags <- flags ||| (1 <<< 3)
            if streamDcId.IsSome then flags <- flags ||| (1 <<< 4)
            if recordStartDate.IsSome then flags <- flags ||| (1 <<< 5)
            if scheduleDate.IsSome then flags <- flags ||| (1 <<< 7)
            if unmutedVideoCount.IsSome then flags <- flags ||| (1 <<< 10)
            if inviteLink.IsSome then flags <- flags ||| (1 <<< 16)
            w.WriteInt32(flags)
            w.WriteInt64(id)
            w.WriteInt64(accessHash)
            w.WriteInt32(participantsCount)
            title |> Option.iter (fun v -> w.WriteString(v))
            streamDcId |> Option.iter (fun v -> w.WriteInt32(v))
            recordStartDate |> Option.iter (fun v -> w.WriteInt32(v))
            scheduleDate |> Option.iter (fun v -> w.WriteInt32(v))
            unmutedVideoCount |> Option.iter (fun v -> w.WriteInt32(v))
            w.WriteInt32(unmutedVideoLimit)
            w.WriteInt32(version)
            inviteLink |> Option.iter (fun v -> w.WriteString(v))

    and writeMessageMedia (w: TlWriteBuffer) (layer: int) (p: WriteMessageMedia) =
        match p with
        | WriteMessageMedia.MessageMediaPhoto(spoiler, photo, ttlSeconds) ->
            w.WriteConstructorId(0x695150D7u)
            let mutable flags = 0
            if spoiler then flags <- flags ||| (1 <<< 3)
            if photo.IsSome then flags <- flags ||| (1 <<< 0)
            if ttlSeconds.IsSome then flags <- flags ||| (1 <<< 2)
            w.WriteInt32(flags)
            photo |> Option.iter (fun v -> writePhoto w v)
            ttlSeconds |> Option.iter (fun v -> w.WriteInt32(v))
        | WriteMessageMedia.MessageMediaDocument(nopremium, spoiler, video, round, voice, document, altDocuments, videoCover, videoTimestamp, ttlSeconds) ->
            w.WriteConstructorId(GeneratedLayerCid.messageMediaDocument layer)
            let mutable flags = 0
            if nopremium then flags <- flags ||| (1 <<< 3)
            if spoiler then flags <- flags ||| (1 <<< 4)
            if video then flags <- flags ||| (1 <<< 6)
            if round then flags <- flags ||| (1 <<< 7)
            if voice then flags <- flags ||| (1 <<< 8)
            if document.IsSome then flags <- flags ||| (1 <<< 0)
            if altDocuments.IsSome then flags <- flags ||| (1 <<< 5)
            if videoCover.IsSome then flags <- flags ||| (1 <<< 9)
            if videoTimestamp.IsSome then flags <- flags ||| (1 <<< 10)
            if ttlSeconds.IsSome then flags <- flags ||| (1 <<< 2)
            w.WriteInt32(flags)
            document |> Option.iter (fun v -> writeDocument w v)
            match altDocuments with
            | Some arr ->
                w.WriteConstructorId(0x1CB5C415u)
                w.WriteInt32(arr.Length)
                for item in arr do writeDocument w item
            | None -> ()
            videoCover |> Option.iter (fun v -> writePhoto w v)
            videoTimestamp |> Option.iter (fun v -> w.WriteInt32(v))
            ttlSeconds |> Option.iter (fun v -> w.WriteInt32(v))
        | WriteMessageMedia.MessageMediaPoll(pollBytes, resultsBytes) ->
            w.WriteConstructorId(0x4BD6E798u) // messageMediaPoll
            w.WriteRawBytes(pollBytes)
            w.WriteRawBytes(resultsBytes)
        | WriteMessageMedia.MessageMediaGeo(lat, lon) ->
            w.WriteConstructorId(0x56E0D474u) // messageMediaGeo
            // geoPoint#b2a2f663 flags:# long:double lat:double access_hash:long accuracy_radius:flags.0?int
            w.WriteConstructorId(0xB2A2F663u)
            let flags = 0
            w.WriteInt32(flags)
            w.WriteDouble(lon)
            w.WriteDouble(lat)
            w.WriteInt64(0L) // access_hash
        | WriteMessageMedia.MessageMediaGeoLive(lat, lon, heading, period, proximityNotificationRadius) ->
            w.WriteConstructorId(0xB940C666u) // messageMediaGeoLive
            let mutable flags = 0
            if heading.IsSome then flags <- flags ||| (1 <<< 0)
            if proximityNotificationRadius.IsSome then flags <- flags ||| (1 <<< 1)
            w.WriteInt32(flags)
            // geoPoint#b2a2f663
            w.WriteConstructorId(0xB2A2F663u)
            w.WriteInt32(0) // geo flags
            w.WriteDouble(lon)
            w.WriteDouble(lat)
            w.WriteInt64(0L) // access_hash
            heading |> Option.iter (fun v -> w.WriteInt32(v))
            w.WriteInt32(period)
            proximityNotificationRadius |> Option.iter (fun v -> w.WriteInt32(v))
        | WriteMessageMedia.MessageMediaVenue(lat, lon, title, address, provider, venueId, venueType) ->
            w.WriteConstructorId(0x2EC0533Fu) // messageMediaVenue
            // geoPoint#b2a2f663
            w.WriteConstructorId(0xB2A2F663u)
            w.WriteInt32(0) // geo flags
            w.WriteDouble(lon)
            w.WriteDouble(lat)
            w.WriteInt64(0L) // access_hash
            w.WriteString(title)
            w.WriteString(address)
            w.WriteString(provider)
            w.WriteString(venueId)
            w.WriteString(venueType)
        | WriteMessageMedia.MessageMediaWebPage(webPageBytes) ->
            w.WriteConstructorId(0xDDF10C3Bu) // messageMediaWebPage
            w.WriteInt32(0) // flags
            w.WriteRawBytes(webPageBytes)

    and writeMessagesSentEncryptedMessage (w: TlWriteBuffer) (p: WriteMessagesSentEncryptedMessage) =
        match p with
        | WriteMessagesSentEncryptedMessage.MessagesSentEncryptedMessage(date) ->
            w.WriteConstructorId(0x560F8935u)
            w.WriteInt32(date)
        | WriteMessagesSentEncryptedMessage.MessagesSentEncryptedFile(date, file) ->
            w.WriteConstructorId(0x9493FF32u)
            w.WriteInt32(date)
            writeEncryptedFile w file

    and writePeer (w: TlWriteBuffer) (p: WritePeer) =
        match p with
        | WritePeer.PeerUser(userId) ->
            w.WriteConstructorId(0x59511722u)
            w.WriteInt64(userId)
        | WritePeer.PeerChat(chatId) ->
            w.WriteConstructorId(0x36C6019Au)
            w.WriteInt64(chatId)
        | WritePeer.PeerChannel(channelId) ->
            w.WriteConstructorId(0xA2A5371Eu)
            w.WriteInt64(channelId)

    and writePhoneCall (w: TlWriteBuffer) (p: WritePhoneCall) =
        match p with
        | WritePhoneCall.PhoneCallWaiting(video, id, accessHash, date, adminId, participantId, protocol, receiveDate) ->
            w.WriteConstructorId(0xC5226F17u)
            let mutable flags = 0
            if video then flags <- flags ||| (1 <<< 6)
            if receiveDate.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            w.WriteInt64(id)
            w.WriteInt64(accessHash)
            w.WriteInt32(date)
            w.WriteInt64(adminId)
            w.WriteInt64(participantId)
            writePhoneCallProtocol w protocol
            receiveDate |> Option.iter (fun v -> w.WriteInt32(v))
        | WritePhoneCall.PhoneCallAccepted(video, id, accessHash, date, adminId, participantId, gB, protocol) ->
            w.WriteConstructorId(0x3660C311u)
            let mutable flags = 0
            if video then flags <- flags ||| (1 <<< 6)
            w.WriteInt32(flags)
            w.WriteInt64(id)
            w.WriteInt64(accessHash)
            w.WriteInt32(date)
            w.WriteInt64(adminId)
            w.WriteInt64(participantId)
            w.WriteBytes(gB)
            writePhoneCallProtocol w protocol
        | WritePhoneCall.PhoneCall(p2pAllowed, video, conferenceSupported, id, accessHash, date, adminId, participantId, gAOrB, keyFingerprint, protocol, connections, startDate, customParameters) ->
            w.WriteConstructorId(0x30535AF5u)
            let mutable flags = 0
            if p2pAllowed then flags <- flags ||| (1 <<< 5)
            if video then flags <- flags ||| (1 <<< 6)
            if conferenceSupported then flags <- flags ||| (1 <<< 8)
            if customParameters.IsSome then flags <- flags ||| (1 <<< 7)
            w.WriteInt32(flags)
            w.WriteInt64(id)
            w.WriteInt64(accessHash)
            w.WriteInt32(date)
            w.WriteInt64(adminId)
            w.WriteInt64(participantId)
            w.WriteBytes(gAOrB)
            w.WriteInt64(keyFingerprint)
            writePhoneCallProtocol w protocol
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(connections.Length)
            for item in connections do writePhoneConnection w item
            w.WriteInt32(startDate)
            customParameters |> Option.iter (fun v -> w.WriteBytes(v))
        | WritePhoneCall.PhoneCallDiscarded(needRating, needDebug, video, id, reason, duration) ->
            w.WriteConstructorId(0x50CA4DE1u)
            let mutable flags = 0
            if needRating then flags <- flags ||| (1 <<< 2)
            if needDebug then flags <- flags ||| (1 <<< 3)
            if video then flags <- flags ||| (1 <<< 6)
            if reason.IsSome then flags <- flags ||| (1 <<< 0)
            if duration.IsSome then flags <- flags ||| (1 <<< 1)
            w.WriteInt32(flags)
            w.WriteInt64(id)
            reason |> Option.iter (fun v -> w.WriteBytes(v))
            duration |> Option.iter (fun v -> w.WriteInt32(v))

    and writePhoneConnection (w: TlWriteBuffer) (p: WritePhoneConnection) =
        match p with
        | WritePhoneConnection.PhoneConnection(tcp, id, ip, ipv6, port, peerTag) ->
            w.WriteConstructorId(0x9CC123C7u)
            let mutable flags = 0
            if tcp then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            w.WriteInt64(id)
            w.WriteString(ip)
            w.WriteString(ipv6)
            w.WriteInt32(port)
            w.WriteBytes(peerTag)
        | WritePhoneConnection.PhoneConnectionWebrtc(turn, stun, id, ip, ipv6, port, username, password) ->
            w.WriteConstructorId(0x635FE375u)
            let mutable flags = 0
            if turn then flags <- flags ||| (1 <<< 0)
            if stun then flags <- flags ||| (1 <<< 1)
            w.WriteInt32(flags)
            w.WriteInt64(id)
            w.WriteString(ip)
            w.WriteString(ipv6)
            w.WriteInt32(port)
            w.WriteString(username)
            w.WriteString(password)

    and writeReaction (w: TlWriteBuffer) (p: WriteReaction) =
        match p with
        | WriteReaction.ReactionEmoji(emoticon) ->
            w.WriteConstructorId(0x1B2286B8u)
            w.WriteString(emoticon)
        | WriteReaction.ReactionCustomEmoji(documentId) ->
            w.WriteConstructorId(0x8935FC73u)
            w.WriteInt64(documentId)

    and writeUpdate (w: TlWriteBuffer) (layer: int) (p: WriteUpdate) =
        match p with
        | WriteUpdate.UpdateNewMessage(message, pts, ptsCount) ->
            w.WriteConstructorId(0x1F2B0AFDu)
            writeMessage w layer message
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)
        | WriteUpdate.UpdateMessageID(id, randomId) ->
            w.WriteConstructorId(0x4E90BFD6u)
            w.WriteInt32(id)
            w.WriteInt64(randomId)
        | WriteUpdate.UpdateDeleteMessages(messages, pts, ptsCount) ->
            w.WriteConstructorId(0xA20DB0E5u)
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(messages.Length)
            for item in messages do w.WriteInt32(item)
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)
        | WriteUpdate.UpdateUserStatus(userId, status) ->
            w.WriteConstructorId(0xE5BDF8DEu)
            w.WriteInt64(userId)
            writeUserStatus w status
        | WriteUpdate.UpdateNewEncryptedMessage(message, qts) ->
            w.WriteConstructorId(0x12BCBD9Au)
            writeEncryptedMessage w message
            w.WriteInt32(qts)
        | WriteUpdate.UpdateEncryptedChatTyping(chatId) ->
            w.WriteConstructorId(0x1710F156u)
            w.WriteInt32(chatId)
        | WriteUpdate.UpdateEncryption(chat, date) ->
            w.WriteConstructorId(0xB4A2E88Du)
            writeEncryptedChat w chat
            w.WriteInt32(date)
        | WriteUpdate.UpdateReadHistoryInbox(folderId, peer, maxId, stillUnreadCount, pts, ptsCount) ->
            w.WriteConstructorId(0x9C974FDFu)
            let mutable flags = 0
            if folderId.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            folderId |> Option.iter (fun v -> w.WriteInt32(v))
            writePeer w peer
            w.WriteInt32(maxId)
            w.WriteInt32(stillUnreadCount)
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)
        | WriteUpdate.UpdateReadHistoryOutbox(peer, maxId, pts, ptsCount) ->
            w.WriteConstructorId(0x2F2F21BFu)
            writePeer w peer
            w.WriteInt32(maxId)
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)
        | WriteUpdate.UpdateChannel(channelId) ->
            w.WriteConstructorId(0x635B4C09u)
            w.WriteInt64(channelId)
        | WriteUpdate.UpdateNewChannelMessage(message, pts, ptsCount) ->
            w.WriteConstructorId(0x62BA04D9u)
            writeMessage w layer message
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)
        | WriteUpdate.UpdateReadChannelInbox(folderId, channelId, maxId, stillUnreadCount, pts) ->
            w.WriteConstructorId(0x922E6E10u)
            let mutable flags = 0
            if folderId.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            folderId |> Option.iter (fun v -> w.WriteInt32(v))
            w.WriteInt64(channelId)
            w.WriteInt32(maxId)
            w.WriteInt32(stillUnreadCount)
            w.WriteInt32(pts)
        | WriteUpdate.UpdateDeleteChannelMessages(channelId, messages, pts, ptsCount) ->
            w.WriteConstructorId(0xC32D5B12u)
            w.WriteInt64(channelId)
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(messages.Length)
            for item in messages do w.WriteInt32(item)
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)
        | WriteUpdate.UpdateEditMessage(message, pts, ptsCount) ->
            w.WriteConstructorId(0xE40370A3u)
            writeMessage w layer message
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)
        | WriteUpdate.UpdateReadChannelOutbox(channelId, maxId) ->
            w.WriteConstructorId(0xB75F99A9u)
            w.WriteInt64(channelId)
            w.WriteInt32(maxId)
        | WriteUpdate.UpdateDraftMessage(peer, topMsgId, savedPeerId, draft) ->
            w.WriteConstructorId(0xEDFC111Eu)
            let mutable flags = 0
            if topMsgId.IsSome then flags <- flags ||| (1 <<< 0)
            if savedPeerId.IsSome then flags <- flags ||| (1 <<< 1)
            w.WriteInt32(flags)
            writePeer w peer
            topMsgId |> Option.iter (fun v -> w.WriteInt32(v))
            savedPeerId |> Option.iter (fun v -> writePeer w v)
            writeDraftMessage w draft
        | WriteUpdate.UpdatePhoneCall(phoneCall) ->
            w.WriteConstructorId(0xAB0F6B1Eu)
            writePhoneCall w phoneCall
        | WriteUpdate.UpdateMessagePoll(pollId, poll, results) ->
            w.WriteConstructorId(0xACA1657Bu)
            let mutable flags = 0
            if poll.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            w.WriteInt64(pollId)
            poll |> Option.iter (fun v -> w.WriteBytes(v))
            writePollResults w results
        | WriteUpdate.UpdatePeerSettings(peer, settings) ->
            w.WriteConstructorId(0x6A7E7366u)
            writePeer w peer
            writePeerSettings w settings
        | WriteUpdate.UpdateNewScheduledMessage(message) ->
            w.WriteConstructorId(0x39A51DFBu)
            writeMessage w layer message
        | WriteUpdate.UpdatePinnedMessages(pinned, peer, messages, pts, ptsCount) ->
            w.WriteConstructorId(0xED85EAB5u)
            let mutable flags = 0
            if pinned then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            writePeer w peer
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(messages.Length)
            for item in messages do w.WriteInt32(item)
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)
        | WriteUpdate.UpdateChat(chatId) ->
            w.WriteConstructorId(0xF89A6A4Eu)
            w.WriteInt64(chatId)
        | WriteUpdate.UpdateGroupCallParticipants(call, participants, version) ->
            w.WriteConstructorId(0xF2EBDB4Eu)
            writeInputGroupCall w call
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(participants.Length)
            for item in participants do writeGroupCallParticipant w item
            w.WriteInt32(version)
        | WriteUpdate.UpdateGroupCall(chatId, call) ->
            w.WriteConstructorId(0x97D64341u)
            let mutable flags = 0
            if chatId.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            chatId |> Option.iter (fun v -> w.WriteInt64(v))
            writeGroupCall w call
        | WriteUpdate.UpdateMessageReactions(peer, msgId, topMsgId, savedPeerId, reactions) ->
            w.WriteConstructorId(0x1E297BFAu)
            let mutable flags = 0
            if topMsgId.IsSome then flags <- flags ||| (1 <<< 0)
            if savedPeerId.IsSome then flags <- flags ||| (1 <<< 1)
            w.WriteInt32(flags)
            writePeer w peer
            w.WriteInt32(msgId)
            topMsgId |> Option.iter (fun v -> w.WriteInt32(v))
            savedPeerId |> Option.iter (fun v -> writePeer w v)
            writeMessageReactions w reactions
        | WriteUpdate.UpdateNewServiceMessage(message, pts, ptsCount) ->
            w.WriteConstructorId(0x1F2B0AFDu) // updateNewMessage
            writeMessageService w message
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)
        | WriteUpdate.UpdateNewChannelServiceMessage(message, pts, ptsCount) ->
            w.WriteConstructorId(0x62BA04D9u) // updateNewChannelMessage
            writeMessageService w message
            w.WriteInt32(pts)
            w.WriteInt32(ptsCount)

    and writeUserStatus (w: TlWriteBuffer) (p: WriteUserStatus) =
        match p with
        | WriteUserStatus.UserStatusOnline(expires) ->
            w.WriteConstructorId(0xEDB93949u)
            w.WriteInt32(expires)
        | WriteUserStatus.UserStatusOffline(wasOnline) ->
            w.WriteConstructorId(0x008C703Fu)
            w.WriteInt32(wasOnline)
        | WriteUserStatus.UserStatusRecently(byMe) ->
            w.WriteConstructorId(0x7B197DC8u)
            let mutable flags = 0
            if byMe then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)

    and writeAuthAuthorization (w: TlWriteBuffer) (layer: int) (p: WriteAuthAuthorizationParams) =
        w.WriteConstructorId(0x2EA2C0D4u)
        let mutable flags = 0
        if p.setupPasswordRequired then flags <- flags ||| (1 <<< 1)
        if p.otherwiseReloginDays.IsSome then flags <- flags ||| (1 <<< 1)
        if p.tmpSessions.IsSome then flags <- flags ||| (1 <<< 0)
        if p.futureAuthToken.IsSome then flags <- flags ||| (1 <<< 2)
        w.WriteInt32(flags)
        p.otherwiseReloginDays |> Option.iter (fun v -> w.WriteInt32(v))
        p.tmpSessions |> Option.iter (fun v -> w.WriteInt32(v))
        p.futureAuthToken |> Option.iter (fun v -> w.WriteBytes(v))
        writeUser w layer p.user

    and writeAuthLoggedOut (w: TlWriteBuffer) (p: WriteAuthLoggedOutParams) =
        w.WriteConstructorId(0xC3A2835Fu)
        let mutable flags = 0
        if p.futureAuthToken.IsSome then flags <- flags ||| (1 <<< 0)
        w.WriteInt32(flags)
        p.futureAuthToken |> Option.iter (fun v -> w.WriteBytes(v))

    and writeAuthSentCode (w: TlWriteBuffer) (p: WriteAuthSentCodeParams) =
        w.WriteConstructorId(0x5E002502u)
        let mutable flags = 0
        if p.nextType.IsSome then flags <- flags ||| (1 <<< 1)
        if p.timeout.IsSome then flags <- flags ||| (1 <<< 2)
        w.WriteInt32(flags)
        writeAuthSentCodeTypeApp w p.``type``
        w.WriteString(p.phoneCodeHash)
        p.nextType |> Option.iter (fun v -> w.WriteBytes(v))
        p.timeout |> Option.iter (fun v -> w.WriteInt32(v))

    and writeAuthSentCodeTypeApp (w: TlWriteBuffer) (p: WriteAuthSentCodeTypeAppParams) =
        w.WriteConstructorId(0x3DBB5986u)
        w.WriteInt32(p.length)

    and writeAuthorization (w: TlWriteBuffer) (p: WriteAuthorizationParams) =
        w.WriteConstructorId(0xAD01D61Du)
        let mutable flags = 0
        if p.current then flags <- flags ||| (1 <<< 0)
        if p.officialApp then flags <- flags ||| (1 <<< 1)
        if p.passwordPending then flags <- flags ||| (1 <<< 2)
        if p.encryptedRequestsDisabled then flags <- flags ||| (1 <<< 3)
        if p.callRequestsDisabled then flags <- flags ||| (1 <<< 4)
        if p.unconfirmed then flags <- flags ||| (1 <<< 5)
        w.WriteInt32(flags)
        w.WriteInt64(p.hash)
        w.WriteString(p.deviceModel)
        w.WriteString(p.platform)
        w.WriteString(p.systemVersion)
        w.WriteInt32(p.apiId)
        w.WriteString(p.appName)
        w.WriteString(p.appVersion)
        w.WriteInt32(p.dateCreated)
        w.WriteInt32(p.dateActive)
        w.WriteString(p.ip)
        w.WriteString(p.country)
        w.WriteString(p.region)

    and writeChatAdminRights (w: TlWriteBuffer) (p: WriteChatAdminRightsParams) =
        w.WriteConstructorId(0x5FB224D5u)
        let mutable flags = 0
        if p.changeInfo then flags <- flags ||| (1 <<< 0)
        if p.postMessages then flags <- flags ||| (1 <<< 1)
        if p.editMessages then flags <- flags ||| (1 <<< 2)
        if p.deleteMessages then flags <- flags ||| (1 <<< 3)
        if p.banUsers then flags <- flags ||| (1 <<< 4)
        if p.inviteUsers then flags <- flags ||| (1 <<< 5)
        if p.pinMessages then flags <- flags ||| (1 <<< 7)
        if p.addAdmins then flags <- flags ||| (1 <<< 9)
        if p.anonymous then flags <- flags ||| (1 <<< 10)
        if p.manageCall then flags <- flags ||| (1 <<< 11)
        if p.other then flags <- flags ||| (1 <<< 12)
        if p.manageTopics then flags <- flags ||| (1 <<< 13)
        if p.postStories then flags <- flags ||| (1 <<< 14)
        if p.editStories then flags <- flags ||| (1 <<< 15)
        if p.deleteStories then flags <- flags ||| (1 <<< 16)
        if p.manageDirectMessages then flags <- flags ||| (1 <<< 17)
        w.WriteInt32(flags)

    and writeChatBannedRights (w: TlWriteBuffer) (p: WriteChatBannedRightsParams) =
        w.WriteConstructorId(0x9F120418u)
        let mutable flags = 0
        if p.viewMessages then flags <- flags ||| (1 <<< 0)
        if p.sendMessages then flags <- flags ||| (1 <<< 1)
        if p.sendMedia then flags <- flags ||| (1 <<< 2)
        if p.sendStickers then flags <- flags ||| (1 <<< 3)
        if p.sendGifs then flags <- flags ||| (1 <<< 4)
        if p.sendGames then flags <- flags ||| (1 <<< 5)
        if p.sendInline then flags <- flags ||| (1 <<< 6)
        if p.embedLinks then flags <- flags ||| (1 <<< 7)
        if p.sendPolls then flags <- flags ||| (1 <<< 8)
        if p.changeInfo then flags <- flags ||| (1 <<< 10)
        if p.inviteUsers then flags <- flags ||| (1 <<< 15)
        if p.pinMessages then flags <- flags ||| (1 <<< 17)
        if p.manageTopics then flags <- flags ||| (1 <<< 18)
        if p.sendPhotos then flags <- flags ||| (1 <<< 19)
        if p.sendVideos then flags <- flags ||| (1 <<< 20)
        if p.sendRoundvideos then flags <- flags ||| (1 <<< 21)
        if p.sendAudios then flags <- flags ||| (1 <<< 22)
        if p.sendVoices then flags <- flags ||| (1 <<< 23)
        if p.sendDocs then flags <- flags ||| (1 <<< 24)
        if p.sendPlain then flags <- flags ||| (1 <<< 25)
        w.WriteInt32(flags)
        w.WriteInt32(p.untilDate)

    and writeChannelFull (w: TlWriteBuffer) (p: WriteChannelFullParams) =
        w.WriteConstructorId(0xE4E0B29Du)
        let mutable flags = 0
        if p.canViewParticipants then flags <- flags ||| (1 <<< 3)
        if p.canSetUsername then flags <- flags ||| (1 <<< 6)
        if p.canSetStickers then flags <- flags ||| (1 <<< 7)
        if p.hiddenPrehistory then flags <- flags ||| (1 <<< 10)
        if p.canSetLocation then flags <- flags ||| (1 <<< 16)
        if p.hasScheduled then flags <- flags ||| (1 <<< 19)
        if p.canViewStats then flags <- flags ||| (1 <<< 20)
        if p.blocked then flags <- flags ||| (1 <<< 22)
        if p.participantsCount.IsSome then flags <- flags ||| (1 <<< 0)
        if p.adminsCount.IsSome then flags <- flags ||| (1 <<< 1)
        if p.kickedCount.IsSome then flags <- flags ||| (1 <<< 2)
        if p.bannedCount.IsSome then flags <- flags ||| (1 <<< 2)
        if p.onlineCount.IsSome then flags <- flags ||| (1 <<< 13)
        if p.exportedInvite.IsSome then flags <- flags ||| (1 <<< 23)
        if p.migratedFromChatId.IsSome then flags <- flags ||| (1 <<< 4)
        if p.migratedFromMaxId.IsSome then flags <- flags ||| (1 <<< 4)
        if p.pinnedMsgId.IsSome then flags <- flags ||| (1 <<< 5)
        if p.stickerset.IsSome then flags <- flags ||| (1 <<< 8)
        if p.availableMinId.IsSome then flags <- flags ||| (1 <<< 9)
        if p.folderId.IsSome then flags <- flags ||| (1 <<< 11)
        if p.linkedChatId.IsSome then flags <- flags ||| (1 <<< 14)
        if p.location.IsSome then flags <- flags ||| (1 <<< 15)
        if p.slowmodeSeconds.IsSome then flags <- flags ||| (1 <<< 17)
        if p.slowmodeNextSendDate.IsSome then flags <- flags ||| (1 <<< 18)
        if p.statsDc.IsSome then flags <- flags ||| (1 <<< 12)
        if p.call.IsSome then flags <- flags ||| (1 <<< 21)
        if p.ttlPeriod.IsSome then flags <- flags ||| (1 <<< 24)
        if p.pendingSuggestions.IsSome then flags <- flags ||| (1 <<< 25)
        if p.groupcallDefaultJoinAs.IsSome then flags <- flags ||| (1 <<< 26)
        if p.themeEmoticon.IsSome then flags <- flags ||| (1 <<< 27)
        if p.requestsPending.IsSome then flags <- flags ||| (1 <<< 28)
        if p.recentRequesters.IsSome then flags <- flags ||| (1 <<< 28)
        if p.defaultSendAs.IsSome then flags <- flags ||| (1 <<< 29)
        if p.availableReactions.IsSome then flags <- flags ||| (1 <<< 30)
        w.WriteInt32(flags)
        let mutable flags2 = 0
        if p.canDeleteChannel then flags2 <- flags2 ||| (1 <<< 0)
        if p.antispam then flags2 <- flags2 ||| (1 <<< 1)
        if p.participantsHidden then flags2 <- flags2 ||| (1 <<< 2)
        if p.translationsDisabled then flags2 <- flags2 ||| (1 <<< 3)
        if p.storiesPinnedAvailable then flags2 <- flags2 ||| (1 <<< 5)
        if p.viewForumAsMessages then flags2 <- flags2 ||| (1 <<< 6)
        if p.restrictedSponsored then flags2 <- flags2 ||| (1 <<< 11)
        if p.canViewRevenue then flags2 <- flags2 ||| (1 <<< 12)
        if p.paidMediaAllowed then flags2 <- flags2 ||| (1 <<< 14)
        if p.canViewStarsRevenue then flags2 <- flags2 ||| (1 <<< 15)
        if p.paidReactionsAvailable then flags2 <- flags2 ||| (1 <<< 16)
        if p.stargiftsAvailable then flags2 <- flags2 ||| (1 <<< 19)
        if p.paidMessagesAvailable then flags2 <- flags2 ||| (1 <<< 20)
        if p.reactionsLimit.IsSome then flags2 <- flags2 ||| (1 <<< 13)
        if p.stories.IsSome then flags2 <- flags2 ||| (1 <<< 4)
        if p.wallpaper.IsSome then flags2 <- flags2 ||| (1 <<< 7)
        if p.boostsApplied.IsSome then flags2 <- flags2 ||| (1 <<< 8)
        if p.boostsUnrestrict.IsSome then flags2 <- flags2 ||| (1 <<< 9)
        if p.emojiset.IsSome then flags2 <- flags2 ||| (1 <<< 10)
        if p.botVerification.IsSome then flags2 <- flags2 ||| (1 <<< 17)
        if p.stargiftsCount.IsSome then flags2 <- flags2 ||| (1 <<< 18)
        if p.sendPaidMessagesStars.IsSome then flags2 <- flags2 ||| (1 <<< 21)
        if p.mainTab.IsSome then flags2 <- flags2 ||| (1 <<< 22)
        w.WriteInt32(flags2)
        w.WriteInt64(p.id)
        w.WriteString(p.about)
        p.participantsCount |> Option.iter (fun v -> w.WriteInt32(v))
        p.adminsCount |> Option.iter (fun v -> w.WriteInt32(v))
        p.kickedCount |> Option.iter (fun v -> w.WriteInt32(v))
        p.bannedCount |> Option.iter (fun v -> w.WriteInt32(v))
        p.onlineCount |> Option.iter (fun v -> w.WriteInt32(v))
        w.WriteInt32(p.readInboxMaxId)
        w.WriteInt32(p.readOutboxMaxId)
        w.WriteInt32(p.unreadCount)
        writePhoto w p.chatPhoto
        writePeerNotifySettings w p.notifySettings
        p.exportedInvite |> Option.iter (fun v -> w.WriteBytes(v))
        w.WriteConstructorId(0x1CB5C415u)
        w.WriteInt32(p.botInfo.Length)
        for item in p.botInfo do w.WriteBytes(item)
        p.migratedFromChatId |> Option.iter (fun v -> w.WriteInt64(v))
        p.migratedFromMaxId |> Option.iter (fun v -> w.WriteInt32(v))
        p.pinnedMsgId |> Option.iter (fun v -> w.WriteInt32(v))
        p.stickerset |> Option.iter (fun v -> w.WriteBytes(v))
        p.availableMinId |> Option.iter (fun v -> w.WriteInt32(v))
        p.folderId |> Option.iter (fun v -> w.WriteInt32(v))
        p.linkedChatId |> Option.iter (fun v -> w.WriteInt64(v))
        p.location |> Option.iter (fun v -> w.WriteBytes(v))
        p.slowmodeSeconds |> Option.iter (fun v -> w.WriteInt32(v))
        p.slowmodeNextSendDate |> Option.iter (fun v -> w.WriteInt32(v))
        p.statsDc |> Option.iter (fun v -> w.WriteInt32(v))
        w.WriteInt32(p.pts)
        p.call |> Option.iter (fun v -> writeInputGroupCall w v)
        p.ttlPeriod |> Option.iter (fun v -> w.WriteInt32(v))
        match p.pendingSuggestions with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteString(item)
        | None -> ()
        p.groupcallDefaultJoinAs |> Option.iter (fun v -> writePeer w v)
        p.themeEmoticon |> Option.iter (fun v -> w.WriteString(v))
        p.requestsPending |> Option.iter (fun v -> w.WriteInt32(v))
        match p.recentRequesters with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteInt64(item)
        | None -> ()
        p.defaultSendAs |> Option.iter (fun v -> writePeer w v)
        p.availableReactions |> Option.iter (fun v -> w.WriteBytes(v))
        p.reactionsLimit |> Option.iter (fun v -> w.WriteInt32(v))
        p.stories |> Option.iter (fun v -> w.WriteBytes(v))
        p.wallpaper |> Option.iter (fun v -> w.WriteBytes(v))
        p.boostsApplied |> Option.iter (fun v -> w.WriteInt32(v))
        p.boostsUnrestrict |> Option.iter (fun v -> w.WriteInt32(v))
        p.emojiset |> Option.iter (fun v -> w.WriteBytes(v))
        p.botVerification |> Option.iter (fun v -> w.WriteBytes(v))
        p.stargiftsCount |> Option.iter (fun v -> w.WriteInt32(v))
        p.sendPaidMessagesStars |> Option.iter (fun v -> w.WriteInt64(v))
        p.mainTab |> Option.iter (fun v -> w.WriteBytes(v))

    and writeContact (w: TlWriteBuffer) (p: WriteContactParams) =
        w.WriteConstructorId(0x145ADE0Bu)
        w.WriteInt64(p.userId)
        w.WriteBool(p.mutual)

    and writeContactStatus (w: TlWriteBuffer) (p: WriteContactStatusParams) =
        w.WriteConstructorId(0x16D9703Bu)
        w.WriteInt64(p.userId)
        writeUserStatus w p.status

    and writeDcOption (w: TlWriteBuffer) (p: WriteDcOptionParams) =
        w.WriteConstructorId(0x18B7A10Du)
        let mutable flags = 0
        if p.ipv6 then flags <- flags ||| (1 <<< 0)
        if p.mediaOnly then flags <- flags ||| (1 <<< 1)
        if p.tcpoOnly then flags <- flags ||| (1 <<< 2)
        if p.cdn then flags <- flags ||| (1 <<< 3)
        if p.``static`` then flags <- flags ||| (1 <<< 4)
        if p.thisPortOnly then flags <- flags ||| (1 <<< 5)
        if p.secret.IsSome then flags <- flags ||| (1 <<< 10)
        w.WriteInt32(flags)
        w.WriteInt32(p.id)
        w.WriteString(p.ipAddress)
        w.WriteInt32(p.port)
        p.secret |> Option.iter (fun v -> w.WriteBytes(v))

    and writeDialog (w: TlWriteBuffer) (p: WriteDialogParams) =
        w.WriteConstructorId(0xD58A08C6u)
        let mutable flags = 0
        if p.pinned then flags <- flags ||| (1 <<< 2)
        if p.unreadMark then flags <- flags ||| (1 <<< 3)
        if p.viewForumAsMessages then flags <- flags ||| (1 <<< 6)
        if p.pts.IsSome then flags <- flags ||| (1 <<< 0)
        if p.draft.IsSome then flags <- flags ||| (1 <<< 1)
        if p.folderId.IsSome then flags <- flags ||| (1 <<< 4)
        if p.ttlPeriod.IsSome then flags <- flags ||| (1 <<< 5)
        w.WriteInt32(flags)
        writePeer w p.peer
        w.WriteInt32(p.topMessage)
        w.WriteInt32(p.readInboxMaxId)
        w.WriteInt32(p.readOutboxMaxId)
        w.WriteInt32(p.unreadCount)
        w.WriteInt32(p.unreadMentionsCount)
        w.WriteInt32(p.unreadReactionsCount)
        writePeerNotifySettings w p.notifySettings
        p.pts |> Option.iter (fun v -> w.WriteInt32(v))
        p.draft |> Option.iter (fun v -> writeDraftMessage w v)
        p.folderId |> Option.iter (fun v -> w.WriteInt32(v))
        p.ttlPeriod |> Option.iter (fun v -> w.WriteInt32(v))

    and writeDialogPeer (w: TlWriteBuffer) (p: WriteDialogPeerParams) =
        w.WriteConstructorId(0xE56DBF05u)
        writePeer w p.peer

    and writeDocument (w: TlWriteBuffer) (p: WriteDocumentParams) =
        w.WriteConstructorId(0x8FD4C4D8u)
        let mutable flags = 0
        if p.thumbs.IsSome then flags <- flags ||| (1 <<< 0)
        if p.videoThumbs.IsSome then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        w.WriteInt64(p.id)
        w.WriteInt64(p.accessHash)
        w.WriteBytes(p.fileReference)
        w.WriteInt32(p.date)
        w.WriteString(p.mimeType)
        w.WriteInt64(p.size)
        match p.thumbs with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do writePhotoSize w item
        | None -> ()
        match p.videoThumbs with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()
        w.WriteInt32(p.dcId)
        w.WriteConstructorId(0x1CB5C415u)
        w.WriteInt32(p.attributes.Length)
        for item in p.attributes do writeDocumentAttributeFilename w item

    and writeDocumentAttributeFilename (w: TlWriteBuffer) (p: WriteDocumentAttributeFilenameParams) =
        w.WriteConstructorId(0x15590068u)
        w.WriteString(p.fileName)

    and writeDraftMessage (w: TlWriteBuffer) (p: WriteDraftMessageParams) =
        w.WriteConstructorId(0x96EAA5EBu)
        let mutable flags = 0
        if p.noWebpage then flags <- flags ||| (1 <<< 1)
        if p.invertMedia then flags <- flags ||| (1 <<< 6)
        if p.replyTo.IsSome then flags <- flags ||| (1 <<< 4)
        if p.entities.IsSome then flags <- flags ||| (1 <<< 3)
        if p.media.IsSome then flags <- flags ||| (1 <<< 5)
        if p.effect.IsSome then flags <- flags ||| (1 <<< 7)
        if p.suggestedPost.IsSome then flags <- flags ||| (1 <<< 8)
        w.WriteInt32(flags)
        p.replyTo |> Option.iter (fun v -> w.WriteBytes(v))
        w.WriteString(p.message)
        match p.entities with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()
        p.media |> Option.iter (fun v -> w.WriteBytes(v))
        w.WriteInt32(p.date)
        p.effect |> Option.iter (fun v -> w.WriteInt64(v))
        p.suggestedPost |> Option.iter (fun v -> w.WriteBytes(v))

    and writeForumTopic (w: TlWriteBuffer) (p: WriteForumTopicParams) =
        w.WriteConstructorId(0x71701DA9u)
        let mutable flags = 0
        if p.my then flags <- flags ||| (1 <<< 1)
        if p.closed then flags <- flags ||| (1 <<< 2)
        if p.pinned then flags <- flags ||| (1 <<< 3)
        if p.short then flags <- flags ||| (1 <<< 5)
        if p.hidden then flags <- flags ||| (1 <<< 6)
        if p.iconEmojiId.IsSome then flags <- flags ||| (1 <<< 0)
        if p.draft.IsSome then flags <- flags ||| (1 <<< 4)
        w.WriteInt32(flags)
        w.WriteInt32(p.id)
        w.WriteInt32(p.date)
        w.WriteString(p.title)
        w.WriteInt32(p.iconColor)
        p.iconEmojiId |> Option.iter (fun v -> w.WriteInt64(v))
        w.WriteInt32(p.topMessage)
        w.WriteInt32(p.readInboxMaxId)
        w.WriteInt32(p.readOutboxMaxId)
        w.WriteInt32(p.unreadCount)
        w.WriteInt32(p.unreadMentionsCount)
        w.WriteInt32(p.unreadReactionsCount)
        writePeer w p.fromId
        writePeerNotifySettings w p.notifySettings
        p.draft |> Option.iter (fun v -> writeDraftMessage w v)

    and writeGroupCallParticipant (w: TlWriteBuffer) (p: WriteGroupCallParticipantParams) =
        w.WriteConstructorId(0xEBA636FEu)
        let mutable flags = 0
        if p.muted then flags <- flags ||| (1 <<< 0)
        if p.left then flags <- flags ||| (1 <<< 1)
        if p.canSelfUnmute then flags <- flags ||| (1 <<< 2)
        if p.justJoined then flags <- flags ||| (1 <<< 4)
        if p.versioned then flags <- flags ||| (1 <<< 5)
        if p.min then flags <- flags ||| (1 <<< 8)
        if p.mutedByYou then flags <- flags ||| (1 <<< 9)
        if p.volumeByAdmin then flags <- flags ||| (1 <<< 10)
        if p.self then flags <- flags ||| (1 <<< 12)
        if p.videoJoined then flags <- flags ||| (1 <<< 15)
        if p.activeDate.IsSome then flags <- flags ||| (1 <<< 3)
        if p.volume.IsSome then flags <- flags ||| (1 <<< 7)
        if p.about.IsSome then flags <- flags ||| (1 <<< 11)
        if p.raiseHandRating.IsSome then flags <- flags ||| (1 <<< 13)
        if p.video.IsSome then flags <- flags ||| (1 <<< 6)
        if p.presentation.IsSome then flags <- flags ||| (1 <<< 14)
        w.WriteInt32(flags)
        writePeer w p.peer
        w.WriteInt32(p.date)
        p.activeDate |> Option.iter (fun v -> w.WriteInt32(v))
        w.WriteInt32(p.source)
        p.volume |> Option.iter (fun v -> w.WriteInt32(v))
        p.about |> Option.iter (fun v -> w.WriteString(v))
        p.raiseHandRating |> Option.iter (fun v -> w.WriteInt64(v))
        p.video |> Option.iter (fun v -> w.WriteBytes(v))
        p.presentation |> Option.iter (fun v -> w.WriteBytes(v))

    and writeImportedContact (w: TlWriteBuffer) (p: WriteImportedContactParams) =
        w.WriteConstructorId(0xC13E3C50u)
        w.WriteInt64(p.userId)
        w.WriteInt64(p.clientId)

    and writeInputGroupCall (w: TlWriteBuffer) (p: WriteInputGroupCallParams) =
        w.WriteConstructorId(0xD8AA840Fu)
        w.WriteInt64(p.id)
        w.WriteInt64(p.accessHash)

    and writeLangPackLanguage (w: TlWriteBuffer) (p: WriteLangPackLanguageParams) =
        w.WriteConstructorId(0xEECA5CE3u)
        let mutable flags = 0
        if p.official then flags <- flags ||| (1 <<< 0)
        if p.rtl then flags <- flags ||| (1 <<< 2)
        if p.beta then flags <- flags ||| (1 <<< 3)
        if p.baseLangCode.IsSome then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        w.WriteString(p.name)
        w.WriteString(p.nativeName)
        w.WriteString(p.langCode)
        p.baseLangCode |> Option.iter (fun v -> w.WriteString(v))
        w.WriteString(p.pluralCode)
        w.WriteInt32(p.stringsCount)
        w.WriteInt32(p.translatedCount)
        w.WriteString(p.translationsUrl)

    and writeMessage (w: TlWriteBuffer) (layer: int) (p: WriteMessageParams) =
        w.WriteConstructorId(GeneratedLayerCid.message layer)
        let mutable flags = 0
        if p.out then flags <- flags ||| (1 <<< 1)
        if p.mentioned then flags <- flags ||| (1 <<< 4)
        if p.mediaUnread then flags <- flags ||| (1 <<< 5)
        if p.silent then flags <- flags ||| (1 <<< 13)
        if p.post then flags <- flags ||| (1 <<< 14)
        if p.fromScheduled then flags <- flags ||| (1 <<< 18)
        if p.legacy then flags <- flags ||| (1 <<< 19)
        if p.editHide then flags <- flags ||| (1 <<< 21)
        if p.pinned then flags <- flags ||| (1 <<< 24)
        if p.noforwards then flags <- flags ||| (1 <<< 26)
        if p.invertMedia then flags <- flags ||| (1 <<< 27)
        if p.fromId.IsSome then flags <- flags ||| (1 <<< 8)
        if p.fromBoostsApplied.IsSome then flags <- flags ||| (1 <<< 29)
        if p.savedPeerId.IsSome then flags <- flags ||| (1 <<< 28)
        if p.fwdFrom.IsSome then flags <- flags ||| (1 <<< 2)
        if p.viaBotId.IsSome then flags <- flags ||| (1 <<< 11)
        if p.replyTo.IsSome then flags <- flags ||| (1 <<< 3)
        if p.media.IsSome then flags <- flags ||| (1 <<< 9)
        if p.replyMarkup.IsSome then flags <- flags ||| (1 <<< 6)
        if p.entities.IsSome then flags <- flags ||| (1 <<< 7)
        if p.views.IsSome then flags <- flags ||| (1 <<< 10)
        if p.forwards.IsSome then flags <- flags ||| (1 <<< 10)
        if p.replies.IsSome then flags <- flags ||| (1 <<< 23)
        if p.editDate.IsSome then flags <- flags ||| (1 <<< 15)
        if p.postAuthor.IsSome then flags <- flags ||| (1 <<< 16)
        if p.groupedId.IsSome then flags <- flags ||| (1 <<< 17)
        if p.reactions.IsSome then flags <- flags ||| (1 <<< 20)
        if p.restrictionReason.IsSome then flags <- flags ||| (1 <<< 22)
        if p.ttlPeriod.IsSome then flags <- flags ||| (1 <<< 25)
        if p.quickReplyShortcutId.IsSome then flags <- flags ||| (1 <<< 30)
        w.WriteInt32(flags)
        let mutable flags2 = 0
        if p.offline then flags2 <- flags2 ||| (1 <<< 1)
        if p.videoProcessingPending then flags2 <- flags2 ||| (1 <<< 4)
        if p.paidSuggestedPostStars then flags2 <- flags2 ||| (1 <<< 8)
        if p.paidSuggestedPostTon then flags2 <- flags2 ||| (1 <<< 9)
        if p.viaBusinessBotId.IsSome then flags2 <- flags2 ||| (1 <<< 0)
        if p.effect.IsSome then flags2 <- flags2 ||| (1 <<< 2)
        if p.factcheck.IsSome then flags2 <- flags2 ||| (1 <<< 3)
        if p.reportDeliveryUntilDate.IsSome then flags2 <- flags2 ||| (1 <<< 5)
        if p.paidMessageStars.IsSome then flags2 <- flags2 ||| (1 <<< 6)
        if p.suggestedPost.IsSome then flags2 <- flags2 ||| (1 <<< 7)
        w.WriteInt32(flags2)
        w.WriteInt32(p.id)
        p.fromId |> Option.iter (fun v -> writePeer w v)
        p.fromBoostsApplied |> Option.iter (fun v -> w.WriteInt32(v))
        writePeer w p.peerId
        p.savedPeerId |> Option.iter (fun v -> writePeer w v)
        p.fwdFrom |> Option.iter (fun v -> w.WriteBytes(v))
        p.viaBotId |> Option.iter (fun v -> w.WriteInt64(v))
        p.viaBusinessBotId |> Option.iter (fun v -> w.WriteInt64(v))
        p.replyTo |> Option.iter (fun v -> writeMessageReplyHeader w layer v)
        w.WriteInt32(p.date)
        w.WriteString(p.message)
        p.media |> Option.iter (fun v -> writeMessageMedia w layer v)
        p.replyMarkup |> Option.iter (fun v -> w.WriteBytes(v))
        match p.entities with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()
        p.views |> Option.iter (fun v -> w.WriteInt32(v))
        p.forwards |> Option.iter (fun v -> w.WriteInt32(v))
        p.replies |> Option.iter (fun v -> w.WriteBytes(v))
        p.editDate |> Option.iter (fun v -> w.WriteInt32(v))
        p.postAuthor |> Option.iter (fun v -> w.WriteString(v))
        p.groupedId |> Option.iter (fun v -> w.WriteInt64(v))
        p.reactions |> Option.iter (fun v -> writeMessageReactions w v)
        match p.restrictionReason with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()
        p.ttlPeriod |> Option.iter (fun v -> w.WriteInt32(v))
        p.quickReplyShortcutId |> Option.iter (fun v -> w.WriteInt32(v))
        p.effect |> Option.iter (fun v -> w.WriteInt64(v))
        p.factcheck |> Option.iter (fun v -> w.WriteBytes(v))
        p.reportDeliveryUntilDate |> Option.iter (fun v -> w.WriteInt32(v))
        p.paidMessageStars |> Option.iter (fun v -> w.WriteInt64(v))
        p.suggestedPost |> Option.iter (fun v -> w.WriteBytes(v))

    and writeMessageAction (w: TlWriteBuffer) (p: WriteMessageAction) =
        match p with
        | WriteMessageAction.MessageActionEmpty ->
            w.WriteConstructorId(GeneratedCid.MessageActionEmpty)
        | WriteMessageAction.MessageActionChatCreate(title, users) ->
            w.WriteConstructorId(GeneratedCid.MessageActionChatCreate)
            w.WriteString(title)
            w.WriteConstructorId(0x1CB5C415u) // vector
            w.WriteInt32(users.Length)
            for u in users do w.WriteInt64(u)
        | WriteMessageAction.MessageActionChatEditTitle(title) ->
            w.WriteConstructorId(GeneratedCid.MessageActionChatEditTitle)
            w.WriteString(title)
        | WriteMessageAction.MessageActionChatEditPhoto(photoBytes) ->
            w.WriteConstructorId(GeneratedCid.MessageActionChatEditPhoto)
            w.WriteRawBytes(photoBytes)
        | WriteMessageAction.MessageActionChatDeletePhoto ->
            w.WriteConstructorId(GeneratedCid.MessageActionChatDeletePhoto)
        | WriteMessageAction.MessageActionChatAddUser(users) ->
            w.WriteConstructorId(GeneratedCid.MessageActionChatAddUser)
            w.WriteConstructorId(0x1CB5C415u) // vector
            w.WriteInt32(users.Length)
            for u in users do w.WriteInt64(u)
        | WriteMessageAction.MessageActionChatDeleteUser(userId) ->
            w.WriteConstructorId(GeneratedCid.MessageActionChatDeleteUser)
            w.WriteInt64(userId)
        | WriteMessageAction.MessageActionChatJoinedByLink(inviterId) ->
            w.WriteConstructorId(GeneratedCid.MessageActionChatJoinedByLink)
            w.WriteInt64(inviterId)
        | WriteMessageAction.MessageActionChannelCreate(title) ->
            w.WriteConstructorId(GeneratedCid.MessageActionChannelCreate)
            w.WriteString(title)
        | WriteMessageAction.MessageActionPinMessage ->
            w.WriteConstructorId(GeneratedCid.MessageActionPinMessage)
        | WriteMessageAction.MessageActionHistoryClear ->
            w.WriteConstructorId(GeneratedCid.MessageActionHistoryClear)
        | WriteMessageAction.MessageActionGroupCall(callId, callAccessHash, duration) ->
            w.WriteConstructorId(GeneratedCid.MessageActionGroupCall)
            let mutable flags = 0
            if duration.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            // InputGroupCall
            w.WriteConstructorId(GeneratedCid.InputGroupCall)
            w.WriteInt64(callId)
            w.WriteInt64(callAccessHash)
            duration |> Option.iter (fun v -> w.WriteInt32(v))
        | WriteMessageAction.MessageActionSetMessagesTTL(period, autoSettingFrom) ->
            w.WriteConstructorId(GeneratedCid.MessageActionSetMessagesTTL)
            let mutable flags = 0
            if autoSettingFrom.IsSome then flags <- flags ||| (1 <<< 0)
            w.WriteInt32(flags)
            w.WriteInt32(period)
            autoSettingFrom |> Option.iter (fun v -> w.WriteInt64(v))
        | WriteMessageAction.MessageActionPhoneCall(video, callId, reason, duration) ->
            w.WriteConstructorId(GeneratedCid.MessageActionPhoneCall)
            let mutable flags = 0
            if video then flags <- flags ||| (1 <<< 2)
            if reason.IsSome then flags <- flags ||| (1 <<< 0)
            if duration.IsSome then flags <- flags ||| (1 <<< 1)
            w.WriteInt32(flags)
            w.WriteInt64(callId)
            reason |> Option.iter (fun v -> w.WriteRawBytes(v))
            duration |> Option.iter (fun v -> w.WriteInt32(v))
        | WriteMessageAction.MessageActionChatJoinedByRequest ->
            w.WriteConstructorId(GeneratedCid.MessageActionChatJoinedByRequest)

    /// Serialize messageService#7a800e0a
    and writeMessageService (w: TlWriteBuffer) (p: WriteMessageServiceParams) =
        w.WriteConstructorId(GeneratedCid.MessageService)
        let mutable flags = 0
        if p.out then flags <- flags ||| (1 <<< 1)
        if p.mentioned then flags <- flags ||| (1 <<< 4)
        if p.mediaUnread then flags <- flags ||| (1 <<< 5)
        if p.silent then flags <- flags ||| (1 <<< 13)
        if p.post then flags <- flags ||| (1 <<< 14)
        if p.legacy then flags <- flags ||| (1 <<< 19)
        if p.fromId.IsSome then flags <- flags ||| (1 <<< 8)
        if p.savedPeerId.IsSome then flags <- flags ||| (1 <<< 28)
        if p.replyTo.IsSome then flags <- flags ||| (1 <<< 3)
        if p.ttlPeriod.IsSome then flags <- flags ||| (1 <<< 25)
        w.WriteInt32(flags)
        w.WriteInt32(p.id)
        p.fromId |> Option.iter (fun v -> writePeer w v)
        writePeer w p.peerId
        p.savedPeerId |> Option.iter (fun v -> writePeer w v)
        p.replyTo |> Option.iter (fun v -> writeMessageReplyHeader w 0 v)
        w.WriteInt32(p.date)
        writeMessageAction w p.action
        // reactions: flags.20 — not written for service messages from server
        p.ttlPeriod |> Option.iter (fun v -> w.WriteInt32(v))

    and writeMessagePeerReaction (w: TlWriteBuffer) (p: WriteMessagePeerReactionParams) =
        w.WriteConstructorId(0x8C79B63Cu)
        let mutable flags = 0
        if p.big then flags <- flags ||| (1 <<< 0)
        if p.unread then flags <- flags ||| (1 <<< 1)
        if p.my then flags <- flags ||| (1 <<< 2)
        w.WriteInt32(flags)
        writePeer w p.peerId
        w.WriteInt32(p.date)
        writeReaction w p.reaction

    and writeMessageReactions (w: TlWriteBuffer) (p: WriteMessageReactionsParams) =
        w.WriteConstructorId(0x0A339F0Bu)
        let mutable flags = 0
        if p.min then flags <- flags ||| (1 <<< 0)
        if p.canSeeList then flags <- flags ||| (1 <<< 2)
        if p.reactionsAsTags then flags <- flags ||| (1 <<< 3)
        if p.recentReactions.IsSome then flags <- flags ||| (1 <<< 1)
        if p.topReactors.IsSome then flags <- flags ||| (1 <<< 4)
        w.WriteInt32(flags)
        w.WriteConstructorId(0x1CB5C415u)
        w.WriteInt32(p.results.Length)
        for item in p.results do writeReactionCount w item
        match p.recentReactions with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do writeMessagePeerReaction w item
        | None -> ()
        match p.topReactors with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()

    and writeMessageReplyHeader (w: TlWriteBuffer) (layer: int) (p: WriteMessageReplyHeaderParams) =
        w.WriteConstructorId(0x6917560Bu)
        let mutable flags = 0
        if p.replyToScheduled then flags <- flags ||| (1 <<< 2)
        if p.forumTopic then flags <- flags ||| (1 <<< 3)
        if p.quote then flags <- flags ||| (1 <<< 9)
        if p.replyToMsgId.IsSome then flags <- flags ||| (1 <<< 4)
        if p.replyToPeerId.IsSome then flags <- flags ||| (1 <<< 0)
        if p.replyFrom.IsSome then flags <- flags ||| (1 <<< 5)
        if p.replyMedia.IsSome then flags <- flags ||| (1 <<< 8)
        if p.replyToTopId.IsSome then flags <- flags ||| (1 <<< 1)
        if p.quoteText.IsSome then flags <- flags ||| (1 <<< 6)
        if p.quoteEntities.IsSome then flags <- flags ||| (1 <<< 7)
        if p.quoteOffset.IsSome then flags <- flags ||| (1 <<< 10)
        if p.todoItemId.IsSome then flags <- flags ||| (1 <<< 11)
        w.WriteInt32(flags)
        p.replyToMsgId |> Option.iter (fun v -> w.WriteInt32(v))
        p.replyToPeerId |> Option.iter (fun v -> writePeer w v)
        p.replyFrom |> Option.iter (fun v -> w.WriteBytes(v))
        p.replyMedia |> Option.iter (fun v -> writeMessageMedia w layer v)
        p.replyToTopId |> Option.iter (fun v -> w.WriteInt32(v))
        p.quoteText |> Option.iter (fun v -> w.WriteString(v))
        match p.quoteEntities with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()
        p.quoteOffset |> Option.iter (fun v -> w.WriteInt32(v))
        p.todoItemId |> Option.iter (fun v -> w.WriteInt32(v))

    and writeMessageViews (w: TlWriteBuffer) (p: WriteMessageViewsParams) =
        w.WriteConstructorId(0x455B853Du)
        let mutable flags = 0
        if p.views.IsSome then flags <- flags ||| (1 <<< 0)
        if p.forwards.IsSome then flags <- flags ||| (1 <<< 1)
        if p.replies.IsSome then flags <- flags ||| (1 <<< 2)
        w.WriteInt32(flags)
        p.views |> Option.iter (fun v -> w.WriteInt32(v))
        p.forwards |> Option.iter (fun v -> w.WriteInt32(v))
        p.replies |> Option.iter (fun v -> w.WriteBytes(v))

    and writeMessagesAffectedHistory (w: TlWriteBuffer) (p: WriteMessagesAffectedHistoryParams) =
        w.WriteConstructorId(0xB45C69D1u)
        w.WriteInt32(p.pts)
        w.WriteInt32(p.ptsCount)
        w.WriteInt32(p.offset)

    and writeMessagesAffectedMessages (w: TlWriteBuffer) (p: WriteMessagesAffectedMessagesParams) =
        w.WriteConstructorId(0x84D19185u)
        w.WriteInt32(p.pts)
        w.WriteInt32(p.ptsCount)

    and writePeerBlocked (w: TlWriteBuffer) (p: WritePeerBlockedParams) =
        w.WriteConstructorId(0xE8FD8014u)
        writePeer w p.peerId
        w.WriteInt32(p.date)

    and writePeerNotifySettings (w: TlWriteBuffer) (p: WritePeerNotifySettingsParams) =
        w.WriteConstructorId(0x99622C0Cu)
        let mutable flags = 0
        if p.showPreviews.IsSome then flags <- flags ||| (1 <<< 0)
        if p.silent.IsSome then flags <- flags ||| (1 <<< 1)
        if p.muteUntil.IsSome then flags <- flags ||| (1 <<< 2)
        if p.iosSound.IsSome then flags <- flags ||| (1 <<< 3)
        if p.androidSound.IsSome then flags <- flags ||| (1 <<< 4)
        if p.otherSound.IsSome then flags <- flags ||| (1 <<< 5)
        if p.storiesMuted.IsSome then flags <- flags ||| (1 <<< 6)
        if p.storiesHideSender.IsSome then flags <- flags ||| (1 <<< 7)
        if p.storiesIosSound.IsSome then flags <- flags ||| (1 <<< 8)
        if p.storiesAndroidSound.IsSome then flags <- flags ||| (1 <<< 9)
        if p.storiesOtherSound.IsSome then flags <- flags ||| (1 <<< 10)
        w.WriteInt32(flags)
        p.showPreviews |> Option.iter (fun v -> w.WriteBool(v))
        p.silent |> Option.iter (fun v -> w.WriteBool(v))
        p.muteUntil |> Option.iter (fun v -> w.WriteInt32(v))
        p.iosSound |> Option.iter (fun v -> w.WriteBytes(v))
        p.androidSound |> Option.iter (fun v -> w.WriteBytes(v))
        p.otherSound |> Option.iter (fun v -> w.WriteBytes(v))
        p.storiesMuted |> Option.iter (fun v -> w.WriteBool(v))
        p.storiesHideSender |> Option.iter (fun v -> w.WriteBool(v))
        p.storiesIosSound |> Option.iter (fun v -> w.WriteBytes(v))
        p.storiesAndroidSound |> Option.iter (fun v -> w.WriteBytes(v))
        p.storiesOtherSound |> Option.iter (fun v -> w.WriteBytes(v))

    and writePeerSettings (w: TlWriteBuffer) (p: WritePeerSettingsParams) =
        w.WriteConstructorId(0xF47741F7u)
        let mutable flags = 0
        if p.reportSpam then flags <- flags ||| (1 <<< 0)
        if p.addContact then flags <- flags ||| (1 <<< 1)
        if p.blockContact then flags <- flags ||| (1 <<< 2)
        if p.shareContact then flags <- flags ||| (1 <<< 3)
        if p.needContactsException then flags <- flags ||| (1 <<< 4)
        if p.reportGeo then flags <- flags ||| (1 <<< 5)
        if p.autoarchived then flags <- flags ||| (1 <<< 7)
        if p.inviteMembers then flags <- flags ||| (1 <<< 8)
        if p.requestChatBroadcast then flags <- flags ||| (1 <<< 10)
        if p.businessBotPaused then flags <- flags ||| (1 <<< 11)
        if p.businessBotCanReply then flags <- flags ||| (1 <<< 12)
        if p.geoDistance.IsSome then flags <- flags ||| (1 <<< 6)
        if p.requestChatTitle.IsSome then flags <- flags ||| (1 <<< 9)
        if p.requestChatDate.IsSome then flags <- flags ||| (1 <<< 9)
        if p.businessBotId.IsSome then flags <- flags ||| (1 <<< 13)
        if p.businessBotManageUrl.IsSome then flags <- flags ||| (1 <<< 13)
        if p.chargePaidMessageStars.IsSome then flags <- flags ||| (1 <<< 14)
        if p.registrationMonth.IsSome then flags <- flags ||| (1 <<< 15)
        if p.phoneCountry.IsSome then flags <- flags ||| (1 <<< 16)
        if p.nameChangeDate.IsSome then flags <- flags ||| (1 <<< 17)
        if p.photoChangeDate.IsSome then flags <- flags ||| (1 <<< 18)
        w.WriteInt32(flags)
        p.geoDistance |> Option.iter (fun v -> w.WriteInt32(v))
        p.requestChatTitle |> Option.iter (fun v -> w.WriteString(v))
        p.requestChatDate |> Option.iter (fun v -> w.WriteInt32(v))
        p.businessBotId |> Option.iter (fun v -> w.WriteInt64(v))
        p.businessBotManageUrl |> Option.iter (fun v -> w.WriteString(v))
        p.chargePaidMessageStars |> Option.iter (fun v -> w.WriteInt64(v))
        p.registrationMonth |> Option.iter (fun v -> w.WriteString(v))
        p.phoneCountry |> Option.iter (fun v -> w.WriteString(v))
        p.nameChangeDate |> Option.iter (fun v -> w.WriteInt32(v))
        p.photoChangeDate |> Option.iter (fun v -> w.WriteInt32(v))

    and writePhoneCallProtocol (w: TlWriteBuffer) (p: WritePhoneCallProtocolParams) =
        w.WriteConstructorId(0xFC878FC8u)
        let mutable flags = 0
        if p.udpP2p then flags <- flags ||| (1 <<< 0)
        if p.udpReflector then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        w.WriteInt32(p.minLayer)
        w.WriteInt32(p.maxLayer)
        w.WriteConstructorId(0x1CB5C415u)
        w.WriteInt32(p.libraryVersions.Length)
        for item in p.libraryVersions do w.WriteString(item)

    and writePhoto (w: TlWriteBuffer) (p: WritePhotoParams) =
        w.WriteConstructorId(0xFB197A65u)
        let mutable flags = 0
        if p.hasStickers then flags <- flags ||| (1 <<< 0)
        if p.videoSizes.IsSome then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        w.WriteInt64(p.id)
        w.WriteInt64(p.accessHash)
        w.WriteBytes(p.fileReference)
        w.WriteInt32(p.date)
        w.WriteConstructorId(0x1CB5C415u)
        w.WriteInt32(p.sizes.Length)
        for item in p.sizes do writePhotoSize w item
        match p.videoSizes with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()
        w.WriteInt32(p.dcId)

    and writePhotoSize (w: TlWriteBuffer) (p: WritePhotoSizeParams) =
        w.WriteConstructorId(0x75C78E60u)
        w.WriteString(p.``type``)
        w.WriteInt32(p.w)
        w.WriteInt32(p.h)
        w.WriteInt32(p.size)

    and writePollAnswerVoters (w: TlWriteBuffer) (p: WritePollAnswerVotersParams) =
        w.WriteConstructorId(0x3B6DDAD2u)
        let mutable flags = 0
        if p.chosen then flags <- flags ||| (1 <<< 0)
        if p.correct then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        w.WriteBytes(p.option)
        w.WriteInt32(p.voters)

    and writePollResults (w: TlWriteBuffer) (p: WritePollResultsParams) =
        w.WriteConstructorId(0x7ADF2420u)
        let mutable flags = 0
        if p.min then flags <- flags ||| (1 <<< 0)
        if p.results.IsSome then flags <- flags ||| (1 <<< 1)
        if p.totalVoters.IsSome then flags <- flags ||| (1 <<< 2)
        if p.recentVoters.IsSome then flags <- flags ||| (1 <<< 3)
        if p.solution.IsSome then flags <- flags ||| (1 <<< 4)
        if p.solutionEntities.IsSome then flags <- flags ||| (1 <<< 4)
        w.WriteInt32(flags)
        match p.results with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do writePollAnswerVoters w item
        | None -> ()
        p.totalVoters |> Option.iter (fun v -> w.WriteInt32(v))
        match p.recentVoters with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do writePeer w item
        | None -> ()
        p.solution |> Option.iter (fun v -> w.WriteString(v))
        match p.solutionEntities with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()

    and writeReactionCount (w: TlWriteBuffer) (p: WriteReactionCountParams) =
        w.WriteConstructorId(0xA3D1CB80u)
        let mutable flags = 0
        if p.chosenOrder.IsSome then flags <- flags ||| (1 <<< 0)
        w.WriteInt32(flags)
        p.chosenOrder |> Option.iter (fun v -> w.WriteInt32(v))
        writeReaction w p.reaction
        w.WriteInt32(p.count)

    and writeStoriesStealthMode (w: TlWriteBuffer) (p: WriteStoriesStealthModeParams) =
        w.WriteConstructorId(0x712E27FDu)
        let mutable flags = 0
        if p.activeUntilDate.IsSome then flags <- flags ||| (1 <<< 0)
        if p.cooldownUntilDate.IsSome then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        p.activeUntilDate |> Option.iter (fun v -> w.WriteInt32(v))
        p.cooldownUntilDate |> Option.iter (fun v -> w.WriteInt32(v))

    and writeUpdateShortSentMessage (w: TlWriteBuffer) (layer: int) (p: WriteUpdateShortSentMessageParams) =
        w.WriteConstructorId(0x9015E101u)
        let mutable flags = 0
        if p.out then flags <- flags ||| (1 <<< 1)
        if p.media.IsSome then flags <- flags ||| (1 <<< 9)
        if p.entities.IsSome then flags <- flags ||| (1 <<< 7)
        if p.ttlPeriod.IsSome then flags <- flags ||| (1 <<< 25)
        w.WriteInt32(flags)
        w.WriteInt32(p.id)
        w.WriteInt32(p.pts)
        w.WriteInt32(p.ptsCount)
        w.WriteInt32(p.date)
        p.media |> Option.iter (fun v -> writeMessageMedia w layer v)
        match p.entities with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()
        p.ttlPeriod |> Option.iter (fun v -> w.WriteInt32(v))

    and writeUpdatesDifferenceEmpty (w: TlWriteBuffer) (p: WriteUpdatesDifferenceEmptyParams) =
        w.WriteConstructorId(0x5D75A138u)
        w.WriteInt32(p.date)
        w.WriteInt32(p.seq)

    and writeUpdatesState (w: TlWriteBuffer) (p: WriteUpdatesStateParams) =
        w.WriteConstructorId(0xA56C2A3Eu)
        w.WriteInt32(p.pts)
        w.WriteInt32(p.qts)
        w.WriteInt32(p.date)
        w.WriteInt32(p.seq)
        w.WriteInt32(p.unreadCount)

    and writeUser (w: TlWriteBuffer) (layer: int) (p: WriteUserParams) =
        w.WriteConstructorId(GeneratedLayerCid.user layer)
        let mutable flags = 0
        if p.self then flags <- flags ||| (1 <<< 10)
        if p.contact then flags <- flags ||| (1 <<< 11)
        if p.mutualContact then flags <- flags ||| (1 <<< 12)
        if p.deleted then flags <- flags ||| (1 <<< 13)
        if p.bot then flags <- flags ||| (1 <<< 14)
        if p.botChatHistory then flags <- flags ||| (1 <<< 15)
        if p.botNochats then flags <- flags ||| (1 <<< 16)
        if p.verified then flags <- flags ||| (1 <<< 17)
        if p.restricted then flags <- flags ||| (1 <<< 18)
        if p.min then flags <- flags ||| (1 <<< 20)
        if p.botInlineGeo then flags <- flags ||| (1 <<< 21)
        if p.support then flags <- flags ||| (1 <<< 23)
        if p.scam then flags <- flags ||| (1 <<< 24)
        if p.applyMinPhoto then flags <- flags ||| (1 <<< 25)
        if p.fake then flags <- flags ||| (1 <<< 26)
        if p.botAttachMenu then flags <- flags ||| (1 <<< 27)
        if p.premium then flags <- flags ||| (1 <<< 28)
        if p.attachMenuEnabled then flags <- flags ||| (1 <<< 29)
        if p.accessHash.IsSome then flags <- flags ||| (1 <<< 0)
        if p.firstName.IsSome then flags <- flags ||| (1 <<< 1)
        if p.lastName.IsSome then flags <- flags ||| (1 <<< 2)
        if p.username.IsSome then flags <- flags ||| (1 <<< 3)
        if p.phone.IsSome then flags <- flags ||| (1 <<< 4)
        if p.photo.IsSome then flags <- flags ||| (1 <<< 5)
        if p.status.IsSome then flags <- flags ||| (1 <<< 6)
        if p.botInfoVersion.IsSome then flags <- flags ||| (1 <<< 14)
        if p.restrictionReason.IsSome then flags <- flags ||| (1 <<< 18)
        if p.botInlinePlaceholder.IsSome then flags <- flags ||| (1 <<< 19)
        if p.langCode.IsSome then flags <- flags ||| (1 <<< 22)
        if p.emojiStatus.IsSome then flags <- flags ||| (1 <<< 30)
        w.WriteInt32(flags)
        let mutable flags2 = 0
        if p.botCanEdit then flags2 <- flags2 ||| (1 <<< 1)
        if p.closeFriend then flags2 <- flags2 ||| (1 <<< 2)
        if p.storiesHidden then flags2 <- flags2 ||| (1 <<< 3)
        if p.storiesUnavailable then flags2 <- flags2 ||| (1 <<< 4)
        if p.contactRequirePremium then flags2 <- flags2 ||| (1 <<< 10)
        if p.botBusiness then flags2 <- flags2 ||| (1 <<< 11)
        if p.botHasMainApp then flags2 <- flags2 ||| (1 <<< 13)
        if p.botForumView then flags2 <- flags2 ||| (1 <<< 16)
        if p.botForumCanManageTopics then flags2 <- flags2 ||| (1 <<< 17)
        if p.usernames.IsSome then flags2 <- flags2 ||| (1 <<< 0)
        if p.storiesMaxId.IsSome then flags2 <- flags2 ||| (1 <<< 5)
        if p.color.IsSome then flags2 <- flags2 ||| (1 <<< 8)
        if p.profileColor.IsSome then flags2 <- flags2 ||| (1 <<< 9)
        if p.botActiveUsers.IsSome then flags2 <- flags2 ||| (1 <<< 12)
        if p.botVerificationIcon.IsSome then flags2 <- flags2 ||| (1 <<< 14)
        if p.sendPaidMessagesStars.IsSome then flags2 <- flags2 ||| (1 <<< 15)
        w.WriteInt32(flags2)
        w.WriteInt64(p.id)
        p.accessHash |> Option.iter (fun v -> w.WriteInt64(v))
        p.firstName |> Option.iter (fun v -> w.WriteString(v))
        p.lastName |> Option.iter (fun v -> w.WriteString(v))
        p.username |> Option.iter (fun v -> w.WriteString(v))
        p.phone |> Option.iter (fun v -> w.WriteString(v))
        p.photo |> Option.iter (fun v -> writeUserProfilePhoto w v)
        p.status |> Option.iter (fun v -> writeUserStatus w v)
        p.botInfoVersion |> Option.iter (fun v -> w.WriteInt32(v))
        match p.restrictionReason with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()
        p.botInlinePlaceholder |> Option.iter (fun v -> w.WriteString(v))
        p.langCode |> Option.iter (fun v -> w.WriteString(v))
        p.emojiStatus |> Option.iter (fun v -> w.WriteBytes(v))
        match p.usernames with
        | Some arr ->
            w.WriteConstructorId(0x1CB5C415u)
            w.WriteInt32(arr.Length)
            for item in arr do w.WriteBytes(item)
        | None -> ()
        p.storiesMaxId |> Option.iter (fun v -> w.WriteInt32(v))
        p.color |> Option.iter (fun v -> w.WriteBytes(v))
        p.profileColor |> Option.iter (fun v -> w.WriteBytes(v))
        p.botActiveUsers |> Option.iter (fun v -> w.WriteInt32(v))
        p.botVerificationIcon |> Option.iter (fun v -> w.WriteInt64(v))
        p.sendPaidMessagesStars |> Option.iter (fun v -> w.WriteInt64(v))

    and writeUserProfilePhoto (w: TlWriteBuffer) (p: WriteUserProfilePhotoParams) =
        w.WriteConstructorId(0x82D1F706u)
        let mutable flags = 0
        if p.hasVideo then flags <- flags ||| (1 <<< 0)
        if p.personal then flags <- flags ||| (1 <<< 2)
        if p.strippedThumb.IsSome then flags <- flags ||| (1 <<< 1)
        w.WriteInt32(flags)
        w.WriteInt64(p.photoId)
        p.strippedThumb |> Option.iter (fun v -> w.WriteBytes(v))
        w.WriteInt32(p.dcId)

