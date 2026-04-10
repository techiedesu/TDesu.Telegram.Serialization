namespace TDesu.Serialization

/// Utility TL serialization functions (vector header only — all types migrated to GeneratedTlTypes.g.fs).
module TlWriters =

    /// Write vector header (constructor + count).
    let writeVectorHeader (w: TlWriteBuffer) (count: int) =
        w.WriteConstructorId(GeneratedCid.VectorCid)
        w.WriteInt32(count)

/// Response envelope helpers for common composite TL responses.
/// These prevent field-order bugs in frequently used wrapper types.
[<AutoOpen>]
module ResponseEnvelopes =

    /// Empty vector writer — `TlWriters.writeVectorHeader w 0`.
    let noItems (w: TlWriteBuffer) = TlWriters.writeVectorHeader w 0

    /// Serialize `updates#ed18c118` envelope.
    /// Each lambda writes its vector (header + items). Use `noItems` for empty vectors.
    let updatesResponse
        (writeUpdates: TlWriteBuffer -> unit)
        (writeUsers: TlWriteBuffer -> unit)
        (writeChats: TlWriteBuffer -> unit)
        (date: int) (seq: int) : byte[] =
        tl {
            cid GeneratedCid.Updates
            write writeUpdates
            write writeUsers
            write writeChats
            int32 date
            int32 seq
        }

    /// Serialize empty `updates` (no updates/users/chats).
    let emptyUpdates (date: int) (seq: int) : byte[] =
        updatesResponse noItems noItems noItems date seq

    /// Serialize `updates` with one update, no users/chats.
    let singleUpdateResponse (writeUpdate: TlWriteBuffer -> unit) (date: int) (seq: int) : byte[] =
        updatesResponse
            (fun w -> TlWriters.writeVectorHeader w 1; writeUpdate w)
            noItems noItems date seq

    // ── messages.messages#1d73e7ea ──────────────────────────────
    // messages:Vector<Message> topics:Vector<ForumTopic> chats:Vector<Chat> users:Vector<User>

    /// Serialize `messages.messages` envelope. Each lambda writes its vector (header + items).
    let messagesResponse
        (writeMessages: TlWriteBuffer -> unit)
        (writeTopics: TlWriteBuffer -> unit)
        (writeChats: TlWriteBuffer -> unit)
        (writeUsers: TlWriteBuffer -> unit) : byte[] =
        tl {
            cid GeneratedCid.Messages
            write writeMessages
            write writeTopics
            write writeChats
            write writeUsers
        }

    /// Empty messages.messages (4 empty vectors).
    let emptyMessages () : byte[] =
        messagesResponse noItems noItems noItems noItems

    /// Serialize messages.messagesSlice with total count (for pagination).
    let messagesSliceResponse (count: int)
        (writeMessages: TlWriteBuffer -> unit)
        (writeTopics: TlWriteBuffer -> unit)
        (writeChats: TlWriteBuffer -> unit)
        (writeUsers: TlWriteBuffer -> unit) : byte[] =
        tl {
            cid GeneratedCid.MessagesSlice
            int32 0
            int32 count
            write writeMessages
            write writeTopics
            write writeChats
            write writeUsers
        }

    // ── messages.channelMessages ────────────────────────────────
    // flags:# inexact:flags.1?true pts:int count:int offsetIdOffset:flags.2?int
    // messages:Vector<Message> topics:Vector<ForumTopic> chats:Vector<Chat> users:Vector<User>

    /// Serialize `messages.channelMessages` envelope.
    let channelMessagesResponse (pts: int) (count: int)
        (writeMessages: TlWriteBuffer -> unit)
        (writeChats: TlWriteBuffer -> unit)
        (writeUsers: TlWriteBuffer -> unit) : byte[] =
        tl {
            cid GeneratedCid.MessagesChannelMessages
            int32 0 // flags
            int32 pts
            int32 count
            write writeMessages
            write noItems // topics
            write writeChats
            write writeUsers
        }

    // ── messages.chats#64ff9fd5 ─────────────────────────────────
    // chats:Vector<Chat>

    /// Serialize `messages.chats` envelope.
    let messagesChatsResponse (writeChats: TlWriteBuffer -> unit) : byte[] =
        tl { cid GeneratedCid.MessagesChats; write writeChats }

    // ── messages.dialogs#15ba6c40 ──────────────────────────────
    // dialogs:Vector<Dialog> messages:Vector<Message> chats:Vector<Chat> users:Vector<User>

    /// Serialize `messages.dialogs` envelope.
    let dialogsResponse
        (writeDialogs: TlWriteBuffer -> unit)
        (writeMessages: TlWriteBuffer -> unit)
        (writeChats: TlWriteBuffer -> unit)
        (writeUsers: TlWriteBuffer -> unit) : byte[] =
        tl {
            cid GeneratedCid.MessagesDialogs
            write writeDialogs
            write writeMessages
            write writeChats
            write writeUsers
        }

    // ── messages.peerDialogs#3407e51b ──────────────────────────
    // dialogs + messages + chats + users + state

    /// Serialize `messages.peerDialogs` envelope.
    let peerDialogsResponse
        (writeDialogs: TlWriteBuffer -> unit)
        (writeMessages: TlWriteBuffer -> unit)
        (writeChats: TlWriteBuffer -> unit)
        (writeUsers: TlWriteBuffer -> unit)
        (writeState: TlWriteBuffer -> unit) : byte[] =
        tl {
            cid GeneratedCid.MessagesPeerDialogs
            write writeDialogs
            write writeMessages
            write writeChats
            write writeUsers
            write writeState
        }

    // ── auth.authorization#2ea2c0d4 ────────────────────────────
    // flags:# ... user:User

    /// Serialize `auth.authorization` envelope (flags=0 + user).
    let authAuthorizationResponse (writeUser: TlWriteBuffer -> unit) : byte[] =
        tl {
            cid GeneratedCid.AuthAuthorization
            int32 0 // flags
            write writeUser
        }

    // ── contacts.found ─────────────────────────────────────────
    // my_results:Vector<Peer> results:Vector<Peer> chats:Vector<Chat> users:Vector<User>

    // ── Zero-copy variants: write directly to target buffer ────

    /// Write `updates` envelope directly to buffer (zero-copy).
    let writeUpdatesTo (w: TlWriteBuffer)
        (writeUpdates: TlWriteBuffer -> unit)
        (writeUsers: TlWriteBuffer -> unit)
        (writeChats: TlWriteBuffer -> unit)
        (date: int) (seq: int) =
        w.WriteConstructorId(GeneratedCid.Updates)
        writeUpdates w
        writeUsers w
        writeChats w
        w.WriteInt32(date)
        w.WriteInt32(seq)

    /// Write `messages.messages` directly to buffer (zero-copy).
    let writeMessagesTo (w: TlWriteBuffer)
        (writeMessages: TlWriteBuffer -> unit)
        (writeTopics: TlWriteBuffer -> unit)
        (writeChats: TlWriteBuffer -> unit)
        (writeUsers: TlWriteBuffer -> unit) =
        w.WriteConstructorId(GeneratedCid.Messages)
        writeMessages w
        writeTopics w
        writeChats w
        writeUsers w

    /// Serialize `contacts.found` envelope.
    let contactsFoundResponse
        (writeMyResults: TlWriteBuffer -> unit)
        (writeResults: TlWriteBuffer -> unit)
        (writeChats: TlWriteBuffer -> unit)
        (writeUsers: TlWriteBuffer -> unit) : byte[] =
        tl {
            cid GeneratedCid.ContactsFound
            write writeMyResults
            write writeResults
            write writeChats
            write writeUsers
        }
