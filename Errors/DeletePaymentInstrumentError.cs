using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class DeletePaymentInstrumentError : ApiError
{
    private readonly Optional<DeletePaymentInstrumentException1> _deletePaymentInstrumentException1Value;

    private readonly Optional<DeletePaymentInstrumentException21> _deletePaymentInstrumentException21Value;

    private readonly Optional<DeletePaymentInstrumentException31> _deletePaymentInstrumentException31Value;

    private readonly Optional<DeletePaymentInstrumentException41> _deletePaymentInstrumentException41Value;

    private readonly Optional<DeletePaymentInstrumentException51> _deletePaymentInstrumentException51Value;

    private DeletePaymentInstrumentError(Optional<DeletePaymentInstrumentException1> deletePaymentInstrumentException1Value,
        Optional<DeletePaymentInstrumentException21> deletePaymentInstrumentException21Value,
        Optional<DeletePaymentInstrumentException31> deletePaymentInstrumentException31Value,
        Optional<DeletePaymentInstrumentException41> deletePaymentInstrumentException41Value,
        Optional<DeletePaymentInstrumentException51> deletePaymentInstrumentException51Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _deletePaymentInstrumentException1Value = deletePaymentInstrumentException1Value;
        _deletePaymentInstrumentException21Value = deletePaymentInstrumentException21Value;
        _deletePaymentInstrumentException31Value = deletePaymentInstrumentException31Value;
        _deletePaymentInstrumentException41Value = deletePaymentInstrumentException41Value;
        _deletePaymentInstrumentException51Value = deletePaymentInstrumentException51Value;
    }

    private static DeletePaymentInstrumentError AsDeletePaymentInstrumentException1(DeletePaymentInstrumentException1 value) =>
        new(Optional<DeletePaymentInstrumentException1>.Some(value), default, default, default, default, default);

    private static DeletePaymentInstrumentError AsDeletePaymentInstrumentException21(DeletePaymentInstrumentException21 value) =>
        new(default, Optional<DeletePaymentInstrumentException21>.Some(value), default, default, default, default);

    private static DeletePaymentInstrumentError AsDeletePaymentInstrumentException31(DeletePaymentInstrumentException31 value) =>
        new(default, default, Optional<DeletePaymentInstrumentException31>.Some(value), default, default, default);

    private static DeletePaymentInstrumentError AsDeletePaymentInstrumentException41(DeletePaymentInstrumentException41 value) =>
        new(default, default, default, Optional<DeletePaymentInstrumentException41>.Some(value), default, default);

    private static DeletePaymentInstrumentError AsDeletePaymentInstrumentException51(DeletePaymentInstrumentException51 value) =>
        new(default, default, default, default, Optional<DeletePaymentInstrumentException51>.Some(value), default);

    private static DeletePaymentInstrumentError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDeletePaymentInstrumentException1(out DeletePaymentInstrumentException1 value) =>
        _deletePaymentInstrumentException1Value.TryGetValue(out value);

    public bool TryGetDeletePaymentInstrumentException21(out DeletePaymentInstrumentException21 value) =>
        _deletePaymentInstrumentException21Value.TryGetValue(out value);

    public bool TryGetDeletePaymentInstrumentException31(out DeletePaymentInstrumentException31 value) =>
        _deletePaymentInstrumentException31Value.TryGetValue(out value);

    public bool TryGetDeletePaymentInstrumentException41(out DeletePaymentInstrumentException41 value) =>
        _deletePaymentInstrumentException41Value.TryGetValue(out value);

    public bool TryGetDeletePaymentInstrumentException51(out DeletePaymentInstrumentException51 value) =>
        _deletePaymentInstrumentException51Value.TryGetValue(out value);

    internal static Task<DeletePaymentInstrumentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<DeletePaymentInstrumentException1>(response, ct).As(AsDeletePaymentInstrumentException1),
            404 => FromJson<DeletePaymentInstrumentException21>(response, ct).As(AsDeletePaymentInstrumentException21),
            410 => FromJson<DeletePaymentInstrumentException31>(response, ct).As(AsDeletePaymentInstrumentException31),
            424 => FromJson<DeletePaymentInstrumentException41>(response, ct).As(AsDeletePaymentInstrumentException41),
            500 => FromJson<DeletePaymentInstrumentException51>(response, ct).As(AsDeletePaymentInstrumentException51),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeletePaymentInstrumentErrorResponse : IErrorResponse<DeletePaymentInstrumentError>
{
    public static DeletePaymentInstrumentErrorResponse Instance { get; } = new();

    private DeletePaymentInstrumentErrorResponse()
    {
    }

    public Task<DeletePaymentInstrumentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeletePaymentInstrumentError.Create(response, ct);
}
