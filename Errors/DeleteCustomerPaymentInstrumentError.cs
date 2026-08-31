using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class DeleteCustomerPaymentInstrumentError : ApiError
{
    private readonly Optional<DeleteCustomerPaymentInstrumentException1> _deleteCustomerPaymentInstrumentException1Value;

    private readonly Optional<DeleteCustomerPaymentInstrumentException21> _deleteCustomerPaymentInstrumentException21Value;

    private readonly Optional<DeleteCustomerPaymentInstrumentException31> _deleteCustomerPaymentInstrumentException31Value;

    private readonly Optional<DeleteCustomerPaymentInstrumentException41> _deleteCustomerPaymentInstrumentException41Value;

    private readonly Optional<DeleteCustomerPaymentInstrumentException51> _deleteCustomerPaymentInstrumentException51Value;

    private readonly Optional<DeleteCustomerPaymentInstrumentException61> _deleteCustomerPaymentInstrumentException61Value;

    private readonly Optional<DeleteCustomerPaymentInstrumentException71> _deleteCustomerPaymentInstrumentException71Value;

    private DeleteCustomerPaymentInstrumentError(Optional<DeleteCustomerPaymentInstrumentException1> deleteCustomerPaymentInstrumentException1Value,
        Optional<DeleteCustomerPaymentInstrumentException21> deleteCustomerPaymentInstrumentException21Value,
        Optional<DeleteCustomerPaymentInstrumentException31> deleteCustomerPaymentInstrumentException31Value,
        Optional<DeleteCustomerPaymentInstrumentException41> deleteCustomerPaymentInstrumentException41Value,
        Optional<DeleteCustomerPaymentInstrumentException51> deleteCustomerPaymentInstrumentException51Value,
        Optional<DeleteCustomerPaymentInstrumentException61> deleteCustomerPaymentInstrumentException61Value,
        Optional<DeleteCustomerPaymentInstrumentException71> deleteCustomerPaymentInstrumentException71Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _deleteCustomerPaymentInstrumentException1Value = deleteCustomerPaymentInstrumentException1Value;
        _deleteCustomerPaymentInstrumentException21Value = deleteCustomerPaymentInstrumentException21Value;
        _deleteCustomerPaymentInstrumentException31Value = deleteCustomerPaymentInstrumentException31Value;
        _deleteCustomerPaymentInstrumentException41Value = deleteCustomerPaymentInstrumentException41Value;
        _deleteCustomerPaymentInstrumentException51Value = deleteCustomerPaymentInstrumentException51Value;
        _deleteCustomerPaymentInstrumentException61Value = deleteCustomerPaymentInstrumentException61Value;
        _deleteCustomerPaymentInstrumentException71Value = deleteCustomerPaymentInstrumentException71Value;
    }

    private static DeleteCustomerPaymentInstrumentError AsDeleteCustomerPaymentInstrumentException1(DeleteCustomerPaymentInstrumentException1 value) =>
        new(Optional<DeleteCustomerPaymentInstrumentException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    private static DeleteCustomerPaymentInstrumentError AsDeleteCustomerPaymentInstrumentException21(DeleteCustomerPaymentInstrumentException21 value) =>
        new(default,
            Optional<DeleteCustomerPaymentInstrumentException21>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static DeleteCustomerPaymentInstrumentError AsDeleteCustomerPaymentInstrumentException31(DeleteCustomerPaymentInstrumentException31 value) =>
        new(default,
            default,
            Optional<DeleteCustomerPaymentInstrumentException31>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static DeleteCustomerPaymentInstrumentError AsDeleteCustomerPaymentInstrumentException41(DeleteCustomerPaymentInstrumentException41 value) =>
        new(default,
            default,
            default,
            Optional<DeleteCustomerPaymentInstrumentException41>.Some(value),
            default,
            default,
            default,
            default);

    private static DeleteCustomerPaymentInstrumentError AsDeleteCustomerPaymentInstrumentException51(DeleteCustomerPaymentInstrumentException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<DeleteCustomerPaymentInstrumentException51>.Some(value),
            default,
            default,
            default);

    private static DeleteCustomerPaymentInstrumentError AsDeleteCustomerPaymentInstrumentException61(DeleteCustomerPaymentInstrumentException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<DeleteCustomerPaymentInstrumentException61>.Some(value),
            default,
            default);

    private static DeleteCustomerPaymentInstrumentError AsDeleteCustomerPaymentInstrumentException71(DeleteCustomerPaymentInstrumentException71 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<DeleteCustomerPaymentInstrumentException71>.Some(value),
            default);

    private static DeleteCustomerPaymentInstrumentError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDeleteCustomerPaymentInstrumentException1(out DeleteCustomerPaymentInstrumentException1 value) =>
        _deleteCustomerPaymentInstrumentException1Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerPaymentInstrumentException21(out DeleteCustomerPaymentInstrumentException21 value) =>
        _deleteCustomerPaymentInstrumentException21Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerPaymentInstrumentException31(out DeleteCustomerPaymentInstrumentException31 value) =>
        _deleteCustomerPaymentInstrumentException31Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerPaymentInstrumentException41(out DeleteCustomerPaymentInstrumentException41 value) =>
        _deleteCustomerPaymentInstrumentException41Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerPaymentInstrumentException51(out DeleteCustomerPaymentInstrumentException51 value) =>
        _deleteCustomerPaymentInstrumentException51Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerPaymentInstrumentException61(out DeleteCustomerPaymentInstrumentException61 value) =>
        _deleteCustomerPaymentInstrumentException61Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerPaymentInstrumentException71(out DeleteCustomerPaymentInstrumentException71 value) =>
        _deleteCustomerPaymentInstrumentException71Value.TryGetValue(out value);

    internal static Task<DeleteCustomerPaymentInstrumentError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeleteCustomerPaymentInstrumentException1>(response, ct).As(AsDeleteCustomerPaymentInstrumentException1),
            403 => FromJson<DeleteCustomerPaymentInstrumentException21>(response, ct).As(AsDeleteCustomerPaymentInstrumentException21),
            404 => FromJson<DeleteCustomerPaymentInstrumentException31>(response, ct).As(AsDeleteCustomerPaymentInstrumentException31),
            409 => FromJson<DeleteCustomerPaymentInstrumentException41>(response, ct).As(AsDeleteCustomerPaymentInstrumentException41),
            410 => FromJson<DeleteCustomerPaymentInstrumentException51>(response, ct).As(AsDeleteCustomerPaymentInstrumentException51),
            424 => FromJson<DeleteCustomerPaymentInstrumentException61>(response, ct).As(AsDeleteCustomerPaymentInstrumentException61),
            500 => FromJson<DeleteCustomerPaymentInstrumentException71>(response, ct).As(AsDeleteCustomerPaymentInstrumentException71),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteCustomerPaymentInstrumentErrorResponse : IErrorResponse<DeleteCustomerPaymentInstrumentError>
{
    public static DeleteCustomerPaymentInstrumentErrorResponse Instance { get; } = new();

    private DeleteCustomerPaymentInstrumentErrorResponse()
    {
    }

    public Task<DeleteCustomerPaymentInstrumentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteCustomerPaymentInstrumentError.Create(response, ct);
}
