using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PatchCustomerError : ApiError
{
    private readonly Optional<PatchCustomerException1> _patchCustomerException1Value;

    private readonly Optional<PatchCustomerException21> _patchCustomerException21Value;

    private readonly Optional<PatchCustomerException31> _patchCustomerException31Value;

    private readonly Optional<PatchCustomerException41> _patchCustomerException41Value;

    private readonly Optional<PatchCustomerException51> _patchCustomerException51Value;

    private readonly Optional<PatchCustomerException61> _patchCustomerException61Value;

    private readonly Optional<PatchCustomerException71> _patchCustomerException71Value;

    private PatchCustomerError(Optional<PatchCustomerException1> patchCustomerException1Value,
        Optional<PatchCustomerException21> patchCustomerException21Value,
        Optional<PatchCustomerException31> patchCustomerException31Value,
        Optional<PatchCustomerException41> patchCustomerException41Value,
        Optional<PatchCustomerException51> patchCustomerException51Value,
        Optional<PatchCustomerException61> patchCustomerException61Value,
        Optional<PatchCustomerException71> patchCustomerException71Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _patchCustomerException1Value = patchCustomerException1Value;
        _patchCustomerException21Value = patchCustomerException21Value;
        _patchCustomerException31Value = patchCustomerException31Value;
        _patchCustomerException41Value = patchCustomerException41Value;
        _patchCustomerException51Value = patchCustomerException51Value;
        _patchCustomerException61Value = patchCustomerException61Value;
        _patchCustomerException71Value = patchCustomerException71Value;
    }

    private static PatchCustomerError AsPatchCustomerException1(PatchCustomerException1 value) =>
        new(Optional<PatchCustomerException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchCustomerError AsPatchCustomerException21(PatchCustomerException21 value) =>
        new(default,
            Optional<PatchCustomerException21>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchCustomerError AsPatchCustomerException31(PatchCustomerException31 value) =>
        new(default,
            default,
            Optional<PatchCustomerException31>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PatchCustomerError AsPatchCustomerException41(PatchCustomerException41 value) =>
        new(default,
            default,
            default,
            Optional<PatchCustomerException41>.Some(value),
            default,
            default,
            default,
            default);

    private static PatchCustomerError AsPatchCustomerException51(PatchCustomerException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<PatchCustomerException51>.Some(value),
            default,
            default,
            default);

    private static PatchCustomerError AsPatchCustomerException61(PatchCustomerException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<PatchCustomerException61>.Some(value),
            default,
            default);

    private static PatchCustomerError AsPatchCustomerException71(PatchCustomerException71 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<PatchCustomerException71>.Some(value),
            default);

    private static PatchCustomerError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPatchCustomerException1(out PatchCustomerException1 value) =>
        _patchCustomerException1Value.TryGetValue(out value);

    public bool TryGetPatchCustomerException21(out PatchCustomerException21 value) =>
        _patchCustomerException21Value.TryGetValue(out value);

    public bool TryGetPatchCustomerException31(out PatchCustomerException31 value) =>
        _patchCustomerException31Value.TryGetValue(out value);

    public bool TryGetPatchCustomerException41(out PatchCustomerException41 value) =>
        _patchCustomerException41Value.TryGetValue(out value);

    public bool TryGetPatchCustomerException51(out PatchCustomerException51 value) =>
        _patchCustomerException51Value.TryGetValue(out value);

    public bool TryGetPatchCustomerException61(out PatchCustomerException61 value) =>
        _patchCustomerException61Value.TryGetValue(out value);

    public bool TryGetPatchCustomerException71(out PatchCustomerException71 value) =>
        _patchCustomerException71Value.TryGetValue(out value);

    internal static Task<PatchCustomerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PatchCustomerException1>(response, ct).As(AsPatchCustomerException1),
            403 => FromJson<PatchCustomerException21>(response, ct).As(AsPatchCustomerException21),
            404 => FromJson<PatchCustomerException31>(response, ct).As(AsPatchCustomerException31),
            410 => FromJson<PatchCustomerException41>(response, ct).As(AsPatchCustomerException41),
            412 => FromJson<PatchCustomerException51>(response, ct).As(AsPatchCustomerException51),
            424 => FromJson<PatchCustomerException61>(response, ct).As(AsPatchCustomerException61),
            500 => FromJson<PatchCustomerException71>(response, ct).As(AsPatchCustomerException71),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchCustomerErrorResponse : IErrorResponse<PatchCustomerError>
{
    public static PatchCustomerErrorResponse Instance { get; } = new();

    private PatchCustomerErrorResponse()
    {
    }

    public Task<PatchCustomerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PatchCustomerError.Create(response, ct);
}
