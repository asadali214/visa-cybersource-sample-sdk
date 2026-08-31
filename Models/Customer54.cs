using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Customer54
{
    /// <summary>
    /// Personal identifier validation result.
    /// <para>
    /// Valid values:
    /// - '1': Verified
    /// - '2': Failed
    /// - '3': Not performed
    /// - '4': Issuer does not support id verification
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalIdResult")]
    [MaxLength(1)]
    public string? PersonalIdResult { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
