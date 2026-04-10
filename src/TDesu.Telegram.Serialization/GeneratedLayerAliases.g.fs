// Auto-generated layer CID aliases. Do not edit manually.
// Re-generate with: dotnet run --project src/MTProto.TL.Generator -- --layer-aliases
// Base schema: cached/api.tl (Telethon L216)
// New schema:  src/cached/api.tl (tdesktop L223)

namespace TDesu.Serialization

/// L223→L216 function CID aliases for dual-layer compatibility.
[<RequireQualifiedAccess>]
module GeneratedLayerAliases =

    /// All L223→L216 function CID aliases (17 total).
    let aliases : (uint32 * uint32) array = [|
        0xE42CE9C9u, 0xFE74EF9Fu // account.getUniqueGiftChatThemes
        0x684D214Eu, 0x7CEFA15Du // account.updateColor
        0xD9BA2E54u, 0xE8F463D0u // contacts.addContact
        0x2F98C3D5u, 0xF40C0224u // messages.createForumTopic -> channels.createForumTopic
        0xD2816F10u, 0x34435F2Du // messages.deleteTopicHistory -> channels.deleteTopicHistory
        0xCECC1134u, 0xF4DFA185u // messages.editForumTopic -> channels.editForumTopic
        0x51E842E1u, 0xDFD14005u // messages.editMessage
        0x13704A7Cu, 0x978928CAu // messages.forwardMessages
        0x3BA47BFFu, 0x0DE560D1u // messages.getForumTopics -> channels.getForumTopics
        0xAF0A4A08u, 0xB0831EB9u // messages.getForumTopicsByID -> channels.getForumTopicsByID
        0x0E7841F0u, 0x2950A18Fu // messages.reorderPinnedForumTopics -> channels.reorderPinnedForumTopics
        0x0330E77Fu, 0xAC55D9C1u // messages.sendMedia
        0x545CD15Au, 0xFE05DC9Au // messages.sendMessage
        0x175DF251u, 0x6C2D9026u // messages.updatePinnedForumTopic -> channels.updatePinnedForumTopic
        0x5AF4C73Au, 0xDEB3ABBFu // phone.getGroupCallStreamRtmpUrl
        0x974392F2u, 0x74BBB43Du // phone.toggleGroupCallSettings
        0x78499170u, 0x535983C3u // stories.getPeerMaxIDs
    |]

    /// NotModified constructor CIDs (42 total).
    /// tdesktop rejects these when client sends hash=0 (first request).
    /// Server should return full empty response instead.
    let notModifiedCids : System.Collections.Generic.HashSet<uint32> =
        System.Collections.Generic.HashSet<uint32>([|
            0xE011E1C4u // account.chatThemesNotModified
            0xD08CE645u // account.emojiStatusesNotModified
            0x4FC81D6Eu // account.savedMusicIdsNotModified
            0xFBF6E8B1u // account.savedRingtonesNotModified
            0xF41EB622u // account.themesNotModified
            0x1C199183u // account.wallPapersNotModified
            0xF1D88A5Cu // attachMenuBotsNotModified
            0x5DA674B7u // botAppNotModified
            0xF0173FE9u // channels.channelParticipantsNotModified
            0xB74BA9D2u // contacts.contactsNotModified
            0xDE266EF5u // contacts.topPeersNotModified
            0x481EADFAu // emojiListNotModified
            0x7CDE641Du // help.appConfigNotModified
            0x93CC1F32u // help.countriesListNotModified
            0xBFB9F457u // help.passportConfigNotModified
            0x2BA1F5CEu // help.peerColorsNotModified
            0x970708CCu // help.timezonesListNotModified
            0xE86602C3u // messages.allStickersNotModified
            0xD1ED9A5Bu // messages.availableEffectsNotModified
            0x9F071957u // messages.availableReactionsNotModified
            0xC0E24635u // messages.dhConfigNotModified
            0xF0E3E596u // messages.dialogsNotModified
            0x6FB4AD87u // messages.emojiGroupsNotModified
            0x9E8FA6D3u // messages.favedStickersNotModified
            0xC6DC0C66u // messages.featuredStickersNotModified
            0x0D54B65Du // messages.foundStickerSetsNotModified
            0x6010C534u // messages.foundStickersNotModified
            0x74535F21u // messages.messagesNotModified
            0x5F91EB5Bu // messages.quickRepliesNotModified
            0xB06FDBDFu // messages.reactionsNotModified
            0x0B17F890u // messages.recentStickersNotModified
            0xC01F6FE8u // messages.savedDialogsNotModified
            0xE8025CA2u // messages.savedGifsNotModified
            0x889B59EFu // messages.savedReactionTagsNotModified
            0xD3F924EBu // messages.stickerSetNotModified
            0xF1749A22u // messages.stickersNotModified
            0xA0BA4F17u // payments.starGiftCollectionsNotModified
            0xA388A368u // payments.starGiftsNotModified
            0x564EDAEBu // stories.albumsNotModified
            0x1158FE3Eu // stories.allStoriesNotModified
            0xE3878AA4u // users.savedMusicNotModified
            0x7311CA11u // webPageNotModified
        |])

