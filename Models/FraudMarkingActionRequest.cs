using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record FraudMarkingActionRequest
{
    [JsonPropertyName("riskInformation")]
    public required RiskInformation9 RiskInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientReferenceInformation")]
    public ClientReferenceInformation49? ClientReferenceInformation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
