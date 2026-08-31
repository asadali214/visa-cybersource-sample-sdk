using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetPaymentBatchSummaryError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetPaymentBatchSummaryError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetPaymentBatchSummaryError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetPaymentBatchSummaryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetPaymentBatchSummaryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPaymentBatchSummaryErrorResponse : IErrorResponse<GetPaymentBatchSummaryError>
{
    public static GetPaymentBatchSummaryErrorResponse Instance { get; } = new();

    private GetPaymentBatchSummaryErrorResponse()
    {
    }

    public Task<GetPaymentBatchSummaryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPaymentBatchSummaryError.Create(response, ct);
}
