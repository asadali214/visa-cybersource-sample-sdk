using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PatchPaymentInstrumentError : ApiError
{
    private readonly Optional<PatchPaymentInstrumentException1> _patchPaymentInstrumentException1Value;

    private readonly Optional<PatchPaymentInstrumentException21> _patchPaymentInstrumentException21Value;

    private readonly Optional<PatchPaymentInstrumentException31> _patchPaymentInstrumentException31Value;

    private readonly Optional<PatchPaymentInstrumentException41> _patchPaymentInstrumentException41Value;

    private readonly Optional<PatchPaymentInstrumentException51> _patchPaymentInstrumentException51Value;

    private readonly Optional<PatchPaymentInstrumentException61> _patchPaymentInstrumentException61Value;

    private readonly Optional<PatchPaymentInstrumentException71> _patchPaymentInstrumentException71Value;

    private PatchPaymentInstrumentError(Optional<PatchPaymentInstrumentException1> patchPaymentInstrumentException1Value,
        Optional<PatchPaymentInstrumentException21> patchPaymentInstrumentException21Value,
        Optional<PatchPaymentInstrumentException31> patchPaymentInstrumentException31Value,
        Optional<PatchPaymentInstrumentException41> patchPaymentInstrumentException41Value,
        Optional<PatchPaymentInstrumentException51> patchPaymentInstrumentException51Value,
        Optional<PatchPaymentInstrumentException61> patchPaymentInstrumentException61Value,
        Optional<PatchPaymentInstrumentException71> patchPaymentInstrumentException71Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _patchPaymentInstrumentException1Value = patchPaymentInstrumentException1Value;
        _patchPaymentInstrumentException21Value = patchPaymentInstrumentException21Value;
        _patchPaymentInstrumentException31Value = patchPaymentInstrumentException31Value;
        _patchPaymentInstrumentException41Value = patchPaymentInstrumentException41Value;
        _patchPaymentInstrumentException51Value = patchPaymentInstrumentException51Value;
        _patchPaymentInstrumentException61Value = patchPaymentInstrumentException61Value;
        _patchPaymentInstrumentException71Value = patchPaymentInstrumentException71Value;
    }

    private static PatchPaymentInstrumentError AsPatchPaymentInstrumentException1(PatchPaymentInstrumentException1 value) =>
        new(Optional<PatchPaymentInstrumentException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchPaymentInstrumentError AsPatchPaymentInstrumentException21(PatchPaymentInstrumentException21 value) =>
        new(default,
            Optional<PatchPaymentInstrumentException21>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchPaymentInstrumentError AsPatchPaymentInstrumentException31(PatchPaymentInstrumentException31 value) =>
        new(default,
            default,
            Optional<PatchPaymentInstrumentException31>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PatchPaymentInstrumentError AsPatchPaymentInstrumentException41(PatchPaymentInstrumentException41 value) =>
        new(default,
            default,
            default,
            Optional<PatchPaymentInstrumentException41>.Some(value),
            default,
            default,
            default,
            default);

    private static PatchPaymentInstrumentError AsPatchPaymentInstrumentException51(PatchPaymentInstrumentException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<PatchPaymentInstrumentException51>.Some(value),
            default,
            default,
            default);

    private static PatchPaymentInstrumentError AsPatchPaymentInstrumentException61(PatchPaymentInstrumentException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<PatchPaymentInstrumentException61>.Some(value),
            default,
            default);

    private static PatchPaymentInstrumentError AsPatchPaymentInstrumentException71(PatchPaymentInstrumentException71 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<PatchPaymentInstrumentException71>.Some(value),
            default);

    private static PatchPaymentInstrumentError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPatchPaymentInstrumentException1(out PatchPaymentInstrumentException1 value) =>
        _patchPaymentInstrumentException1Value.TryGetValue(out value);

    public bool TryGetPatchPaymentInstrumentException21(out PatchPaymentInstrumentException21 value) =>
        _patchPaymentInstrumentException21Value.TryGetValue(out value);

    public bool TryGetPatchPaymentInstrumentException31(out PatchPaymentInstrumentException31 value) =>
        _patchPaymentInstrumentException31Value.TryGetValue(out value);

    public bool TryGetPatchPaymentInstrumentException41(out PatchPaymentInstrumentException41 value) =>
        _patchPaymentInstrumentException41Value.TryGetValue(out value);

    public bool TryGetPatchPaymentInstrumentException51(out PatchPaymentInstrumentException51 value) =>
        _patchPaymentInstrumentException51Value.TryGetValue(out value);

    public bool TryGetPatchPaymentInstrumentException61(out PatchPaymentInstrumentException61 value) =>
        _patchPaymentInstrumentException61Value.TryGetValue(out value);

    public bool TryGetPatchPaymentInstrumentException71(out PatchPaymentInstrumentException71 value) =>
        _patchPaymentInstrumentException71Value.TryGetValue(out value);

    internal static Task<PatchPaymentInstrumentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PatchPaymentInstrumentException1>(response, ct).As(AsPatchPaymentInstrumentException1),
            403 => FromJson<PatchPaymentInstrumentException21>(response, ct).As(AsPatchPaymentInstrumentException21),
            404 => FromJson<PatchPaymentInstrumentException31>(response, ct).As(AsPatchPaymentInstrumentException31),
            410 => FromJson<PatchPaymentInstrumentException41>(response, ct).As(AsPatchPaymentInstrumentException41),
            412 => FromJson<PatchPaymentInstrumentException51>(response, ct).As(AsPatchPaymentInstrumentException51),
            424 => FromJson<PatchPaymentInstrumentException61>(response, ct).As(AsPatchPaymentInstrumentException61),
            500 => FromJson<PatchPaymentInstrumentException71>(response, ct).As(AsPatchPaymentInstrumentException71),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchPaymentInstrumentErrorResponse : IErrorResponse<PatchPaymentInstrumentError>
{
    public static PatchPaymentInstrumentErrorResponse Instance { get; } = new();

    private PatchPaymentInstrumentErrorResponse()
    {
    }

    public Task<PatchPaymentInstrumentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PatchPaymentInstrumentError.Create(response, ct);
}
