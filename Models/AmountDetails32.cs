using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails32
{
    /// <summary>
    /// Grand total for the order. This value cannot be negative. You can include a decimal point (.), but you cannot include any other special characters. CyberSource truncates the amount to the correct number of decimal places
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalAmount")]
    [MaxLength(32)]
    public string? TotalAmount { get; init; }

    /// <summary>
    /// Currency used for the order
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MaxLength(3)]
    public string? Currency { get; init; }

    /// <summary>
    /// Discount amount for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountAmount")]
    [MaxLength(32)]
    public string? DiscountAmount { get; init; }

    /// <summary>
    /// Aggregate shipping charges for the transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAmount")]
    [MaxLength(32)]
    public string? ShippingAmount { get; init; }

    /// <summary>
    /// Shipping discount amount for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingDiscountAmount")]
    [MaxLength(32)]
    public string? ShippingDiscountAmount { get; init; }

    /// <summary>
    /// Total tax amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAmount")]
    [MaxLength(32)]
    public string? TaxAmount { get; init; }

    /// <summary>
    /// Amount being charged for the insurance fee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insuranceAmount")]
    [MaxLength(32)]
    public string? InsuranceAmount { get; init; }

    /// <summary>
    /// Amount being charged as duty amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dutyAmount")]
    [MaxLength(32)]
    public string? DutyAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
