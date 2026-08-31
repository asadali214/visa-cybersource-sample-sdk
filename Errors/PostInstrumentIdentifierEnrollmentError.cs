using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostInstrumentIdentifierEnrollmentError : ApiError
{
    private readonly Optional<PostInstrumentIdentifierEnrollmentException1> _postInstrumentIdentifierEnrollmentException1Value;

    private readonly Optional<PostInstrumentIdentifierEnrollmentException21> _postInstrumentIdentifierEnrollmentException21Value;

    private readonly Optional<PostInstrumentIdentifierEnrollmentException31> _postInstrumentIdentifierEnrollmentException31Value;

    private readonly Optional<PostInstrumentIdentifierEnrollmentException41> _postInstrumentIdentifierEnrollmentException41Value;

    private readonly Optional<PostInstrumentIdentifierEnrollmentException51> _postInstrumentIdentifierEnrollmentException51Value;

    private readonly Optional<PostInstrumentIdentifierEnrollmentException61> _postInstrumentIdentifierEnrollmentException61Value;

    private PostInstrumentIdentifierEnrollmentError(Optional<PostInstrumentIdentifierEnrollmentException1> postInstrumentIdentifierEnrollmentException1Value,
        Optional<PostInstrumentIdentifierEnrollmentException21> postInstrumentIdentifierEnrollmentException21Value,
        Optional<PostInstrumentIdentifierEnrollmentException31> postInstrumentIdentifierEnrollmentException31Value,
        Optional<PostInstrumentIdentifierEnrollmentException41> postInstrumentIdentifierEnrollmentException41Value,
        Optional<PostInstrumentIdentifierEnrollmentException51> postInstrumentIdentifierEnrollmentException51Value,
        Optional<PostInstrumentIdentifierEnrollmentException61> postInstrumentIdentifierEnrollmentException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _postInstrumentIdentifierEnrollmentException1Value = postInstrumentIdentifierEnrollmentException1Value;
        _postInstrumentIdentifierEnrollmentException21Value = postInstrumentIdentifierEnrollmentException21Value;
        _postInstrumentIdentifierEnrollmentException31Value = postInstrumentIdentifierEnrollmentException31Value;
        _postInstrumentIdentifierEnrollmentException41Value = postInstrumentIdentifierEnrollmentException41Value;
        _postInstrumentIdentifierEnrollmentException51Value = postInstrumentIdentifierEnrollmentException51Value;
        _postInstrumentIdentifierEnrollmentException61Value = postInstrumentIdentifierEnrollmentException61Value;
    }

    private static PostInstrumentIdentifierEnrollmentError AsPostInstrumentIdentifierEnrollmentException1(PostInstrumentIdentifierEnrollmentException1 value) =>
        new(Optional<PostInstrumentIdentifierEnrollmentException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static PostInstrumentIdentifierEnrollmentError AsPostInstrumentIdentifierEnrollmentException21(PostInstrumentIdentifierEnrollmentException21 value) =>
        new(default,
            Optional<PostInstrumentIdentifierEnrollmentException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PostInstrumentIdentifierEnrollmentError AsPostInstrumentIdentifierEnrollmentException31(PostInstrumentIdentifierEnrollmentException31 value) =>
        new(default,
            default,
            Optional<PostInstrumentIdentifierEnrollmentException31>.Some(value),
            default,
            default,
            default,
            default);

    private static PostInstrumentIdentifierEnrollmentError AsPostInstrumentIdentifierEnrollmentException41(PostInstrumentIdentifierEnrollmentException41 value) =>
        new(default,
            default,
            default,
            Optional<PostInstrumentIdentifierEnrollmentException41>.Some(value),
            default,
            default,
            default);

    private static PostInstrumentIdentifierEnrollmentError AsPostInstrumentIdentifierEnrollmentException51(PostInstrumentIdentifierEnrollmentException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<PostInstrumentIdentifierEnrollmentException51>.Some(value),
            default,
            default);

    private static PostInstrumentIdentifierEnrollmentError AsPostInstrumentIdentifierEnrollmentException61(PostInstrumentIdentifierEnrollmentException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<PostInstrumentIdentifierEnrollmentException61>.Some(value),
            default);

    private static PostInstrumentIdentifierEnrollmentError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPostInstrumentIdentifierEnrollmentException1(out PostInstrumentIdentifierEnrollmentException1 value) =>
        _postInstrumentIdentifierEnrollmentException1Value.TryGetValue(out value);

    public bool TryGetPostInstrumentIdentifierEnrollmentException21(out PostInstrumentIdentifierEnrollmentException21 value) =>
        _postInstrumentIdentifierEnrollmentException21Value.TryGetValue(out value);

    public bool TryGetPostInstrumentIdentifierEnrollmentException31(out PostInstrumentIdentifierEnrollmentException31 value) =>
        _postInstrumentIdentifierEnrollmentException31Value.TryGetValue(out value);

    public bool TryGetPostInstrumentIdentifierEnrollmentException41(out PostInstrumentIdentifierEnrollmentException41 value) =>
        _postInstrumentIdentifierEnrollmentException41Value.TryGetValue(out value);

    public bool TryGetPostInstrumentIdentifierEnrollmentException51(out PostInstrumentIdentifierEnrollmentException51 value) =>
        _postInstrumentIdentifierEnrollmentException51Value.TryGetValue(out value);

    public bool TryGetPostInstrumentIdentifierEnrollmentException61(out PostInstrumentIdentifierEnrollmentException61 value) =>
        _postInstrumentIdentifierEnrollmentException61Value.TryGetValue(out value);

    internal static Task<PostInstrumentIdentifierEnrollmentError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PostInstrumentIdentifierEnrollmentException1>(response, ct).As(AsPostInstrumentIdentifierEnrollmentException1),
            403 => FromJson<PostInstrumentIdentifierEnrollmentException21>(response, ct).As(AsPostInstrumentIdentifierEnrollmentException21),
            404 => FromJson<PostInstrumentIdentifierEnrollmentException31>(response, ct).As(AsPostInstrumentIdentifierEnrollmentException31),
            410 => FromJson<PostInstrumentIdentifierEnrollmentException41>(response, ct).As(AsPostInstrumentIdentifierEnrollmentException41),
            424 => FromJson<PostInstrumentIdentifierEnrollmentException51>(response, ct).As(AsPostInstrumentIdentifierEnrollmentException51),
            500 => FromJson<PostInstrumentIdentifierEnrollmentException61>(response, ct).As(AsPostInstrumentIdentifierEnrollmentException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostInstrumentIdentifierEnrollmentErrorResponse : IErrorResponse<PostInstrumentIdentifierEnrollmentError>
{
    public static PostInstrumentIdentifierEnrollmentErrorResponse Instance { get; } = new();

    private PostInstrumentIdentifierEnrollmentErrorResponse()
    {
    }

    public Task<PostInstrumentIdentifierEnrollmentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostInstrumentIdentifierEnrollmentError.Create(response, ct);
}
