using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Converters;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Line item from the order.
/// </summary>
public record LineItem17
{
    /// <summary>
    /// Product identifier code. Also known as the Stock Keeping Unit (SKU) code for the product.
    /// <para>
    /// For an authorization or capture transaction (<c>processingOptions.capture</c> is set to <c>true</c> or <c>false</c>), this field is required when <c>orderInformation.lineItems[].productCode</c> is not set to <b>default</b> or one of the other values that are related to shipping and/or handling.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes.
    /// For an authorization or capture transaction (<c>processingOptions.capture</c> is set to <c>true</c> or <c>false</c>), this field is
    /// required when <c>orderInformation.lineItems[].productCode</c> is not <c>default</c> or one of the values related to shipping and/or handling.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productSku")]
    [MaxLength(255)]
    public string? ProductSku { get; init; }

    /// <summary>
    /// For an authorization or capture transaction (<c>processingOptions.capture</c> is <c>true</c> or <c>false</c>),
    /// this field is required when <c>orderInformation.lineItems[].productCode</c> is not <c>default</c> or one of
    /// the other values that are related to shipping and/or handling.
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S., Canadian, international tax, and value added taxes.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productName")]
    [MaxLength(255)]
    public string? ProductName { get; init; }

    /// <summary>
    /// Number of units for this order. Must be a non-negative integer.
    /// <para>
    /// The default is <c>1</c>. For an authorization or capture transaction (<c>processingOptions.capture</c> is set to <c>true</c> or <c>false</c>),
    /// this field is required when <c>orderInformation.lineItems[].productCode</c> is not <c>default</c> or one of the other values
    /// related to shipping and/or handling.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S., Canadian, international tax, and value added taxes.
    /// </para>
    /// </summary>
    [JsonPropertyName("quantity")]
    [Minimum(1)]
    [Maximum(999999999)]
    public int? Quantity { get; init; } = 1;

    /// <summary>
    /// Per-item price of the product. This value for this field cannot be negative.
    /// <para>
    /// You must include either this field or the request-level field <c>orderInformation.amountDetails.totalAmount</c> in your request.
    /// </para>
    /// <para>
    /// You can include a decimal point (.), but you cannot include any other special characters.
    /// The value is truncated to the correct number of decimal places.
    /// </para>
    /// <para>
    /// #### DCC with a Third-Party Provider
    /// Set this field to the converted amount that was returned by the DCC provider. You must include either
    /// the 1st line item in the order and this field, or the request-level field <c>orderInformation.amountDetails.totalAmount</c> in your request.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Required field for U.S., Canadian, international and value added taxes.
    /// </para>
    /// <para>
    /// #### Zero Amount Authorizations
    /// If your processor supports zero amount authorizations, you can set this field to 0 for the
    /// authorization to check if the card is lost or stolen.
    /// </para>
    /// <para>
    /// #### Maximum Field Lengths
    /// For GPN and JCN Gateway: Decimal (10)
    /// All other processors: Decimal (15)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unitPrice")]
    [JsonConverter(typeof(NumericStringConverter))]
    [MaxLength(15)]
    public string? UnitPrice { get; init; }

    /// <summary>
    /// Discount applied to the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(NumericStringConverter))]
    [JsonPropertyName("discountAmount")]
    [MaxLength(13)]
    public string? DiscountAmount { get; init; }

    /// <summary>
    /// Rate the item is discounted. Maximum of 2 decimal places.
    /// <para>
    /// Example 5.25 (=5.25%)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(NumericStringConverter))]
    [JsonPropertyName("discountPercent")]
    [MaxLength(6)]
    public string? DiscountPercent { get; init; }

    /// <summary>
    /// Total tax to apply to the product. This value cannot be negative. The tax amount and the offer amount must
    /// be in the same currency. The tax amount field is additive.
    /// <para>
    /// The following example uses a two-exponent currency such as USD:
    /// </para>
    /// <para>
    ///  1. You include each line item in your request.
    ///  ..- 1st line item has amount=10.00, quantity=1, and taxAmount=0.80
    ///  ..- 2nd line item has amount=20.00, quantity=1, and taxAmount=1.60
    ///  2. The total amount authorized will be 32.40, not 30.00 with 2.40 of tax included.
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### Airlines processing
    /// Tax portion of the order amount. This value cannot exceed 99999999999999 (fourteen 9s).
    /// Format: English characters only.
    /// Optional request field for a line item.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S., Canadian, international tax, and value added taxes.
    /// </para>
    /// <para>
    /// Note if you send this field in your tax request, the value in the field will override the tax engine
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(NumericStringConverter))]
    [JsonPropertyName("taxAmount")]
    [MaxLength(15)]
    public string? TaxAmount { get; init; }

    /// <summary>
    /// Valid range: 1% to 99%, with only whole percentage values accepted; values with additional
    /// <para>
    /// decimal places will be truncated
    /// </para>
    /// <para>
    /// For processor-specific details, see the alternate_tax_amount, vat_rate, vat_tax_rate, local_tax, national_tax, vat_tax_amount or other_tax#_rate field descriptions in the Level II and Level III Processing Using the SCMP API Guide.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(NumericStringConverter))]
    [JsonPropertyName("taxRate")]
    [MaxLength(7)]
    public string? TaxRate { get; init; }

    /// <summary>
    /// Total amount for the item. Normally calculated as the unit price times quantity.
    /// <para>
    /// When <c>orderInformation.lineItems[].productCode</c> is "gift_card", this is the purchase amount total
    /// for prepaid gift cards in major units.
    /// </para>
    /// <para>
    /// Example: 123.45 USD = 123
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(NumericStringConverter))]
    [JsonPropertyName("totalAmount")]
    [MaxLength(13)]
    public string? TotalAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
