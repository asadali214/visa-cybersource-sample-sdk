using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class DeleteInstrumentIdentifierError : ApiError
{
    private readonly Optional<DeleteInstrumentIdentifierException1> _deleteInstrumentIdentifierException1Value;

    private readonly Optional<DeleteInstrumentIdentifierException21> _deleteInstrumentIdentifierException21Value;

    private readonly Optional<DeleteInstrumentIdentifierException31> _deleteInstrumentIdentifierException31Value;

    private readonly Optional<DeleteInstrumentIdentifierException41> _deleteInstrumentIdentifierException41Value;

    private readonly Optional<DeleteInstrumentIdentifierException51> _deleteInstrumentIdentifierException51Value;

    private readonly Optional<DeleteInstrumentIdentifierException61> _deleteInstrumentIdentifierException61Value;

    private DeleteInstrumentIdentifierError(Optional<DeleteInstrumentIdentifierException1> deleteInstrumentIdentifierException1Value,
        Optional<DeleteInstrumentIdentifierException21> deleteInstrumentIdentifierException21Value,
        Optional<DeleteInstrumentIdentifierException31> deleteInstrumentIdentifierException31Value,
        Optional<DeleteInstrumentIdentifierException41> deleteInstrumentIdentifierException41Value,
        Optional<DeleteInstrumentIdentifierException51> deleteInstrumentIdentifierException51Value,
        Optional<DeleteInstrumentIdentifierException61> deleteInstrumentIdentifierException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _deleteInstrumentIdentifierException1Value = deleteInstrumentIdentifierException1Value;
        _deleteInstrumentIdentifierException21Value = deleteInstrumentIdentifierException21Value;
        _deleteInstrumentIdentifierException31Value = deleteInstrumentIdentifierException31Value;
        _deleteInstrumentIdentifierException41Value = deleteInstrumentIdentifierException41Value;
        _deleteInstrumentIdentifierException51Value = deleteInstrumentIdentifierException51Value;
        _deleteInstrumentIdentifierException61Value = deleteInstrumentIdentifierException61Value;
    }

    private static DeleteInstrumentIdentifierError AsDeleteInstrumentIdentifierException1(DeleteInstrumentIdentifierException1 value) =>
        new(Optional<DeleteInstrumentIdentifierException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static DeleteInstrumentIdentifierError AsDeleteInstrumentIdentifierException21(DeleteInstrumentIdentifierException21 value) =>
        new(default,
            Optional<DeleteInstrumentIdentifierException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static DeleteInstrumentIdentifierError AsDeleteInstrumentIdentifierException31(DeleteInstrumentIdentifierException31 value) =>
        new(default,
            default,
            Optional<DeleteInstrumentIdentifierException31>.Some(value),
            default,
            default,
            default,
            default);

    private static DeleteInstrumentIdentifierError AsDeleteInstrumentIdentifierException41(DeleteInstrumentIdentifierException41 value) =>
        new(default,
            default,
            default,
            Optional<DeleteInstrumentIdentifierException41>.Some(value),
            default,
            default,
            default);

    private static DeleteInstrumentIdentifierError AsDeleteInstrumentIdentifierException51(DeleteInstrumentIdentifierException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<DeleteInstrumentIdentifierException51>.Some(value),
            default,
            default);

    private static DeleteInstrumentIdentifierError AsDeleteInstrumentIdentifierException61(DeleteInstrumentIdentifierException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<DeleteInstrumentIdentifierException61>.Some(value),
            default);

    private static DeleteInstrumentIdentifierError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDeleteInstrumentIdentifierException1(out DeleteInstrumentIdentifierException1 value) =>
        _deleteInstrumentIdentifierException1Value.TryGetValue(out value);

    public bool TryGetDeleteInstrumentIdentifierException21(out DeleteInstrumentIdentifierException21 value) =>
        _deleteInstrumentIdentifierException21Value.TryGetValue(out value);

    public bool TryGetDeleteInstrumentIdentifierException31(out DeleteInstrumentIdentifierException31 value) =>
        _deleteInstrumentIdentifierException31Value.TryGetValue(out value);

    public bool TryGetDeleteInstrumentIdentifierException41(out DeleteInstrumentIdentifierException41 value) =>
        _deleteInstrumentIdentifierException41Value.TryGetValue(out value);

    public bool TryGetDeleteInstrumentIdentifierException51(out DeleteInstrumentIdentifierException51 value) =>
        _deleteInstrumentIdentifierException51Value.TryGetValue(out value);

    public bool TryGetDeleteInstrumentIdentifierException61(out DeleteInstrumentIdentifierException61 value) =>
        _deleteInstrumentIdentifierException61Value.TryGetValue(out value);

    internal static Task<DeleteInstrumentIdentifierError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<DeleteInstrumentIdentifierException1>(response, ct).As(AsDeleteInstrumentIdentifierException1),
            404 => FromJson<DeleteInstrumentIdentifierException21>(response, ct).As(AsDeleteInstrumentIdentifierException21),
            409 => FromJson<DeleteInstrumentIdentifierException31>(response, ct).As(AsDeleteInstrumentIdentifierException31),
            410 => FromJson<DeleteInstrumentIdentifierException41>(response, ct).As(AsDeleteInstrumentIdentifierException41),
            424 => FromJson<DeleteInstrumentIdentifierException51>(response, ct).As(AsDeleteInstrumentIdentifierException51),
            500 => FromJson<DeleteInstrumentIdentifierException61>(response, ct).As(AsDeleteInstrumentIdentifierException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteInstrumentIdentifierErrorResponse : IErrorResponse<DeleteInstrumentIdentifierError>
{
    public static DeleteInstrumentIdentifierErrorResponse Instance { get; } = new();

    private DeleteInstrumentIdentifierErrorResponse()
    {
    }

    public Task<DeleteInstrumentIdentifierError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteInstrumentIdentifierError.Create(response, ct);
}
