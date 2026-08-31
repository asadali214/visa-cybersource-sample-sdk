using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreatePullFundsReversalError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreatePullFundsReversalError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreatePullFundsReversalError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreatePullFundsReversalError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreatePullFundsReversalError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreatePullFundsReversalErrorResponse : IErrorResponse<CreatePullFundsReversalError>
{
    public static CreatePullFundsReversalErrorResponse Instance { get; } = new();

    private CreatePullFundsReversalErrorResponse()
    {
    }

    public Task<CreatePullFundsReversalError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreatePullFundsReversalError.Create(response, ct);
}
