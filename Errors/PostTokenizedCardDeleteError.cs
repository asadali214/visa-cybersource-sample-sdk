using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostTokenizedCardDeleteError : ApiError
{
    private readonly Optional<PostTokenizedCardDeleteException1> _postTokenizedCardDeleteException1Value;

    private readonly Optional<PostTokenizedCardDeleteException21> _postTokenizedCardDeleteException21Value;

    private readonly Optional<PostTokenizedCardDeleteException31> _postTokenizedCardDeleteException31Value;

    private readonly Optional<PostTokenizedCardDeleteException41> _postTokenizedCardDeleteException41Value;

    private readonly Optional<PostTokenizedCardDeleteException51> _postTokenizedCardDeleteException51Value;

    private readonly Optional<PostTokenizedCardDeleteException61> _postTokenizedCardDeleteException61Value;

    private readonly Optional<PostTokenizedCardDeleteException71> _postTokenizedCardDeleteException71Value;

    private PostTokenizedCardDeleteError(Optional<PostTokenizedCardDeleteException1> postTokenizedCardDeleteException1Value,
        Optional<PostTokenizedCardDeleteException21> postTokenizedCardDeleteException21Value,
        Optional<PostTokenizedCardDeleteException31> postTokenizedCardDeleteException31Value,
        Optional<PostTokenizedCardDeleteException41> postTokenizedCardDeleteException41Value,
        Optional<PostTokenizedCardDeleteException51> postTokenizedCardDeleteException51Value,
        Optional<PostTokenizedCardDeleteException61> postTokenizedCardDeleteException61Value,
        Optional<PostTokenizedCardDeleteException71> postTokenizedCardDeleteException71Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _postTokenizedCardDeleteException1Value = postTokenizedCardDeleteException1Value;
        _postTokenizedCardDeleteException21Value = postTokenizedCardDeleteException21Value;
        _postTokenizedCardDeleteException31Value = postTokenizedCardDeleteException31Value;
        _postTokenizedCardDeleteException41Value = postTokenizedCardDeleteException41Value;
        _postTokenizedCardDeleteException51Value = postTokenizedCardDeleteException51Value;
        _postTokenizedCardDeleteException61Value = postTokenizedCardDeleteException61Value;
        _postTokenizedCardDeleteException71Value = postTokenizedCardDeleteException71Value;
    }

    private static PostTokenizedCardDeleteError AsPostTokenizedCardDeleteException1(PostTokenizedCardDeleteException1 value) =>
        new(Optional<PostTokenizedCardDeleteException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    private static PostTokenizedCardDeleteError AsPostTokenizedCardDeleteException21(PostTokenizedCardDeleteException21 value) =>
        new(default,
            Optional<PostTokenizedCardDeleteException21>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static PostTokenizedCardDeleteError AsPostTokenizedCardDeleteException31(PostTokenizedCardDeleteException31 value) =>
        new(default,
            default,
            Optional<PostTokenizedCardDeleteException31>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PostTokenizedCardDeleteError AsPostTokenizedCardDeleteException41(PostTokenizedCardDeleteException41 value) =>
        new(default,
            default,
            default,
            Optional<PostTokenizedCardDeleteException41>.Some(value),
            default,
            default,
            default,
            default);

    private static PostTokenizedCardDeleteError AsPostTokenizedCardDeleteException51(PostTokenizedCardDeleteException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<PostTokenizedCardDeleteException51>.Some(value),
            default,
            default,
            default);

    private static PostTokenizedCardDeleteError AsPostTokenizedCardDeleteException61(PostTokenizedCardDeleteException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<PostTokenizedCardDeleteException61>.Some(value),
            default,
            default);

    private static PostTokenizedCardDeleteError AsPostTokenizedCardDeleteException71(PostTokenizedCardDeleteException71 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<PostTokenizedCardDeleteException71>.Some(value),
            default);

    private static PostTokenizedCardDeleteError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPostTokenizedCardDeleteException1(out PostTokenizedCardDeleteException1 value) =>
        _postTokenizedCardDeleteException1Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardDeleteException21(out PostTokenizedCardDeleteException21 value) =>
        _postTokenizedCardDeleteException21Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardDeleteException31(out PostTokenizedCardDeleteException31 value) =>
        _postTokenizedCardDeleteException31Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardDeleteException41(out PostTokenizedCardDeleteException41 value) =>
        _postTokenizedCardDeleteException41Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardDeleteException51(out PostTokenizedCardDeleteException51 value) =>
        _postTokenizedCardDeleteException51Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardDeleteException61(out PostTokenizedCardDeleteException61 value) =>
        _postTokenizedCardDeleteException61Value.TryGetValue(out value);

    public bool TryGetPostTokenizedCardDeleteException71(out PostTokenizedCardDeleteException71 value) =>
        _postTokenizedCardDeleteException71Value.TryGetValue(out value);

    internal static Task<PostTokenizedCardDeleteError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PostTokenizedCardDeleteException1>(response, ct).As(AsPostTokenizedCardDeleteException1),
            403 => FromJson<PostTokenizedCardDeleteException21>(response, ct).As(AsPostTokenizedCardDeleteException21),
            404 => FromJson<PostTokenizedCardDeleteException31>(response, ct).As(AsPostTokenizedCardDeleteException31),
            409 => FromJson<PostTokenizedCardDeleteException41>(response, ct).As(AsPostTokenizedCardDeleteException41),
            410 => FromJson<PostTokenizedCardDeleteException51>(response, ct).As(AsPostTokenizedCardDeleteException51),
            424 => FromJson<PostTokenizedCardDeleteException61>(response, ct).As(AsPostTokenizedCardDeleteException61),
            500 => FromJson<PostTokenizedCardDeleteException71>(response, ct).As(AsPostTokenizedCardDeleteException71),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostTokenizedCardDeleteErrorResponse : IErrorResponse<PostTokenizedCardDeleteError>
{
    public static PostTokenizedCardDeleteErrorResponse Instance { get; } = new();

    private PostTokenizedCardDeleteErrorResponse()
    {
    }

    public Task<PostTokenizedCardDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostTokenizedCardDeleteError.Create(response, ct);
}
