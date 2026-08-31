using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostTokenPaymentCredentialsV3Error : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private PostTokenPaymentCredentialsV3Error(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static PostTokenPaymentCredentialsV3Error AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static PostTokenPaymentCredentialsV3Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<PostTokenPaymentCredentialsV3Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 409 or 410 or 500 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostTokenPaymentCredentialsV3ErrorResponse : IErrorResponse<PostTokenPaymentCredentialsV3Error>
{
    public static PostTokenPaymentCredentialsV3ErrorResponse Instance { get; } = new();

    private PostTokenPaymentCredentialsV3ErrorResponse()
    {
    }

    public Task<PostTokenPaymentCredentialsV3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostTokenPaymentCredentialsV3Error.Create(response, ct);
}
