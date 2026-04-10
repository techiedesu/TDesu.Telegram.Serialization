// Auto-generated TL constructor IDs. Do not edit manually.
// Re-generate with: dotnet run --project src/MTProto.TL.Generator
// Overrides defined in: src/MTProto.TL.Generator/CidOverrides.fs

namespace TDesu.Serialization

/// Auto-generated constructor IDs from TL schema + client overrides.
[<RequireQualifiedAccess>]
module GeneratedCid =

    // --- MTProto Constructors ---
    [<Literal>]
    let ResPQ = 0x05162463u
    [<Literal>]
    let PQInnerDataDc = 0xA9F55F95u
    [<Literal>]
    let PQInnerDataTempDc = 0x56FDDF88u
    [<Literal>]
    let ServerDHParamsOk = 0xD0E8075Cu
    [<Literal>]
    let ServerDHInnerData = 0xB5890DBAu
    [<Literal>]
    let ClientDHInnerData = 0x6643B654u
    [<Literal>]
    let DhGenOk = 0x3BCBF734u
    [<Literal>]
    let DhGenRetry = 0x46DC1FB9u
    [<Literal>]
    let DhGenFail = 0xA69DAE02u
    [<Literal>]
    let BindAuthKeyInner = 0x75A3F765u
    [<Literal>]
    let RpcResult = 0xF35C6D01u
    [<Literal>]
    let RpcError = 0x2144CA19u
    [<Literal>]
    let RpcAnswerUnknown = 0x5E2AD36Eu
    [<Literal>]
    let RpcAnswerDroppedRunning = 0xCD78E586u
    [<Literal>]
    let RpcAnswerDropped = 0xA43AD8B7u
    [<Literal>]
    let FutureSalt = 0x0949D9DCu
    [<Literal>]
    let FutureSalts = 0xAE500895u
    [<Literal>]
    let Pong = 0x347773C5u
    [<Literal>]
    let DestroySessionOk = 0xE22045FCu
    [<Literal>]
    let DestroySessionNone = 0x62D350C9u
    [<Literal>]
    let NewSessionCreated = 0x9EC20908u
    [<Literal>]
    let Message = 0x5BB8E511u
    [<Literal>]
    let MsgCopy = 0xE06046B2u
    [<Literal>]
    let GzipPacked = 0x3072CFA1u
    [<Literal>]
    let MsgsAck = 0x62D6B459u
    [<Literal>]
    let BadMsgNotification = 0xA7EFF811u
    [<Literal>]
    let BadServerSalt = 0xEDAB447Bu
    [<Literal>]
    let MsgResendReq = 0x7D861A08u
    [<Literal>]
    let MsgsStateReq = 0xDA69FB52u
    [<Literal>]
    let MsgsStateInfo = 0x04DEB57Du
    [<Literal>]
    let MsgsAllInfo = 0x8CC0D131u
    [<Literal>]
    let MsgDetailedInfo = 0x276D3EC6u
    [<Literal>]
    let MsgNewDetailedInfo = 0x809DB6DFu
    [<Literal>]
    let DestroyAuthKeyOk = 0xF660E1D4u
    [<Literal>]
    let DestroyAuthKeyNone = 0x0A9F2259u
    [<Literal>]
    let DestroyAuthKeyFail = 0xEA109B13u
    [<Literal>]
    let HttpWait = 0x9299359Fu

    // --- MTProto Functions ---
    [<Literal>]
    let ReqPqMulti = 0xBE7E8EF1u
    [<Literal>]
    let ReqDHParams = 0xD712E4BEu
    [<Literal>]
    let SetClientDHParams = 0xF5045F1Fu
    [<Literal>]
    let RpcDropAnswer = 0x58E4A740u
    [<Literal>]
    let GetFutureSalts = 0xB921BD04u
    [<Literal>]
    let Ping = 0x7ABE77ECu
    [<Literal>]
    let PingDelayDisconnect = 0xF3427B8Cu
    [<Literal>]
    let DestroySession = 0xE7512126u
    [<Literal>]
    let DestroyAuthKey = 0xD1435160u

    // --- API Constructors ---
    [<Literal>]
    let BoolFalse = 0xBC799737u
    [<Literal>]
    let BoolTrue = 0x997275B5u
    [<Literal>]
    let True = 0x3FEDD339u
    [<Literal>]
    let Error = 0xC4B9F9BBu
    [<Literal>]
    let Null = 0x56730BCCu
    [<Literal>]
    let InputPeerEmpty = 0x7F3B18EAu
    [<Literal>]
    let InputPeerSelf = 0x7DA07EC9u
    [<Literal>]
    let InputPeerChat = 0x35A95CB9u
    [<Literal>]
    let InputPeerUser = 0xDDE8A54Cu
    [<Literal>]
    let InputPeerChannel = 0x27BCBBFCu
    [<Literal>]
    let InputPeerUserFromMessage = 0xA87B0A1Cu
    [<Literal>]
    let InputPeerChannelFromMessage = 0xBD2A0840u
    [<Literal>]
    let InputUserEmpty = 0xB98886CFu
    [<Literal>]
    let InputUserSelf = 0xF7C1B13Fu
    [<Literal>]
    let InputUser = 0xF21158C6u
    [<Literal>]
    let InputUserFromMessage = 0x1DA448E2u
    [<Literal>]
    let InputPhoneContact = 0xF392B7F4u
    [<Literal>]
    let InputFile = 0xF52FF27Fu
    [<Literal>]
    let InputFileBig = 0xFA4F0BB5u
    [<Literal>]
    let InputFileStoryDocument = 0x62DC8B48u
    [<Literal>]
    let InputMediaEmpty = 0x9664F57Fu
    [<Literal>]
    let InputMediaUploadedPhoto = 0x1E287D04u
    [<Literal>]
    let InputMediaPhoto = 0xB3BA0635u
    [<Literal>]
    let InputMediaGeoPoint = 0xF9C44144u
    [<Literal>]
    let InputMediaContact = 0xF8AB7DFBu
    [<Literal>]
    let InputMediaUploadedDocument = 0x037C9330u
    [<Literal>]
    let InputMediaDocument = 0xA8763AB5u
    [<Literal>]
    let InputMediaVenue = 0xC13D1C11u
    [<Literal>]
    let InputMediaPhotoExternal = 0xE5BBFE1Au
    [<Literal>]
    let InputMediaDocumentExternal = 0x779600F9u
    [<Literal>]
    let InputMediaGame = 0xD33F43F3u
    [<Literal>]
    let InputMediaInvoice = 0x405FEF0Du
    [<Literal>]
    let InputMediaGeoLive = 0x971FA843u
    [<Literal>]
    let InputMediaPoll = 0x0F94E5F1u
    [<Literal>]
    let InputMediaDice = 0xE66FBF7Bu
    [<Literal>]
    let InputMediaStory = 0x89FDD778u
    [<Literal>]
    let InputMediaWebPage = 0xC21B8849u
    [<Literal>]
    let InputMediaPaidMedia = 0xC4103386u
    [<Literal>]
    let InputMediaTodo = 0x9FC55FDEu
    [<Literal>]
    let InputChatPhotoEmpty = 0x1CA48F57u
    [<Literal>]
    let InputChatUploadedPhoto = 0xBDCDAEC0u
    [<Literal>]
    let InputChatPhoto = 0x8953AD37u
    [<Literal>]
    let InputGeoPointEmpty = 0xE4C123D6u
    [<Literal>]
    let InputGeoPoint = 0x48222FAFu
    [<Literal>]
    let InputPhotoEmpty = 0x1CD7BF0Du
    [<Literal>]
    let InputPhoto = 0x3BB3B94Au
    [<Literal>]
    let InputFileLocation = 0xDFDAABE1u
    [<Literal>]
    let InputEncryptedFileLocation = 0xF5235D55u
    [<Literal>]
    let InputDocumentFileLocation = 0xBAD07584u
    [<Literal>]
    let InputSecureFileLocation = 0xCBC7EE28u
    [<Literal>]
    let InputTakeoutFileLocation = 0x29BE5899u
    [<Literal>]
    let InputPhotoFileLocation = 0x40181FFEu
    [<Literal>]
    let InputPhotoLegacyFileLocation = 0xD83466F3u
    [<Literal>]
    let InputPeerPhotoFileLocation = 0x37257E99u
    [<Literal>]
    let InputStickerSetThumb = 0x9D84F3DBu
    [<Literal>]
    let InputGroupCallStream = 0x0598A92Au
    [<Literal>]
    let PeerUser = 0x59511722u
    [<Literal>]
    let PeerChat = 0x36C6019Au
    [<Literal>]
    let PeerChannel = 0xA2A5371Eu
    [<Literal>]
    let StorageFileUnknown = 0xAA963B05u
    [<Literal>]
    let StorageFilePartial = 0x40BC6F52u
    [<Literal>]
    let StorageFileJpeg = 0x007EFE0Eu
    [<Literal>]
    let StorageFileGif = 0xCAE1AADFu
    [<Literal>]
    let StorageFilePng = 0x0A4F63C0u
    [<Literal>]
    let StorageFilePdf = 0xAE1E508Du
    [<Literal>]
    let StorageFileMp3 = 0x528A0677u
    [<Literal>]
    let StorageFileMov = 0x4B09EBBCu
    [<Literal>]
    let StorageFileMp4 = 0xB3CEA0E4u
    [<Literal>]
    let StorageFileWebp = 0x1081464Cu
    [<Literal>]
    let UserEmpty = 0xD3BC4B7Au
    [<Literal>]
    let User = 0x020B1422u
    [<Literal>]
    let UserProfilePhotoEmpty = 0x4F11BAE1u
    [<Literal>]
    let UserProfilePhoto = 0x82D1F706u
    [<Literal>]
    let UserStatusEmpty = 0x09D05049u
    [<Literal>]
    let UserStatusOnline = 0xEDB93949u
    [<Literal>]
    let UserStatusOffline = 0x008C703Fu
    [<Literal>]
    let UserStatusRecently = 0x7B197DC8u
    [<Literal>]
    let UserStatusLastWeek = 0x541A1D1Au
    [<Literal>]
    let UserStatusLastMonth = 0x65899777u
    [<Literal>]
    let ChatEmpty = 0x29562865u
    [<Literal>]
    let Chat = 0x41CBF256u
    [<Literal>]
    let ChatForbidden = 0x6592A1A7u
    [<Literal>]
    let Channel = 0xFE685355u
    [<Literal>]
    let ChannelForbidden = 0x17D493D5u
    [<Literal>]
    let ChatFull = 0x2633421Bu
    [<Literal>]
    let ChannelFull = 0xE4E0B29Du
    [<Literal>]
    let ChatParticipant = 0xC02D4007u
    [<Literal>]
    let ChatParticipantCreator = 0xE46BCEE4u
    [<Literal>]
    let ChatParticipantAdmin = 0xA0933F5Bu
    [<Literal>]
    let ChatParticipantsForbidden = 0x8763D3E1u
    [<Literal>]
    let ChatParticipants = 0x3CBC93F8u
    [<Literal>]
    let ChatPhotoEmpty = 0x37C1011Cu
    [<Literal>]
    let ChatPhoto = 0x1C6E1C11u
    [<Literal>]
    let MessageEmpty = 0x90A6CA84u
    [<Literal>]
    let MessageService = 0x7A800E0Au
    [<Literal>]
    let MessageMediaEmpty = 0x3DED6320u
    [<Literal>]
    let MessageMediaPhoto = 0x695150D7u
    [<Literal>]
    let MessageMediaGeo = 0x56E0D474u
    [<Literal>]
    let MessageMediaContact = 0x70322949u
    [<Literal>]
    let MessageMediaUnsupported = 0x9F84F49Eu
    [<Literal>]
    let MessageMediaDocument = 0x52D8CCD9u
    [<Literal>]
    let MessageMediaWebPage = 0xDDF10C3Bu
    [<Literal>]
    let MessageMediaVenue = 0x2EC0533Fu
    [<Literal>]
    let MessageMediaGame = 0xFDB19008u
    [<Literal>]
    let MessageMediaInvoice = 0xF6A548D3u
    [<Literal>]
    let MessageMediaGeoLive = 0xB940C666u
    [<Literal>]
    let MessageMediaPoll = 0x4BD6E798u
    [<Literal>]
    let MessageMediaDice = 0x3F7EE58Bu
    [<Literal>]
    let MessageMediaStory = 0x68CB6283u
    [<Literal>]
    let MessageMediaGiveaway = 0xAA073BEBu
    [<Literal>]
    let MessageMediaGiveawayResults = 0xCEAA3EA1u
    [<Literal>]
    let MessageMediaPaidMedia = 0xA8852491u
    [<Literal>]
    let MessageMediaToDo = 0x8A53B014u
    [<Literal>]
    let MessageActionEmpty = 0xB6AEF7B0u
    [<Literal>]
    let MessageActionChatCreate = 0xBD47CBADu
    [<Literal>]
    let MessageActionChatEditTitle = 0xB5A1CE5Au
    [<Literal>]
    let MessageActionChatEditPhoto = 0x7FCB13A8u
    [<Literal>]
    let MessageActionChatDeletePhoto = 0x95E3FBEFu
    [<Literal>]
    let MessageActionChatAddUser = 0x15CEFD00u
    [<Literal>]
    let MessageActionChatDeleteUser = 0xA43F30CCu
    [<Literal>]
    let MessageActionChatJoinedByLink = 0x031224C3u
    [<Literal>]
    let MessageActionChannelCreate = 0x95D2AC92u
    [<Literal>]
    let MessageActionChatMigrateTo = 0xE1037F92u
    [<Literal>]
    let MessageActionChannelMigrateFrom = 0xEA3948E9u
    [<Literal>]
    let MessageActionPinMessage = 0x94BD38EDu
    [<Literal>]
    let MessageActionHistoryClear = 0x9FBAB604u
    [<Literal>]
    let MessageActionGameScore = 0x92A72876u
    [<Literal>]
    let MessageActionPaymentSentMe = 0xFFA00CCCu
    [<Literal>]
    let MessageActionPaymentSent = 0xC624B16Eu
    [<Literal>]
    let MessageActionPhoneCall = 0x80E11A7Fu
    [<Literal>]
    let MessageActionScreenshotTaken = 0x4792929Bu
    [<Literal>]
    let MessageActionCustomAction = 0xFAE69F56u
    [<Literal>]
    let MessageActionBotAllowed = 0xC516D679u
    [<Literal>]
    let MessageActionSecureValuesSentMe = 0x1B287353u
    [<Literal>]
    let MessageActionSecureValuesSent = 0xD95C6154u
    [<Literal>]
    let MessageActionContactSignUp = 0xF3F25F76u
    [<Literal>]
    let MessageActionGeoProximityReached = 0x98E0D697u
    [<Literal>]
    let MessageActionGroupCall = 0x7A0D7F42u
    [<Literal>]
    let MessageActionInviteToGroupCall = 0x502F92F7u
    [<Literal>]
    let MessageActionSetMessagesTTL = 0x3C134D7Bu
    [<Literal>]
    let MessageActionGroupCallScheduled = 0xB3A07661u
    [<Literal>]
    let MessageActionSetChatTheme = 0xB91BBD3Au
    [<Literal>]
    let MessageActionChatJoinedByRequest = 0xEBBCA3CBu
    [<Literal>]
    let MessageActionWebViewDataSentMe = 0x47DD8079u
    [<Literal>]
    let MessageActionWebViewDataSent = 0xB4C38CB5u
    [<Literal>]
    let MessageActionGiftPremium = 0x6C6274FAu
    [<Literal>]
    let MessageActionTopicCreate = 0x0D999256u
    [<Literal>]
    let MessageActionTopicEdit = 0xC0944820u
    [<Literal>]
    let MessageActionSuggestProfilePhoto = 0x57DE635Eu
    [<Literal>]
    let MessageActionRequestedPeer = 0x31518E9Bu
    [<Literal>]
    let MessageActionSetChatWallPaper = 0x5060A3F4u
    [<Literal>]
    let MessageActionGiftCode = 0x56D03994u
    [<Literal>]
    let MessageActionGiveawayLaunch = 0xA80F51E4u
    [<Literal>]
    let MessageActionGiveawayResults = 0x87E2F155u
    [<Literal>]
    let MessageActionBoostApply = 0xCC02AA6Du
    [<Literal>]
    let MessageActionRequestedPeerSentMe = 0x93B31848u
    [<Literal>]
    let MessageActionPaymentRefunded = 0x41B3E202u
    [<Literal>]
    let MessageActionGiftStars = 0x45D5B021u
    [<Literal>]
    let MessageActionPrizeStars = 0xB00C47A2u
    [<Literal>]
    let MessageActionStarGift = 0xF24DE7FAu
    [<Literal>]
    let MessageActionStarGiftUnique = 0x34F762F3u
    [<Literal>]
    let MessageActionPaidMessagesRefunded = 0xAC1F1FCDu
    [<Literal>]
    let MessageActionPaidMessagesPrice = 0x84B88578u
    [<Literal>]
    let MessageActionConferenceCall = 0x2FFE2F7Au
    [<Literal>]
    let MessageActionTodoCompletions = 0xCC7C5C89u
    [<Literal>]
    let MessageActionTodoAppendTasks = 0xC7EDBC83u
    [<Literal>]
    let MessageActionSuggestedPostApproval = 0xEE7A1596u
    [<Literal>]
    let MessageActionSuggestedPostSuccess = 0x95DDCF69u
    [<Literal>]
    let MessageActionSuggestedPostRefund = 0x69F916F8u
    [<Literal>]
    let MessageActionGiftTon = 0xA8A3C699u
    [<Literal>]
    let Dialog = 0xD58A08C6u
    [<Literal>]
    let DialogFolder = 0x71BD134Cu
    [<Literal>]
    let PhotoEmpty = 0x2331B22Du
    [<Literal>]
    let Photo = 0xFB197A65u
    [<Literal>]
    let PhotoSizeEmpty = 0x0E17E23Cu
    [<Literal>]
    let PhotoSize = 0x75C78E60u
    [<Literal>]
    let PhotoCachedSize = 0x021E1AD6u
    [<Literal>]
    let PhotoStrippedSize = 0xE0B0BC2Eu
    [<Literal>]
    let PhotoSizeProgressive = 0xFA3EFB95u
    [<Literal>]
    let PhotoPathSize = 0xD8214D41u
    [<Literal>]
    let GeoPointEmpty = 0x1117DD5Fu
    [<Literal>]
    let GeoPoint = 0xB2A2F663u
    [<Literal>]
    let AuthSentCode = 0x5E002502u
    [<Literal>]
    let AuthSentCodeSuccess = 0x2390FE44u
    [<Literal>]
    let AuthSentCodePaymentRequired = 0xD7A2FCF9u
    [<Literal>]
    let AuthAuthorization = 0x2EA2C0D4u
    [<Literal>]
    let AuthAuthorizationSignUpRequired = 0x44747E9Au
    [<Literal>]
    let AuthExportedAuthorization = 0xB434E2B8u
    [<Literal>]
    let InputNotifyPeer = 0xB8BC5B0Cu
    [<Literal>]
    let InputNotifyUsers = 0x193B4417u
    [<Literal>]
    let InputNotifyChats = 0x4A95E84Eu
    [<Literal>]
    let InputNotifyBroadcasts = 0xB1DB7C7Eu
    [<Literal>]
    let InputNotifyForumTopic = 0x5C467992u
    [<Literal>]
    let InputPeerNotifySettings = 0xCACB6AE2u
    [<Literal>]
    let PeerNotifySettings = 0x99622C0Cu
    [<Literal>]
    let PeerSettings = 0xF47741F7u
    [<Literal>]
    let WallPaper = 0xA437C3EDu
    [<Literal>]
    let WallPaperNoFile = 0xE0804116u
    [<Literal>]
    let InputReportReasonSpam = 0x58DBCAB8u
    [<Literal>]
    let InputReportReasonViolence = 0x1E22C78Du
    [<Literal>]
    let InputReportReasonPornography = 0x2E59D922u
    [<Literal>]
    let InputReportReasonChildAbuse = 0xADF44EE3u
    [<Literal>]
    let InputReportReasonOther = 0xC1E4A2B1u
    [<Literal>]
    let InputReportReasonCopyright = 0x9B89F93Au
    [<Literal>]
    let InputReportReasonGeoIrrelevant = 0xDBD4FEEDu
    [<Literal>]
    let InputReportReasonFake = 0xF5DDD6E7u
    [<Literal>]
    let InputReportReasonIllegalDrugs = 0x0A8EB2BEu
    [<Literal>]
    let InputReportReasonPersonalDetails = 0x9EC7863Du
    [<Literal>]
    let UserFull = 0xC577B5ADu
    [<Literal>]
    let Contact = 0x145ADE0Bu
    [<Literal>]
    let ImportedContact = 0xC13E3C50u
    [<Literal>]
    let ContactStatus = 0x16D9703Bu
    [<Literal>]
    let ContactsContactsNotModified = 0xB74BA9D2u
    [<Literal>]
    let ContactsContacts = 0xEAE87E42u
    [<Literal>]
    let ContactsImportedContacts = 0x77D01C3Bu
    [<Literal>]
    let ContactsBlocked = 0x0ADE1591u
    [<Literal>]
    let ContactsBlockedSlice = 0xE1664194u
    [<Literal>]
    let MessagesDialogs = 0x15BA6C40u
    [<Literal>]
    let MessagesDialogsSlice = 0x71E094F3u
    [<Literal>]
    let MessagesDialogsNotModified = 0xF0E3E596u
    [<Literal>]
    let MessagesMessages = 0x8C718E87u
    [<Literal>]
    let MessagesMessagesSlice = 0x762B263Du
    [<Literal>]
    let MessagesChannelMessages = 0xC776BA4Eu
    [<Literal>]
    let MessagesMessagesNotModified = 0x74535F21u
    [<Literal>]
    let MessagesChats = 0x64FF9FD5u
    [<Literal>]
    let MessagesChatsSlice = 0x9CD81144u
    [<Literal>]
    let MessagesChatFull = 0xE5D7D19Cu
    [<Literal>]
    let MessagesAffectedHistory = 0xB45C69D1u
    [<Literal>]
    let InputMessagesFilterEmpty = 0x57E2F66Cu
    [<Literal>]
    let InputMessagesFilterPhotos = 0x9609A51Cu
    [<Literal>]
    let InputMessagesFilterVideo = 0x9FC00E65u
    [<Literal>]
    let InputMessagesFilterPhotoVideo = 0x56E9F0E4u
    [<Literal>]
    let InputMessagesFilterDocument = 0x9EDDF188u
    [<Literal>]
    let InputMessagesFilterUrl = 0x7EF0DD87u
    [<Literal>]
    let InputMessagesFilterGif = 0xFFC86587u
    [<Literal>]
    let InputMessagesFilterVoice = 0x50F5C392u
    [<Literal>]
    let InputMessagesFilterMusic = 0x3751B49Eu
    [<Literal>]
    let InputMessagesFilterChatPhotos = 0x3A20ECB8u
    [<Literal>]
    let InputMessagesFilterPhoneCalls = 0x80C99768u
    [<Literal>]
    let InputMessagesFilterRoundVoice = 0x7A7C17A4u
    [<Literal>]
    let InputMessagesFilterRoundVideo = 0xB549DA53u
    [<Literal>]
    let InputMessagesFilterMyMentions = 0xC1F8E69Au
    [<Literal>]
    let InputMessagesFilterGeo = 0xE7026D0Du
    [<Literal>]
    let InputMessagesFilterContacts = 0xE062DB83u
    [<Literal>]
    let InputMessagesFilterPinned = 0x1BB00451u
    [<Literal>]
    let UpdateNewMessage = 0x1F2B0AFDu
    [<Literal>]
    let UpdateMessageID = 0x4E90BFD6u
    [<Literal>]
    let UpdateDeleteMessages = 0xA20DB0E5u
    [<Literal>]
    let UpdateUserTyping = 0xC01E857Fu
    [<Literal>]
    let UpdateChatUserTyping = 0x83487AF0u
    [<Literal>]
    let UpdateChatParticipants = 0x07761198u
    [<Literal>]
    let UpdateUserStatus = 0xE5BDF8DEu
    [<Literal>]
    let UpdateUserName = 0xA7848924u
    [<Literal>]
    let UpdateNewAuthorization = 0x8951ABEFu
    [<Literal>]
    let UpdateNewEncryptedMessage = 0x12BCBD9Au
    [<Literal>]
    let UpdateEncryptedChatTyping = 0x1710F156u
    [<Literal>]
    let UpdateEncryption = 0xB4A2E88Du
    [<Literal>]
    let UpdateEncryptedMessagesRead = 0x38FE25B7u
    [<Literal>]
    let UpdateChatParticipantAdd = 0x3DDA5451u
    [<Literal>]
    let UpdateChatParticipantDelete = 0xE32F3D77u
    [<Literal>]
    let UpdateDcOptions = 0x8E5E9873u
    [<Literal>]
    let UpdateNotifySettings = 0xBEC268EFu
    [<Literal>]
    let UpdateServiceNotification = 0xEBE46819u
    [<Literal>]
    let UpdatePrivacy = 0xEE3B272Au
    [<Literal>]
    let UpdateUserPhone = 0x05492A13u
    [<Literal>]
    let UpdateReadHistoryInbox = 0x9C974FDFu
    [<Literal>]
    let UpdateReadHistoryOutbox = 0x2F2F21BFu
    [<Literal>]
    let UpdateWebPage = 0x7F891213u
    [<Literal>]
    let UpdateReadMessagesContents = 0xF8227181u
    [<Literal>]
    let UpdateChannelTooLong = 0x108D941Fu
    [<Literal>]
    let UpdateChannel = 0x635B4C09u
    [<Literal>]
    let UpdateNewChannelMessage = 0x62BA04D9u
    [<Literal>]
    let UpdateReadChannelInbox = 0x922E6E10u
    [<Literal>]
    let UpdateDeleteChannelMessages = 0xC32D5B12u
    [<Literal>]
    let UpdateChannelMessageViews = 0xF226AC08u
    [<Literal>]
    let UpdateChatParticipantAdmin = 0xD7CA61A2u
    [<Literal>]
    let UpdateNewStickerSet = 0x688A30AAu
    [<Literal>]
    let UpdateStickerSetsOrder = 0x0BB2D201u
    [<Literal>]
    let UpdateStickerSets = 0x31C24808u
    [<Literal>]
    let UpdateSavedGifs = 0x9375341Eu
    [<Literal>]
    let UpdateBotInlineQuery = 0x496F379Cu
    [<Literal>]
    let UpdateBotInlineSend = 0x12F12A07u
    [<Literal>]
    let UpdateEditChannelMessage = 0x1B3F4DF7u
    [<Literal>]
    let UpdateBotCallbackQuery = 0xB9CFC48Du
    [<Literal>]
    let UpdateEditMessage = 0xE40370A3u
    [<Literal>]
    let UpdateInlineBotCallbackQuery = 0x691E9052u
    [<Literal>]
    let UpdateReadChannelOutbox = 0xB75F99A9u
    [<Literal>]
    let UpdateDraftMessage = 0xEDFC111Eu
    [<Literal>]
    let UpdateReadFeaturedStickers = 0x571D2742u
    [<Literal>]
    let UpdateRecentStickers = 0x9A422C20u
    [<Literal>]
    let UpdateConfig = 0xA229DD06u
    [<Literal>]
    let UpdatePtsChanged = 0x3354678Fu
    [<Literal>]
    let UpdateChannelWebPage = 0x2F2BA99Fu
    [<Literal>]
    let UpdateDialogPinned = 0x6E6FE51Cu
    [<Literal>]
    let UpdatePinnedDialogs = 0xFA0F3CA2u
    [<Literal>]
    let UpdateBotWebhookJSON = 0x8317C0C3u
    [<Literal>]
    let UpdateBotWebhookJSONQuery = 0x9B9240A6u
    [<Literal>]
    let UpdateBotShippingQuery = 0xB5AEFD7Du
    [<Literal>]
    let UpdateBotPrecheckoutQuery = 0x8CAA9A96u
    [<Literal>]
    let UpdatePhoneCall = 0xAB0F6B1Eu
    [<Literal>]
    let UpdateLangPackTooLong = 0x46560264u
    [<Literal>]
    let UpdateLangPack = 0x56022F4Du
    [<Literal>]
    let UpdateFavedStickers = 0xE511996Du
    [<Literal>]
    let UpdateChannelReadMessagesContents = 0x25F324F7u
    [<Literal>]
    let UpdateContactsReset = 0x7084A7BEu
    [<Literal>]
    let UpdateChannelAvailableMessages = 0xB23FC698u
    [<Literal>]
    let UpdateDialogUnreadMark = 0xB658F23Eu
    [<Literal>]
    let UpdateMessagePoll = 0xACA1657Bu
    [<Literal>]
    let UpdateChatDefaultBannedRights = 0x54C01850u
    [<Literal>]
    let UpdateFolderPeers = 0x19360DC0u
    [<Literal>]
    let UpdatePeerSettings = 0x6A7E7366u
    [<Literal>]
    let UpdatePeerLocated = 0xB4AFCFB0u
    [<Literal>]
    let UpdateNewScheduledMessage = 0x39A51DFBu
    [<Literal>]
    let UpdateDeleteScheduledMessages = 0xF2A71983u
    [<Literal>]
    let UpdateTheme = 0x8216FBA3u
    [<Literal>]
    let UpdateGeoLiveViewed = 0x871FB939u
    [<Literal>]
    let UpdateLoginToken = 0x564FE691u
    [<Literal>]
    let UpdateMessagePollVote = 0x24F40E77u
    [<Literal>]
    let UpdateDialogFilter = 0x26FFDE7Du
    [<Literal>]
    let UpdateDialogFilterOrder = 0xA5D72105u
    [<Literal>]
    let UpdateDialogFilters = 0x3504914Fu
    [<Literal>]
    let UpdatePhoneCallSignalingData = 0x2661BF09u
    [<Literal>]
    let UpdateChannelMessageForwards = 0xD29A27F4u
    [<Literal>]
    let UpdateReadChannelDiscussionInbox = 0xD6B19546u
    [<Literal>]
    let UpdateReadChannelDiscussionOutbox = 0x695C9E7Cu
    [<Literal>]
    let UpdatePeerBlocked = 0xEBE07752u
    [<Literal>]
    let UpdateChannelUserTyping = 0x8C88C923u
    [<Literal>]
    let UpdatePinnedMessages = 0xED85EAB5u
    [<Literal>]
    let UpdatePinnedChannelMessages = 0x5BB98608u
    [<Literal>]
    let UpdateChat = 0xF89A6A4Eu
    [<Literal>]
    let UpdateGroupCallParticipants = 0xF2EBDB4Eu
    [<Literal>]
    let UpdateGroupCall = 0x97D64341u
    [<Literal>]
    let UpdatePeerHistoryTTL = 0xBB9BB9A5u
    [<Literal>]
    let UpdateChatParticipant = 0xD087663Au
    [<Literal>]
    let UpdateChannelParticipant = 0x985D3ABBu
    [<Literal>]
    let UpdateBotStopped = 0xC4870A49u
    [<Literal>]
    let UpdateGroupCallConnection = 0x0B783982u
    [<Literal>]
    let UpdateBotCommands = 0x4D712F2Eu
    [<Literal>]
    let UpdatePendingJoinRequests = 0x7063C3DBu
    [<Literal>]
    let UpdateBotChatInviteRequester = 0x11DFA986u
    [<Literal>]
    let UpdateMessageReactions = 0x1E297BFAu
    [<Literal>]
    let UpdateAttachMenuBots = 0x17B7A20Bu
    [<Literal>]
    let UpdateWebViewResultSent = 0x1592B79Du
    [<Literal>]
    let UpdateBotMenuButton = 0x14B85813u
    [<Literal>]
    let UpdateSavedRingtones = 0x74D8BE99u
    [<Literal>]
    let UpdateTranscribedAudio = 0x0084CD5Au
    [<Literal>]
    let UpdateReadFeaturedEmojiStickers = 0xFB4C496Cu
    [<Literal>]
    let UpdateUserEmojiStatus = 0x28373599u
    [<Literal>]
    let UpdateRecentEmojiStatuses = 0x30F443DBu
    [<Literal>]
    let UpdateRecentReactions = 0x6F7863F4u
    [<Literal>]
    let UpdateMoveStickerSetToTop = 0x86FCCF85u
    [<Literal>]
    let UpdateMessageExtendedMedia = 0xD5A41724u
    [<Literal>]
    let UpdateChannelPinnedTopic = 0x192EFBE3u
    [<Literal>]
    let UpdateChannelPinnedTopics = 0xFE198602u
    [<Literal>]
    let UpdateUser = 0x20529438u
    [<Literal>]
    let UpdateAutoSaveSettings = 0xEC05B097u
    [<Literal>]
    let UpdateStory = 0x75B3B798u
    [<Literal>]
    let UpdateReadStories = 0xF74E932Bu
    [<Literal>]
    let UpdateStoryID = 0x1BF335B9u
    [<Literal>]
    let UpdateStoriesStealthMode = 0x2C084DC1u
    [<Literal>]
    let UpdateSentStoryReaction = 0x7D627683u
    [<Literal>]
    let UpdateBotChatBoost = 0x904DD49Cu
    [<Literal>]
    let UpdateChannelViewForumAsMessages = 0x07B68920u
    [<Literal>]
    let UpdatePeerWallpaper = 0xAE3F101Du
    [<Literal>]
    let UpdateBotMessageReaction = 0xAC21D3CEu
    [<Literal>]
    let UpdateBotMessageReactions = 0x09CB7759u
    [<Literal>]
    let UpdateSavedDialogPinned = 0xAEAF9E74u
    [<Literal>]
    let UpdatePinnedSavedDialogs = 0x686C85A6u
    [<Literal>]
    let UpdateSavedReactionTags = 0x39C67432u
    [<Literal>]
    let UpdateSmsJob = 0xF16269D4u
    [<Literal>]
    let UpdateQuickReplies = 0xF9470AB2u
    [<Literal>]
    let UpdateNewQuickReply = 0xF53DA717u
    [<Literal>]
    let UpdateDeleteQuickReply = 0x53E6F1ECu
    [<Literal>]
    let UpdateQuickReplyMessage = 0x3E050D0Fu
    [<Literal>]
    let UpdateDeleteQuickReplyMessages = 0x566FE7CDu
    [<Literal>]
    let UpdateBotBusinessConnect = 0x8AE5C97Au
    [<Literal>]
    let UpdateBotNewBusinessMessage = 0x9DDB347Cu
    [<Literal>]
    let UpdateBotEditBusinessMessage = 0x07DF587Cu
    [<Literal>]
    let UpdateBotDeleteBusinessMessage = 0xA02A982Eu
    [<Literal>]
    let UpdateNewStoryReaction = 0x1824E40Bu
    [<Literal>]
    let UpdateStarsBalance = 0x4E80A379u
    [<Literal>]
    let UpdateBusinessBotCallbackQuery = 0x1EA2FDA7u
    [<Literal>]
    let UpdateStarsRevenueStatus = 0xA584B019u
    [<Literal>]
    let UpdateBotPurchasedPaidMedia = 0x283BD312u
    [<Literal>]
    let UpdatePaidReactionPrivacy = 0x8B725FCEu
    [<Literal>]
    let UpdateSentPhoneCode = 0x504AA18Fu
    [<Literal>]
    let UpdateGroupCallChainBlocks = 0xA477288Fu
    [<Literal>]
    let UpdateReadMonoForumInbox = 0x77B0E372u
    [<Literal>]
    let UpdateReadMonoForumOutbox = 0xA4A79376u
    [<Literal>]
    let UpdateMonoForumNoPaidException = 0x9F812B08u
    [<Literal>]
    let UpdatesState = 0xA56C2A3Eu
    [<Literal>]
    let UpdatesDifferenceEmpty = 0x5D75A138u
    [<Literal>]
    let UpdatesDifference = 0x00F49CA0u
    [<Literal>]
    let UpdatesDifferenceSlice = 0xA8FB1981u
    [<Literal>]
    let UpdatesDifferenceTooLong = 0x4AFE8F6Du
    [<Literal>]
    let UpdatesTooLong = 0xE317AF7Eu
    [<Literal>]
    let UpdateShortMessage = 0x313BC7F8u
    [<Literal>]
    let UpdateShortChatMessage = 0x4D6DEEA5u
    [<Literal>]
    let UpdateShort = 0x78D4DEC1u
    [<Literal>]
    let UpdatesCombined = 0x725B04C3u
    [<Literal>]
    let Updates = 0x74AE4240u
    [<Literal>]
    let UpdateShortSentMessage = 0x9015E101u
    [<Literal>]
    let PhotosPhotos = 0x8DCA6AA5u
    [<Literal>]
    let PhotosPhotosSlice = 0x15051F54u
    [<Literal>]
    let PhotosPhoto = 0x20212CA8u
    [<Literal>]
    let UploadFile = 0x096A18D5u
    [<Literal>]
    let UploadFileCdnRedirect = 0xF18CDA44u
    [<Literal>]
    let DcOption = 0x18B7A10Du
    [<Literal>]
    let Config = 0xCC1A241Eu
    [<Literal>]
    let NearestDc = 0x8E1A1775u
    [<Literal>]
    let HelpAppUpdate = 0xCCBBCE30u
    [<Literal>]
    let HelpNoAppUpdate = 0xC45A6536u
    [<Literal>]
    let HelpInviteText = 0x18CB9F78u
    [<Literal>]
    let EncryptedChatEmpty = 0xAB7EC0A0u
    [<Literal>]
    let EncryptedChatWaiting = 0x66B25953u
    [<Literal>]
    let EncryptedChatRequested = 0x48F1D94Cu
    [<Literal>]
    let EncryptedChat = 0x61F0D4C7u
    [<Literal>]
    let EncryptedChatDiscarded = 0x1E1C7C45u
    [<Literal>]
    let InputEncryptedChat = 0xF141B5E1u
    [<Literal>]
    let EncryptedFileEmpty = 0xC21F497Eu
    [<Literal>]
    let EncryptedFile = 0xA8008CD8u
    [<Literal>]
    let InputEncryptedFileEmpty = 0x1837C364u
    [<Literal>]
    let InputEncryptedFileUploaded = 0x64BD0306u
    [<Literal>]
    let InputEncryptedFile = 0x5A17B5E5u
    [<Literal>]
    let InputEncryptedFileBigUploaded = 0x2DC173C8u
    [<Literal>]
    let EncryptedMessage = 0xED18C118u
    [<Literal>]
    let EncryptedMessageService = 0x23734B06u
    [<Literal>]
    let MessagesDhConfigNotModified = 0xC0E24635u
    [<Literal>]
    let MessagesDhConfig = 0x2C221EDDu
    [<Literal>]
    let MessagesSentEncryptedMessage = 0x560F8935u
    [<Literal>]
    let MessagesSentEncryptedFile = 0x9493FF32u
    [<Literal>]
    let InputDocumentEmpty = 0x72F0EAAEu
    [<Literal>]
    let InputDocument = 0x1ABFB575u
    [<Literal>]
    let DocumentEmpty = 0x36F8C871u
    [<Literal>]
    let Document = 0x8FD4C4D8u
    [<Literal>]
    let HelpSupport = 0x17C6B5F6u
    [<Literal>]
    let NotifyPeer = 0x9FD40BD8u
    [<Literal>]
    let NotifyUsers = 0xB4C83B4Cu
    [<Literal>]
    let NotifyChats = 0xC007CEC3u
    [<Literal>]
    let NotifyBroadcasts = 0xD612E8EFu
    [<Literal>]
    let NotifyForumTopic = 0x226E6308u
    [<Literal>]
    let SendMessageTypingAction = 0x16BF744Eu
    [<Literal>]
    let SendMessageCancelAction = 0xFD5EC8F5u
    [<Literal>]
    let SendMessageRecordVideoAction = 0xA187D66Fu
    [<Literal>]
    let SendMessageUploadVideoAction = 0xE9763AECu
    [<Literal>]
    let SendMessageRecordAudioAction = 0xD52F73F7u
    [<Literal>]
    let SendMessageUploadAudioAction = 0xF351D7ABu
    [<Literal>]
    let SendMessageUploadPhotoAction = 0xD1D34A26u
    [<Literal>]
    let SendMessageUploadDocumentAction = 0xAA0CD9E4u
    [<Literal>]
    let SendMessageGeoLocationAction = 0x176F8BA1u
    [<Literal>]
    let SendMessageChooseContactAction = 0x628CBC6Fu
    [<Literal>]
    let SendMessageGamePlayAction = 0xDD6A8F48u
    [<Literal>]
    let SendMessageRecordRoundAction = 0x88F27FBCu
    [<Literal>]
    let SendMessageUploadRoundAction = 0x243E1C66u
    [<Literal>]
    let SpeakingInGroupCallAction = 0xD92C2285u
    [<Literal>]
    let SendMessageHistoryImportAction = 0xDBDA9246u
    [<Literal>]
    let SendMessageChooseStickerAction = 0xB05AC6B1u
    [<Literal>]
    let SendMessageEmojiInteraction = 0x25972BCBu
    [<Literal>]
    let SendMessageEmojiInteractionSeen = 0xB665902Eu
    [<Literal>]
    let ContactsFound = 0xB3134D9Du
    [<Literal>]
    let InputPrivacyKeyStatusTimestamp = 0x4F96CB18u
    [<Literal>]
    let InputPrivacyKeyChatInvite = 0xBDFB0426u
    [<Literal>]
    let InputPrivacyKeyPhoneCall = 0xFABADC5Fu
    [<Literal>]
    let InputPrivacyKeyPhoneP2P = 0xDB9E70D2u
    [<Literal>]
    let InputPrivacyKeyForwards = 0xA4DD4C08u
    [<Literal>]
    let InputPrivacyKeyProfilePhoto = 0x5719BACCu
    [<Literal>]
    let InputPrivacyKeyPhoneNumber = 0x0352DAFAu
    [<Literal>]
    let InputPrivacyKeyAddedByPhone = 0xD1219BDDu
    [<Literal>]
    let InputPrivacyKeyVoiceMessages = 0xAEE69D68u
    [<Literal>]
    let InputPrivacyKeyAbout = 0x3823CC40u
    [<Literal>]
    let InputPrivacyKeyBirthday = 0xD65A11CCu
    [<Literal>]
    let InputPrivacyKeyStarGiftsAutoSave = 0xE1732341u
    [<Literal>]
    let InputPrivacyKeyNoPaidMessages = 0xBDC597B4u
    [<Literal>]
    let PrivacyKeyStatusTimestamp = 0xBC2EAB30u
    [<Literal>]
    let PrivacyKeyChatInvite = 0x500E6DFAu
    [<Literal>]
    let PrivacyKeyPhoneCall = 0x3D662B7Bu
    [<Literal>]
    let PrivacyKeyPhoneP2P = 0x39491CC8u
    [<Literal>]
    let PrivacyKeyForwards = 0x69EC56A3u
    [<Literal>]
    let PrivacyKeyProfilePhoto = 0x96151FEDu
    [<Literal>]
    let PrivacyKeyPhoneNumber = 0xD19AE46Du
    [<Literal>]
    let PrivacyKeyAddedByPhone = 0x42FFD42Bu
    [<Literal>]
    let PrivacyKeyVoiceMessages = 0x0697F414u
    [<Literal>]
    let PrivacyKeyAbout = 0xA486B761u
    [<Literal>]
    let PrivacyKeyBirthday = 0x2000A518u
    [<Literal>]
    let PrivacyKeyStarGiftsAutoSave = 0x2CA4FDF8u
    [<Literal>]
    let PrivacyKeyNoPaidMessages = 0x17D348D2u
    [<Literal>]
    let InputPrivacyValueAllowContacts = 0x0D09E07Bu
    [<Literal>]
    let InputPrivacyValueAllowAll = 0x184B35CEu
    [<Literal>]
    let InputPrivacyValueAllowUsers = 0x131CC67Fu
    [<Literal>]
    let InputPrivacyValueDisallowContacts = 0x0BA52007u
    [<Literal>]
    let InputPrivacyValueDisallowAll = 0xD66B66C9u
    [<Literal>]
    let InputPrivacyValueDisallowUsers = 0x90110467u
    [<Literal>]
    let InputPrivacyValueAllowChatParticipants = 0x840649CFu
    [<Literal>]
    let InputPrivacyValueDisallowChatParticipants = 0xE94F0F86u
    [<Literal>]
    let InputPrivacyValueAllowCloseFriends = 0x2F453E49u
    [<Literal>]
    let InputPrivacyValueAllowPremium = 0x77CDC9F1u
    [<Literal>]
    let InputPrivacyValueAllowBots = 0x5A4FCCE5u
    [<Literal>]
    let InputPrivacyValueDisallowBots = 0xC4E57915u
    [<Literal>]
    let PrivacyValueAllowContacts = 0xFFFE1BACu
    [<Literal>]
    let PrivacyValueAllowAll = 0x65427B82u
    [<Literal>]
    let PrivacyValueAllowUsers = 0xB8905FB2u
    [<Literal>]
    let PrivacyValueDisallowContacts = 0xF888FA1Au
    [<Literal>]
    let PrivacyValueDisallowAll = 0x8B73E763u
    [<Literal>]
    let PrivacyValueDisallowUsers = 0xE4621141u
    [<Literal>]
    let PrivacyValueAllowChatParticipants = 0x6B134E8Eu
    [<Literal>]
    let PrivacyValueDisallowChatParticipants = 0x41C87565u
    [<Literal>]
    let PrivacyValueAllowCloseFriends = 0xF7E8D89Bu
    [<Literal>]
    let PrivacyValueAllowPremium = 0xECE9814Bu
    [<Literal>]
    let PrivacyValueAllowBots = 0x21461B5Du
    [<Literal>]
    let PrivacyValueDisallowBots = 0xF6A5F82Fu
    [<Literal>]
    let AccountPrivacyRules = 0x50A04E45u
    [<Literal>]
    let AccountDaysTTL = 0xB8D0AFDFu
    [<Literal>]
    let DocumentAttributeImageSize = 0x6C37C15Cu
    [<Literal>]
    let DocumentAttributeAnimated = 0x11B58939u
    [<Literal>]
    let DocumentAttributeSticker = 0x6319D612u
    [<Literal>]
    let DocumentAttributeVideo = 0x43C57C48u
    [<Literal>]
    let DocumentAttributeAudio = 0x9852F9C6u
    [<Literal>]
    let DocumentAttributeFilename = 0x15590068u
    [<Literal>]
    let DocumentAttributeHasStickers = 0x9801D2F7u
    [<Literal>]
    let DocumentAttributeCustomEmoji = 0xFD149899u
    [<Literal>]
    let MessagesStickersNotModified = 0xF1749A22u
    [<Literal>]
    let MessagesStickers = 0x30A6EC7Eu
    [<Literal>]
    let StickerPack = 0x12B299D4u
    [<Literal>]
    let MessagesAllStickersNotModified = 0xE86602C3u
    [<Literal>]
    let MessagesAllStickers = 0xCDBBCEBBu
    [<Literal>]
    let MessagesAffectedMessages = 0x84D19185u
    [<Literal>]
    let WebPageEmpty = 0x211A1788u
    [<Literal>]
    let WebPagePending = 0xB0D13E47u
    [<Literal>]
    let WebPage = 0xE89C45B2u
    [<Literal>]
    let WebPageNotModified = 0x7311CA11u
    [<Literal>]
    let Authorization = 0xAD01D61Du
    [<Literal>]
    let AccountAuthorizations = 0x4BFF8EA0u
    [<Literal>]
    let AccountPassword = 0x957B50FBu
    [<Literal>]
    let AccountPasswordSettings = 0x9A5C33E5u
    [<Literal>]
    let AccountPasswordInputSettings = 0xC23727C9u
    [<Literal>]
    let AuthPasswordRecovery = 0x137948A5u
    [<Literal>]
    let ReceivedNotifyMessage = 0xA384B779u
    [<Literal>]
    let ChatInviteExported = 0xA22CBD96u
    [<Literal>]
    let ChatInvitePublicJoinRequests = 0xED107AB7u
    [<Literal>]
    let ChatInviteAlready = 0x5A686D7Cu
    [<Literal>]
    let ChatInvite = 0x5C9D3702u
    [<Literal>]
    let ChatInvitePeek = 0x61695CB0u
    [<Literal>]
    let InputStickerSetEmpty = 0xFFB62B95u
    [<Literal>]
    let InputStickerSetID = 0x9DE7A269u
    [<Literal>]
    let InputStickerSetShortName = 0x861CC8A0u
    [<Literal>]
    let InputStickerSetAnimatedEmoji = 0x028703C8u
    [<Literal>]
    let InputStickerSetDice = 0xE67F520Eu
    [<Literal>]
    let InputStickerSetAnimatedEmojiAnimations = 0x0CDE3739u
    [<Literal>]
    let InputStickerSetPremiumGifts = 0xC88B3B02u
    [<Literal>]
    let InputStickerSetEmojiGenericAnimations = 0x04C4D4CEu
    [<Literal>]
    let InputStickerSetEmojiDefaultStatuses = 0x29D0F5EEu
    [<Literal>]
    let InputStickerSetEmojiDefaultTopicIcons = 0x44C1F8E9u
    [<Literal>]
    let InputStickerSetEmojiChannelDefaultStatuses = 0x49748553u
    [<Literal>]
    let InputStickerSetTonGifts = 0x1CF671A0u
    [<Literal>]
    let StickerSet = 0x2DD14EDCu
    [<Literal>]
    let MessagesStickerSet = 0x6E153F16u
    [<Literal>]
    let MessagesStickerSetNotModified = 0xD3F924EBu
    [<Literal>]
    let BotCommand = 0xC27AC8C7u
    [<Literal>]
    let BotInfo = 0x4D8A0299u
    [<Literal>]
    let KeyboardButton = 0xA2FA4880u
    [<Literal>]
    let KeyboardButtonUrl = 0x258AFF05u
    [<Literal>]
    let KeyboardButtonCallback = 0x35BBDB6Bu
    [<Literal>]
    let KeyboardButtonRequestPhone = 0xB16A6C29u
    [<Literal>]
    let KeyboardButtonRequestGeoLocation = 0xFC796B3Fu
    [<Literal>]
    let KeyboardButtonSwitchInline = 0x93B9FBB5u
    [<Literal>]
    let KeyboardButtonGame = 0x50F41CCFu
    [<Literal>]
    let KeyboardButtonBuy = 0xAFD93FBBu
    [<Literal>]
    let KeyboardButtonUrlAuth = 0x10B78D29u
    [<Literal>]
    let InputKeyboardButtonUrlAuth = 0xD02E7FD4u
    [<Literal>]
    let KeyboardButtonRequestPoll = 0xBBC7515Du
    [<Literal>]
    let InputKeyboardButtonUserProfile = 0xE988037Bu
    [<Literal>]
    let KeyboardButtonUserProfile = 0x308660C1u
    [<Literal>]
    let KeyboardButtonWebView = 0x13767230u
    [<Literal>]
    let KeyboardButtonSimpleWebView = 0xA0C0505Cu
    [<Literal>]
    let KeyboardButtonRequestPeer = 0x53D7BFD8u
    [<Literal>]
    let InputKeyboardButtonRequestPeer = 0xC9662D05u
    [<Literal>]
    let KeyboardButtonCopy = 0x75D2698Eu
    [<Literal>]
    let KeyboardButtonRow = 0x77608B83u
    [<Literal>]
    let ReplyKeyboardHide = 0xA03E5B85u
    [<Literal>]
    let ReplyKeyboardForceReply = 0x86B40B08u
    [<Literal>]
    let ReplyKeyboardMarkup = 0x85DD99D1u
    [<Literal>]
    let ReplyInlineMarkup = 0x48A30254u
    [<Literal>]
    let MessageEntityUnknown = 0xBB92BA95u
    [<Literal>]
    let MessageEntityMention = 0xFA04579Du
    [<Literal>]
    let MessageEntityHashtag = 0x6F635B0Du
    [<Literal>]
    let MessageEntityBotCommand = 0x6CEF8AC7u
    [<Literal>]
    let MessageEntityUrl = 0x6ED02538u
    [<Literal>]
    let MessageEntityEmail = 0x64E475C2u
    [<Literal>]
    let MessageEntityBold = 0xBD610BC9u
    [<Literal>]
    let MessageEntityItalic = 0x826F8B60u
    [<Literal>]
    let MessageEntityCode = 0x28A20571u
    [<Literal>]
    let MessageEntityPre = 0x73924BE0u
    [<Literal>]
    let MessageEntityTextUrl = 0x76A6D327u
    [<Literal>]
    let MessageEntityMentionName = 0xDC7B1140u
    [<Literal>]
    let InputMessageEntityMentionName = 0x208E68C9u
    [<Literal>]
    let MessageEntityPhone = 0x9B69E34Bu
    [<Literal>]
    let MessageEntityCashtag = 0x4C4E743Fu
    [<Literal>]
    let MessageEntityUnderline = 0x9C4E7E8Bu
    [<Literal>]
    let MessageEntityStrike = 0xBF0693D4u
    [<Literal>]
    let MessageEntityBankCard = 0x761E6AF4u
    [<Literal>]
    let MessageEntitySpoiler = 0x32CA960Fu
    [<Literal>]
    let MessageEntityCustomEmoji = 0xC8CF05F8u
    [<Literal>]
    let MessageEntityBlockquote = 0xF1CCAAACu
    [<Literal>]
    let InputChannelEmpty = 0xEE8C1E86u
    [<Literal>]
    let InputChannel = 0xF35AEC28u
    [<Literal>]
    let InputChannelFromMessage = 0x5B934F9Du
    [<Literal>]
    let ContactsResolvedPeer = 0x7F077AD9u
    [<Literal>]
    let MessageRange = 0x0AE30253u
    [<Literal>]
    let UpdatesChannelDifferenceEmpty = 0x3E11AFFBu
    [<Literal>]
    let UpdatesChannelDifferenceTooLong = 0xA4BCC6FEu
    [<Literal>]
    let UpdatesChannelDifference = 0x2064674Eu
    [<Literal>]
    let ChannelMessagesFilterEmpty = 0x94D42EE7u
    [<Literal>]
    let ChannelMessagesFilter = 0xCD77D957u
    [<Literal>]
    let ChannelParticipant = 0xCB397619u
    [<Literal>]
    let ChannelParticipantSelf = 0x4F607BEFu
    [<Literal>]
    let ChannelParticipantCreator = 0x2FE601D3u
    [<Literal>]
    let ChannelParticipantAdmin = 0x34C3BB53u
    [<Literal>]
    let ChannelParticipantBanned = 0x6DF8014Eu
    [<Literal>]
    let ChannelParticipantLeft = 0x1B03F006u
    [<Literal>]
    let ChannelParticipantsRecent = 0xDE3F3C79u
    [<Literal>]
    let ChannelParticipantsAdmins = 0xB4608969u
    [<Literal>]
    let ChannelParticipantsKicked = 0xA3B54985u
    [<Literal>]
    let ChannelParticipantsBots = 0xB0D1865Bu
    [<Literal>]
    let ChannelParticipantsBanned = 0x1427A5E1u
    [<Literal>]
    let ChannelParticipantsSearch = 0x0656AC4Bu
    [<Literal>]
    let ChannelParticipantsContacts = 0xBB6AE88Du
    [<Literal>]
    let ChannelParticipantsMentions = 0xE04B5CEBu
    [<Literal>]
    let ChannelsChannelParticipants = 0x9AB0FEAFu
    [<Literal>]
    let ChannelsChannelParticipantsNotModified = 0xF0173FE9u
    [<Literal>]
    let ChannelsChannelParticipant = 0xDFB80317u
    [<Literal>]
    let HelpTermsOfService = 0x780A0310u
    [<Literal>]
    let MessagesSavedGifsNotModified = 0xE8025CA2u
    [<Literal>]
    let MessagesSavedGifs = 0x84A02A0Du
    [<Literal>]
    let InputBotInlineMessageMediaAuto = 0x3380C786u
    [<Literal>]
    let InputBotInlineMessageText = 0x3DCD7A87u
    [<Literal>]
    let InputBotInlineMessageMediaGeo = 0x96929A85u
    [<Literal>]
    let InputBotInlineMessageMediaVenue = 0x417BBF11u
    [<Literal>]
    let InputBotInlineMessageMediaContact = 0xA6EDBFFDu
    [<Literal>]
    let InputBotInlineMessageGame = 0x4B425864u
    [<Literal>]
    let InputBotInlineMessageMediaInvoice = 0xD7E78225u
    [<Literal>]
    let InputBotInlineMessageMediaWebPage = 0xBDDCC510u
    [<Literal>]
    let InputBotInlineResult = 0x88BF9319u
    [<Literal>]
    let InputBotInlineResultPhoto = 0xA8D864A7u
    [<Literal>]
    let InputBotInlineResultDocument = 0xFFF8FDC4u
    [<Literal>]
    let InputBotInlineResultGame = 0x4FA417F2u
    [<Literal>]
    let BotInlineMessageMediaAuto = 0x764CF810u
    [<Literal>]
    let BotInlineMessageText = 0x8C7F65E2u
    [<Literal>]
    let BotInlineMessageMediaGeo = 0x051846FDu
    [<Literal>]
    let BotInlineMessageMediaVenue = 0x8A86659Cu
    [<Literal>]
    let BotInlineMessageMediaContact = 0x18D1CDC2u
    [<Literal>]
    let BotInlineMessageMediaInvoice = 0x354A9B09u
    [<Literal>]
    let BotInlineMessageMediaWebPage = 0x809AD9A6u
    [<Literal>]
    let BotInlineResult = 0x11965F3Au
    [<Literal>]
    let BotInlineMediaResult = 0x17DB940Bu
    [<Literal>]
    let MessagesBotResults = 0xE021F2F6u
    [<Literal>]
    let ExportedMessageLink = 0x5DAB1AF4u
    [<Literal>]
    let MessageFwdHeader = 0x4E4DF4BBu
    [<Literal>]
    let AuthCodeTypeSms = 0x72A3158Cu
    [<Literal>]
    let AuthCodeTypeCall = 0x741CD3E3u
    [<Literal>]
    let AuthCodeTypeFlashCall = 0x226CCEFBu
    [<Literal>]
    let AuthCodeTypeMissedCall = 0xD61AD6EEu
    [<Literal>]
    let AuthCodeTypeFragmentSms = 0x06ED998Cu
    [<Literal>]
    let AuthSentCodeTypeApp = 0x3DBB5986u
    [<Literal>]
    let AuthSentCodeTypeSms = 0xC000BBA2u
    [<Literal>]
    let AuthSentCodeTypeCall = 0x5353E5A7u
    [<Literal>]
    let AuthSentCodeTypeFlashCall = 0xAB03C6D9u
    [<Literal>]
    let AuthSentCodeTypeMissedCall = 0x82006484u
    [<Literal>]
    let AuthSentCodeTypeEmailCode = 0xF450F59Bu
    [<Literal>]
    let AuthSentCodeTypeSetUpEmailRequired = 0xA5491DEAu
    [<Literal>]
    let AuthSentCodeTypeFragmentSms = 0xD9565C39u
    [<Literal>]
    let AuthSentCodeTypeFirebaseSms = 0x009FD736u
    [<Literal>]
    let AuthSentCodeTypeSmsWord = 0xA416AC81u
    [<Literal>]
    let AuthSentCodeTypeSmsPhrase = 0xB37794AFu
    [<Literal>]
    let MessagesBotCallbackAnswer = 0x36585EA4u
    [<Literal>]
    let MessagesMessageEditData = 0x26B5DDE6u
    [<Literal>]
    let InputBotInlineMessageID = 0x890C3D89u
    [<Literal>]
    let InputBotInlineMessageID64 = 0xB6D915D7u
    [<Literal>]
    let InlineBotSwitchPM = 0x3C20629Fu
    [<Literal>]
    let MessagesPeerDialogs = 0x3371C354u
    [<Literal>]
    let TopPeer = 0xEDCDC05Bu
    [<Literal>]
    let TopPeerCategoryBotsPM = 0xAB661B5Bu
    [<Literal>]
    let TopPeerCategoryBotsInline = 0x148677E2u
    [<Literal>]
    let TopPeerCategoryCorrespondents = 0x0637B7EDu
    [<Literal>]
    let TopPeerCategoryGroups = 0xBD17A14Au
    [<Literal>]
    let TopPeerCategoryChannels = 0x161D9628u
    [<Literal>]
    let TopPeerCategoryPhoneCalls = 0x1E76A78Cu
    [<Literal>]
    let TopPeerCategoryForwardUsers = 0xA8406CA9u
    [<Literal>]
    let TopPeerCategoryForwardChats = 0xFBEEC0F0u
    [<Literal>]
    let TopPeerCategoryBotsApp = 0xFD9E7BECu
    [<Literal>]
    let TopPeerCategoryPeers = 0xFB834291u
    [<Literal>]
    let ContactsTopPeersNotModified = 0xDE266EF5u
    [<Literal>]
    let ContactsTopPeers = 0x70B772A8u
    [<Literal>]
    let ContactsTopPeersDisabled = 0xB52C939Du
    [<Literal>]
    let DraftMessageEmpty = 0x1B0C841Au
    [<Literal>]
    let DraftMessage = 0x96EAA5EBu
    [<Literal>]
    let MessagesFeaturedStickersNotModified = 0xC6DC0C66u
    [<Literal>]
    let MessagesFeaturedStickers = 0xBE382906u
    [<Literal>]
    let MessagesRecentStickersNotModified = 0x0B17F890u
    [<Literal>]
    let MessagesRecentStickers = 0x88D37C56u
    [<Literal>]
    let MessagesArchivedStickers = 0x4FCBA9C8u
    [<Literal>]
    let MessagesStickerSetInstallResultSuccess = 0x38641628u
    [<Literal>]
    let MessagesStickerSetInstallResultArchive = 0x35E410A8u
    [<Literal>]
    let StickerSetCovered = 0x6410A5D2u
    [<Literal>]
    let StickerSetMultiCovered = 0x3407E51Bu
    [<Literal>]
    let StickerSetFullCovered = 0x40D13C0Eu
    [<Literal>]
    let StickerSetNoCovered = 0x77B15D1Cu
    [<Literal>]
    let MaskCoords = 0xAED6DBB2u
    [<Literal>]
    let InputStickeredMediaPhoto = 0x4A992157u
    [<Literal>]
    let InputStickeredMediaDocument = 0x0438865Bu
    [<Literal>]
    let Game = 0xBDF9653Bu
    [<Literal>]
    let InputGameID = 0x032C3E77u
    [<Literal>]
    let InputGameShortName = 0xC331E80Au
    [<Literal>]
    let HighScore = 0x73A379EBu
    [<Literal>]
    let MessagesHighScores = 0x9A3BFD99u
    [<Literal>]
    let TextEmpty = 0xDC3D824Fu
    [<Literal>]
    let TextPlain = 0x744694E0u
    [<Literal>]
    let TextBold = 0x6724ABC4u
    [<Literal>]
    let TextItalic = 0xD912A59Cu
    [<Literal>]
    let TextUnderline = 0xC12622C4u
    [<Literal>]
    let TextStrike = 0x9BF8BB95u
    [<Literal>]
    let TextFixed = 0x6C3F19B9u
    [<Literal>]
    let TextUrl = 0x3C2884C1u
    [<Literal>]
    let TextEmail = 0xDE5A0DD6u
    [<Literal>]
    let TextConcat = 0x7E6260D7u
    [<Literal>]
    let TextSubscript = 0xED6A8504u
    [<Literal>]
    let TextSuperscript = 0xC7FB5E01u
    [<Literal>]
    let TextMarked = 0x034B8621u
    [<Literal>]
    let TextPhone = 0x1CCB966Au
    [<Literal>]
    let TextImage = 0x081CCF4Fu
    [<Literal>]
    let TextAnchor = 0x35553762u
    [<Literal>]
    let PageBlockUnsupported = 0x13567E8Au
    [<Literal>]
    let PageBlockTitle = 0x70ABC3FDu
    [<Literal>]
    let PageBlockSubtitle = 0x8FFA9A1Fu
    [<Literal>]
    let PageBlockAuthorDate = 0xBAAFE5E0u
    [<Literal>]
    let PageBlockHeader = 0xBFD064ECu
    [<Literal>]
    let PageBlockSubheader = 0xF12BB6E1u
    [<Literal>]
    let PageBlockParagraph = 0x467A0766u
    [<Literal>]
    let PageBlockPreformatted = 0xC070D93Eu
    [<Literal>]
    let PageBlockFooter = 0x48870999u
    [<Literal>]
    let PageBlockDivider = 0xDB20B188u
    [<Literal>]
    let PageBlockAnchor = 0xCE0D37B0u
    [<Literal>]
    let PageBlockList = 0xE4E88011u
    [<Literal>]
    let PageBlockBlockquote = 0x263D7C26u
    [<Literal>]
    let PageBlockPullquote = 0x4F4456D3u
    [<Literal>]
    let PageBlockPhoto = 0x1759C560u
    [<Literal>]
    let PageBlockVideo = 0x7C8FE7B6u
    [<Literal>]
    let PageBlockCover = 0x39F23300u
    [<Literal>]
    let PageBlockEmbed = 0xA8718DC5u
    [<Literal>]
    let PageBlockEmbedPost = 0xF259A80Bu
    [<Literal>]
    let PageBlockCollage = 0x65A0FA4Du
    [<Literal>]
    let PageBlockSlideshow = 0x031F9590u
    [<Literal>]
    let PageBlockChannel = 0xEF1751B5u
    [<Literal>]
    let PageBlockAudio = 0x804361EAu
    [<Literal>]
    let PageBlockKicker = 0x1E148390u
    [<Literal>]
    let PageBlockTable = 0xBF4DEA82u
    [<Literal>]
    let PageBlockOrderedList = 0x9A8AE1E1u
    [<Literal>]
    let PageBlockDetails = 0x76768BEDu
    [<Literal>]
    let PageBlockRelatedArticles = 0x16115A96u
    [<Literal>]
    let PageBlockMap = 0xA44F3EF6u
    [<Literal>]
    let PhoneCallDiscardReasonMissed = 0x85E42301u
    [<Literal>]
    let PhoneCallDiscardReasonDisconnect = 0xE095C1A0u
    [<Literal>]
    let PhoneCallDiscardReasonHangup = 0x57ADC690u
    [<Literal>]
    let PhoneCallDiscardReasonBusy = 0xFAF7E8C9u
    [<Literal>]
    let PhoneCallDiscardReasonMigrateConferenceCall = 0x9FBBF1F7u
    [<Literal>]
    let DataJSON = 0x7D748D04u
    [<Literal>]
    let LabeledPrice = 0xCB296BF8u
    [<Literal>]
    let Invoice = 0x049EE584u
    [<Literal>]
    let PaymentCharge = 0xEA02C27Eu
    [<Literal>]
    let PostAddress = 0x1E8CAAEBu
    [<Literal>]
    let PaymentRequestedInfo = 0x909C3F94u
    [<Literal>]
    let PaymentSavedCredentialsCard = 0xCDC27A1Fu
    [<Literal>]
    let WebDocument = 0x1C570ED1u
    [<Literal>]
    let WebDocumentNoProxy = 0xF9C8BCC6u
    [<Literal>]
    let InputWebDocument = 0x9BED434Du
    [<Literal>]
    let InputWebFileLocation = 0xC239D686u
    [<Literal>]
    let InputWebFileGeoPointLocation = 0x9F2221C9u
    [<Literal>]
    let InputWebFileAudioAlbumThumbLocation = 0xF46FE924u
    [<Literal>]
    let UploadWebFile = 0x21E753BCu
    [<Literal>]
    let PaymentsPaymentForm = 0xA0058751u
    [<Literal>]
    let PaymentsPaymentFormStars = 0x7BF6B15Cu
    [<Literal>]
    let PaymentsPaymentFormStarGift = 0xB425CFE1u
    [<Literal>]
    let PaymentsValidatedRequestedInfo = 0xD1451883u
    [<Literal>]
    let PaymentsPaymentResult = 0x4E5F810Du
    [<Literal>]
    let PaymentsPaymentVerificationNeeded = 0xD8411139u
    [<Literal>]
    let PaymentsPaymentReceipt = 0x70C4FE03u
    [<Literal>]
    let PaymentsPaymentReceiptStars = 0xDABBF83Au
    [<Literal>]
    let PaymentsSavedInfo = 0xFB8FE43Cu
    [<Literal>]
    let InputPaymentCredentialsSaved = 0xC10EB2CFu
    [<Literal>]
    let InputPaymentCredentials = 0x3417D728u
    [<Literal>]
    let InputPaymentCredentialsApplePay = 0x0AA1C39Fu
    [<Literal>]
    let InputPaymentCredentialsGooglePay = 0x8AC32801u
    [<Literal>]
    let AccountTmpPassword = 0xDB64FD34u
    [<Literal>]
    let ShippingOption = 0xB6213CDFu
    [<Literal>]
    let InputStickerSetItem = 0x32DA9E9Cu
    [<Literal>]
    let InputPhoneCall = 0x1E36FDEDu
    [<Literal>]
    let PhoneCallEmpty = 0x5366C915u
    [<Literal>]
    let PhoneCallWaiting = 0xC5226F17u
    [<Literal>]
    let PhoneCallRequested = 0x14B0ED0Cu
    [<Literal>]
    let PhoneCallAccepted = 0x3660C311u
    [<Literal>]
    let PhoneCall = 0x30535AF5u
    [<Literal>]
    let PhoneCallDiscarded = 0x50CA4DE1u
    [<Literal>]
    let PhoneConnection = 0x9CC123C7u
    [<Literal>]
    let PhoneConnectionWebrtc = 0x635FE375u
    [<Literal>]
    let PhoneCallProtocol = 0xFC878FC8u
    [<Literal>]
    let PhonePhoneCall = 0xEC82E140u
    [<Literal>]
    let UploadCdnFileReuploadNeeded = 0xEEA8E46Eu
    [<Literal>]
    let UploadCdnFile = 0xA99FCA4Fu
    [<Literal>]
    let CdnPublicKey = 0xC982EABAu
    [<Literal>]
    let CdnConfig = 0x5725E40Au
    [<Literal>]
    let LangPackString = 0xCAD181F6u
    [<Literal>]
    let LangPackStringPluralized = 0x6C47AC9Fu
    [<Literal>]
    let LangPackStringDeleted = 0x2979EEB2u
    [<Literal>]
    let LangPackDifference = 0xF385C1F6u
    [<Literal>]
    let LangPackLanguage = 0xEECA5CE3u
    [<Literal>]
    let ChannelAdminLogEventActionChangeTitle = 0xE6DFB825u
    [<Literal>]
    let ChannelAdminLogEventActionChangeAbout = 0x55188A2Eu
    [<Literal>]
    let ChannelAdminLogEventActionChangeUsername = 0x6A4AFC38u
    [<Literal>]
    let ChannelAdminLogEventActionChangePhoto = 0x434BD2AFu
    [<Literal>]
    let ChannelAdminLogEventActionToggleInvites = 0x1B7907AEu
    [<Literal>]
    let ChannelAdminLogEventActionToggleSignatures = 0x26AE0971u
    [<Literal>]
    let ChannelAdminLogEventActionUpdatePinned = 0xE9E82C18u
    [<Literal>]
    let ChannelAdminLogEventActionEditMessage = 0x709B2405u
    [<Literal>]
    let ChannelAdminLogEventActionDeleteMessage = 0x42E047BBu
    [<Literal>]
    let ChannelAdminLogEventActionParticipantJoin = 0x183040D3u
    [<Literal>]
    let ChannelAdminLogEventActionParticipantLeave = 0xF89777F2u
    [<Literal>]
    let ChannelAdminLogEventActionParticipantInvite = 0xE31C34D8u
    [<Literal>]
    let ChannelAdminLogEventActionParticipantToggleBan = 0xE6D83D7Eu
    [<Literal>]
    let ChannelAdminLogEventActionParticipantToggleAdmin = 0xD5676710u
    [<Literal>]
    let ChannelAdminLogEventActionChangeStickerSet = 0xB1C3CAA7u
    [<Literal>]
    let ChannelAdminLogEventActionTogglePreHistoryHidden = 0x5F5C95F1u
    [<Literal>]
    let ChannelAdminLogEventActionDefaultBannedRights = 0x2DF5FC0Au
    [<Literal>]
    let ChannelAdminLogEventActionStopPoll = 0x8F079643u
    [<Literal>]
    let ChannelAdminLogEventActionChangeLinkedChat = 0x050C7AC8u
    [<Literal>]
    let ChannelAdminLogEventActionChangeLocation = 0x0E6B76AEu
    [<Literal>]
    let ChannelAdminLogEventActionToggleSlowMode = 0x53909779u
    [<Literal>]
    let ChannelAdminLogEventActionStartGroupCall = 0x23209745u
    [<Literal>]
    let ChannelAdminLogEventActionDiscardGroupCall = 0xDB9F9140u
    [<Literal>]
    let ChannelAdminLogEventActionParticipantMute = 0xF92424D2u
    [<Literal>]
    let ChannelAdminLogEventActionParticipantUnmute = 0xE64429C0u
    [<Literal>]
    let ChannelAdminLogEventActionToggleGroupCallSetting = 0x56D6A247u
    [<Literal>]
    let ChannelAdminLogEventActionParticipantJoinByInvite = 0xFE9FC158u
    [<Literal>]
    let ChannelAdminLogEventActionExportedInviteDelete = 0x5A50FCA4u
    [<Literal>]
    let ChannelAdminLogEventActionExportedInviteRevoke = 0x410A134Eu
    [<Literal>]
    let ChannelAdminLogEventActionExportedInviteEdit = 0xE90EBB59u
    [<Literal>]
    let ChannelAdminLogEventActionParticipantVolume = 0x3E7F6847u
    [<Literal>]
    let ChannelAdminLogEventActionChangeHistoryTTL = 0x6E941A38u
    [<Literal>]
    let ChannelAdminLogEventActionParticipantJoinByRequest = 0xAFB6144Au
    [<Literal>]
    let ChannelAdminLogEventActionToggleNoForwards = 0xCB2AC766u
    [<Literal>]
    let ChannelAdminLogEventActionSendMessage = 0x278F2868u
    [<Literal>]
    let ChannelAdminLogEventActionChangeAvailableReactions = 0xBE4E0EF8u
    [<Literal>]
    let ChannelAdminLogEventActionChangeUsernames = 0xF04FB3A9u
    [<Literal>]
    let ChannelAdminLogEventActionToggleForum = 0x02CC6383u
    [<Literal>]
    let ChannelAdminLogEventActionCreateTopic = 0x58707D28u
    [<Literal>]
    let ChannelAdminLogEventActionEditTopic = 0xF06FE208u
    [<Literal>]
    let ChannelAdminLogEventActionDeleteTopic = 0xAE168909u
    [<Literal>]
    let ChannelAdminLogEventActionPinTopic = 0x5D8D353Bu
    [<Literal>]
    let ChannelAdminLogEventActionToggleAntiSpam = 0x64F36DFCu
    [<Literal>]
    let ChannelAdminLogEventActionChangePeerColor = 0x5796E780u
    [<Literal>]
    let ChannelAdminLogEventActionChangeProfilePeerColor = 0x5E477B25u
    [<Literal>]
    let ChannelAdminLogEventActionChangeWallpaper = 0x31BB5D52u
    [<Literal>]
    let ChannelAdminLogEventActionChangeEmojiStatus = 0x3EA9FEB1u
    [<Literal>]
    let ChannelAdminLogEventActionChangeEmojiStickerSet = 0x46D840ABu
    [<Literal>]
    let ChannelAdminLogEventActionToggleSignatureProfiles = 0x60A79C79u
    [<Literal>]
    let ChannelAdminLogEventActionParticipantSubExtend = 0x64642DB3u
    [<Literal>]
    let ChannelAdminLogEventActionToggleAutotranslation = 0xC517F77Eu
    [<Literal>]
    let ChannelAdminLogEvent = 0x1FAD68CDu
    [<Literal>]
    let ChannelsAdminLogResults = 0xED8AF74Du
    [<Literal>]
    let ChannelAdminLogEventsFilter = 0xEA107AE4u
    [<Literal>]
    let PopularContact = 0x5CE14175u
    [<Literal>]
    let MessagesFavedStickersNotModified = 0x9E8FA6D3u
    [<Literal>]
    let MessagesFavedStickers = 0x2CB51097u
    [<Literal>]
    let RecentMeUrlUnknown = 0x46E1D13Du
    [<Literal>]
    let RecentMeUrlUser = 0xB92C09E2u
    [<Literal>]
    let RecentMeUrlChat = 0xB2DA71D2u
    [<Literal>]
    let RecentMeUrlChatInvite = 0xEB49081Du
    [<Literal>]
    let RecentMeUrlStickerSet = 0xBC0A57DCu
    [<Literal>]
    let HelpRecentMeUrls = 0x0E0310D7u
    [<Literal>]
    let InputSingleMedia = 0x1CC6E91Fu
    [<Literal>]
    let WebAuthorization = 0xA6F8F452u
    [<Literal>]
    let AccountWebAuthorizations = 0xED56C9FCu
    [<Literal>]
    let InputMessageID = 0xA676A322u
    [<Literal>]
    let InputMessageReplyTo = 0xBAD88395u
    [<Literal>]
    let InputMessagePinned = 0x86872538u
    [<Literal>]
    let InputMessageCallbackQuery = 0xACFA1A7Eu
    [<Literal>]
    let InputDialogPeer = 0xFCAAFEB7u
    [<Literal>]
    let InputDialogPeerFolder = 0x64600527u
    [<Literal>]
    let DialogPeer = 0xE56DBF05u
    [<Literal>]
    let DialogPeerFolder = 0x514519E2u
    [<Literal>]
    let MessagesFoundStickerSetsNotModified = 0x0D54B65Du
    [<Literal>]
    let MessagesFoundStickerSets = 0x8AF09DD2u
    [<Literal>]
    let FileHash = 0xF39B035Cu
    [<Literal>]
    let InputClientProxy = 0x75588B3Fu
    [<Literal>]
    let HelpTermsOfServiceUpdateEmpty = 0xE3309F7Fu
    [<Literal>]
    let HelpTermsOfServiceUpdate = 0x28ECF961u
    [<Literal>]
    let InputSecureFileUploaded = 0x3334B0F0u
    [<Literal>]
    let InputSecureFile = 0x5367E5BEu
    [<Literal>]
    let SecureFileEmpty = 0x64199744u
    [<Literal>]
    let SecureFile = 0x7D09C27Eu
    [<Literal>]
    let SecureData = 0x8AEABEC3u
    [<Literal>]
    let SecurePlainPhone = 0x7D6099DDu
    [<Literal>]
    let SecurePlainEmail = 0x21EC5A5Fu
    [<Literal>]
    let SecureValueTypePersonalDetails = 0x9D2A81E3u
    [<Literal>]
    let SecureValueTypePassport = 0x3DAC6A00u
    [<Literal>]
    let SecureValueTypeDriverLicense = 0x06E425C4u
    [<Literal>]
    let SecureValueTypeIdentityCard = 0xA0D0744Bu
    [<Literal>]
    let SecureValueTypeInternalPassport = 0x99A48F23u
    [<Literal>]
    let SecureValueTypeAddress = 0xCBE31E26u
    [<Literal>]
    let SecureValueTypeUtilityBill = 0xFC36954Eu
    [<Literal>]
    let SecureValueTypeBankStatement = 0x89137C0Du
    [<Literal>]
    let SecureValueTypeRentalAgreement = 0x8B883488u
    [<Literal>]
    let SecureValueTypePassportRegistration = 0x99E3806Au
    [<Literal>]
    let SecureValueTypeTemporaryRegistration = 0xEA02EC33u
    [<Literal>]
    let SecureValueTypePhone = 0xB320AADBu
    [<Literal>]
    let SecureValueTypeEmail = 0x8E3CA7EEu
    [<Literal>]
    let SecureValue = 0x187FA0CAu
    [<Literal>]
    let InputSecureValue = 0xDB21D0A7u
    [<Literal>]
    let SecureValueHash = 0xED1ECDB0u
    [<Literal>]
    let SecureValueErrorData = 0xE8A40BD9u
    [<Literal>]
    let SecureValueErrorFrontSide = 0x00BE3DFAu
    [<Literal>]
    let SecureValueErrorReverseSide = 0x868A2AA5u
    [<Literal>]
    let SecureValueErrorSelfie = 0xE537CED6u
    [<Literal>]
    let SecureValueErrorFile = 0x7A700873u
    [<Literal>]
    let SecureValueErrorFiles = 0x666220E9u
    [<Literal>]
    let SecureValueError = 0x869D758Fu
    [<Literal>]
    let SecureValueErrorTranslationFile = 0xA1144770u
    [<Literal>]
    let SecureValueErrorTranslationFiles = 0x34636DD8u
    [<Literal>]
    let SecureCredentialsEncrypted = 0x33F0EA47u
    [<Literal>]
    let AccountAuthorizationForm = 0xAD2E1CD8u
    [<Literal>]
    let AccountSentEmailCode = 0x811F854Fu
    [<Literal>]
    let HelpDeepLinkInfoEmpty = 0x66AFA166u
    [<Literal>]
    let HelpDeepLinkInfo = 0x6A4EE832u
    [<Literal>]
    let SavedPhoneContact = 0x1142BD56u
    [<Literal>]
    let AccountTakeout = 0x4DBA4501u
    [<Literal>]
    let PasswordKdfAlgoUnknown = 0xD45AB096u
    [<Literal>]
    let PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow = 0x3A912D4Au
    [<Literal>]
    let SecurePasswordKdfAlgoUnknown = 0x004A8537u
    [<Literal>]
    let SecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000 = 0xBBF2DDA0u
    [<Literal>]
    let SecurePasswordKdfAlgoSHA512 = 0x86471D92u
    [<Literal>]
    let SecureSecretSettings = 0x1527BCACu
    [<Literal>]
    let InputCheckPasswordEmpty = 0x9880F658u
    [<Literal>]
    let InputCheckPasswordSRP = 0xD27FF082u
    [<Literal>]
    let SecureRequiredType = 0x829D99DAu
    [<Literal>]
    let SecureRequiredTypeOneOf = 0x027477B4u
    [<Literal>]
    let HelpPassportConfigNotModified = 0xBFB9F457u
    [<Literal>]
    let HelpPassportConfig = 0xA098D6AFu
    [<Literal>]
    let InputAppEvent = 0x1D1B1245u
    [<Literal>]
    let JsonObjectValue = 0xC0DE1BD9u
    [<Literal>]
    let JsonNull = 0x3F6D7B68u
    [<Literal>]
    let JsonBool = 0xC7345E6Au
    [<Literal>]
    let JsonNumber = 0x2BE0DFA4u
    [<Literal>]
    let JsonString = 0xB71E767Au
    [<Literal>]
    let JsonArray = 0xF7444763u
    [<Literal>]
    let JsonObject = 0x99C1D49Du
    [<Literal>]
    let PageTableCell = 0x34566B6Au
    [<Literal>]
    let PageTableRow = 0xE0C0C5E5u
    [<Literal>]
    let PageCaption = 0x6F747657u
    [<Literal>]
    let PageListItemText = 0xB92FB6CDu
    [<Literal>]
    let PageListItemBlocks = 0x25E073FCu
    [<Literal>]
    let PageListOrderedItemText = 0x5E068047u
    [<Literal>]
    let PageListOrderedItemBlocks = 0x98DD8936u
    [<Literal>]
    let PageRelatedArticle = 0xB390DC08u
    [<Literal>]
    let Page = 0x98657F0Du
    [<Literal>]
    let HelpSupportName = 0x8C05F1C9u
    [<Literal>]
    let HelpUserInfoEmpty = 0xF3AE2EEDu
    [<Literal>]
    let HelpUserInfo = 0x01EB3758u
    [<Literal>]
    let PollAnswer = 0xFF16E2CAu
    [<Literal>]
    let Poll = 0x58747131u
    [<Literal>]
    let PollAnswerVoters = 0x3B6DDAD2u
    [<Literal>]
    let PollResults = 0x7ADF2420u
    [<Literal>]
    let ChatOnlines = 0xF041E250u
    [<Literal>]
    let StatsURL = 0x47A971E0u
    [<Literal>]
    let ChatAdminRights = 0x5FB224D5u
    [<Literal>]
    let ChatBannedRights = 0x9F120418u
    [<Literal>]
    let InputWallPaper = 0xE630B979u
    [<Literal>]
    let InputWallPaperSlug = 0x72091C80u
    [<Literal>]
    let InputWallPaperNoFile = 0x967A462Eu
    [<Literal>]
    let AccountWallPapersNotModified = 0x1C199183u
    [<Literal>]
    let AccountWallPapers = 0xCDC3858Cu
    [<Literal>]
    let CodeSettings = 0xAD253D78u
    [<Literal>]
    let WallPaperSettings = 0x372EFCD0u
    [<Literal>]
    let AutoDownloadSettings = 0xBAA57628u
    [<Literal>]
    let AccountAutoDownloadSettings = 0x63CACF26u
    [<Literal>]
    let EmojiKeyword = 0xD5B3B9F9u
    [<Literal>]
    let EmojiKeywordDeleted = 0x236DF622u
    [<Literal>]
    let EmojiKeywordsDifference = 0x5CC761BDu
    [<Literal>]
    let EmojiURL = 0xA575739Du
    [<Literal>]
    let EmojiLanguage = 0xB3FB5361u
    [<Literal>]
    let Folder = 0xFF544E65u
    [<Literal>]
    let InputFolderPeer = 0xFBD2C296u
    [<Literal>]
    let FolderPeer = 0xE9BAA668u
    [<Literal>]
    let MessagesSearchCounter = 0xE844EBFFu
    [<Literal>]
    let UrlAuthResultRequest = 0x92D33A0Eu
    [<Literal>]
    let UrlAuthResultAccepted = 0x8F8C0E4Eu
    [<Literal>]
    let UrlAuthResultDefault = 0xA9D6DB1Fu
    [<Literal>]
    let ChannelLocationEmpty = 0xBFB5AD8Bu
    [<Literal>]
    let ChannelLocation = 0x209B82DBu
    [<Literal>]
    let PeerLocated = 0xCA461B5Du
    [<Literal>]
    let PeerSelfLocated = 0xF8EC284Bu
    [<Literal>]
    let RestrictionReason = 0xD072ACB4u
    [<Literal>]
    let InputTheme = 0x3C5693E9u
    [<Literal>]
    let InputThemeSlug = 0xF5890DF1u
    [<Literal>]
    let Theme = 0xA00E67D6u
    [<Literal>]
    let AccountThemesNotModified = 0xF41EB622u
    [<Literal>]
    let AccountThemes = 0x9A3D8C6Du
    [<Literal>]
    let AuthLoginToken = 0x629F1980u
    [<Literal>]
    let AuthLoginTokenMigrateTo = 0x068E9916u
    [<Literal>]
    let AuthLoginTokenSuccess = 0x390D5C5Eu
    [<Literal>]
    let AccountContentSettings = 0x57E28221u
    [<Literal>]
    let MessagesInactiveChats = 0xA927FEC5u
    [<Literal>]
    let BaseThemeClassic = 0xC3A12462u
    [<Literal>]
    let BaseThemeDay = 0xFBD81688u
    [<Literal>]
    let BaseThemeNight = 0xB7B31EA8u
    [<Literal>]
    let BaseThemeTinted = 0x6D5F77EEu
    [<Literal>]
    let BaseThemeArctic = 0x5B11125Au
    [<Literal>]
    let InputThemeSettings = 0x8FDE504Fu
    [<Literal>]
    let ThemeSettings = 0xFA58B6D4u
    [<Literal>]
    let WebPageAttributeTheme = 0x54B56617u
    [<Literal>]
    let WebPageAttributeStory = 0x2E94C3E7u
    [<Literal>]
    let WebPageAttributeStickerSet = 0x50CC03D3u
    [<Literal>]
    let WebPageAttributeUniqueStarGift = 0xCF6F6DB8u
    [<Literal>]
    let WebPageAttributeStarGiftCollection = 0x31CAD303u
    [<Literal>]
    let MessagesVotesList = 0x4899484Eu
    [<Literal>]
    let BankCardOpenUrl = 0xF568028Au
    [<Literal>]
    let PaymentsBankCardData = 0x3E24E573u
    [<Literal>]
    let DialogFilter = 0xAA472651u
    [<Literal>]
    let DialogFilterDefault = 0x363293AEu
    [<Literal>]
    let DialogFilterChatlist = 0x96537BD7u
    [<Literal>]
    let DialogFilterSuggested = 0x77744D4Au
    [<Literal>]
    let StatsDateRangeDays = 0xB637EDAFu
    [<Literal>]
    let StatsAbsValueAndPrev = 0xCB43ACDEu
    [<Literal>]
    let StatsPercentValue = 0xCBCE2FE0u
    [<Literal>]
    let StatsGraphAsync = 0x4A27EB2Du
    [<Literal>]
    let StatsGraphError = 0xBEDC9822u
    [<Literal>]
    let StatsGraph = 0x8EA464B6u
    [<Literal>]
    let StatsBroadcastStats = 0x396CA5FCu
    [<Literal>]
    let HelpPromoDataEmpty = 0x98F6AC75u
    [<Literal>]
    let HelpPromoData = 0x08A4D87Au
    [<Literal>]
    let VideoSize = 0xDE33B094u
    [<Literal>]
    let VideoSizeEmojiMarkup = 0xF85C413Cu
    [<Literal>]
    let VideoSizeStickerMarkup = 0x0DA082FEu
    [<Literal>]
    let StatsGroupTopPoster = 0x9D04AF9Bu
    [<Literal>]
    let StatsGroupTopAdmin = 0xD7584C87u
    [<Literal>]
    let StatsGroupTopInviter = 0x535F779Du
    [<Literal>]
    let StatsMegagroupStats = 0xEF7FF916u
    [<Literal>]
    let GlobalPrivacySettings = 0xFE41B34Fu
    [<Literal>]
    let HelpCountryCode = 0x4203C5EFu
    [<Literal>]
    let HelpCountry = 0xC3878E23u
    [<Literal>]
    let HelpCountriesListNotModified = 0x93CC1F32u
    [<Literal>]
    let HelpCountriesList = 0x87D0759Eu
    [<Literal>]
    let MessageViews = 0x455B853Du
    [<Literal>]
    let MessagesMessageViews = 0xB6C4F543u
    [<Literal>]
    let MessagesDiscussionMessage = 0xA6341782u
    [<Literal>]
    let MessageReplyHeader = 0x6917560Bu
    [<Literal>]
    let MessageReplyStoryHeader = 0x0E5AF939u
    [<Literal>]
    let MessageReplies = 0x83D60FC2u
    [<Literal>]
    let PeerBlocked = 0xE8FD8014u
    [<Literal>]
    let StatsMessageStats = 0x7FE91C14u
    [<Literal>]
    let GroupCallDiscarded = 0x7780BCB4u
    [<Literal>]
    let GroupCall = 0x553B0BA1u
    [<Literal>]
    let InputGroupCall = 0xD8AA840Fu
    [<Literal>]
    let InputGroupCallSlug = 0xFE06823Fu
    [<Literal>]
    let InputGroupCallInviteMessage = 0x8C10603Fu
    [<Literal>]
    let GroupCallParticipant = 0xEBA636FEu
    [<Literal>]
    let PhoneGroupCall = 0x9E727AADu
    [<Literal>]
    let PhoneGroupParticipants = 0xF47751B6u
    [<Literal>]
    let InlineQueryPeerTypeSameBotPM = 0x3081ED9Du
    [<Literal>]
    let InlineQueryPeerTypePM = 0x833C0FACu
    [<Literal>]
    let InlineQueryPeerTypeChat = 0xD766C50Au
    [<Literal>]
    let InlineQueryPeerTypeMegagroup = 0x5EC4BE43u
    [<Literal>]
    let InlineQueryPeerTypeBroadcast = 0x6334EE9Au
    [<Literal>]
    let InlineQueryPeerTypeBotPM = 0x0E3B2D0Cu
    [<Literal>]
    let MessagesHistoryImport = 0x1662AF0Bu
    [<Literal>]
    let MessagesHistoryImportParsed = 0x5E0FB7B9u
    [<Literal>]
    let MessagesAffectedFoundMessages = 0xEF8D3E6Cu
    [<Literal>]
    let ChatInviteImporter = 0x8C5ADFD9u
    [<Literal>]
    let MessagesExportedChatInvites = 0xBDC62DCCu
    [<Literal>]
    let MessagesExportedChatInvite = 0x1871BE50u
    [<Literal>]
    let MessagesExportedChatInviteReplaced = 0x222600EFu
    [<Literal>]
    let MessagesChatInviteImporters = 0x81B6B00Au
    [<Literal>]
    let ChatAdminWithInvites = 0xF2ECEF23u
    [<Literal>]
    let MessagesChatAdminsWithInvites = 0xB69B72D7u
    [<Literal>]
    let MessagesCheckedHistoryImportPeer = 0xA24DE717u
    [<Literal>]
    let PhoneJoinAsPeers = 0xAFE5623Fu
    [<Literal>]
    let PhoneExportedGroupCallInvite = 0x204BD158u
    [<Literal>]
    let GroupCallParticipantVideoSourceGroup = 0xDCB118B7u
    [<Literal>]
    let GroupCallParticipantVideo = 0x67753AC8u
    [<Literal>]
    let StickersSuggestedShortName = 0x85FEA03Fu
    [<Literal>]
    let BotCommandScopeDefault = 0x2F6CB2ABu
    [<Literal>]
    let BotCommandScopeUsers = 0x3C4F04D8u
    [<Literal>]
    let BotCommandScopeChats = 0x6FE1A881u
    [<Literal>]
    let BotCommandScopeChatAdmins = 0xB9AA606Au
    [<Literal>]
    let BotCommandScopePeer = 0xDB9D897Du
    [<Literal>]
    let BotCommandScopePeerAdmins = 0x3FD863D1u
    [<Literal>]
    let BotCommandScopePeerUser = 0x0A1321F3u
    [<Literal>]
    let AccountResetPasswordFailedWait = 0xE3779861u
    [<Literal>]
    let AccountResetPasswordRequestedWait = 0xE9EFFC7Du
    [<Literal>]
    let AccountResetPasswordOk = 0xE926D63Eu
    [<Literal>]
    let ChatTheme = 0xC3DFFC04u
    [<Literal>]
    let ChatThemeUniqueGift = 0x3458F9C8u
    [<Literal>]
    let AccountChatThemesNotModified = 0xE011E1C4u
    [<Literal>]
    let AccountChatThemes = 0x16484857u
    [<Literal>]
    let SponsoredMessage = 0x7DBF8673u
    [<Literal>]
    let MessagesSponsoredMessages = 0xFFDA656Du
    [<Literal>]
    let MessagesSponsoredMessagesEmpty = 0x1839490Fu
    [<Literal>]
    let SearchResultsCalendarPeriod = 0xC9B0539Fu
    [<Literal>]
    let MessagesSearchResultsCalendar = 0x147EE23Cu
    [<Literal>]
    let SearchResultPosition = 0x7F648B67u
    [<Literal>]
    let MessagesSearchResultsPositions = 0x53B22BAFu
    [<Literal>]
    let ChannelsSendAsPeers = 0xF496B0C6u
    [<Literal>]
    let UsersUserFull = 0x3B6D152Eu
    [<Literal>]
    let MessagesPeerSettings = 0x6880B94Du
    [<Literal>]
    let AuthLoggedOut = 0xC3A2835Fu
    [<Literal>]
    let ReactionCount = 0xA3D1CB80u
    [<Literal>]
    let MessageReactions = 0x0A339F0Bu
    [<Literal>]
    let MessagesMessageReactionsList = 0x31BD492Du
    [<Literal>]
    let AvailableReaction = 0xC077EC01u
    [<Literal>]
    let MessagesAvailableReactionsNotModified = 0x9F071957u
    [<Literal>]
    let MessagesAvailableReactions = 0x768E3AADu
    [<Literal>]
    let MessagePeerReaction = 0x8C79B63Cu
    [<Literal>]
    let GroupCallStreamChannel = 0x80EB48AFu
    [<Literal>]
    let PhoneGroupCallStreamChannels = 0xD0E482B2u
    [<Literal>]
    let PhoneGroupCallStreamRtmpUrl = 0x2DBF3432u
    [<Literal>]
    let AttachMenuBotIconColor = 0x4576F3F0u
    [<Literal>]
    let AttachMenuBotIcon = 0xB2A7386Bu
    [<Literal>]
    let AttachMenuBot = 0xD90D8DFEu
    [<Literal>]
    let AttachMenuBotsNotModified = 0xF1D88A5Cu
    [<Literal>]
    let AttachMenuBots = 0x3C4301C0u
    [<Literal>]
    let AttachMenuBotsBot = 0x93BF667Fu
    [<Literal>]
    let WebViewResultUrl = 0x4D22FF98u
    [<Literal>]
    let WebViewMessageSent = 0x0C94511Cu
    [<Literal>]
    let BotMenuButtonDefault = 0x7533A588u
    [<Literal>]
    let BotMenuButtonCommands = 0x4258C205u
    [<Literal>]
    let BotMenuButton = 0xC7B57CE6u
    [<Literal>]
    let AccountSavedRingtonesNotModified = 0xFBF6E8B1u
    [<Literal>]
    let AccountSavedRingtones = 0xC1E92CC5u
    [<Literal>]
    let NotificationSoundDefault = 0x97E8BEBEu
    [<Literal>]
    let NotificationSoundNone = 0x6F0C34DFu
    [<Literal>]
    let NotificationSoundLocal = 0x830B9AE4u
    [<Literal>]
    let NotificationSoundRingtone = 0xFF6C8049u
    [<Literal>]
    let AccountSavedRingtone = 0xB7263F6Du
    [<Literal>]
    let AccountSavedRingtoneConverted = 0x1F307EB7u
    [<Literal>]
    let AttachMenuPeerTypeSameBotPM = 0x7D6BE90Eu
    [<Literal>]
    let AttachMenuPeerTypeBotPM = 0xC32BFA1Au
    [<Literal>]
    let AttachMenuPeerTypePM = 0xF146D31Fu
    [<Literal>]
    let AttachMenuPeerTypeChat = 0x0509113Fu
    [<Literal>]
    let AttachMenuPeerTypeBroadcast = 0x7BFBDEFCu
    [<Literal>]
    let InputInvoiceMessage = 0xC5B56859u
    [<Literal>]
    let InputInvoiceSlug = 0xC326CAEFu
    [<Literal>]
    let InputInvoicePremiumGiftCode = 0x98986C0Du
    [<Literal>]
    let InputInvoiceStars = 0x65F00CE3u
    [<Literal>]
    let InputInvoiceChatInviteSubscription = 0x34E793F1u
    [<Literal>]
    let InputInvoiceStarGift = 0xE8625E92u
    [<Literal>]
    let InputInvoiceStarGiftUpgrade = 0x4D818D5Du
    [<Literal>]
    let InputInvoiceStarGiftTransfer = 0x4A5F5BD9u
    [<Literal>]
    let InputInvoicePremiumGiftStars = 0xDABAB2EFu
    [<Literal>]
    let InputInvoiceBusinessBotTransferStars = 0xF4997E42u
    [<Literal>]
    let InputInvoiceStarGiftResale = 0xC39F5324u
    [<Literal>]
    let InputInvoiceStarGiftPrepaidUpgrade = 0x9A0B48B8u
    [<Literal>]
    let PaymentsExportedInvoice = 0xAED0CBD9u
    [<Literal>]
    let MessagesTranscribedAudio = 0xCFB9D957u
    [<Literal>]
    let HelpPremiumPromo = 0x5334759Cu
    [<Literal>]
    let InputStorePaymentPremiumSubscription = 0xA6751E66u
    [<Literal>]
    let InputStorePaymentGiftPremium = 0x616F7FE8u
    [<Literal>]
    let InputStorePaymentPremiumGiftCode = 0xFB790393u
    [<Literal>]
    let InputStorePaymentPremiumGiveaway = 0x160544CAu
    [<Literal>]
    let InputStorePaymentStarsTopup = 0xF9A2A6CBu
    [<Literal>]
    let InputStorePaymentStarsGift = 0x1D741EF7u
    [<Literal>]
    let InputStorePaymentStarsGiveaway = 0x751F08FAu
    [<Literal>]
    let InputStorePaymentAuthCode = 0x9BB2636Du
    [<Literal>]
    let PaymentFormMethod = 0x88F8F21Bu
    [<Literal>]
    let EmojiStatusEmpty = 0x2DE11AAEu
    [<Literal>]
    let EmojiStatus = 0xE7FF068Au
    [<Literal>]
    let EmojiStatusCollectible = 0x7184603Bu
    [<Literal>]
    let InputEmojiStatusCollectible = 0x07141DBFu
    [<Literal>]
    let AccountEmojiStatusesNotModified = 0xD08CE645u
    [<Literal>]
    let AccountEmojiStatuses = 0x90C467D1u
    [<Literal>]
    let ReactionEmpty = 0x79F5D419u
    [<Literal>]
    let ReactionEmoji = 0x1B2286B8u
    [<Literal>]
    let ReactionCustomEmoji = 0x8935FC73u
    [<Literal>]
    let ReactionPaid = 0x523DA4EBu
    [<Literal>]
    let ChatReactionsNone = 0xEAFC32BCu
    [<Literal>]
    let ChatReactionsAll = 0x52928BCAu
    [<Literal>]
    let ChatReactionsSome = 0x661D4037u
    [<Literal>]
    let MessagesReactionsNotModified = 0xB06FDBDFu
    [<Literal>]
    let MessagesReactions = 0xEAFDF716u
    [<Literal>]
    let EmailVerifyPurposeLoginSetup = 0x4345BE73u
    [<Literal>]
    let EmailVerifyPurposeLoginChange = 0x527D22EBu
    [<Literal>]
    let EmailVerifyPurposePassport = 0xBBF51685u
    [<Literal>]
    let EmailVerificationCode = 0x922E55A9u
    [<Literal>]
    let EmailVerificationGoogle = 0xDB909EC2u
    [<Literal>]
    let EmailVerificationApple = 0x96D074FDu
    [<Literal>]
    let AccountEmailVerified = 0x2B96CD1Bu
    [<Literal>]
    let AccountEmailVerifiedLogin = 0xE1BB0D61u
    [<Literal>]
    let PremiumSubscriptionOption = 0x5F2D1DF2u
    [<Literal>]
    let SendAsPeer = 0xB81C7034u
    [<Literal>]
    let MessageExtendedMediaPreview = 0xAD628CC8u
    [<Literal>]
    let MessageExtendedMedia = 0xEE479C64u
    [<Literal>]
    let StickerKeyword = 0xFCFEB29Cu
    [<Literal>]
    let Username = 0xB4073647u
    [<Literal>]
    let ForumTopicDeleted = 0x023F109Bu
    [<Literal>]
    let ForumTopic = 0x71701DA9u
    [<Literal>]
    let MessagesForumTopics = 0x367617D3u
    [<Literal>]
    let DefaultHistoryTTL = 0x43B46B20u
    [<Literal>]
    let ExportedContactToken = 0x41BF109Bu
    [<Literal>]
    let RequestPeerTypeUser = 0x5F3B8A00u
    [<Literal>]
    let RequestPeerTypeChat = 0xC9F06E1Bu
    [<Literal>]
    let RequestPeerTypeBroadcast = 0x339BEF6Cu
    [<Literal>]
    let EmojiListNotModified = 0x481EADFAu
    [<Literal>]
    let EmojiList = 0x7A1E11D1u
    [<Literal>]
    let EmojiGroup = 0x7A9ABDA9u
    [<Literal>]
    let EmojiGroupGreeting = 0x80D26CC7u
    [<Literal>]
    let EmojiGroupPremium = 0x093BCF34u
    [<Literal>]
    let MessagesEmojiGroupsNotModified = 0x6FB4AD87u
    [<Literal>]
    let MessagesEmojiGroups = 0x881FB94Bu
    [<Literal>]
    let TextWithEntities = 0x751F3146u
    [<Literal>]
    let MessagesTranslateResult = 0x33DB32F8u
    [<Literal>]
    let AutoSaveSettings = 0xC84834CEu
    [<Literal>]
    let AutoSaveException = 0x81602D47u
    [<Literal>]
    let AccountAutoSaveSettings = 0x4C3E069Du
    [<Literal>]
    let HelpAppConfigNotModified = 0x7CDE641Du
    [<Literal>]
    let HelpAppConfig = 0xDD18782Eu
    [<Literal>]
    let InputBotAppID = 0xA920BD7Au
    [<Literal>]
    let InputBotAppShortName = 0x908C0407u
    [<Literal>]
    let BotAppNotModified = 0x5DA674B7u
    [<Literal>]
    let BotApp = 0x95FCD1D6u
    [<Literal>]
    let MessagesBotApp = 0xEB50ADF5u
    [<Literal>]
    let InlineBotWebView = 0xB57295D5u
    [<Literal>]
    let ReadParticipantDate = 0x4A4FF172u
    [<Literal>]
    let InputChatlistDialogFilter = 0xF3E0DA33u
    [<Literal>]
    let ExportedChatlistInvite = 0x0C5181ACu
    [<Literal>]
    let ChatlistsExportedChatlistInvite = 0x10E6E3A6u
    [<Literal>]
    let ChatlistsExportedInvites = 0x10AB6DC7u
    [<Literal>]
    let ChatlistsChatlistInviteAlready = 0xFA87F659u
    [<Literal>]
    let ChatlistsChatlistInvite = 0xF10ECE2Fu
    [<Literal>]
    let ChatlistsChatlistUpdates = 0x93BD878Du
    [<Literal>]
    let BotsBotInfo = 0xE8A775B0u
    [<Literal>]
    let MessagePeerVote = 0xB6CC2D5Cu
    [<Literal>]
    let MessagePeerVoteInputOption = 0x74CDA504u
    [<Literal>]
    let MessagePeerVoteMultiple = 0x4628F6E6u
    [<Literal>]
    let StoryViews = 0x8D595CD6u
    [<Literal>]
    let StoryItemDeleted = 0x51E6EE4Fu
    [<Literal>]
    let StoryItemSkipped = 0xFFADC913u
    [<Literal>]
    let StoryItem = 0xEDF164F1u
    [<Literal>]
    let StoriesAllStoriesNotModified = 0x1158FE3Eu
    [<Literal>]
    let StoriesAllStories = 0x6EFC5E81u
    [<Literal>]
    let StoriesStories = 0x63C3DD0Au
    [<Literal>]
    let StoryView = 0xB0BDEAC5u
    [<Literal>]
    let StoryViewPublicForward = 0x9083670Bu
    [<Literal>]
    let StoryViewPublicRepost = 0xBD74CF49u
    [<Literal>]
    let StoriesStoryViewsList = 0x59D78FC5u
    [<Literal>]
    let StoriesStoryViews = 0xDE9EED1Du
    [<Literal>]
    let InputReplyToMessage = 0x869FBE10u
    [<Literal>]
    let InputReplyToStory = 0x5881323Au
    [<Literal>]
    let InputReplyToMonoForum = 0x69D66C45u
    [<Literal>]
    let ExportedStoryLink = 0x3FC9053Bu
    [<Literal>]
    let StoriesStealthMode = 0x712E27FDu
    [<Literal>]
    let MediaAreaCoordinates = 0xCFC9E002u
    [<Literal>]
    let MediaAreaVenue = 0xBE82DB9Cu
    [<Literal>]
    let InputMediaAreaVenue = 0xB282217Fu
    [<Literal>]
    let MediaAreaGeoPoint = 0xCAD5452Du
    [<Literal>]
    let MediaAreaSuggestedReaction = 0x14455871u
    [<Literal>]
    let MediaAreaChannelPost = 0x770416AFu
    [<Literal>]
    let InputMediaAreaChannelPost = 0x2271F2BFu
    [<Literal>]
    let MediaAreaUrl = 0x37381085u
    [<Literal>]
    let MediaAreaWeather = 0x49A6549Cu
    [<Literal>]
    let MediaAreaStarGift = 0x5787686Du
    [<Literal>]
    let PeerStories = 0x9A35E999u
    [<Literal>]
    let StoriesPeerStories = 0xCAE68768u
    [<Literal>]
    let MessagesWebPage = 0xFD5E12BDu
    [<Literal>]
    let PremiumGiftCodeOption = 0x257E962Bu
    [<Literal>]
    let PaymentsCheckedGiftCode = 0x284A1096u
    [<Literal>]
    let PaymentsGiveawayInfo = 0x4367DAA0u
    [<Literal>]
    let PaymentsGiveawayInfoResults = 0xE175E66Fu
    [<Literal>]
    let PrepaidGiveaway = 0xB2539D54u
    [<Literal>]
    let PrepaidStarsGiveaway = 0x9A9D77E0u
    [<Literal>]
    let Boost = 0x4B3E14D6u
    [<Literal>]
    let PremiumBoostsList = 0x86F8613Cu
    [<Literal>]
    let MyBoost = 0xC448415Cu
    [<Literal>]
    let PremiumMyBoosts = 0x9AE228E2u
    [<Literal>]
    let PremiumBoostsStatus = 0x4959427Au
    [<Literal>]
    let StoryFwdHeader = 0xB826E150u
    [<Literal>]
    let PostInteractionCountersMessage = 0xE7058E7Fu
    [<Literal>]
    let PostInteractionCountersStory = 0x8A480E27u
    [<Literal>]
    let StatsStoryStats = 0x50CD067Cu
    [<Literal>]
    let PublicForwardMessage = 0x01F2BF4Au
    [<Literal>]
    let PublicForwardStory = 0xEDF3ADD0u
    [<Literal>]
    let StatsPublicForwards = 0x93037E20u
    [<Literal>]
    let PeerColor = 0xB54B5ACFu
    [<Literal>]
    let HelpPeerColorSet = 0x26219A58u
    [<Literal>]
    let HelpPeerColorProfileSet = 0x767D61EBu
    [<Literal>]
    let HelpPeerColorOption = 0xADEC6EBEu
    [<Literal>]
    let HelpPeerColorsNotModified = 0x2BA1F5CEu
    [<Literal>]
    let HelpPeerColors = 0x00F8ED08u
    [<Literal>]
    let StoryReaction = 0x6090D6D5u
    [<Literal>]
    let StoryReactionPublicForward = 0xBBAB2643u
    [<Literal>]
    let StoryReactionPublicRepost = 0xCFCD0F13u
    [<Literal>]
    let StoriesStoryReactionsList = 0xAA5F789Cu
    [<Literal>]
    let SavedDialog = 0xBD87CB6Cu
    [<Literal>]
    let MonoForumDialog = 0x64407EA7u
    [<Literal>]
    let MessagesSavedDialogs = 0xF83AE221u
    [<Literal>]
    let MessagesSavedDialogsSlice = 0x44BA9DD9u
    [<Literal>]
    let MessagesSavedDialogsNotModified = 0xC01F6FE8u
    [<Literal>]
    let SavedReactionTag = 0xCB6FF828u
    [<Literal>]
    let MessagesSavedReactionTagsNotModified = 0x889B59EFu
    [<Literal>]
    let MessagesSavedReactionTags = 0x3259950Au
    [<Literal>]
    let OutboxReadDate = 0x3BB842ACu
    [<Literal>]
    let SmsjobsEligibleToJoin = 0xDC8B44CFu
    [<Literal>]
    let SmsjobsStatus = 0x2AEE9191u
    [<Literal>]
    let SmsJob = 0xE6A1EEB8u
    [<Literal>]
    let BusinessWeeklyOpen = 0x120B1AB9u
    [<Literal>]
    let BusinessWorkHours = 0x8C92B098u
    [<Literal>]
    let BusinessLocation = 0xAC5C1AF7u
    [<Literal>]
    let InputBusinessRecipients = 0x6F8B32AAu
    [<Literal>]
    let BusinessRecipients = 0x21108FF7u
    [<Literal>]
    let BusinessAwayMessageScheduleAlways = 0xC9B9E2B9u
    [<Literal>]
    let BusinessAwayMessageScheduleOutsideWorkHours = 0xC3F2F501u
    [<Literal>]
    let BusinessAwayMessageScheduleCustom = 0xCC4D9ECCu
    [<Literal>]
    let InputBusinessGreetingMessage = 0x0194CB3Bu
    [<Literal>]
    let BusinessGreetingMessage = 0xE519ABABu
    [<Literal>]
    let InputBusinessAwayMessage = 0x832175E0u
    [<Literal>]
    let BusinessAwayMessage = 0xEF156A5Cu
    [<Literal>]
    let Timezone = 0xFF9289F5u
    [<Literal>]
    let HelpTimezonesListNotModified = 0x970708CCu
    [<Literal>]
    let HelpTimezonesList = 0x7B74ED71u
    [<Literal>]
    let QuickReply = 0x0697102Bu
    [<Literal>]
    let InputQuickReplyShortcut = 0x24596D41u
    [<Literal>]
    let InputQuickReplyShortcutId = 0x01190CF1u
    [<Literal>]
    let MessagesQuickReplies = 0xC68D6695u
    [<Literal>]
    let MessagesQuickRepliesNotModified = 0x5F91EB5Bu
    [<Literal>]
    let ConnectedBot = 0xCD64636Cu
    [<Literal>]
    let AccountConnectedBots = 0x17D7F87Bu
    [<Literal>]
    let MessagesDialogFilters = 0x2AD93719u
    [<Literal>]
    let Birthday = 0x6C8E1E06u
    [<Literal>]
    let BotBusinessConnection = 0x8F34B2F5u
    [<Literal>]
    let InputBusinessIntro = 0x09C469CDu
    [<Literal>]
    let BusinessIntro = 0x5A0A066Du
    [<Literal>]
    let MessagesMyStickers = 0xFAFF629Du
    [<Literal>]
    let InputCollectibleUsername = 0xE39460A9u
    [<Literal>]
    let InputCollectiblePhone = 0xA2E214A4u
    [<Literal>]
    let FragmentCollectibleInfo = 0x6EBDFF91u
    [<Literal>]
    let InputBusinessBotRecipients = 0xC4E5921Eu
    [<Literal>]
    let BusinessBotRecipients = 0xB88CF373u
    [<Literal>]
    let ContactBirthday = 0x1D998733u
    [<Literal>]
    let ContactsContactBirthdays = 0x114FF30Du
    [<Literal>]
    let MissingInvitee = 0x628C9224u
    [<Literal>]
    let MessagesInvitedUsers = 0x7F5DEFA6u
    [<Literal>]
    let InputBusinessChatLink = 0x11679FA7u
    [<Literal>]
    let BusinessChatLink = 0xB4AE666Fu
    [<Literal>]
    let AccountBusinessChatLinks = 0xEC43A2D1u
    [<Literal>]
    let AccountResolvedBusinessChatLinks = 0x9A23AF21u
    [<Literal>]
    let RequestedPeerUser = 0xD62FF46Au
    [<Literal>]
    let RequestedPeerChat = 0x7307544Fu
    [<Literal>]
    let RequestedPeerChannel = 0x8BA403E4u
    [<Literal>]
    let SponsoredMessageReportOption = 0x430D3150u
    [<Literal>]
    let ChannelsSponsoredMessageReportResultChooseOption = 0x846F9E42u
    [<Literal>]
    let ChannelsSponsoredMessageReportResultAdsHidden = 0x3E3BCF2Fu
    [<Literal>]
    let ChannelsSponsoredMessageReportResultReported = 0xAD798849u
    [<Literal>]
    let ReactionNotificationsFromContacts = 0xBAC3A61Au
    [<Literal>]
    let ReactionNotificationsFromAll = 0x4B9E22A0u
    [<Literal>]
    let ReactionsNotifySettings = 0x56E34970u
    [<Literal>]
    let AvailableEffect = 0x93C3E27Eu
    [<Literal>]
    let MessagesAvailableEffectsNotModified = 0xD1ED9A5Bu
    [<Literal>]
    let MessagesAvailableEffects = 0xBDDB616Eu
    [<Literal>]
    let FactCheck = 0xB89BFCCFu
    [<Literal>]
    let StarsTransactionPeerUnsupported = 0x95F2BFE4u
    [<Literal>]
    let StarsTransactionPeerAppStore = 0xB457B375u
    [<Literal>]
    let StarsTransactionPeerPlayMarket = 0x7B560A0Bu
    [<Literal>]
    let StarsTransactionPeerPremiumBot = 0x250DBAF8u
    [<Literal>]
    let StarsTransactionPeerFragment = 0xE92FD902u
    [<Literal>]
    let StarsTransactionPeer = 0xD80DA15Du
    [<Literal>]
    let StarsTransactionPeerAds = 0x60682812u
    [<Literal>]
    let StarsTransactionPeerAPI = 0xF9677AADu
    [<Literal>]
    let StarsTopupOption = 0x0BD915C0u
    [<Literal>]
    let StarsTransaction = 0x13659EB0u
    [<Literal>]
    let PaymentsStarsStatus = 0x6C9CE8EDu
    [<Literal>]
    let FoundStory = 0xE87ACBC0u
    [<Literal>]
    let StoriesFoundStories = 0xE2DE7737u
    [<Literal>]
    let GeoPointAddress = 0xDE4C5D93u
    [<Literal>]
    let StarsRevenueStatus = 0xFEBE5491u
    [<Literal>]
    let PaymentsStarsRevenueStats = 0x6C207376u
    [<Literal>]
    let PaymentsStarsRevenueWithdrawalUrl = 0x1DAB80B7u
    [<Literal>]
    let PaymentsStarsRevenueAdsAccountUrl = 0x394E7F21u
    [<Literal>]
    let InputStarsTransaction = 0x206AE6D1u
    [<Literal>]
    let StarsGiftOption = 0x5E0589F1u
    [<Literal>]
    let BotsPopularAppBots = 0x1991B13Bu
    [<Literal>]
    let BotPreviewMedia = 0x23E91BA3u
    [<Literal>]
    let BotsPreviewInfo = 0x0CA71D64u
    [<Literal>]
    let StarsSubscriptionPricing = 0x05416D58u
    [<Literal>]
    let StarsSubscription = 0x2E6EAB1Au
    [<Literal>]
    let MessageReactor = 0x4BA3A95Au
    [<Literal>]
    let StarsGiveawayOption = 0x94CE852Au
    [<Literal>]
    let StarsGiveawayWinnersOption = 0x54236209u
    [<Literal>]
    let StarGift = 0x80AC53C3u
    [<Literal>]
    let StarGiftUnique = 0x1BEFE865u
    [<Literal>]
    let PaymentsStarGiftsNotModified = 0xA388A368u
    [<Literal>]
    let PaymentsStarGifts = 0x2ED82995u
    [<Literal>]
    let MessageReportOption = 0x7903E3D9u
    [<Literal>]
    let ReportResultChooseOption = 0xF0E4E0B6u
    [<Literal>]
    let ReportResultAddComment = 0x6F09AC31u
    [<Literal>]
    let ReportResultReported = 0x8DB33C4Bu
    [<Literal>]
    let MessagesBotPreparedInlineMessage = 0x8ECF0511u
    [<Literal>]
    let MessagesPreparedInlineMessage = 0xFF57708Du
    [<Literal>]
    let BotAppSettings = 0xC99B1950u
    [<Literal>]
    let StarRefProgram = 0xDD0C66F2u
    [<Literal>]
    let ConnectedBotStarRef = 0x19A13F71u
    [<Literal>]
    let PaymentsConnectedStarRefBots = 0x98D5EA1Du
    [<Literal>]
    let PaymentsSuggestedStarRefBots = 0xB4D5D859u
    [<Literal>]
    let StarsAmount = 0xBBB6B4A3u
    [<Literal>]
    let StarsTonAmount = 0x74AEE3E0u
    [<Literal>]
    let MessagesFoundStickersNotModified = 0x6010C534u
    [<Literal>]
    let MessagesFoundStickers = 0x82C9E290u
    [<Literal>]
    let BotVerifierSettings = 0xB0CD6617u
    [<Literal>]
    let BotVerification = 0xF93CD45Cu
    [<Literal>]
    let StarGiftAttributeModel = 0x39D99013u
    [<Literal>]
    let StarGiftAttributePattern = 0x13ACFF19u
    [<Literal>]
    let StarGiftAttributeBackdrop = 0xD93D859Cu
    [<Literal>]
    let StarGiftAttributeOriginalDetails = 0xE0BFF26Cu
    [<Literal>]
    let PaymentsStarGiftUpgradePreview = 0x167BD90Bu
    [<Literal>]
    let UsersUsers = 0x62D706B8u
    [<Literal>]
    let UsersUsersSlice = 0x315A4974u
    [<Literal>]
    let PaymentsUniqueStarGift = 0x416C56E8u
    [<Literal>]
    let MessagesWebPagePreview = 0x8C9A88ACu
    [<Literal>]
    let SavedStarGift = 0x19A9B572u
    [<Literal>]
    let PaymentsSavedStarGifts = 0x95F389B1u
    [<Literal>]
    let InputSavedStarGiftUser = 0x69279795u
    [<Literal>]
    let InputSavedStarGiftChat = 0xF101AA7Fu
    [<Literal>]
    let InputSavedStarGiftSlug = 0x2085C238u
    [<Literal>]
    let PaymentsStarGiftWithdrawalUrl = 0x84AA3A9Cu
    [<Literal>]
    let PaidReactionPrivacyDefault = 0x206AD49Eu
    [<Literal>]
    let PaidReactionPrivacyAnonymous = 0x1F0C1AD9u
    [<Literal>]
    let PaidReactionPrivacyPeer = 0xDC6CFCF0u
    [<Literal>]
    let AccountPaidMessagesRevenue = 0x1E109708u
    [<Literal>]
    let RequirementToContactEmpty = 0x050A9839u
    [<Literal>]
    let RequirementToContactPremium = 0xE581E4E9u
    [<Literal>]
    let RequirementToContactPaidMessages = 0xB4F67E93u
    [<Literal>]
    let BusinessBotRights = 0xA0624CF7u
    [<Literal>]
    let DisallowedGiftsSettings = 0x71F276C4u
    [<Literal>]
    let SponsoredPeer = 0xC69708D3u
    [<Literal>]
    let ContactsSponsoredPeersEmpty = 0xEA32B4B1u
    [<Literal>]
    let ContactsSponsoredPeers = 0xEB032884u
    [<Literal>]
    let StarGiftAttributeIdModel = 0x48AAAE3Cu
    [<Literal>]
    let StarGiftAttributeIdPattern = 0x4A162433u
    [<Literal>]
    let StarGiftAttributeIdBackdrop = 0x1F01C757u
    [<Literal>]
    let StarGiftAttributeCounter = 0x2EB1B658u
    [<Literal>]
    let PaymentsResaleStarGifts = 0x947A12DFu
    [<Literal>]
    let StoriesCanSendStoryCount = 0xC387C04Eu
    [<Literal>]
    let PendingSuggestion = 0xE7E82E12u
    [<Literal>]
    let TodoItem = 0xCBA9A52Fu
    [<Literal>]
    let TodoList = 0x49B92A26u
    [<Literal>]
    let TodoCompletion = 0x4CC120B7u
    [<Literal>]
    let SuggestedPost = 0x0E8E37E5u
    [<Literal>]
    let StarsRating = 0x1B0E4F07u
    [<Literal>]
    let StarGiftCollection = 0x9D6B13B0u
    [<Literal>]
    let PaymentsStarGiftCollectionsNotModified = 0xA0BA4F17u
    [<Literal>]
    let PaymentsStarGiftCollections = 0x8A2932F3u
    [<Literal>]
    let StoryAlbum = 0x9325705Au
    [<Literal>]
    let StoriesAlbumsNotModified = 0x564EDAEBu
    [<Literal>]
    let StoriesAlbums = 0xC3987A3Au
    [<Literal>]
    let SearchPostsFlood = 0x3E0B5B6Au
    [<Literal>]
    let PaymentsUniqueStarGiftValueInfo = 0x512FE446u
    [<Literal>]
    let ProfileTabPosts = 0xB98CD696u
    [<Literal>]
    let ProfileTabGifts = 0x4D4BD46Au
    [<Literal>]
    let ProfileTabMedia = 0x72C64955u
    [<Literal>]
    let ProfileTabFiles = 0xAB339C00u
    [<Literal>]
    let ProfileTabMusic = 0x9F27D26Eu
    [<Literal>]
    let ProfileTabVoice = 0xE477092Eu
    [<Literal>]
    let ProfileTabLinks = 0xD3656499u
    [<Literal>]
    let ProfileTabGifs = 0xA2C0F695u
    [<Literal>]
    let UsersSavedMusicNotModified = 0xE3878AA4u
    [<Literal>]
    let UsersSavedMusic = 0x34A2F297u
    [<Literal>]
    let AccountSavedMusicIdsNotModified = 0x4FC81D6Eu
    [<Literal>]
    let AccountSavedMusicIds = 0x998D6636u
    [<Literal>]
    let PaymentsCheckCanSendGiftResultOk = 0x374FA7ADu
    [<Literal>]
    let PaymentsCheckCanSendGiftResultFail = 0xD5E58274u
    [<Literal>]
    let InputChatThemeEmpty = 0x83268483u
    [<Literal>]
    let InputChatTheme = 0xC93DE95Cu
    [<Literal>]
    let InputChatThemeUniqueGift = 0x87E5DFE4u

    // --- API Functions ---
    [<Literal>]
    let InvokeAfterMsg = 0xCB9F372Du
    [<Literal>]
    let InvokeAfterMsgs = 0x3DC4B4F0u
    [<Literal>]
    let InitConnection = 0xC1CD5EA9u
    [<Literal>]
    let InvokeWithLayer = 0xDA9B0D0Du
    [<Literal>]
    let InvokeWithoutUpdates = 0xBF9459B7u
    [<Literal>]
    let InvokeWithMessagesRange = 0x365275F2u
    [<Literal>]
    let InvokeWithTakeout = 0xACA9FD2Eu
    [<Literal>]
    let InvokeWithBusinessConnection = 0xDD289F8Eu
    [<Literal>]
    let InvokeWithGooglePlayIntegrity = 0x1DF92984u
    [<Literal>]
    let InvokeWithApnsSecret = 0x0DAE54F8u
    [<Literal>]
    let InvokeWithReCaptcha = 0xADBB0F94u
    [<Literal>]
    let AuthSendCode = 0xA677244Fu
    [<Literal>]
    let AuthSignUp = 0xAAC7B717u
    [<Literal>]
    let AuthSignIn = 0x8D52A951u
    [<Literal>]
    let AuthLogOut = 0x3E72BA19u
    [<Literal>]
    let AuthResetAuthorizations = 0x9FAB0D1Au
    [<Literal>]
    let AuthExportAuthorization = 0xE5BFFFCDu
    [<Literal>]
    let AuthImportAuthorization = 0xA57A7DADu
    [<Literal>]
    let AuthBindTempAuthKey = 0xCDD42A05u
    [<Literal>]
    let AuthImportBotAuthorization = 0x67A3FF2Cu
    [<Literal>]
    let AuthCheckPassword = 0xD18B4D16u
    [<Literal>]
    let AuthRequestPasswordRecovery = 0xD897BC66u
    [<Literal>]
    let AuthRecoverPassword = 0x37096C70u
    [<Literal>]
    let AuthResendCode = 0xCAE47523u
    [<Literal>]
    let AuthCancelCode = 0x1F040578u
    [<Literal>]
    let AuthDropTempAuthKeys = 0x8E48A188u
    [<Literal>]
    let AuthExportLoginToken = 0xB7E085FEu
    [<Literal>]
    let AuthImportLoginToken = 0x95AC5CE4u
    [<Literal>]
    let AuthAcceptLoginToken = 0xE894AD4Du
    [<Literal>]
    let AuthCheckRecoveryPassword = 0x0D36BF79u
    [<Literal>]
    let AuthImportWebTokenAuthorization = 0x2DB873A9u
    [<Literal>]
    let AuthRequestFirebaseSms = 0x8E39261Eu
    [<Literal>]
    let AuthResetLoginEmail = 0x7E960193u
    [<Literal>]
    let AuthReportMissingCode = 0xCB9DEFF6u
    [<Literal>]
    let AccountRegisterDevice = 0xEC86017Au
    [<Literal>]
    let AccountUnregisterDevice = 0x6A0D3206u
    [<Literal>]
    let AccountUpdateNotifySettings = 0x84BE5B93u
    [<Literal>]
    let AccountGetNotifySettings = 0x12B3AD31u
    [<Literal>]
    let AccountResetNotifySettings = 0xDB7E1747u
    [<Literal>]
    let AccountUpdateProfile = 0x78515775u
    [<Literal>]
    let AccountUpdateStatus = 0x6628562Cu
    [<Literal>]
    let AccountGetWallPapers = 0x07967D36u
    [<Literal>]
    let AccountReportPeer = 0xC5BA3D86u
    [<Literal>]
    let AccountCheckUsername = 0x2714D86Cu
    [<Literal>]
    let AccountUpdateUsername = 0x3E0BDD7Cu
    [<Literal>]
    let AccountGetPrivacy = 0xDADBC950u
    [<Literal>]
    let AccountSetPrivacy = 0xC9F81CE8u
    [<Literal>]
    let AccountDeleteAccount = 0xA2C0CF74u
    [<Literal>]
    let AccountGetAccountTTL = 0x08FC711Du
    [<Literal>]
    let AccountSetAccountTTL = 0x2442485Eu
    [<Literal>]
    let AccountSendChangePhoneCode = 0x82574AE5u
    [<Literal>]
    let AccountChangePhone = 0x70C32EDBu
    [<Literal>]
    let AccountUpdateDeviceLocked = 0x38DF3532u
    [<Literal>]
    let AccountGetAuthorizations = 0xE320C158u
    [<Literal>]
    let AccountResetAuthorization = 0xDF77F3BCu
    [<Literal>]
    let AccountGetPassword = 0x548A30F5u
    [<Literal>]
    let AccountGetPasswordSettings = 0x9CD4EAF9u
    [<Literal>]
    let AccountUpdatePasswordSettings = 0xA59B102Fu
    [<Literal>]
    let AccountSendConfirmPhoneCode = 0x1B3FAA88u
    [<Literal>]
    let AccountConfirmPhone = 0x5F2178C3u
    [<Literal>]
    let AccountGetTmpPassword = 0x449E0B51u
    [<Literal>]
    let AccountGetWebAuthorizations = 0x182E6D6Fu
    [<Literal>]
    let AccountResetWebAuthorization = 0x2D01B9EFu
    [<Literal>]
    let AccountResetWebAuthorizations = 0x682D2594u
    [<Literal>]
    let AccountGetAllSecureValues = 0xB288BC7Du
    [<Literal>]
    let AccountGetSecureValue = 0x73665BC2u
    [<Literal>]
    let AccountSaveSecureValue = 0x899FE31Du
    [<Literal>]
    let AccountDeleteSecureValue = 0xB880BC4Bu
    [<Literal>]
    let AccountGetAuthorizationForm = 0xA929597Au
    [<Literal>]
    let AccountAcceptAuthorization = 0xF3ED4C73u
    [<Literal>]
    let AccountSendVerifyPhoneCode = 0xA5A356F9u
    [<Literal>]
    let AccountVerifyPhone = 0x4DD3A7F6u
    [<Literal>]
    let AccountSendVerifyEmailCode = 0x98E037BBu
    [<Literal>]
    let AccountVerifyEmail = 0x032DA4CFu
    [<Literal>]
    let AccountInitTakeoutSession = 0x8EF3EAB0u
    [<Literal>]
    let AccountFinishTakeoutSession = 0x1D2652EEu
    [<Literal>]
    let AccountConfirmPasswordEmail = 0x8FDF1920u
    [<Literal>]
    let AccountResendPasswordEmail = 0x7A7F2A15u
    [<Literal>]
    let AccountCancelPasswordEmail = 0xC1CBD5B6u
    [<Literal>]
    let AccountGetContactSignUpNotification = 0x9F07C728u
    [<Literal>]
    let AccountSetContactSignUpNotification = 0xCFF43F61u
    [<Literal>]
    let AccountGetNotifyExceptions = 0x53577479u
    [<Literal>]
    let AccountGetWallPaper = 0xFC8DDBEAu
    [<Literal>]
    let AccountUploadWallPaper = 0xE39A8F03u
    [<Literal>]
    let AccountSaveWallPaper = 0x6C5A5B37u
    [<Literal>]
    let AccountInstallWallPaper = 0xFEED5769u
    [<Literal>]
    let AccountResetWallPapers = 0xBB3B9804u
    [<Literal>]
    let AccountGetAutoDownloadSettings = 0x56DA0B3Fu
    [<Literal>]
    let AccountSaveAutoDownloadSettings = 0x76F36233u
    [<Literal>]
    let AccountUploadTheme = 0x1C3DB333u
    [<Literal>]
    let AccountCreateTheme = 0x652E4400u
    [<Literal>]
    let AccountUpdateTheme = 0x2BF40CCCu
    [<Literal>]
    let AccountSaveTheme = 0xF257106Cu
    [<Literal>]
    let AccountInstallTheme = 0xC727BB3Bu
    [<Literal>]
    let AccountGetTheme = 0x3A5869ECu
    [<Literal>]
    let AccountGetThemes = 0x7206E458u
    [<Literal>]
    let AccountSetContentSettings = 0xB574B16Bu
    [<Literal>]
    let AccountGetContentSettings = 0x8B9B4DAEu
    [<Literal>]
    let AccountGetMultiWallPapers = 0x65AD71DCu
    [<Literal>]
    let AccountGetGlobalPrivacySettings = 0xEB2B4CF6u
    [<Literal>]
    let AccountSetGlobalPrivacySettings = 0x1EDAAAC2u
    [<Literal>]
    let AccountReportProfilePhoto = 0xFA8CC6F5u
    [<Literal>]
    let AccountResetPassword = 0x9308CE1Bu
    [<Literal>]
    let AccountDeclinePasswordReset = 0x4C9409F6u
    [<Literal>]
    let AccountGetChatThemes = 0xD638DE89u
    [<Literal>]
    let AccountSetAuthorizationTTL = 0xBF899AA0u
    [<Literal>]
    let AccountChangeAuthorizationSettings = 0x40F48462u
    [<Literal>]
    let AccountGetSavedRingtones = 0xE1902288u
    [<Literal>]
    let AccountSaveRingtone = 0x3DEA5B03u
    [<Literal>]
    let AccountUploadRingtone = 0x831A83A2u
    [<Literal>]
    let AccountUpdateEmojiStatus = 0xFBD3DE6Bu
    [<Literal>]
    let AccountGetDefaultEmojiStatuses = 0xD6753386u
    [<Literal>]
    let AccountGetRecentEmojiStatuses = 0x0F578105u
    [<Literal>]
    let AccountClearRecentEmojiStatuses = 0x18201AAEu
    [<Literal>]
    let AccountReorderUsernames = 0xEF500EABu
    [<Literal>]
    let AccountToggleUsername = 0x58D6B376u
    [<Literal>]
    let AccountGetDefaultProfilePhotoEmojis = 0xE2750328u
    [<Literal>]
    let AccountGetDefaultGroupPhotoEmojis = 0x915860AEu
    [<Literal>]
    let AccountGetAutoSaveSettings = 0xADCBBCDAu
    [<Literal>]
    let AccountSaveAutoSaveSettings = 0xD69B8361u
    [<Literal>]
    let AccountDeleteAutoSaveExceptions = 0x53BC0020u
    [<Literal>]
    let AccountInvalidateSignInCodes = 0xCA8AE8BAu
    [<Literal>]
    let AccountUpdateColor = 0x7CEFA15Du
    [<Literal>]
    let AccountGetDefaultBackgroundEmojis = 0xA60AB9CEu
    [<Literal>]
    let AccountGetChannelDefaultEmojiStatuses = 0x7727A7D5u
    [<Literal>]
    let AccountGetChannelRestrictedStatusEmojis = 0x35A9E0D5u
    [<Literal>]
    let AccountUpdateBusinessWorkHours = 0x4B00E066u
    [<Literal>]
    let AccountUpdateBusinessLocation = 0x9E6B131Au
    [<Literal>]
    let AccountUpdateBusinessGreetingMessage = 0x66CDAFC4u
    [<Literal>]
    let AccountUpdateBusinessAwayMessage = 0xA26A7FA5u
    [<Literal>]
    let AccountUpdateConnectedBot = 0x66A08C7Eu
    [<Literal>]
    let AccountGetConnectedBots = 0x4EA4C80Fu
    [<Literal>]
    let AccountGetBotBusinessConnection = 0x76A86270u
    [<Literal>]
    let AccountUpdateBusinessIntro = 0xA614D034u
    [<Literal>]
    let AccountToggleConnectedBotPaused = 0x646E1097u
    [<Literal>]
    let AccountDisablePeerConnectedBot = 0x5E437ED9u
    [<Literal>]
    let AccountUpdateBirthday = 0xCC6E0C11u
    [<Literal>]
    let AccountCreateBusinessChatLink = 0x8851E68Eu
    [<Literal>]
    let AccountEditBusinessChatLink = 0x8C3410AFu
    [<Literal>]
    let AccountDeleteBusinessChatLink = 0x60073674u
    [<Literal>]
    let AccountGetBusinessChatLinks = 0x6F70DDE1u
    [<Literal>]
    let AccountResolveBusinessChatLink = 0x5492E5EEu
    [<Literal>]
    let AccountUpdatePersonalChannel = 0xD94305E0u
    [<Literal>]
    let AccountToggleSponsoredMessages = 0xB9D9A38Du
    [<Literal>]
    let AccountGetReactionsNotifySettings = 0x06DD654Cu
    [<Literal>]
    let AccountSetReactionsNotifySettings = 0x316CE548u
    [<Literal>]
    let AccountGetCollectibleEmojiStatuses = 0x2E7B4543u
    [<Literal>]
    let AccountGetPaidMessagesRevenue = 0x19BA4A67u
    [<Literal>]
    let AccountToggleNoPaidMessagesException = 0xFE2EDA76u
    [<Literal>]
    let AccountSetMainProfileTab = 0x5DEE78B0u
    [<Literal>]
    let AccountSaveMusic = 0xB26732A9u
    [<Literal>]
    let AccountGetSavedMusicIds = 0xE09D5FAFu
    [<Literal>]
    let AccountGetUniqueGiftChatThemes = 0xFE74EF9Fu
    [<Literal>]
    let UsersGetUsers = 0x0D91A548u
    [<Literal>]
    let UsersGetFullUser = 0xB60F5918u
    [<Literal>]
    let UsersSetSecureValueErrors = 0x90C894B5u
    [<Literal>]
    let UsersGetRequirementsToContact = 0xD89A83A3u
    [<Literal>]
    let UsersGetSavedMusic = 0x788D7FE3u
    [<Literal>]
    let UsersGetSavedMusicByID = 0x7573A4E9u
    [<Literal>]
    let ContactsGetContactIDs = 0x7ADC669Du
    [<Literal>]
    let ContactsGetStatuses = 0xC4A353EEu
    [<Literal>]
    let ContactsGetContacts = 0x5DD69E12u
    [<Literal>]
    let ContactsImportContacts = 0x2C800BE5u
    [<Literal>]
    let ContactsDeleteContacts = 0x096A0E00u
    [<Literal>]
    let ContactsDeleteByPhones = 0x1013FD9Eu
    [<Literal>]
    let ContactsBlock = 0x2E2E8734u
    [<Literal>]
    let ContactsUnblock = 0xB550D328u
    [<Literal>]
    let ContactsGetBlocked = 0x9A868F80u
    [<Literal>]
    let ContactsSearch = 0x11F812D8u
    [<Literal>]
    let ContactsResolveUsername = 0x725AFBBCu
    [<Literal>]
    let ContactsGetTopPeers = 0x973478B6u
    [<Literal>]
    let ContactsResetTopPeerRating = 0x1AE373ACu
    [<Literal>]
    let ContactsResetSaved = 0x879537F1u
    [<Literal>]
    let ContactsGetSaved = 0x82F1E39Fu
    [<Literal>]
    let ContactsToggleTopPeers = 0x8514BDDAu
    [<Literal>]
    let ContactsAddContact = 0xE8F463D0u
    [<Literal>]
    let ContactsAcceptContact = 0xF831A20Fu
    [<Literal>]
    let ContactsGetLocated = 0xD348BC44u
    [<Literal>]
    let ContactsBlockFromReplies = 0x29A8962Cu
    [<Literal>]
    let ContactsResolvePhone = 0x8AF94344u
    [<Literal>]
    let ContactsExportContactToken = 0xF8654027u
    [<Literal>]
    let ContactsImportContactToken = 0x13005788u
    [<Literal>]
    let ContactsEditCloseFriends = 0xBA6705F0u
    [<Literal>]
    let ContactsSetBlocked = 0x94C65C76u
    [<Literal>]
    let ContactsGetBirthdays = 0xDAEDA864u
    [<Literal>]
    let ContactsGetSponsoredPeers = 0xB6C8C393u
    [<Literal>]
    let MessagesGetMessages = 0x63C66506u
    [<Literal>]
    let MessagesGetDialogs = 0xA0F4CB4Fu
    [<Literal>]
    let MessagesGetHistory = 0x4423E6C5u
    [<Literal>]
    let MessagesSearch = 0x29EE847Au
    [<Literal>]
    let MessagesReadHistory = 0x0E306D3Au
    [<Literal>]
    let MessagesDeleteHistory = 0xB08F922Au
    [<Literal>]
    let MessagesDeleteMessages = 0xE58E95D2u
    [<Literal>]
    let MessagesReceivedMessages = 0x05A954C0u
    [<Literal>]
    let MessagesSetTyping = 0x58943EE2u
    [<Literal>]
    let MessagesSendMessage = 0xFE05DC9Au
    [<Literal>]
    let MessagesSendMedia = 0xAC55D9C1u
    [<Literal>]
    let MessagesForwardMessages = 0x978928CAu
    [<Literal>]
    let MessagesReportSpam = 0xCF1592DBu
    [<Literal>]
    let MessagesGetPeerSettings = 0xEFD9A6A2u
    [<Literal>]
    let MessagesReport = 0xFC78AF9Bu
    [<Literal>]
    let MessagesGetChats = 0x49E9528Fu
    [<Literal>]
    let MessagesGetFullChat = 0xAEB00B34u
    [<Literal>]
    let MessagesEditChatTitle = 0x73783FFDu
    [<Literal>]
    let MessagesEditChatPhoto = 0x35DDD674u
    [<Literal>]
    let MessagesAddChatUser = 0xCBC6D107u
    [<Literal>]
    let MessagesDeleteChatUser = 0xA2185CABu
    [<Literal>]
    let MessagesCreateChat = 0x92CEDDD4u
    [<Literal>]
    let MessagesGetDhConfig = 0x26CF8950u
    [<Literal>]
    let MessagesRequestEncryption = 0xF64DAF43u
    [<Literal>]
    let MessagesAcceptEncryption = 0x3DBC0415u
    [<Literal>]
    let MessagesDiscardEncryption = 0xF393AEA0u
    [<Literal>]
    let MessagesSetEncryptedTyping = 0x791451EDu
    [<Literal>]
    let MessagesReadEncryptedHistory = 0x7F4B690Au
    [<Literal>]
    let MessagesSendEncrypted = 0x44FA7A15u
    [<Literal>]
    let MessagesSendEncryptedFile = 0x5559481Du
    [<Literal>]
    let MessagesSendEncryptedService = 0x32D439A4u
    [<Literal>]
    let MessagesReceivedQueue = 0x55A5BB66u
    [<Literal>]
    let MessagesReportEncryptedSpam = 0x4B0C8C0Fu
    [<Literal>]
    let MessagesReadMessageContents = 0x36A73F77u
    [<Literal>]
    let MessagesGetStickers = 0xD5A5D3A1u
    [<Literal>]
    let MessagesGetAllStickers = 0xB8A0A1A8u
    [<Literal>]
    let MessagesGetWebPagePreview = 0x570D6F6Fu
    [<Literal>]
    let MessagesExportChatInvite = 0xA455DE90u
    [<Literal>]
    let MessagesCheckChatInvite = 0x3EADB1BBu
    [<Literal>]
    let MessagesImportChatInvite = 0x6C50051Cu
    [<Literal>]
    let MessagesGetStickerSet = 0xC8A0EC74u
    [<Literal>]
    let MessagesInstallStickerSet = 0xC78FE460u
    [<Literal>]
    let MessagesUninstallStickerSet = 0xF96E55DEu
    [<Literal>]
    let MessagesStartBot = 0xE6DF7378u
    [<Literal>]
    let MessagesGetMessagesViews = 0x5784D3E1u
    [<Literal>]
    let MessagesEditChatAdmin = 0xA85BD1C2u
    [<Literal>]
    let MessagesMigrateChat = 0xA2875319u
    [<Literal>]
    let MessagesSearchGlobal = 0x4BC6589Au
    [<Literal>]
    let MessagesReorderStickerSets = 0x78337739u
    [<Literal>]
    let MessagesGetDocumentByHash = 0xB1F2061Fu
    [<Literal>]
    let MessagesGetSavedGifs = 0x5CF09635u
    [<Literal>]
    let MessagesSaveGif = 0x327A30CBu
    [<Literal>]
    let MessagesGetInlineBotResults = 0x514E999Du
    [<Literal>]
    let MessagesSetInlineBotResults = 0xBB12A419u
    [<Literal>]
    let MessagesSendInlineBotResult = 0xC0CF7646u
    [<Literal>]
    let MessagesGetMessageEditData = 0xFDA68D36u
    [<Literal>]
    let MessagesEditMessage = 0xDFD14005u
    [<Literal>]
    let MessagesEditInlineBotMessage = 0x83557DBAu
    [<Literal>]
    let MessagesGetBotCallbackAnswer = 0x9342CA07u
    [<Literal>]
    let MessagesSetBotCallbackAnswer = 0xD58F130Au
    [<Literal>]
    let MessagesGetPeerDialogs = 0xE470BCFDu
    [<Literal>]
    let MessagesSaveDraft = 0x54AE308Eu
    [<Literal>]
    let MessagesGetAllDrafts = 0x6A3F8D65u
    [<Literal>]
    let MessagesGetFeaturedStickers = 0x64780B14u
    [<Literal>]
    let MessagesReadFeaturedStickers = 0x5B118126u
    [<Literal>]
    let MessagesGetRecentStickers = 0x9DA9403Bu
    [<Literal>]
    let MessagesSaveRecentSticker = 0x392718F8u
    [<Literal>]
    let MessagesClearRecentStickers = 0x8999602Du
    [<Literal>]
    let MessagesGetArchivedStickers = 0x57F17692u
    [<Literal>]
    let MessagesGetMaskStickers = 0x640F82B8u
    [<Literal>]
    let MessagesGetAttachedStickers = 0xCC5B67CCu
    [<Literal>]
    let MessagesSetGameScore = 0x8EF8ECC0u
    [<Literal>]
    let MessagesSetInlineGameScore = 0x15AD9F64u
    [<Literal>]
    let MessagesGetGameHighScores = 0xE822649Du
    [<Literal>]
    let MessagesGetInlineGameHighScores = 0x0F635E1Bu
    [<Literal>]
    let MessagesGetCommonChats = 0xE40CA104u
    [<Literal>]
    let MessagesGetWebPage = 0x8D9692A3u
    [<Literal>]
    let MessagesToggleDialogPin = 0xA731E257u
    [<Literal>]
    let MessagesReorderPinnedDialogs = 0x3B1ADF37u
    [<Literal>]
    let MessagesGetPinnedDialogs = 0xD6B94DF2u
    [<Literal>]
    let MessagesSetBotShippingResults = 0xE5F672FAu
    [<Literal>]
    let MessagesSetBotPrecheckoutResults = 0x09C2DD95u
    [<Literal>]
    let MessagesUploadMedia = 0x14967978u
    [<Literal>]
    let MessagesSendScreenshotNotification = 0xA1405817u
    [<Literal>]
    let MessagesGetFavedStickers = 0x04F1AAA9u
    [<Literal>]
    let MessagesFaveSticker = 0xB9FFC55Bu
    [<Literal>]
    let MessagesGetUnreadMentions = 0xF107E790u
    [<Literal>]
    let MessagesReadMentions = 0x36E5BF4Du
    [<Literal>]
    let MessagesGetRecentLocations = 0x702A40E0u
    [<Literal>]
    let MessagesSendMultiMedia = 0x1BF89D74u
    [<Literal>]
    let MessagesUploadEncryptedFile = 0x5057C497u
    [<Literal>]
    let MessagesSearchStickerSets = 0x35705B8Au
    [<Literal>]
    let MessagesGetSplitRanges = 0x1CFF7E08u
    [<Literal>]
    let MessagesMarkDialogUnread = 0x8C5006F8u
    [<Literal>]
    let MessagesGetDialogUnreadMarks = 0x21202222u
    [<Literal>]
    let MessagesClearAllDrafts = 0x7E58EE9Cu
    [<Literal>]
    let MessagesUpdatePinnedMessage = 0xD2AAF7ECu
    [<Literal>]
    let MessagesSendVote = 0x10EA6184u
    [<Literal>]
    let MessagesGetPollResults = 0x73BB643Bu
    [<Literal>]
    let MessagesGetOnlines = 0x6E2BE050u
    [<Literal>]
    let MessagesEditChatAbout = 0xDEF60797u
    [<Literal>]
    let MessagesEditChatDefaultBannedRights = 0xA5866B41u
    [<Literal>]
    let MessagesGetEmojiKeywords = 0x35A0E062u
    [<Literal>]
    let MessagesGetEmojiKeywordsDifference = 0x1508B6AFu
    [<Literal>]
    let MessagesGetEmojiKeywordsLanguages = 0x4E9963B2u
    [<Literal>]
    let MessagesGetEmojiURL = 0xD5B10C26u
    [<Literal>]
    let MessagesGetSearchCounters = 0x1BBCF300u
    [<Literal>]
    let MessagesRequestUrlAuth = 0x198FB446u
    [<Literal>]
    let MessagesAcceptUrlAuth = 0xB12C7125u
    [<Literal>]
    let MessagesHidePeerSettingsBar = 0x4FACB138u
    [<Literal>]
    let MessagesGetScheduledHistory = 0xF516760Bu
    [<Literal>]
    let MessagesGetScheduledMessages = 0xBDBB0464u
    [<Literal>]
    let MessagesSendScheduledMessages = 0xBD38850Au
    [<Literal>]
    let MessagesDeleteScheduledMessages = 0x59AE2B16u
    [<Literal>]
    let MessagesGetPollVotes = 0xB86E380Eu
    [<Literal>]
    let MessagesToggleStickerSets = 0xB5052FEAu
    [<Literal>]
    let MessagesGetDialogFilters = 0xEFD48C89u
    [<Literal>]
    let MessagesGetSuggestedDialogFilters = 0xA29CD42Cu
    [<Literal>]
    let MessagesUpdateDialogFilter = 0x1AD4A04Au
    [<Literal>]
    let MessagesUpdateDialogFiltersOrder = 0xC563C1E4u
    [<Literal>]
    let MessagesGetOldFeaturedStickers = 0x7ED094A1u
    [<Literal>]
    let MessagesGetReplies = 0x22DDD30Cu
    [<Literal>]
    let MessagesGetDiscussionMessage = 0x446972FDu
    [<Literal>]
    let MessagesReadDiscussion = 0xF731A9F4u
    [<Literal>]
    let MessagesUnpinAllMessages = 0x062DD747u
    [<Literal>]
    let MessagesDeleteChat = 0x5BD0EE50u
    [<Literal>]
    let MessagesDeletePhoneCallHistory = 0xF9CBE409u
    [<Literal>]
    let MessagesCheckHistoryImport = 0x43FE19F3u
    [<Literal>]
    let MessagesInitHistoryImport = 0x34090C3Bu
    [<Literal>]
    let MessagesUploadImportedMedia = 0x2A862092u
    [<Literal>]
    let MessagesStartHistoryImport = 0xB43DF344u
    [<Literal>]
    let MessagesGetExportedChatInvites = 0xA2B5A3F6u
    [<Literal>]
    let MessagesGetExportedChatInvite = 0x73746F5Cu
    [<Literal>]
    let MessagesEditExportedChatInvite = 0xBDCA2F75u
    [<Literal>]
    let MessagesDeleteRevokedExportedChatInvites = 0x56987BD5u
    [<Literal>]
    let MessagesDeleteExportedChatInvite = 0xD464A42Bu
    [<Literal>]
    let MessagesGetAdminsWithInvites = 0x3920E6EFu
    [<Literal>]
    let MessagesGetChatInviteImporters = 0xDF04DD4Eu
    [<Literal>]
    let MessagesSetHistoryTTL = 0xB80E5FE4u
    [<Literal>]
    let MessagesCheckHistoryImportPeer = 0x5DC60F03u
    [<Literal>]
    let MessagesSetChatTheme = 0x081202C9u
    [<Literal>]
    let MessagesGetMessageReadParticipants = 0x31C1C44Fu
    [<Literal>]
    let MessagesGetSearchResultsCalendar = 0x6AA3F6BDu
    [<Literal>]
    let MessagesGetSearchResultsPositions = 0x9C7F2F10u
    [<Literal>]
    let MessagesHideChatJoinRequest = 0x7FE7E815u
    [<Literal>]
    let MessagesHideAllChatJoinRequests = 0xE085F4EAu
    [<Literal>]
    let MessagesToggleNoForwards = 0xB11EAFA2u
    [<Literal>]
    let MessagesSaveDefaultSendAs = 0xCCFDDF96u
    [<Literal>]
    let MessagesSendReaction = 0xD30D78D4u
    [<Literal>]
    let MessagesGetMessagesReactions = 0x8BBA90E6u
    [<Literal>]
    let MessagesGetMessageReactionsList = 0x461B3F48u
    [<Literal>]
    let MessagesSetChatAvailableReactions = 0x864B2581u
    [<Literal>]
    let MessagesGetAvailableReactions = 0x18DEA0ACu
    [<Literal>]
    let MessagesSetDefaultReaction = 0x4F47A016u
    [<Literal>]
    let MessagesTranslateText = 0x63183030u
    [<Literal>]
    let MessagesGetUnreadReactions = 0xBD7F90ACu
    [<Literal>]
    let MessagesReadReactions = 0x9EC44F93u
    [<Literal>]
    let MessagesSearchSentMedia = 0x107E31A0u
    [<Literal>]
    let MessagesGetAttachMenuBots = 0x16FCC2CBu
    [<Literal>]
    let MessagesGetAttachMenuBot = 0x77216192u
    [<Literal>]
    let MessagesToggleBotInAttachMenu = 0x69F59D69u
    [<Literal>]
    let MessagesRequestWebView = 0x269DC2C1u
    [<Literal>]
    let MessagesProlongWebView = 0xB0D81A83u
    [<Literal>]
    let MessagesRequestSimpleWebView = 0x413A3E73u
    [<Literal>]
    let MessagesSendWebViewResultMessage = 0x0A4314F5u
    [<Literal>]
    let MessagesSendWebViewData = 0xDC0242C8u
    [<Literal>]
    let MessagesTranscribeAudio = 0x269E9A49u
    [<Literal>]
    let MessagesRateTranscribedAudio = 0x7F1D072Fu
    [<Literal>]
    let MessagesGetCustomEmojiDocuments = 0xD9AB0F54u
    [<Literal>]
    let MessagesGetEmojiStickers = 0xFBFCA18Fu
    [<Literal>]
    let MessagesGetFeaturedEmojiStickers = 0x0ECF6736u
    [<Literal>]
    let MessagesReportReaction = 0x3F64C076u
    [<Literal>]
    let MessagesGetTopReactions = 0xBB8125BAu
    [<Literal>]
    let MessagesGetRecentReactions = 0x39461DB2u
    [<Literal>]
    let MessagesClearRecentReactions = 0x9DFEEFB4u
    [<Literal>]
    let MessagesGetExtendedMedia = 0x84F80814u
    [<Literal>]
    let MessagesSetDefaultHistoryTTL = 0x9EB51445u
    [<Literal>]
    let MessagesGetDefaultHistoryTTL = 0x658B7188u
    [<Literal>]
    let MessagesSendBotRequestedPeer = 0x91B2D060u
    [<Literal>]
    let MessagesGetEmojiGroups = 0x7488CE5Bu
    [<Literal>]
    let MessagesGetEmojiStatusGroups = 0x2ECD56CDu
    [<Literal>]
    let MessagesGetEmojiProfilePhotoGroups = 0x21A548F3u
    [<Literal>]
    let MessagesSearchCustomEmoji = 0x2C11C0D7u
    [<Literal>]
    let MessagesTogglePeerTranslations = 0xE47CB579u
    [<Literal>]
    let MessagesGetBotApp = 0x34FDC5C3u
    [<Literal>]
    let MessagesRequestAppWebView = 0x53618BCEu
    [<Literal>]
    let MessagesSetChatWallPaper = 0x8FFACAE1u
    [<Literal>]
    let MessagesSearchEmojiStickerSets = 0x92B4494Cu
    [<Literal>]
    let MessagesGetSavedDialogs = 0x1E91FC99u
    [<Literal>]
    let MessagesGetSavedHistory = 0x998AB009u
    [<Literal>]
    let MessagesDeleteSavedHistory = 0x4DC5085Fu
    [<Literal>]
    let MessagesGetPinnedSavedDialogs = 0xD63D94E0u
    [<Literal>]
    let MessagesToggleSavedDialogPin = 0xAC81BBDEu
    [<Literal>]
    let MessagesReorderPinnedSavedDialogs = 0x8B716587u
    [<Literal>]
    let MessagesGetSavedReactionTags = 0x3637E05Bu
    [<Literal>]
    let MessagesUpdateSavedReactionTag = 0x60297DECu
    [<Literal>]
    let MessagesGetDefaultTagReactions = 0xBDF93428u
    [<Literal>]
    let MessagesGetOutboxReadDate = 0x8C4BFE5Du
    [<Literal>]
    let MessagesGetQuickReplies = 0xD483F2A8u
    [<Literal>]
    let MessagesReorderQuickReplies = 0x60331907u
    [<Literal>]
    let MessagesCheckQuickReplyShortcut = 0xF1D0FBD3u
    [<Literal>]
    let MessagesEditQuickReplyShortcut = 0x5C003CEFu
    [<Literal>]
    let MessagesDeleteQuickReplyShortcut = 0x3CC04740u
    [<Literal>]
    let MessagesGetQuickReplyMessages = 0x94A495C3u
    [<Literal>]
    let MessagesSendQuickReplyMessages = 0x6C750DE1u
    [<Literal>]
    let MessagesDeleteQuickReplyMessages = 0xE105E910u
    [<Literal>]
    let MessagesToggleDialogFilterTags = 0xFD2DDA49u
    [<Literal>]
    let MessagesGetMyStickers = 0xD0B5E1FCu
    [<Literal>]
    let MessagesGetEmojiStickerGroups = 0x1DD840F5u
    [<Literal>]
    let MessagesGetAvailableEffects = 0xDEA20A39u
    [<Literal>]
    let MessagesEditFactCheck = 0x0589EE75u
    [<Literal>]
    let MessagesDeleteFactCheck = 0xD1DA940Cu
    [<Literal>]
    let MessagesGetFactCheck = 0xB9CDC5EEu
    [<Literal>]
    let MessagesRequestMainWebView = 0xC9E01E7Bu
    [<Literal>]
    let MessagesSendPaidReaction = 0x58BBCB50u
    [<Literal>]
    let MessagesTogglePaidReactionPrivacy = 0x435885B5u
    [<Literal>]
    let MessagesGetPaidReactionPrivacy = 0x472455AAu
    [<Literal>]
    let MessagesViewSponsoredMessage = 0x269E3643u
    [<Literal>]
    let MessagesClickSponsoredMessage = 0x8235057Eu
    [<Literal>]
    let MessagesReportSponsoredMessage = 0x12CBF0C4u
    [<Literal>]
    let MessagesGetSponsoredMessages = 0x3D6CE850u
    [<Literal>]
    let MessagesSavePreparedInlineMessage = 0xF21F7F2Fu
    [<Literal>]
    let MessagesGetPreparedInlineMessage = 0x857EBDB8u
    [<Literal>]
    let MessagesSearchStickers = 0x29B1C66Au
    [<Literal>]
    let MessagesReportMessagesDelivery = 0x5A6D7395u
    [<Literal>]
    let MessagesGetSavedDialogsByID = 0x6F6F9C96u
    [<Literal>]
    let MessagesReadSavedHistory = 0xBA4A3B5Bu
    [<Literal>]
    let MessagesToggleTodoCompleted = 0xD3E03124u
    [<Literal>]
    let MessagesAppendTodoList = 0x21A61057u
    [<Literal>]
    let MessagesToggleSuggestedPostApproval = 0x8107455Cu
    [<Literal>]
    let UpdatesGetState = 0xEDD4882Au
    [<Literal>]
    let UpdatesGetDifference = 0x19C2F763u
    [<Literal>]
    let UpdatesGetChannelDifference = 0x03173D78u
    [<Literal>]
    let PhotosUpdateProfilePhoto = 0x09E82039u
    [<Literal>]
    let PhotosUploadProfilePhoto = 0x0388A3B5u
    [<Literal>]
    let PhotosDeletePhotos = 0x87CF7F2Fu
    [<Literal>]
    let PhotosGetUserPhotos = 0x91CD32A8u
    [<Literal>]
    let PhotosUploadContactProfilePhoto = 0xE14C4A71u
    [<Literal>]
    let UploadSaveFilePart = 0xB304A621u
    [<Literal>]
    let UploadGetFile = 0xBE5335BEu
    [<Literal>]
    let UploadSaveBigFilePart = 0xDE7B673Du
    [<Literal>]
    let UploadGetWebFile = 0x24E6818Du
    [<Literal>]
    let UploadGetCdnFile = 0x395F69DAu
    [<Literal>]
    let UploadReuploadCdnFile = 0x9B2754A8u
    [<Literal>]
    let UploadGetCdnFileHashes = 0x91DC3F31u
    [<Literal>]
    let UploadGetFileHashes = 0x9156982Au
    [<Literal>]
    let HelpGetConfig = 0xC4F9186Bu
    [<Literal>]
    let HelpGetNearestDc = 0x1FB33026u
    [<Literal>]
    let HelpGetAppUpdate = 0x522D5A7Du
    [<Literal>]
    let HelpGetInviteText = 0x4D392343u
    [<Literal>]
    let HelpGetSupport = 0x9CDF08CDu
    [<Literal>]
    let HelpSetBotUpdatesStatus = 0xEC22CFCDu
    [<Literal>]
    let HelpGetCdnConfig = 0x52029342u
    [<Literal>]
    let HelpGetRecentMeUrls = 0x3DC0F114u
    [<Literal>]
    let HelpGetTermsOfServiceUpdate = 0x2CA51FD1u
    [<Literal>]
    let HelpAcceptTermsOfService = 0xEE72F79Au
    [<Literal>]
    let HelpGetDeepLinkInfo = 0x3FEDC75Fu
    [<Literal>]
    let HelpGetAppConfig = 0x61E3F854u
    [<Literal>]
    let HelpSaveAppLog = 0x6F02F748u
    [<Literal>]
    let HelpGetPassportConfig = 0xC661AD08u
    [<Literal>]
    let HelpGetSupportName = 0xD360E72Cu
    [<Literal>]
    let HelpGetUserInfo = 0x038A08D3u
    [<Literal>]
    let HelpEditUserInfo = 0x66B91B70u
    [<Literal>]
    let HelpGetPromoData = 0xC0977421u
    [<Literal>]
    let HelpHidePromoData = 0x1E251C95u
    [<Literal>]
    let HelpDismissSuggestion = 0xF50DBAA1u
    [<Literal>]
    let HelpGetCountriesList = 0x735787A8u
    [<Literal>]
    let HelpGetPremiumPromo = 0xB81B93D4u
    [<Literal>]
    let HelpGetPeerColors = 0xDA80F42Fu
    [<Literal>]
    let HelpGetPeerProfileColors = 0xABCFA9FDu
    [<Literal>]
    let HelpGetTimezonesList = 0x49B30240u
    [<Literal>]
    let ChannelsReadHistory = 0xCC104937u
    [<Literal>]
    let ChannelsDeleteMessages = 0x84C1FD4Eu
    [<Literal>]
    let ChannelsReportSpam = 0xF44A8315u
    [<Literal>]
    let ChannelsGetMessages = 0xAD8C9A23u
    [<Literal>]
    let ChannelsGetParticipants = 0x77CED9D0u
    [<Literal>]
    let ChannelsGetParticipant = 0xA0AB6CC6u
    [<Literal>]
    let ChannelsGetChannels = 0x0A7F6BBBu
    [<Literal>]
    let ChannelsGetFullChannel = 0x08736A09u
    [<Literal>]
    let ChannelsCreateChannel = 0x91006707u
    [<Literal>]
    let ChannelsEditAdmin = 0xD33C8902u
    [<Literal>]
    let ChannelsEditTitle = 0x566DECD0u
    [<Literal>]
    let ChannelsEditPhoto = 0xF12E57C9u
    [<Literal>]
    let ChannelsCheckUsername = 0x10E6BD2Cu
    [<Literal>]
    let ChannelsUpdateUsername = 0x3514B3DEu
    [<Literal>]
    let ChannelsJoinChannel = 0x24B524C5u
    [<Literal>]
    let ChannelsLeaveChannel = 0xF836AA95u
    [<Literal>]
    let ChannelsInviteToChannel = 0xC9E33D54u
    [<Literal>]
    let ChannelsDeleteChannel = 0xC0111FE3u
    [<Literal>]
    let ChannelsExportMessageLink = 0xE63FADEBu
    [<Literal>]
    let ChannelsToggleSignatures = 0x418D549Cu
    [<Literal>]
    let ChannelsGetAdminedPublicChannels = 0xF8B036AFu
    [<Literal>]
    let ChannelsEditBanned = 0x96E6CD81u
    [<Literal>]
    let ChannelsGetAdminLog = 0x33DDF480u
    [<Literal>]
    let ChannelsSetStickers = 0xEA8CA4F9u
    [<Literal>]
    let ChannelsReadMessageContents = 0xEAB5DC38u
    [<Literal>]
    let ChannelsDeleteHistory = 0x9BAA9647u
    [<Literal>]
    let ChannelsTogglePreHistoryHidden = 0xEABBB94Cu
    [<Literal>]
    let ChannelsGetLeftChannels = 0x8341ECC0u
    [<Literal>]
    let ChannelsGetGroupsForDiscussion = 0xF5DAD378u
    [<Literal>]
    let ChannelsSetDiscussionGroup = 0x40582BB2u
    [<Literal>]
    let ChannelsEditCreator = 0x8F38CD1Fu
    [<Literal>]
    let ChannelsEditLocation = 0x58E63F6Du
    [<Literal>]
    let ChannelsToggleSlowMode = 0xEDD49EF0u
    [<Literal>]
    let ChannelsGetInactiveChannels = 0x11E831EEu
    [<Literal>]
    let ChannelsConvertToGigagroup = 0x0B290C69u
    [<Literal>]
    let ChannelsGetSendAs = 0xE785A43Fu
    [<Literal>]
    let ChannelsDeleteParticipantHistory = 0x367544DBu
    [<Literal>]
    let ChannelsToggleJoinToSend = 0xE4CB9580u
    [<Literal>]
    let ChannelsToggleJoinRequest = 0x4C2985B6u
    [<Literal>]
    let ChannelsReorderUsernames = 0xB45CED1Du
    [<Literal>]
    let ChannelsToggleUsername = 0x50F24105u
    [<Literal>]
    let ChannelsDeactivateAllUsernames = 0x0A245DD3u
    [<Literal>]
    let ChannelsToggleForum = 0x3FF75734u
    [<Literal>]
    let ChannelsCreateForumTopic = 0xF40C0224u
    [<Literal>]
    let ChannelsGetForumTopics = 0x0DE560D1u
    [<Literal>]
    let ChannelsGetForumTopicsByID = 0xB0831EB9u
    [<Literal>]
    let ChannelsEditForumTopic = 0xF4DFA185u
    [<Literal>]
    let ChannelsUpdatePinnedForumTopic = 0x6C2D9026u
    [<Literal>]
    let ChannelsDeleteTopicHistory = 0x34435F2Du
    [<Literal>]
    let ChannelsReorderPinnedForumTopics = 0x2950A18Fu
    [<Literal>]
    let ChannelsToggleAntiSpam = 0x68F3E4EBu
    [<Literal>]
    let ChannelsReportAntiSpamFalsePositive = 0xA850A693u
    [<Literal>]
    let ChannelsToggleParticipantsHidden = 0x6A6E7854u
    [<Literal>]
    let ChannelsUpdateColor = 0xD8AA3671u
    [<Literal>]
    let ChannelsToggleViewForumAsMessages = 0x9738BB15u
    [<Literal>]
    let ChannelsGetChannelRecommendations = 0x25A71742u
    [<Literal>]
    let ChannelsUpdateEmojiStatus = 0xF0D3E6A8u
    [<Literal>]
    let ChannelsSetBoostsToUnblockRestrictions = 0xAD399CEEu
    [<Literal>]
    let ChannelsSetEmojiStickers = 0x3CD930B7u
    [<Literal>]
    let ChannelsRestrictSponsoredMessages = 0x9AE91519u
    [<Literal>]
    let ChannelsSearchPosts = 0xF2C4F24Du
    [<Literal>]
    let ChannelsUpdatePaidMessagesPrice = 0x4B12327Bu
    [<Literal>]
    let ChannelsToggleAutotranslation = 0x167FC0A1u
    [<Literal>]
    let ChannelsGetMessageAuthor = 0xECE2A0E6u
    [<Literal>]
    let ChannelsCheckSearchPostsFlood = 0x22567115u
    [<Literal>]
    let ChannelsSetMainProfileTab = 0x3583FCB1u
    [<Literal>]
    let BotsSendCustomRequest = 0xAA2769EDu
    [<Literal>]
    let BotsAnswerWebhookJSONQuery = 0xE6213F4Du
    [<Literal>]
    let BotsSetBotCommands = 0x0517165Au
    [<Literal>]
    let BotsResetBotCommands = 0x3D8DE0F9u
    [<Literal>]
    let BotsGetBotCommands = 0xE34C0DD6u
    [<Literal>]
    let BotsSetBotMenuButton = 0x4504D54Fu
    [<Literal>]
    let BotsGetBotMenuButton = 0x9C60EB28u
    [<Literal>]
    let BotsSetBotBroadcastDefaultAdminRights = 0x788464E1u
    [<Literal>]
    let BotsSetBotGroupDefaultAdminRights = 0x925EC9EAu
    [<Literal>]
    let BotsSetBotInfo = 0x10CF3123u
    [<Literal>]
    let BotsGetBotInfo = 0xDCD914FDu
    [<Literal>]
    let BotsReorderUsernames = 0x9709B1C2u
    [<Literal>]
    let BotsToggleUsername = 0x053CA973u
    [<Literal>]
    let BotsCanSendMessage = 0x1359F4E6u
    [<Literal>]
    let BotsAllowSendMessage = 0xF132E3EFu
    [<Literal>]
    let BotsInvokeWebViewCustomMethod = 0x087FC5E7u
    [<Literal>]
    let BotsGetPopularAppBots = 0xC2510192u
    [<Literal>]
    let BotsAddPreviewMedia = 0x17AEB75Au
    [<Literal>]
    let BotsEditPreviewMedia = 0x8525606Fu
    [<Literal>]
    let BotsDeletePreviewMedia = 0x2D0135B3u
    [<Literal>]
    let BotsReorderPreviewMedias = 0xB627F3AAu
    [<Literal>]
    let BotsGetPreviewInfo = 0x423AB3ADu
    [<Literal>]
    let BotsGetPreviewMedias = 0xA2A5594Du
    [<Literal>]
    let BotsUpdateUserEmojiStatus = 0xED9F30C5u
    [<Literal>]
    let BotsToggleUserEmojiStatusPermission = 0x06DE6392u
    [<Literal>]
    let BotsCheckDownloadFileParams = 0x50077589u
    [<Literal>]
    let BotsGetAdminedBots = 0xB0711D83u
    [<Literal>]
    let BotsUpdateStarRefProgram = 0x778B5AB3u
    [<Literal>]
    let BotsSetCustomVerification = 0x8B89DFBDu
    [<Literal>]
    let BotsGetBotRecommendations = 0xA1B70815u
    [<Literal>]
    let PaymentsGetPaymentForm = 0x37148DBBu
    [<Literal>]
    let PaymentsGetPaymentReceipt = 0x2478D1CCu
    [<Literal>]
    let PaymentsValidateRequestedInfo = 0xB6C8F12Bu
    [<Literal>]
    let PaymentsSendPaymentForm = 0x2D03522Fu
    [<Literal>]
    let PaymentsGetSavedInfo = 0x227D824Bu
    [<Literal>]
    let PaymentsClearSavedInfo = 0xD83D70C1u
    [<Literal>]
    let PaymentsGetBankCardData = 0x2E79D779u
    [<Literal>]
    let PaymentsExportInvoice = 0x0F91B065u
    [<Literal>]
    let PaymentsAssignAppStoreTransaction = 0x80ED747Du
    [<Literal>]
    let PaymentsAssignPlayMarketTransaction = 0xDFFD50D3u
    [<Literal>]
    let PaymentsGetPremiumGiftCodeOptions = 0x2757BA54u
    [<Literal>]
    let PaymentsCheckGiftCode = 0x8E51B4C1u
    [<Literal>]
    let PaymentsApplyGiftCode = 0xF6E26854u
    [<Literal>]
    let PaymentsGetGiveawayInfo = 0xF4239425u
    [<Literal>]
    let PaymentsLaunchPrepaidGiveaway = 0x5FF58F20u
    [<Literal>]
    let PaymentsGetStarsTopupOptions = 0xC00EC7D3u
    [<Literal>]
    let PaymentsGetStarsStatus = 0x4EA9B3BFu
    [<Literal>]
    let PaymentsGetStarsTransactions = 0x69DA4557u
    [<Literal>]
    let PaymentsSendStarsForm = 0x7998C914u
    [<Literal>]
    let PaymentsRefundStarsCharge = 0x25AE8F4Au
    [<Literal>]
    let PaymentsGetStarsRevenueStats = 0xD91FFAD6u
    [<Literal>]
    let PaymentsGetStarsRevenueWithdrawalUrl = 0x2433DC92u
    [<Literal>]
    let PaymentsGetStarsRevenueAdsAccountUrl = 0xD1D7EFC5u
    [<Literal>]
    let PaymentsGetStarsTransactionsByID = 0x2DCA16B8u
    [<Literal>]
    let PaymentsGetStarsGiftOptions = 0xD3C96BC8u
    [<Literal>]
    let PaymentsGetStarsSubscriptions = 0x032512C5u
    [<Literal>]
    let PaymentsChangeStarsSubscription = 0xC7770878u
    [<Literal>]
    let PaymentsFulfillStarsSubscription = 0xCC5BEBB3u
    [<Literal>]
    let PaymentsGetStarsGiveawayOptions = 0xBD1EFD3Eu
    [<Literal>]
    let PaymentsGetStarGifts = 0xC4563590u
    [<Literal>]
    let PaymentsSaveStarGift = 0x2A2A697Cu
    [<Literal>]
    let PaymentsConvertStarGift = 0x74BF076Bu
    [<Literal>]
    let PaymentsBotCancelStarsSubscription = 0x6DFA0622u
    [<Literal>]
    let PaymentsGetConnectedStarRefBots = 0x5869A553u
    [<Literal>]
    let PaymentsGetConnectedStarRefBot = 0xB7D998F0u
    [<Literal>]
    let PaymentsGetSuggestedStarRefBots = 0x0D6B48F7u
    [<Literal>]
    let PaymentsConnectStarRefBot = 0x7ED5348Au
    [<Literal>]
    let PaymentsEditConnectedStarRefBot = 0xE4FCA4A3u
    [<Literal>]
    let PaymentsGetStarGiftUpgradePreview = 0x9C9ABCB1u
    [<Literal>]
    let PaymentsUpgradeStarGift = 0xAED6E4F5u
    [<Literal>]
    let PaymentsTransferStarGift = 0x7F18176Au
    [<Literal>]
    let PaymentsGetUniqueStarGift = 0xA1974D72u
    [<Literal>]
    let PaymentsGetSavedStarGifts = 0xA319E569u
    [<Literal>]
    let PaymentsGetSavedStarGift = 0xB455A106u
    [<Literal>]
    let PaymentsGetStarGiftWithdrawalUrl = 0xD06E93A8u
    [<Literal>]
    let PaymentsToggleChatStarGiftNotifications = 0x60EAEFA1u
    [<Literal>]
    let PaymentsToggleStarGiftsPinnedToTop = 0x1513E7B0u
    [<Literal>]
    let PaymentsCanPurchaseStore = 0x4FDC5EA7u
    [<Literal>]
    let PaymentsGetResaleStarGifts = 0x7A5FA236u
    [<Literal>]
    let PaymentsUpdateStarGiftPrice = 0xEDBE6CCBu
    [<Literal>]
    let PaymentsCreateStarGiftCollection = 0x1F4A0E87u
    [<Literal>]
    let PaymentsUpdateStarGiftCollection = 0x4FDDBEE7u
    [<Literal>]
    let PaymentsReorderStarGiftCollections = 0xC32AF4CCu
    [<Literal>]
    let PaymentsDeleteStarGiftCollection = 0xAD5648E8u
    [<Literal>]
    let PaymentsGetStarGiftCollections = 0x981B91DDu
    [<Literal>]
    let PaymentsGetUniqueStarGiftValueInfo = 0x4365AF6Bu
    [<Literal>]
    let PaymentsCheckCanSendGift = 0xC0C4EDC9u
    [<Literal>]
    let StickersCreateStickerSet = 0x9021AB67u
    [<Literal>]
    let StickersRemoveStickerFromSet = 0xF7760F51u
    [<Literal>]
    let StickersChangeStickerPosition = 0xFFB6D4CAu
    [<Literal>]
    let StickersAddStickerToSet = 0x8653FEBEu
    [<Literal>]
    let StickersSetStickerSetThumb = 0xA76A5392u
    [<Literal>]
    let StickersCheckShortName = 0x284B3639u
    [<Literal>]
    let StickersSuggestShortName = 0x4DAFC503u
    [<Literal>]
    let StickersChangeSticker = 0xF5537EBCu
    [<Literal>]
    let StickersRenameStickerSet = 0x124B1C00u
    [<Literal>]
    let StickersDeleteStickerSet = 0x87704394u
    [<Literal>]
    let StickersReplaceSticker = 0x4696459Au
    [<Literal>]
    let PhoneGetCallConfig = 0x55451FA9u
    [<Literal>]
    let PhoneRequestCall = 0x42FF96EDu
    [<Literal>]
    let PhoneAcceptCall = 0x3BD2B4A0u
    [<Literal>]
    let PhoneConfirmCall = 0x2EFE1722u
    [<Literal>]
    let PhoneReceivedCall = 0x17D54F61u
    [<Literal>]
    let PhoneDiscardCall = 0xB2CBC1C0u
    [<Literal>]
    let PhoneSetCallRating = 0x59EAD627u
    [<Literal>]
    let PhoneSaveCallDebug = 0x277ADD7Eu
    [<Literal>]
    let PhoneSendSignalingData = 0xFF7A9383u
    [<Literal>]
    let PhoneCreateGroupCall = 0x48CDC6D8u
    [<Literal>]
    let PhoneJoinGroupCall = 0x8FB53057u
    [<Literal>]
    let PhoneLeaveGroupCall = 0x500377F9u
    [<Literal>]
    let PhoneInviteToGroupCall = 0x7B393160u
    [<Literal>]
    let PhoneDiscardGroupCall = 0x7A777135u
    [<Literal>]
    let PhoneToggleGroupCallSettings = 0x74BBB43Du
    [<Literal>]
    let PhoneGetGroupCall = 0x041845DBu
    [<Literal>]
    let PhoneGetGroupParticipants = 0xC558D8ABu
    [<Literal>]
    let PhoneCheckGroupCall = 0xB59CF977u
    [<Literal>]
    let PhoneToggleGroupCallRecord = 0xF128C708u
    [<Literal>]
    let PhoneEditGroupCallParticipant = 0xA5273ABFu
    [<Literal>]
    let PhoneEditGroupCallTitle = 0x1CA6AC0Au
    [<Literal>]
    let PhoneGetGroupCallJoinAs = 0xEF7C213Au
    [<Literal>]
    let PhoneExportGroupCallInvite = 0xE6AA647Fu
    [<Literal>]
    let PhoneToggleGroupCallStartSubscription = 0x219C34E6u
    [<Literal>]
    let PhoneStartScheduledGroupCall = 0x5680E342u
    [<Literal>]
    let PhoneSaveDefaultGroupCallJoinAs = 0x575E1F8Cu
    [<Literal>]
    let PhoneJoinGroupCallPresentation = 0xCBEA6BC4u
    [<Literal>]
    let PhoneLeaveGroupCallPresentation = 0x1C50D144u
    [<Literal>]
    let PhoneGetGroupCallStreamChannels = 0x1AB21940u
    [<Literal>]
    let PhoneGetGroupCallStreamRtmpUrl = 0xDEB3ABBFu
    [<Literal>]
    let PhoneSaveCallLog = 0x41248786u
    [<Literal>]
    let PhoneCreateConferenceCall = 0x7D0444BBu
    [<Literal>]
    let PhoneDeleteConferenceCallParticipants = 0x8CA60525u
    [<Literal>]
    let PhoneSendConferenceCallBroadcast = 0xC6701900u
    [<Literal>]
    let PhoneInviteConferenceCallParticipant = 0xBCF22685u
    [<Literal>]
    let PhoneDeclineConferenceCallInvite = 0x3C479971u
    [<Literal>]
    let PhoneGetGroupCallChainBlocks = 0xEE9F88A6u
    [<Literal>]
    let LangpackGetLangPack = 0xF2F2330Au
    [<Literal>]
    let LangpackGetStrings = 0xEFEA3803u
    [<Literal>]
    let LangpackGetDifference = 0xCD984AA5u
    [<Literal>]
    let LangpackGetLanguages = 0x42C6978Fu
    [<Literal>]
    let LangpackGetLanguage = 0x6A596502u
    [<Literal>]
    let FoldersEditPeerFolders = 0x6847D0ABu
    [<Literal>]
    let StatsGetBroadcastStats = 0xAB42441Au
    [<Literal>]
    let StatsLoadAsyncGraph = 0x621D5FA0u
    [<Literal>]
    let StatsGetMegagroupStats = 0xDCDF8607u
    [<Literal>]
    let StatsGetMessagePublicForwards = 0x5F150144u
    [<Literal>]
    let StatsGetMessageStats = 0xB6E0A3F5u
    [<Literal>]
    let StatsGetStoryStats = 0x374FEF40u
    [<Literal>]
    let StatsGetStoryPublicForwards = 0xA6437EF6u
    [<Literal>]
    let ChatlistsExportChatlistInvite = 0x8472478Eu
    [<Literal>]
    let ChatlistsDeleteExportedInvite = 0x719C5C5Eu
    [<Literal>]
    let ChatlistsEditExportedInvite = 0x653DB63Du
    [<Literal>]
    let ChatlistsGetExportedInvites = 0xCE03DA83u
    [<Literal>]
    let ChatlistsCheckChatlistInvite = 0x41C10FFFu
    [<Literal>]
    let ChatlistsJoinChatlistInvite = 0xA6B1E39Au
    [<Literal>]
    let ChatlistsGetChatlistUpdates = 0x89419521u
    [<Literal>]
    let ChatlistsJoinChatlistUpdates = 0xE089F8F5u
    [<Literal>]
    let ChatlistsHideChatlistUpdates = 0x66E486FBu
    [<Literal>]
    let ChatlistsGetLeaveChatlistSuggestions = 0xFDBCD714u
    [<Literal>]
    let ChatlistsLeaveChatlist = 0x74FAE13Au
    [<Literal>]
    let StoriesCanSendStory = 0x30EB63F0u
    [<Literal>]
    let StoriesSendStory = 0x737FC2ECu
    [<Literal>]
    let StoriesEditStory = 0xB583BA46u
    [<Literal>]
    let StoriesDeleteStories = 0xAE59DB5Fu
    [<Literal>]
    let StoriesTogglePinned = 0x9A75A1EFu
    [<Literal>]
    let StoriesGetAllStories = 0xEEB0D625u
    [<Literal>]
    let StoriesGetPinnedStories = 0x5821A5DCu
    [<Literal>]
    let StoriesGetStoriesArchive = 0xB4352016u
    [<Literal>]
    let StoriesGetStoriesByID = 0x5774CA74u
    [<Literal>]
    let StoriesToggleAllStoriesHidden = 0x7C2557C4u
    [<Literal>]
    let StoriesReadStories = 0xA556DAC8u
    [<Literal>]
    let StoriesIncrementStoryViews = 0xB2028AFBu
    [<Literal>]
    let StoriesGetStoryViewsList = 0x7ED23C57u
    [<Literal>]
    let StoriesGetStoriesViews = 0x28E16CC8u
    [<Literal>]
    let StoriesExportStoryLink = 0x7B8DEF20u
    [<Literal>]
    let StoriesReport = 0x19D8EB45u
    [<Literal>]
    let StoriesActivateStealthMode = 0x57BBD166u
    [<Literal>]
    let StoriesSendReaction = 0x7FD736B2u
    [<Literal>]
    let StoriesGetPeerStories = 0x2C4ADA50u
    [<Literal>]
    let StoriesGetAllReadPeerStories = 0x9B5AE7F9u
    [<Literal>]
    let StoriesGetPeerMaxIDs = 0x535983C3u
    [<Literal>]
    let StoriesGetChatsToSend = 0xA56A8B60u
    [<Literal>]
    let StoriesTogglePeerStoriesHidden = 0xBD0415C4u
    [<Literal>]
    let StoriesGetStoryReactionsList = 0xB9B2881Fu
    [<Literal>]
    let StoriesTogglePinnedToTop = 0x0B297E9Bu
    [<Literal>]
    let StoriesSearchPosts = 0xD1810907u
    [<Literal>]
    let StoriesCreateAlbum = 0xA36396E5u
    [<Literal>]
    let StoriesUpdateAlbum = 0x5E5259B6u
    [<Literal>]
    let StoriesReorderAlbums = 0x8535FBD9u
    [<Literal>]
    let StoriesDeleteAlbum = 0x8D3456D0u
    [<Literal>]
    let StoriesGetAlbums = 0x25B3EAC7u
    [<Literal>]
    let StoriesGetAlbumStories = 0xAC806D61u
    [<Literal>]
    let PremiumGetBoostsList = 0x60F67660u
    [<Literal>]
    let PremiumGetMyBoosts = 0x0BE77B4Au
    [<Literal>]
    let PremiumApplyBoost = 0x6B7DA746u
    [<Literal>]
    let PremiumGetBoostsStatus = 0x042F1F61u
    [<Literal>]
    let PremiumGetUserBoosts = 0x39854D1Fu
    [<Literal>]
    let SmsjobsIsEligibleToJoin = 0x0EDC39D0u
    [<Literal>]
    let SmsjobsJoin = 0xA74ECE2Du
    [<Literal>]
    let SmsjobsLeave = 0x9898AD73u
    [<Literal>]
    let SmsjobsUpdateSettings = 0x093FA0BFu
    [<Literal>]
    let SmsjobsGetStatus = 0x10A698E8u
    [<Literal>]
    let SmsjobsGetSmsJob = 0x778D902Fu
    [<Literal>]
    let SmsjobsFinishJob = 0x4F1EBF24u
    [<Literal>]
    let FragmentGetCollectibleInfo = 0xBE1E85BAu

    // --- Aliases (multi-CID methods from different client layers) ---
    [<Literal>]
    let MessagesSendMessage2 = 0x983689B3u
    [<Literal>]
    let MessagesSendMessage3 = 0x280D096Fu
    [<Literal>]
    let MessagesSendMessage4 = 0xFE05DC9Au
    [<Literal>]
    let MessagesEditMessage2 = 0x51E842E1u
    [<Literal>]
    let ContactsAddContact2 = 0xD9BA2E54u
    [<Literal>]
    let InputPeerUser2 = 0xDDE8A54Cu
    [<Literal>]
    let InputReplyToMessage2 = 0x22C0F6D5u
    [<Literal>]
    let InputReplyToMessage3 = 0x869FBE10u
    [<Literal>]
    let MessagesSendMedia2 = 0xE44DF73Cu
    [<Literal>]
    let UpdatesGetDifference2 = 0xA1B9B13Fu

    // --- Extra (undocumented / client-specific) ---
    /// auth.initPasskeyLogin — undocumented, seen from web client
    [<Literal>]
    let InputPasskeyLogin = 0x518AD0B7u
    /// Unidentified RPC seen from web client
    [<Literal>]
    let UnknownRpc0xdea20a39 = 0xDEA20A39u
    /// messages.messages (4-vector, current layer)
    [<Literal>]
    let Messages = 0x1D73E7EAu
    /// messages.messagesSlice
    [<Literal>]
    let MessagesSlice = 0x5F206716u
    /// vector constructor
    [<Literal>]
    let VectorCid = 0x1CB5C415u
    /// messages.sendMessage layer 216 CID
    [<Literal>]
    let MessagesSendMessage1 = 0x983F9745u
    /// inputReplyToMessage old CID
    [<Literal>]
    let InputReplyToMessage1 = 0x73EC805Du
    /// channels.editAbout
    [<Literal>]
    let ChannelsEditAbout = 0x13E27F1Eu
    /// documentAttributeVideo layer 216
    [<Literal>]
    let DocumentAttributeVideo2 = 0x43C57C48u
    /// inputMediaUploadedDocument layer 216
    [<Literal>]
    let InputMediaUploadedDocument2 = 0x037C9330u
    /// inputMediaDocument layer 216
    [<Literal>]
    let InputMediaDocument2 = 0xA8763AB5u
    /// messages.getPinnedMessages
    [<Literal>]
    let MessagesGetPinnedMessages = 0xADE8D43Fu
    /// payments.getStarGiftActiveAuctions
    [<Literal>]
    let PaymentsGetStarGiftActiveAuctions = 0xA5D0514Du
    /// payments.starGiftActiveAuctionsNotModified
    [<Literal>]
    let StarGiftActiveAuctionsNotModified = 0xDB33DAD0u
    /// users.userFull old CID
    [<Literal>]
    let UserFullOld = 0xA02BC13Eu
    /// messages.createForumTopic old CID
    [<Literal>]
    let MessagesCreateForumTopic = 0x2F98C3D5u
    /// messages.editForumTopic old CID
    [<Literal>]
    let MessagesEditForumTopic = 0xCECC1134u
    /// messages.getForumTopics old CID
    [<Literal>]
    let MessagesGetForumTopics = 0x3BA47BFFu
    /// messages.getForumTopicsByID old CID
    [<Literal>]
    let MessagesGetForumTopicsByID = 0xAF0A4A08u
    /// messages.updatePinnedForumTopic old CID
    [<Literal>]
    let MessagesUpdatePinnedForumTopic = 0x175DF251u
    /// updates.getDifference old layer CID
    [<Literal>]
    let UpdatesGetDifferenceOld = 0x25939651u
    /// photos.uploadProfilePhoto Telethon layer 216
    [<Literal>]
    let PhotosUploadProfilePhotoOld = 0x0D50F1C1u
    /// messages.deleteTopicHistory old CID
    [<Literal>]
    let MessagesDeleteTopicHistory = 0xD2816F10u

