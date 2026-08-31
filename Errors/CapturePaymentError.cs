using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CapturePaymentError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CapturePaymentError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CapturePaymentError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CapturePaymentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CapturePaymentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CapturePaymentErrorResponse : IErrorResponse<CapturePaymentError>
{
    public static CapturePaymentErrorResponse Instance { get; } = new();

    private CapturePaymentErrorResponse()
    {
    }

    public Task<CapturePaymentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CapturePaymentError.Create(response, ct);
}
