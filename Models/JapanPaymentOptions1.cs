using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record JapanPaymentOptions1
{
    /// <summary>
    /// This value is a 2-digit code indicating the payment method.
    /// Use Payment Method Code value that applies to the tranasction.
    /// - 10 (One-time payment)
    /// - 21, 22, 23, 24  (Bonus(one-time)payment)
    /// - 61 (Installment payment)
    /// - 31, 32, 33, 34  (Integrated (Bonus + Installment)payment)
    /// - 80 (Revolving payment)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    [MaxLength(2)]
    public string? PaymentMethod { get; init; }

    /// <summary>
    /// Field contains the number of bonuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bonuses")]
    [MaxLength(2)]
    public string? Bonuses { get; init; }

    /// <summary>
    /// Number of Installments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installments")]
    public string? Installments { get; init; }

    /// <summary>
    /// Billing month in MM format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstBillingMonth")]
    [MaxLength(2)]
    public string? FirstBillingMonth { get; init; }

    /// <summary>
    /// This field contains the bonus amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bonusAmount")]
    [MaxLength(12)]
    public string? BonusAmount { get; init; }

    /// <summary>
    /// This field contains the Japan specific first bonus month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bonusMonth")]
    [MaxLength(2)]
    public string? BonusMonth { get; init; }

    /// <summary>
    /// Field contains the second bonus amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondBonusAmount")]
    [MaxLength(12)]
    public string? SecondBonusAmount { get; init; }

    /// <summary>
    /// Field contains the Japan specific second bonus month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondBonusMonth")]
    [MaxLength(2)]
    public string? SecondBonusMonth { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
