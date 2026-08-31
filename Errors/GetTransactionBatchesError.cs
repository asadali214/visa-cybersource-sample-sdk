using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetTransactionBatchesError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetTransactionBatchesError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetTransactionBatchesError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetTransactionBatchesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetTransactionBatchesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTransactionBatchesErrorResponse : IErrorResponse<GetTransactionBatchesError>
{
    public static GetTransactionBatchesErrorResponse Instance { get; } = new();

    private GetTransactionBatchesErrorResponse()
    {
    }

    public Task<GetTransactionBatchesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTransactionBatchesError.Create(response, ct);
}
