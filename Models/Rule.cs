using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Rule
{
    /// <summary>
    /// Description of the rule as it appears in the Profile Editor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// Summarizes the result for the rule according to the setting that you chose in the Profile Editor.
    /// This field can contain one of the following values:
    /// - <c>IGNORE</c>
    /// - <c>REVIEW</c>
    /// - <c>REJECT</c>
    /// - <c>ACCEPT</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decision")]
    [MaxLength(255)]
    public string? Decision { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
