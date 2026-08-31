using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostCustomerShippingAddressError : ApiError
{
    private readonly Optional<PostCustomerShippingAddressException1> _postCustomerShippingAddressException1Value;

    private readonly Optional<PostCustomerShippingAddressException21> _postCustomerShippingAddressException21Value;

    private readonly Optional<PostCustomerShippingAddressException31> _postCustomerShippingAddressException31Value;

    private readonly Optional<PostCustomerShippingAddressException41> _postCustomerShippingAddressException41Value;

    private readonly Optional<PostCustomerShippingAddressException51> _postCustomerShippingAddressException51Value;

    private PostCustomerShippingAddressError(Optional<PostCustomerShippingAddressException1> postCustomerShippingAddressException1Value,
        Optional<PostCustomerShippingAddressException21> postCustomerShippingAddressException21Value,
        Optional<PostCustomerShippingAddressException31> postCustomerShippingAddressException31Value,
        Optional<PostCustomerShippingAddressException41> postCustomerShippingAddressException41Value,
        Optional<PostCustomerShippingAddressException51> postCustomerShippingAddressException51Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _postCustomerShippingAddressException1Value = postCustomerShippingAddressException1Value;
        _postCustomerShippingAddressException21Value = postCustomerShippingAddressException21Value;
        _postCustomerShippingAddressException31Value = postCustomerShippingAddressException31Value;
        _postCustomerShippingAddressException41Value = postCustomerShippingAddressException41Value;
        _postCustomerShippingAddressException51Value = postCustomerShippingAddressException51Value;
    }

    private static PostCustomerShippingAddressError AsPostCustomerShippingAddressException1(PostCustomerShippingAddressException1 value) =>
        new(Optional<PostCustomerShippingAddressException1>.Some(value), default, default, default, default, default);

    private static PostCustomerShippingAddressError AsPostCustomerShippingAddressException21(PostCustomerShippingAddressException21 value) =>
        new(default, Optional<PostCustomerShippingAddressException21>.Some(value), default, default, default, default);

    private static PostCustomerShippingAddressError AsPostCustomerShippingAddressException31(PostCustomerShippingAddressException31 value) =>
        new(default, default, Optional<PostCustomerShippingAddressException31>.Some(value), default, default, default);

    private static PostCustomerShippingAddressError AsPostCustomerShippingAddressException41(PostCustomerShippingAddressException41 value) =>
        new(default, default, default, Optional<PostCustomerShippingAddressException41>.Some(value), default, default);

    private static PostCustomerShippingAddressError AsPostCustomerShippingAddressException51(PostCustomerShippingAddressException51 value) =>
        new(default, default, default, default, Optional<PostCustomerShippingAddressException51>.Some(value), default);

    private static PostCustomerShippingAddressError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPostCustomerShippingAddressException1(out PostCustomerShippingAddressException1 value) =>
        _postCustomerShippingAddressException1Value.TryGetValue(out value);

    public bool TryGetPostCustomerShippingAddressException21(out PostCustomerShippingAddressException21 value) =>
        _postCustomerShippingAddressException21Value.TryGetValue(out value);

    public bool TryGetPostCustomerShippingAddressException31(out PostCustomerShippingAddressException31 value) =>
        _postCustomerShippingAddressException31Value.TryGetValue(out value);

    public bool TryGetPostCustomerShippingAddressException41(out PostCustomerShippingAddressException41 value) =>
        _postCustomerShippingAddressException41Value.TryGetValue(out value);

    public bool TryGetPostCustomerShippingAddressException51(out PostCustomerShippingAddressException51 value) =>
        _postCustomerShippingAddressException51Value.TryGetValue(out value);

    internal static Task<PostCustomerShippingAddressError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PostCustomerShippingAddressException1>(response, ct).As(AsPostCustomerShippingAddressException1),
            403 => FromJson<PostCustomerShippingAddressException21>(response, ct).As(AsPostCustomerShippingAddressException21),
            409 => FromJson<PostCustomerShippingAddressException31>(response, ct).As(AsPostCustomerShippingAddressException31),
            424 => FromJson<PostCustomerShippingAddressException41>(response, ct).As(AsPostCustomerShippingAddressException41),
            500 => FromJson<PostCustomerShippingAddressException51>(response, ct).As(AsPostCustomerShippingAddressException51),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCustomerShippingAddressErrorResponse : IErrorResponse<PostCustomerShippingAddressError>
{
    public static PostCustomerShippingAddressErrorResponse Instance { get; } = new();

    private PostCustomerShippingAddressErrorResponse()
    {
    }

    public Task<PostCustomerShippingAddressError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCustomerShippingAddressError.Create(response, ct);
}
