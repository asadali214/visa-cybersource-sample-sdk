using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class VoidRefundError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private VoidRefundError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static VoidRefundError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static VoidRefundError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<VoidRefundError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class VoidRefundErrorResponse : IErrorResponse<VoidRefundError>
{
    public static VoidRefundErrorResponse Instance { get; } = new();

    private VoidRefundErrorResponse()
    {
    }

    public Task<VoidRefundError> Map(HttpResponseMessage response, CancellationToken ct) =>
        VoidRefundError.Create(response, ct);
}
