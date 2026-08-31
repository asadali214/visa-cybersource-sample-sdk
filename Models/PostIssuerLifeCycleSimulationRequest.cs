using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Represents the Issuer LifeCycle Event Simulation for a Tokenized Card.
/// </summary>
public record PostIssuerLifeCycleSimulationRequest
{
    /// <summary>
    /// The new state of the Tokenized Card.
    /// Possible Values:
    /// - ACTIVE
    /// - SUSPENDED
    /// - DELETED
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card30? Card { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public TmsIssuerLifeCycleEventSimulationMetadata? Metadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
