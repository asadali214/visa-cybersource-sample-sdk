using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostInstrumentIdentifierError : ApiError
{
    private readonly Optional<PostInstrumentIdentifierException1> _postInstrumentIdentifierException1Value;

    private readonly Optional<PostInstrumentIdentifierException21> _postInstrumentIdentifierException21Value;

    private readonly Optional<PostInstrumentIdentifierException31> _postInstrumentIdentifierException31Value;

    private readonly Optional<PostInstrumentIdentifierException41> _postInstrumentIdentifierException41Value;

    private readonly Optional<PostInstrumentIdentifierException51> _postInstrumentIdentifierException51Value;

    private PostInstrumentIdentifierError(Optional<PostInstrumentIdentifierException1> postInstrumentIdentifierException1Value,
        Optional<PostInstrumentIdentifierException21> postInstrumentIdentifierException21Value,
        Optional<PostInstrumentIdentifierException31> postInstrumentIdentifierException31Value,
        Optional<PostInstrumentIdentifierException41> postInstrumentIdentifierException41Value,
        Optional<PostInstrumentIdentifierException51> postInstrumentIdentifierException51Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _postInstrumentIdentifierException1Value = postInstrumentIdentifierException1Value;
        _postInstrumentIdentifierException21Value = postInstrumentIdentifierException21Value;
        _postInstrumentIdentifierException31Value = postInstrumentIdentifierException31Value;
        _postInstrumentIdentifierException41Value = postInstrumentIdentifierException41Value;
        _postInstrumentIdentifierException51Value = postInstrumentIdentifierException51Value;
    }

    private static PostInstrumentIdentifierError AsPostInstrumentIdentifierException1(PostInstrumentIdentifierException1 value) =>
        new(Optional<PostInstrumentIdentifierException1>.Some(value), default, default, default, default, default);

    private static PostInstrumentIdentifierError AsPostInstrumentIdentifierException21(PostInstrumentIdentifierException21 value) =>
        new(default, Optional<PostInstrumentIdentifierException21>.Some(value), default, default, default, default);

    private static PostInstrumentIdentifierError AsPostInstrumentIdentifierException31(PostInstrumentIdentifierException31 value) =>
        new(default, default, Optional<PostInstrumentIdentifierException31>.Some(value), default, default, default);

    private static PostInstrumentIdentifierError AsPostInstrumentIdentifierException41(PostInstrumentIdentifierException41 value) =>
        new(default, default, default, Optional<PostInstrumentIdentifierException41>.Some(value), default, default);

    private static PostInstrumentIdentifierError AsPostInstrumentIdentifierException51(PostInstrumentIdentifierException51 value) =>
        new(default, default, default, default, Optional<PostInstrumentIdentifierException51>.Some(value), default);

    private static PostInstrumentIdentifierError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPostInstrumentIdentifierException1(out PostInstrumentIdentifierException1 value) =>
        _postInstrumentIdentifierException1Value.TryGetValue(out value);

    public bool TryGetPostInstrumentIdentifierException21(out PostInstrumentIdentifierException21 value) =>
        _postInstrumentIdentifierException21Value.TryGetValue(out value);

    public bool TryGetPostInstrumentIdentifierException31(out PostInstrumentIdentifierException31 value) =>
        _postInstrumentIdentifierException31Value.TryGetValue(out value);

    public bool TryGetPostInstrumentIdentifierException41(out PostInstrumentIdentifierException41 value) =>
        _postInstrumentIdentifierException41Value.TryGetValue(out value);

    public bool TryGetPostInstrumentIdentifierException51(out PostInstrumentIdentifierException51 value) =>
        _postInstrumentIdentifierException51Value.TryGetValue(out value);

    internal static Task<PostInstrumentIdentifierError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PostInstrumentIdentifierException1>(response, ct).As(AsPostInstrumentIdentifierException1),
            403 => FromJson<PostInstrumentIdentifierException21>(response, ct).As(AsPostInstrumentIdentifierException21),
            409 => FromJson<PostInstrumentIdentifierException31>(response, ct).As(AsPostInstrumentIdentifierException31),
            424 => FromJson<PostInstrumentIdentifierException41>(response, ct).As(AsPostInstrumentIdentifierException41),
            500 => FromJson<PostInstrumentIdentifierException51>(response, ct).As(AsPostInstrumentIdentifierException51),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostInstrumentIdentifierErrorResponse : IErrorResponse<PostInstrumentIdentifierError>
{
    public static PostInstrumentIdentifierErrorResponse Instance { get; } = new();

    private PostInstrumentIdentifierErrorResponse()
    {
    }

    public Task<PostInstrumentIdentifierError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostInstrumentIdentifierError.Create(response, ct);
}
