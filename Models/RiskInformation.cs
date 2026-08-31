using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// This object is only needed when you are requesting both payment and DM services at same time.
/// </summary>
public record RiskInformation
{
    /// <summary>
    /// Identifies a risk profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profile")]
    public Profile? Profile { get; init; }

    /// <summary>
    /// Specifies one of the following types of events:
    /// - login
    /// - account_creation
    /// - account_update
    /// For regular payment transactions, do not send this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventType")]
    [MaxLength(255)]
    public string? EventType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyerHistory")]
    public BuyerHistory? BuyerHistory { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auxiliaryData")]
    public IReadOnlyList<AuxiliaryDatum>? AuxiliaryData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
