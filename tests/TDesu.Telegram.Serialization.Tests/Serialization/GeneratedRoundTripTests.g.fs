// Auto-generated round-trip tests. Do not edit manually.
// Re-generate with: dotnet run --project src/MTProto.TL.Generator -- --tests

module TDesu.MTProto.Tests.GeneratedRoundTripTests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Requests

[<TestFixture>]
type RoundTripTests() =

    [<Test>]
    member _.``AuthSendCode round-trip``() =
        let v : AuthSendCode = { phoneNumber = ""; apiId = 0; apiHash = ""; settings = { CodeSettings.allowFlashcall = false; currentNumber = false; allowAppHash = false; allowMissedCall = false; allowFirebase = false; unknownNumber = false; logoutTokens = None; token = None; appSandbox = None } }
        use w1 = new TlWriteBuffer()
        AuthSendCode.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthSendCode.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthSendCode.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthSendCode round-trip mismatch")

    [<Test>]
    member _.``AuthSignUp round-trip``() =
        let v : AuthSignUp = { noJoinedNotifications = false; phoneNumber = ""; phoneCodeHash = ""; firstName = ""; lastName = "" }
        use w1 = new TlWriteBuffer()
        AuthSignUp.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthSignUp.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthSignUp.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthSignUp round-trip mismatch")

    [<Test>]
    member _.``AuthSignIn round-trip``() =
        let v : AuthSignIn = { phoneNumber = ""; phoneCodeHash = ""; phoneCode = None; emailVerification = None }
        use w1 = new TlWriteBuffer()
        AuthSignIn.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthSignIn.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthSignIn.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthSignIn round-trip mismatch")

    [<Test>]
    member _.``AuthExportAuthorization round-trip``() =
        let v : AuthExportAuthorization = { dcId = 0 }
        use w1 = new TlWriteBuffer()
        AuthExportAuthorization.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthExportAuthorization.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthExportAuthorization.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthExportAuthorization round-trip mismatch")

    [<Test>]
    member _.``AuthImportAuthorization round-trip``() =
        let v : AuthImportAuthorization = { id = 0L; bytes = Array.empty }
        use w1 = new TlWriteBuffer()
        AuthImportAuthorization.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthImportAuthorization.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthImportAuthorization.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthImportAuthorization round-trip mismatch")

    [<Test>]
    member _.``AuthBindTempAuthKey round-trip``() =
        let v : AuthBindTempAuthKey = { permAuthKeyId = 0L; nonce = 0L; expiresAt = 0; encryptedMessage = Array.empty }
        use w1 = new TlWriteBuffer()
        AuthBindTempAuthKey.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthBindTempAuthKey.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthBindTempAuthKey.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthBindTempAuthKey round-trip mismatch")

    [<Test>]
    member _.``AuthImportBotAuthorization round-trip``() =
        let v : AuthImportBotAuthorization = { flags = 0; apiId = 0; apiHash = ""; botAuthToken = "" }
        use w1 = new TlWriteBuffer()
        AuthImportBotAuthorization.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthImportBotAuthorization.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthImportBotAuthorization.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthImportBotAuthorization round-trip mismatch")

    [<Test>]
    member _.``AuthCheckPassword round-trip``() =
        let v : AuthCheckPassword = { password = InputCheckPasswordSRP.InputCheckPasswordEmpty }
        use w1 = new TlWriteBuffer()
        AuthCheckPassword.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthCheckPassword.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthCheckPassword.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthCheckPassword round-trip mismatch")

    [<Test>]
    member _.``AuthResendCode round-trip``() =
        let v : AuthResendCode = { phoneNumber = ""; phoneCodeHash = ""; reason = None }
        use w1 = new TlWriteBuffer()
        AuthResendCode.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthResendCode.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthResendCode.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthResendCode round-trip mismatch")

    [<Test>]
    member _.``AuthCancelCode round-trip``() =
        let v : AuthCancelCode = { phoneNumber = ""; phoneCodeHash = "" }
        use w1 = new TlWriteBuffer()
        AuthCancelCode.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthCancelCode.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthCancelCode.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthCancelCode round-trip mismatch")

    [<Test>]
    member _.``AuthExportLoginToken round-trip``() =
        let v : AuthExportLoginToken = { apiId = 0; apiHash = ""; exceptIds = [||] }
        use w1 = new TlWriteBuffer()
        AuthExportLoginToken.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AuthExportLoginToken.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AuthExportLoginToken.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AuthExportLoginToken round-trip mismatch")

    [<Test>]
    member _.``AccountUpdateNotifySettings round-trip``() =
        let v : AccountUpdateNotifySettings = { peer = InputNotifyPeer.InputNotifyUsers; settings = { InputPeerNotifySettings.showPreviews = None; silent = None; muteUntil = None; sound = None; storiesMuted = None; storiesHideSender = None; storiesSound = None } }
        use w1 = new TlWriteBuffer()
        AccountUpdateNotifySettings.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountUpdateNotifySettings.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountUpdateNotifySettings.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountUpdateNotifySettings round-trip mismatch")

    [<Test>]
    member _.``AccountGetNotifySettings round-trip``() =
        let v : AccountGetNotifySettings = { peer = InputNotifyPeer.InputNotifyUsers }
        use w1 = new TlWriteBuffer()
        AccountGetNotifySettings.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountGetNotifySettings.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountGetNotifySettings.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountGetNotifySettings round-trip mismatch")

    [<Test>]
    member _.``AccountUpdateProfile round-trip``() =
        let v : AccountUpdateProfile = { firstName = None; lastName = None; about = None }
        use w1 = new TlWriteBuffer()
        AccountUpdateProfile.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountUpdateProfile.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountUpdateProfile.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountUpdateProfile round-trip mismatch")

    [<Test>]
    member _.``AccountUpdateStatus round-trip``() =
        let v : AccountUpdateStatus = { offline = false }
        use w1 = new TlWriteBuffer()
        AccountUpdateStatus.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountUpdateStatus.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountUpdateStatus.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountUpdateStatus round-trip mismatch")

    [<Test>]
    member _.``AccountCheckUsername round-trip``() =
        let v : AccountCheckUsername = { username = "" }
        use w1 = new TlWriteBuffer()
        AccountCheckUsername.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountCheckUsername.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountCheckUsername.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountCheckUsername round-trip mismatch")

    [<Test>]
    member _.``AccountUpdateUsername round-trip``() =
        let v : AccountUpdateUsername = { username = "" }
        use w1 = new TlWriteBuffer()
        AccountUpdateUsername.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountUpdateUsername.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountUpdateUsername.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountUpdateUsername round-trip mismatch")

    [<Test>]
    member _.``AccountGetPrivacy round-trip``() =
        let v : AccountGetPrivacy = { key = InputPrivacyKey.InputPrivacyKeyStatusTimestamp }
        use w1 = new TlWriteBuffer()
        AccountGetPrivacy.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountGetPrivacy.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountGetPrivacy.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountGetPrivacy round-trip mismatch")

    [<Test>]
    member _.``AccountSetPrivacy round-trip``() =
        let v : AccountSetPrivacy = { key = InputPrivacyKey.InputPrivacyKeyStatusTimestamp; rules = [||] }
        use w1 = new TlWriteBuffer()
        AccountSetPrivacy.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountSetPrivacy.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountSetPrivacy.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountSetPrivacy round-trip mismatch")

    [<Test>]
    member _.``AccountSetAccountTTL round-trip``() =
        let v : AccountSetAccountTTL = { ttl = { AccountDaysTTL.days = 0 } }
        use w1 = new TlWriteBuffer()
        AccountSetAccountTTL.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountSetAccountTTL.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountSetAccountTTL.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountSetAccountTTL round-trip mismatch")

    [<Test>]
    member _.``AccountSetGlobalPrivacySettings round-trip``() =
        let v : AccountSetGlobalPrivacySettings = { settings = { GlobalPrivacySettings.archiveAndMuteNewNoncontactPeers = false; keepArchivedUnmuted = false; keepArchivedFolders = false; hideReadMarks = false; newNoncontactPeersRequirePremium = false; displayGiftsButton = false; noncontactPeersPaidStars = None; disallowedGifts = None } }
        use w1 = new TlWriteBuffer()
        AccountSetGlobalPrivacySettings.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountSetGlobalPrivacySettings.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountSetGlobalPrivacySettings.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountSetGlobalPrivacySettings round-trip mismatch")

    [<Test>]
    member _.``AccountUpdateBirthday round-trip``() =
        let v : AccountUpdateBirthday = { birthday = None }
        use w1 = new TlWriteBuffer()
        AccountUpdateBirthday.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = AccountUpdateBirthday.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        AccountUpdateBirthday.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "AccountUpdateBirthday round-trip mismatch")

    [<Test>]
    member _.``UsersGetUsers round-trip``() =
        let v : UsersGetUsers = { id = [||] }
        use w1 = new TlWriteBuffer()
        UsersGetUsers.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = UsersGetUsers.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        UsersGetUsers.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "UsersGetUsers round-trip mismatch")

    [<Test>]
    member _.``UsersGetFullUser round-trip``() =
        let v : UsersGetFullUser = { id = InputUser.InputUserEmpty }
        use w1 = new TlWriteBuffer()
        UsersGetFullUser.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = UsersGetFullUser.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        UsersGetFullUser.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "UsersGetFullUser round-trip mismatch")

    [<Test>]
    member _.``ContactsGetContactIDs round-trip``() =
        let v : ContactsGetContactIDs = { hash = 0L }
        use w1 = new TlWriteBuffer()
        ContactsGetContactIDs.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsGetContactIDs.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsGetContactIDs.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsGetContactIDs round-trip mismatch")

    [<Test>]
    member _.``ContactsImportContacts round-trip``() =
        let v : ContactsImportContacts = { contacts = [||] }
        use w1 = new TlWriteBuffer()
        ContactsImportContacts.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsImportContacts.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsImportContacts.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsImportContacts round-trip mismatch")

    [<Test>]
    member _.``ContactsDeleteContacts round-trip``() =
        let v : ContactsDeleteContacts = { id = [||] }
        use w1 = new TlWriteBuffer()
        ContactsDeleteContacts.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsDeleteContacts.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsDeleteContacts.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsDeleteContacts round-trip mismatch")

    [<Test>]
    member _.``ContactsBlock round-trip``() =
        let v : ContactsBlock = { myStoriesFrom = false; id = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        ContactsBlock.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsBlock.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsBlock.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsBlock round-trip mismatch")

    [<Test>]
    member _.``ContactsUnblock round-trip``() =
        let v : ContactsUnblock = { myStoriesFrom = false; id = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        ContactsUnblock.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsUnblock.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsUnblock.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsUnblock round-trip mismatch")

    [<Test>]
    member _.``ContactsGetBlocked round-trip``() =
        let v : ContactsGetBlocked = { myStoriesFrom = false; offset = 0; limit = 0 }
        use w1 = new TlWriteBuffer()
        ContactsGetBlocked.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsGetBlocked.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsGetBlocked.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsGetBlocked round-trip mismatch")

    [<Test>]
    member _.``ContactsSearch round-trip``() =
        let v : ContactsSearch = { q = ""; limit = 0 }
        use w1 = new TlWriteBuffer()
        ContactsSearch.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsSearch.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsSearch.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsSearch round-trip mismatch")

    [<Test>]
    member _.``ContactsResolveUsername round-trip``() =
        let v : ContactsResolveUsername = { username = ""; referer = None }
        use w1 = new TlWriteBuffer()
        ContactsResolveUsername.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsResolveUsername.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsResolveUsername.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsResolveUsername round-trip mismatch")

    [<Test>]
    member _.``ContactsGetTopPeers round-trip``() =
        let v : ContactsGetTopPeers = { correspondents = false; botsPm = false; botsInline = false; phoneCalls = false; forwardUsers = false; forwardChats = false; groups = false; channels = false; botsApp = false; offset = 0; limit = 0; hash = 0L }
        use w1 = new TlWriteBuffer()
        ContactsGetTopPeers.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsGetTopPeers.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsGetTopPeers.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsGetTopPeers round-trip mismatch")

    [<Test>]
    member _.``ContactsAddContact round-trip``() =
        let v : ContactsAddContact = { addPhonePrivacyException = false; id = InputUser.InputUserEmpty; firstName = ""; lastName = ""; phone = "" }
        use w1 = new TlWriteBuffer()
        ContactsAddContact.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ContactsAddContact.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ContactsAddContact.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ContactsAddContact round-trip mismatch")

    [<Test>]
    member _.``MessagesGetMessages round-trip``() =
        let v : MessagesGetMessages = { id = [||] }
        use w1 = new TlWriteBuffer()
        MessagesGetMessages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetMessages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetMessages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetMessages round-trip mismatch")

    [<Test>]
    member _.``MessagesGetHistory round-trip``() =
        let v : MessagesGetHistory = { peer = InputPeer.InputPeerEmpty; offsetId = 0; offsetDate = 0; addOffset = 0; limit = 0; maxId = 0; minId = 0; hash = 0L }
        use w1 = new TlWriteBuffer()
        MessagesGetHistory.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetHistory.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetHistory.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetHistory round-trip mismatch")

    [<Test>]
    member _.``MessagesSearch round-trip``() =
        let v : MessagesSearch = { peer = InputPeer.InputPeerEmpty; q = ""; fromId = None; savedPeerId = None; savedReaction = None; topMsgId = None; filter = MessagesFilter.InputMessagesFilterEmpty; minDate = 0; maxDate = 0; offsetId = 0; addOffset = 0; limit = 0; maxId = 0; minId = 0; hash = 0L }
        use w1 = new TlWriteBuffer()
        MessagesSearch.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSearch.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSearch.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSearch round-trip mismatch")

    [<Test>]
    member _.``MessagesReadHistory round-trip``() =
        let v : MessagesReadHistory = { peer = InputPeer.InputPeerEmpty; maxId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesReadHistory.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReadHistory.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReadHistory.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReadHistory round-trip mismatch")

    [<Test>]
    member _.``MessagesDeleteHistory round-trip``() =
        let v : MessagesDeleteHistory = { justClear = false; revoke = false; peer = InputPeer.InputPeerEmpty; maxId = 0; minDate = None; maxDate = None }
        use w1 = new TlWriteBuffer()
        MessagesDeleteHistory.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesDeleteHistory.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesDeleteHistory.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesDeleteHistory round-trip mismatch")

    [<Test>]
    member _.``MessagesDeleteMessages round-trip``() =
        let v : MessagesDeleteMessages = { revoke = false; id = [||] }
        use w1 = new TlWriteBuffer()
        MessagesDeleteMessages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesDeleteMessages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesDeleteMessages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesDeleteMessages round-trip mismatch")

    [<Test>]
    member _.``MessagesSetTyping round-trip``() =
        let v : MessagesSetTyping = { peer = InputPeer.InputPeerEmpty; topMsgId = None; action = SendMessageAction.SendMessageTypingAction }
        use w1 = new TlWriteBuffer()
        MessagesSetTyping.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSetTyping.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSetTyping.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSetTyping round-trip mismatch")

    [<Test>]
    member _.``MessagesSendMedia round-trip``() =
        let v : MessagesSendMedia = { silent = false; background = false; clearDraft = false; noforwards = false; updateStickersetsOrder = false; invertMedia = false; allowPaidFloodskip = false; peer = InputPeer.InputPeerEmpty; replyTo = None; media = InputMedia.InputMediaEmpty; message = ""; randomId = 0L; replyMarkup = None; entities = None; scheduleDate = None; sendAs = None; quickReplyShortcut = None; effect = None; allowPaidStars = None; suggestedPost = None }
        use w1 = new TlWriteBuffer()
        MessagesSendMedia.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSendMedia.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSendMedia.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSendMedia round-trip mismatch")

    [<Test>]
    member _.``MessagesForwardMessages round-trip``() =
        let v : MessagesForwardMessages = { silent = false; background = false; withMyScore = false; dropAuthor = false; dropMediaCaptions = false; noforwards = false; allowPaidFloodskip = false; fromPeer = InputPeer.InputPeerEmpty; id = [||]; randomId = [||]; toPeer = InputPeer.InputPeerEmpty; topMsgId = None; replyTo = None; scheduleDate = None; sendAs = None; quickReplyShortcut = None; videoTimestamp = None; allowPaidStars = None; suggestedPost = None }
        use w1 = new TlWriteBuffer()
        MessagesForwardMessages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesForwardMessages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesForwardMessages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesForwardMessages round-trip mismatch")

    [<Test>]
    member _.``MessagesReportSpam round-trip``() =
        let v : MessagesReportSpam = { peer = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        MessagesReportSpam.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReportSpam.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReportSpam.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReportSpam round-trip mismatch")

    [<Test>]
    member _.``MessagesReport round-trip``() =
        let v : MessagesReport = { peer = InputPeer.InputPeerEmpty; id = [||]; option = Array.empty; message = "" }
        use w1 = new TlWriteBuffer()
        MessagesReport.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReport.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReport.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReport round-trip mismatch")

    [<Test>]
    member _.``MessagesGetChats round-trip``() =
        let v : MessagesGetChats = { id = [||] }
        use w1 = new TlWriteBuffer()
        MessagesGetChats.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetChats.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetChats.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetChats round-trip mismatch")

    [<Test>]
    member _.``MessagesGetFullChat round-trip``() =
        let v : MessagesGetFullChat = { chatId = 0L }
        use w1 = new TlWriteBuffer()
        MessagesGetFullChat.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetFullChat.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetFullChat.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetFullChat round-trip mismatch")

    [<Test>]
    member _.``MessagesEditChatTitle round-trip``() =
        let v : MessagesEditChatTitle = { chatId = 0L; title = "" }
        use w1 = new TlWriteBuffer()
        MessagesEditChatTitle.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesEditChatTitle.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesEditChatTitle.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesEditChatTitle round-trip mismatch")

    [<Test>]
    member _.``MessagesEditChatPhoto round-trip``() =
        let v : MessagesEditChatPhoto = { chatId = 0L; photo = InputChatPhoto.InputChatPhotoEmpty }
        use w1 = new TlWriteBuffer()
        MessagesEditChatPhoto.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesEditChatPhoto.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesEditChatPhoto.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesEditChatPhoto round-trip mismatch")

    [<Test>]
    member _.``MessagesAddChatUser round-trip``() =
        let v : MessagesAddChatUser = { chatId = 0L; userId = InputUser.InputUserEmpty; fwdLimit = 0 }
        use w1 = new TlWriteBuffer()
        MessagesAddChatUser.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesAddChatUser.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesAddChatUser.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesAddChatUser round-trip mismatch")

    [<Test>]
    member _.``MessagesDeleteChatUser round-trip``() =
        let v : MessagesDeleteChatUser = { revokeHistory = false; chatId = 0L; userId = InputUser.InputUserEmpty }
        use w1 = new TlWriteBuffer()
        MessagesDeleteChatUser.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesDeleteChatUser.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesDeleteChatUser.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesDeleteChatUser round-trip mismatch")

    [<Test>]
    member _.``MessagesCreateChat round-trip``() =
        let v : MessagesCreateChat = { users = [||]; title = ""; ttlPeriod = None }
        use w1 = new TlWriteBuffer()
        MessagesCreateChat.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesCreateChat.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesCreateChat.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesCreateChat round-trip mismatch")

    [<Test>]
    member _.``MessagesGetDhConfig round-trip``() =
        let v : MessagesGetDhConfig = { version = 0; randomLength = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetDhConfig.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetDhConfig.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetDhConfig.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetDhConfig round-trip mismatch")

    [<Test>]
    member _.``MessagesRequestEncryption round-trip``() =
        let v : MessagesRequestEncryption = { userId = InputUser.InputUserEmpty; randomId = 0; gA = Array.empty }
        use w1 = new TlWriteBuffer()
        MessagesRequestEncryption.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesRequestEncryption.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesRequestEncryption.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesRequestEncryption round-trip mismatch")

    [<Test>]
    member _.``MessagesAcceptEncryption round-trip``() =
        let v : MessagesAcceptEncryption = { peer = { InputEncryptedChat.chatId = 0; accessHash = 0L }; gB = Array.empty; keyFingerprint = 0L }
        use w1 = new TlWriteBuffer()
        MessagesAcceptEncryption.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesAcceptEncryption.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesAcceptEncryption.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesAcceptEncryption round-trip mismatch")

    [<Test>]
    member _.``MessagesDiscardEncryption round-trip``() =
        let v : MessagesDiscardEncryption = { deleteHistory = false; chatId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesDiscardEncryption.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesDiscardEncryption.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesDiscardEncryption.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesDiscardEncryption round-trip mismatch")

    [<Test>]
    member _.``MessagesSetEncryptedTyping round-trip``() =
        let v : MessagesSetEncryptedTyping = { peer = { InputEncryptedChat.chatId = 0; accessHash = 0L }; typing = false }
        use w1 = new TlWriteBuffer()
        MessagesSetEncryptedTyping.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSetEncryptedTyping.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSetEncryptedTyping.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSetEncryptedTyping round-trip mismatch")

    [<Test>]
    member _.``MessagesReadEncryptedHistory round-trip``() =
        let v : MessagesReadEncryptedHistory = { peer = { InputEncryptedChat.chatId = 0; accessHash = 0L }; maxDate = 0 }
        use w1 = new TlWriteBuffer()
        MessagesReadEncryptedHistory.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReadEncryptedHistory.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReadEncryptedHistory.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReadEncryptedHistory round-trip mismatch")

    [<Test>]
    member _.``MessagesSendEncrypted round-trip``() =
        let v : MessagesSendEncrypted = { silent = false; peer = { InputEncryptedChat.chatId = 0; accessHash = 0L }; randomId = 0L; data = Array.empty }
        use w1 = new TlWriteBuffer()
        MessagesSendEncrypted.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSendEncrypted.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSendEncrypted.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSendEncrypted round-trip mismatch")

    [<Test>]
    member _.``MessagesSendEncryptedFile round-trip``() =
        let v : MessagesSendEncryptedFile = { silent = false; peer = { InputEncryptedChat.chatId = 0; accessHash = 0L }; randomId = 0L; data = Array.empty; file = InputEncryptedFile.InputEncryptedFileEmpty }
        use w1 = new TlWriteBuffer()
        MessagesSendEncryptedFile.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSendEncryptedFile.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSendEncryptedFile.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSendEncryptedFile round-trip mismatch")

    [<Test>]
    member _.``MessagesSendEncryptedService round-trip``() =
        let v : MessagesSendEncryptedService = { peer = { InputEncryptedChat.chatId = 0; accessHash = 0L }; randomId = 0L; data = Array.empty }
        use w1 = new TlWriteBuffer()
        MessagesSendEncryptedService.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSendEncryptedService.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSendEncryptedService.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSendEncryptedService round-trip mismatch")

    [<Test>]
    member _.``MessagesReceivedQueue round-trip``() =
        let v : MessagesReceivedQueue = { maxQts = 0 }
        use w1 = new TlWriteBuffer()
        MessagesReceivedQueue.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReceivedQueue.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReceivedQueue.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReceivedQueue round-trip mismatch")

    [<Test>]
    member _.``MessagesReadMessageContents round-trip``() =
        let v : MessagesReadMessageContents = { id = [||] }
        use w1 = new TlWriteBuffer()
        MessagesReadMessageContents.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReadMessageContents.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReadMessageContents.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReadMessageContents round-trip mismatch")

    [<Test>]
    member _.``MessagesExportChatInvite round-trip``() =
        let v : MessagesExportChatInvite = { legacyRevokePermanent = false; requestNeeded = false; peer = InputPeer.InputPeerEmpty; expireDate = None; usageLimit = None; title = None; subscriptionPricing = None }
        use w1 = new TlWriteBuffer()
        MessagesExportChatInvite.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesExportChatInvite.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesExportChatInvite.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesExportChatInvite round-trip mismatch")

    [<Test>]
    member _.``MessagesCheckChatInvite round-trip``() =
        let v : MessagesCheckChatInvite = { hash = "" }
        use w1 = new TlWriteBuffer()
        MessagesCheckChatInvite.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesCheckChatInvite.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesCheckChatInvite.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesCheckChatInvite round-trip mismatch")

    [<Test>]
    member _.``MessagesImportChatInvite round-trip``() =
        let v : MessagesImportChatInvite = { hash = "" }
        use w1 = new TlWriteBuffer()
        MessagesImportChatInvite.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesImportChatInvite.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesImportChatInvite.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesImportChatInvite round-trip mismatch")

    [<Test>]
    member _.``MessagesStartBot round-trip``() =
        let v : MessagesStartBot = { bot = InputUser.InputUserEmpty; peer = InputPeer.InputPeerEmpty; randomId = 0L; startParam = "" }
        use w1 = new TlWriteBuffer()
        MessagesStartBot.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesStartBot.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesStartBot.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesStartBot round-trip mismatch")

    [<Test>]
    member _.``MessagesGetMessagesViews round-trip``() =
        let v : MessagesGetMessagesViews = { peer = InputPeer.InputPeerEmpty; id = [||]; increment = false }
        use w1 = new TlWriteBuffer()
        MessagesGetMessagesViews.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetMessagesViews.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetMessagesViews.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetMessagesViews round-trip mismatch")

    [<Test>]
    member _.``MessagesEditChatAdmin round-trip``() =
        let v : MessagesEditChatAdmin = { chatId = 0L; userId = InputUser.InputUserEmpty; isAdmin = false }
        use w1 = new TlWriteBuffer()
        MessagesEditChatAdmin.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesEditChatAdmin.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesEditChatAdmin.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesEditChatAdmin round-trip mismatch")

    [<Test>]
    member _.``MessagesMigrateChat round-trip``() =
        let v : MessagesMigrateChat = { chatId = 0L }
        use w1 = new TlWriteBuffer()
        MessagesMigrateChat.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesMigrateChat.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesMigrateChat.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesMigrateChat round-trip mismatch")

    [<Test>]
    member _.``MessagesSearchGlobal round-trip``() =
        let v : MessagesSearchGlobal = { broadcastsOnly = false; groupsOnly = false; usersOnly = false; folderId = None; q = ""; filter = MessagesFilter.InputMessagesFilterEmpty; minDate = 0; maxDate = 0; offsetRate = 0; offsetPeer = InputPeer.InputPeerEmpty; offsetId = 0; limit = 0 }
        use w1 = new TlWriteBuffer()
        MessagesSearchGlobal.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSearchGlobal.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSearchGlobal.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSearchGlobal round-trip mismatch")

    [<Test>]
    member _.``MessagesGetInlineBotResults round-trip``() =
        let v : MessagesGetInlineBotResults = { bot = InputUser.InputUserEmpty; peer = InputPeer.InputPeerEmpty; geoPoint = None; query = ""; offset = "" }
        use w1 = new TlWriteBuffer()
        MessagesGetInlineBotResults.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetInlineBotResults.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetInlineBotResults.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetInlineBotResults round-trip mismatch")

    [<Test>]
    member _.``MessagesSendInlineBotResult round-trip``() =
        let v : MessagesSendInlineBotResult = { silent = false; background = false; clearDraft = false; hideVia = false; peer = InputPeer.InputPeerEmpty; replyTo = None; randomId = 0L; queryId = 0L; id = ""; scheduleDate = None; sendAs = None; quickReplyShortcut = None; allowPaidStars = None }
        use w1 = new TlWriteBuffer()
        MessagesSendInlineBotResult.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSendInlineBotResult.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSendInlineBotResult.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSendInlineBotResult round-trip mismatch")

    [<Test>]
    member _.``MessagesEditMessage round-trip``() =
        let v : MessagesEditMessage = { noWebpage = false; invertMedia = false; peer = InputPeer.InputPeerEmpty; id = 0; message = None; media = None; replyMarkup = None; entities = None; scheduleDate = None; quickReplyShortcutId = None }
        use w1 = new TlWriteBuffer()
        MessagesEditMessage.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesEditMessage.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesEditMessage.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesEditMessage round-trip mismatch")

    [<Test>]
    member _.``MessagesGetBotCallbackAnswer round-trip``() =
        let v : MessagesGetBotCallbackAnswer = { game = false; peer = InputPeer.InputPeerEmpty; msgId = 0; data = None; password = None }
        use w1 = new TlWriteBuffer()
        MessagesGetBotCallbackAnswer.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetBotCallbackAnswer.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetBotCallbackAnswer.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetBotCallbackAnswer round-trip mismatch")

    [<Test>]
    member _.``MessagesGetPeerDialogs round-trip``() =
        let v : MessagesGetPeerDialogs = { peers = [||] }
        use w1 = new TlWriteBuffer()
        MessagesGetPeerDialogs.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetPeerDialogs.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetPeerDialogs.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetPeerDialogs round-trip mismatch")

    [<Test>]
    member _.``MessagesSaveDraft round-trip``() =
        let v : MessagesSaveDraft = { noWebpage = false; invertMedia = false; replyTo = None; peer = InputPeer.InputPeerEmpty; message = ""; entities = None; media = None; effect = None; suggestedPost = None }
        use w1 = new TlWriteBuffer()
        MessagesSaveDraft.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSaveDraft.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSaveDraft.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSaveDraft round-trip mismatch")

    [<Test>]
    member _.``MessagesGetCommonChats round-trip``() =
        let v : MessagesGetCommonChats = { userId = InputUser.InputUserEmpty; maxId = 0L; limit = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetCommonChats.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetCommonChats.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetCommonChats.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetCommonChats round-trip mismatch")

    [<Test>]
    member _.``MessagesToggleDialogPin round-trip``() =
        let v : MessagesToggleDialogPin = { pinned = false; peer = InputDialogPeer.InputDialogPeer(InputPeer.InputPeerEmpty) }
        use w1 = new TlWriteBuffer()
        MessagesToggleDialogPin.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesToggleDialogPin.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesToggleDialogPin.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesToggleDialogPin round-trip mismatch")

    [<Test>]
    member _.``MessagesReorderPinnedDialogs round-trip``() =
        let v : MessagesReorderPinnedDialogs = { force = false; folderId = 0; order = [||] }
        use w1 = new TlWriteBuffer()
        MessagesReorderPinnedDialogs.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReorderPinnedDialogs.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReorderPinnedDialogs.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReorderPinnedDialogs round-trip mismatch")

    [<Test>]
    member _.``MessagesGetPinnedDialogs round-trip``() =
        let v : MessagesGetPinnedDialogs = { folderId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetPinnedDialogs.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetPinnedDialogs.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetPinnedDialogs.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetPinnedDialogs round-trip mismatch")

    [<Test>]
    member _.``MessagesUploadMedia round-trip``() =
        let v : MessagesUploadMedia = { businessConnectionId = None; peer = InputPeer.InputPeerEmpty; media = InputMedia.InputMediaEmpty }
        use w1 = new TlWriteBuffer()
        MessagesUploadMedia.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesUploadMedia.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesUploadMedia.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesUploadMedia round-trip mismatch")

    [<Test>]
    member _.``MessagesGetUnreadMentions round-trip``() =
        let v : MessagesGetUnreadMentions = { peer = InputPeer.InputPeerEmpty; topMsgId = None; offsetId = 0; addOffset = 0; limit = 0; maxId = 0; minId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetUnreadMentions.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetUnreadMentions.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetUnreadMentions.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetUnreadMentions round-trip mismatch")

    [<Test>]
    member _.``MessagesReadMentions round-trip``() =
        let v : MessagesReadMentions = { peer = InputPeer.InputPeerEmpty; topMsgId = None }
        use w1 = new TlWriteBuffer()
        MessagesReadMentions.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReadMentions.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReadMentions.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReadMentions round-trip mismatch")

    [<Test>]
    member _.``MessagesSendMultiMedia round-trip``() =
        let v : MessagesSendMultiMedia = { silent = false; background = false; clearDraft = false; noforwards = false; updateStickersetsOrder = false; invertMedia = false; allowPaidFloodskip = false; peer = InputPeer.InputPeerEmpty; replyTo = None; multiMedia = [||]; scheduleDate = None; sendAs = None; quickReplyShortcut = None; effect = None; allowPaidStars = None }
        use w1 = new TlWriteBuffer()
        MessagesSendMultiMedia.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSendMultiMedia.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSendMultiMedia.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSendMultiMedia round-trip mismatch")

    [<Test>]
    member _.``MessagesMarkDialogUnread round-trip``() =
        let v : MessagesMarkDialogUnread = { unread = false; parentPeer = None; peer = InputDialogPeer.InputDialogPeer(InputPeer.InputPeerEmpty) }
        use w1 = new TlWriteBuffer()
        MessagesMarkDialogUnread.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesMarkDialogUnread.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesMarkDialogUnread.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesMarkDialogUnread round-trip mismatch")

    [<Test>]
    member _.``MessagesUpdatePinnedMessage round-trip``() =
        let v : MessagesUpdatePinnedMessage = { silent = false; unpin = false; pmOneside = false; peer = InputPeer.InputPeerEmpty; id = 0 }
        use w1 = new TlWriteBuffer()
        MessagesUpdatePinnedMessage.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesUpdatePinnedMessage.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesUpdatePinnedMessage.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesUpdatePinnedMessage round-trip mismatch")

    [<Test>]
    member _.``MessagesSendVote round-trip``() =
        let v : MessagesSendVote = { peer = InputPeer.InputPeerEmpty; msgId = 0; options = [||] }
        use w1 = new TlWriteBuffer()
        MessagesSendVote.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSendVote.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSendVote.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSendVote round-trip mismatch")

    [<Test>]
    member _.``MessagesGetPollResults round-trip``() =
        let v : MessagesGetPollResults = { peer = InputPeer.InputPeerEmpty; msgId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetPollResults.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetPollResults.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetPollResults.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetPollResults round-trip mismatch")

    [<Test>]
    member _.``MessagesEditChatAbout round-trip``() =
        let v : MessagesEditChatAbout = { peer = InputPeer.InputPeerEmpty; about = "" }
        use w1 = new TlWriteBuffer()
        MessagesEditChatAbout.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesEditChatAbout.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesEditChatAbout.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesEditChatAbout round-trip mismatch")

    [<Test>]
    member _.``MessagesEditChatDefaultBannedRights round-trip``() =
        let v : MessagesEditChatDefaultBannedRights = { peer = InputPeer.InputPeerEmpty; bannedRights = { ChatBannedRights.viewMessages = false; sendMessages = false; sendMedia = false; sendStickers = false; sendGifs = false; sendGames = false; sendInline = false; embedLinks = false; sendPolls = false; changeInfo = false; inviteUsers = false; pinMessages = false; manageTopics = false; sendPhotos = false; sendVideos = false; sendRoundvideos = false; sendAudios = false; sendVoices = false; sendDocs = false; sendPlain = false; untilDate = 0 } }
        use w1 = new TlWriteBuffer()
        MessagesEditChatDefaultBannedRights.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesEditChatDefaultBannedRights.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesEditChatDefaultBannedRights.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesEditChatDefaultBannedRights round-trip mismatch")

    [<Test>]
    member _.``MessagesGetSearchCounters round-trip``() =
        let v : MessagesGetSearchCounters = { peer = InputPeer.InputPeerEmpty; savedPeerId = None; topMsgId = None; filters = [||] }
        use w1 = new TlWriteBuffer()
        MessagesGetSearchCounters.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetSearchCounters.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetSearchCounters.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetSearchCounters round-trip mismatch")

    [<Test>]
    member _.``MessagesGetScheduledHistory round-trip``() =
        let v : MessagesGetScheduledHistory = { peer = InputPeer.InputPeerEmpty; hash = 0L }
        use w1 = new TlWriteBuffer()
        MessagesGetScheduledHistory.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetScheduledHistory.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetScheduledHistory.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetScheduledHistory round-trip mismatch")

    [<Test>]
    member _.``MessagesGetScheduledMessages round-trip``() =
        let v : MessagesGetScheduledMessages = { peer = InputPeer.InputPeerEmpty; id = [||] }
        use w1 = new TlWriteBuffer()
        MessagesGetScheduledMessages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetScheduledMessages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetScheduledMessages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetScheduledMessages round-trip mismatch")

    [<Test>]
    member _.``MessagesSendScheduledMessages round-trip``() =
        let v : MessagesSendScheduledMessages = { peer = InputPeer.InputPeerEmpty; id = [||] }
        use w1 = new TlWriteBuffer()
        MessagesSendScheduledMessages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSendScheduledMessages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSendScheduledMessages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSendScheduledMessages round-trip mismatch")

    [<Test>]
    member _.``MessagesDeleteScheduledMessages round-trip``() =
        let v : MessagesDeleteScheduledMessages = { peer = InputPeer.InputPeerEmpty; id = [||] }
        use w1 = new TlWriteBuffer()
        MessagesDeleteScheduledMessages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesDeleteScheduledMessages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesDeleteScheduledMessages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesDeleteScheduledMessages round-trip mismatch")

    [<Test>]
    member _.``MessagesGetPollVotes round-trip``() =
        let v : MessagesGetPollVotes = { peer = InputPeer.InputPeerEmpty; id = 0; option = None; offset = None; limit = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetPollVotes.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetPollVotes.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetPollVotes.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetPollVotes round-trip mismatch")

    [<Test>]
    member _.``MessagesUpdateDialogFilter round-trip``() =
        let v : MessagesUpdateDialogFilter = { id = 0; filter = None }
        use w1 = new TlWriteBuffer()
        MessagesUpdateDialogFilter.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesUpdateDialogFilter.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesUpdateDialogFilter.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesUpdateDialogFilter round-trip mismatch")

    [<Test>]
    member _.``MessagesUpdateDialogFiltersOrder round-trip``() =
        let v : MessagesUpdateDialogFiltersOrder = { order = [||] }
        use w1 = new TlWriteBuffer()
        MessagesUpdateDialogFiltersOrder.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesUpdateDialogFiltersOrder.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesUpdateDialogFiltersOrder.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesUpdateDialogFiltersOrder round-trip mismatch")

    [<Test>]
    member _.``MessagesGetReplies round-trip``() =
        let v : MessagesGetReplies = { peer = InputPeer.InputPeerEmpty; msgId = 0; offsetId = 0; offsetDate = 0; addOffset = 0; limit = 0; maxId = 0; minId = 0; hash = 0L }
        use w1 = new TlWriteBuffer()
        MessagesGetReplies.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetReplies.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetReplies.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetReplies round-trip mismatch")

    [<Test>]
    member _.``MessagesGetDiscussionMessage round-trip``() =
        let v : MessagesGetDiscussionMessage = { peer = InputPeer.InputPeerEmpty; msgId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetDiscussionMessage.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetDiscussionMessage.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetDiscussionMessage.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetDiscussionMessage round-trip mismatch")

    [<Test>]
    member _.``MessagesReadDiscussion round-trip``() =
        let v : MessagesReadDiscussion = { peer = InputPeer.InputPeerEmpty; msgId = 0; readMaxId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesReadDiscussion.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReadDiscussion.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReadDiscussion.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReadDiscussion round-trip mismatch")

    [<Test>]
    member _.``MessagesUnpinAllMessages round-trip``() =
        let v : MessagesUnpinAllMessages = { peer = InputPeer.InputPeerEmpty; topMsgId = None; savedPeerId = None }
        use w1 = new TlWriteBuffer()
        MessagesUnpinAllMessages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesUnpinAllMessages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesUnpinAllMessages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesUnpinAllMessages round-trip mismatch")

    [<Test>]
    member _.``MessagesDeleteChat round-trip``() =
        let v : MessagesDeleteChat = { chatId = 0L }
        use w1 = new TlWriteBuffer()
        MessagesDeleteChat.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesDeleteChat.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesDeleteChat.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesDeleteChat round-trip mismatch")

    [<Test>]
    member _.``MessagesGetExportedChatInvites round-trip``() =
        let v : MessagesGetExportedChatInvites = { revoked = false; peer = InputPeer.InputPeerEmpty; adminId = InputUser.InputUserEmpty; offsetDate = None; offsetLink = None; limit = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetExportedChatInvites.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetExportedChatInvites.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetExportedChatInvites.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetExportedChatInvites round-trip mismatch")

    [<Test>]
    member _.``MessagesEditExportedChatInvite round-trip``() =
        let v : MessagesEditExportedChatInvite = { revoked = false; peer = InputPeer.InputPeerEmpty; link = ""; expireDate = None; usageLimit = None; requestNeeded = None; title = None }
        use w1 = new TlWriteBuffer()
        MessagesEditExportedChatInvite.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesEditExportedChatInvite.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesEditExportedChatInvite.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesEditExportedChatInvite round-trip mismatch")

    [<Test>]
    member _.``MessagesGetAdminsWithInvites round-trip``() =
        let v : MessagesGetAdminsWithInvites = { peer = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        MessagesGetAdminsWithInvites.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetAdminsWithInvites.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetAdminsWithInvites.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetAdminsWithInvites round-trip mismatch")

    [<Test>]
    member _.``MessagesSetHistoryTTL round-trip``() =
        let v : MessagesSetHistoryTTL = { peer = InputPeer.InputPeerEmpty; period = 0 }
        use w1 = new TlWriteBuffer()
        MessagesSetHistoryTTL.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSetHistoryTTL.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSetHistoryTTL.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSetHistoryTTL round-trip mismatch")

    [<Test>]
    member _.``MessagesGetMessageReadParticipants round-trip``() =
        let v : MessagesGetMessageReadParticipants = { peer = InputPeer.InputPeerEmpty; msgId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetMessageReadParticipants.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetMessageReadParticipants.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetMessageReadParticipants.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetMessageReadParticipants round-trip mismatch")

    [<Test>]
    member _.``MessagesGetSearchResultsCalendar round-trip``() =
        let v : MessagesGetSearchResultsCalendar = { peer = InputPeer.InputPeerEmpty; savedPeerId = None; filter = MessagesFilter.InputMessagesFilterEmpty; offsetId = 0; offsetDate = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetSearchResultsCalendar.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetSearchResultsCalendar.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetSearchResultsCalendar.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetSearchResultsCalendar round-trip mismatch")

    [<Test>]
    member _.``MessagesHideChatJoinRequest round-trip``() =
        let v : MessagesHideChatJoinRequest = { approved = false; peer = InputPeer.InputPeerEmpty; userId = InputUser.InputUserEmpty }
        use w1 = new TlWriteBuffer()
        MessagesHideChatJoinRequest.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesHideChatJoinRequest.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesHideChatJoinRequest.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesHideChatJoinRequest round-trip mismatch")

    [<Test>]
    member _.``MessagesToggleNoForwards round-trip``() =
        let v : MessagesToggleNoForwards = { peer = InputPeer.InputPeerEmpty; enabled = false }
        use w1 = new TlWriteBuffer()
        MessagesToggleNoForwards.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesToggleNoForwards.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesToggleNoForwards.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesToggleNoForwards round-trip mismatch")

    [<Test>]
    member _.``MessagesSaveDefaultSendAs round-trip``() =
        let v : MessagesSaveDefaultSendAs = { peer = InputPeer.InputPeerEmpty; sendAs = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        MessagesSaveDefaultSendAs.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSaveDefaultSendAs.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSaveDefaultSendAs.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSaveDefaultSendAs round-trip mismatch")

    [<Test>]
    member _.``MessagesSendReaction round-trip``() =
        let v : MessagesSendReaction = { big = false; addToRecent = false; peer = InputPeer.InputPeerEmpty; msgId = 0; reaction = None }
        use w1 = new TlWriteBuffer()
        MessagesSendReaction.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSendReaction.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSendReaction.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSendReaction round-trip mismatch")

    [<Test>]
    member _.``MessagesGetMessagesReactions round-trip``() =
        let v : MessagesGetMessagesReactions = { peer = InputPeer.InputPeerEmpty; id = [||] }
        use w1 = new TlWriteBuffer()
        MessagesGetMessagesReactions.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetMessagesReactions.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetMessagesReactions.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetMessagesReactions round-trip mismatch")

    [<Test>]
    member _.``MessagesGetMessageReactionsList round-trip``() =
        let v : MessagesGetMessageReactionsList = { peer = InputPeer.InputPeerEmpty; id = 0; reaction = None; offset = None; limit = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetMessageReactionsList.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetMessageReactionsList.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetMessageReactionsList.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetMessageReactionsList round-trip mismatch")

    [<Test>]
    member _.``MessagesSetChatAvailableReactions round-trip``() =
        let v : MessagesSetChatAvailableReactions = { peer = InputPeer.InputPeerEmpty; availableReactions = ChatReactions.ChatReactionsNone; reactionsLimit = None; paidEnabled = None }
        use w1 = new TlWriteBuffer()
        MessagesSetChatAvailableReactions.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSetChatAvailableReactions.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSetChatAvailableReactions.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSetChatAvailableReactions round-trip mismatch")

    [<Test>]
    member _.``MessagesGetAvailableReactions round-trip``() =
        let v : MessagesGetAvailableReactions = { hash = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetAvailableReactions.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetAvailableReactions.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetAvailableReactions.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetAvailableReactions round-trip mismatch")

    [<Test>]
    member _.``MessagesSetDefaultReaction round-trip``() =
        let v : MessagesSetDefaultReaction = { reaction = Reaction.ReactionEmpty }
        use w1 = new TlWriteBuffer()
        MessagesSetDefaultReaction.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSetDefaultReaction.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSetDefaultReaction.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSetDefaultReaction round-trip mismatch")

    [<Test>]
    member _.``MessagesTranslateText round-trip``() =
        let v : MessagesTranslateText = { peer = None; id = None; text = None; toLang = "" }
        use w1 = new TlWriteBuffer()
        MessagesTranslateText.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesTranslateText.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesTranslateText.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesTranslateText round-trip mismatch")

    [<Test>]
    member _.``MessagesGetUnreadReactions round-trip``() =
        let v : MessagesGetUnreadReactions = { peer = InputPeer.InputPeerEmpty; topMsgId = None; savedPeerId = None; offsetId = 0; addOffset = 0; limit = 0; maxId = 0; minId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetUnreadReactions.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetUnreadReactions.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetUnreadReactions.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetUnreadReactions round-trip mismatch")

    [<Test>]
    member _.``MessagesReadReactions round-trip``() =
        let v : MessagesReadReactions = { peer = InputPeer.InputPeerEmpty; topMsgId = None; savedPeerId = None }
        use w1 = new TlWriteBuffer()
        MessagesReadReactions.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReadReactions.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReadReactions.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReadReactions round-trip mismatch")

    [<Test>]
    member _.``MessagesGetTopReactions round-trip``() =
        let v : MessagesGetTopReactions = { limit = 0; hash = 0L }
        use w1 = new TlWriteBuffer()
        MessagesGetTopReactions.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetTopReactions.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetTopReactions.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetTopReactions round-trip mismatch")

    [<Test>]
    member _.``MessagesGetRecentReactions round-trip``() =
        let v : MessagesGetRecentReactions = { limit = 0; hash = 0L }
        use w1 = new TlWriteBuffer()
        MessagesGetRecentReactions.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetRecentReactions.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetRecentReactions.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetRecentReactions round-trip mismatch")

    [<Test>]
    member _.``MessagesSetDefaultHistoryTTL round-trip``() =
        let v : MessagesSetDefaultHistoryTTL = { period = 0 }
        use w1 = new TlWriteBuffer()
        MessagesSetDefaultHistoryTTL.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesSetDefaultHistoryTTL.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesSetDefaultHistoryTTL.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesSetDefaultHistoryTTL round-trip mismatch")

    [<Test>]
    member _.``MessagesTogglePeerTranslations round-trip``() =
        let v : MessagesTogglePeerTranslations = { disabled = false; peer = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        MessagesTogglePeerTranslations.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesTogglePeerTranslations.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesTogglePeerTranslations.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesTogglePeerTranslations round-trip mismatch")

    [<Test>]
    member _.``MessagesGetSavedHistory round-trip``() =
        let v : MessagesGetSavedHistory = { parentPeer = None; peer = InputPeer.InputPeerEmpty; offsetId = 0; offsetDate = 0; addOffset = 0; limit = 0; maxId = 0; minId = 0; hash = 0L }
        use w1 = new TlWriteBuffer()
        MessagesGetSavedHistory.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetSavedHistory.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetSavedHistory.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetSavedHistory round-trip mismatch")

    [<Test>]
    member _.``MessagesToggleSavedDialogPin round-trip``() =
        let v : MessagesToggleSavedDialogPin = { pinned = false; peer = InputDialogPeer.InputDialogPeer(InputPeer.InputPeerEmpty) }
        use w1 = new TlWriteBuffer()
        MessagesToggleSavedDialogPin.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesToggleSavedDialogPin.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesToggleSavedDialogPin.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesToggleSavedDialogPin round-trip mismatch")

    [<Test>]
    member _.``MessagesReorderPinnedSavedDialogs round-trip``() =
        let v : MessagesReorderPinnedSavedDialogs = { force = false; order = [||] }
        use w1 = new TlWriteBuffer()
        MessagesReorderPinnedSavedDialogs.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesReorderPinnedSavedDialogs.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesReorderPinnedSavedDialogs.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesReorderPinnedSavedDialogs round-trip mismatch")

    [<Test>]
    member _.``MessagesGetOutboxReadDate round-trip``() =
        let v : MessagesGetOutboxReadDate = { peer = InputPeer.InputPeerEmpty; msgId = 0 }
        use w1 = new TlWriteBuffer()
        MessagesGetOutboxReadDate.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = MessagesGetOutboxReadDate.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        MessagesGetOutboxReadDate.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "MessagesGetOutboxReadDate round-trip mismatch")

    [<Test>]
    member _.``UpdatesGetDifference round-trip``() =
        let v : UpdatesGetDifference = { pts = 0; ptsLimit = None; ptsTotalLimit = None; date = 0; qts = 0; qtsLimit = None }
        use w1 = new TlWriteBuffer()
        UpdatesGetDifference.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = UpdatesGetDifference.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        UpdatesGetDifference.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "UpdatesGetDifference round-trip mismatch")

    [<Test>]
    member _.``UpdatesGetChannelDifference round-trip``() =
        let v : UpdatesGetChannelDifference = { force = false; channel = InputChannel.InputChannelEmpty; filter = ChannelMessagesFilter.ChannelMessagesFilterEmpty; pts = 0; limit = 0 }
        use w1 = new TlWriteBuffer()
        UpdatesGetChannelDifference.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = UpdatesGetChannelDifference.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        UpdatesGetChannelDifference.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "UpdatesGetChannelDifference round-trip mismatch")

    [<Test>]
    member _.``PhotosUpdateProfilePhoto round-trip``() =
        let v : PhotosUpdateProfilePhoto = { fallback = false; bot = None; id = InputPhoto.InputPhotoEmpty }
        use w1 = new TlWriteBuffer()
        PhotosUpdateProfilePhoto.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhotosUpdateProfilePhoto.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhotosUpdateProfilePhoto.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhotosUpdateProfilePhoto round-trip mismatch")

    [<Test>]
    member _.``PhotosDeletePhotos round-trip``() =
        let v : PhotosDeletePhotos = { id = [||] }
        use w1 = new TlWriteBuffer()
        PhotosDeletePhotos.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhotosDeletePhotos.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhotosDeletePhotos.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhotosDeletePhotos round-trip mismatch")

    [<Test>]
    member _.``PhotosGetUserPhotos round-trip``() =
        let v : PhotosGetUserPhotos = { userId = InputUser.InputUserEmpty; offset = 0; maxId = 0L; limit = 0 }
        use w1 = new TlWriteBuffer()
        PhotosGetUserPhotos.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhotosGetUserPhotos.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhotosGetUserPhotos.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhotosGetUserPhotos round-trip mismatch")

    [<Test>]
    member _.``UploadSaveFilePart round-trip``() =
        let v : UploadSaveFilePart = { fileId = 0L; filePart = 0; bytes = Array.empty }
        use w1 = new TlWriteBuffer()
        UploadSaveFilePart.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = UploadSaveFilePart.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        UploadSaveFilePart.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "UploadSaveFilePart round-trip mismatch")

    [<Test>]
    member _.``UploadGetFile round-trip``() =
        let v : UploadGetFile = { precise = false; cdnSupported = false; location = InputFileLocation.InputFileLocation(0L, 0, 0L, Array.empty); offset = 0L; limit = 0 }
        use w1 = new TlWriteBuffer()
        UploadGetFile.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = UploadGetFile.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        UploadGetFile.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "UploadGetFile round-trip mismatch")

    [<Test>]
    member _.``UploadSaveBigFilePart round-trip``() =
        let v : UploadSaveBigFilePart = { fileId = 0L; filePart = 0; fileTotalParts = 0; bytes = Array.empty }
        use w1 = new TlWriteBuffer()
        UploadSaveBigFilePart.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = UploadSaveBigFilePart.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        UploadSaveBigFilePart.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "UploadSaveBigFilePart round-trip mismatch")

    [<Test>]
    member _.``ChannelsReadHistory round-trip``() =
        let v : ChannelsReadHistory = { channel = InputChannel.InputChannelEmpty; maxId = 0 }
        use w1 = new TlWriteBuffer()
        ChannelsReadHistory.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsReadHistory.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsReadHistory.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsReadHistory round-trip mismatch")

    [<Test>]
    member _.``ChannelsDeleteMessages round-trip``() =
        let v : ChannelsDeleteMessages = { channel = InputChannel.InputChannelEmpty; id = [||] }
        use w1 = new TlWriteBuffer()
        ChannelsDeleteMessages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsDeleteMessages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsDeleteMessages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsDeleteMessages round-trip mismatch")

    [<Test>]
    member _.``ChannelsGetMessages round-trip``() =
        let v : ChannelsGetMessages = { channel = InputChannel.InputChannelEmpty; id = [||] }
        use w1 = new TlWriteBuffer()
        ChannelsGetMessages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsGetMessages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsGetMessages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsGetMessages round-trip mismatch")

    [<Test>]
    member _.``ChannelsGetParticipants round-trip``() =
        let v : ChannelsGetParticipants = { channel = InputChannel.InputChannelEmpty; filter = ChannelParticipantsFilter.ChannelParticipantsRecent; offset = 0; limit = 0; hash = 0L }
        use w1 = new TlWriteBuffer()
        ChannelsGetParticipants.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsGetParticipants.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsGetParticipants.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsGetParticipants round-trip mismatch")

    [<Test>]
    member _.``ChannelsGetParticipant round-trip``() =
        let v : ChannelsGetParticipant = { channel = InputChannel.InputChannelEmpty; participant = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        ChannelsGetParticipant.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsGetParticipant.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsGetParticipant.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsGetParticipant round-trip mismatch")

    [<Test>]
    member _.``ChannelsGetChannels round-trip``() =
        let v : ChannelsGetChannels = { id = [||] }
        use w1 = new TlWriteBuffer()
        ChannelsGetChannels.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsGetChannels.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsGetChannels.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsGetChannels round-trip mismatch")

    [<Test>]
    member _.``ChannelsGetFullChannel round-trip``() =
        let v : ChannelsGetFullChannel = { channel = InputChannel.InputChannelEmpty }
        use w1 = new TlWriteBuffer()
        ChannelsGetFullChannel.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsGetFullChannel.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsGetFullChannel.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsGetFullChannel round-trip mismatch")

    [<Test>]
    member _.``ChannelsCreateChannel round-trip``() =
        let v : ChannelsCreateChannel = { broadcast = false; megagroup = false; forImport = false; forum = false; title = ""; about = ""; geoPoint = None; address = None; ttlPeriod = None }
        use w1 = new TlWriteBuffer()
        ChannelsCreateChannel.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsCreateChannel.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsCreateChannel.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsCreateChannel round-trip mismatch")

    [<Test>]
    member _.``ChannelsEditTitle round-trip``() =
        let v : ChannelsEditTitle = { channel = InputChannel.InputChannelEmpty; title = "" }
        use w1 = new TlWriteBuffer()
        ChannelsEditTitle.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsEditTitle.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsEditTitle.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsEditTitle round-trip mismatch")

    [<Test>]
    member _.``ChannelsEditPhoto round-trip``() =
        let v : ChannelsEditPhoto = { channel = InputChannel.InputChannelEmpty; photo = InputChatPhoto.InputChatPhotoEmpty }
        use w1 = new TlWriteBuffer()
        ChannelsEditPhoto.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsEditPhoto.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsEditPhoto.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsEditPhoto round-trip mismatch")

    [<Test>]
    member _.``ChannelsCheckUsername round-trip``() =
        let v : ChannelsCheckUsername = { channel = InputChannel.InputChannelEmpty; username = "" }
        use w1 = new TlWriteBuffer()
        ChannelsCheckUsername.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsCheckUsername.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsCheckUsername.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsCheckUsername round-trip mismatch")

    [<Test>]
    member _.``ChannelsUpdateUsername round-trip``() =
        let v : ChannelsUpdateUsername = { channel = InputChannel.InputChannelEmpty; username = "" }
        use w1 = new TlWriteBuffer()
        ChannelsUpdateUsername.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsUpdateUsername.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsUpdateUsername.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsUpdateUsername round-trip mismatch")

    [<Test>]
    member _.``ChannelsJoinChannel round-trip``() =
        let v : ChannelsJoinChannel = { channel = InputChannel.InputChannelEmpty }
        use w1 = new TlWriteBuffer()
        ChannelsJoinChannel.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsJoinChannel.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsJoinChannel.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsJoinChannel round-trip mismatch")

    [<Test>]
    member _.``ChannelsLeaveChannel round-trip``() =
        let v : ChannelsLeaveChannel = { channel = InputChannel.InputChannelEmpty }
        use w1 = new TlWriteBuffer()
        ChannelsLeaveChannel.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsLeaveChannel.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsLeaveChannel.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsLeaveChannel round-trip mismatch")

    [<Test>]
    member _.``ChannelsInviteToChannel round-trip``() =
        let v : ChannelsInviteToChannel = { channel = InputChannel.InputChannelEmpty; users = [||] }
        use w1 = new TlWriteBuffer()
        ChannelsInviteToChannel.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsInviteToChannel.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsInviteToChannel.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsInviteToChannel round-trip mismatch")

    [<Test>]
    member _.``ChannelsDeleteChannel round-trip``() =
        let v : ChannelsDeleteChannel = { channel = InputChannel.InputChannelEmpty }
        use w1 = new TlWriteBuffer()
        ChannelsDeleteChannel.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsDeleteChannel.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsDeleteChannel.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsDeleteChannel round-trip mismatch")

    [<Test>]
    member _.``ChannelsToggleSignatures round-trip``() =
        let v : ChannelsToggleSignatures = { signaturesEnabled = false; profilesEnabled = false; channel = InputChannel.InputChannelEmpty }
        use w1 = new TlWriteBuffer()
        ChannelsToggleSignatures.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsToggleSignatures.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsToggleSignatures.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsToggleSignatures round-trip mismatch")

    [<Test>]
    member _.``ChannelsEditBanned round-trip``() =
        let v : ChannelsEditBanned = { channel = InputChannel.InputChannelEmpty; participant = InputPeer.InputPeerEmpty; bannedRights = { ChatBannedRights.viewMessages = false; sendMessages = false; sendMedia = false; sendStickers = false; sendGifs = false; sendGames = false; sendInline = false; embedLinks = false; sendPolls = false; changeInfo = false; inviteUsers = false; pinMessages = false; manageTopics = false; sendPhotos = false; sendVideos = false; sendRoundvideos = false; sendAudios = false; sendVoices = false; sendDocs = false; sendPlain = false; untilDate = 0 } }
        use w1 = new TlWriteBuffer()
        ChannelsEditBanned.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsEditBanned.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsEditBanned.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsEditBanned round-trip mismatch")

    [<Test>]
    member _.``ChannelsReadMessageContents round-trip``() =
        let v : ChannelsReadMessageContents = { channel = InputChannel.InputChannelEmpty; id = [||] }
        use w1 = new TlWriteBuffer()
        ChannelsReadMessageContents.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsReadMessageContents.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsReadMessageContents.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsReadMessageContents round-trip mismatch")

    [<Test>]
    member _.``ChannelsTogglePreHistoryHidden round-trip``() =
        let v : ChannelsTogglePreHistoryHidden = { channel = InputChannel.InputChannelEmpty; enabled = false }
        use w1 = new TlWriteBuffer()
        ChannelsTogglePreHistoryHidden.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsTogglePreHistoryHidden.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsTogglePreHistoryHidden.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsTogglePreHistoryHidden round-trip mismatch")

    [<Test>]
    member _.``ChannelsSetDiscussionGroup round-trip``() =
        let v : ChannelsSetDiscussionGroup = { broadcast = InputChannel.InputChannelEmpty; group = InputChannel.InputChannelEmpty }
        use w1 = new TlWriteBuffer()
        ChannelsSetDiscussionGroup.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsSetDiscussionGroup.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsSetDiscussionGroup.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsSetDiscussionGroup round-trip mismatch")

    [<Test>]
    member _.``ChannelsToggleSlowMode round-trip``() =
        let v : ChannelsToggleSlowMode = { channel = InputChannel.InputChannelEmpty; seconds = 0 }
        use w1 = new TlWriteBuffer()
        ChannelsToggleSlowMode.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsToggleSlowMode.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsToggleSlowMode.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsToggleSlowMode round-trip mismatch")

    [<Test>]
    member _.``ChannelsGetSendAs round-trip``() =
        let v : ChannelsGetSendAs = { forPaidReactions = false; peer = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        ChannelsGetSendAs.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsGetSendAs.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsGetSendAs.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsGetSendAs round-trip mismatch")

    [<Test>]
    member _.``ChannelsToggleJoinToSend round-trip``() =
        let v : ChannelsToggleJoinToSend = { channel = InputChannel.InputChannelEmpty; enabled = false }
        use w1 = new TlWriteBuffer()
        ChannelsToggleJoinToSend.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsToggleJoinToSend.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsToggleJoinToSend.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsToggleJoinToSend round-trip mismatch")

    [<Test>]
    member _.``ChannelsToggleJoinRequest round-trip``() =
        let v : ChannelsToggleJoinRequest = { channel = InputChannel.InputChannelEmpty; enabled = false }
        use w1 = new TlWriteBuffer()
        ChannelsToggleJoinRequest.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsToggleJoinRequest.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsToggleJoinRequest.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsToggleJoinRequest round-trip mismatch")

    [<Test>]
    member _.``ChannelsToggleForum round-trip``() =
        let v : ChannelsToggleForum = { channel = InputChannel.InputChannelEmpty; enabled = false; tabs = false }
        use w1 = new TlWriteBuffer()
        ChannelsToggleForum.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = ChannelsToggleForum.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        ChannelsToggleForum.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "ChannelsToggleForum round-trip mismatch")

    [<Test>]
    member _.``PhoneRequestCall round-trip``() =
        let v : PhoneRequestCall = { video = false; userId = InputUser.InputUserEmpty; randomId = 0; gAHash = Array.empty; protocol = { PhoneCallProtocol.udpP2p = false; udpReflector = false; minLayer = 0; maxLayer = 0; libraryVersions = [||] } }
        use w1 = new TlWriteBuffer()
        PhoneRequestCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneRequestCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneRequestCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneRequestCall round-trip mismatch")

    [<Test>]
    member _.``PhoneAcceptCall round-trip``() =
        let v : PhoneAcceptCall = { peer = { InputPhoneCall.id = 0L; accessHash = 0L }; gB = Array.empty; protocol = { PhoneCallProtocol.udpP2p = false; udpReflector = false; minLayer = 0; maxLayer = 0; libraryVersions = [||] } }
        use w1 = new TlWriteBuffer()
        PhoneAcceptCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneAcceptCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneAcceptCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneAcceptCall round-trip mismatch")

    [<Test>]
    member _.``PhoneConfirmCall round-trip``() =
        let v : PhoneConfirmCall = { peer = { InputPhoneCall.id = 0L; accessHash = 0L }; gA = Array.empty; keyFingerprint = 0L; protocol = { PhoneCallProtocol.udpP2p = false; udpReflector = false; minLayer = 0; maxLayer = 0; libraryVersions = [||] } }
        use w1 = new TlWriteBuffer()
        PhoneConfirmCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneConfirmCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneConfirmCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneConfirmCall round-trip mismatch")

    [<Test>]
    member _.``PhoneDiscardCall round-trip``() =
        let v : PhoneDiscardCall = { video = false; peer = { InputPhoneCall.id = 0L; accessHash = 0L }; duration = 0; reason = PhoneCallDiscardReason.PhoneCallDiscardReasonMissed; connectionId = 0L }
        use w1 = new TlWriteBuffer()
        PhoneDiscardCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneDiscardCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneDiscardCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneDiscardCall round-trip mismatch")

    [<Test>]
    member _.``PhoneSaveCallDebug round-trip``() =
        let v : PhoneSaveCallDebug = { peer = { InputPhoneCall.id = 0L; accessHash = 0L }; debug = { DataJSON.data = "" } }
        use w1 = new TlWriteBuffer()
        PhoneSaveCallDebug.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneSaveCallDebug.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneSaveCallDebug.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneSaveCallDebug round-trip mismatch")

    [<Test>]
    member _.``PhoneSendSignalingData round-trip``() =
        let v : PhoneSendSignalingData = { peer = { InputPhoneCall.id = 0L; accessHash = 0L }; data = Array.empty }
        use w1 = new TlWriteBuffer()
        PhoneSendSignalingData.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneSendSignalingData.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneSendSignalingData.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneSendSignalingData round-trip mismatch")

    [<Test>]
    member _.``PhoneCreateGroupCall round-trip``() =
        let v : PhoneCreateGroupCall = { rtmpStream = false; peer = InputPeer.InputPeerEmpty; randomId = 0; title = None; scheduleDate = None }
        use w1 = new TlWriteBuffer()
        PhoneCreateGroupCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneCreateGroupCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneCreateGroupCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneCreateGroupCall round-trip mismatch")

    [<Test>]
    member _.``PhoneJoinGroupCall round-trip``() =
        let v : PhoneJoinGroupCall = { muted = false; videoStopped = false; call = InputGroupCall.InputGroupCallSlug(""); joinAs = InputPeer.InputPeerEmpty; inviteHash = None; publicKey = None; block = None; ``params`` = { DataJSON.data = "" } }
        use w1 = new TlWriteBuffer()
        PhoneJoinGroupCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneJoinGroupCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneJoinGroupCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneJoinGroupCall round-trip mismatch")

    [<Test>]
    member _.``PhoneLeaveGroupCall round-trip``() =
        let v : PhoneLeaveGroupCall = { call = InputGroupCall.InputGroupCallSlug(""); source = 0 }
        use w1 = new TlWriteBuffer()
        PhoneLeaveGroupCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneLeaveGroupCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneLeaveGroupCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneLeaveGroupCall round-trip mismatch")

    [<Test>]
    member _.``PhoneInviteToGroupCall round-trip``() =
        let v : PhoneInviteToGroupCall = { call = InputGroupCall.InputGroupCallSlug(""); users = [||] }
        use w1 = new TlWriteBuffer()
        PhoneInviteToGroupCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneInviteToGroupCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneInviteToGroupCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneInviteToGroupCall round-trip mismatch")

    [<Test>]
    member _.``PhoneDiscardGroupCall round-trip``() =
        let v : PhoneDiscardGroupCall = { call = InputGroupCall.InputGroupCallSlug("") }
        use w1 = new TlWriteBuffer()
        PhoneDiscardGroupCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneDiscardGroupCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneDiscardGroupCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneDiscardGroupCall round-trip mismatch")

    [<Test>]
    member _.``PhoneToggleGroupCallSettings round-trip``() =
        let v : PhoneToggleGroupCallSettings = { resetInviteHash = false; call = InputGroupCall.InputGroupCallSlug(""); joinMuted = None }
        use w1 = new TlWriteBuffer()
        PhoneToggleGroupCallSettings.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneToggleGroupCallSettings.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneToggleGroupCallSettings.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneToggleGroupCallSettings round-trip mismatch")

    [<Test>]
    member _.``PhoneGetGroupCall round-trip``() =
        let v : PhoneGetGroupCall = { call = InputGroupCall.InputGroupCallSlug(""); limit = 0 }
        use w1 = new TlWriteBuffer()
        PhoneGetGroupCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneGetGroupCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneGetGroupCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneGetGroupCall round-trip mismatch")

    [<Test>]
    member _.``PhoneGetGroupParticipants round-trip``() =
        let v : PhoneGetGroupParticipants = { call = InputGroupCall.InputGroupCallSlug(""); ids = [||]; sources = [||]; offset = ""; limit = 0 }
        use w1 = new TlWriteBuffer()
        PhoneGetGroupParticipants.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneGetGroupParticipants.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneGetGroupParticipants.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneGetGroupParticipants round-trip mismatch")

    [<Test>]
    member _.``PhoneCheckGroupCall round-trip``() =
        let v : PhoneCheckGroupCall = { call = InputGroupCall.InputGroupCallSlug(""); sources = [||] }
        use w1 = new TlWriteBuffer()
        PhoneCheckGroupCall.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneCheckGroupCall.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneCheckGroupCall.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneCheckGroupCall round-trip mismatch")

    [<Test>]
    member _.``PhoneToggleGroupCallRecord round-trip``() =
        let v : PhoneToggleGroupCallRecord = { start = false; video = false; call = InputGroupCall.InputGroupCallSlug(""); title = None; videoPortrait = None }
        use w1 = new TlWriteBuffer()
        PhoneToggleGroupCallRecord.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneToggleGroupCallRecord.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneToggleGroupCallRecord.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneToggleGroupCallRecord round-trip mismatch")

    [<Test>]
    member _.``PhoneEditGroupCallParticipant round-trip``() =
        let v : PhoneEditGroupCallParticipant = { call = InputGroupCall.InputGroupCallSlug(""); participant = InputPeer.InputPeerEmpty; muted = None; volume = None; raiseHand = None; videoStopped = None; videoPaused = None; presentationPaused = None }
        use w1 = new TlWriteBuffer()
        PhoneEditGroupCallParticipant.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneEditGroupCallParticipant.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneEditGroupCallParticipant.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneEditGroupCallParticipant round-trip mismatch")

    [<Test>]
    member _.``PhoneEditGroupCallTitle round-trip``() =
        let v : PhoneEditGroupCallTitle = { call = InputGroupCall.InputGroupCallSlug(""); title = "" }
        use w1 = new TlWriteBuffer()
        PhoneEditGroupCallTitle.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneEditGroupCallTitle.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneEditGroupCallTitle.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneEditGroupCallTitle round-trip mismatch")

    [<Test>]
    member _.``PhoneGetGroupCallJoinAs round-trip``() =
        let v : PhoneGetGroupCallJoinAs = { peer = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        PhoneGetGroupCallJoinAs.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneGetGroupCallJoinAs.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneGetGroupCallJoinAs.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneGetGroupCallJoinAs round-trip mismatch")

    [<Test>]
    member _.``PhoneExportGroupCallInvite round-trip``() =
        let v : PhoneExportGroupCallInvite = { canSelfUnmute = false; call = InputGroupCall.InputGroupCallSlug("") }
        use w1 = new TlWriteBuffer()
        PhoneExportGroupCallInvite.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = PhoneExportGroupCallInvite.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        PhoneExportGroupCallInvite.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "PhoneExportGroupCallInvite round-trip mismatch")

    [<Test>]
    member _.``LangpackGetLangPack round-trip``() =
        let v : LangpackGetLangPack = { langPack = ""; langCode = "" }
        use w1 = new TlWriteBuffer()
        LangpackGetLangPack.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = LangpackGetLangPack.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        LangpackGetLangPack.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "LangpackGetLangPack round-trip mismatch")

    [<Test>]
    member _.``LangpackGetStrings round-trip``() =
        let v : LangpackGetStrings = { langPack = ""; langCode = ""; keys = [||] }
        use w1 = new TlWriteBuffer()
        LangpackGetStrings.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = LangpackGetStrings.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        LangpackGetStrings.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "LangpackGetStrings round-trip mismatch")

    [<Test>]
    member _.``LangpackGetDifference round-trip``() =
        let v : LangpackGetDifference = { langPack = ""; langCode = ""; fromVersion = 0 }
        use w1 = new TlWriteBuffer()
        LangpackGetDifference.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = LangpackGetDifference.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        LangpackGetDifference.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "LangpackGetDifference round-trip mismatch")

    [<Test>]
    member _.``LangpackGetLanguages round-trip``() =
        let v : LangpackGetLanguages = { langPack = "" }
        use w1 = new TlWriteBuffer()
        LangpackGetLanguages.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = LangpackGetLanguages.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        LangpackGetLanguages.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "LangpackGetLanguages round-trip mismatch")

    [<Test>]
    member _.``LangpackGetLanguage round-trip``() =
        let v : LangpackGetLanguage = { langPack = ""; langCode = "" }
        use w1 = new TlWriteBuffer()
        LangpackGetLanguage.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = LangpackGetLanguage.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        LangpackGetLanguage.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "LangpackGetLanguage round-trip mismatch")

    [<Test>]
    member _.``FoldersEditPeerFolders round-trip``() =
        let v : FoldersEditPeerFolders = { folderPeers = [||] }
        use w1 = new TlWriteBuffer()
        FoldersEditPeerFolders.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = FoldersEditPeerFolders.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        FoldersEditPeerFolders.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "FoldersEditPeerFolders round-trip mismatch")

    [<Test>]
    member _.``StoriesGetAllStories round-trip``() =
        let v : StoriesGetAllStories = { next = false; hidden = false; state = None }
        use w1 = new TlWriteBuffer()
        StoriesGetAllStories.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = StoriesGetAllStories.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        StoriesGetAllStories.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "StoriesGetAllStories round-trip mismatch")

    [<Test>]
    member _.``StoriesGetPeerStories round-trip``() =
        let v : StoriesGetPeerStories = { peer = InputPeer.InputPeerEmpty }
        use w1 = new TlWriteBuffer()
        StoriesGetPeerStories.Serialize(w1, v)
        let bytes1 = w1.ToArray()
        let v2 = StoriesGetPeerStories.Deserialize(bytes1)
        use w2 = new TlWriteBuffer()
        StoriesGetPeerStories.Serialize(w2, v2)
        let bytes2 = w2.ToArray()
        Assert.That(bytes2, Is.EqualTo(bytes1 :> obj), "StoriesGetPeerStories round-trip mismatch")

