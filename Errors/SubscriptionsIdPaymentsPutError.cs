using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class SubscriptionsIdPaymentsPutError : ApiError
{
    private readonly Optional<SubscriptionsIdPaymentsPutException1> _subscriptionsIdPaymentsPutException1Value;

    private readonly Optional<SubscriptionsIdPaymentsPutException21> _subscriptionsIdPaymentsPutException21Value;

    private readonly Optional<SubscriptionsIdPaymentsPutException31> _subscriptionsIdPaymentsPutException31Value;

    private SubscriptionsIdPaymentsPutError(Optional<SubscriptionsIdPaymentsPutException1> subscriptionsIdPaymentsPutException1Value,
        Optional<SubscriptionsIdPaymentsPutException21> subscriptionsIdPaymentsPutException21Value,
        Optional<SubscriptionsIdPaymentsPutException31> subscriptionsIdPaymentsPutException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _subscriptionsIdPaymentsPutException1Value = subscriptionsIdPaymentsPutException1Value;
        _subscriptionsIdPaymentsPutException21Value = subscriptionsIdPaymentsPutException21Value;
        _subscriptionsIdPaymentsPutException31Value = subscriptionsIdPaymentsPutException31Value;
    }

    private static SubscriptionsIdPaymentsPutError AsSubscriptionsIdPaymentsPutException1(SubscriptionsIdPaymentsPutException1 value) =>
        new(Optional<SubscriptionsIdPaymentsPutException1>.Some(value), default, default, default);

    private static SubscriptionsIdPaymentsPutError AsSubscriptionsIdPaymentsPutException21(SubscriptionsIdPaymentsPutException21 value) =>
        new(default, Optional<SubscriptionsIdPaymentsPutException21>.Some(value), default, default);

    private static SubscriptionsIdPaymentsPutError AsSubscriptionsIdPaymentsPutException31(SubscriptionsIdPaymentsPutException31 value) =>
        new(default, default, Optional<SubscriptionsIdPaymentsPutException31>.Some(value), default);

    private static SubscriptionsIdPaymentsPutError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetSubscriptionsIdPaymentsPutException1(out SubscriptionsIdPaymentsPutException1 value) =>
        _subscriptionsIdPaymentsPutException1Value.TryGetValue(out value);

    public bool TryGetSubscriptionsIdPaymentsPutException21(out SubscriptionsIdPaymentsPutException21 value) =>
        _subscriptionsIdPaymentsPutException21Value.TryGetValue(out value);

    public bool TryGetSubscriptionsIdPaymentsPutException31(out SubscriptionsIdPaymentsPutException31 value) =>
        _subscriptionsIdPaymentsPutException31Value.TryGetValue(out value);

    internal static Task<SubscriptionsIdPaymentsPutError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<SubscriptionsIdPaymentsPutException1>(response, ct).As(AsSubscriptionsIdPaymentsPutException1),
            404 => FromJson<SubscriptionsIdPaymentsPutException21>(response, ct).As(AsSubscriptionsIdPaymentsPutException21),
            502 => FromJson<SubscriptionsIdPaymentsPutException31>(response, ct).As(AsSubscriptionsIdPaymentsPutException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubscriptionsIdPaymentsPutErrorResponse : IErrorResponse<SubscriptionsIdPaymentsPutError>
{
    public static SubscriptionsIdPaymentsPutErrorResponse Instance { get; } = new();

    private SubscriptionsIdPaymentsPutErrorResponse()
    {
    }

    public Task<SubscriptionsIdPaymentsPutError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SubscriptionsIdPaymentsPutError.Create(response, ct);
}
