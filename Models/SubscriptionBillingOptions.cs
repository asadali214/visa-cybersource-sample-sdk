using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record SubscriptionBillingOptions
{
    /// <summary>
    /// Valid Values:
    /// - <c>ALL</c> - Change applied to all Subscriptions (Existing + New)
    /// - <c>NEW</c> - Change applied to New Subsciptions only
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applyTo")]
    public string? ApplyTo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
