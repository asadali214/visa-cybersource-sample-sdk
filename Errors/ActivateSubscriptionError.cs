using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class ActivateSubscriptionError : ApiError
{
    private readonly Optional<ActivateSubscriptionException1> _activateSubscriptionException1Value;

    private readonly Optional<ActivateSubscriptionException21> _activateSubscriptionException21Value;

    private readonly Optional<ActivateSubscriptionException31> _activateSubscriptionException31Value;

    private ActivateSubscriptionError(Optional<ActivateSubscriptionException1> activateSubscriptionException1Value,
        Optional<ActivateSubscriptionException21> activateSubscriptionException21Value,
        Optional<ActivateSubscriptionException31> activateSubscriptionException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _activateSubscriptionException1Value = activateSubscriptionException1Value;
        _activateSubscriptionException21Value = activateSubscriptionException21Value;
        _activateSubscriptionException31Value = activateSubscriptionException31Value;
    }

    private static ActivateSubscriptionError AsActivateSubscriptionException1(ActivateSubscriptionException1 value) =>
        new(Optional<ActivateSubscriptionException1>.Some(value), default, default, default);

    private static ActivateSubscriptionError AsActivateSubscriptionException21(ActivateSubscriptionException21 value) =>
        new(default, Optional<ActivateSubscriptionException21>.Some(value), default, default);

    private static ActivateSubscriptionError AsActivateSubscriptionException31(ActivateSubscriptionException31 value) =>
        new(default, default, Optional<ActivateSubscriptionException31>.Some(value), default);

    private static ActivateSubscriptionError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetActivateSubscriptionException1(out ActivateSubscriptionException1 value) =>
        _activateSubscriptionException1Value.TryGetValue(out value);

    public bool TryGetActivateSubscriptionException21(out ActivateSubscriptionException21 value) =>
        _activateSubscriptionException21Value.TryGetValue(out value);

    public bool TryGetActivateSubscriptionException31(out ActivateSubscriptionException31 value) =>
        _activateSubscriptionException31Value.TryGetValue(out value);

    internal static Task<ActivateSubscriptionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ActivateSubscriptionException1>(response, ct).As(AsActivateSubscriptionException1),
            404 => FromJson<ActivateSubscriptionException21>(response, ct).As(AsActivateSubscriptionException21),
            502 => FromJson<ActivateSubscriptionException31>(response, ct).As(AsActivateSubscriptionException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ActivateSubscriptionErrorResponse : IErrorResponse<ActivateSubscriptionError>
{
    public static ActivateSubscriptionErrorResponse Instance { get; } = new();

    private ActivateSubscriptionErrorResponse()
    {
    }

    public Task<ActivateSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ActivateSubscriptionError.Create(response, ct);
}
