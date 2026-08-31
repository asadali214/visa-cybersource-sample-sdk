using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class VerifyCustomerAddressError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private VerifyCustomerAddressError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static VerifyCustomerAddressError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static VerifyCustomerAddressError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<VerifyCustomerAddressError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class VerifyCustomerAddressErrorResponse : IErrorResponse<VerifyCustomerAddressError>
{
    public static VerifyCustomerAddressErrorResponse Instance { get; } = new();

    private VerifyCustomerAddressErrorResponse()
    {
    }

    public Task<VerifyCustomerAddressError> Map(HttpResponseMessage response, CancellationToken ct) =>
        VerifyCustomerAddressError.Create(response, ct);
}
