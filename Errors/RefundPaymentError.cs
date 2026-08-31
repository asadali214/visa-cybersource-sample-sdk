using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class RefundPaymentError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private RefundPaymentError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static RefundPaymentError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static RefundPaymentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<RefundPaymentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RefundPaymentErrorResponse : IErrorResponse<RefundPaymentError>
{
    public static RefundPaymentErrorResponse Instance { get; } = new();

    private RefundPaymentErrorResponse()
    {
    }

    public Task<RefundPaymentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RefundPaymentError.Create(response, ct);
}
