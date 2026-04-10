namespace TDesu.Serialization

/// Peer type for message serialization.
[<Struct>]
type PeerType =
    | PeerTypeUser
    | PeerTypeChat
    | PeerTypeChannel

/// Document attribute attached to a document media.
[<RequireQualifiedAccess>]
type DocumentAttribute =
    /// documentAttributeFilename#15590068 file_name:string
    | Filename of fileName: string
    /// documentAttributeImageSize#6c37c15c w:int h:int
    | ImageSize of w: int * h: int
    /// documentAttributeVideo#43c57c48 flags:# round_message:flags.0?true supports_streaming:flags.1?true nosound:flags.3?true duration:double w:int h:int preload_prefix_size:flags.2?int video_codec:flags.5?string
    | Video of duration: float * w: int * h: int * roundMessage: bool * supportsStreaming: bool
    /// documentAttributeAudio#9852f9c6 flags:# voice:flags.10?true duration:int title:flags.0?string performer:flags.1?string waveform:flags.2?bytes
    | Audio of duration: int * title: string option * performer: string option * voice: bool * waveform: byte[] option
    /// documentAttributeSticker#6319d612 flags:# mask:flags.1?true alt:string stickerset:InputStickerSet mask_coords:flags.0?MaskCoords
    | Sticker of alt: string
    /// documentAttributeAnimated#11b58939
    | Animated
    /// documentAttributeHasStickers#9801d2f7
    | HasStickers

/// Media info attached to a message.
[<RequireQualifiedAccess>]
type MediaInfo =
    | Photo of photoId: int64 * accessHash: int64 * dcId: int * width: int * height: int * size: int
    | Document of docId: int64 * accessHash: int64 * dcId: int * mime: string * size: int64 * name: string * attributes: DocumentAttribute list
    | Poll of pollId: int64 * pollBytes: byte[] * resultsBytes: byte[]
    | Geo of lat: float * lon: float
    | GeoLive of lat: float * lon: float * period: int * heading: int
    | Venue of lat: float * lon: float * title: string * address: string * provider: string * venueId: string * venueType: string
    | Empty

/// User online status for TL serialization.
[<RequireQualifiedAccess>]
type UserStatus =
    /// userStatusOnline#edb93949 expires:int
    | Online of expires: int
    /// userStatusOffline#008c703f was_online:int
    | Offline of wasOnline: int
    /// userStatusRecently#7b197dc8 flags:# by_me:flags.0?true
    | Recently
    /// userStatusLastWeek#541f1b21 flags:# by_me:flags.0?true
    | LastWeek
    /// userStatusLastMonth#65899777 flags:# by_me:flags.0?true
    | LastMonth

