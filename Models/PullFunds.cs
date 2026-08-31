using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PullFunds
{
    /// <summary>
    /// This field indicates if domestic AFTs (pull funds) are allowed.
    /// Possible values:
    ///   - <c>true</c>
    ///   - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domesticParticipant")]
    [MaxLength(5)]
    public string? DomesticParticipant { get; init; }

    /// <summary>
    /// This field indicates if cross-border AFTs (pull funds) are allowed.
    /// Possible values:
    ///   - <c>true</c>
    ///   - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("crossBorderParticipant")]
    [MaxLength(5)]
    public string? CrossBorderParticipant { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
