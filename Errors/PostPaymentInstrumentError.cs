using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostPaymentInstrumentError : ApiError
{
    private readonly Optional<PostPaymentInstrumentException1> _postPaymentInstrumentException1Value;

    private readonly Optional<PostPaymentInstrumentException21> _postPaymentInstrumentException21Value;

    private readonly Optional<PostPaymentInstrumentException31> _postPaymentInstrumentException31Value;

    private readonly Optional<PostPaymentInstrumentException41> _postPaymentInstrumentException41Value;

    private readonly Optional<PostPaymentInstrumentException51> _postPaymentInstrumentException51Value;

    private PostPaymentInstrumentError(Optional<PostPaymentInstrumentException1> postPaymentInstrumentException1Value,
        Optional<PostPaymentInstrumentException21> postPaymentInstrumentException21Value,
        Optional<PostPaymentInstrumentException31> postPaymentInstrumentException31Value,
        Optional<PostPaymentInstrumentException41> postPaymentInstrumentException41Value,
        Optional<PostPaymentInstrumentException51> postPaymentInstrumentException51Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _postPaymentInstrumentException1Value = postPaymentInstrumentException1Value;
        _postPaymentInstrumentException21Value = postPaymentInstrumentException21Value;
        _postPaymentInstrumentException31Value = postPaymentInstrumentException31Value;
        _postPaymentInstrumentException41Value = postPaymentInstrumentException41Value;
        _postPaymentInstrumentException51Value = postPaymentInstrumentException51Value;
    }

    private static PostPaymentInstrumentError AsPostPaymentInstrumentException1(PostPaymentInstrumentException1 value) =>
        new(Optional<PostPaymentInstrumentException1>.Some(value), default, default, default, default, default);

    private static PostPaymentInstrumentError AsPostPaymentInstrumentException21(PostPaymentInstrumentException21 value) =>
        new(default, Optional<PostPaymentInstrumentException21>.Some(value), default, default, default, default);

    private static PostPaymentInstrumentError AsPostPaymentInstrumentException31(PostPaymentInstrumentException31 value) =>
        new(default, default, Optional<PostPaymentInstrumentException31>.Some(value), default, default, default);

    private static PostPaymentInstrumentError AsPostPaymentInstrumentException41(PostPaymentInstrumentException41 value) =>
        new(default, default, default, Optional<PostPaymentInstrumentException41>.Some(value), default, default);

    private static PostPaymentInstrumentError AsPostPaymentInstrumentException51(PostPaymentInstrumentException51 value) =>
        new(default, default, default, default, Optional<PostPaymentInstrumentException51>.Some(value), default);

    private static PostPaymentInstrumentError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPostPaymentInstrumentException1(out PostPaymentInstrumentException1 value) =>
        _postPaymentInstrumentException1Value.TryGetValue(out value);

    public bool TryGetPostPaymentInstrumentException21(out PostPaymentInstrumentException21 value) =>
        _postPaymentInstrumentException21Value.TryGetValue(out value);

    public bool TryGetPostPaymentInstrumentException31(out PostPaymentInstrumentException31 value) =>
        _postPaymentInstrumentException31Value.TryGetValue(out value);

    public bool TryGetPostPaymentInstrumentException41(out PostPaymentInstrumentException41 value) =>
        _postPaymentInstrumentException41Value.TryGetValue(out value);

    public bool TryGetPostPaymentInstrumentException51(out PostPaymentInstrumentException51 value) =>
        _postPaymentInstrumentException51Value.TryGetValue(out value);

    internal static Task<PostPaymentInstrumentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PostPaymentInstrumentException1>(response, ct).As(AsPostPaymentInstrumentException1),
            403 => FromJson<PostPaymentInstrumentException21>(response, ct).As(AsPostPaymentInstrumentException21),
            409 => FromJson<PostPaymentInstrumentException31>(response, ct).As(AsPostPaymentInstrumentException31),
            424 => FromJson<PostPaymentInstrumentException41>(response, ct).As(AsPostPaymentInstrumentException41),
            500 => FromJson<PostPaymentInstrumentException51>(response, ct).As(AsPostPaymentInstrumentException51),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPaymentInstrumentErrorResponse : IErrorResponse<PostPaymentInstrumentError>
{
    public static PostPaymentInstrumentErrorResponse Instance { get; } = new();

    private PostPaymentInstrumentErrorResponse()
    {
    }

    public Task<PostPaymentInstrumentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPaymentInstrumentError.Create(response, ct);
}
