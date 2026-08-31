using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetCustomerShippingAddressesListError : ApiError
{
    private readonly Optional<GetCustomerShippingAddressesListException1> _getCustomerShippingAddressesListException1Value;

    private readonly Optional<GetCustomerShippingAddressesListException21> _getCustomerShippingAddressesListException21Value;

    private readonly Optional<GetCustomerShippingAddressesListException31> _getCustomerShippingAddressesListException31Value;

    private readonly Optional<GetCustomerShippingAddressesListException41> _getCustomerShippingAddressesListException41Value;

    private readonly Optional<GetCustomerShippingAddressesListException51> _getCustomerShippingAddressesListException51Value;

    private readonly Optional<GetCustomerShippingAddressesListException61> _getCustomerShippingAddressesListException61Value;

    private GetCustomerShippingAddressesListError(Optional<GetCustomerShippingAddressesListException1> getCustomerShippingAddressesListException1Value,
        Optional<GetCustomerShippingAddressesListException21> getCustomerShippingAddressesListException21Value,
        Optional<GetCustomerShippingAddressesListException31> getCustomerShippingAddressesListException31Value,
        Optional<GetCustomerShippingAddressesListException41> getCustomerShippingAddressesListException41Value,
        Optional<GetCustomerShippingAddressesListException51> getCustomerShippingAddressesListException51Value,
        Optional<GetCustomerShippingAddressesListException61> getCustomerShippingAddressesListException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getCustomerShippingAddressesListException1Value = getCustomerShippingAddressesListException1Value;
        _getCustomerShippingAddressesListException21Value = getCustomerShippingAddressesListException21Value;
        _getCustomerShippingAddressesListException31Value = getCustomerShippingAddressesListException31Value;
        _getCustomerShippingAddressesListException41Value = getCustomerShippingAddressesListException41Value;
        _getCustomerShippingAddressesListException51Value = getCustomerShippingAddressesListException51Value;
        _getCustomerShippingAddressesListException61Value = getCustomerShippingAddressesListException61Value;
    }

    private static GetCustomerShippingAddressesListError AsGetCustomerShippingAddressesListException1(GetCustomerShippingAddressesListException1 value) =>
        new(Optional<GetCustomerShippingAddressesListException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static GetCustomerShippingAddressesListError AsGetCustomerShippingAddressesListException21(GetCustomerShippingAddressesListException21 value) =>
        new(default,
            Optional<GetCustomerShippingAddressesListException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetCustomerShippingAddressesListError AsGetCustomerShippingAddressesListException31(GetCustomerShippingAddressesListException31 value) =>
        new(default,
            default,
            Optional<GetCustomerShippingAddressesListException31>.Some(value),
            default,
            default,
            default,
            default);

    private static GetCustomerShippingAddressesListError AsGetCustomerShippingAddressesListException41(GetCustomerShippingAddressesListException41 value) =>
        new(default,
            default,
            default,
            Optional<GetCustomerShippingAddressesListException41>.Some(value),
            default,
            default,
            default);

    private static GetCustomerShippingAddressesListError AsGetCustomerShippingAddressesListException51(GetCustomerShippingAddressesListException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<GetCustomerShippingAddressesListException51>.Some(value),
            default,
            default);

    private static GetCustomerShippingAddressesListError AsGetCustomerShippingAddressesListException61(GetCustomerShippingAddressesListException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<GetCustomerShippingAddressesListException61>.Some(value),
            default);

    private static GetCustomerShippingAddressesListError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetCustomerShippingAddressesListException1(out GetCustomerShippingAddressesListException1 value) =>
        _getCustomerShippingAddressesListException1Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressesListException21(out GetCustomerShippingAddressesListException21 value) =>
        _getCustomerShippingAddressesListException21Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressesListException31(out GetCustomerShippingAddressesListException31 value) =>
        _getCustomerShippingAddressesListException31Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressesListException41(out GetCustomerShippingAddressesListException41 value) =>
        _getCustomerShippingAddressesListException41Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressesListException51(out GetCustomerShippingAddressesListException51 value) =>
        _getCustomerShippingAddressesListException51Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressesListException61(out GetCustomerShippingAddressesListException61 value) =>
        _getCustomerShippingAddressesListException61Value.TryGetValue(out value);

    internal static Task<GetCustomerShippingAddressesListError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetCustomerShippingAddressesListException1>(response, ct).As(AsGetCustomerShippingAddressesListException1),
            403 => FromJson<GetCustomerShippingAddressesListException21>(response, ct).As(AsGetCustomerShippingAddressesListException21),
            404 => FromJson<GetCustomerShippingAddressesListException31>(response, ct).As(AsGetCustomerShippingAddressesListException31),
            410 => FromJson<GetCustomerShippingAddressesListException41>(response, ct).As(AsGetCustomerShippingAddressesListException41),
            424 => FromJson<GetCustomerShippingAddressesListException51>(response, ct).As(AsGetCustomerShippingAddressesListException51),
            500 => FromJson<GetCustomerShippingAddressesListException61>(response, ct).As(AsGetCustomerShippingAddressesListException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCustomerShippingAddressesListErrorResponse : IErrorResponse<GetCustomerShippingAddressesListError>
{
    public static GetCustomerShippingAddressesListErrorResponse Instance { get; } = new();

    private GetCustomerShippingAddressesListErrorResponse()
    {
    }

    public Task<GetCustomerShippingAddressesListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCustomerShippingAddressesListError.Create(response, ct);
}
