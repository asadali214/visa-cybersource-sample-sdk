using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetSubscriptionError : ApiError
{
    private readonly Optional<GetSubscriptionException1> _getSubscriptionException1Value;

    private readonly Optional<GetSubscriptionException21> _getSubscriptionException21Value;

    private readonly Optional<GetSubscriptionException31> _getSubscriptionException31Value;

    private GetSubscriptionError(Optional<GetSubscriptionException1> getSubscriptionException1Value,
        Optional<GetSubscriptionException21> getSubscriptionException21Value,
        Optional<GetSubscriptionException31> getSubscriptionException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getSubscriptionException1Value = getSubscriptionException1Value;
        _getSubscriptionException21Value = getSubscriptionException21Value;
        _getSubscriptionException31Value = getSubscriptionException31Value;
    }

    private static GetSubscriptionError AsGetSubscriptionException1(GetSubscriptionException1 value) =>
        new(Optional<GetSubscriptionException1>.Some(value), default, default, default);

    private static GetSubscriptionError AsGetSubscriptionException21(GetSubscriptionException21 value) =>
        new(default, Optional<GetSubscriptionException21>.Some(value), default, default);

    private static GetSubscriptionError AsGetSubscriptionException31(GetSubscriptionException31 value) =>
        new(default, default, Optional<GetSubscriptionException31>.Some(value), default);

    private static GetSubscriptionError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetSubscriptionException1(out GetSubscriptionException1 value) =>
        _getSubscriptionException1Value.TryGetValue(out value);

    public bool TryGetGetSubscriptionException21(out GetSubscriptionException21 value) =>
        _getSubscriptionException21Value.TryGetValue(out value);

    public bool TryGetGetSubscriptionException31(out GetSubscriptionException31 value) =>
        _getSubscriptionException31Value.TryGetValue(out value);

    internal static Task<GetSubscriptionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetSubscriptionException1>(response, ct).As(AsGetSubscriptionException1),
            404 => FromJson<GetSubscriptionException21>(response, ct).As(AsGetSubscriptionException21),
            502 => FromJson<GetSubscriptionException31>(response, ct).As(AsGetSubscriptionException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSubscriptionErrorResponse : IErrorResponse<GetSubscriptionError>
{
    public static GetSubscriptionErrorResponse Instance { get; } = new();

    private GetSubscriptionErrorResponse()
    {
    }

    public Task<GetSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetSubscriptionError.Create(response, ct);
}
