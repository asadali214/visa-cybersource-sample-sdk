using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetMerchantDefinedFieldsDefinitionsError : ApiError
{
    private readonly Optional<GetMerchantDefinedFieldsDefinitionsException1> _getMerchantDefinedFieldsDefinitionsException1Value;

    private GetMerchantDefinedFieldsDefinitionsError(Optional<GetMerchantDefinedFieldsDefinitionsException1> getMerchantDefinedFieldsDefinitionsException1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getMerchantDefinedFieldsDefinitionsException1Value = getMerchantDefinedFieldsDefinitionsException1Value;
    }

    private static GetMerchantDefinedFieldsDefinitionsError AsGetMerchantDefinedFieldsDefinitionsException1(GetMerchantDefinedFieldsDefinitionsException1 value) =>
        new(Optional<GetMerchantDefinedFieldsDefinitionsException1>.Some(value), default);

    private static GetMerchantDefinedFieldsDefinitionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetGetMerchantDefinedFieldsDefinitionsException1(out GetMerchantDefinedFieldsDefinitionsException1 value) =>
        _getMerchantDefinedFieldsDefinitionsException1Value.TryGetValue(out value);

    internal static Task<GetMerchantDefinedFieldsDefinitionsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<GetMerchantDefinedFieldsDefinitionsException1>(response, ct).As(AsGetMerchantDefinedFieldsDefinitionsException1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantDefinedFieldsDefinitionsErrorResponse : IErrorResponse<GetMerchantDefinedFieldsDefinitionsError>
{
    public static GetMerchantDefinedFieldsDefinitionsErrorResponse Instance { get; } = new();

    private GetMerchantDefinedFieldsDefinitionsErrorResponse()
    {
    }

    public Task<GetMerchantDefinedFieldsDefinitionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetMerchantDefinedFieldsDefinitionsError.Create(response, ct);
}
