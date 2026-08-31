using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreatePullFundsTransferError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreatePullFundsTransferError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreatePullFundsTransferError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreatePullFundsTransferError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreatePullFundsTransferError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreatePullFundsTransferErrorResponse : IErrorResponse<CreatePullFundsTransferError>
{
    public static CreatePullFundsTransferErrorResponse Instance { get; } = new();

    private CreatePullFundsTransferErrorResponse()
    {
    }

    public Task<CreatePullFundsTransferError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreatePullFundsTransferError.Create(response, ct);
}
