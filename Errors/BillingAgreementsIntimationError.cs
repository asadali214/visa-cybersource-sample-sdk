using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class BillingAgreementsIntimationError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private BillingAgreementsIntimationError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static BillingAgreementsIntimationError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static BillingAgreementsIntimationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<BillingAgreementsIntimationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BillingAgreementsIntimationErrorResponse : IErrorResponse<BillingAgreementsIntimationError>
{
    public static BillingAgreementsIntimationErrorResponse Instance { get; } = new();

    private BillingAgreementsIntimationErrorResponse()
    {
    }

    public Task<BillingAgreementsIntimationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BillingAgreementsIntimationError.Create(response, ct);
}
