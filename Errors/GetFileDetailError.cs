using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetFileDetailError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetFileDetailError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetFileDetailError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetFileDetailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetFileDetailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFileDetailErrorResponse : IErrorResponse<GetFileDetailError>
{
    public static GetFileDetailErrorResponse Instance { get; } = new();

    private GetFileDetailErrorResponse()
    {
    }

    public Task<GetFileDetailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFileDetailError.Create(response, ct);
}
