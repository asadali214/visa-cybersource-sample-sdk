using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class IncrementAuthError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private IncrementAuthError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static IncrementAuthError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static IncrementAuthError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<IncrementAuthError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class IncrementAuthErrorResponse : IErrorResponse<IncrementAuthError>
{
    public static IncrementAuthErrorResponse Instance { get; } = new();

    private IncrementAuthErrorResponse()
    {
    }

    public Task<IncrementAuthError> Map(HttpResponseMessage response, CancellationToken ct) =>
        IncrementAuthError.Create(response, ct);
}
