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
`samples/SedBotOverrides/sedbot-overrides.toml` in the
[TDesu.Telegram.MTProto](https://github.com/techiedesu/TDesu.Telegram.MTProto)
repo as a worked example for a Telegram server with dual-layer support.

If you depended on `TlSharedTypes` (`PeerType`, `MediaInfo`, etc.), copy the
file from the v0.2.0 git history into your own project — they're SedBot
domain types, not generic TL primitives.

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

Initial release. Extracted from SedBot MTProto server.

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
