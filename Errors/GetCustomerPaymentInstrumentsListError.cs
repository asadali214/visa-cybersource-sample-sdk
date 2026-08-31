using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetCustomerPaymentInstrumentsListError : ApiError
{
    private readonly Optional<GetCustomerPaymentInstrumentsListException1> _getCustomerPaymentInstrumentsListException1Value;

    private readonly Optional<GetCustomerPaymentInstrumentsListException21> _getCustomerPaymentInstrumentsListException21Value;

    private readonly Optional<GetCustomerPaymentInstrumentsListException31> _getCustomerPaymentInstrumentsListException31Value;

    private readonly Optional<GetCustomerPaymentInstrumentsListException41> _getCustomerPaymentInstrumentsListException41Value;

    private readonly Optional<GetCustomerPaymentInstrumentsListException51> _getCustomerPaymentInstrumentsListException51Value;

    private readonly Optional<GetCustomerPaymentInstrumentsListException61> _getCustomerPaymentInstrumentsListException61Value;

    private GetCustomerPaymentInstrumentsListError(Optional<GetCustomerPaymentInstrumentsListException1> getCustomerPaymentInstrumentsListException1Value,
        Optional<GetCustomerPaymentInstrumentsListException21> getCustomerPaymentInstrumentsListException21Value,
        Optional<GetCustomerPaymentInstrumentsListException31> getCustomerPaymentInstrumentsListException31Value,
        Optional<GetCustomerPaymentInstrumentsListException41> getCustomerPaymentInstrumentsListException41Value,
        Optional<GetCustomerPaymentInstrumentsListException51> getCustomerPaymentInstrumentsListException51Value,
        Optional<GetCustomerPaymentInstrumentsListException61> getCustomerPaymentInstrumentsListException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getCustomerPaymentInstrumentsListException1Value = getCustomerPaymentInstrumentsListException1Value;
        _getCustomerPaymentInstrumentsListException21Value = getCustomerPaymentInstrumentsListException21Value;
        _getCustomerPaymentInstrumentsListException31Value = getCustomerPaymentInstrumentsListException31Value;
        _getCustomerPaymentInstrumentsListException41Value = getCustomerPaymentInstrumentsListException41Value;
        _getCustomerPaymentInstrumentsListException51Value = getCustomerPaymentInstrumentsListException51Value;
        _getCustomerPaymentInstrumentsListException61Value = getCustomerPaymentInstrumentsListException61Value;
    }

    private static GetCustomerPaymentInstrumentsListError AsGetCustomerPaymentInstrumentsListException1(GetCustomerPaymentInstrumentsListException1 value) =>
        new(Optional<GetCustomerPaymentInstrumentsListException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static GetCustomerPaymentInstrumentsListError AsGetCustomerPaymentInstrumentsListException21(GetCustomerPaymentInstrumentsListException21 value) =>
        new(default,
            Optional<GetCustomerPaymentInstrumentsListException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetCustomerPaymentInstrumentsListError AsGetCustomerPaymentInstrumentsListException31(GetCustomerPaymentInstrumentsListException31 value) =>
        new(default,
            default,
            Optional<GetCustomerPaymentInstrumentsListException31>.Some(value),
            default,
            default,
            default,
            default);

    private static GetCustomerPaymentInstrumentsListError AsGetCustomerPaymentInstrumentsListException41(GetCustomerPaymentInstrumentsListException41 value) =>
        new(default,
            default,
            default,
            Optional<GetCustomerPaymentInstrumentsListException41>.Some(value),
            default,
            default,
            default);

    private static GetCustomerPaymentInstrumentsListError AsGetCustomerPaymentInstrumentsListException51(GetCustomerPaymentInstrumentsListException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<GetCustomerPaymentInstrumentsListException51>.Some(value),
            default,
            default);

    private static GetCustomerPaymentInstrumentsListError AsGetCustomerPaymentInstrumentsListException61(GetCustomerPaymentInstrumentsListException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<GetCustomerPaymentInstrumentsListException61>.Some(value),
            default);

    private static GetCustomerPaymentInstrumentsListError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetCustomerPaymentInstrumentsListException1(out GetCustomerPaymentInstrumentsListException1 value) =>
        _getCustomerPaymentInstrumentsListException1Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentsListException21(out GetCustomerPaymentInstrumentsListException21 value) =>
        _getCustomerPaymentInstrumentsListException21Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentsListException31(out GetCustomerPaymentInstrumentsListException31 value) =>
        _getCustomerPaymentInstrumentsListException31Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentsListException41(out GetCustomerPaymentInstrumentsListException41 value) =>
        _getCustomerPaymentInstrumentsListException41Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentsListException51(out GetCustomerPaymentInstrumentsListException51 value) =>
        _getCustomerPaymentInstrumentsListException51Value.TryGetValue(out value);

    public bool TryGetGetCustomerPaymentInstrumentsListException61(out GetCustomerPaymentInstrumentsListException61 value) =>
        _getCustomerPaymentInstrumentsListException61Value.TryGetValue(out value);

    internal static Task<GetCustomerPaymentInstrumentsListError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetCustomerPaymentInstrumentsListException1>(response, ct).As(AsGetCustomerPaymentInstrumentsListException1),
            403 => FromJson<GetCustomerPaymentInstrumentsListException21>(response, ct).As(AsGetCustomerPaymentInstrumentsListException21),
            404 => FromJson<GetCustomerPaymentInstrumentsListException31>(response, ct).As(AsGetCustomerPaymentInstrumentsListException31),
            410 => FromJson<GetCustomerPaymentInstrumentsListException41>(response, ct).As(AsGetCustomerPaymentInstrumentsListException41),
            424 => FromJson<GetCustomerPaymentInstrumentsListException51>(response, ct).As(AsGetCustomerPaymentInstrumentsListException51),
            500 => FromJson<GetCustomerPaymentInstrumentsListException61>(response, ct).As(AsGetCustomerPaymentInstrumentsListException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCustomerPaymentInstrumentsListErrorResponse : IErrorResponse<GetCustomerPaymentInstrumentsListError>
{
    public static GetCustomerPaymentInstrumentsListErrorResponse Instance { get; } = new();

    private GetCustomerPaymentInstrumentsListErrorResponse()
    {
    }

    public Task<GetCustomerPaymentInstrumentsListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCustomerPaymentInstrumentsListError.Create(response, ct);
}
