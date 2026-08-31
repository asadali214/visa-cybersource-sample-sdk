using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetPurchaseAndRefundDetailsError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetPurchaseAndRefundDetailsError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetPurchaseAndRefundDetailsError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetPurchaseAndRefundDetailsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetPurchaseAndRefundDetailsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPurchaseAndRefundDetailsErrorResponse : IErrorResponse<GetPurchaseAndRefundDetailsError>
{
    public static GetPurchaseAndRefundDetailsErrorResponse Instance { get; } = new();

    private GetPurchaseAndRefundDetailsErrorResponse()
    {
    }

    public Task<GetPurchaseAndRefundDetailsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPurchaseAndRefundDetailsError.Create(response, ct);
}
