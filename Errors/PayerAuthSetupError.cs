using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PayerAuthSetupError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private PayerAuthSetupError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static PayerAuthSetupError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static PayerAuthSetupError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<PayerAuthSetupError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PayerAuthSetupErrorResponse : IErrorResponse<PayerAuthSetupError>
{
    public static PayerAuthSetupErrorResponse Instance { get; } = new();

    private PayerAuthSetupErrorResponse()
    {
    }

    public Task<PayerAuthSetupError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PayerAuthSetupError.Create(response, ct);
}
