using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetSubscription2Error : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetSubscription2Error(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetSubscription2Error AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetSubscription2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetSubscription2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSubscription2ErrorResponse : IErrorResponse<GetSubscription2Error>
{
    public static GetSubscription2ErrorResponse Instance { get; } = new();

    private GetSubscription2ErrorResponse()
    {
    }

    public Task<GetSubscription2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetSubscription2Error.Create(response, ct);
}
