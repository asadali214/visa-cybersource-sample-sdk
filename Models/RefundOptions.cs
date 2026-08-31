using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RefundOptions
{
    /// <summary>
    /// The reason for the refund.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// Alternative reference number that can be up to 12 characters in length. If this field is used, it overrides any data added to the ccCaptureService_reconciliationID field. You can use this value to reconcile Cybersource reports with processor reports.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reconciliationIdAlternate")]
    [MaxLength(12)]
    public string? ReconciliationIdAlternate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
