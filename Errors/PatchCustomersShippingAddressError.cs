using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PatchCustomersShippingAddressError : ApiError
{
    private readonly Optional<PatchCustomersShippingAddressException1> _patchCustomersShippingAddressException1Value;

    private readonly Optional<PatchCustomersShippingAddressException21> _patchCustomersShippingAddressException21Value;

    private readonly Optional<PatchCustomersShippingAddressException31> _patchCustomersShippingAddressException31Value;

    private readonly Optional<PatchCustomersShippingAddressException41> _patchCustomersShippingAddressException41Value;

    private readonly Optional<PatchCustomersShippingAddressException51> _patchCustomersShippingAddressException51Value;

    private readonly Optional<PatchCustomersShippingAddressException61> _patchCustomersShippingAddressException61Value;

    private readonly Optional<PatchCustomersShippingAddressException71> _patchCustomersShippingAddressException71Value;

    private PatchCustomersShippingAddressError(Optional<PatchCustomersShippingAddressException1> patchCustomersShippingAddressException1Value,
        Optional<PatchCustomersShippingAddressException21> patchCustomersShippingAddressException21Value,
        Optional<PatchCustomersShippingAddressException31> patchCustomersShippingAddressException31Value,
        Optional<PatchCustomersShippingAddressException41> patchCustomersShippingAddressException41Value,
        Optional<PatchCustomersShippingAddressException51> patchCustomersShippingAddressException51Value,
        Optional<PatchCustomersShippingAddressException61> patchCustomersShippingAddressException61Value,
        Optional<PatchCustomersShippingAddressException71> patchCustomersShippingAddressException71Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _patchCustomersShippingAddressException1Value = patchCustomersShippingAddressException1Value;
        _patchCustomersShippingAddressException21Value = patchCustomersShippingAddressException21Value;
        _patchCustomersShippingAddressException31Value = patchCustomersShippingAddressException31Value;
        _patchCustomersShippingAddressException41Value = patchCustomersShippingAddressException41Value;
        _patchCustomersShippingAddressException51Value = patchCustomersShippingAddressException51Value;
        _patchCustomersShippingAddressException61Value = patchCustomersShippingAddressException61Value;
        _patchCustomersShippingAddressException71Value = patchCustomersShippingAddressException71Value;
    }

    private static PatchCustomersShippingAddressError AsPatchCustomersShippingAddressException1(PatchCustomersShippingAddressException1 value) =>
        new(Optional<PatchCustomersShippingAddressException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchCustomersShippingAddressError AsPatchCustomersShippingAddressException21(PatchCustomersShippingAddressException21 value) =>
        new(default,
            Optional<PatchCustomersShippingAddressException21>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static PatchCustomersShippingAddressError AsPatchCustomersShippingAddressException31(PatchCustomersShippingAddressException31 value) =>
        new(default,
            default,
            Optional<PatchCustomersShippingAddressException31>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PatchCustomersShippingAddressError AsPatchCustomersShippingAddressException41(PatchCustomersShippingAddressException41 value) =>
        new(default,
            default,
            default,
            Optional<PatchCustomersShippingAddressException41>.Some(value),
            default,
            default,
            default,
            default);

    private static PatchCustomersShippingAddressError AsPatchCustomersShippingAddressException51(PatchCustomersShippingAddressException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<PatchCustomersShippingAddressException51>.Some(value),
            default,
            default,
            default);

    private static PatchCustomersShippingAddressError AsPatchCustomersShippingAddressException61(PatchCustomersShippingAddressException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<PatchCustomersShippingAddressException61>.Some(value),
            default,
            default);

    private static PatchCustomersShippingAddressError AsPatchCustomersShippingAddressException71(PatchCustomersShippingAddressException71 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<PatchCustomersShippingAddressException71>.Some(value),
            default);

    private static PatchCustomersShippingAddressError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPatchCustomersShippingAddressException1(out PatchCustomersShippingAddressException1 value) =>
        _patchCustomersShippingAddressException1Value.TryGetValue(out value);

    public bool TryGetPatchCustomersShippingAddressException21(out PatchCustomersShippingAddressException21 value) =>
        _patchCustomersShippingAddressException21Value.TryGetValue(out value);

    public bool TryGetPatchCustomersShippingAddressException31(out PatchCustomersShippingAddressException31 value) =>
        _patchCustomersShippingAddressException31Value.TryGetValue(out value);

    public bool TryGetPatchCustomersShippingAddressException41(out PatchCustomersShippingAddressException41 value) =>
        _patchCustomersShippingAddressException41Value.TryGetValue(out value);

    public bool TryGetPatchCustomersShippingAddressException51(out PatchCustomersShippingAddressException51 value) =>
        _patchCustomersShippingAddressException51Value.TryGetValue(out value);

    public bool TryGetPatchCustomersShippingAddressException61(out PatchCustomersShippingAddressException61 value) =>
        _patchCustomersShippingAddressException61Value.TryGetValue(out value);

    public bool TryGetPatchCustomersShippingAddressException71(out PatchCustomersShippingAddressException71 value) =>
        _patchCustomersShippingAddressException71Value.TryGetValue(out value);

    internal static Task<PatchCustomersShippingAddressError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PatchCustomersShippingAddressException1>(response, ct).As(AsPatchCustomersShippingAddressException1),
            403 => FromJson<PatchCustomersShippingAddressException21>(response, ct).As(AsPatchCustomersShippingAddressException21),
            404 => FromJson<PatchCustomersShippingAddressException31>(response, ct).As(AsPatchCustomersShippingAddressException31),
            410 => FromJson<PatchCustomersShippingAddressException41>(response, ct).As(AsPatchCustomersShippingAddressException41),
            412 => FromJson<PatchCustomersShippingAddressException51>(response, ct).As(AsPatchCustomersShippingAddressException51),
            424 => FromJson<PatchCustomersShippingAddressException61>(response, ct).As(AsPatchCustomersShippingAddressException61),
            500 => FromJson<PatchCustomersShippingAddressException71>(response, ct).As(AsPatchCustomersShippingAddressException71),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchCustomersShippingAddressErrorResponse : IErrorResponse<PatchCustomersShippingAddressError>
{
    public static PatchCustomersShippingAddressErrorResponse Instance { get; } = new();

    private PatchCustomersShippingAddressErrorResponse()
    {
    }

    public Task<PatchCustomersShippingAddressError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PatchCustomersShippingAddressError.Create(response, ct);
}
