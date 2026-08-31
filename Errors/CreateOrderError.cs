using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateOrderError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreateOrderError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreateOrderError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreateOrderError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreateOrderError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateOrderErrorResponse : IErrorResponse<CreateOrderError>
{
    public static CreateOrderErrorResponse Instance { get; } = new();

    private CreateOrderErrorResponse()
    {
    }

    public Task<CreateOrderError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateOrderError.Create(response, ct);
}
