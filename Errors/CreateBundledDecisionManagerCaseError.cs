using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateBundledDecisionManagerCaseError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CreateBundledDecisionManagerCaseError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CreateBundledDecisionManagerCaseError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CreateBundledDecisionManagerCaseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CreateBundledDecisionManagerCaseError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 502 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateBundledDecisionManagerCaseErrorResponse : IErrorResponse<CreateBundledDecisionManagerCaseError>
{
    public static CreateBundledDecisionManagerCaseErrorResponse Instance { get; } = new();

    private CreateBundledDecisionManagerCaseErrorResponse()
    {
    }

    public Task<CreateBundledDecisionManagerCaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateBundledDecisionManagerCaseError.Create(response, ct);
}
