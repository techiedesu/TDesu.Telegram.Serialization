# TDesu.Telegram.Serialization

[![NuGet](https://img.shields.io/nuget/v/TDesu.Telegram.Serialization.svg)](https://www.nuget.org/packages/TDesu.Telegram.Serialization)
[![License: Unlicense](https://img.shields.io/badge/License-Unlicense-blue.svg)](https://unlicense.org)

Pure runtime primitives for Telegram's [TL (Type Language)](https://core.telegram.org/mtproto/TL-tl) wire format: a pooled write buffer and a bounds-checked reader over `byte[]`. No reflection, no runtime codegen, no schema dependency.

The library is intentionally schema-agnostic. To get types for specific TL constructors,
run [`td-tl-gen`](https://github.com/techiedesu/TDesu.Telegram.MTProto) against your own
schema + overrides TOML and commit the result into your own project.

> **0.4.0 (breaking)** dropped `IDisposable` from `TlReadBuffer` and removed the `tl {}` /
> `tlPooled {}` / `tlInto {}` computation expression, `PooledBytes`, `DetachBuffer`,
> `StreamPosition` and `PatchInt32` — none had a consumer, and the computation expression's own
> README examples did not compile. See [`RELEASE_NOTES.md`](RELEASE_NOTES.md) for the full list
> and the migration.
>
> **0.3.0 (breaking)** removed the schema-pinned `Generated*.g.fs` artifacts that
> 0.2.0 included as a transitional layer. See [`RELEASE_NOTES.md`](RELEASE_NOTES.md) for that
> migration.

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
w.WriteRawBytes([| 1uy; 2uy |])                       // byte[] overload
w.WriteRawBytes(ReadOnlySpan<byte>(someBuffer, 4, 8))  // ReadOnlySpan<byte> overload — no copy

let bytes = w.ToArray()      // copy out
let span = w.WrittenSpan     // zero-copy read
```

Also: `WriteInt128`, `WriteInt256`, `WriteDouble`, `WriteVector`.

`WriteBytes` and `WriteString` raise `ArgumentException` for a length of 2<sup>24</sup> bytes or
more — the extended length header only has 24 bits, so anything at or past that boundary cannot
be encoded and is rejected rather than silently wrapped.

## TlReadBuffer

Stateful reader over a `byte[]`, or a bounded view over part of one. Not `IDisposable` — it owns
no resource to release.

```fsharp
let reader = TlReadBuffer(bytes)             // the whole array
let view   = TlReadBuffer(bytes, 4, 16)      // a bounds-checked view: bytes[4 .. 19]

let cid = reader.ReadConstructorId()
let value = reader.ReadInt32()
let name = reader.ReadString()               // decodes straight from the span, no byte[] copy
let data = reader.ReadBytes()

reader.Position   // 0-based within this reader's own view; range-checked on assignment
reader.Length     // this view's logical length
reader.Remaining  // bytes left to read in this view
reader.HasMore    // Remaining > 0
reader.Skip(n)
```

Zero-copy helpers, for a caller that wants to forward or hash bytes rather than own a copy:

```fsharp
let span  = reader.ReadSpan(16)   // ReadOnlySpan<byte> over the next 16 bytes; no allocation
let inner = reader.Slice(32)      // a second TlReadBuffer over the same array, next 32 bytes;
                                   //   advances `reader` past them
```

Peeking at the next constructor id without consuming it — for dispatching on a union's cid
before choosing which `Deserialize` to call:

```fsharp
let cid = reader.PeekConstructorId()          // bounded: raises if fewer than 4 bytes remain
match reader.TryPeekConstructorId() with      // ValueNone instead of raising
| ValueSome cid -> // enough bytes to decide
| ValueNone -> // not a full frame yet
```

Every read that finds the buffer too short, or an unrecognised bool/vector constructor id,
raises `TlFormatException` — one exception type for "this input is malformed," instead of the
`ArgumentOutOfRangeException`/`IndexOutOfRangeException`/`InvalidOperationException` mix earlier
versions raised depending which method you called. A bad argument to the reader's own API (a
negative `Position`, an out-of-range `(data, offset, count)`) is a separate concern and still
raises `ArgumentException`/`ArgumentOutOfRangeException`, because that is the caller misusing the
type rather than Telegram sending something malformed.

## Vector header

`TlWriters.writeVectorHeader` is the only auxiliary helper. Use it when emitting
a TL `Vector<T>` payload by hand.

```fsharp
TlWriters.writeVectorHeader w 3       // writes 0x1cb5c415u + count(3)
for item in items do writeItem w item
```

## TlConstants

The wire-format literals both buffers use — public since 0.4.0 so a consumer that needs the
vector or bool constructor ids does not have to retype them:

```fsharp
TlConstants.BoolTrue             // 0x997275b5u
TlConstants.BoolFalse            // 0xbc799737u
TlConstants.VectorConstructorId  // 0x1cb5c415u
TlConstants.MaxByteLength        // 16777216 (2^24) — one past the largest length WriteBytes/WriteString can encode
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

- [TDesu.FSharp](https://github.com/techiedesu/TDesu.FSharp) (>= 2.0.0) — `Guard` for argument
  validation, `Bytes`/`ArrayPool` from `TDesu.FSharp.Buffers` for the pooled-buffer plumbing.
- No other dependencies

## Building

```sh
dotnet build
dotnet test
```

## License

[Unlicense](LICENSE)
