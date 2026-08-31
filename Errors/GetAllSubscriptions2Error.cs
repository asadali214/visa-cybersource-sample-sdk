using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetAllSubscriptions2Error : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetAllSubscriptions2Error(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetAllSubscriptions2Error AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetAllSubscriptions2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetAllSubscriptions2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAllSubscriptions2ErrorResponse : IErrorResponse<GetAllSubscriptions2Error>
{
    public static GetAllSubscriptions2ErrorResponse Instance { get; } = new();

    private GetAllSubscriptions2ErrorResponse()
    {
    }

    public Task<GetAllSubscriptions2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAllSubscriptions2Error.Create(response, ct);
}
