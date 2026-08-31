using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateCreditError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreateCreditError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreateCreditError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreateCreditError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreateCreditError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateCreditErrorResponse : IErrorResponse<CreateCreditError>
{
    public static CreateCreditErrorResponse Instance { get; } = new();

    private CreateCreditErrorResponse()
    {
    }

    public Task<CreateCreditError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateCreditError.Create(response, ct);
}
