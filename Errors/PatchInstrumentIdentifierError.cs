using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PatchInstrumentIdentifierError : ApiError
{
    private readonly Optional<PatchInstrumentIdentifierException1> _patchInstrumentIdentifierException1Value;

    private readonly Optional<PatchInstrumentIdentifierException21> _patchInstrumentIdentifierException21Value;

    private readonly Optional<PatchInstrumentIdentifierException31> _patchInstrumentIdentifierException31Value;

    private readonly Optional<PatchInstrumentIdentifierException41> _patchInstrumentIdentifierException41Value;

    private readonly Optional<PatchInstrumentIdentifierException51> _patchInstrumentIdentifierException51Value;

    private readonly Optional<PatchInstrumentIdentifierException61> _patchInstrumentIdentifierException61Value;

    private readonly Optional<PatchInstrumentIdentifierException71> _patchInstrumentIdentifierException71Value;

    private PatchInstrumentIdentifierError(Optional<PatchInstrumentIdentifierException1> patchInstrumentIdentifierException1Value,
        Optional<PatchInstrumentIdentifierException21> patchInstrumentIdentifierException21Value,
        Optional<PatchInstrumentIdentifierException31> patchInstrumentIdentifierException31Value,
        Optional<PatchInstrumentIdentifierException41> patchInstrumentIdentifierException41Value,
        Optional<PatchInstrumentIdentifierException51> patchInstrumentIdentifierException51Value,
        Optional<PatchInstrumentIdentifierException61> patchInstrumentIdentifierException61Value,
        Optional<PatchInstrumentIdentifierException71> patchInstrumentIdentifierException71Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _patchInstrumentIdentifierException1Value = patchInstrumentIdentifierException1Value;
        _patchInstrumentIdentifierException21Value = patchInstrumentIdentifierException21Value;
        _patchInstrumentIdentifierException31Value = patchInstrumentIdentifierException31Value;
        _patchInstrumentIdentifierException41Value = patchInstrumentIdentifierException41Value;
        _patchInstrumentIdentifierException51Value = patchInstrumentIdentifierException51Value;
        _patchInstrumentIdentifierException61Value = patchInstrumentIdentifierException61Value;
        _patchInstrumentIdentifierException71Value = patchInstrumentIdentifierException71Value;
    }

    private static PatchInstrumentIdentifierError AsPatchInstrumentIdentifierException1(PatchInstrumentIdentifierException1 value) =>
        new(Optional<PatchInstrumentIdentifierException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchInstrumentIdentifierError AsPatchInstrumentIdentifierException21(PatchInstrumentIdentifierException21 value) =>
        new(default,
            Optional<PatchInstrumentIdentifierException21>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchInstrumentIdentifierError AsPatchInstrumentIdentifierException31(PatchInstrumentIdentifierException31 value) =>
        new(default,
            default,
            Optional<PatchInstrumentIdentifierException31>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PatchInstrumentIdentifierError AsPatchInstrumentIdentifierException41(PatchInstrumentIdentifierException41 value) =>
        new(default,
            default,
            default,
            Optional<PatchInstrumentIdentifierException41>.Some(value),
            default,
            default,
            default,
            default);

    private static PatchInstrumentIdentifierError AsPatchInstrumentIdentifierException51(PatchInstrumentIdentifierException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<PatchInstrumentIdentifierException51>.Some(value),
            default,
            default,
            default);

    private static PatchInstrumentIdentifierError AsPatchInstrumentIdentifierException61(PatchInstrumentIdentifierException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<PatchInstrumentIdentifierException61>.Some(value),
            default,
            default);

    private static PatchInstrumentIdentifierError AsPatchInstrumentIdentifierException71(PatchInstrumentIdentifierException71 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<PatchInstrumentIdentifierException71>.Some(value),
            default);

    private static PatchInstrumentIdentifierError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPatchInstrumentIdentifierException1(out PatchInstrumentIdentifierException1 value) =>
        _patchInstrumentIdentifierException1Value.TryGetValue(out value);

    public bool TryGetPatchInstrumentIdentifierException21(out PatchInstrumentIdentifierException21 value) =>
        _patchInstrumentIdentifierException21Value.TryGetValue(out value);

    public bool TryGetPatchInstrumentIdentifierException31(out PatchInstrumentIdentifierException31 value) =>
        _patchInstrumentIdentifierException31Value.TryGetValue(out value);

    public bool TryGetPatchInstrumentIdentifierException41(out PatchInstrumentIdentifierException41 value) =>
        _patchInstrumentIdentifierException41Value.TryGetValue(out value);

    public bool TryGetPatchInstrumentIdentifierException51(out PatchInstrumentIdentifierException51 value) =>
        _patchInstrumentIdentifierException51Value.TryGetValue(out value);

    public bool TryGetPatchInstrumentIdentifierException61(out PatchInstrumentIdentifierException61 value) =>
        _patchInstrumentIdentifierException61Value.TryGetValue(out value);

    public bool TryGetPatchInstrumentIdentifierException71(out PatchInstrumentIdentifierException71 value) =>
        _patchInstrumentIdentifierException71Value.TryGetValue(out value);

    internal static Task<PatchInstrumentIdentifierError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PatchInstrumentIdentifierException1>(response, ct).As(AsPatchInstrumentIdentifierException1),
            403 => FromJson<PatchInstrumentIdentifierException21>(response, ct).As(AsPatchInstrumentIdentifierException21),
            404 => FromJson<PatchInstrumentIdentifierException31>(response, ct).As(AsPatchInstrumentIdentifierException31),
            410 => FromJson<PatchInstrumentIdentifierException41>(response, ct).As(AsPatchInstrumentIdentifierException41),
            412 => FromJson<PatchInstrumentIdentifierException51>(response, ct).As(AsPatchInstrumentIdentifierException51),
            424 => FromJson<PatchInstrumentIdentifierException61>(response, ct).As(AsPatchInstrumentIdentifierException61),
            500 => FromJson<PatchInstrumentIdentifierException71>(response, ct).As(AsPatchInstrumentIdentifierException71),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchInstrumentIdentifierErrorResponse : IErrorResponse<PatchInstrumentIdentifierError>
{
    public static PatchInstrumentIdentifierErrorResponse Instance { get; } = new();

    private PatchInstrumentIdentifierErrorResponse()
    {
    }

    public Task<PatchInstrumentIdentifierError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PatchInstrumentIdentifierError.Create(response, ct);
}
