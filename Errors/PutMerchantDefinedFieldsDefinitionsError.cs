using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PutMerchantDefinedFieldsDefinitionsError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private PutMerchantDefinedFieldsDefinitionsError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static PutMerchantDefinedFieldsDefinitionsError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static PutMerchantDefinedFieldsDefinitionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<PutMerchantDefinedFieldsDefinitionsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 409 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PutMerchantDefinedFieldsDefinitionsErrorResponse : IErrorResponse<PutMerchantDefinedFieldsDefinitionsError>
{
    public static PutMerchantDefinedFieldsDefinitionsErrorResponse Instance { get; } = new();

    private PutMerchantDefinedFieldsDefinitionsErrorResponse()
    {
    }

    public Task<PutMerchantDefinedFieldsDefinitionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PutMerchantDefinedFieldsDefinitionsError.Create(response, ct);
}
