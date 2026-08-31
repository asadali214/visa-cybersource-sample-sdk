using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateStandardOrClassicSubscriptionError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreateStandardOrClassicSubscriptionError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreateStandardOrClassicSubscriptionError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreateStandardOrClassicSubscriptionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreateStandardOrClassicSubscriptionError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateStandardOrClassicSubscriptionErrorResponse : IErrorResponse<CreateStandardOrClassicSubscriptionError>
{
    public static CreateStandardOrClassicSubscriptionErrorResponse Instance { get; } = new();

    private CreateStandardOrClassicSubscriptionErrorResponse()
    {
    }

    public Task<CreateStandardOrClassicSubscriptionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateStandardOrClassicSubscriptionError.Create(response, ct);
}
