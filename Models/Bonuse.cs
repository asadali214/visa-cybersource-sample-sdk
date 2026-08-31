using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Bonuse
{
    /// <summary>
    /// This value is a 2-digit code indicating the first bonus month. Valid value from 1 to 12.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("month")]
    [MaxLength(2)]
    public string? Month { get; init; }

    /// <summary>
    /// This value contains the bonus amount of the first month. Maximum value without decimal 99999999.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    [MaxLength(8)]
    public string? Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
