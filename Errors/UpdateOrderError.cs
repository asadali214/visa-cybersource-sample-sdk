using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class UpdateOrderError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private UpdateOrderError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static UpdateOrderError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static UpdateOrderError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<UpdateOrderError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateOrderErrorResponse : IErrorResponse<UpdateOrderError>
{
    public static UpdateOrderErrorResponse Instance { get; } = new();

    private UpdateOrderErrorResponse()
    {
    }

    public Task<UpdateOrderError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateOrderError.Create(response, ct);
}
