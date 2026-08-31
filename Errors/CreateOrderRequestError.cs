using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateOrderRequestError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreateOrderRequestError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreateOrderRequestError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreateOrderRequestError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreateOrderRequestError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateOrderRequestErrorResponse : IErrorResponse<CreateOrderRequestError>
{
    public static CreateOrderRequestErrorResponse Instance { get; } = new();

    private CreateOrderRequestErrorResponse()
    {
    }

    public Task<CreateOrderRequestError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateOrderRequestError.Create(response, ct);
}
