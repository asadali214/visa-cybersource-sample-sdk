using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TokenInformation
{
    /// <summary>
    /// TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jti")]
    [MaxLength(64)]
    public string? Jti { get; init; }

    /// <summary>
    /// Flex API Transient Token encoded as JWT (JSON Web Token), e.g. Flex microform or Unified Payment checkout result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transientTokenJwt")]
    public string? TransientTokenJwt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrument")]
    public PaymentInstrument1? PaymentInstrument { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAddress")]
    public ShippingAddress1? ShippingAddress { get; init; }

    /// <summary>
    /// Indicates whether a payment network token associated with a TMS token should be used for authorization. This field can contain one of following values:
    /// <list type="bullet">
    ///   <item><description><c>ignore</c>: Use a tokenized card number for an authorization, even if the TMS token has an associated payment network token.</description></item>
    ///   <item><description><c>prefer</c>: (Default) Use an associated payment network token for an authorization if the TMS token has one; otherwise, use the tokenized card number.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkTokenOption")]
    public string? NetworkTokenOption { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenProvisioningInformation")]
    public TokenProvisioningInformation? TokenProvisioningInformation { get; init; }

    /// <summary>
    /// Client-generated unique identifier for correlating token operations across API calls.
    /// This value helps track and associate token-related transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientCorrelationId")]
    [MaxLength(36)]
    public string? ClientCorrelationId { get; init; }

    /// <summary>
    /// Contains authentication information associated with the token, including details about authenticated identities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenAuthenticationInformation")]
    public TokenAuthenticationInformation? TokenAuthenticationInformation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
