using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetSubscriptionCodeError : ApiError
{
    private readonly Optional<GetSubscriptionCodeException1> _getSubscriptionCodeException1Value;

    private readonly Optional<GetSubscriptionCodeException21> _getSubscriptionCodeException21Value;

    private GetSubscriptionCodeError(Optional<GetSubscriptionCodeException1> getSubscriptionCodeException1Value,
        Optional<GetSubscriptionCodeException21> getSubscriptionCodeException21Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getSubscriptionCodeException1Value = getSubscriptionCodeException1Value;
        _getSubscriptionCodeException21Value = getSubscriptionCodeException21Value;
    }

    private static GetSubscriptionCodeError AsGetSubscriptionCodeException1(GetSubscriptionCodeException1 value) =>
        new(Optional<GetSubscriptionCodeException1>.Some(value), default, default);

    private static GetSubscriptionCodeError AsGetSubscriptionCodeException21(GetSubscriptionCodeException21 value) =>
        new(default, Optional<GetSubscriptionCodeException21>.Some(value), default);

    private static GetSubscriptionCodeError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetGetSubscriptionCodeException1(out GetSubscriptionCodeException1 value) =>
        _getSubscriptionCodeException1Value.TryGetValue(out value);

    public bool TryGetGetSubscriptionCodeException21(out GetSubscriptionCodeException21 value) =>
        _getSubscriptionCodeException21Value.TryGetValue(out value);

    internal static Task<GetSubscriptionCodeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetSubscriptionCodeException1>(response, ct).As(AsGetSubscriptionCodeException1),
            502 => FromJson<GetSubscriptionCodeException21>(response, ct).As(AsGetSubscriptionCodeException21),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSubscriptionCodeErrorResponse : IErrorResponse<GetSubscriptionCodeError>
{
    public static GetSubscriptionCodeErrorResponse Instance { get; } = new();

    private GetSubscriptionCodeErrorResponse()
    {
    }

    public Task<GetSubscriptionCodeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetSubscriptionCodeError.Create(response, ct);
}
