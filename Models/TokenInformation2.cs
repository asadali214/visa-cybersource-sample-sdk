using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TokenInformation2
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
