namespace TDesu.Serialization.Tests

open System
open NUnit.Framework
open TDesu.Serialization
open TDesu.Serialization.Tests

[<TestFixture>]
type TlBuilderTests() =

    [<Test>]
    member _.``cid + int32 round-trip``() =
        let expected =
            use w = new TlWriteBuffer()
            w.WriteConstructorId(GeneratedCid.PeerUser)
            w.WriteInt32(42)
            w.ToArray()

        let actual = tl {
            cid GeneratedCid.PeerUser
            int32 42
        }

        equals actual expected

    [<Test>]
    member _.``string + bool + int64``() =
        let expected =
            use w = new TlWriteBuffer()
            w.WriteString("hello")
            w.WriteBool(true)
            w.WriteInt64(999L)
            w.ToArray()

        let actual = tl {
            string "hello"
            bool true
            int64 999L
        }

        equals actual expected

    [<Test>]
    member _.``emptyVector writes vector cid + count 0``() =
        let expected =
            use w = new TlWriteBuffer()
            w.WriteConstructorId(GeneratedCid.VectorCid)
            w.WriteInt32(0)
            w.ToArray()

        let actual = tl {
            emptyVector
        }

        equals actual expected

    [<Test>]
    member _.``flags with no optionals``() =
        let expected =
            use w = new TlWriteBuffer()
            w.WriteConstructorId(GeneratedCid.PeerUser)
            w.WriteInt32(0) // flags = 0
            w.WriteInt32(7)
            w.ToArray()

        let actual = tl {
            cid GeneratedCid.PeerUser
            flags
            optInt32 0 None
            optString 1 None
            flagsEnd
            int32 7
        }

        equals actual expected

    [<Test>]
    member _.``flags with some optionals``() =
        let expected =
            use w = new TlWriteBuffer()
            w.WriteConstructorId(GeneratedCid.PeerUser)
            let flagsValue = (1 <<< 0) ||| (1 <<< 2)
            w.WriteInt32(flagsValue)
            w.WriteInt32(42)
            w.WriteString("test")
            w.ToArray()

        let actual = tl {
            cid GeneratedCid.PeerUser
            flags
            optInt32 0 (Some 42)
            optBool 1 None
            optString 2 (Some "test")
            flagsEnd
        }

        equals actual expected

    [<Test>]
    member _.``nested flags``() =
        let expected =
            use w = new TlWriteBuffer()
            // outer flags
            let outerFlags = 1 <<< 0
            w.WriteInt32(outerFlags)
            w.WriteInt32(1)
            // inner flags
            let innerFlags = 1 <<< 1
            w.WriteInt32(innerFlags)
            w.WriteString("inner")
            w.ToArray()

        let actual = tl {
            flags
            optInt32 0 (Some 1)
            flags
            optInt32 0 None
            optString 1 (Some "inner")
            flagsEnd
            flagsEnd
        }

        equals actual expected

    [<Test>]
    member _.``flagBit unconditional``() =
        let expected =
            use w = new TlWriteBuffer()
            w.WriteInt32(1 <<< 3)
            w.ToArray()

        let actual = tl {
            flags
            flagBit 3
            flagsEnd
        }

        equals actual expected

    [<Test>]
    member _.``write delegation``() =
        let expected =
            use w = new TlWriteBuffer()
            TlWriters.writeVectorHeader w 0
            w.ToArray()

        let actual = tl {
            write (fun w -> TlWriters.writeVectorHeader w 0)
        }

        equals actual expected

    [<Test>]
    member _.``complex handler reproduction - globalPrivacySettings``() =
        let archiveAndMuteNewNoncontactPeers = true

        let expected =
            use w = new TlWriteBuffer()
            w.WriteConstructorId(0x734c4ccbu)
            let mutable flagsVal = 0
            if archiveAndMuteNewNoncontactPeers then flagsVal <- flagsVal ||| (1 <<< 0)
            w.WriteInt32(flagsVal)
            if archiveAndMuteNewNoncontactPeers then w.WriteBool(true)
            w.ToArray()

        let v = if archiveAndMuteNewNoncontactPeers then Some true else None

        let actual = tl {
            cid 0x734c4ccbu
            flags
            optBool 0 v
            flagsEnd
        }

        equals actual expected

    [<Test>]
    member _.``double and bytes primitives``() =
        let data = [| 1uy; 2uy; 3uy |]

        let expected =
            use w = new TlWriteBuffer()
            w.WriteDouble(3.14)
            w.WriteBytes(data)
            w.ToArray()

        let actual = tl {
            double 3.14
            bytes data
        }

        equals actual expected

    [<Test>]
    member _.``vector with items``() =
        let items = [| 10; 20; 30 |]

        let expected =
            use w = new TlWriteBuffer()
            w.WriteVector(items, fun w v -> w.WriteInt32(v))
            w.ToArray()

        let actual = tl {
            vector items (fun w v -> w.WriteInt32(v))
        }

        equals actual expected

    [<Test>]
    member _.``optRaw and optCid``() =
        let rawData = [| 0xAAuy; 0xBBuy |]

        let expected =
            use w = new TlWriteBuffer()
            let flagsVal = (1 <<< 0) ||| (1 <<< 2)
            w.WriteInt32(flagsVal)
            w.WriteRawBytes(rawData)
            w.WriteConstructorId(GeneratedCid.BoolTrue)
            w.ToArray()

        let actual = tl {
            flags
            optRaw 0 (Some rawData)
            optInt64 1 None
            optCid 2 (Some GeneratedCid.BoolTrue)
            flagsEnd
        }

        equals actual expected

    [<Test>]
    member _.``raw writes bytes without TL encoding``() =
        let data = [| 0xDEuy; 0xADuy; 0xBEuy; 0xEFuy |]

        let expected =
            use w = new TlWriteBuffer()
            w.WriteRawBytes(data)
            w.ToArray()

        let actual = tl {
            raw data
        }

        equals actual expected

    [<Test>]
    member _.``write with TlChat.serialize helper``() =
        let chat: TlChat = {
            ChatId = 100L; Title = "Test Chat"
            MembersCount = 3; Date = 1000; Photo = None
        }

        let expected =
            use w = new TlWriteBuffer()
            TlChat.serialize w chat
            w.ToArray()

        let actual = tl {
            write (fun w -> TlChat.serialize w chat)
        }

        equals actual expected

    [<Test>]
    member _.``multiple emptyVector calls``() =
        let expected =
            use w = new TlWriteBuffer()
            TlWriters.writeVectorHeader w 0
            TlWriters.writeVectorHeader w 0
            TlWriters.writeVectorHeader w 0
            w.ToArray()

        let actual = tl {
            emptyVector
            emptyVector
            emptyVector
        }

        equals actual expected

    [<Test>]
    member _.``mixed cid + write + int32 interleaving``() =
        let expected =
            use w = new TlWriteBuffer()
            w.WriteConstructorId(GeneratedCid.Updates)
            TlWriters.writeVectorHeader w 0
            TlWriters.writeVectorHeader w 0
            TlWriters.writeVectorHeader w 0
            w.WriteInt32(42)
            w.WriteInt32(0)
            w.ToArray()

        let actual = tl {
            cid GeneratedCid.Updates
            emptyVector
            emptyVector
            emptyVector
            int32 42
            int32 0
        }

        equals actual expected

    [<Test>]
    member _.``real handler reproduction - updatesDifferenceEmpty``() =
        let date = 1710000000
        let seq = 5

        let expected =
            use w = new TlWriteBuffer()
            w.WriteConstructorId(0x5d75a138u)
            w.WriteInt32(date)
            w.WriteInt32(seq)
            w.ToArray()

        let actual = tl {
            cid 0x5d75a138u
            int32 date
            int32 seq
        }

        equals actual expected
