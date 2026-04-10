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