/// Layer-dependent constructor IDs. Resolved at runtime by negotiated layer.
[<RequireQualifiedAccess>]
module GeneratedLayerCid =

    /// Default layer when client hasn't sent invokeWithLayer yet.
    [<Literal>]
    let DefaultLayer = 223

    /// Minimum supported layer.
    [<Literal>]
    let MinSupportedLayer = 190

    [<Literal>]
    let private UserLayer216 = 0x020B1422u
    [<Literal>]
    let private UserDefault = 0x31774388u
    /// Get the User constructor ID for the given layer.
    let user (layer: int) =
        if layer <= 216 then UserLayer216
        else UserDefault

    [<Literal>]
    let private MessageLayer216 = 0x9815CEC8u
    [<Literal>]
    let private MessageDefault = 0x3AE56482u
    /// Get the Message constructor ID for the given layer.
    let message (layer: int) =
        if layer <= 216 then MessageLayer216
        else MessageDefault

    [<Literal>]
    let private ChannelLayer216 = 0xFE685355u
    [<Literal>]
    let private ChannelDefault = 0x1C32B11Cu
    /// Get the Channel constructor ID for the given layer.
    let channel (layer: int) =
        if layer <= 216 then ChannelLayer216
        else ChannelDefault

    [<Literal>]
    let private MessageMediaDocumentLayer216 = 0x52D8CCD9u
    [<Literal>]
    let private MessageMediaDocumentLayer221 = 0x4CF4D72Du
    [<Literal>]
    let private MessageMediaDocumentDefault = 0x52D8CCD9u
    /// Get the MessageMediaDocument constructor ID for the given layer.
    let messageMediaDocument (layer: int) =
        if layer <= 216 then MessageMediaDocumentLayer216
        elif layer <= 221 then MessageMediaDocumentLayer221
        else MessageMediaDocumentDefault

