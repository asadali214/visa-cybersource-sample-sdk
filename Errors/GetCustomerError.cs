using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetCustomerError : ApiError
{
    private readonly Optional<GetCustomerException1> _getCustomerException1Value;

    private readonly Optional<GetCustomerException21> _getCustomerException21Value;

    private readonly Optional<GetCustomerException31> _getCustomerException31Value;

    private readonly Optional<GetCustomerException41> _getCustomerException41Value;

    private readonly Optional<GetCustomerException51> _getCustomerException51Value;

    private readonly Optional<GetCustomerException61> _getCustomerException61Value;

    private GetCustomerError(Optional<GetCustomerException1> getCustomerException1Value,
        Optional<GetCustomerException21> getCustomerException21Value,
        Optional<GetCustomerException31> getCustomerException31Value,
        Optional<GetCustomerException41> getCustomerException41Value,
        Optional<GetCustomerException51> getCustomerException51Value,
        Optional<GetCustomerException61> getCustomerException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getCustomerException1Value = getCustomerException1Value;
        _getCustomerException21Value = getCustomerException21Value;
        _getCustomerException31Value = getCustomerException31Value;
        _getCustomerException41Value = getCustomerException41Value;
        _getCustomerException51Value = getCustomerException51Value;
        _getCustomerException61Value = getCustomerException61Value;
    }

    private static GetCustomerError AsGetCustomerException1(GetCustomerException1 value) =>
        new(Optional<GetCustomerException1>.Some(value), default, default, default, default, default, default);

    private static GetCustomerError AsGetCustomerException21(GetCustomerException21 value) =>
        new(default, Optional<GetCustomerException21>.Some(value), default, default, default, default, default);

    private static GetCustomerError AsGetCustomerException31(GetCustomerException31 value) =>
        new(default, default, Optional<GetCustomerException31>.Some(value), default, default, default, default);

    private static GetCustomerError AsGetCustomerException41(GetCustomerException41 value) =>
        new(default, default, default, Optional<GetCustomerException41>.Some(value), default, default, default);

    private static GetCustomerError AsGetCustomerException51(GetCustomerException51 value) =>
        new(default, default, default, default, Optional<GetCustomerException51>.Some(value), default, default);

    private static GetCustomerError AsGetCustomerException61(GetCustomerException61 value) =>
        new(default, default, default, default, default, Optional<GetCustomerException61>.Some(value), default);

    private static GetCustomerError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetCustomerException1(out GetCustomerException1 value) =>
        _getCustomerException1Value.TryGetValue(out value);

    public bool TryGetGetCustomerException21(out GetCustomerException21 value) =>
        _getCustomerException21Value.TryGetValue(out value);

    public bool TryGetGetCustomerException31(out GetCustomerException31 value) =>
        _getCustomerException31Value.TryGetValue(out value);

    public bool TryGetGetCustomerException41(out GetCustomerException41 value) =>
        _getCustomerException41Value.TryGetValue(out value);

    public bool TryGetGetCustomerException51(out GetCustomerException51 value) =>
        _getCustomerException51Value.TryGetValue(out value);

    public bool TryGetGetCustomerException61(out GetCustomerException61 value) =>
        _getCustomerException61Value.TryGetValue(out value);

    internal static Task<GetCustomerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetCustomerException1>(response, ct).As(AsGetCustomerException1),
            403 => FromJson<GetCustomerException21>(response, ct).As(AsGetCustomerException21),
            404 => FromJson<GetCustomerException31>(response, ct).As(AsGetCustomerException31),
            410 => FromJson<GetCustomerException41>(response, ct).As(AsGetCustomerException41),
            424 => FromJson<GetCustomerException51>(response, ct).As(AsGetCustomerException51),
            500 => FromJson<GetCustomerException61>(response, ct).As(AsGetCustomerException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCustomerErrorResponse : IErrorResponse<GetCustomerError>
{
    public static GetCustomerErrorResponse Instance { get; } = new();

    private GetCustomerErrorResponse()
    {
    }

    public Task<GetCustomerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCustomerError.Create(response, ct);
}
