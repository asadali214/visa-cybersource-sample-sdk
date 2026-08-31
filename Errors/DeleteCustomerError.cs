using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class DeleteCustomerError : ApiError
{
    private readonly Optional<DeleteCustomerException1> _deleteCustomerException1Value;

    private readonly Optional<DeleteCustomerException21> _deleteCustomerException21Value;

    private readonly Optional<DeleteCustomerException31> _deleteCustomerException31Value;

    private readonly Optional<DeleteCustomerException41> _deleteCustomerException41Value;

    private readonly Optional<DeleteCustomerException51> _deleteCustomerException51Value;

    private readonly Optional<DeleteCustomerException61> _deleteCustomerException61Value;

    private DeleteCustomerError(Optional<DeleteCustomerException1> deleteCustomerException1Value,
        Optional<DeleteCustomerException21> deleteCustomerException21Value,
        Optional<DeleteCustomerException31> deleteCustomerException31Value,
        Optional<DeleteCustomerException41> deleteCustomerException41Value,
        Optional<DeleteCustomerException51> deleteCustomerException51Value,
        Optional<DeleteCustomerException61> deleteCustomerException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _deleteCustomerException1Value = deleteCustomerException1Value;
        _deleteCustomerException21Value = deleteCustomerException21Value;
        _deleteCustomerException31Value = deleteCustomerException31Value;
        _deleteCustomerException41Value = deleteCustomerException41Value;
        _deleteCustomerException51Value = deleteCustomerException51Value;
        _deleteCustomerException61Value = deleteCustomerException61Value;
    }

    private static DeleteCustomerError AsDeleteCustomerException1(DeleteCustomerException1 value) =>
        new(Optional<DeleteCustomerException1>.Some(value), default, default, default, default, default, default);

    private static DeleteCustomerError AsDeleteCustomerException21(DeleteCustomerException21 value) =>
        new(default, Optional<DeleteCustomerException21>.Some(value), default, default, default, default, default);

    private static DeleteCustomerError AsDeleteCustomerException31(DeleteCustomerException31 value) =>
        new(default, default, Optional<DeleteCustomerException31>.Some(value), default, default, default, default);

    private static DeleteCustomerError AsDeleteCustomerException41(DeleteCustomerException41 value) =>
        new(default, default, default, Optional<DeleteCustomerException41>.Some(value), default, default, default);

    private static DeleteCustomerError AsDeleteCustomerException51(DeleteCustomerException51 value) =>
        new(default, default, default, default, Optional<DeleteCustomerException51>.Some(value), default, default);

    private static DeleteCustomerError AsDeleteCustomerException61(DeleteCustomerException61 value) =>
        new(default, default, default, default, default, Optional<DeleteCustomerException61>.Some(value), default);

    private static DeleteCustomerError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDeleteCustomerException1(out DeleteCustomerException1 value) =>
        _deleteCustomerException1Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerException21(out DeleteCustomerException21 value) =>
        _deleteCustomerException21Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerException31(out DeleteCustomerException31 value) =>
        _deleteCustomerException31Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerException41(out DeleteCustomerException41 value) =>
        _deleteCustomerException41Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerException51(out DeleteCustomerException51 value) =>
        _deleteCustomerException51Value.TryGetValue(out value);

    public bool TryGetDeleteCustomerException61(out DeleteCustomerException61 value) =>
        _deleteCustomerException61Value.TryGetValue(out value);

    internal static Task<DeleteCustomerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeleteCustomerException1>(response, ct).As(AsDeleteCustomerException1),
            403 => FromJson<DeleteCustomerException21>(response, ct).As(AsDeleteCustomerException21),
            404 => FromJson<DeleteCustomerException31>(response, ct).As(AsDeleteCustomerException31),
            410 => FromJson<DeleteCustomerException41>(response, ct).As(AsDeleteCustomerException41),
            424 => FromJson<DeleteCustomerException51>(response, ct).As(AsDeleteCustomerException51),
            500 => FromJson<DeleteCustomerException61>(response, ct).As(AsDeleteCustomerException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteCustomerErrorResponse : IErrorResponse<DeleteCustomerError>
{
    public static DeleteCustomerErrorResponse Instance { get; } = new();

    private DeleteCustomerErrorResponse()
    {
    }

    public Task<DeleteCustomerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteCustomerError.Create(response, ct);
}
