using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateSessionRequestError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreateSessionRequestError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreateSessionRequestError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreateSessionRequestError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreateSessionRequestError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateSessionRequestErrorResponse : IErrorResponse<CreateSessionRequestError>
{
    public static CreateSessionRequestErrorResponse Instance { get; } = new();

    private CreateSessionRequestErrorResponse()
    {
    }

    public Task<CreateSessionRequestError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateSessionRequestError.Create(response, ct);
}
