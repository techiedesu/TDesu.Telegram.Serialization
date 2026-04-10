namespace TDesu.Serialization

open System.Collections.Generic

type FlagsHandle = { mutable Value: int; Position: int64 }

[<NoComparison; NoEquality>]
type TlBuilderState = {
    Writer: TlWriteBuffer
    mutable FlagsStack: FlagsHandle list
}

type TlBuilder() =
    member _.Yield(_) = ResizeArray<TlBuilderState -> unit>()

    [<CustomOperation("cid")>]
    member _.Cid(acts: ResizeArray<_>, id: uint32) =
        acts.Add(fun s -> s.Writer.WriteConstructorId(id))
        acts

    [<CustomOperation("int32")>]
    member _.Int32(acts: ResizeArray<_>, v: int32) =
        acts.Add(fun s -> s.Writer.WriteInt32(v))
        acts

    [<CustomOperation("int64")>]
    member _.Int64(acts: ResizeArray<_>, v: int64) =
        acts.Add(fun s -> s.Writer.WriteInt64(v))
        acts

    [<CustomOperation("double")>]
    member _.Double(acts: ResizeArray<_>, v: double) =
        acts.Add(fun s -> s.Writer.WriteDouble(v))
        acts

    [<CustomOperation("string")>]
    member _.String(acts: ResizeArray<_>, v: string) =
        acts.Add(fun s -> s.Writer.WriteString(v))
        acts

    [<CustomOperation("bytes")>]
    member _.Bytes(acts: ResizeArray<_>, v: byte[]) =
        acts.Add(fun s -> s.Writer.WriteBytes(v))
        acts

    [<CustomOperation("bool")>]
    member _.Bool(acts: ResizeArray<_>, v: bool) =
        acts.Add(fun s -> s.Writer.WriteBool(v))
        acts

    [<CustomOperation("raw")>]
    member _.Raw(acts: ResizeArray<_>, v: byte[]) =
        acts.Add(fun s -> s.Writer.WriteRawBytes(v))
        acts

    [<CustomOperation("emptyVector")>]
    member _.EmptyVector(acts: ResizeArray<_>) =
        acts.Add(fun s ->
            s.Writer.WriteConstructorId(TlConstants.VectorConstructorId)
            s.Writer.WriteInt32(0)
        )
        acts

    [<CustomOperation("vector")>]
    member _.Vector(acts: ResizeArray<_>, items: 'a[], writeItem: TlWriteBuffer -> 'a -> unit) =
        acts.Add(fun s -> s.Writer.WriteVector(items, writeItem))
        acts

    [<CustomOperation("flags")>]
    member _.Flags(acts: ResizeArray<_>) =
        acts.Add(fun s ->
            let handle = { Value = 0; Position = s.Writer.StreamPosition }
            s.FlagsStack <- handle :: s.FlagsStack
            s.Writer.WriteInt32(0)
        )
        acts

    [<CustomOperation("flagsEnd")>]
    member _.FlagsEnd(acts: ResizeArray<_>) =
        acts.Add(fun s ->
            let h = List.head s.FlagsStack
            s.Writer.PatchInt32(h.Position, h.Value)
            s.FlagsStack <- List.tail s.FlagsStack
        )
        acts

    [<CustomOperation("flagBit")>]
    member _.FlagBit(acts: ResizeArray<_>, bit: int) =
        acts.Add(fun s ->
            let h = List.head s.FlagsStack
            h.Value <- h.Value ||| (1 <<< bit)
        )
        acts

    [<CustomOperation("optInt32")>]
    member _.OptInt32(acts: ResizeArray<_>, bit: int, v: int32 option) =
        acts.Add(fun s ->
            match v with
            | Some x ->
                let h = List.head s.FlagsStack
                h.Value <- h.Value ||| (1 <<< bit)
                s.Writer.WriteInt32(x)
            | None -> ()
        )
        acts

    [<CustomOperation("optInt64")>]
    member _.OptInt64(acts: ResizeArray<_>, bit: int, v: int64 option) =
        acts.Add(fun s ->
            match v with
            | Some x ->
                let h = List.head s.FlagsStack
                h.Value <- h.Value ||| (1 <<< bit)
                s.Writer.WriteInt64(x)
            | None -> ()
        )
        acts

    [<CustomOperation("optString")>]
    member _.OptString(acts: ResizeArray<_>, bit: int, v: string option) =
        acts.Add(fun s ->
            match v with
            | Some x ->
                let h = List.head s.FlagsStack
                h.Value <- h.Value ||| (1 <<< bit)
                s.Writer.WriteString(x)
            | None -> ()
        )
        acts

    [<CustomOperation("optBool")>]
    member _.OptBool(acts: ResizeArray<_>, bit: int, v: bool option) =
        acts.Add(fun s ->
            match v with
            | Some x ->
                let h = List.head s.FlagsStack
                h.Value <- h.Value ||| (1 <<< bit)
                s.Writer.WriteBool(x)
            | None -> ()
        )
        acts

    [<CustomOperation("optRaw")>]
    member _.OptRaw(acts: ResizeArray<_>, bit: int, v: byte[] option) =
        acts.Add(fun s ->
            match v with
            | Some x ->
                let h = List.head s.FlagsStack
                h.Value <- h.Value ||| (1 <<< bit)
                s.Writer.WriteRawBytes(x)
            | None -> ()
        )
        acts

    [<CustomOperation("optCid")>]
    member _.OptCid(acts: ResizeArray<_>, bit: int, v: uint32 option) =
        acts.Add(fun s ->
            match v with
            | Some x ->
                let h = List.head s.FlagsStack
                h.Value <- h.Value ||| (1 <<< bit)
                s.Writer.WriteConstructorId(x)
            | None -> ()
        )
        acts

    [<CustomOperation("write")>]
    member _.Write(acts: ResizeArray<_>, fn: TlWriteBuffer -> unit) =
        acts.Add(fun s -> fn s.Writer)
        acts

    member _.Run(acts: ResizeArray<TlBuilderState -> unit>) =
        use w = new TlWriteBuffer()
        let state = { Writer = w; FlagsStack = [] }
        for act in acts do act state
        w.ToArray()

[<AutoOpen>]
module TlBuilderModule =
    let tl = TlBuilder()

    /// Zero-copy TL serialization — returns PooledBytes that must be Return()'d after use.
    /// Use when the result is sent to network and not stored long-term.
    let inline tlPooled (acts: ResizeArray<TlBuilderState -> unit>) =
        let w = new TlWriteBuffer()
        let state = { Writer = w; FlagsStack = [] }
        for act in acts do act state
        let (buf, len) = w.DetachBuffer()
        PooledBytes(buf, len)

    /// Write TL directly to an existing TlWriteBuffer (no allocation).
    let inline tlInto (w: TlWriteBuffer) (acts: ResizeArray<TlBuilderState -> unit>) =
        let state = { Writer = w; FlagsStack = [] }
        for act in acts do act state
