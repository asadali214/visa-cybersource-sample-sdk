using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateSubscription2Error : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreateSubscription2Error(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreateSubscription2Error AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreateSubscription2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreateSubscription2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateSubscription2ErrorResponse : IErrorResponse<CreateSubscription2Error>
{
    public static CreateSubscription2ErrorResponse Instance { get; } = new();

    private CreateSubscription2ErrorResponse()
    {
    }

    public Task<CreateSubscription2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateSubscription2Error.Create(response, ct);
}
