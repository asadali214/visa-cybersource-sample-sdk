using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetCustomerPaymentInstrumentError : ApiError
{
    private readonly Optional<GetCustomerPaymentInstrumentException1> _getCustomerPaymentInstrumentException1Value;

    private readonly Optional<GetCustomerPaymentInstrumentException21> _getCustomerPaymentInstrumentException21Value;

    private readonly Optional<GetCustomerPaymentInstrumentException31> _getCustomerPaymentInstrumentException31Value;

    private readonly Optional<GetCustomerPaymentInstrumentException41> _getCustomerPaymentInstrumentException41Value;

    private readonly Optional<GetCustomerPaymentInstrumentException51> _getCustomerPaymentInstrumentException51Value;

    private readonly Optional<GetCustomerPaymentInstrumentException61> _getCustomerPaymentInstrumentException61Value;

    private GetCustomerPaymentInstrumentError(Optional<GetCustomerPaymentInstrumentException1> getCustomerPaymentInstrumentException1Value,
        Optional<GetCustomerPaymentInstrumentException21> getCustomerPaymentInstrumentException21Value,
        Optional<GetCustomerPaymentInstrumentException31> getCustomerPaymentInstrumentException31Value,
        Optional<GetCustomerPaymentInstrumentException41> getCustomerPaymentInstrumentException41Value,
        Optional<GetCustomerPaymentInstrumentException51> getCustomerPaymentInstrumentException51Value,
        Optional<GetCustomerPaymentInstrumentException61> getCustomerPaymentInstrumentException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getCustomerPaymentInstrumentException1Value = getCustomerPaymentInstrumentException1Value;
        _getCustomerPaymentInstrumentException21Value = getCustomerPaymentInstrumentException21Value;
        _getCustomerPaymentInstrumentException31Value = getCustomerPaymentInstrumentException31Value;
        _getCustomerPaymentInstrumentException41Value = getCustomerPaymentInstrumentException41Value;
        _getCustomerPaymentInstrumentException51Value = getCustomerPaymentInstrumentException51Value;
        _getCustomerPaymentInstrumentException61Value = getCustomerPaymentInstrumentException61Value;
    }

    private static GetCustomerPaymentInstrumentError AsGetCustomerPaymentInstrumentException1(GetCustomerPaymentInstrumentException1 value) =>
        new(Optional<GetCustomerPaymentInstrumentException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static GetCustomerPaymentInstrumentError AsGetCustomerPaymentInstrumentException21(GetCustomerPaymentInstrumentException21 value) =>
        new(default,
            Optional<GetCustomerPaymentInstrumentException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetCustomerPaymentInstrumentError AsGetCustomerPaymentInstrumentException31(GetCustomerPaymentInstrumentException31 value) =>
        new(default,
            default,
            Optional<GetCustomerPaymentInstrumentException31>.Some(value),
            default,
            default,
            default,
            default);

    private static GetCustomerPaymentInstrumentError AsGetCustomerPaymentInstrumentException41(GetCustomerPaymentInstrumentException41 value) =>
        new(default,
            default,
            default,
            Optional<GetCustomerPaymentInstrumentException41>.Some(value),
            default,
            default,
            default);

    private static GetCustomerPaymentInstrumentError AsGetCustomerPaymentInstrumentException51(GetCustomerPaymentInstrumentException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<GetCustomerPaymentInstrumentException51>.Some(value),
            default,
            default);

    private static GetCustomerPaymentInstrumentError AsGetCustomerPaymentInstrumentException61(GetCustomerPaymentInstrumentException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<GetCustomerPaymentInstrumentException61>.Some(value),
            default);

    private static GetCustomerPaymentInstrumentError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetCustomerPaymentInstrumentException1(out GetCustomerPaymentInstrumentException1 value) =>
        _getCustomerPaymentInstrumentException1Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentException21(out GetCustomerPaymentInstrumentException21 value) =>
        _getCustomerPaymentInstrumentException21Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentException31(out GetCustomerPaymentInstrumentException31 value) =>
        _getCustomerPaymentInstrumentException31Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentException41(out GetCustomerPaymentInstrumentException41 value) =>
        _getCustomerPaymentInstrumentException41Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentException51(out GetCustomerPaymentInstrumentException51 value) =>
        _getCustomerPaymentInstrumentException51Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentException61(out GetCustomerPaymentInstrumentException61 value) =>
        _getCustomerPaymentInstrumentException61Value.TryGetValue(out value);

    internal static Task<GetCustomerPaymentInstrumentError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetCustomerPaymentInstrumentException1>(response, ct).As(AsGetCustomerPaymentInstrumentException1),
            403 => FromJson<GetCustomerPaymentInstrumentException21>(response, ct).As(AsGetCustomerPaymentInstrumentException21),
            404 => FromJson<GetCustomerPaymentInstrumentException31>(response, ct).As(AsGetCustomerPaymentInstrumentException31),
            410 => FromJson<GetCustomerPaymentInstrumentException41>(response, ct).As(AsGetCustomerPaymentInstrumentException41),
            424 => FromJson<GetCustomerPaymentInstrumentException51>(response, ct).As(AsGetCustomerPaymentInstrumentException51),
            500 => FromJson<GetCustomerPaymentInstrumentException61>(response, ct).As(AsGetCustomerPaymentInstrumentException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCustomerPaymentInstrumentErrorResponse : IErrorResponse<GetCustomerPaymentInstrumentError>
{
    public static GetCustomerPaymentInstrumentErrorResponse Instance { get; } = new();

    private GetCustomerPaymentInstrumentErrorResponse()
    {
    }

    public Task<GetCustomerPaymentInstrumentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCustomerPaymentInstrumentError.Create(response, ct);
}
