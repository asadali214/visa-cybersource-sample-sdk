using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CommentDecisionManagerCaseError : ApiError
{
    private readonly Optional<CommentDecisionManagerCaseException1> _commentDecisionManagerCaseException1Value;

    private readonly Optional<CommentDecisionManagerCaseException21> _commentDecisionManagerCaseException21Value;

    private readonly Optional<CommentDecisionManagerCaseException31> _commentDecisionManagerCaseException31Value;

    private readonly Optional<CommentDecisionManagerCaseException41> _commentDecisionManagerCaseException41Value;

    private readonly Optional<CommentDecisionManagerCaseException51> _commentDecisionManagerCaseException51Value;

    private readonly Optional<CommentDecisionManagerCaseException61> _commentDecisionManagerCaseException61Value;

    private CommentDecisionManagerCaseError(Optional<CommentDecisionManagerCaseException1> commentDecisionManagerCaseException1Value,
        Optional<CommentDecisionManagerCaseException21> commentDecisionManagerCaseException21Value,
        Optional<CommentDecisionManagerCaseException31> commentDecisionManagerCaseException31Value,
        Optional<CommentDecisionManagerCaseException41> commentDecisionManagerCaseException41Value,
        Optional<CommentDecisionManagerCaseException51> commentDecisionManagerCaseException51Value,
        Optional<CommentDecisionManagerCaseException61> commentDecisionManagerCaseException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _commentDecisionManagerCaseException1Value = commentDecisionManagerCaseException1Value;
        _commentDecisionManagerCaseException21Value = commentDecisionManagerCaseException21Value;
        _commentDecisionManagerCaseException31Value = commentDecisionManagerCaseException31Value;
        _commentDecisionManagerCaseException41Value = commentDecisionManagerCaseException41Value;
        _commentDecisionManagerCaseException51Value = commentDecisionManagerCaseException51Value;
        _commentDecisionManagerCaseException61Value = commentDecisionManagerCaseException61Value;
    }

    private static CommentDecisionManagerCaseError AsCommentDecisionManagerCaseException1(CommentDecisionManagerCaseException1 value) =>
        new(Optional<CommentDecisionManagerCaseException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static CommentDecisionManagerCaseError AsCommentDecisionManagerCaseException21(CommentDecisionManagerCaseException21 value) =>
        new(default,
            Optional<CommentDecisionManagerCaseException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static CommentDecisionManagerCaseError AsCommentDecisionManagerCaseException31(CommentDecisionManagerCaseException31 value) =>
        new(default,
            default,
            Optional<CommentDecisionManagerCaseException31>.Some(value),
            default,
            default,
            default,
            default);

    private static CommentDecisionManagerCaseError AsCommentDecisionManagerCaseException41(CommentDecisionManagerCaseException41 value) =>
        new(default,
            default,
            default,
            Optional<CommentDecisionManagerCaseException41>.Some(value),
            default,
            default,
            default);

    private static CommentDecisionManagerCaseError AsCommentDecisionManagerCaseException51(CommentDecisionManagerCaseException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<CommentDecisionManagerCaseException51>.Some(value),
            default,
            default);

    private static CommentDecisionManagerCaseError AsCommentDecisionManagerCaseException61(CommentDecisionManagerCaseException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<CommentDecisionManagerCaseException61>.Some(value),
            default);

    private static CommentDecisionManagerCaseError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetCommentDecisionManagerCaseException1(out CommentDecisionManagerCaseException1 value) =>
        _commentDecisionManagerCaseException1Value.TryGetValue(out value);

    public bool TryGetCommentDecisionManagerCaseException21(out CommentDecisionManagerCaseException21 value) =>
        _commentDecisionManagerCaseException21Value.TryGetValue(out value);

    public bool TryGetCommentDecisionManagerCaseException31(out CommentDecisionManagerCaseException31 value) =>
        _commentDecisionManagerCaseException31Value.TryGetValue(out value);

    public bool TryGetCommentDecisionManagerCaseException41(out CommentDecisionManagerCaseException41 value) =>
        _commentDecisionManagerCaseException41Value.TryGetValue(out value);

    public bool TryGetCommentDecisionManagerCaseException51(out CommentDecisionManagerCaseException51 value) =>
        _commentDecisionManagerCaseException51Value.TryGetValue(out value);

    public bool TryGetCommentDecisionManagerCaseException61(out CommentDecisionManagerCaseException61 value) =>
        _commentDecisionManagerCaseException61Value.TryGetValue(out value);

    internal static Task<CommentDecisionManagerCaseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<CommentDecisionManagerCaseException1>(response, ct).As(AsCommentDecisionManagerCaseException1),
            403 => FromJson<CommentDecisionManagerCaseException21>(response, ct).As(AsCommentDecisionManagerCaseException21),
            422 => FromJson<CommentDecisionManagerCaseException31>(response, ct).As(AsCommentDecisionManagerCaseException31),
            500 => FromJson<CommentDecisionManagerCaseException41>(response, ct).As(AsCommentDecisionManagerCaseException41),
            502 => FromJson<CommentDecisionManagerCaseException51>(response, ct).As(AsCommentDecisionManagerCaseException51),
            503 => FromJson<CommentDecisionManagerCaseException61>(response, ct).As(AsCommentDecisionManagerCaseException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CommentDecisionManagerCaseErrorResponse : IErrorResponse<CommentDecisionManagerCaseError>
{
    public static CommentDecisionManagerCaseErrorResponse Instance { get; } = new();

    private CommentDecisionManagerCaseErrorResponse()
    {
    }

    public Task<CommentDecisionManagerCaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CommentDecisionManagerCaseError.Create(response, ct);
}
