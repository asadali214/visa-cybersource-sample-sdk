using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class SubscriptionsIdPaymentsGetError : ApiError
{
    private readonly Optional<SubscriptionsIdPaymentsGetException1> _subscriptionsIdPaymentsGetException1Value;

    private readonly Optional<SubscriptionsIdPaymentsGetException21> _subscriptionsIdPaymentsGetException21Value;

    private readonly Optional<SubscriptionsIdPaymentsGetException31> _subscriptionsIdPaymentsGetException31Value;

    private SubscriptionsIdPaymentsGetError(Optional<SubscriptionsIdPaymentsGetException1> subscriptionsIdPaymentsGetException1Value,
        Optional<SubscriptionsIdPaymentsGetException21> subscriptionsIdPaymentsGetException21Value,
        Optional<SubscriptionsIdPaymentsGetException31> subscriptionsIdPaymentsGetException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _subscriptionsIdPaymentsGetException1Value = subscriptionsIdPaymentsGetException1Value;
        _subscriptionsIdPaymentsGetException21Value = subscriptionsIdPaymentsGetException21Value;
        _subscriptionsIdPaymentsGetException31Value = subscriptionsIdPaymentsGetException31Value;
    }

    private static SubscriptionsIdPaymentsGetError AsSubscriptionsIdPaymentsGetException1(SubscriptionsIdPaymentsGetException1 value) =>
        new(Optional<SubscriptionsIdPaymentsGetException1>.Some(value), default, default, default);

    private static SubscriptionsIdPaymentsGetError AsSubscriptionsIdPaymentsGetException21(SubscriptionsIdPaymentsGetException21 value) =>
        new(default, Optional<SubscriptionsIdPaymentsGetException21>.Some(value), default, default);

    private static SubscriptionsIdPaymentsGetError AsSubscriptionsIdPaymentsGetException31(SubscriptionsIdPaymentsGetException31 value) =>
        new(default, default, Optional<SubscriptionsIdPaymentsGetException31>.Some(value), default);

    private static SubscriptionsIdPaymentsGetError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetSubscriptionsIdPaymentsGetException1(out SubscriptionsIdPaymentsGetException1 value) =>
        _subscriptionsIdPaymentsGetException1Value.TryGetValue(out value);

    public bool TryGetSubscriptionsIdPaymentsGetException21(out SubscriptionsIdPaymentsGetException21 value) =>
        _subscriptionsIdPaymentsGetException21Value.TryGetValue(out value);

    public bool TryGetSubscriptionsIdPaymentsGetException31(out SubscriptionsIdPaymentsGetException31 value) =>
        _subscriptionsIdPaymentsGetException31Value.TryGetValue(out value);

    internal static Task<SubscriptionsIdPaymentsGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<SubscriptionsIdPaymentsGetException1>(response, ct).As(AsSubscriptionsIdPaymentsGetException1),
            404 => FromJson<SubscriptionsIdPaymentsGetException21>(response, ct).As(AsSubscriptionsIdPaymentsGetException21),
            502 => FromJson<SubscriptionsIdPaymentsGetException31>(response, ct).As(AsSubscriptionsIdPaymentsGetException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubscriptionsIdPaymentsGetErrorResponse : IErrorResponse<SubscriptionsIdPaymentsGetError>
{
    public static SubscriptionsIdPaymentsGetErrorResponse Instance { get; } = new();

    private SubscriptionsIdPaymentsGetErrorResponse()
    {
    }

    public Task<SubscriptionsIdPaymentsGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SubscriptionsIdPaymentsGetError.Create(response, ct);
}
