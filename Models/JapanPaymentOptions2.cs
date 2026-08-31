using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record JapanPaymentOptions2
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
    /// Number of Installments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installments")]
    public string? Installments { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
