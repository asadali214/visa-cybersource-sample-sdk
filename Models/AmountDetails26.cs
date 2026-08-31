using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails26
{
    /// <summary>
    /// Grand total for the order. This value cannot be negative. You can include a decimal point (.), but you cannot include any other special characters. CyberSource truncates the amount to the correct number of decimal places
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalAmount")]
    [MaxLength(10)]
    public string? TotalAmount { get; init; }

    /// <summary>
    /// Currency used for the order
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MaxLength(5)]
    public string? Currency { get; init; }

    /// <summary>
    /// Shipping discount amount for the transaction. If this amount has changed since the initial sessions request, you must include the new value in the order request. You must also include all additional amount fields that apply to the order and ensure the total amount equals the purchaseTotals_grandTotalAmount value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subTotalAmount")]
    [MaxLength(15)]
    public string? SubTotalAmount { get; init; }

    /// <summary>
    /// Aggregate handling charges for the transaction. If this amount has changed since the initial sessions request, you must include the new value in the order request. You must also include all additional amount fields that apply to the order and ensure the total amount equals the purchaseTotals_grandTotalAmount value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("handlingAmount")]
    [MaxLength(15)]
    public string? HandlingAmount { get; init; }

    /// <summary>
    /// Aggregate shipping charges for the transaction If this amount has changed since the initial sessions request, you must include the new value in the order request. You must also include all additional amount fields that apply to the order and ensure the total amount equals the purchaseTotals_grandTotalAmount value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAmount")]
    [MaxLength(15)]
    public string? ShippingAmount { get; init; }

    /// <summary>
    /// Shipping discount amount for the transaction. If this amount has changed since the initial sessions request, you must include the new value in the order request. You must also include all additional amount fields that apply to the order and ensure the total amount equals the purchaseTotals_grandTotalAmount value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingDiscountAmount")]
    [MaxLength(15)]
    public string? ShippingDiscountAmount { get; init; }

    /// <summary>
    /// Total tax amount. When the purchaseTotals_ taxAmount and ap_subtotalAmount fields are included in the request, do not include the tax amount as part of the subtotal amount calculation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAmount")]
    [MaxLength(10)]
    public string? TaxAmount { get; init; }

    /// <summary>
    /// Amount being charged for the insurance fee. Only supported when the payment_method is set to paypal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insuranceAmount")]
    [MaxLength(15)]
    public string? InsuranceAmount { get; init; }

    /// <summary>
    /// Amount being charged as gift wrap fee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("giftWrapAmount")]
    [MaxLength(15)]
    public string? GiftWrapAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
