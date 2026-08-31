using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetFollowOnSubscriptionError : ApiError
{
    private readonly Optional<GetFollowOnSubscriptionException1> _getFollowOnSubscriptionException1Value;

    private readonly Optional<GetFollowOnSubscriptionException21> _getFollowOnSubscriptionException21Value;

    private readonly Optional<GetFollowOnSubscriptionException31> _getFollowOnSubscriptionException31Value;

    private GetFollowOnSubscriptionError(Optional<GetFollowOnSubscriptionException1> getFollowOnSubscriptionException1Value,
        Optional<GetFollowOnSubscriptionException21> getFollowOnSubscriptionException21Value,
        Optional<GetFollowOnSubscriptionException31> getFollowOnSubscriptionException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getFollowOnSubscriptionException1Value = getFollowOnSubscriptionException1Value;
        _getFollowOnSubscriptionException21Value = getFollowOnSubscriptionException21Value;
        _getFollowOnSubscriptionException31Value = getFollowOnSubscriptionException31Value;
    }

    private static GetFollowOnSubscriptionError AsGetFollowOnSubscriptionException1(GetFollowOnSubscriptionException1 value) =>
        new(Optional<GetFollowOnSubscriptionException1>.Some(value), default, default, default);

    private static GetFollowOnSubscriptionError AsGetFollowOnSubscriptionException21(GetFollowOnSubscriptionException21 value) =>
        new(default, Optional<GetFollowOnSubscriptionException21>.Some(value), default, default);

    private static GetFollowOnSubscriptionError AsGetFollowOnSubscriptionException31(GetFollowOnSubscriptionException31 value) =>
        new(default, default, Optional<GetFollowOnSubscriptionException31>.Some(value), default);

    private static GetFollowOnSubscriptionError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetFollowOnSubscriptionException1(out GetFollowOnSubscriptionException1 value) =>
        _getFollowOnSubscriptionException1Value.TryGetValue(out value);

    public bool TryGetGetFollowOnSubscriptionException21(out GetFollowOnSubscriptionException21 value) =>
        _getFollowOnSubscriptionException21Value.TryGetValue(out value);

    public bool TryGetGetFollowOnSubscriptionException31(out GetFollowOnSubscriptionException31 value) =>
        _getFollowOnSubscriptionException31Value.TryGetValue(out value);

    internal static Task<GetFollowOnSubscriptionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetFollowOnSubscriptionException1>(response, ct).As(AsGetFollowOnSubscriptionException1),
            404 => FromJson<GetFollowOnSubscriptionException21>(response, ct).As(AsGetFollowOnSubscriptionException21),
            502 => FromJson<GetFollowOnSubscriptionException31>(response, ct).As(AsGetFollowOnSubscriptionException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFollowOnSubscriptionErrorResponse : IErrorResponse<GetFollowOnSubscriptionError>
{
    public static GetFollowOnSubscriptionErrorResponse Instance { get; } = new();

    private GetFollowOnSubscriptionErrorResponse()
    {
    }

    public Task<GetFollowOnSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFollowOnSubscriptionError.Create(response, ct);
}
