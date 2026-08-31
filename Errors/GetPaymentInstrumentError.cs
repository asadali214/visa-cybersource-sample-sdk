using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetPaymentInstrumentError : ApiError
{
    private readonly Optional<GetPaymentInstrumentException1> _getPaymentInstrumentException1Value;

    private readonly Optional<GetPaymentInstrumentException21> _getPaymentInstrumentException21Value;

    private readonly Optional<GetPaymentInstrumentException31> _getPaymentInstrumentException31Value;

    private readonly Optional<GetPaymentInstrumentException41> _getPaymentInstrumentException41Value;

    private readonly Optional<GetPaymentInstrumentException51> _getPaymentInstrumentException51Value;

    private readonly Optional<GetPaymentInstrumentException61> _getPaymentInstrumentException61Value;

    private GetPaymentInstrumentError(Optional<GetPaymentInstrumentException1> getPaymentInstrumentException1Value,
        Optional<GetPaymentInstrumentException21> getPaymentInstrumentException21Value,
        Optional<GetPaymentInstrumentException31> getPaymentInstrumentException31Value,
        Optional<GetPaymentInstrumentException41> getPaymentInstrumentException41Value,
        Optional<GetPaymentInstrumentException51> getPaymentInstrumentException51Value,
        Optional<GetPaymentInstrumentException61> getPaymentInstrumentException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getPaymentInstrumentException1Value = getPaymentInstrumentException1Value;
        _getPaymentInstrumentException21Value = getPaymentInstrumentException21Value;
        _getPaymentInstrumentException31Value = getPaymentInstrumentException31Value;
        _getPaymentInstrumentException41Value = getPaymentInstrumentException41Value;
        _getPaymentInstrumentException51Value = getPaymentInstrumentException51Value;
        _getPaymentInstrumentException61Value = getPaymentInstrumentException61Value;
    }

    private static GetPaymentInstrumentError AsGetPaymentInstrumentException1(GetPaymentInstrumentException1 value) =>
        new(Optional<GetPaymentInstrumentException1>.Some(value), default, default, default, default, default, default);

    private static GetPaymentInstrumentError AsGetPaymentInstrumentException21(GetPaymentInstrumentException21 value) =>
        new(default, Optional<GetPaymentInstrumentException21>.Some(value), default, default, default, default, default);

    private static GetPaymentInstrumentError AsGetPaymentInstrumentException31(GetPaymentInstrumentException31 value) =>
        new(default, default, Optional<GetPaymentInstrumentException31>.Some(value), default, default, default, default);

    private static GetPaymentInstrumentError AsGetPaymentInstrumentException41(GetPaymentInstrumentException41 value) =>
        new(default, default, default, Optional<GetPaymentInstrumentException41>.Some(value), default, default, default);

    private static GetPaymentInstrumentError AsGetPaymentInstrumentException51(GetPaymentInstrumentException51 value) =>
        new(default, default, default, default, Optional<GetPaymentInstrumentException51>.Some(value), default, default);

    private static GetPaymentInstrumentError AsGetPaymentInstrumentException61(GetPaymentInstrumentException61 value) =>
        new(default, default, default, default, default, Optional<GetPaymentInstrumentException61>.Some(value), default);

    private static GetPaymentInstrumentError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetPaymentInstrumentException1(out GetPaymentInstrumentException1 value) =>
        _getPaymentInstrumentException1Value.TryGetValue(out value);

    public bool TryGetGetPaymentInstrumentException21(out GetPaymentInstrumentException21 value) =>
        _getPaymentInstrumentException21Value.TryGetValue(out value);

    public bool TryGetGetPaymentInstrumentException31(out GetPaymentInstrumentException31 value) =>
        _getPaymentInstrumentException31Value.TryGetValue(out value);

    public bool TryGetGetPaymentInstrumentException41(out GetPaymentInstrumentException41 value) =>
        _getPaymentInstrumentException41Value.TryGetValue(out value);

    public bool TryGetGetPaymentInstrumentException51(out GetPaymentInstrumentException51 value) =>
        _getPaymentInstrumentException51Value.TryGetValue(out value);

    public bool TryGetGetPaymentInstrumentException61(out GetPaymentInstrumentException61 value) =>
        _getPaymentInstrumentException61Value.TryGetValue(out value);

    internal static Task<GetPaymentInstrumentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetPaymentInstrumentException1>(response, ct).As(AsGetPaymentInstrumentException1),
            403 => FromJson<GetPaymentInstrumentException21>(response, ct).As(AsGetPaymentInstrumentException21),
            404 => FromJson<GetPaymentInstrumentException31>(response, ct).As(AsGetPaymentInstrumentException31),
            410 => FromJson<GetPaymentInstrumentException41>(response, ct).As(AsGetPaymentInstrumentException41),
            424 => FromJson<GetPaymentInstrumentException51>(response, ct).As(AsGetPaymentInstrumentException51),
            500 => FromJson<GetPaymentInstrumentException61>(response, ct).As(AsGetPaymentInstrumentException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPaymentInstrumentErrorResponse : IErrorResponse<GetPaymentInstrumentError>
{
    public static GetPaymentInstrumentErrorResponse Instance { get; } = new();

    private GetPaymentInstrumentErrorResponse()
    {
    }

    public Task<GetPaymentInstrumentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPaymentInstrumentError.Create(response, ct);
}
