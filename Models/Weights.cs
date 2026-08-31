using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Weights
{
    /// <summary>
    /// Degree of correlation between a customer’s address and an entry in the DPL
    /// before a match occurs. This field can contain one of the following values:
    /// - exact: The address must be identical to the entry in the DPL.
    /// - high: (default) The address cannot differ significantly from the entry in the DPL.
    /// - medium: The address can differ slightly more from the entry in the DPL.
    /// - low: The address can differ significantly from the entry in the DPL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    [MaxLength(6)]
    public string? Address { get; init; }

    /// <summary>
    /// Degree of correlation between a company address and an entry in the DPL
    /// before a match occurs. This field can contain one of the following values:
    /// - exact: The company name must be identical to the entry in the DPL.
    /// - high: (default) The company name cannot differ significantly from the entry in the DPL.
    /// - medium: The company name can differ slightly more from the entry in the DPL.
    /// - low: The company name can differ significantly from the entry in the DPL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    [MaxLength(6)]
    public string? Company { get; init; }

    /// <summary>
    /// Degree of correlation between a customer’s name and an entry in the DPL
    /// before a match occurs. This field can contain one of the following values:
    /// - exact: The name must be identical to the entry in the DPL.
    /// - high: (default) The name cannot differ significantly from the entry in the DPL.
    /// - medium: The name can differ slightly more from the entry in the DPL.
    /// - low: The name can differ significantly the entry in the DPL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(6)]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
