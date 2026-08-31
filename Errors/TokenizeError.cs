using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class TokenizeError : ApiError
{
    private readonly Optional<TokenizeException1> _tokenizeException1Value;

    private readonly Optional<TokenizeException21> _tokenizeException21Value;

    private readonly Optional<TokenizeException31> _tokenizeException31Value;

    private readonly Optional<TokenizeException41> _tokenizeException41Value;

    private TokenizeError(Optional<TokenizeException1> tokenizeException1Value,
        Optional<TokenizeException21> tokenizeException21Value,
        Optional<TokenizeException31> tokenizeException31Value,
        Optional<TokenizeException41> tokenizeException41Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _tokenizeException1Value = tokenizeException1Value;
        _tokenizeException21Value = tokenizeException21Value;
        _tokenizeException31Value = tokenizeException31Value;
        _tokenizeException41Value = tokenizeException41Value;
    }

    private static TokenizeError AsTokenizeException1(TokenizeException1 value) =>
        new(Optional<TokenizeException1>.Some(value), default, default, default, default);

    private static TokenizeError AsTokenizeException21(TokenizeException21 value) =>
        new(default, Optional<TokenizeException21>.Some(value), default, default, default);

    private static TokenizeError AsTokenizeException31(TokenizeException31 value) =>
        new(default, default, Optional<TokenizeException31>.Some(value), default, default);

    private static TokenizeError AsTokenizeException41(TokenizeException41 value) =>
        new(default, default, default, Optional<TokenizeException41>.Some(value), default);

    private static TokenizeError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetTokenizeException1(out TokenizeException1 value) =>
        _tokenizeException1Value.TryGetValue(out value);

    public bool TryGetTokenizeException21(out TokenizeException21 value) =>
        _tokenizeException21Value.TryGetValue(out value);

    public bool TryGetTokenizeException31(out TokenizeException31 value) =>
        _tokenizeException31Value.TryGetValue(out value);

    public bool TryGetTokenizeException41(out TokenizeException41 value) =>
        _tokenizeException41Value.TryGetValue(out value);

    internal static Task<TokenizeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<TokenizeException1>(response, ct).As(AsTokenizeException1),
            403 => FromJson<TokenizeException21>(response, ct).As(AsTokenizeException21),
            424 => FromJson<TokenizeException31>(response, ct).As(AsTokenizeException31),
            500 => FromJson<TokenizeException41>(response, ct).As(AsTokenizeException41),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TokenizeErrorResponse : IErrorResponse<TokenizeError>
{
    public static TokenizeErrorResponse Instance { get; } = new();

    private TokenizeErrorResponse()
    {
    }

    public Task<TokenizeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        TokenizeError.Create(response, ct);
}
