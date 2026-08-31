using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Billing Frequency
/// </summary>
public record BillingPeriod
{
    /// <summary>
    /// Example:
    /// - If length=1 &amp; unit=month then charge every month
    /// - If length=7 &amp; unit=day then charge every 7th day
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("length")]
    public string? Length { get; init; }

    /// <summary>
    /// Calendar unit values.
    ///   possible values:
    ///   - <c>D</c> - day
    ///   - <c>M</c> - month
    ///   - <c>W</c> - week
    ///   - <c>Y</c> - year
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unit")]
    public string? Unit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
