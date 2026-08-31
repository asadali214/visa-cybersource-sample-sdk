using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetCustomerShippingAddressError : ApiError
{
    private readonly Optional<GetCustomerShippingAddressException1> _getCustomerShippingAddressException1Value;

    private readonly Optional<GetCustomerShippingAddressException21> _getCustomerShippingAddressException21Value;

    private readonly Optional<GetCustomerShippingAddressException31> _getCustomerShippingAddressException31Value;

    private readonly Optional<GetCustomerShippingAddressException41> _getCustomerShippingAddressException41Value;

    private readonly Optional<GetCustomerShippingAddressException51> _getCustomerShippingAddressException51Value;

    private readonly Optional<GetCustomerShippingAddressException61> _getCustomerShippingAddressException61Value;

    private GetCustomerShippingAddressError(Optional<GetCustomerShippingAddressException1> getCustomerShippingAddressException1Value,
        Optional<GetCustomerShippingAddressException21> getCustomerShippingAddressException21Value,
        Optional<GetCustomerShippingAddressException31> getCustomerShippingAddressException31Value,
        Optional<GetCustomerShippingAddressException41> getCustomerShippingAddressException41Value,
        Optional<GetCustomerShippingAddressException51> getCustomerShippingAddressException51Value,
        Optional<GetCustomerShippingAddressException61> getCustomerShippingAddressException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getCustomerShippingAddressException1Value = getCustomerShippingAddressException1Value;
        _getCustomerShippingAddressException21Value = getCustomerShippingAddressException21Value;
        _getCustomerShippingAddressException31Value = getCustomerShippingAddressException31Value;
        _getCustomerShippingAddressException41Value = getCustomerShippingAddressException41Value;
        _getCustomerShippingAddressException51Value = getCustomerShippingAddressException51Value;
        _getCustomerShippingAddressException61Value = getCustomerShippingAddressException61Value;
    }

    private static GetCustomerShippingAddressError AsGetCustomerShippingAddressException1(GetCustomerShippingAddressException1 value) =>
        new(Optional<GetCustomerShippingAddressException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static GetCustomerShippingAddressError AsGetCustomerShippingAddressException21(GetCustomerShippingAddressException21 value) =>
        new(default,
            Optional<GetCustomerShippingAddressException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetCustomerShippingAddressError AsGetCustomerShippingAddressException31(GetCustomerShippingAddressException31 value) =>
        new(default,
            default,
            Optional<GetCustomerShippingAddressException31>.Some(value),
            default,
            default,
            default,
            default);

    private static GetCustomerShippingAddressError AsGetCustomerShippingAddressException41(GetCustomerShippingAddressException41 value) =>
        new(default,
            default,
            default,
            Optional<GetCustomerShippingAddressException41>.Some(value),
            default,
            default,
            default);

    private static GetCustomerShippingAddressError AsGetCustomerShippingAddressException51(GetCustomerShippingAddressException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<GetCustomerShippingAddressException51>.Some(value),
            default,
            default);

    private static GetCustomerShippingAddressError AsGetCustomerShippingAddressException61(GetCustomerShippingAddressException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<GetCustomerShippingAddressException61>.Some(value),
            default);

    private static GetCustomerShippingAddressError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetCustomerShippingAddressException1(out GetCustomerShippingAddressException1 value) =>
        _getCustomerShippingAddressException1Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressException21(out GetCustomerShippingAddressException21 value) =>
        _getCustomerShippingAddressException21Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressException31(out GetCustomerShippingAddressException31 value) =>
        _getCustomerShippingAddressException31Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressException41(out GetCustomerShippingAddressException41 value) =>
        _getCustomerShippingAddressException41Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressException51(out GetCustomerShippingAddressException51 value) =>
        _getCustomerShippingAddressException51Value.TryGetValue(out value);

    public bool TryGetGetCustomerShippingAddressException61(out GetCustomerShippingAddressException61 value) =>
        _getCustomerShippingAddressException61Value.TryGetValue(out value);

    internal static Task<GetCustomerShippingAddressError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetCustomerShippingAddressException1>(response, ct).As(AsGetCustomerShippingAddressException1),
            403 => FromJson<GetCustomerShippingAddressException21>(response, ct).As(AsGetCustomerShippingAddressException21),
            404 => FromJson<GetCustomerShippingAddressException31>(response, ct).As(AsGetCustomerShippingAddressException31),
            410 => FromJson<GetCustomerShippingAddressException41>(response, ct).As(AsGetCustomerShippingAddressException41),
            424 => FromJson<GetCustomerShippingAddressException51>(response, ct).As(AsGetCustomerShippingAddressException51),
            500 => FromJson<GetCustomerShippingAddressException61>(response, ct).As(AsGetCustomerShippingAddressException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCustomerShippingAddressErrorResponse : IErrorResponse<GetCustomerShippingAddressError>
{
    public static GetCustomerShippingAddressErrorResponse Instance { get; } = new();

    private GetCustomerShippingAddressErrorResponse()
    {
    }

    public Task<GetCustomerShippingAddressError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCustomerShippingAddressError.Create(response, ct);
}
