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
