using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetInstrumentIdentifierError : ApiError
{
    private readonly Optional<GetInstrumentIdentifierException1> _getInstrumentIdentifierException1Value;

    private readonly Optional<GetInstrumentIdentifierException21> _getInstrumentIdentifierException21Value;

    private readonly Optional<GetInstrumentIdentifierException31> _getInstrumentIdentifierException31Value;

    private readonly Optional<GetInstrumentIdentifierException41> _getInstrumentIdentifierException41Value;

    private readonly Optional<GetInstrumentIdentifierException51> _getInstrumentIdentifierException51Value;

    private readonly Optional<GetInstrumentIdentifierException61> _getInstrumentIdentifierException61Value;

    private GetInstrumentIdentifierError(Optional<GetInstrumentIdentifierException1> getInstrumentIdentifierException1Value,
        Optional<GetInstrumentIdentifierException21> getInstrumentIdentifierException21Value,
        Optional<GetInstrumentIdentifierException31> getInstrumentIdentifierException31Value,
        Optional<GetInstrumentIdentifierException41> getInstrumentIdentifierException41Value,
        Optional<GetInstrumentIdentifierException51> getInstrumentIdentifierException51Value,
        Optional<GetInstrumentIdentifierException61> getInstrumentIdentifierException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getInstrumentIdentifierException1Value = getInstrumentIdentifierException1Value;
        _getInstrumentIdentifierException21Value = getInstrumentIdentifierException21Value;
        _getInstrumentIdentifierException31Value = getInstrumentIdentifierException31Value;
        _getInstrumentIdentifierException41Value = getInstrumentIdentifierException41Value;
        _getInstrumentIdentifierException51Value = getInstrumentIdentifierException51Value;
        _getInstrumentIdentifierException61Value = getInstrumentIdentifierException61Value;
    }

    private static GetInstrumentIdentifierError AsGetInstrumentIdentifierException1(GetInstrumentIdentifierException1 value) =>
        new(Optional<GetInstrumentIdentifierException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static GetInstrumentIdentifierError AsGetInstrumentIdentifierException21(GetInstrumentIdentifierException21 value) =>
        new(default,
            Optional<GetInstrumentIdentifierException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetInstrumentIdentifierError AsGetInstrumentIdentifierException31(GetInstrumentIdentifierException31 value) =>
        new(default,
            default,
            Optional<GetInstrumentIdentifierException31>.Some(value),
            default,
            default,
            default,
            default);

    private static GetInstrumentIdentifierError AsGetInstrumentIdentifierException41(GetInstrumentIdentifierException41 value) =>
        new(default,
            default,
            default,
            Optional<GetInstrumentIdentifierException41>.Some(value),
            default,
            default,
            default);

    private static GetInstrumentIdentifierError AsGetInstrumentIdentifierException51(GetInstrumentIdentifierException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<GetInstrumentIdentifierException51>.Some(value),
            default,
            default);

    private static GetInstrumentIdentifierError AsGetInstrumentIdentifierException61(GetInstrumentIdentifierException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<GetInstrumentIdentifierException61>.Some(value),
            default);

    private static GetInstrumentIdentifierError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetInstrumentIdentifierException1(out GetInstrumentIdentifierException1 value) =>
        _getInstrumentIdentifierException1Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierException21(out GetInstrumentIdentifierException21 value) =>
        _getInstrumentIdentifierException21Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierException31(out GetInstrumentIdentifierException31 value) =>
        _getInstrumentIdentifierException31Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierException41(out GetInstrumentIdentifierException41 value) =>
        _getInstrumentIdentifierException41Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierException51(out GetInstrumentIdentifierException51 value) =>
        _getInstrumentIdentifierException51Value.TryGetValue(out value);

    public bool TryGetGetInstrumentIdentifierException61(out GetInstrumentIdentifierException61 value) =>
        _getInstrumentIdentifierException61Value.TryGetValue(out value);

    internal static Task<GetInstrumentIdentifierError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetInstrumentIdentifierException1>(response, ct).As(AsGetInstrumentIdentifierException1),
            403 => FromJson<GetInstrumentIdentifierException21>(response, ct).As(AsGetInstrumentIdentifierException21),
            404 => FromJson<GetInstrumentIdentifierException31>(response, ct).As(AsGetInstrumentIdentifierException31),
            410 => FromJson<GetInstrumentIdentifierException41>(response, ct).As(AsGetInstrumentIdentifierException41),
            424 => FromJson<GetInstrumentIdentifierException51>(response, ct).As(AsGetInstrumentIdentifierException51),
            500 => FromJson<GetInstrumentIdentifierException61>(response, ct).As(AsGetInstrumentIdentifierException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetInstrumentIdentifierErrorResponse : IErrorResponse<GetInstrumentIdentifierError>
{
    public static GetInstrumentIdentifierErrorResponse Instance { get; } = new();

    private GetInstrumentIdentifierErrorResponse()
    {
    }

    public Task<GetInstrumentIdentifierError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetInstrumentIdentifierError.Create(response, ct);
}
