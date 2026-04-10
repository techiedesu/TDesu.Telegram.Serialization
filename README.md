# TDesu.Telegram.Serialization

[![NuGet](https://img.shields.io/nuget/v/TDesu.Telegram.Serialization.svg)](https://www.nuget.org/packages/TDesu.Telegram.Serialization)
[![License: Unlicense](https://img.shields.io/badge/License-Unlicense-blue.svg)](https://unlicense.org)

Binary serialization library for Telegram's [TL (Type Language)](https://core.telegram.org/mtproto/TL-tl) wire format. Zero-copy pooled buffers, computation expression builder, and typed parsers.

No reflection. No code generation at runtime. Just structs, spans, and `ArrayPool`.

## Install

```
dotnet add package TDesu.Telegram.Serialization
```

## Core types

### TlWriteBuffer

Pooled, resizable write buffer backed by `ArrayPool<byte>`. Implements `IDisposable` — returns the buffer to the pool on dispose.

```fsharp
open TDesu.Serialization

use w = new TlWriteBuffer()
w.WriteConstructorId(0x997275b5u) // boolTrue
w.WriteInt32(42)
w.WriteInt64(123L)
w.WriteString("hello")
w.WriteBytes([| 1uy; 2uy; 3uy |])
w.WriteBool(true)

let bytes = w.ToArray()      // copy out
let span = w.WrittenSpan     // zero-copy read
```

Supports `WriteInt128`, `WriteInt256`, `WriteDouble`, `WriteVector`, `WriteRawBytes`, and `PatchInt32` for retroactive flag patching.

### TlReadBuffer

Stateful reader over a `byte[]`. Mirrors `TlWriteBuffer` operations.

```fsharp
let reader = new TlReadBuffer(bytes)
let cid = reader.ReadConstructorId()
let value = reader.ReadInt32()
let name = reader.ReadString()
let data = reader.ReadBytes()

// Navigation
reader.Position  // current offset
reader.HasMore   // bytes remaining?
reader.Skip(n)   // skip n bytes
```

### PooledBytes

Zero-copy `struct` for short-lived serialized data. Call `.Return()` to release back to pool.

```fsharp
let pooled = tlPooled { cid 0x997275b5u; int32 42 }
let span = pooled.Span       // use the data
pooled.Return()               // release to pool
```

## TL Builder

Computation expression for fluent TL serialization. Handles flag computation, optional fields, and nesting automatically.

```fsharp
open TDesu.Serialization

// Allocating (returns byte[])
let data = tl {
    cid 0xED18C118u           // updates#ed18c118
    write writeUpdates        // delegate to lambda
    write writeUsers
    write writeChats
    int32 date
    int32 seq
}

// Zero-copy (returns PooledBytes struct)
let pooled = tlPooled {
    cid 0x997275b5u
    int32 42
}

// Into existing buffer
use w = new TlWriteBuffer()
tlInto w {
    cid 0x997275b5u
    int32 42
}
```

### Flag fields

TL flag fields (conditional serialization based on bitmask) are handled declaratively:

```fsharp
let data = tl {
    cid constructorId
    flags                       // start flags block (reserves 4 bytes)
    int32 userId
    optString firstName         // writes if Some, sets flag bit
    optString lastName
    optInt32 botInfoVersion
    flagBit hasPhoto            // bool flag (no data, just bit)
    flagsEnd                    // patches the reserved int32 with computed flags
}
```

Custom operations: `cid`, `int32`, `int64`, `double`, `string`, `bytes`, `bool`, `raw`, `vector`, `emptyVector`, `flags`, `flagsEnd`, `flagBit`, `optInt32`, `optInt64`, `optString`, `optBool`, `optRaw`, `optCid`, `write`.

## Typed parsers

Stateless parsing functions for common Telegram request types:

```fsharp
open TDesu.Serialization

// Parse InputPeer from raw bytes
let peer = TlParsers.readInputPeer reader
match peer with
| Self -> "me"
| User(userId, _) -> $"user {userId}"
| Chat(chatId) -> $"chat {chatId}"
| Channel(channelId, _) -> $"channel {channelId}"
| PeerEmpty -> "empty"
| PeerUnknown cid -> $"unknown 0x{cid:X}"

// Parse full request bodies (via generated Deserialize)
let msg = TlParsers.readSendMessage body
printfn "To: %A, Text: %s" msg.Peer msg.Message

let history = TlParsers.readGetHistory body
printfn "Peer: %A, Limit: %d" history.Peer history.Limit

let media = TlParsers.readSendMedia body
let file = TlParsers.readInputFile reader
let reply = TlParsers.readInputReplyTo reader
```

## Response envelopes

Pre-built helpers for common TL response wrappers. Prevent field-order bugs in frequently used types.

```fsharp
// Empty responses
let data = emptyUpdates date seq
let data = emptyMessages ()

// With content (each lambda writes a vector)
let data = updatesResponse writeUpdates writeUsers writeChats date seq
let data = singleUpdateResponse writeOneUpdate date seq
let data = messagesSliceResponse count writeMessages writeTopics writeChats writeUsers

// Other envelopes
let data = dialogsResponse writeDialogs writeMessages writeChats writeUsers
let data = channelMessagesResponse pts count writeMessages writeChats writeUsers
let data = authAuthorizationResponse writeUser
let data = contactsFoundResponse writeMyResults writeResults writeChats writeUsers
let data = rpcError 400 "PEER_ID_INVALID"

// Zero-copy variants (write directly to existing buffer)
writeUpdatesTo buffer writeUpdates writeUsers writeChats date seq
writeMessagesTo buffer writeMessages writeTopics writeChats writeUsers
```

## Shared types

Domain types used across serialization boundaries:

```fsharp
type PeerType = PeerTypeUser | PeerTypeChat | PeerTypeChannel

type UserStatus = Online of expires: int | Offline of wasOnline: int
               | Recently | LastWeek | LastMonth

type MediaInfo =
    | Photo of photoId: int64 * accessHash: int64 * dcId: int * width: int * height: int * size: int
    | Document of docId: int64 * accessHash: int64 * dcId: int * mime: string * size: int64 * name: string * attrs: DocumentAttribute list
    | Poll of pollId: int64 * pollBytes: byte[] * resultsBytes: byte[]
    | Geo of lat: float * lon: float
    | GeoLive of lat: float * lon: float * period: int * heading: int
    | Venue of lat: float * lon: float * title: string * address: string * provider: string * venueId: string * venueType: string
    | Empty
```

## Write defaults

Default record values for generated writer types. Use `{ defaultWriteUser with id = 42L; firstName = Some "Alice" }` to construct.

```fsharp
let user = { defaultWriteUser with id = 42L; firstName = Some "Alice" }
let msg = { defaultWriteMessage with id = 1; message = "hello"; date = now }
let dialog = { defaultWriteDialog with peer = WritePeer.PeerUser(42L); topMessage = 1 }

// Converters
let writePeer = writePeerFromType PeerTypeUser 42L
let replyTo = writeReplyTo (Some 10)
let media = writeMediaFromInfo (Some(MediaInfo.Photo(1L, 2L, 3, 640, 480, 50000)))
let photo = writePhotoFromTuple (Some(100L, 200L, 2))
let status = writeStatusFromTlStatus (Some(UserStatus.Online 1700000000))
let chatPhoto = writeChatPhotoFromTuple (Some(100L, 200L, 2))
```

## Generated code

The library includes generated code from TL schemas (produced by [td-tl-gen](https://github.com/techiedesu/TDesu.Telegram.MTProto)):

| File | Description |
|------|-------------|
| `GeneratedCid.g.fs` | Constructor ID constants (`GeneratedCid.BoolTrue`, etc.) |
| `GeneratedTlTypes.g.fs` | Layer-aware serialization types (TlUser, TlMessage, TlChat) |
| `GeneratedTlRequests.g.fs` | Request/response types with `Serialize`/`Deserialize` |
| `GeneratedTlWriters.g.fs` | Writer DUs and record params for response construction |
| `GeneratedReturnTypes.g.fs` | CID -> return type mapping |
| `GeneratedCoverageValidator.g.fs` | Handler coverage checker |
| `GeneratedLayerAliases.g.fs` | Layer 223 <-> 216 CID aliases |

## Dependencies

- [TDesu.FSharp](https://github.com/techiedesu/TDesu.FSharp) (>= 1.1.0)
- No other dependencies

## Building

```sh
dotnet build
dotnet test
```

## License

[Unlicense](LICENSE)
