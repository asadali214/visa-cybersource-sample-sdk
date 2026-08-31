using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetResourceInfoByReportDefinitionError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetResourceInfoByReportDefinitionError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetResourceInfoByReportDefinitionError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetResourceInfoByReportDefinitionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetResourceInfoByReportDefinitionError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetResourceInfoByReportDefinitionErrorResponse : IErrorResponse<GetResourceInfoByReportDefinitionError>
{
    public static GetResourceInfoByReportDefinitionErrorResponse Instance { get; } = new();

    private GetResourceInfoByReportDefinitionErrorResponse()
    {
    }

    public Task<GetResourceInfoByReportDefinitionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetResourceInfoByReportDefinitionError.Create(response, ct);
}
