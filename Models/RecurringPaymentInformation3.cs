using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RecurringPaymentInformation3
{
    /// <summary>
    /// Indicates recurring amount type agreed by the cardholder
    /// Valid Values :
    /// 1- Fixed amount recurring payment
    /// 2- Recurring payment with maximum amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountType")]
    [MaxLength(1)]
    public string? AmountType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
