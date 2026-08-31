using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class ValidateExportComplianceError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private ValidateExportComplianceError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static ValidateExportComplianceError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static ValidateExportComplianceError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<ValidateExportComplianceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ValidateExportComplianceErrorResponse : IErrorResponse<ValidateExportComplianceError>
{
    public static ValidateExportComplianceErrorResponse Instance { get; } = new();

    private ValidateExportComplianceErrorResponse()
    {
    }

    public Task<ValidateExportComplianceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ValidateExportComplianceError.Create(response, ct);
}
