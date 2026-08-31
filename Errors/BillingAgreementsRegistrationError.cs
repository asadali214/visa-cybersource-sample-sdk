using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class BillingAgreementsRegistrationError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private BillingAgreementsRegistrationError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static BillingAgreementsRegistrationError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static BillingAgreementsRegistrationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<BillingAgreementsRegistrationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BillingAgreementsRegistrationErrorResponse : IErrorResponse<BillingAgreementsRegistrationError>
{
    public static BillingAgreementsRegistrationErrorResponse Instance { get; } = new();

    private BillingAgreementsRegistrationErrorResponse()
    {
    }

    public Task<BillingAgreementsRegistrationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BillingAgreementsRegistrationError.Create(response, ct);
}
