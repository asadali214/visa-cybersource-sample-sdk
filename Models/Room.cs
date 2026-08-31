using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record Room
{
    /// <summary>
    /// Daily cost of the room.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dailyRate")]
    [MaxLength(8)]
    public string? DailyRate { get; init; }

    /// <summary>
    /// Number of nights billed at the rate specified by <c>travelInformation.lodging.room[].dailyRate</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfNights")]
    [Minimum(1)]
    [Maximum(9999)]
    public int? NumberOfNights { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
