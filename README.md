# TDesu.Telegram.Serialization

[![NuGet](https://img.shields.io/nuget/v/TDesu.Telegram.Serialization.svg)](https://www.nuget.org/packages/TDesu.Telegram.Serialization)
[![License: Unlicense](https://img.shields.io/badge/License-Unlicense-blue.svg)](https://unlicense.org)

Pure runtime primitives for Telegram's [TL (Type Language)](https://core.telegram.org/mtproto/TL-tl) wire format. Pooled `byte[]` buffers, a stateless reader, and a `tl {}` computation expression for ergonomic serialization. No reflection, no runtime codegen, no schema dependency.

The library is intentionally schema-agnostic. To get types for specific TL constructors,
run [`td-tl-gen`](https://github.com/techiedesu/TDesu.Telegram.MTProto) against your own
schema + overrides TOML and commit the result into your own project.

> **0.3.0 (breaking)** removed the schema-pinned `Generated*.g.fs` artifacts that
> 0.2.0 included as a transitional layer. The library is now ~600 LOC of pure
> runtime. See [`RELEASE_NOTES.md`](RELEASE_NOTES.md) for the migration guide.

## Install

```
dotnet add package TDesu.Telegram.Serialization
```

## TlWriteBuffer

Pooled, resizable write buffer backed by `ArrayPool<byte>`. `IDisposable` —
returns the buffer to the pool on dispose.

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

Also: `WriteInt128`, `WriteInt256`, `WriteDouble`, `WriteVector`, `WriteRawBytes`,
and `PatchInt32` for retroactive flag patching.

## TlReadBuffer

Stateful reader over a `byte[]`. Mirrors `TlWriteBuffer`.

```fsharp
let reader = new TlReadBuffer(bytes)
let cid = reader.ReadConstructorId()
let value = reader.ReadInt32()
let name = reader.ReadString()
let data = reader.ReadBytes()

reader.Position  // current offset
reader.HasMore   // bytes remaining?
reader.Skip(n)
```

## PooledBytes

Zero-copy `struct` for short-lived serialized data. Call `.Return()` to release.

```fsharp
let pooled = tlPooled { cid 0x997275b5u; int32 42 }
let span = pooled.Span
pooled.Return()
```

## TL Builder

Computation expression for fluent TL serialization. Handles flag computation,
optional fields, and nesting automatically.

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

Custom operations: `cid`, `int32`, `int64`, `double`, `string`, `bytes`, `bool`,
`raw`, `vector`, `emptyVector`, `flags`, `flagsEnd`, `flagBit`, `optInt32`,
`optInt64`, `optString`, `optBool`, `optRaw`, `optCid`, `write`.

## Vector header

`TlWriters.writeVectorHeader` is the only auxiliary helper. Use it when emitting
a TL `Vector<T>` payload by hand.

```fsharp
TlWriters.writeVectorHeader w 3       // writes 0x1cb5c415u + count(3)
for item in items do writeItem w item
```

## Generating schema-aware types

This package deliberately does not bundle constructor IDs, request types, or
serializer DUs — those are project-specific (which constructors? which layer?
which dual-layer aliases? which undocumented extras?). Use
[`td-tl-gen`](https://github.com/techiedesu/TDesu.Telegram.MTProto) to produce
them yourself:

```sh
dotnet tool install --global TDesu.Telegram.TL.Generator

td-tl-gen --schema cached/api.tl --mtproto-schema cached/mtproto.tl \
          --output ./MyProject/Generated --namespace MyProject.Serialization \
          --overrides my-overrides.toml \
          --target cid types writers
```

Commit the generated `.g.fs` files into your project. They reference
`TDesu.Serialization` types from this package and recompile against any version.

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
