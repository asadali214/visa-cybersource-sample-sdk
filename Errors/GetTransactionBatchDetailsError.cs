using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetTransactionBatchDetailsError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetTransactionBatchDetailsError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetTransactionBatchDetailsError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetTransactionBatchDetailsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetTransactionBatchDetailsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTransactionBatchDetailsErrorResponse : IErrorResponse<GetTransactionBatchDetailsError>
{
    public static GetTransactionBatchDetailsErrorResponse Instance { get; } = new();

    private GetTransactionBatchDetailsErrorResponse()
    {
    }

    public Task<GetTransactionBatchDetailsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTransactionBatchDetailsError.Create(response, ct);
}
