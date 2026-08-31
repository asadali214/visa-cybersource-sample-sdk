using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateReportError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreateReportError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreateReportError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreateReportError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreateReportError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateReportErrorResponse : IErrorResponse<CreateReportError>
{
    public static CreateReportErrorResponse Instance { get; } = new();

    private CreateReportErrorResponse()
    {
    }

    public Task<CreateReportError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateReportError.Create(response, ct);
}
