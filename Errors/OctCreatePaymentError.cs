using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class OctCreatePaymentError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private OctCreatePaymentError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static OctCreatePaymentError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static OctCreatePaymentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<OctCreatePaymentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OctCreatePaymentErrorResponse : IErrorResponse<OctCreatePaymentError>
{
    public static OctCreatePaymentErrorResponse Instance { get; } = new();

    private OctCreatePaymentErrorResponse()
    {
    }

    public Task<OctCreatePaymentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OctCreatePaymentError.Create(response, ct);
}
