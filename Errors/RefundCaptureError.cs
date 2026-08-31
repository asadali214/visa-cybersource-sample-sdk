using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class RefundCaptureError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private RefundCaptureError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static RefundCaptureError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static RefundCaptureError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<RefundCaptureError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RefundCaptureErrorResponse : IErrorResponse<RefundCaptureError>
{
    public static RefundCaptureErrorResponse Instance { get; } = new();

    private RefundCaptureErrorResponse()
    {
    }

    public Task<RefundCaptureError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RefundCaptureError.Create(response, ct);
}
