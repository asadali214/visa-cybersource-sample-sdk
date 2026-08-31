using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class DeleteSubscriptionError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeleteSubscriptionError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeleteSubscriptionError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static DeleteSubscriptionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<DeleteSubscriptionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteSubscriptionErrorResponse : IErrorResponse<DeleteSubscriptionError>
{
    public static DeleteSubscriptionErrorResponse Instance { get; } = new();

    private DeleteSubscriptionErrorResponse()
    {
    }

    public Task<DeleteSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteSubscriptionError.Create(response, ct);
}
