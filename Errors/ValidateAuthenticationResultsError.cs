using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class ValidateAuthenticationResultsError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private ValidateAuthenticationResultsError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static ValidateAuthenticationResultsError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static ValidateAuthenticationResultsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<ValidateAuthenticationResultsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ValidateAuthenticationResultsErrorResponse : IErrorResponse<ValidateAuthenticationResultsError>
{
    public static ValidateAuthenticationResultsErrorResponse Instance { get; } = new();

    private ValidateAuthenticationResultsErrorResponse()
    {
    }

    public Task<ValidateAuthenticationResultsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ValidateAuthenticationResultsError.Create(response, ct);
}
