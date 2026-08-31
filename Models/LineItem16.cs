using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record LineItem16
{
    /// <summary>
    /// Type of product. This value is used to determine the category that the product is in: electronic, handling,
    /// physical, service, or shipping. The default value is <b>default</b>.
    /// <para>
    /// For a payment, when you set this field to a value other than default or any of the values related to
    /// shipping and handling, below fields _quantity_, _productName_, and _productSKU_ are required.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productCode")]
    [MaxLength(255)]
    public string? ProductCode { get; init; }

    /// <summary>
    /// For PAYMENT and CAPTURE API, this field is required when above _productCode_ is not <b>default</b> or one of the
    /// values related to shipping and handling.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productName")]
    [MaxLength(255)]
    public string? ProductName { get; init; }

    /// <summary>
    /// Identification code for the product. For Payment and Capture APIs, this field is required when above
    /// <c>productCode</c> is not <b>default</b> or one of the values related to shipping and/or handling.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productSku")]
    [MaxLength(255)]
    public string? ProductSku { get; init; }

    /// <summary>
    /// Total tax to apply to the product. This value cannot be negative. The tax amount and the offer amount must
    /// be in the same currency. The tax amount field is additive.
    /// <para>
    /// The following example uses a two-exponent currency such as USD:
    /// </para>
    /// <para>
    /// 1. You include each line item in your request.
    ///     - 1st line item has <c>amount=10.00</c>, <c>quantity=1</c>, and <c>taxAmount=0.80</c>
    ///     - 2nd line item has <c>amount=20.00</c>, <c>quantity=1</c>, and <c>taxAmount=1.60</c>
    /// 2. The total amount authorized will be 32.40, not 30.00 with 2.40 of tax included.
    /// </para>
    /// <para>
    /// This field is frequently used for Level II and Level III transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAmount")]
    [MaxLength(15)]
    public string? TaxAmount { get; init; }

    /// <summary>
    /// For a payment or capture, this field is required when _productCode_ is not <b>default</b> or one of the values
    /// related to shipping and handling.
    /// </summary>
    [JsonPropertyName("quantity")]
    [Minimum(1)]
    [Maximum(999999999)]
    public int? Quantity { get; init; } = 1;

    /// <summary>
    /// Per-item price of the product. This value cannot be negative. You can include a decimal point (.), but you
    /// cannot include any other special characters. CyberSource truncates the amount to the correct number of decimal
    /// places.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unitPrice")]
    [MaxLength(15)]
    public string? UnitPrice { get; init; }

    /// <summary>
    /// The description for this field is not available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillmentType")]
    public string? FulfillmentType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
