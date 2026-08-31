using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class UpdateSubscriptionError : ApiError
{
    private readonly Optional<UpdateSubscriptionException1> _updateSubscriptionException1Value;

    private readonly Optional<UpdateSubscriptionException21> _updateSubscriptionException21Value;

    private readonly Optional<UpdateSubscriptionException31> _updateSubscriptionException31Value;

    private UpdateSubscriptionError(Optional<UpdateSubscriptionException1> updateSubscriptionException1Value,
        Optional<UpdateSubscriptionException21> updateSubscriptionException21Value,
        Optional<UpdateSubscriptionException31> updateSubscriptionException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _updateSubscriptionException1Value = updateSubscriptionException1Value;
        _updateSubscriptionException21Value = updateSubscriptionException21Value;
        _updateSubscriptionException31Value = updateSubscriptionException31Value;
    }

    private static UpdateSubscriptionError AsUpdateSubscriptionException1(UpdateSubscriptionException1 value) =>
        new(Optional<UpdateSubscriptionException1>.Some(value), default, default, default);

    private static UpdateSubscriptionError AsUpdateSubscriptionException21(UpdateSubscriptionException21 value) =>
        new(default, Optional<UpdateSubscriptionException21>.Some(value), default, default);

    private static UpdateSubscriptionError AsUpdateSubscriptionException31(UpdateSubscriptionException31 value) =>
        new(default, default, Optional<UpdateSubscriptionException31>.Some(value), default);

    private static UpdateSubscriptionError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetUpdateSubscriptionException1(out UpdateSubscriptionException1 value) =>
        _updateSubscriptionException1Value.TryGetValue(out value);

    public bool TryGetUpdateSubscriptionException21(out UpdateSubscriptionException21 value) =>
        _updateSubscriptionException21Value.TryGetValue(out value);

    public bool TryGetUpdateSubscriptionException31(out UpdateSubscriptionException31 value) =>
        _updateSubscriptionException31Value.TryGetValue(out value);

    internal static Task<UpdateSubscriptionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<UpdateSubscriptionException1>(response, ct).As(AsUpdateSubscriptionException1),
            404 => FromJson<UpdateSubscriptionException21>(response, ct).As(AsUpdateSubscriptionException21),
            502 => FromJson<UpdateSubscriptionException31>(response, ct).As(AsUpdateSubscriptionException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateSubscriptionErrorResponse : IErrorResponse<UpdateSubscriptionError>
{
    public static UpdateSubscriptionErrorResponse Instance { get; } = new();

    private UpdateSubscriptionErrorResponse()
    {
    }

    public Task<UpdateSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateSubscriptionError.Create(response, ct);
}
