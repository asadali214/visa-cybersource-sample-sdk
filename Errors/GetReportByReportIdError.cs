using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetReportByReportIdError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetReportByReportIdError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetReportByReportIdError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetReportByReportIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetReportByReportIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetReportByReportIdErrorResponse : IErrorResponse<GetReportByReportIdError>
{
    public static GetReportByReportIdErrorResponse Instance { get; } = new();

    private GetReportByReportIdErrorResponse()
    {
    }

    public Task<GetReportByReportIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetReportByReportIdError.Create(response, ct);
}
