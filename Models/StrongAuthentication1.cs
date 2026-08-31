using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record StrongAuthentication1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerInformation")]
    public PaymentsStrongAuthIssuerInformation? IssuerInformation { get; init; }

    /// <summary>
    /// This field will contain the outage exemption indicator with one of the following values:
    /// Possible values:
    /// - <c>0</c>  (Outage Authentication exemption does not apply to the transaction)
    /// - <c>1</c> (Outage exempt from SCA as authentication could not be done due to outage)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outageExemptionIndicator")]
    [MaxLength(1)]
    public string? OutageExemptionIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
