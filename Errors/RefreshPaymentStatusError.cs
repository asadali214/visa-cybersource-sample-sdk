using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class RefreshPaymentStatusError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private RefreshPaymentStatusError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static RefreshPaymentStatusError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static RefreshPaymentStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<RefreshPaymentStatusError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RefreshPaymentStatusErrorResponse : IErrorResponse<RefreshPaymentStatusError>
{
    public static RefreshPaymentStatusErrorResponse Instance { get; } = new();

    private RefreshPaymentStatusErrorResponse()
    {
    }

    public Task<RefreshPaymentStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RefreshPaymentStatusError.Create(response, ct);
}
