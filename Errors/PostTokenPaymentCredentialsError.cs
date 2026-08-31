using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostTokenPaymentCredentialsError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private PostTokenPaymentCredentialsError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static PostTokenPaymentCredentialsError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static PostTokenPaymentCredentialsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<PostTokenPaymentCredentialsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 410 or 500 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostTokenPaymentCredentialsErrorResponse : IErrorResponse<PostTokenPaymentCredentialsError>
{
    public static PostTokenPaymentCredentialsErrorResponse Instance { get; } = new();

    private PostTokenPaymentCredentialsErrorResponse()
    {
    }

    public Task<PostTokenPaymentCredentialsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostTokenPaymentCredentialsError.Create(response, ct);
}
