using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreatePaymentError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreatePaymentError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreatePaymentError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreatePaymentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreatePaymentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreatePaymentErrorResponse : IErrorResponse<CreatePaymentError>
{
    public static CreatePaymentErrorResponse Instance { get; } = new();

    private CreatePaymentErrorResponse()
    {
    }

    public Task<CreatePaymentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreatePaymentError.Create(response, ct);
}
