using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CheckPayerAuthEnrollmentError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CheckPayerAuthEnrollmentError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CheckPayerAuthEnrollmentError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CheckPayerAuthEnrollmentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CheckPayerAuthEnrollmentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckPayerAuthEnrollmentErrorResponse : IErrorResponse<CheckPayerAuthEnrollmentError>
{
    public static CheckPayerAuthEnrollmentErrorResponse Instance { get; } = new();

    private CheckPayerAuthEnrollmentErrorResponse()
    {
    }

    public Task<CheckPayerAuthEnrollmentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckPayerAuthEnrollmentError.Create(response, ct);
}
