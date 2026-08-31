using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetDtdv2Error : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetDtdv2Error(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetDtdv2Error AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetDtdv2Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetDtdv2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDtdv2ErrorResponse : IErrorResponse<GetDtdv2Error>
{
    public static GetDtdv2ErrorResponse Instance { get; } = new();

    private GetDtdv2ErrorResponse()
    {
    }

    public Task<GetDtdv2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDtdv2Error.Create(response, ct);
}
