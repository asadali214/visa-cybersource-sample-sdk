using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class DeleteCustomerShippingAddressError : ApiError
{
    private readonly Optional<DeleteCustomerShippingAddressException1> _deleteCustomerShippingAddressException1Value;

    private readonly Optional<DeleteCustomerShippingAddressException21> _deleteCustomerShippingAddressException21Value;

    private readonly Optional<DeleteCustomerShippingAddressException31> _deleteCustomerShippingAddressException31Value;

    private readonly Optional<DeleteCustomerShippingAddressException41> _deleteCustomerShippingAddressException41Value;

    private readonly Optional<DeleteCustomerShippingAddressException51> _deleteCustomerShippingAddressException51Value;

    private readonly Optional<DeleteCustomerShippingAddressException61> _deleteCustomerShippingAddressException61Value;

    private readonly Optional<DeleteCustomerShippingAddressException71> _deleteCustomerShippingAddressException71Value;

    private DeleteCustomerShippingAddressError(Optional<DeleteCustomerShippingAddressException1> deleteCustomerShippingAddressException1Value,
        Optional<DeleteCustomerShippingAddressException21> deleteCustomerShippingAddressException21Value,
        Optional<DeleteCustomerShippingAddressException31> deleteCustomerShippingAddressException31Value,
        Optional<DeleteCustomerShippingAddressException41> deleteCustomerShippingAddressException41Value,
        Optional<DeleteCustomerShippingAddressException51> deleteCustomerShippingAddressException51Value,
        Optional<DeleteCustomerShippingAddressException61> deleteCustomerShippingAddressException61Value,
        Optional<DeleteCustomerShippingAddressException71> deleteCustomerShippingAddressException71Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _deleteCustomerShippingAddressException1Value = deleteCustomerShippingAddressException1Value;
        _deleteCustomerShippingAddressException21Value = deleteCustomerShippingAddressException21Value;
        _deleteCustomerShippingAddressException31Value = deleteCustomerShippingAddressException31Value;
        _deleteCustomerShippingAddressException41Value = deleteCustomerShippingAddressException41Value;
        _deleteCustomerShippingAddressException51Value = deleteCustomerShippingAddressException51Value;
        _deleteCustomerShippingAddressException61Value = deleteCustomerShippingAddressException61Value;
        _deleteCustomerShippingAddressException71Value = deleteCustomerShippingAddressException71Value;
    }

    private static DeleteCustomerShippingAddressError AsDeleteCustomerShippingAddressException1(DeleteCustomerShippingAddressException1 value) =>
        new(Optional<DeleteCustomerShippingAddressException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    private static DeleteCustomerShippingAddressError AsDeleteCustomerShippingAddressException21(DeleteCustomerShippingAddressException21 value) =>
        new(default,
            Optional<DeleteCustomerShippingAddressException21>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static DeleteCustomerShippingAddressError AsDeleteCustomerShippingAddressException31(DeleteCustomerShippingAddressException31 value) =>
        new(default,
            default,
            Optional<DeleteCustomerShippingAddressException31>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static DeleteCustomerShippingAddressError AsDeleteCustomerShippingAddressException41(DeleteCustomerShippingAddressException41 value) =>
        new(default,
            default,
            default,
            Optional<DeleteCustomerShippingAddressException41>.Some(value),
            default,
            default,
            default,
            default);

    private static DeleteCustomerShippingAddressError AsDeleteCustomerShippingAddressException51(DeleteCustomerShippingAddressException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<DeleteCustomerShippingAddressException51>.Some(value),
            default,
            default,
            default);

    private static DeleteCustomerShippingAddressError AsDeleteCustomerShippingAddressException61(DeleteCustomerShippingAddressException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<DeleteCustomerShippingAddressException61>.Some(value),
            default,
            default);

    private static DeleteCustomerShippingAddressError AsDeleteCustomerShippingAddressException71(DeleteCustomerShippingAddressException71 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<DeleteCustomerShippingAddressException71>.Some(value),
            default);

    private static DeleteCustomerShippingAddressError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDeleteCustomerShippingAddressException1(out DeleteCustomerShippingAddressException1 value) =>
        _deleteCustomerShippingAddressException1Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerShippingAddressException21(out DeleteCustomerShippingAddressException21 value) =>
        _deleteCustomerShippingAddressException21Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerShippingAddressException31(out DeleteCustomerShippingAddressException31 value) =>
        _deleteCustomerShippingAddressException31Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerShippingAddressException41(out DeleteCustomerShippingAddressException41 value) =>
        _deleteCustomerShippingAddressException41Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerShippingAddressException51(out DeleteCustomerShippingAddressException51 value) =>
        _deleteCustomerShippingAddressException51Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerShippingAddressException61(out DeleteCustomerShippingAddressException61 value) =>
        _deleteCustomerShippingAddressException61Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerShippingAddressException71(out DeleteCustomerShippingAddressException71 value) =>
        _deleteCustomerShippingAddressException71Value.TryGetValue(out value);

    internal static Task<DeleteCustomerShippingAddressError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeleteCustomerShippingAddressException1>(response, ct).As(AsDeleteCustomerShippingAddressException1),
            403 => FromJson<DeleteCustomerShippingAddressException21>(response, ct).As(AsDeleteCustomerShippingAddressException21),
            404 => FromJson<DeleteCustomerShippingAddressException31>(response, ct).As(AsDeleteCustomerShippingAddressException31),
            409 => FromJson<DeleteCustomerShippingAddressException41>(response, ct).As(AsDeleteCustomerShippingAddressException41),
            410 => FromJson<DeleteCustomerShippingAddressException51>(response, ct).As(AsDeleteCustomerShippingAddressException51),
            424 => FromJson<DeleteCustomerShippingAddressException61>(response, ct).As(AsDeleteCustomerShippingAddressException61),
            500 => FromJson<DeleteCustomerShippingAddressException71>(response, ct).As(AsDeleteCustomerShippingAddressException71),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteCustomerShippingAddressErrorResponse : IErrorResponse<DeleteCustomerShippingAddressError>
{
    public static DeleteCustomerShippingAddressErrorResponse Instance { get; } = new();

    private DeleteCustomerShippingAddressErrorResponse()
    {
    }

    public Task<DeleteCustomerShippingAddressError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteCustomerShippingAddressError.Create(response, ct);
}
