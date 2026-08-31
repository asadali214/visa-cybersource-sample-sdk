using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostTokenizedCardError : ApiError
{
    private readonly Optional<PostTokenizedCardException1> _postTokenizedCardException1Value;

    private readonly Optional<PostTokenizedCardException21> _postTokenizedCardException21Value;

    private readonly Optional<PostTokenizedCardException31> _postTokenizedCardException31Value;

    private readonly Optional<PostTokenizedCardException41> _postTokenizedCardException41Value;

    private readonly Optional<PostTokenizedCardException51> _postTokenizedCardException51Value;

    private PostTokenizedCardError(Optional<PostTokenizedCardException1> postTokenizedCardException1Value,
        Optional<PostTokenizedCardException21> postTokenizedCardException21Value,
        Optional<PostTokenizedCardException31> postTokenizedCardException31Value,
        Optional<PostTokenizedCardException41> postTokenizedCardException41Value,
        Optional<PostTokenizedCardException51> postTokenizedCardException51Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _postTokenizedCardException1Value = postTokenizedCardException1Value;
        _postTokenizedCardException21Value = postTokenizedCardException21Value;
        _postTokenizedCardException31Value = postTokenizedCardException31Value;
        _postTokenizedCardException41Value = postTokenizedCardException41Value;
        _postTokenizedCardException51Value = postTokenizedCardException51Value;
    }

    private static PostTokenizedCardError AsPostTokenizedCardException1(PostTokenizedCardException1 value) =>
        new(Optional<PostTokenizedCardException1>.Some(value), default, default, default, default, default);

    private static PostTokenizedCardError AsPostTokenizedCardException21(PostTokenizedCardException21 value) =>
        new(default, Optional<PostTokenizedCardException21>.Some(value), default, default, default, default);

    private static PostTokenizedCardError AsPostTokenizedCardException31(PostTokenizedCardException31 value) =>
        new(default, default, Optional<PostTokenizedCardException31>.Some(value), default, default, default);

    private static PostTokenizedCardError AsPostTokenizedCardException41(PostTokenizedCardException41 value) =>
        new(default, default, default, Optional<PostTokenizedCardException41>.Some(value), default, default);

    private static PostTokenizedCardError AsPostTokenizedCardException51(PostTokenizedCardException51 value) =>
        new(default, default, default, default, Optional<PostTokenizedCardException51>.Some(value), default);

    private static PostTokenizedCardError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPostTokenizedCardException1(out PostTokenizedCardException1 value) =>
        _postTokenizedCardException1Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardException21(out PostTokenizedCardException21 value) =>
        _postTokenizedCardException21Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardException31(out PostTokenizedCardException31 value) =>
        _postTokenizedCardException31Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardException41(out PostTokenizedCardException41 value) =>
        _postTokenizedCardException41Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardException51(out PostTokenizedCardException51 value) =>
        _postTokenizedCardException51Value.TryGetValue(out value);

    internal static Task<PostTokenizedCardError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PostTokenizedCardException1>(response, ct).As(AsPostTokenizedCardException1),
            403 => FromJson<PostTokenizedCardException21>(response, ct).As(AsPostTokenizedCardException21),
            409 => FromJson<PostTokenizedCardException31>(response, ct).As(AsPostTokenizedCardException31),
            424 => FromJson<PostTokenizedCardException41>(response, ct).As(AsPostTokenizedCardException41),
            500 => FromJson<PostTokenizedCardException51>(response, ct).As(AsPostTokenizedCardException51),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostTokenizedCardErrorResponse : IErrorResponse<PostTokenizedCardError>
{
    public static PostTokenizedCardErrorResponse Instance { get; } = new();

    private PostTokenizedCardErrorResponse()
    {
    }

    public Task<PostTokenizedCardError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostTokenizedCardError.Create(response, ct);
}
