using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CancelSubscriptionError : ApiError
{
    private readonly Optional<CancelSubscriptionException1> _cancelSubscriptionException1Value;

    private readonly Optional<CancelSubscriptionException21> _cancelSubscriptionException21Value;

    private readonly Optional<CancelSubscriptionException31> _cancelSubscriptionException31Value;

    private CancelSubscriptionError(Optional<CancelSubscriptionException1> cancelSubscriptionException1Value,
        Optional<CancelSubscriptionException21> cancelSubscriptionException21Value,
        Optional<CancelSubscriptionException31> cancelSubscriptionException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _cancelSubscriptionException1Value = cancelSubscriptionException1Value;
        _cancelSubscriptionException21Value = cancelSubscriptionException21Value;
        _cancelSubscriptionException31Value = cancelSubscriptionException31Value;
    }

    private static CancelSubscriptionError AsCancelSubscriptionException1(CancelSubscriptionException1 value) =>
        new(Optional<CancelSubscriptionException1>.Some(value), default, default, default);

    private static CancelSubscriptionError AsCancelSubscriptionException21(CancelSubscriptionException21 value) =>
        new(default, Optional<CancelSubscriptionException21>.Some(value), default, default);

    private static CancelSubscriptionError AsCancelSubscriptionException31(CancelSubscriptionException31 value) =>
        new(default, default, Optional<CancelSubscriptionException31>.Some(value), default);

    private static CancelSubscriptionError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetCancelSubscriptionException1(out CancelSubscriptionException1 value) =>
        _cancelSubscriptionException1Value.TryGetValue(out value);

    public bool TryGetCancelSubscriptionException21(out CancelSubscriptionException21 value) =>
        _cancelSubscriptionException21Value.TryGetValue(out value);

    public bool TryGetCancelSubscriptionException31(out CancelSubscriptionException31 value) =>
        _cancelSubscriptionException31Value.TryGetValue(out value);

    internal static Task<CancelSubscriptionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<CancelSubscriptionException1>(response, ct).As(AsCancelSubscriptionException1),
            404 => FromJson<CancelSubscriptionException21>(response, ct).As(AsCancelSubscriptionException21),
            502 => FromJson<CancelSubscriptionException31>(response, ct).As(AsCancelSubscriptionException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelSubscriptionErrorResponse : IErrorResponse<CancelSubscriptionError>
{
    public static CancelSubscriptionErrorResponse Instance { get; } = new();

    private CancelSubscriptionErrorResponse()
    {
    }

    public Task<CancelSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CancelSubscriptionError.Create(response, ct);
}
