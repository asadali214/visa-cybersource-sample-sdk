using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateFollowOnSubscriptionError : ApiError
{
    private readonly Optional<CreateFollowOnSubscriptionException1> _createFollowOnSubscriptionException1Value;

    private readonly Optional<CreateFollowOnSubscriptionException21> _createFollowOnSubscriptionException21Value;

    private CreateFollowOnSubscriptionError(Optional<CreateFollowOnSubscriptionException1> createFollowOnSubscriptionException1Value,
        Optional<CreateFollowOnSubscriptionException21> createFollowOnSubscriptionException21Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _createFollowOnSubscriptionException1Value = createFollowOnSubscriptionException1Value;
        _createFollowOnSubscriptionException21Value = createFollowOnSubscriptionException21Value;
    }

    private static CreateFollowOnSubscriptionError AsCreateFollowOnSubscriptionException1(CreateFollowOnSubscriptionException1 value) =>
        new(Optional<CreateFollowOnSubscriptionException1>.Some(value), default, default);

    private static CreateFollowOnSubscriptionError AsCreateFollowOnSubscriptionException21(CreateFollowOnSubscriptionException21 value) =>
        new(default, Optional<CreateFollowOnSubscriptionException21>.Some(value), default);

    private static CreateFollowOnSubscriptionError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetCreateFollowOnSubscriptionException1(out CreateFollowOnSubscriptionException1 value) =>
        _createFollowOnSubscriptionException1Value.TryGetValue(out value);

    public bool TryGetCreateFollowOnSubscriptionException21(out CreateFollowOnSubscriptionException21 value) =>
        _createFollowOnSubscriptionException21Value.TryGetValue(out value);

    internal static Task<CreateFollowOnSubscriptionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<CreateFollowOnSubscriptionException1>(response, ct).As(AsCreateFollowOnSubscriptionException1),
            502 => FromJson<CreateFollowOnSubscriptionException21>(response, ct).As(AsCreateFollowOnSubscriptionException21),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateFollowOnSubscriptionErrorResponse : IErrorResponse<CreateFollowOnSubscriptionError>
{
    public static CreateFollowOnSubscriptionErrorResponse Instance { get; } = new();

    private CreateFollowOnSubscriptionErrorResponse()
    {
    }

    public Task<CreateFollowOnSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateFollowOnSubscriptionError.Create(response, ct);
}
