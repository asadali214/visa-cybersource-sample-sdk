using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ReactivationInformation
{
    /// <summary>
    /// Number of payments that should have occurred while the subscription was in a suspended status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("missedPaymentsCount")]
    [MaxLength(10)]
    public string? MissedPaymentsCount { get; init; }

    /// <summary>
    /// Total amount that will be charged upon reactivation if <c>processMissedPayments</c> is set to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("missedPaymentsTotalAmount")]
    [MaxLength(19)]
    public string? MissedPaymentsTotalAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
