using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class VoidCaptureError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private VoidCaptureError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static VoidCaptureError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static VoidCaptureError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<VoidCaptureError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class VoidCaptureErrorResponse : IErrorResponse<VoidCaptureError>
{
    public static VoidCaptureErrorResponse Instance { get; } = new();

    private VoidCaptureErrorResponse()
    {
    }

    public Task<VoidCaptureError> Map(HttpResponseMessage response, CancellationToken ct) =>
        VoidCaptureError.Create(response, ct);
}
