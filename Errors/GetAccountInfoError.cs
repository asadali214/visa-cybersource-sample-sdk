using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetAccountInfoError : ApiError
{
    private readonly Optional<BinLookupv400Response1> _binLookupv400Response1Value;

    private readonly Optional<BinLookup403Response1> _binLookup403Response1Value;

    private readonly Optional<GetAccountInfoException1> _getAccountInfoException1Value;

    private GetAccountInfoError(Optional<BinLookupv400Response1> binLookupv400Response1Value,
        Optional<BinLookup403Response1> binLookup403Response1Value,
        Optional<GetAccountInfoException1> getAccountInfoException1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _binLookupv400Response1Value = binLookupv400Response1Value;
        _binLookup403Response1Value = binLookup403Response1Value;
        _getAccountInfoException1Value = getAccountInfoException1Value;
    }

    private static GetAccountInfoError AsBinLookupv400Response1(BinLookupv400Response1 value) =>
        new(Optional<BinLookupv400Response1>.Some(value), default, default, default);

    private static GetAccountInfoError AsBinLookup403Response1(BinLookup403Response1 value) =>
        new(default, Optional<BinLookup403Response1>.Some(value), default, default);

    private static GetAccountInfoError AsGetAccountInfoException1(GetAccountInfoException1 value) =>
        new(default, default, Optional<GetAccountInfoException1>.Some(value), default);

    private static GetAccountInfoError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBinLookupv400Response1(out BinLookupv400Response1 value) =>
        _binLookupv400Response1Value.TryGetValue(out value);

    public bool TryGetBinLookup403Response1(out BinLookup403Response1 value) =>
        _binLookup403Response1Value.TryGetValue(out value);

    public bool TryGetGetAccountInfoException1(out GetAccountInfoException1 value) =>
        _getAccountInfoException1Value.TryGetValue(out value);

    internal static Task<GetAccountInfoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<BinLookupv400Response1>(response, ct).As(AsBinLookupv400Response1),
            403 => FromJson<BinLookup403Response1>(response, ct).As(AsBinLookup403Response1),
            502 => FromJson<GetAccountInfoException1>(response, ct).As(AsGetAccountInfoException1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountInfoErrorResponse : IErrorResponse<GetAccountInfoError>
{
    public static GetAccountInfoErrorResponse Instance { get; } = new();

    private GetAccountInfoErrorResponse()
    {
    }

    public Task<GetAccountInfoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountInfoError.Create(response, ct);
}
