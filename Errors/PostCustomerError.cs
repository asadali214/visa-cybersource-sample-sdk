using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostCustomerError : ApiError
{
    private readonly Optional<PostCustomerException1> _postCustomerException1Value;

    private readonly Optional<PostCustomerException21> _postCustomerException21Value;

    private readonly Optional<PostCustomerException31> _postCustomerException31Value;

    private readonly Optional<PostCustomerException41> _postCustomerException41Value;

    private readonly Optional<PostCustomerException51> _postCustomerException51Value;

    private PostCustomerError(Optional<PostCustomerException1> postCustomerException1Value,
        Optional<PostCustomerException21> postCustomerException21Value,
        Optional<PostCustomerException31> postCustomerException31Value,
        Optional<PostCustomerException41> postCustomerException41Value,
        Optional<PostCustomerException51> postCustomerException51Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _postCustomerException1Value = postCustomerException1Value;
        _postCustomerException21Value = postCustomerException21Value;
        _postCustomerException31Value = postCustomerException31Value;
        _postCustomerException41Value = postCustomerException41Value;
        _postCustomerException51Value = postCustomerException51Value;
    }

    private static PostCustomerError AsPostCustomerException1(PostCustomerException1 value) =>
        new(Optional<PostCustomerException1>.Some(value), default, default, default, default, default);

    private static PostCustomerError AsPostCustomerException21(PostCustomerException21 value) =>
        new(default, Optional<PostCustomerException21>.Some(value), default, default, default, default);

    private static PostCustomerError AsPostCustomerException31(PostCustomerException31 value) =>
        new(default, default, Optional<PostCustomerException31>.Some(value), default, default, default);

    private static PostCustomerError AsPostCustomerException41(PostCustomerException41 value) =>
        new(default, default, default, Optional<PostCustomerException41>.Some(value), default, default);

    private static PostCustomerError AsPostCustomerException51(PostCustomerException51 value) =>
        new(default, default, default, default, Optional<PostCustomerException51>.Some(value), default);

    private static PostCustomerError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPostCustomerException1(out PostCustomerException1 value) =>
        _postCustomerException1Value.TryGetValue(out value);

    public bool TryGetPostCustomerException21(out PostCustomerException21 value) =>
        _postCustomerException21Value.TryGetValue(out value);

    public bool TryGetPostCustomerException31(out PostCustomerException31 value) =>
        _postCustomerException31Value.TryGetValue(out value);

    public bool TryGetPostCustomerException41(out PostCustomerException41 value) =>
        _postCustomerException41Value.TryGetValue(out value);

    public bool TryGetPostCustomerException51(out PostCustomerException51 value) =>
        _postCustomerException51Value.TryGetValue(out value);

    internal static Task<PostCustomerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PostCustomerException1>(response, ct).As(AsPostCustomerException1),
            403 => FromJson<PostCustomerException21>(response, ct).As(AsPostCustomerException21),
            409 => FromJson<PostCustomerException31>(response, ct).As(AsPostCustomerException31),
            424 => FromJson<PostCustomerException41>(response, ct).As(AsPostCustomerException41),
            500 => FromJson<PostCustomerException51>(response, ct).As(AsPostCustomerException51),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCustomerErrorResponse : IErrorResponse<PostCustomerError>
{
    public static PostCustomerErrorResponse Instance { get; } = new();

    private PostCustomerErrorResponse()
    {
    }

    public Task<PostCustomerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCustomerError.Create(response, ct);
}
