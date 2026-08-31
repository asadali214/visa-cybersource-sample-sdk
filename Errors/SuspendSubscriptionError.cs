using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class SuspendSubscriptionError : ApiError
{
    private readonly Optional<SuspendSubscriptionException1> _suspendSubscriptionException1Value;

    private readonly Optional<SuspendSubscriptionException21> _suspendSubscriptionException21Value;

    private readonly Optional<SuspendSubscriptionException31> _suspendSubscriptionException31Value;

    private SuspendSubscriptionError(Optional<SuspendSubscriptionException1> suspendSubscriptionException1Value,
        Optional<SuspendSubscriptionException21> suspendSubscriptionException21Value,
        Optional<SuspendSubscriptionException31> suspendSubscriptionException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _suspendSubscriptionException1Value = suspendSubscriptionException1Value;
        _suspendSubscriptionException21Value = suspendSubscriptionException21Value;
        _suspendSubscriptionException31Value = suspendSubscriptionException31Value;
    }

    private static SuspendSubscriptionError AsSuspendSubscriptionException1(SuspendSubscriptionException1 value) =>
        new(Optional<SuspendSubscriptionException1>.Some(value), default, default, default);

    private static SuspendSubscriptionError AsSuspendSubscriptionException21(SuspendSubscriptionException21 value) =>
        new(default, Optional<SuspendSubscriptionException21>.Some(value), default, default);

    private static SuspendSubscriptionError AsSuspendSubscriptionException31(SuspendSubscriptionException31 value) =>
        new(default, default, Optional<SuspendSubscriptionException31>.Some(value), default);

    private static SuspendSubscriptionError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetSuspendSubscriptionException1(out SuspendSubscriptionException1 value) =>
        _suspendSubscriptionException1Value.TryGetValue(out value);

    public bool TryGetSuspendSubscriptionException21(out SuspendSubscriptionException21 value) =>
        _suspendSubscriptionException21Value.TryGetValue(out value);

    public bool TryGetSuspendSubscriptionException31(out SuspendSubscriptionException31 value) =>
        _suspendSubscriptionException31Value.TryGetValue(out value);

    internal static Task<SuspendSubscriptionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<SuspendSubscriptionException1>(response, ct).As(AsSuspendSubscriptionException1),
            404 => FromJson<SuspendSubscriptionException21>(response, ct).As(AsSuspendSubscriptionException21),
            502 => FromJson<SuspendSubscriptionException31>(response, ct).As(AsSuspendSubscriptionException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SuspendSubscriptionErrorResponse : IErrorResponse<SuspendSubscriptionError>
{
    public static SuspendSubscriptionErrorResponse Instance { get; } = new();

    private SuspendSubscriptionErrorResponse()
    {
    }

    public Task<SuspendSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SuspendSubscriptionError.Create(response, ct);
}
