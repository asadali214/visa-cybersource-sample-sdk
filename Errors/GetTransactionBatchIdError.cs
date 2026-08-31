using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetTransactionBatchIdError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetTransactionBatchIdError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetTransactionBatchIdError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetTransactionBatchIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetTransactionBatchIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTransactionBatchIdErrorResponse : IErrorResponse<GetTransactionBatchIdError>
{
    public static GetTransactionBatchIdErrorResponse Instance { get; } = new();

    private GetTransactionBatchIdErrorResponse()
    {
    }

    public Task<GetTransactionBatchIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTransactionBatchIdError.Create(response, ct);
}
