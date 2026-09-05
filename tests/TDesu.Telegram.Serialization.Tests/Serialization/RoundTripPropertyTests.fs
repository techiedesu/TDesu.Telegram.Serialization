namespace TDesu.Serialization.Tests

open System.Text
open FsCheck
open FsCheck.FSharp
open NUnit.Framework
open TDesu.Serialization

/// <summary>
/// FsCheck round-trip properties for the two variable-length TL encodings.
/// </summary>
/// <remarks>
/// 0.3.2 had no generative coverage at all: every test enumerated its own bytes by hand, so a
/// boundary nobody thought to write by hand had no test defending it. These run 300 random
/// cases per property (FsCheck's default is 100), sized up to 300 elements/characters so the
/// generator itself regularly crosses the 254-byte extended-length threshold, on top of the
/// exact boundary examples in <c>TlReadBufferTests</c>/<c>TlWriteBufferTests</c>.
/// </remarks>
[<TestFixture>]
type RoundTripPropertyTests() =

    let config = Config.QuickThrowOnFailure.WithMaxTest(300).WithEndSize(300)

    /// `Encoding.UTF8.GetBytes` replaces an unpaired UTF-16 surrogate with U+FFFD, so a .NET
    /// string containing one cannot round-trip through any UTF-8 encoding — not something
    /// `WriteString`/`ReadString` can fix, just the boundary of what the encoding can represent.
    /// The property is scoped to strings the encoding can actually carry.
    let isUtf8RoundTrippable (s: string) =
        not (isNull s) && Encoding.UTF8.GetString(Encoding.UTF8.GetBytes s) = s

    [<Test>]
    member _.``WriteBytes then ReadBytes returns the original bytes``() =
        let prop (bytes: byte[]) =
            not (isNull bytes)
            ==> lazy
                (use w = new TlWriteBuffer()
                 w.WriteBytes(bytes)
                 let r = new TlReadBuffer(w.ToArray())
                 r.ReadBytes() = bytes)

        Check.One(config, prop)

    [<Test>]
    member _.``WriteString then ReadString returns the original string``() =
        let prop (s: string) =
            isUtf8RoundTrippable s
            ==> lazy
                (use w = new TlWriteBuffer()
                 w.WriteString(s)
                 let r = new TlReadBuffer(w.ToArray())
                 r.ReadString() = s)

        Check.One(config, prop)

    [<Test>]
    member _.``WriteBytes then ReadBytes leaves nothing else in the buffer``() =
        let prop (bytes: byte[]) (tail: int32) =
            not (isNull bytes)
            ==> lazy
                (use w = new TlWriteBuffer()
                 w.WriteBytes(bytes)
                 w.WriteInt32(tail) // a second field must survive right after the padding
                 let r = new TlReadBuffer(w.ToArray())
                 let roundTripped = r.ReadBytes()
                 roundTripped = bytes && r.ReadInt32() = tail && not r.HasMore)

        Check.One(config, prop)
