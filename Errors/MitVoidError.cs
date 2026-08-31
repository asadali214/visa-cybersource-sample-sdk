using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class MitVoidError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private MitVoidError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static MitVoidError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static MitVoidError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<MitVoidError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MitVoidErrorResponse : IErrorResponse<MitVoidError>
{
    public static MitVoidErrorResponse Instance { get; } = new();

    private MitVoidErrorResponse()
    {
    }

    public Task<MitVoidError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MitVoidError.Create(response, ct);
}
