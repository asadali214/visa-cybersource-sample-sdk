using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class AuthReversalError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private AuthReversalError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static AuthReversalError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static AuthReversalError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<AuthReversalError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AuthReversalErrorResponse : IErrorResponse<AuthReversalError>
{
    public static AuthReversalErrorResponse Instance { get; } = new();

    private AuthReversalErrorResponse()
    {
    }

    public Task<AuthReversalError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AuthReversalError.Create(response, ct);
}
