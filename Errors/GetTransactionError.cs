using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetTransactionError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetTransactionError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetTransactionError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetTransactionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetTransactionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTransactionErrorResponse : IErrorResponse<GetTransactionError>
{
    public static GetTransactionErrorResponse Instance { get; } = new();

    private GetTransactionErrorResponse()
    {
    }

    public Task<GetTransactionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTransactionError.Create(response, ct);
}
