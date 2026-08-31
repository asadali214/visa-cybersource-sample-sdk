using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class DownloadReportError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DownloadReportError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DownloadReportError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static DownloadReportError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<DownloadReportError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DownloadReportErrorResponse : IErrorResponse<DownloadReportError>
{
    public static DownloadReportErrorResponse Instance { get; } = new();

    private DownloadReportErrorResponse()
    {
    }

    public Task<DownloadReportError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DownloadReportError.Create(response, ct);
}
