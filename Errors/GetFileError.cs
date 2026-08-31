using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetFileError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetFileError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetFileError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static GetFileError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetFileError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFileErrorResponse : IErrorResponse<GetFileError>
{
    public static GetFileErrorResponse Instance { get; } = new();

    private GetFileErrorResponse()
    {
    }

    public Task<GetFileError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFileError.Create(response, ct);
}
