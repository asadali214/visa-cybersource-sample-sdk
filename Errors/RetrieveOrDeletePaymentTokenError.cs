using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class RetrieveOrDeletePaymentTokenError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private RetrieveOrDeletePaymentTokenError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static RetrieveOrDeletePaymentTokenError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static RetrieveOrDeletePaymentTokenError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<RetrieveOrDeletePaymentTokenError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RetrieveOrDeletePaymentTokenErrorResponse : IErrorResponse<RetrieveOrDeletePaymentTokenError>
{
    public static RetrieveOrDeletePaymentTokenErrorResponse Instance { get; } = new();

    private RetrieveOrDeletePaymentTokenErrorResponse()
    {
    }

    public Task<RetrieveOrDeletePaymentTokenError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RetrieveOrDeletePaymentTokenError.Create(response, ct);
}
