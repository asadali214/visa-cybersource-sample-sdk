using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TokenProvisioningInformation
{
    /// <summary>
    /// Flag that indicates whether the user consented to the tokenization of their credentials. Required for card network tokenization in certain markets, such as India.
    /// Possible Values:
    /// - <c>true</c>: Consumer has consented to tokenization of their credentials.
    /// - <c>false</c>: Consumer has not consented to tokenization of their credentials.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumerConsentObtained")]
    public bool? ConsumerConsentObtained { get; init; }

    /// <summary>
    /// Flag that indicates whether AFA (Additional Factor of Authentication) for the PAN was completed. Required for card network tokenization in certain markets, such as India.
    /// Possible Values:
    /// - <c>true</c>: Consumer has been authenticated by the issuer.
    /// - <c>false</c>: Consumer has not been authenticated by the issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("multiFactorAuthenticated")]
    public bool? MultiFactorAuthenticated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
