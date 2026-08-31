using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreatePullFundsRefundError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreatePullFundsRefundError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreatePullFundsRefundError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreatePullFundsRefundError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreatePullFundsRefundError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreatePullFundsRefundErrorResponse : IErrorResponse<CreatePullFundsRefundError>
{
    public static CreatePullFundsRefundErrorResponse Instance { get; } = new();

    private CreatePullFundsRefundErrorResponse()
    {
    }

    public Task<CreatePullFundsRefundError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreatePullFundsRefundError.Create(response, ct);
}
