using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetInstrumentIdentifierPaymentInstrumentsListError : ApiError
{
    private readonly Optional<GetInstrumentIdentifierPaymentInstrumentsListException1> _getInstrumentIdentifierPaymentInstrumentsListException1Value;

    private readonly Optional<GetInstrumentIdentifierPaymentInstrumentsListException21> _getInstrumentIdentifierPaymentInstrumentsListException21Value;

    private readonly Optional<GetInstrumentIdentifierPaymentInstrumentsListException31> _getInstrumentIdentifierPaymentInstrumentsListException31Value;

    private readonly Optional<GetInstrumentIdentifierPaymentInstrumentsListException41> _getInstrumentIdentifierPaymentInstrumentsListException41Value;

    private readonly Optional<GetInstrumentIdentifierPaymentInstrumentsListException51> _getInstrumentIdentifierPaymentInstrumentsListException51Value;

    private readonly Optional<GetInstrumentIdentifierPaymentInstrumentsListException61> _getInstrumentIdentifierPaymentInstrumentsListException61Value;

    private GetInstrumentIdentifierPaymentInstrumentsListError(Optional<GetInstrumentIdentifierPaymentInstrumentsListException1> getInstrumentIdentifierPaymentInstrumentsListException1Value,
        Optional<GetInstrumentIdentifierPaymentInstrumentsListException21> getInstrumentIdentifierPaymentInstrumentsListException21Value,
        Optional<GetInstrumentIdentifierPaymentInstrumentsListException31> getInstrumentIdentifierPaymentInstrumentsListException31Value,
        Optional<GetInstrumentIdentifierPaymentInstrumentsListException41> getInstrumentIdentifierPaymentInstrumentsListException41Value,
        Optional<GetInstrumentIdentifierPaymentInstrumentsListException51> getInstrumentIdentifierPaymentInstrumentsListException51Value,
        Optional<GetInstrumentIdentifierPaymentInstrumentsListException61> getInstrumentIdentifierPaymentInstrumentsListException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getInstrumentIdentifierPaymentInstrumentsListException1Value =
            getInstrumentIdentifierPaymentInstrumentsListException1Value;
        _getInstrumentIdentifierPaymentInstrumentsListException21Value =
            getInstrumentIdentifierPaymentInstrumentsListException21Value;
        _getInstrumentIdentifierPaymentInstrumentsListException31Value =
            getInstrumentIdentifierPaymentInstrumentsListException31Value;
        _getInstrumentIdentifierPaymentInstrumentsListException41Value =
            getInstrumentIdentifierPaymentInstrumentsListException41Value;
        _getInstrumentIdentifierPaymentInstrumentsListException51Value =
            getInstrumentIdentifierPaymentInstrumentsListException51Value;
        _getInstrumentIdentifierPaymentInstrumentsListException61Value =
            getInstrumentIdentifierPaymentInstrumentsListException61Value;
    }

    private static GetInstrumentIdentifierPaymentInstrumentsListError AsGetInstrumentIdentifierPaymentInstrumentsListException1(GetInstrumentIdentifierPaymentInstrumentsListException1 value) =>
        new(Optional<GetInstrumentIdentifierPaymentInstrumentsListException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static GetInstrumentIdentifierPaymentInstrumentsListError AsGetInstrumentIdentifierPaymentInstrumentsListException21(GetInstrumentIdentifierPaymentInstrumentsListException21 value) =>
        new(default,
            Optional<GetInstrumentIdentifierPaymentInstrumentsListException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetInstrumentIdentifierPaymentInstrumentsListError AsGetInstrumentIdentifierPaymentInstrumentsListException31(GetInstrumentIdentifierPaymentInstrumentsListException31 value) =>
        new(default,
            default,
            Optional<GetInstrumentIdentifierPaymentInstrumentsListException31>.Some(value),
            default,
            default,
            default,
            default);

    private static GetInstrumentIdentifierPaymentInstrumentsListError AsGetInstrumentIdentifierPaymentInstrumentsListException41(GetInstrumentIdentifierPaymentInstrumentsListException41 value) =>
        new(default,
            default,
            default,
            Optional<GetInstrumentIdentifierPaymentInstrumentsListException41>.Some(value),
            default,
            default,
            default);

    private static GetInstrumentIdentifierPaymentInstrumentsListError AsGetInstrumentIdentifierPaymentInstrumentsListException51(GetInstrumentIdentifierPaymentInstrumentsListException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<GetInstrumentIdentifierPaymentInstrumentsListException51>.Some(value),
            default,
            default);

    private static GetInstrumentIdentifierPaymentInstrumentsListError AsGetInstrumentIdentifierPaymentInstrumentsListException61(GetInstrumentIdentifierPaymentInstrumentsListException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<GetInstrumentIdentifierPaymentInstrumentsListException61>.Some(value),
            default);

    private static GetInstrumentIdentifierPaymentInstrumentsListError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetInstrumentIdentifierPaymentInstrumentsListException1(out GetInstrumentIdentifierPaymentInstrumentsListException1 value) =>
        _getInstrumentIdentifierPaymentInstrumentsListException1Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierPaymentInstrumentsListException21(out GetInstrumentIdentifierPaymentInstrumentsListException21 value) =>
        _getInstrumentIdentifierPaymentInstrumentsListException21Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierPaymentInstrumentsListException31(out GetInstrumentIdentifierPaymentInstrumentsListException31 value) =>
        _getInstrumentIdentifierPaymentInstrumentsListException31Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierPaymentInstrumentsListException41(out GetInstrumentIdentifierPaymentInstrumentsListException41 value) =>
        _getInstrumentIdentifierPaymentInstrumentsListException41Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierPaymentInstrumentsListException51(out GetInstrumentIdentifierPaymentInstrumentsListException51 value) =>
        _getInstrumentIdentifierPaymentInstrumentsListException51Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierPaymentInstrumentsListException61(out GetInstrumentIdentifierPaymentInstrumentsListException61 value) =>
        _getInstrumentIdentifierPaymentInstrumentsListException61Value.TryGetValue(out value);

    internal static Task<GetInstrumentIdentifierPaymentInstrumentsListError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetInstrumentIdentifierPaymentInstrumentsListException1>(response, ct).As(AsGetInstrumentIdentifierPaymentInstrumentsListException1),
            403 => FromJson<GetInstrumentIdentifierPaymentInstrumentsListException21>(response, ct).As(AsGetInstrumentIdentifierPaymentInstrumentsListException21),
            404 => FromJson<GetInstrumentIdentifierPaymentInstrumentsListException31>(response, ct).As(AsGetInstrumentIdentifierPaymentInstrumentsListException31),
            410 => FromJson<GetInstrumentIdentifierPaymentInstrumentsListException41>(response, ct).As(AsGetInstrumentIdentifierPaymentInstrumentsListException41),
            424 => FromJson<GetInstrumentIdentifierPaymentInstrumentsListException51>(response, ct).As(AsGetInstrumentIdentifierPaymentInstrumentsListException51),
            500 => FromJson<GetInstrumentIdentifierPaymentInstrumentsListException61>(response, ct).As(AsGetInstrumentIdentifierPaymentInstrumentsListException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetInstrumentIdentifierPaymentInstrumentsListErrorResponse : IErrorResponse<GetInstrumentIdentifierPaymentInstrumentsListError>
{
    public static GetInstrumentIdentifierPaymentInstrumentsListErrorResponse Instance { get; } = new();

    private GetInstrumentIdentifierPaymentInstrumentsListErrorResponse()
    {
    }

    public Task<GetInstrumentIdentifierPaymentInstrumentsListError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetInstrumentIdentifierPaymentInstrumentsListError.Create(response, ct);
}
