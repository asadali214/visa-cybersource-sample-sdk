using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateSearchError : ApiError
{
    private readonly Optional<TssV2TransactionsPost400Response1> _tssV2TransactionsPost400Response1Value;

    private readonly Optional<TssV2TransactionsPost502Response1> _tssV2TransactionsPost502Response1Value;

    private CreateSearchError(Optional<TssV2TransactionsPost400Response1> tssV2TransactionsPost400Response1Value,
        Optional<TssV2TransactionsPost502Response1> tssV2TransactionsPost502Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _tssV2TransactionsPost400Response1Value = tssV2TransactionsPost400Response1Value;
        _tssV2TransactionsPost502Response1Value = tssV2TransactionsPost502Response1Value;
    }

    private static CreateSearchError AsTssV2TransactionsPost400Response1(TssV2TransactionsPost400Response1 value) =>
        new(Optional<TssV2TransactionsPost400Response1>.Some(value), default, default);

    private static CreateSearchError AsTssV2TransactionsPost502Response1(TssV2TransactionsPost502Response1 value) =>
        new(default, Optional<TssV2TransactionsPost502Response1>.Some(value), default);

    private static CreateSearchError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetTssV2TransactionsPost400Response1(out TssV2TransactionsPost400Response1 value) =>
        _tssV2TransactionsPost400Response1Value.TryGetValue(out value);

    public bool TryGetTssV2TransactionsPost502Response1(out TssV2TransactionsPost502Response1 value) =>
        _tssV2TransactionsPost502Response1Value.TryGetValue(out value);

    internal static Task<CreateSearchError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<TssV2TransactionsPost400Response1>(response, ct).As(AsTssV2TransactionsPost400Response1),
            502 => FromJson<TssV2TransactionsPost502Response1>(response, ct).As(AsTssV2TransactionsPost502Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateSearchErrorResponse : IErrorResponse<CreateSearchError>
{
    public static CreateSearchErrorResponse Instance { get; } = new();

    private CreateSearchErrorResponse()
    {
    }

    public Task<CreateSearchError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateSearchError.Create(response, ct);
}
