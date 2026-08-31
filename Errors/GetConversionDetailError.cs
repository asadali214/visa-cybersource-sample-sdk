using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetConversionDetailError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetConversionDetailError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetConversionDetailError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetConversionDetailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetConversionDetailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetConversionDetailErrorResponse : IErrorResponse<GetConversionDetailError>
{
    public static GetConversionDetailErrorResponse Instance { get; } = new();

    private GetConversionDetailErrorResponse()
    {
    }

    public Task<GetConversionDetailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetConversionDetailError.Create(response, ct);
}
