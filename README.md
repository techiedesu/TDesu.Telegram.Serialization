# TDesu.Telegram.Serialization

[![NuGet](https://img.shields.io/nuget/v/TDesu.Telegram.Serialization.svg)](https://www.nuget.org/packages/TDesu.Telegram.Serialization)
[![License: Unlicense](https://img.shields.io/badge/License-Unlicense-blue.svg)](https://unlicense.org)

Binary serialization library for Telegram's [TL (Type Language)](https://core.telegram.org/mtproto/TL-tl) wire format. Zero-copy pooled buffers, computation expression builder, and generated TL types for the pinned schema layer.

No reflection. No code generation at runtime. Just structs, spans, and `ArrayPool`.

> **0.2.0 (breaking)** removed the project-specific helpers that shipped in 0.1.0
> (`TlParsers`, `WriteDefaults`, `TypedResponses`, `ResponseEnvelopes`). See
> [`RELEASE_NOTES.md`](RELEASE_NOTES.md) for the migration list. Future releases
> will continue narrowing the scope to pure generic primitives.

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

## Vector header

Use `TlWriters.writeVectorHeader` when emitting a TL `Vector<T>` payload by hand
instead of constructing the constructor + count yourself.

```fsharp
TlWriters.writeVectorHeader w 3       // writes 0x1cb5c415u + count(3)
for item in items do writeItem w item
```

## Shared types

Domain types used by the generated TL artifacts (and re-exposed for consumers that
want to construct them directly):

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

## Generated code

The library currently includes generated code from a pinned TL schema layer
(produced by [td-tl-gen](https://github.com/techiedesu/TDesu.Telegram.MTProto)):

| File | Description |
|------|-------------|
| `GeneratedCid.g.fs` | Constructor ID constants (`GeneratedCid.BoolTrue`, etc.) |
| `GeneratedTlTypes.g.fs` | Layer-aware serialization types (TlUser, TlMessage, TlChat) |
| `GeneratedTlRequests.g.fs` | Request/response types with `Serialize`/`Deserialize` |
| `GeneratedTlWriters.g.fs` | Writer DUs and record params for response construction |
| `GeneratedReturnTypes.g.fs` | CID -> return type mapping |
| `GeneratedCoverageValidator.g.fs` | Handler coverage checker |
| `GeneratedLayerAliases.g.fs` | Layer 223 <-> 216 CID aliases |

These artifacts will move out of this package in a future release. Plan to either
generate them yourself via `td-tl-gen --overrides your-config.toml` or depend on a
forthcoming `TDesu.Telegram.Serialization.Schema` package.

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
