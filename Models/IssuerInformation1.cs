using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record IssuerInformation1
{
    /// <summary>
    /// Payer authentication exemption indicator for Carte Bancaire exemptions.
    /// This is used with unbundled authentication and authorizations calls, for example: "low fraud merchant program".
    /// The value for this field maps to the value returned in the payer authentication API response field -
    /// <c>consumerAuthenticationInformation.exemptionDataRaw</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exemptionDataRaw")]
    [MaxLength(4)]
    public string? ExemptionDataRaw { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
