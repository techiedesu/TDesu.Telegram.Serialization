## 0.4.1

**`Tl.build`/`Tl.bytesOf` replace the three-line dance every generated `Serialize` call site was
repeating.** Every consumer of a generated TL type ended up writing
`use w = new TlWriteBuffer()` / `X.Serialize(w, v)` / `w.ToArray()` at each of its own request
sites — one project counted 11 copies of exactly that, plus a private SRTP helper reproducing
`bytesOf`, because this package provided the pooled buffer but never the pattern of using one and
giving it back. `Tl.build write` runs `write` against a fresh pooled writer and returns
`ToArray()`, disposing the writer (`use`) whether or not `write` throws. `Tl.bytesOf value` is
`build (fun w -> T.Serialize(w, value))` for `value`'s own type, picked up via an SRTP constraint
(`static member Serialize: TlWriteBuffer * ^T -> unit`) rather than an interface, since generated
TL types share no common base to implement one against.

### Added
- `Tl.build (write: TlWriteBuffer -> unit) : byte[]`
- `Tl.bytesOf (value: ^T) : byte[]` — inline, constrained to `^T` having a static `Serialize`

## 0.4.0

**Every malformed read now raises one exception, and reading no longer requires an unused
`IDisposable`.** `TlReadBuffer` mixed `ArgumentOutOfRangeException` (the shared bounds check in
`take`), `IndexOutOfRangeException` (`ReadBytes`'s own unchecked prefix read) and
`InvalidOperationException` (`ReadBool`/`ReadVector`) for the same underlying problem — a length,
count or constructor id the buffer cannot honour — so a caller could not catch "this frame is
malformed" in one place. `ReadBytes` also advanced `Position` past its length prefix *before*
validating the payload length, so a short buffer left the cursor mid-value instead of where the
read began, and the padding skip that followed a successful read had no bound at all. Both are
fixed together: one `TlFormatException` for every malformed read, and `ReadBytes` restores
`Position` on failure with its padding skip going through the same bounds check as everything
else.

`TlReadBuffer` also drops `IDisposable` — its `Dispose()` was empty, and it forced
`use r = new TlReadBuffer(...)` at all 52 call sites the audit counted across the two consumers,
for a type that owns no resource to release.

### Added
- `TlReadBuffer(data, offset, count)` — a bounds-checked view over part of an existing array,
  instead of every nested TL payload being sliced into a fresh one first
- `TlReadBuffer.Slice(count)` — a second reader over the *same* array, advancing this one past it
- `TlReadBuffer.ReadSpan(count)` — the next `count` bytes as a `ReadOnlySpan<byte>`, no allocation
- `TlReadBuffer.PeekConstructorId()` / `TryPeekConstructorId()` — read the next constructor id
  without consuming it, bounded (the first raises, the second returns `ValueNone`); five call
  sites across the two consumers were hand-rolling this with `BitConverter`, two of them inside
  the client that forbids exactly that
- `TlReadBuffer.Remaining` — bytes left in this reader's view
- `TlWriteBuffer.WriteRawBytes(ReadOnlySpan<byte>)` alongside the existing `byte[]` overload
- `TlConstants` is now public, so the vector/bool constructor ids and the new
  `TlConstants.MaxByteLength` have one canonical source instead of being retyped at call sites
  outside this assembly

### Changed
- `TlReadBuffer.ReadString` decodes straight from the span instead of allocating a `byte[]` via
  `ReadBytes` first — `Encoding.UTF8.GetString(ReadOnlySpan<byte>)` has been available since
  netstandard2.1, which this package already targets
- `TlReadBuffer.Position`'s setter is range-checked (`[0, Length]`) — an out-of-range value used
  to reopen the truncation `take` exists to prevent, by making the remaining-bytes computation
  wrong
- `TlWriteBuffer.WriteString` is rewritten: 0.3.2 rented a pool buffer for every string under 256
  UTF-8 bytes purely to hold the encoded bytes long enough to copy them a second time, and its
  long-form branch (kept for a string whose encoding needed more than that) was dead code —
  `GetMaxByteCount` only exceeds 256 past 84 three-byte UTF-8 characters, 252 encoded bytes,
  still under the rental cap. `GetByteCount` sizes the header once and `GetBytes` encodes
  straight into the buffer, and the header-writing logic is now shared with `WriteBytes` instead
  of duplicated
- `TlWriteBuffer.WriteBytes`/`WriteString` raise `ArgumentException` for a length of 2^24 bytes or
  more instead of silently wrapping the 24-bit length field
- Buffers returned to `ArrayPool` are cleared (`clearArray: true`) — a buffer a writer just grew
  away from, or disposed, can still hold a session key or a plaintext body from whatever was
  serialised into it
- `TDesu.FSharp` bumped to 2.0.0. `Guard` replaces the hand-written argument checks (constructor
  bounds, `Position`'s range, the length guards); `Bytes.slice` from `TDesu.FSharp.Buffers`
  replaces the F# array-slice copy in every variable-length read; `ArrayPool.rentBytes` replaces
  the direct `ArrayPool<byte>.Shared.Rent` calls

### Removed
- `TlReadBuffer : IDisposable` — see above
- `TlBuilder.fs` in full: the `tl { }` / `tlPooled { }` / `tlInto { }` computation expression,
  `PooledBytes`, `DetachBuffer`, `StreamPosition`, `PatchInt32`. None had a consumer in the
  MTProto client or TeleEye (counted), the README's own `tlPooled { … }` / `tlInto w { … }`
  examples could not compile (`tl`'s custom operations build an action list; `Run` returns
  `byte[]`, so the list value the CE's `Yield` produces was never reachable through them), and
  `PooledBytes.Return` was a double-return footgun advertised as the headline feature

### Migration
- `use r = new TlReadBuffer(...)` becomes `let r = new TlReadBuffer(...)` — the type no longer
  needs disposing
- A `tl { }` block becomes the same calls against a `TlWriteBuffer` directly: `flags`/`flagsEnd`/
  `optX` become an `if`/`match` around the flags `int32` and each optional field's own `WriteX`
  call, matching how the mandatory fields were already written

### Tests
- A round-trip property test (FsCheck) for `WriteBytes`/`ReadBytes` and `WriteString`/`ReadString`
  against random input, sized so the generator regularly crosses the 254-byte extended-length
  threshold, plus exact examples at that threshold and at the 2^24 length-guard boundary on both
  sides. `TlBuilderTests` (16 tests) is gone with `TlBuilder.fs`; the suite now also covers the
  `(data, offset, count)` view, `Slice`, `ReadSpan`, `Peek`/`TryPeekConstructorId`, and that every
  malformed read raises `TlFormatException` and nothing else. 40 tests to 50

## 0.3.2

**A short buffer now raises instead of reading back truncated.** F# array slicing clamps an
out-of-range slice rather than throwing, and every variable-length read in `TlReadBuffer` was a
slice: a TL `bytes` declaring 10 over a 3-byte tail returned those 3 bytes with the cursor at 12 of
4, `ReadInt256` over 31 bytes returned 31, and `ReadRawBytes(-3)` returned nothing and moved the
cursor *backwards* — all measured against 0.3.1. Nothing downstream can tell such a value from a real
one, which is how a truncated frame becomes a wrong auth key or an empty file reference instead of
an error.

`ReadBytes`, `ReadRawBytes`, `ReadInt128`, `ReadInt256` and `Skip` now go through one bounds check
and raise `ArgumentOutOfRangeException` naming the count, the position and the buffer length, with
the cursor left where it was. The fixed-width reads were already safe: `ReadOnlySpan(data, pos, n)`
validates its own range. Reaching exactly the end stays allowed. Pinned by four tests that fail
against the unfixed buffer.

Also: a `nuget.config` pinning nuget.org as the only source — with central package management,
a user-level config listing several feeds fails the restore with NU1507 — and `global.json` rolls
forward to the latest 10.0 feature band, matching the `10.0.x` CI uses.

## 0.3.1

**`ReadVector` rejects a count the buffer cannot hold.** A TL element is never smaller than 4 bytes,
so a declared count above `remaining / 4` cannot be honest; it now raises before `Array.init`
allocates for it. Measured: 200,000,000 declared elements over a 12-byte body allocated ~1.5 GiB
before failing on 0.3.0.

## 0.3.0

**Breaking changes** — removes the schema-pinned generated code that 0.2.0
shipped as a transitional layer. The library is now a pure runtime: binary
buffers, the `tl {}` computation expression, and a vector header writer.
Nothing in the package depends on a specific Telegram TL schema.

### Removed

- **`Generated*.g.fs`** (~22 000 LOC) — the entire pinned schema artifact set
  that 0.2.0 included as a transitional compatibility layer. These were
  always project-specific (a particular whitelist + extras + dual-layer policy)
  dressed up as a generic library.
  - `GeneratedCid.g.fs` — constructor ID literals
  - `GeneratedTlTypes.g.fs` — TlUser / TlMessage / TlChat per-layer serializers
    (the hand-written half) and request types (the auto-generated half)
  - `GeneratedTlRequests.g.fs` — Request DUs (`MessagesSendMessage`, etc.)
  - `GeneratedTlWriters.g.fs` — Write DUs (`WritePhoneCall`, `WriteUpdate`, etc.)
  - `GeneratedCoverageValidator.g.fs`
  - `GeneratedReturnTypes.g.fs`
  - `GeneratedLayerAliases.g.fs`
- **`TlSharedTypes.fs`** — `PeerType`, `MediaInfo`, `DocumentAttribute`,
  `UserStatus`. These were referenced by the hand-written part of
  `GeneratedTlTypes.fs`, so they're entangled with the generated artifacts and
  follow them out.
- Tests for the removed types (`TlMessageTests`, `TlUserTests`, `TlChatTests`,
  `TlRoundTripTests`, `GeneratedRoundTripTests`).

### Migration

Run `td-tl-gen` (0.1.0+) against your own TL schema and overrides TOML to
produce the artifacts you need:

```sh
td-tl-gen --schema cached/api.tl --mtproto-schema cached/mtproto.tl \
          --output ./MyProject/Generated --namespace MyProject.Serialization \
          --overrides my-overrides.toml --target cid types writers
```

Commit the generated `.g.fs` files into your project. Use
`samples/ServerOverrides/server-overrides.toml` in the
[TDesu.Telegram.MTProto](https://github.com/techiedesu/TDesu.Telegram.MTProto)
repo as a worked example for a Telegram server with dual-layer support.

If you depended on `TlSharedTypes` (`PeerType`, `MediaInfo`, etc.), copy the
file from the v0.2.0 git history into your own project — they're one
server's domain types, not generic TL primitives.

### Kept

The library is now ~600 LOC of pure runtime:

- `TlReadBuffer` / `TlWriteBuffer` — pooled binary primitives
- `TlBuilder` — `tl {}` / `tlPooled {}` / `tlInto {}` computation expression
- `TlWriters.writeVectorHeader` — the only generic helper, self-contained

Tests: 35 across primitives, vector, and the builder CE.

---

## 0.2.0

**Breaking changes** — removes consumer-specific helpers that were embedded in the
0.1.0 release. The library now ships only generic primitives plus generated TL types
for the pinned schema layer. Project-specific helpers must be implemented in the
consuming project.

### Removed (consumers must relocate or replace)

- `TlParsers` module (`readInputPeer`, `readInputReplyTo`, `readInputFile`,
  `readSendMessage`, `readGetHistory`, `readSendMedia`) and the `Parsed*` value types
  (`ParsedInputPeer`, `ParsedReplyTo`, `ParsedSendMessage`, `ParsedGetHistory`,
  `ParsedSendMedia`, `ParsedInputFile`, `ParsedInputMedia`). These were server-side
  handler parsers tied to a specific feature set, not generic serialization.

- `WriteDefaults` module (`defaultWriteUser`, `defaultWriteMessage`,
  `defaultWriteMessageService`, `defaultWriteDialog`, `defaultWriteNotifySettings`)
  and converters (`writePeerFromType`, `writeReplyTo`, `writeReplyToWithTopic`,
  `writeMediaFromInfo`, `writePhotoFromTuple`, `writeStatusFromTlStatus`,
  `writeChatPhotoFromTuple`, `writeMessageFromTlMessage`, `simpleChat`,
  `simpleChannel`, `serializeMessageFwdHeader`, `rpcError`). These hardcode the
  field set of one specific schema layer; any schema bump silently broke them.

- `TypedResponses` module (`boolTrue`, `boolFalse`, `boolResponse`, `updatesTooLong`).
  Trivial helpers that consumers can re-implement in two lines.

- `ResponseEnvelopes` module from `TlWriters.fs` (`updatesResponse`, `emptyUpdates`,
  `singleUpdateResponse`, `messagesResponse`, `emptyMessages`, `messagesSliceResponse`,
  `channelMessagesResponse`, `messagesChatsResponse`, `dialogsResponse`,
  `peerDialogsResponse`, `authAuthorizationResponse`, `contactsFoundResponse`,
  `writeUpdatesTo`, `writeMessagesTo`). Server-side response envelope helpers.

### Migration

If you were using these APIs in 0.1.0, copy the source files into your own project.
The 0.1.0 source is available in the git history at tag `v0.1.0`. Adjust namespaces
as needed; everything was previously under `namespace TDesu.Serialization`.

### Kept

- `TlWriteBuffer`, `TlReadBuffer`, `TlBuilder` (`tl {}` / `tlPooled {}` / `tlInto {}`)
  — generic binary primitives, unchanged.
- `TlSharedTypes`: `PeerType`, `UserStatus`, `MediaInfo`, `DocumentAttribute` —
  these are referenced by the generated TL types and remain part of the public surface.
- `TlWriters.writeVectorHeader` — the only remaining helper, now self-contained
  (uses the literal vector CID instead of `GeneratedCid.VectorCid`).
- All `Generated*.g.fs` artifacts — pinned to schema layer 223 for now. A future
  release will move them to a separate package or require consumers to run
  `td-tl-gen` themselves.

### Notes

- The 0.2.0 series is still pre-1.0; further breaking changes are expected as the
  separation between generic primitives and pinned generated code is finalised.

---

## 0.1.0

Initial release. Extracted from a Telegram MTProto server implementation.

### Core
- TlWriteBuffer: pooled resizable write buffer (ArrayPool-backed)
- TlReadBuffer: stateful binary reader
- TlBuilder: `tl {}` / `tlPooled {}` / `tlInto {}` computation expressions with flag support
- PooledBytes: zero-copy struct for short-lived serialized data

### Parsers
- TlParsers: readInputPeer, readInputReplyTo, readInputFile, readSendMessage, readGetHistory, readSendMedia

### Response Envelopes
- updatesResponse, emptyUpdates, singleUpdateResponse
- messagesResponse, emptyMessages, messagesSliceResponse, channelMessagesResponse
- dialogsResponse, peerDialogsResponse, authAuthorizationResponse, contactsFoundResponse
- rpcError
- Zero-copy variants: writeUpdatesTo, writeMessagesTo

### Types
- PeerType, UserStatus, MediaInfo, DocumentAttribute
- WriteDefaults: defaultWriteUser, defaultWriteMessage, defaultWriteDialog
- Converters: writePeerFromType, writeReplyTo, writeMediaFromInfo, etc.

### Generated Code
- GeneratedCid, GeneratedTlTypes, GeneratedTlRequests, GeneratedTlWriters
- GeneratedReturnTypes, GeneratedCoverageValidator, GeneratedLayerAliases