/// Runtime CID → TL method name lookup for logging and dispatch.
[<RequireQualifiedAccess>]
module GeneratedMethodNames =

    /// Lookup table: CID → TL method name.
    let private entries = [|
        0xBE7E8EF1u, "req_pq_multi"
        0xD712E4BEu, "req_DH_params"
        0xF5045F1Fu, "set_client_DH_params"
        0x58E4A740u, "rpc_drop_answer"
        0xB921BD04u, "get_future_salts"
        0x7ABE77ECu, "ping"
        0xF3427B8Cu, "ping_delay_disconnect"
        0xE7512126u, "destroy_session"
        0xD1435160u, "destroy_auth_key"
        0xCB9F372Du, "invokeAfterMsg"
        0x3DC4B4F0u, "invokeAfterMsgs"
        0xC1CD5EA9u, "initConnection"
        0xDA9B0D0Du, "invokeWithLayer"
        0xBF9459B7u, "invokeWithoutUpdates"
        0x365275F2u, "invokeWithMessagesRange"
        0xACA9FD2Eu, "invokeWithTakeout"
        0xDD289F8Eu, "invokeWithBusinessConnection"
        0x1DF92984u, "invokeWithGooglePlayIntegrity"
        0x0DAE54F8u, "invokeWithApnsSecret"
        0xADBB0F94u, "invokeWithReCaptcha"
        0xA677244Fu, "auth.sendCode"
        0xAAC7B717u, "auth.signUp"
        0x8D52A951u, "auth.signIn"
        0x3E72BA19u, "auth.logOut"
        0x9FAB0D1Au, "auth.resetAuthorizations"
        0xE5BFFFCDu, "auth.exportAuthorization"
        0xA57A7DADu, "auth.importAuthorization"
        0xCDD42A05u, "auth.bindTempAuthKey"
        0x67A3FF2Cu, "auth.importBotAuthorization"
        0xD18B4D16u, "auth.checkPassword"
        0xD897BC66u, "auth.requestPasswordRecovery"
        0x37096C70u, "auth.recoverPassword"
        0xCAE47523u, "auth.resendCode"
        0x1F040578u, "auth.cancelCode"
        0x8E48A188u, "auth.dropTempAuthKeys"
        0xB7E085FEu, "auth.exportLoginToken"
        0x95AC5CE4u, "auth.importLoginToken"
        0xE894AD4Du, "auth.acceptLoginToken"
        0x0D36BF79u, "auth.checkRecoveryPassword"
        0x2DB873A9u, "auth.importWebTokenAuthorization"
        0x8E39261Eu, "auth.requestFirebaseSms"
        0x7E960193u, "auth.resetLoginEmail"
        0xCB9DEFF6u, "auth.reportMissingCode"
        0xEC86017Au, "account.registerDevice"
        0x6A0D3206u, "account.unregisterDevice"
        0x84BE5B93u, "account.updateNotifySettings"
        0x12B3AD31u, "account.getNotifySettings"
        0xDB7E1747u, "account.resetNotifySettings"
        0x78515775u, "account.updateProfile"
        0x6628562Cu, "account.updateStatus"
        0x07967D36u, "account.getWallPapers"
        0xC5BA3D86u, "account.reportPeer"
        0x2714D86Cu, "account.checkUsername"
        0x3E0BDD7Cu, "account.updateUsername"
        0xDADBC950u, "account.getPrivacy"
        0xC9F81CE8u, "account.setPrivacy"
        0xA2C0CF74u, "account.deleteAccount"
        0x08FC711Du, "account.getAccountTTL"
        0x2442485Eu, "account.setAccountTTL"
        0x82574AE5u, "account.sendChangePhoneCode"
        0x70C32EDBu, "account.changePhone"
        0x38DF3532u, "account.updateDeviceLocked"
        0xE320C158u, "account.getAuthorizations"
        0xDF77F3BCu, "account.resetAuthorization"
        0x548A30F5u, "account.getPassword"
        0x9CD4EAF9u, "account.getPasswordSettings"
        0xA59B102Fu, "account.updatePasswordSettings"
        0x1B3FAA88u, "account.sendConfirmPhoneCode"
        0x5F2178C3u, "account.confirmPhone"
        0x449E0B51u, "account.getTmpPassword"
        0x182E6D6Fu, "account.getWebAuthorizations"
        0x2D01B9EFu, "account.resetWebAuthorization"
        0x682D2594u, "account.resetWebAuthorizations"
        0xB288BC7Du, "account.getAllSecureValues"
        0x73665BC2u, "account.getSecureValue"
        0x899FE31Du, "account.saveSecureValue"
        0xB880BC4Bu, "account.deleteSecureValue"
        0xA929597Au, "account.getAuthorizationForm"
        0xF3ED4C73u, "account.acceptAuthorization"
        0xA5A356F9u, "account.sendVerifyPhoneCode"
        0x4DD3A7F6u, "account.verifyPhone"
        0x98E037BBu, "account.sendVerifyEmailCode"
        0x032DA4CFu, "account.verifyEmail"
        0x8EF3EAB0u, "account.initTakeoutSession"
        0x1D2652EEu, "account.finishTakeoutSession"
        0x8FDF1920u, "account.confirmPasswordEmail"
        0x7A7F2A15u, "account.resendPasswordEmail"
        0xC1CBD5B6u, "account.cancelPasswordEmail"
        0x9F07C728u, "account.getContactSignUpNotification"
        0xCFF43F61u, "account.setContactSignUpNotification"
        0x53577479u, "account.getNotifyExceptions"
        0xFC8DDBEAu, "account.getWallPaper"
        0xE39A8F03u, "account.uploadWallPaper"
        0x6C5A5B37u, "account.saveWallPaper"
        0xFEED5769u, "account.installWallPaper"
        0xBB3B9804u, "account.resetWallPapers"
        0x56DA0B3Fu, "account.getAutoDownloadSettings"
        0x76F36233u, "account.saveAutoDownloadSettings"
        0x1C3DB333u, "account.uploadTheme"
        0x652E4400u, "account.createTheme"
        0x2BF40CCCu, "account.updateTheme"
        0xF257106Cu, "account.saveTheme"
        0xC727BB3Bu, "account.installTheme"
        0x3A5869ECu, "account.getTheme"
        0x7206E458u, "account.getThemes"
        0xB574B16Bu, "account.setContentSettings"
        0x8B9B4DAEu, "account.getContentSettings"
        0x65AD71DCu, "account.getMultiWallPapers"
        0xEB2B4CF6u, "account.getGlobalPrivacySettings"
        0x1EDAAAC2u, "account.setGlobalPrivacySettings"
        0xFA8CC6F5u, "account.reportProfilePhoto"
        0x9308CE1Bu, "account.resetPassword"
        0x4C9409F6u, "account.declinePasswordReset"
        0xD638DE89u, "account.getChatThemes"
        0xBF899AA0u, "account.setAuthorizationTTL"
        0x40F48462u, "account.changeAuthorizationSettings"
        0xE1902288u, "account.getSavedRingtones"
        0x3DEA5B03u, "account.saveRingtone"
        0x831A83A2u, "account.uploadRingtone"
        0xFBD3DE6Bu, "account.updateEmojiStatus"
        0xD6753386u, "account.getDefaultEmojiStatuses"
        0x0F578105u, "account.getRecentEmojiStatuses"
        0x18201AAEu, "account.clearRecentEmojiStatuses"
        0xEF500EABu, "account.reorderUsernames"
        0x58D6B376u, "account.toggleUsername"
        0xE2750328u, "account.getDefaultProfilePhotoEmojis"
        0x915860AEu, "account.getDefaultGroupPhotoEmojis"
        0xADCBBCDAu, "account.getAutoSaveSettings"
        0xD69B8361u, "account.saveAutoSaveSettings"
        0x53BC0020u, "account.deleteAutoSaveExceptions"
        0xCA8AE8BAu, "account.invalidateSignInCodes"
        0x7CEFA15Du, "account.updateColor"
        0xA60AB9CEu, "account.getDefaultBackgroundEmojis"
        0x7727A7D5u, "account.getChannelDefaultEmojiStatuses"
        0x35A9E0D5u, "account.getChannelRestrictedStatusEmojis"
        0x4B00E066u, "account.updateBusinessWorkHours"
        0x9E6B131Au, "account.updateBusinessLocation"
        0x66CDAFC4u, "account.updateBusinessGreetingMessage"
        0xA26A7FA5u, "account.updateBusinessAwayMessage"
        0x66A08C7Eu, "account.updateConnectedBot"
        0x4EA4C80Fu, "account.getConnectedBots"
        0x76A86270u, "account.getBotBusinessConnection"
        0xA614D034u, "account.updateBusinessIntro"
        0x646E1097u, "account.toggleConnectedBotPaused"
        0x5E437ED9u, "account.disablePeerConnectedBot"
        0xCC6E0C11u, "account.updateBirthday"
        0x8851E68Eu, "account.createBusinessChatLink"
        0x8C3410AFu, "account.editBusinessChatLink"
        0x60073674u, "account.deleteBusinessChatLink"
        0x6F70DDE1u, "account.getBusinessChatLinks"
        0x5492E5EEu, "account.resolveBusinessChatLink"
        0xD94305E0u, "account.updatePersonalChannel"
        0xB9D9A38Du, "account.toggleSponsoredMessages"
        0x06DD654Cu, "account.getReactionsNotifySettings"
        0x316CE548u, "account.setReactionsNotifySettings"
        0x2E7B4543u, "account.getCollectibleEmojiStatuses"
        0x19BA4A67u, "account.getPaidMessagesRevenue"
        0xFE2EDA76u, "account.toggleNoPaidMessagesException"
        0x5DEE78B0u, "account.setMainProfileTab"
        0xB26732A9u, "account.saveMusic"
        0xE09D5FAFu, "account.getSavedMusicIds"
        0xFE74EF9Fu, "account.getUniqueGiftChatThemes"
        0x0D91A548u, "users.getUsers"
        0xB60F5918u, "users.getFullUser"
        0x90C894B5u, "users.setSecureValueErrors"
        0xD89A83A3u, "users.getRequirementsToContact"
        0x788D7FE3u, "users.getSavedMusic"
        0x7573A4E9u, "users.getSavedMusicByID"
        0x7ADC669Du, "contacts.getContactIDs"
        0xC4A353EEu, "contacts.getStatuses"
        0x5DD69E12u, "contacts.getContacts"
        0x2C800BE5u, "contacts.importContacts"
        0x096A0E00u, "contacts.deleteContacts"
        0x1013FD9Eu, "contacts.deleteByPhones"
        0x2E2E8734u, "contacts.block"
        0xB550D328u, "contacts.unblock"
        0x9A868F80u, "contacts.getBlocked"
        0x11F812D8u, "contacts.search"
        0x725AFBBCu, "contacts.resolveUsername"
        0x973478B6u, "contacts.getTopPeers"
        0x1AE373ACu, "contacts.resetTopPeerRating"
        0x879537F1u, "contacts.resetSaved"
        0x82F1E39Fu, "contacts.getSaved"
        0x8514BDDAu, "contacts.toggleTopPeers"
        0xE8F463D0u, "contacts.addContact"
        0xF831A20Fu, "contacts.acceptContact"
        0xD348BC44u, "contacts.getLocated"
        0x29A8962Cu, "contacts.blockFromReplies"
        0x8AF94344u, "contacts.resolvePhone"
        0xF8654027u, "contacts.exportContactToken"
        0x13005788u, "contacts.importContactToken"
        0xBA6705F0u, "contacts.editCloseFriends"
        0x94C65C76u, "contacts.setBlocked"
        0xDAEDA864u, "contacts.getBirthdays"
        0xB6C8C393u, "contacts.getSponsoredPeers"
        0x63C66506u, "messages.getMessages"
        0xA0F4CB4Fu, "messages.getDialogs"
        0x4423E6C5u, "messages.getHistory"
        0x29EE847Au, "messages.search"
        0x0E306D3Au, "messages.readHistory"
        0xB08F922Au, "messages.deleteHistory"
        0xE58E95D2u, "messages.deleteMessages"
        0x05A954C0u, "messages.receivedMessages"
        0x58943EE2u, "messages.setTyping"
        0xFE05DC9Au, "messages.sendMessage"
        0xAC55D9C1u, "messages.sendMedia"
        0x978928CAu, "messages.forwardMessages"
        0xCF1592DBu, "messages.reportSpam"
        0xEFD9A6A2u, "messages.getPeerSettings"
        0xFC78AF9Bu, "messages.report"
        0x49E9528Fu, "messages.getChats"
        0xAEB00B34u, "messages.getFullChat"
        0x73783FFDu, "messages.editChatTitle"
        0x35DDD674u, "messages.editChatPhoto"
        0xCBC6D107u, "messages.addChatUser"
        0xA2185CABu, "messages.deleteChatUser"
        0x92CEDDD4u, "messages.createChat"
        0x26CF8950u, "messages.getDhConfig"
        0xF64DAF43u, "messages.requestEncryption"
        0x3DBC0415u, "messages.acceptEncryption"
        0xF393AEA0u, "messages.discardEncryption"
        0x791451EDu, "messages.setEncryptedTyping"
        0x7F4B690Au, "messages.readEncryptedHistory"
        0x44FA7A15u, "messages.sendEncrypted"
        0x5559481Du, "messages.sendEncryptedFile"
        0x32D439A4u, "messages.sendEncryptedService"
        0x55A5BB66u, "messages.receivedQueue"
        0x4B0C8C0Fu, "messages.reportEncryptedSpam"
        0x36A73F77u, "messages.readMessageContents"
        0xD5A5D3A1u, "messages.getStickers"
        0xB8A0A1A8u, "messages.getAllStickers"
        0x570D6F6Fu, "messages.getWebPagePreview"
        0xA455DE90u, "messages.exportChatInvite"
        0x3EADB1BBu, "messages.checkChatInvite"
        0x6C50051Cu, "messages.importChatInvite"
        0xC8A0EC74u, "messages.getStickerSet"
        0xC78FE460u, "messages.installStickerSet"
        0xF96E55DEu, "messages.uninstallStickerSet"
        0xE6DF7378u, "messages.startBot"
        0x5784D3E1u, "messages.getMessagesViews"
        0xA85BD1C2u, "messages.editChatAdmin"
        0xA2875319u, "messages.migrateChat"
        0x4BC6589Au, "messages.searchGlobal"
        0x78337739u, "messages.reorderStickerSets"
        0xB1F2061Fu, "messages.getDocumentByHash"
        0x5CF09635u, "messages.getSavedGifs"
        0x327A30CBu, "messages.saveGif"
        0x514E999Du, "messages.getInlineBotResults"
        0xBB12A419u, "messages.setInlineBotResults"
        0xC0CF7646u, "messages.sendInlineBotResult"
        0xFDA68D36u, "messages.getMessageEditData"
        0xDFD14005u, "messages.editMessage"
        0x83557DBAu, "messages.editInlineBotMessage"
        0x9342CA07u, "messages.getBotCallbackAnswer"
        0xD58F130Au, "messages.setBotCallbackAnswer"
        0xE470BCFDu, "messages.getPeerDialogs"
        0x54AE308Eu, "messages.saveDraft"
        0x6A3F8D65u, "messages.getAllDrafts"
        0x64780B14u, "messages.getFeaturedStickers"
        0x5B118126u, "messages.readFeaturedStickers"
        0x9DA9403Bu, "messages.getRecentStickers"
        0x392718F8u, "messages.saveRecentSticker"
        0x8999602Du, "messages.clearRecentStickers"
        0x57F17692u, "messages.getArchivedStickers"
        0x640F82B8u, "messages.getMaskStickers"
        0xCC5B67CCu, "messages.getAttachedStickers"
        0x8EF8ECC0u, "messages.setGameScore"
        0x15AD9F64u, "messages.setInlineGameScore"
        0xE822649Du, "messages.getGameHighScores"
        0x0F635E1Bu, "messages.getInlineGameHighScores"
        0xE40CA104u, "messages.getCommonChats"
        0x8D9692A3u, "messages.getWebPage"
        0xA731E257u, "messages.toggleDialogPin"
        0x3B1ADF37u, "messages.reorderPinnedDialogs"
        0xD6B94DF2u, "messages.getPinnedDialogs"
        0xE5F672FAu, "messages.setBotShippingResults"
        0x09C2DD95u, "messages.setBotPrecheckoutResults"
        0x14967978u, "messages.uploadMedia"
        0xA1405817u, "messages.sendScreenshotNotification"
        0x04F1AAA9u, "messages.getFavedStickers"
        0xB9FFC55Bu, "messages.faveSticker"
        0xF107E790u, "messages.getUnreadMentions"
        0x36E5BF4Du, "messages.readMentions"
        0x702A40E0u, "messages.getRecentLocations"
        0x1BF89D74u, "messages.sendMultiMedia"
        0x5057C497u, "messages.uploadEncryptedFile"
        0x35705B8Au, "messages.searchStickerSets"
        0x1CFF7E08u, "messages.getSplitRanges"
        0x8C5006F8u, "messages.markDialogUnread"
        0x21202222u, "messages.getDialogUnreadMarks"
        0x7E58EE9Cu, "messages.clearAllDrafts"
        0xD2AAF7ECu, "messages.updatePinnedMessage"
        0x10EA6184u, "messages.sendVote"
        0x73BB643Bu, "messages.getPollResults"
        0x6E2BE050u, "messages.getOnlines"
        0xDEF60797u, "messages.editChatAbout"
        0xA5866B41u, "messages.editChatDefaultBannedRights"
        0x35A0E062u, "messages.getEmojiKeywords"
        0x1508B6AFu, "messages.getEmojiKeywordsDifference"
        0x4E9963B2u, "messages.getEmojiKeywordsLanguages"
        0xD5B10C26u, "messages.getEmojiURL"
        0x1BBCF300u, "messages.getSearchCounters"
        0x198FB446u, "messages.requestUrlAuth"
        0xB12C7125u, "messages.acceptUrlAuth"
        0x4FACB138u, "messages.hidePeerSettingsBar"
        0xF516760Bu, "messages.getScheduledHistory"
        0xBDBB0464u, "messages.getScheduledMessages"
        0xBD38850Au, "messages.sendScheduledMessages"
        0x59AE2B16u, "messages.deleteScheduledMessages"
        0xB86E380Eu, "messages.getPollVotes"
        0xB5052FEAu, "messages.toggleStickerSets"
        0xEFD48C89u, "messages.getDialogFilters"
        0xA29CD42Cu, "messages.getSuggestedDialogFilters"
        0x1AD4A04Au, "messages.updateDialogFilter"
        0xC563C1E4u, "messages.updateDialogFiltersOrder"
        0x7ED094A1u, "messages.getOldFeaturedStickers"
        0x22DDD30Cu, "messages.getReplies"
        0x446972FDu, "messages.getDiscussionMessage"
        0xF731A9F4u, "messages.readDiscussion"
        0x062DD747u, "messages.unpinAllMessages"
        0x5BD0EE50u, "messages.deleteChat"
        0xF9CBE409u, "messages.deletePhoneCallHistory"
        0x43FE19F3u, "messages.checkHistoryImport"
        0x34090C3Bu, "messages.initHistoryImport"
        0x2A862092u, "messages.uploadImportedMedia"
        0xB43DF344u, "messages.startHistoryImport"
        0xA2B5A3F6u, "messages.getExportedChatInvites"
        0x73746F5Cu, "messages.getExportedChatInvite"
        0xBDCA2F75u, "messages.editExportedChatInvite"
        0x56987BD5u, "messages.deleteRevokedExportedChatInvites"
        0xD464A42Bu, "messages.deleteExportedChatInvite"
        0x3920E6EFu, "messages.getAdminsWithInvites"
        0xDF04DD4Eu, "messages.getChatInviteImporters"
        0xB80E5FE4u, "messages.setHistoryTTL"
        0x5DC60F03u, "messages.checkHistoryImportPeer"
        0x081202C9u, "messages.setChatTheme"
        0x31C1C44Fu, "messages.getMessageReadParticipants"
        0x6AA3F6BDu, "messages.getSearchResultsCalendar"
        0x9C7F2F10u, "messages.getSearchResultsPositions"
        0x7FE7E815u, "messages.hideChatJoinRequest"
        0xE085F4EAu, "messages.hideAllChatJoinRequests"
        0xB11EAFA2u, "messages.toggleNoForwards"
        0xCCFDDF96u, "messages.saveDefaultSendAs"
        0xD30D78D4u, "messages.sendReaction"
        0x8BBA90E6u, "messages.getMessagesReactions"
        0x461B3F48u, "messages.getMessageReactionsList"
        0x864B2581u, "messages.setChatAvailableReactions"
        0x18DEA0ACu, "messages.getAvailableReactions"
        0x4F47A016u, "messages.setDefaultReaction"
        0x63183030u, "messages.translateText"
        0xBD7F90ACu, "messages.getUnreadReactions"
        0x9EC44F93u, "messages.readReactions"
        0x107E31A0u, "messages.searchSentMedia"
        0x16FCC2CBu, "messages.getAttachMenuBots"
        0x77216192u, "messages.getAttachMenuBot"
        0x69F59D69u, "messages.toggleBotInAttachMenu"
        0x269DC2C1u, "messages.requestWebView"
        0xB0D81A83u, "messages.prolongWebView"
        0x413A3E73u, "messages.requestSimpleWebView"
        0x0A4314F5u, "messages.sendWebViewResultMessage"
        0xDC0242C8u, "messages.sendWebViewData"
        0x269E9A49u, "messages.transcribeAudio"
        0x7F1D072Fu, "messages.rateTranscribedAudio"
        0xD9AB0F54u, "messages.getCustomEmojiDocuments"
        0xFBFCA18Fu, "messages.getEmojiStickers"
        0x0ECF6736u, "messages.getFeaturedEmojiStickers"
        0x3F64C076u, "messages.reportReaction"
        0xBB8125BAu, "messages.getTopReactions"
        0x39461DB2u, "messages.getRecentReactions"
        0x9DFEEFB4u, "messages.clearRecentReactions"
        0x84F80814u, "messages.getExtendedMedia"
        0x9EB51445u, "messages.setDefaultHistoryTTL"
        0x658B7188u, "messages.getDefaultHistoryTTL"
        0x91B2D060u, "messages.sendBotRequestedPeer"
        0x7488CE5Bu, "messages.getEmojiGroups"
        0x2ECD56CDu, "messages.getEmojiStatusGroups"
        0x21A548F3u, "messages.getEmojiProfilePhotoGroups"
        0x2C11C0D7u, "messages.searchCustomEmoji"
        0xE47CB579u, "messages.togglePeerTranslations"
        0x34FDC5C3u, "messages.getBotApp"
        0x53618BCEu, "messages.requestAppWebView"
        0x8FFACAE1u, "messages.setChatWallPaper"
        0x92B4494Cu, "messages.searchEmojiStickerSets"
        0x1E91FC99u, "messages.getSavedDialogs"
        0x998AB009u, "messages.getSavedHistory"
        0x4DC5085Fu, "messages.deleteSavedHistory"
        0xD63D94E0u, "messages.getPinnedSavedDialogs"
        0xAC81BBDEu, "messages.toggleSavedDialogPin"
        0x8B716587u, "messages.reorderPinnedSavedDialogs"
        0x3637E05Bu, "messages.getSavedReactionTags"
        0x60297DECu, "messages.updateSavedReactionTag"
        0xBDF93428u, "messages.getDefaultTagReactions"
        0x8C4BFE5Du, "messages.getOutboxReadDate"
        0xD483F2A8u, "messages.getQuickReplies"
        0x60331907u, "messages.reorderQuickReplies"
        0xF1D0FBD3u, "messages.checkQuickReplyShortcut"
        0x5C003CEFu, "messages.editQuickReplyShortcut"
        0x3CC04740u, "messages.deleteQuickReplyShortcut"
        0x94A495C3u, "messages.getQuickReplyMessages"
        0x6C750DE1u, "messages.sendQuickReplyMessages"
        0xE105E910u, "messages.deleteQuickReplyMessages"
        0xFD2DDA49u, "messages.toggleDialogFilterTags"
        0xD0B5E1FCu, "messages.getMyStickers"
        0x1DD840F5u, "messages.getEmojiStickerGroups"
        0xDEA20A39u, "messages.getAvailableEffects"
        0x0589EE75u, "messages.editFactCheck"
        0xD1DA940Cu, "messages.deleteFactCheck"
        0xB9CDC5EEu, "messages.getFactCheck"
        0xC9E01E7Bu, "messages.requestMainWebView"
        0x58BBCB50u, "messages.sendPaidReaction"
        0x435885B5u, "messages.togglePaidReactionPrivacy"
        0x472455AAu, "messages.getPaidReactionPrivacy"
        0x269E3643u, "messages.viewSponsoredMessage"
        0x8235057Eu, "messages.clickSponsoredMessage"
        0x12CBF0C4u, "messages.reportSponsoredMessage"
        0x3D6CE850u, "messages.getSponsoredMessages"
        0xF21F7F2Fu, "messages.savePreparedInlineMessage"
        0x857EBDB8u, "messages.getPreparedInlineMessage"
        0x29B1C66Au, "messages.searchStickers"
        0x5A6D7395u, "messages.reportMessagesDelivery"
        0x6F6F9C96u, "messages.getSavedDialogsByID"
        0xBA4A3B5Bu, "messages.readSavedHistory"
        0xD3E03124u, "messages.toggleTodoCompleted"
        0x21A61057u, "messages.appendTodoList"
        0x8107455Cu, "messages.toggleSuggestedPostApproval"
        0xEDD4882Au, "updates.getState"
        0x19C2F763u, "updates.getDifference"
        0x03173D78u, "updates.getChannelDifference"
        0x09E82039u, "photos.updateProfilePhoto"
        0x0388A3B5u, "photos.uploadProfilePhoto"
        0x87CF7F2Fu, "photos.deletePhotos"
        0x91CD32A8u, "photos.getUserPhotos"
        0xE14C4A71u, "photos.uploadContactProfilePhoto"
        0xB304A621u, "upload.saveFilePart"
        0xBE5335BEu, "upload.getFile"
        0xDE7B673Du, "upload.saveBigFilePart"
        0x24E6818Du, "upload.getWebFile"
        0x395F69DAu, "upload.getCdnFile"
        0x9B2754A8u, "upload.reuploadCdnFile"
        0x91DC3F31u, "upload.getCdnFileHashes"
        0x9156982Au, "upload.getFileHashes"
        0xC4F9186Bu, "help.getConfig"
        0x1FB33026u, "help.getNearestDc"
        0x522D5A7Du, "help.getAppUpdate"
        0x4D392343u, "help.getInviteText"
        0x9CDF08CDu, "help.getSupport"
        0xEC22CFCDu, "help.setBotUpdatesStatus"
        0x52029342u, "help.getCdnConfig"
        0x3DC0F114u, "help.getRecentMeUrls"
        0x2CA51FD1u, "help.getTermsOfServiceUpdate"
        0xEE72F79Au, "help.acceptTermsOfService"
        0x3FEDC75Fu, "help.getDeepLinkInfo"
        0x61E3F854u, "help.getAppConfig"
        0x6F02F748u, "help.saveAppLog"
        0xC661AD08u, "help.getPassportConfig"
        0xD360E72Cu, "help.getSupportName"
        0x038A08D3u, "help.getUserInfo"
        0x66B91B70u, "help.editUserInfo"
        0xC0977421u, "help.getPromoData"
        0x1E251C95u, "help.hidePromoData"
        0xF50DBAA1u, "help.dismissSuggestion"
        0x735787A8u, "help.getCountriesList"
        0xB81B93D4u, "help.getPremiumPromo"
        0xDA80F42Fu, "help.getPeerColors"
        0xABCFA9FDu, "help.getPeerProfileColors"
        0x49B30240u, "help.getTimezonesList"
        0xCC104937u, "channels.readHistory"
        0x84C1FD4Eu, "channels.deleteMessages"
        0xF44A8315u, "channels.reportSpam"
        0xAD8C9A23u, "channels.getMessages"
        0x77CED9D0u, "channels.getParticipants"
        0xA0AB6CC6u, "channels.getParticipant"
        0x0A7F6BBBu, "channels.getChannels"
        0x08736A09u, "channels.getFullChannel"
        0x91006707u, "channels.createChannel"
        0xD33C8902u, "channels.editAdmin"
        0x566DECD0u, "channels.editTitle"
        0xF12E57C9u, "channels.editPhoto"
        0x10E6BD2Cu, "channels.checkUsername"
        0x3514B3DEu, "channels.updateUsername"
        0x24B524C5u, "channels.joinChannel"
        0xF836AA95u, "channels.leaveChannel"
        0xC9E33D54u, "channels.inviteToChannel"
        0xC0111FE3u, "channels.deleteChannel"
        0xE63FADEBu, "channels.exportMessageLink"
        0x418D549Cu, "channels.toggleSignatures"
        0xF8B036AFu, "channels.getAdminedPublicChannels"
        0x96E6CD81u, "channels.editBanned"
        0x33DDF480u, "channels.getAdminLog"
        0xEA8CA4F9u, "channels.setStickers"
        0xEAB5DC38u, "channels.readMessageContents"
        0x9BAA9647u, "channels.deleteHistory"
        0xEABBB94Cu, "channels.togglePreHistoryHidden"
        0x8341ECC0u, "channels.getLeftChannels"
        0xF5DAD378u, "channels.getGroupsForDiscussion"
        0x40582BB2u, "channels.setDiscussionGroup"
        0x8F38CD1Fu, "channels.editCreator"
        0x58E63F6Du, "channels.editLocation"
        0xEDD49EF0u, "channels.toggleSlowMode"
        0x11E831EEu, "channels.getInactiveChannels"
        0x0B290C69u, "channels.convertToGigagroup"
        0xE785A43Fu, "channels.getSendAs"
        0x367544DBu, "channels.deleteParticipantHistory"
        0xE4CB9580u, "channels.toggleJoinToSend"
        0x4C2985B6u, "channels.toggleJoinRequest"
        0xB45CED1Du, "channels.reorderUsernames"
        0x50F24105u, "channels.toggleUsername"
        0x0A245DD3u, "channels.deactivateAllUsernames"
        0x3FF75734u, "channels.toggleForum"
        0xF40C0224u, "channels.createForumTopic"
        0x0DE560D1u, "channels.getForumTopics"
        0xB0831EB9u, "channels.getForumTopicsByID"
        0xF4DFA185u, "channels.editForumTopic"
        0x6C2D9026u, "channels.updatePinnedForumTopic"
        0x34435F2Du, "channels.deleteTopicHistory"
        0x2950A18Fu, "channels.reorderPinnedForumTopics"
        0x68F3E4EBu, "channels.toggleAntiSpam"
        0xA850A693u, "channels.reportAntiSpamFalsePositive"
        0x6A6E7854u, "channels.toggleParticipantsHidden"
        0xD8AA3671u, "channels.updateColor"
        0x9738BB15u, "channels.toggleViewForumAsMessages"
        0x25A71742u, "channels.getChannelRecommendations"
        0xF0D3E6A8u, "channels.updateEmojiStatus"
        0xAD399CEEu, "channels.setBoostsToUnblockRestrictions"
        0x3CD930B7u, "channels.setEmojiStickers"
        0x9AE91519u, "channels.restrictSponsoredMessages"
        0xF2C4F24Du, "channels.searchPosts"
        0x4B12327Bu, "channels.updatePaidMessagesPrice"
        0x167FC0A1u, "channels.toggleAutotranslation"
        0xECE2A0E6u, "channels.getMessageAuthor"
        0x22567115u, "channels.checkSearchPostsFlood"
        0x3583FCB1u, "channels.setMainProfileTab"
        0xAA2769EDu, "bots.sendCustomRequest"
        0xE6213F4Du, "bots.answerWebhookJSONQuery"
        0x0517165Au, "bots.setBotCommands"
        0x3D8DE0F9u, "bots.resetBotCommands"
        0xE34C0DD6u, "bots.getBotCommands"
        0x4504D54Fu, "bots.setBotMenuButton"
        0x9C60EB28u, "bots.getBotMenuButton"
        0x788464E1u, "bots.setBotBroadcastDefaultAdminRights"
        0x925EC9EAu, "bots.setBotGroupDefaultAdminRights"
        0x10CF3123u, "bots.setBotInfo"
        0xDCD914FDu, "bots.getBotInfo"
        0x9709B1C2u, "bots.reorderUsernames"
        0x053CA973u, "bots.toggleUsername"
        0x1359F4E6u, "bots.canSendMessage"
        0xF132E3EFu, "bots.allowSendMessage"
        0x087FC5E7u, "bots.invokeWebViewCustomMethod"
        0xC2510192u, "bots.getPopularAppBots"
        0x17AEB75Au, "bots.addPreviewMedia"
        0x8525606Fu, "bots.editPreviewMedia"
        0x2D0135B3u, "bots.deletePreviewMedia"
        0xB627F3AAu, "bots.reorderPreviewMedias"
        0x423AB3ADu, "bots.getPreviewInfo"
        0xA2A5594Du, "bots.getPreviewMedias"
        0xED9F30C5u, "bots.updateUserEmojiStatus"
        0x06DE6392u, "bots.toggleUserEmojiStatusPermission"
        0x50077589u, "bots.checkDownloadFileParams"
        0xB0711D83u, "bots.getAdminedBots"
        0x778B5AB3u, "bots.updateStarRefProgram"
        0x8B89DFBDu, "bots.setCustomVerification"
        0xA1B70815u, "bots.getBotRecommendations"
        0x37148DBBu, "payments.getPaymentForm"
        0x2478D1CCu, "payments.getPaymentReceipt"
        0xB6C8F12Bu, "payments.validateRequestedInfo"
        0x2D03522Fu, "payments.sendPaymentForm"
        0x227D824Bu, "payments.getSavedInfo"
        0xD83D70C1u, "payments.clearSavedInfo"
        0x2E79D779u, "payments.getBankCardData"
        0x0F91B065u, "payments.exportInvoice"
        0x80ED747Du, "payments.assignAppStoreTransaction"
        0xDFFD50D3u, "payments.assignPlayMarketTransaction"
        0x2757BA54u, "payments.getPremiumGiftCodeOptions"
        0x8E51B4C1u, "payments.checkGiftCode"
        0xF6E26854u, "payments.applyGiftCode"
        0xF4239425u, "payments.getGiveawayInfo"
        0x5FF58F20u, "payments.launchPrepaidGiveaway"
        0xC00EC7D3u, "payments.getStarsTopupOptions"
        0x4EA9B3BFu, "payments.getStarsStatus"
        0x69DA4557u, "payments.getStarsTransactions"
        0x7998C914u, "payments.sendStarsForm"
        0x25AE8F4Au, "payments.refundStarsCharge"
        0xD91FFAD6u, "payments.getStarsRevenueStats"
        0x2433DC92u, "payments.getStarsRevenueWithdrawalUrl"
        0xD1D7EFC5u, "payments.getStarsRevenueAdsAccountUrl"
        0x2DCA16B8u, "payments.getStarsTransactionsByID"
        0xD3C96BC8u, "payments.getStarsGiftOptions"
        0x032512C5u, "payments.getStarsSubscriptions"
        0xC7770878u, "payments.changeStarsSubscription"
        0xCC5BEBB3u, "payments.fulfillStarsSubscription"
        0xBD1EFD3Eu, "payments.getStarsGiveawayOptions"
        0xC4563590u, "payments.getStarGifts"
        0x2A2A697Cu, "payments.saveStarGift"
        0x74BF076Bu, "payments.convertStarGift"
        0x6DFA0622u, "payments.botCancelStarsSubscription"
        0x5869A553u, "payments.getConnectedStarRefBots"
        0xB7D998F0u, "payments.getConnectedStarRefBot"
        0x0D6B48F7u, "payments.getSuggestedStarRefBots"
        0x7ED5348Au, "payments.connectStarRefBot"
        0xE4FCA4A3u, "payments.editConnectedStarRefBot"
        0x9C9ABCB1u, "payments.getStarGiftUpgradePreview"
        0xAED6E4F5u, "payments.upgradeStarGift"
        0x7F18176Au, "payments.transferStarGift"
        0xA1974D72u, "payments.getUniqueStarGift"
        0xA319E569u, "payments.getSavedStarGifts"
        0xB455A106u, "payments.getSavedStarGift"
        0xD06E93A8u, "payments.getStarGiftWithdrawalUrl"
        0x60EAEFA1u, "payments.toggleChatStarGiftNotifications"
        0x1513E7B0u, "payments.toggleStarGiftsPinnedToTop"
        0x4FDC5EA7u, "payments.canPurchaseStore"
        0x7A5FA236u, "payments.getResaleStarGifts"
        0xEDBE6CCBu, "payments.updateStarGiftPrice"
        0x1F4A0E87u, "payments.createStarGiftCollection"
        0x4FDDBEE7u, "payments.updateStarGiftCollection"
        0xC32AF4CCu, "payments.reorderStarGiftCollections"
        0xAD5648E8u, "payments.deleteStarGiftCollection"
        0x981B91DDu, "payments.getStarGiftCollections"
        0x4365AF6Bu, "payments.getUniqueStarGiftValueInfo"
        0xC0C4EDC9u, "payments.checkCanSendGift"
        0x9021AB67u, "stickers.createStickerSet"
        0xF7760F51u, "stickers.removeStickerFromSet"
        0xFFB6D4CAu, "stickers.changeStickerPosition"
        0x8653FEBEu, "stickers.addStickerToSet"
        0xA76A5392u, "stickers.setStickerSetThumb"
        0x284B3639u, "stickers.checkShortName"
        0x4DAFC503u, "stickers.suggestShortName"
        0xF5537EBCu, "stickers.changeSticker"
        0x124B1C00u, "stickers.renameStickerSet"
        0x87704394u, "stickers.deleteStickerSet"
        0x4696459Au, "stickers.replaceSticker"
        0x55451FA9u, "phone.getCallConfig"
        0x42FF96EDu, "phone.requestCall"
        0x3BD2B4A0u, "phone.acceptCall"
        0x2EFE1722u, "phone.confirmCall"
        0x17D54F61u, "phone.receivedCall"
        0xB2CBC1C0u, "phone.discardCall"
        0x59EAD627u, "phone.setCallRating"
        0x277ADD7Eu, "phone.saveCallDebug"
        0xFF7A9383u, "phone.sendSignalingData"
        0x48CDC6D8u, "phone.createGroupCall"
        0x8FB53057u, "phone.joinGroupCall"
        0x500377F9u, "phone.leaveGroupCall"
        0x7B393160u, "phone.inviteToGroupCall"
        0x7A777135u, "phone.discardGroupCall"
        0x74BBB43Du, "phone.toggleGroupCallSettings"
        0x041845DBu, "phone.getGroupCall"
        0xC558D8ABu, "phone.getGroupParticipants"
        0xB59CF977u, "phone.checkGroupCall"
        0xF128C708u, "phone.toggleGroupCallRecord"
        0xA5273ABFu, "phone.editGroupCallParticipant"
        0x1CA6AC0Au, "phone.editGroupCallTitle"
        0xEF7C213Au, "phone.getGroupCallJoinAs"
        0xE6AA647Fu, "phone.exportGroupCallInvite"
        0x219C34E6u, "phone.toggleGroupCallStartSubscription"
        0x5680E342u, "phone.startScheduledGroupCall"
        0x575E1F8Cu, "phone.saveDefaultGroupCallJoinAs"
        0xCBEA6BC4u, "phone.joinGroupCallPresentation"
        0x1C50D144u, "phone.leaveGroupCallPresentation"
        0x1AB21940u, "phone.getGroupCallStreamChannels"
        0xDEB3ABBFu, "phone.getGroupCallStreamRtmpUrl"
        0x41248786u, "phone.saveCallLog"
        0x7D0444BBu, "phone.createConferenceCall"
        0x8CA60525u, "phone.deleteConferenceCallParticipants"
        0xC6701900u, "phone.sendConferenceCallBroadcast"
        0xBCF22685u, "phone.inviteConferenceCallParticipant"
        0x3C479971u, "phone.declineConferenceCallInvite"
        0xEE9F88A6u, "phone.getGroupCallChainBlocks"
        0xF2F2330Au, "langpack.getLangPack"
        0xEFEA3803u, "langpack.getStrings"
        0xCD984AA5u, "langpack.getDifference"
        0x42C6978Fu, "langpack.getLanguages"
        0x6A596502u, "langpack.getLanguage"
        0x6847D0ABu, "folders.editPeerFolders"
        0xAB42441Au, "stats.getBroadcastStats"
        0x621D5FA0u, "stats.loadAsyncGraph"
        0xDCDF8607u, "stats.getMegagroupStats"
        0x5F150144u, "stats.getMessagePublicForwards"
        0xB6E0A3F5u, "stats.getMessageStats"
        0x374FEF40u, "stats.getStoryStats"
        0xA6437EF6u, "stats.getStoryPublicForwards"
        0x8472478Eu, "chatlists.exportChatlistInvite"
        0x719C5C5Eu, "chatlists.deleteExportedInvite"
        0x653DB63Du, "chatlists.editExportedInvite"
        0xCE03DA83u, "chatlists.getExportedInvites"
        0x41C10FFFu, "chatlists.checkChatlistInvite"
        0xA6B1E39Au, "chatlists.joinChatlistInvite"
        0x89419521u, "chatlists.getChatlistUpdates"
        0xE089F8F5u, "chatlists.joinChatlistUpdates"
        0x66E486FBu, "chatlists.hideChatlistUpdates"
        0xFDBCD714u, "chatlists.getLeaveChatlistSuggestions"
        0x74FAE13Au, "chatlists.leaveChatlist"
        0x30EB63F0u, "stories.canSendStory"
        0x737FC2ECu, "stories.sendStory"
        0xB583BA46u, "stories.editStory"
        0xAE59DB5Fu, "stories.deleteStories"
        0x9A75A1EFu, "stories.togglePinned"
        0xEEB0D625u, "stories.getAllStories"
        0x5821A5DCu, "stories.getPinnedStories"
        0xB4352016u, "stories.getStoriesArchive"
        0x5774CA74u, "stories.getStoriesByID"
        0x7C2557C4u, "stories.toggleAllStoriesHidden"
        0xA556DAC8u, "stories.readStories"
        0xB2028AFBu, "stories.incrementStoryViews"
        0x7ED23C57u, "stories.getStoryViewsList"
        0x28E16CC8u, "stories.getStoriesViews"
        0x7B8DEF20u, "stories.exportStoryLink"
        0x19D8EB45u, "stories.report"
        0x57BBD166u, "stories.activateStealthMode"
        0x7FD736B2u, "stories.sendReaction"
        0x2C4ADA50u, "stories.getPeerStories"
        0x9B5AE7F9u, "stories.getAllReadPeerStories"
        0x535983C3u, "stories.getPeerMaxIDs"
        0xA56A8B60u, "stories.getChatsToSend"
        0xBD0415C4u, "stories.togglePeerStoriesHidden"
        0xB9B2881Fu, "stories.getStoryReactionsList"
        0x0B297E9Bu, "stories.togglePinnedToTop"
        0xD1810907u, "stories.searchPosts"
        0xA36396E5u, "stories.createAlbum"
        0x5E5259B6u, "stories.updateAlbum"
        0x8535FBD9u, "stories.reorderAlbums"
        0x8D3456D0u, "stories.deleteAlbum"
        0x25B3EAC7u, "stories.getAlbums"
        0xAC806D61u, "stories.getAlbumStories"
        0x60F67660u, "premium.getBoostsList"
        0x0BE77B4Au, "premium.getMyBoosts"
        0x6B7DA746u, "premium.applyBoost"
        0x042F1F61u, "premium.getBoostsStatus"
        0x39854D1Fu, "premium.getUserBoosts"
        0x0EDC39D0u, "smsjobs.isEligibleToJoin"
        0xA74ECE2Du, "smsjobs.join"
        0x9898AD73u, "smsjobs.leave"
        0x093FA0BFu, "smsjobs.updateSettings"
        0x10A698E8u, "smsjobs.getStatus"
        0x778D902Fu, "smsjobs.getSmsJob"
        0x4F1EBF24u, "smsjobs.finishJob"
        0xBE1E85BAu, "fragment.getCollectibleInfo"
        0x983689B3u, "MessagesSendMessage"
        0x280D096Fu, "MessagesSendMessage"
        0xFE05DC9Au, "MessagesSendMessage"
        0x51E842E1u, "messages.editMessage"
        0xD9BA2E54u, "contacts.addContact"
        0xDDE8A54Cu, "InputPeerUser"
        0x22C0F6D5u, "InputReplyToMessage"
        0x869FBE10u, "InputReplyToMessage"
        0xE44DF73Cu, "MessagesSendMedia"
        0xA1B9B13Fu, "updates.getDifference"
    |]

    let private lookup = System.Collections.Generic.Dictionary<uint32, string>(entries.Length)
    do for cid, name in entries do lookup.[cid] <- name

    /// Get TL method name for a CID, or None if unknown.
    let tryGet (cid: uint32) : string option =
        match lookup.TryGetValue(cid) with
        | true, name -> Some name
        | false, _ -> None

    /// Get TL method name, or hex fallback.
    let getOrHex (cid: uint32) : string =
        match lookup.TryGetValue(cid) with
        | true, name -> name
        | false, _ -> $"0x%08X{cid}"

