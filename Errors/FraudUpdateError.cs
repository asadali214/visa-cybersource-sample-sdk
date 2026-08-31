using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class FraudUpdateError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private FraudUpdateError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static FraudUpdateError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static FraudUpdateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<FraudUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FraudUpdateErrorResponse : IErrorResponse<FraudUpdateError>
{
    public static FraudUpdateErrorResponse Instance { get; } = new();

    private FraudUpdateErrorResponse()
    {
    }

    public Task<FraudUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FraudUpdateError.Create(response, ct);
}
