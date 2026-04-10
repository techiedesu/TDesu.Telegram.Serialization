namespace TDesu.Serialization

/// Typed response values for TL return types.
/// Handlers return these instead of raw byte[], serialization is automatic.
[<AutoOpen>]
module TypedResponses =

    /// Bool response: boolTrue or boolFalse.
    let boolTrue : byte[] = tl { cid GeneratedCid.BoolTrue }
    let boolFalse : byte[] = tl { cid GeneratedCid.BoolFalse }

    /// Bool from condition.
    let boolResponse (value: bool) : byte[] =
        if value then boolTrue else boolFalse

    /// Serialize updates.tooLong (tells client to re-sync).
    let updatesTooLong : byte[] = tl { cid GeneratedCid.UpdatesTooLong }
