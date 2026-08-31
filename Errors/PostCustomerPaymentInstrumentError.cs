using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostCustomerPaymentInstrumentError : ApiError
{
    private readonly Optional<PostCustomerPaymentInstrumentException1> _postCustomerPaymentInstrumentException1Value;

    private readonly Optional<PostCustomerPaymentInstrumentException21> _postCustomerPaymentInstrumentException21Value;

    private readonly Optional<PostCustomerPaymentInstrumentException31> _postCustomerPaymentInstrumentException31Value;

    private readonly Optional<PostCustomerPaymentInstrumentException41> _postCustomerPaymentInstrumentException41Value;

    private readonly Optional<PostCustomerPaymentInstrumentException51> _postCustomerPaymentInstrumentException51Value;

    private PostCustomerPaymentInstrumentError(Optional<PostCustomerPaymentInstrumentException1> postCustomerPaymentInstrumentException1Value,
        Optional<PostCustomerPaymentInstrumentException21> postCustomerPaymentInstrumentException21Value,
        Optional<PostCustomerPaymentInstrumentException31> postCustomerPaymentInstrumentException31Value,
        Optional<PostCustomerPaymentInstrumentException41> postCustomerPaymentInstrumentException41Value,
        Optional<PostCustomerPaymentInstrumentException51> postCustomerPaymentInstrumentException51Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _postCustomerPaymentInstrumentException1Value = postCustomerPaymentInstrumentException1Value;
        _postCustomerPaymentInstrumentException21Value = postCustomerPaymentInstrumentException21Value;
        _postCustomerPaymentInstrumentException31Value = postCustomerPaymentInstrumentException31Value;
        _postCustomerPaymentInstrumentException41Value = postCustomerPaymentInstrumentException41Value;
        _postCustomerPaymentInstrumentException51Value = postCustomerPaymentInstrumentException51Value;
    }

    private static PostCustomerPaymentInstrumentError AsPostCustomerPaymentInstrumentException1(PostCustomerPaymentInstrumentException1 value) =>
        new(Optional<PostCustomerPaymentInstrumentException1>.Some(value), default, default, default, default, default);

    private static PostCustomerPaymentInstrumentError AsPostCustomerPaymentInstrumentException21(PostCustomerPaymentInstrumentException21 value) =>
        new(default, Optional<PostCustomerPaymentInstrumentException21>.Some(value), default, default, default, default);

    private static PostCustomerPaymentInstrumentError AsPostCustomerPaymentInstrumentException31(PostCustomerPaymentInstrumentException31 value) =>
        new(default, default, Optional<PostCustomerPaymentInstrumentException31>.Some(value), default, default, default);

    private static PostCustomerPaymentInstrumentError AsPostCustomerPaymentInstrumentException41(PostCustomerPaymentInstrumentException41 value) =>
        new(default, default, default, Optional<PostCustomerPaymentInstrumentException41>.Some(value), default, default);

    private static PostCustomerPaymentInstrumentError AsPostCustomerPaymentInstrumentException51(PostCustomerPaymentInstrumentException51 value) =>
        new(default, default, default, default, Optional<PostCustomerPaymentInstrumentException51>.Some(value), default);

    private static PostCustomerPaymentInstrumentError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPostCustomerPaymentInstrumentException1(out PostCustomerPaymentInstrumentException1 value) =>
        _postCustomerPaymentInstrumentException1Value.TryGetValue(out value);

    public bool TryGetPostCustomerPaymentInstrumentException21(out PostCustomerPaymentInstrumentException21 value) =>
        _postCustomerPaymentInstrumentException21Value.TryGetValue(out value);

    public bool TryGetPostCustomerPaymentInstrumentException31(out PostCustomerPaymentInstrumentException31 value) =>
        _postCustomerPaymentInstrumentException31Value.TryGetValue(out value);

    public bool TryGetPostCustomerPaymentInstrumentException41(out PostCustomerPaymentInstrumentException41 value) =>
        _postCustomerPaymentInstrumentException41Value.TryGetValue(out value);

    public bool TryGetPostCustomerPaymentInstrumentException51(out PostCustomerPaymentInstrumentException51 value) =>
        _postCustomerPaymentInstrumentException51Value.TryGetValue(out value);

    internal static Task<PostCustomerPaymentInstrumentError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PostCustomerPaymentInstrumentException1>(response, ct).As(AsPostCustomerPaymentInstrumentException1),
            403 => FromJson<PostCustomerPaymentInstrumentException21>(response, ct).As(AsPostCustomerPaymentInstrumentException21),
            409 => FromJson<PostCustomerPaymentInstrumentException31>(response, ct).As(AsPostCustomerPaymentInstrumentException31),
            424 => FromJson<PostCustomerPaymentInstrumentException41>(response, ct).As(AsPostCustomerPaymentInstrumentException41),
            500 => FromJson<PostCustomerPaymentInstrumentException51>(response, ct).As(AsPostCustomerPaymentInstrumentException51),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCustomerPaymentInstrumentErrorResponse : IErrorResponse<PostCustomerPaymentInstrumentError>
{
    public static PostCustomerPaymentInstrumentErrorResponse Instance { get; } = new();

    private PostCustomerPaymentInstrumentErrorResponse()
    {
    }

    public Task<PostCustomerPaymentInstrumentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCustomerPaymentInstrumentError.Create(response, ct);
}
