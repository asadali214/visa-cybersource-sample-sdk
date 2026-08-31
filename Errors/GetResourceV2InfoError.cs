using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetResourceV2InfoError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetResourceV2InfoError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetResourceV2InfoError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetResourceV2InfoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetResourceV2InfoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetResourceV2InfoErrorResponse : IErrorResponse<GetResourceV2InfoError>
{
    public static GetResourceV2InfoErrorResponse Instance { get; } = new();

    private GetResourceV2InfoErrorResponse()
    {
    }

    public Task<GetResourceV2InfoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetResourceV2InfoError.Create(response, ct);
}
