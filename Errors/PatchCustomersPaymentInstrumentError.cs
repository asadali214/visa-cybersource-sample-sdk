using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PatchCustomersPaymentInstrumentError : ApiError
{
    private readonly Optional<PatchCustomersPaymentInstrumentException1> _patchCustomersPaymentInstrumentException1Value;

    private readonly Optional<PatchCustomersPaymentInstrumentException21> _patchCustomersPaymentInstrumentException21Value;

    private readonly Optional<PatchCustomersPaymentInstrumentException31> _patchCustomersPaymentInstrumentException31Value;

    private readonly Optional<PatchCustomersPaymentInstrumentException41> _patchCustomersPaymentInstrumentException41Value;

    private readonly Optional<PatchCustomersPaymentInstrumentException51> _patchCustomersPaymentInstrumentException51Value;

    private readonly Optional<PatchCustomersPaymentInstrumentException61> _patchCustomersPaymentInstrumentException61Value;

    private readonly Optional<PatchCustomersPaymentInstrumentException71> _patchCustomersPaymentInstrumentException71Value;

    private PatchCustomersPaymentInstrumentError(Optional<PatchCustomersPaymentInstrumentException1> patchCustomersPaymentInstrumentException1Value,
        Optional<PatchCustomersPaymentInstrumentException21> patchCustomersPaymentInstrumentException21Value,
        Optional<PatchCustomersPaymentInstrumentException31> patchCustomersPaymentInstrumentException31Value,
        Optional<PatchCustomersPaymentInstrumentException41> patchCustomersPaymentInstrumentException41Value,
        Optional<PatchCustomersPaymentInstrumentException51> patchCustomersPaymentInstrumentException51Value,
        Optional<PatchCustomersPaymentInstrumentException61> patchCustomersPaymentInstrumentException61Value,
        Optional<PatchCustomersPaymentInstrumentException71> patchCustomersPaymentInstrumentException71Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _patchCustomersPaymentInstrumentException1Value = patchCustomersPaymentInstrumentException1Value;
        _patchCustomersPaymentInstrumentException21Value = patchCustomersPaymentInstrumentException21Value;
        _patchCustomersPaymentInstrumentException31Value = patchCustomersPaymentInstrumentException31Value;
        _patchCustomersPaymentInstrumentException41Value = patchCustomersPaymentInstrumentException41Value;
        _patchCustomersPaymentInstrumentException51Value = patchCustomersPaymentInstrumentException51Value;
        _patchCustomersPaymentInstrumentException61Value = patchCustomersPaymentInstrumentException61Value;
        _patchCustomersPaymentInstrumentException71Value = patchCustomersPaymentInstrumentException71Value;
    }

    private static PatchCustomersPaymentInstrumentError AsPatchCustomersPaymentInstrumentException1(PatchCustomersPaymentInstrumentException1 value) =>
        new(Optional<PatchCustomersPaymentInstrumentException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchCustomersPaymentInstrumentError AsPatchCustomersPaymentInstrumentException21(PatchCustomersPaymentInstrumentException21 value) =>
        new(default,
            Optional<PatchCustomersPaymentInstrumentException21>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchCustomersPaymentInstrumentError AsPatchCustomersPaymentInstrumentException31(PatchCustomersPaymentInstrumentException31 value) =>
        new(default,
            default,
            Optional<PatchCustomersPaymentInstrumentException31>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PatchCustomersPaymentInstrumentError AsPatchCustomersPaymentInstrumentException41(PatchCustomersPaymentInstrumentException41 value) =>
        new(default,
            default,
            default,
            Optional<PatchCustomersPaymentInstrumentException41>.Some(value),
            default,
            default,
            default,
            default);

    private static PatchCustomersPaymentInstrumentError AsPatchCustomersPaymentInstrumentException51(PatchCustomersPaymentInstrumentException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<PatchCustomersPaymentInstrumentException51>.Some(value),
            default,
            default,
            default);

    private static PatchCustomersPaymentInstrumentError AsPatchCustomersPaymentInstrumentException61(PatchCustomersPaymentInstrumentException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<PatchCustomersPaymentInstrumentException61>.Some(value),
            default,
            default);

    private static PatchCustomersPaymentInstrumentError AsPatchCustomersPaymentInstrumentException71(PatchCustomersPaymentInstrumentException71 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<PatchCustomersPaymentInstrumentException71>.Some(value),
            default);

    private static PatchCustomersPaymentInstrumentError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPatchCustomersPaymentInstrumentException1(out PatchCustomersPaymentInstrumentException1 value) =>
        _patchCustomersPaymentInstrumentException1Value.TryGetValue(out value);

    public bool TryGetPatchCustomersPaymentInstrumentException21(out PatchCustomersPaymentInstrumentException21 value) =>
        _patchCustomersPaymentInstrumentException21Value.TryGetValue(out value);

    public bool TryGetPatchCustomersPaymentInstrumentException31(out PatchCustomersPaymentInstrumentException31 value) =>
        _patchCustomersPaymentInstrumentException31Value.TryGetValue(out value);

    public bool TryGetPatchCustomersPaymentInstrumentException41(out PatchCustomersPaymentInstrumentException41 value) =>
        _patchCustomersPaymentInstrumentException41Value.TryGetValue(out value);

    public bool TryGetPatchCustomersPaymentInstrumentException51(out PatchCustomersPaymentInstrumentException51 value) =>
        _patchCustomersPaymentInstrumentException51Value.TryGetValue(out value);

    public bool TryGetPatchCustomersPaymentInstrumentException61(out PatchCustomersPaymentInstrumentException61 value) =>
        _patchCustomersPaymentInstrumentException61Value.TryGetValue(out value);

    public bool TryGetPatchCustomersPaymentInstrumentException71(out PatchCustomersPaymentInstrumentException71 value) =>
        _patchCustomersPaymentInstrumentException71Value.TryGetValue(out value);

    internal static Task<PatchCustomersPaymentInstrumentError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PatchCustomersPaymentInstrumentException1>(response, ct).As(AsPatchCustomersPaymentInstrumentException1),
            403 => FromJson<PatchCustomersPaymentInstrumentException21>(response, ct).As(AsPatchCustomersPaymentInstrumentException21),
            404 => FromJson<PatchCustomersPaymentInstrumentException31>(response, ct).As(AsPatchCustomersPaymentInstrumentException31),
            410 => FromJson<PatchCustomersPaymentInstrumentException41>(response, ct).As(AsPatchCustomersPaymentInstrumentException41),
            412 => FromJson<PatchCustomersPaymentInstrumentException51>(response, ct).As(AsPatchCustomersPaymentInstrumentException51),
            424 => FromJson<PatchCustomersPaymentInstrumentException61>(response, ct).As(AsPatchCustomersPaymentInstrumentException61),
            500 => FromJson<PatchCustomersPaymentInstrumentException71>(response, ct).As(AsPatchCustomersPaymentInstrumentException71),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchCustomersPaymentInstrumentErrorResponse : IErrorResponse<PatchCustomersPaymentInstrumentError>
{
    public static PatchCustomersPaymentInstrumentErrorResponse Instance { get; } = new();

    private PatchCustomersPaymentInstrumentErrorResponse()
    {
    }

    public Task<PatchCustomersPaymentInstrumentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PatchCustomersPaymentInstrumentError.Create(response, ct);
}
