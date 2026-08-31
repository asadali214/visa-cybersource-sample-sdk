using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateSubscriptionError : ApiError
{
    private readonly Optional<CreateSubscriptionException1> _createSubscriptionException1Value;

    private readonly Optional<CreateSubscriptionException21> _createSubscriptionException21Value;

    private CreateSubscriptionError(Optional<CreateSubscriptionException1> createSubscriptionException1Value,
        Optional<CreateSubscriptionException21> createSubscriptionException21Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _createSubscriptionException1Value = createSubscriptionException1Value;
        _createSubscriptionException21Value = createSubscriptionException21Value;
    }

    private static CreateSubscriptionError AsCreateSubscriptionException1(CreateSubscriptionException1 value) =>
        new(Optional<CreateSubscriptionException1>.Some(value), default, default);

    private static CreateSubscriptionError AsCreateSubscriptionException21(CreateSubscriptionException21 value) =>
        new(default, Optional<CreateSubscriptionException21>.Some(value), default);

    private static CreateSubscriptionError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetCreateSubscriptionException1(out CreateSubscriptionException1 value) =>
        _createSubscriptionException1Value.TryGetValue(out value);

    public bool TryGetCreateSubscriptionException21(out CreateSubscriptionException21 value) =>
        _createSubscriptionException21Value.TryGetValue(out value);

    internal static Task<CreateSubscriptionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<CreateSubscriptionException1>(response, ct).As(AsCreateSubscriptionException1),
            502 => FromJson<CreateSubscriptionException21>(response, ct).As(AsCreateSubscriptionException21),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateSubscriptionErrorResponse : IErrorResponse<CreateSubscriptionError>
{
    public static CreateSubscriptionErrorResponse Instance { get; } = new();

    private CreateSubscriptionErrorResponse()
    {
    }

    public Task<CreateSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateSubscriptionError.Create(response, ct);
}
