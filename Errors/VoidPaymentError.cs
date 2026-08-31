using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class VoidPaymentError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private VoidPaymentError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static VoidPaymentError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static VoidPaymentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<VoidPaymentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class VoidPaymentErrorResponse : IErrorResponse<VoidPaymentError>
{
    public static VoidPaymentErrorResponse Instance { get; } = new();

    private VoidPaymentErrorResponse()
    {
    }

    public Task<VoidPaymentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        VoidPaymentError.Create(response, ct);
}
