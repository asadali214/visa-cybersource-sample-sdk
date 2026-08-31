using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record UnscheduledPaymentInformation
{
    /// <summary>
    /// Indicates the type of unscheduled payment. This field is required for unscheduled payments CIT/MIT Possible values:
    /// 1: First unscheduled transaction.
    /// 2: Subsequent unscheduled transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(1)]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
