using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PostPaymentCredentialsRequest
{
    /// <summary>
    /// The type of payment credentials to be returned.
    /// By default, payment credentials include network token and cryptogram or dynamic CVV.
    /// If "NETWORK_TOKEN" is supplied then only network token card number will be returned and no cryptogram or dynamic CVV will be requested.
    /// If "SECURITY_CODE" is supplied then dynamic CVV will be requested and returned with the network token card number. Dynamic CVV is only supported for Amex and SCOF.
    /// If "CRYPTOGRAM" is supplied then cryptogram will be requested and returned with the network token card number. Cryptogram is NOT supported for Amex.
    /// <para>
    /// Possible Values:
    ///   - NETWORK_TOKEN
    ///   - SECURITY_CODE
    ///   - CRYPTOGRAM
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentCredentialType")]
    public string? PaymentCredentialType { get; init; }

    /// <summary>
    /// Specifies the type of transaction for which the network token credentials are required.
    /// Possible Values:
    ///   - ECOM: Ecommerce transaction. If transactionType is not provided, ECOM is set as the default.
    ///   - AFT: Account Funding Transaction. This is only supported for VISA and paymentCredentialType of CRYPTOGRAM.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionType")]
    public string? TransactionType { get; init; }

    /// <summary>
    /// Used to correlate authentication and payment credential requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientCorrelationId")]
    [MaxLength(36)]
    [RegularExpression("[A-Za-z0-9]+")]
    public string? ClientCorrelationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderInformation")]
    public OrderInformation33? OrderInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantInformation")]
    public TmsMerchantInformation2? MerchantInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceInformation")]
    public DeviceInformation11? DeviceInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticatedIdentities")]
    public IReadOnlyList<AuthenticatedIdentity1>? AuthenticatedIdentities { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
