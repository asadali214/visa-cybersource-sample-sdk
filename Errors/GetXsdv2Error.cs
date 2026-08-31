using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetXsdv2Error : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetXsdv2Error(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetXsdv2Error AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetXsdv2Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetXsdv2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetXsdv2ErrorResponse : IErrorResponse<GetXsdv2Error>
{
    public static GetXsdv2ErrorResponse Instance { get; } = new();

    private GetXsdv2ErrorResponse()
    {
    }

    public Task<GetXsdv2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetXsdv2Error.Create(response, ct);
}
