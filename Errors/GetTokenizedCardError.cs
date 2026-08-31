using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetTokenizedCardError : ApiError
{
    private readonly Optional<GetTokenizedCardException1> _getTokenizedCardException1Value;

    private readonly Optional<GetTokenizedCardException21> _getTokenizedCardException21Value;

    private readonly Optional<GetTokenizedCardException31> _getTokenizedCardException31Value;

    private readonly Optional<GetTokenizedCardException41> _getTokenizedCardException41Value;

    private readonly Optional<GetTokenizedCardException51> _getTokenizedCardException51Value;

    private GetTokenizedCardError(Optional<GetTokenizedCardException1> getTokenizedCardException1Value,
        Optional<GetTokenizedCardException21> getTokenizedCardException21Value,
        Optional<GetTokenizedCardException31> getTokenizedCardException31Value,
        Optional<GetTokenizedCardException41> getTokenizedCardException41Value,
        Optional<GetTokenizedCardException51> getTokenizedCardException51Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getTokenizedCardException1Value = getTokenizedCardException1Value;
        _getTokenizedCardException21Value = getTokenizedCardException21Value;
        _getTokenizedCardException31Value = getTokenizedCardException31Value;
        _getTokenizedCardException41Value = getTokenizedCardException41Value;
        _getTokenizedCardException51Value = getTokenizedCardException51Value;
    }

    private static GetTokenizedCardError AsGetTokenizedCardException1(GetTokenizedCardException1 value) =>
        new(Optional<GetTokenizedCardException1>.Some(value), default, default, default, default, default);

    private static GetTokenizedCardError AsGetTokenizedCardException21(GetTokenizedCardException21 value) =>
        new(default, Optional<GetTokenizedCardException21>.Some(value), default, default, default, default);

    private static GetTokenizedCardError AsGetTokenizedCardException31(GetTokenizedCardException31 value) =>
        new(default, default, Optional<GetTokenizedCardException31>.Some(value), default, default, default);

    private static GetTokenizedCardError AsGetTokenizedCardException41(GetTokenizedCardException41 value) =>
        new(default, default, default, Optional<GetTokenizedCardException41>.Some(value), default, default);

    private static GetTokenizedCardError AsGetTokenizedCardException51(GetTokenizedCardException51 value) =>
        new(default, default, default, default, Optional<GetTokenizedCardException51>.Some(value), default);

    private static GetTokenizedCardError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetTokenizedCardException1(out GetTokenizedCardException1 value) =>
        _getTokenizedCardException1Value.TryGetValue(out value);

    public bool TryGetGetTokenizedCardException21(out GetTokenizedCardException21 value) =>
        _getTokenizedCardException21Value.TryGetValue(out value);

    public bool TryGetGetTokenizedCardException31(out GetTokenizedCardException31 value) =>
        _getTokenizedCardException31Value.TryGetValue(out value);

    public bool TryGetGetTokenizedCardException41(out GetTokenizedCardException41 value) =>
        _getTokenizedCardException41Value.TryGetValue(out value);

    public bool TryGetGetTokenizedCardException51(out GetTokenizedCardException51 value) =>
        _getTokenizedCardException51Value.TryGetValue(out value);

    internal static Task<GetTokenizedCardError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetTokenizedCardException1>(response, ct).As(AsGetTokenizedCardException1),
            403 => FromJson<GetTokenizedCardException21>(response, ct).As(AsGetTokenizedCardException21),
            404 => FromJson<GetTokenizedCardException31>(response, ct).As(AsGetTokenizedCardException31),
            424 => FromJson<GetTokenizedCardException41>(response, ct).As(AsGetTokenizedCardException41),
            500 => FromJson<GetTokenizedCardException51>(response, ct).As(AsGetTokenizedCardException51),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTokenizedCardErrorResponse : IErrorResponse<GetTokenizedCardError>
{
    public static GetTokenizedCardErrorResponse Instance { get; } = new();

    private GetTokenizedCardErrorResponse()
    {
    }

    public Task<GetTokenizedCardError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTokenizedCardError.Create(response, ct);
}
