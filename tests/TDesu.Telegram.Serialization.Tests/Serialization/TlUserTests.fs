namespace TDesu.Serialization.Tests

open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

/// Verify that TlUser per-layer serialize functions produce deterministic bytes.
[<TestFixture>]
type TlUserTests() =

    let serializeWithTlUser (u: TlUser) (layer: int) : byte[] =
        use w = new TlWriteBuffer()
        TlUser.serializeInt w u layer
        w.ToArray()

    let basicUser: TlUser = {
        UserId = 42L
        AccessHash = Some 12345L
        FirstName = "Alice"
        LastName = Some "Smith"
        Username = Some "alice"
        Phone = Some "+1234567890"
        IsSelf = false
        IsBot = false
        BotInfoVersion = None
        Photo = None
        Status = None
    }

    [<Test>]
    member _.``Basic user serializeLayer223 is deterministic``() =
        use w1 = new TlWriteBuffer()
        TlUser.serializeLayer223 w1 basicUser
        let first = w1.ToArray()
        use w2 = new TlWriteBuffer()
        TlUser.serializeLayer223 w2 basicUser
        let second = w2.ToArray()
        equals first second

    [<Test>]
    member _.``Basic user serializeLayer216 is deterministic``() =
        use w1 = new TlWriteBuffer()
        TlUser.serializeLayer216 w1 basicUser
        let first = w1.ToArray()
        use w2 = new TlWriteBuffer()
        TlUser.serializeLayer216 w2 basicUser
        let second = w2.ToArray()
        equals first second

    [<Test>]
    member _.``Basic user serialize dispatches correctly - layer 223``() =
        use w = new TlWriteBuffer()
        TlUser.serializeLayer223 w basicUser
        let expected = w.ToArray()
        let actual = serializeWithTlUser basicUser 223
        equals actual expected

    [<Test>]
    member _.``Basic user serialize dispatches correctly - layer 216``() =
        use w = new TlWriteBuffer()
        TlUser.serializeLayer216 w basicUser
        let expected = w.ToArray()
        let actual = serializeWithTlUser basicUser 216
        equals actual expected

    [<Test>]
    member _.``Self user is deterministic - layer 223``() =
        let user = { basicUser with IsSelf = true; AccessHash = None }
        let first = serializeWithTlUser user 223
        let second = serializeWithTlUser user 223
        equals first second

    [<Test>]
    member _.``Bot user is deterministic - layer 223``() =
        let user = { basicUser with IsBot = true; BotInfoVersion = Some 3 }
        let first = serializeWithTlUser user 223
        let second = serializeWithTlUser user 223
        equals first second

    [<Test>]
    member _.``Bot user is deterministic - layer 216``() =
        let user = { basicUser with IsBot = true; BotInfoVersion = Some 3 }
        let first = serializeWithTlUser user 216
        let second = serializeWithTlUser user 216
        equals first second

    [<Test>]
    member _.``User with photo is deterministic - layer 223``() =
        let user: TlUser = {
            basicUser with
                Photo = Some { PhotoId = 999L; StrippedThumb = None; DcId = 2 }
        }
        let first = serializeWithTlUser user 223
        let second = serializeWithTlUser user 223
        equals first second

    [<Test>]
    member _.``User with status online is deterministic - layer 223``() =
        let user = { basicUser with Status = Some(TlUserStatus.Online 1710000000) }
        let first = serializeWithTlUser user 223
        let second = serializeWithTlUser user 223
        equals first second

    [<Test>]
    member _.``User with status offline is deterministic - layer 216``() =
        let user = { basicUser with Status = Some(TlUserStatus.Offline 1709999000) }
        let first = serializeWithTlUser user 216
        let second = serializeWithTlUser user 216
        equals first second

    [<Test>]
    member _.``User with status recently is deterministic - layer 223``() =
        let user = { basicUser with Status = Some(TlUserStatus.Recently false) }
        let first = serializeWithTlUser user 223
        let second = serializeWithTlUser user 223
        equals first second

    [<Test>]
    member _.``Minimal user (no optional fields) is deterministic - layer 223``() =
        let user: TlUser = {
            UserId = 1L
            AccessHash = None
            FirstName = "X"
            LastName = None
            Username = None
            Phone = None
            IsSelf = false
            IsBot = false
            BotInfoVersion = None
            Photo = None
            Status = None
        }
        let first = serializeWithTlUser user 223
        let second = serializeWithTlUser user 223
        equals first second

    [<Test>]
    member _.``Minimal user (no optional fields) is deterministic - layer 216``() =
        let user: TlUser = {
            UserId = 1L
            AccessHash = None
            FirstName = "X"
            LastName = None
            Username = None
            Phone = None
            IsSelf = false
            IsBot = false
            BotInfoVersion = None
            Photo = None
            Status = None
        }
        let first = serializeWithTlUser user 216
        let second = serializeWithTlUser user 216
        equals first second

    [<Test>]
    member _.``Full user (all fields) is deterministic - layer 223``() =
        let user: TlUser = {
            UserId = 777L
            AccessHash = Some 88888L
            FirstName = "Bob"
            LastName = Some "Jones"
            Username = Some "bobjones"
            Phone = Some "+9876543210"
            IsSelf = true
            IsBot = true
            BotInfoVersion = Some 5
            Photo = Some { PhotoId = 12345L; StrippedThumb = None; DcId = 3 }
            Status = Some(TlUserStatus.Online 1710001000)
        }
        let first = serializeWithTlUser user 223
        let second = serializeWithTlUser user 223
        equals first second

    [<Test>]
    member _.``Layer 216 and 223 both emit flags2 (same length, different CID)``() =
        let layer216 = serializeWithTlUser basicUser 216
        let layer223 = serializeWithTlUser basicUser 223
        // Both layers emit flags2, so same length (only CID differs)
        equals layer223.Length layer216.Length

    [<Test>]
    member _.``Layer 222 is deterministic``() =
        let first = serializeWithTlUser basicUser 222
        let second = serializeWithTlUser basicUser 222
        equals first second
