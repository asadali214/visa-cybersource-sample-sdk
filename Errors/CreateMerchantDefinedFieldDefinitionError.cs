using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateMerchantDefinedFieldDefinitionError : ApiError
{
    private readonly Optional<CreateMerchantDefinedFieldDefinitionException1> _createMerchantDefinedFieldDefinitionException1Value;

    private CreateMerchantDefinedFieldDefinitionError(Optional<CreateMerchantDefinedFieldDefinitionException1> createMerchantDefinedFieldDefinitionException1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _createMerchantDefinedFieldDefinitionException1Value = createMerchantDefinedFieldDefinitionException1Value;
    }

    private static CreateMerchantDefinedFieldDefinitionError AsCreateMerchantDefinedFieldDefinitionException1(CreateMerchantDefinedFieldDefinitionException1 value) =>
        new(Optional<CreateMerchantDefinedFieldDefinitionException1>.Some(value), default);

    private static CreateMerchantDefinedFieldDefinitionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetCreateMerchantDefinedFieldDefinitionException1(out CreateMerchantDefinedFieldDefinitionException1 value) =>
        _createMerchantDefinedFieldDefinitionException1Value.TryGetValue(out value);

    internal static Task<CreateMerchantDefinedFieldDefinitionError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 409 or 412 => FromJson<CreateMerchantDefinedFieldDefinitionException1>(response, ct).As(AsCreateMerchantDefinedFieldDefinitionException1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateMerchantDefinedFieldDefinitionErrorResponse : IErrorResponse<CreateMerchantDefinedFieldDefinitionError>
{
    public static CreateMerchantDefinedFieldDefinitionErrorResponse Instance { get; } = new();

    private CreateMerchantDefinedFieldDefinitionErrorResponse()
    {
    }

    public Task<CreateMerchantDefinedFieldDefinitionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateMerchantDefinedFieldDefinitionError.Create(response, ct);
}
