using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class UpdateSessionRequestError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private UpdateSessionRequestError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static UpdateSessionRequestError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static UpdateSessionRequestError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<UpdateSessionRequestError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateSessionRequestErrorResponse : IErrorResponse<UpdateSessionRequestError>
{
    public static UpdateSessionRequestErrorResponse Instance { get; } = new();

    private UpdateSessionRequestErrorResponse()
    {
    }

    public Task<UpdateSessionRequestError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateSessionRequestError.Create(response, ct);
}
