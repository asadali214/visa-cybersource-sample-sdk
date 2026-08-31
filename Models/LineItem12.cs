using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record LineItem12
{
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
    [JsonPropertyName("totalAmount")]
    [MaxLength(13)]
    public string? TotalAmount { get; init; }

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
    [JsonPropertyName("unitPrice")]
    [MaxLength(15)]
    public required string UnitPrice { get; init; }

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
    /// When <c>orderInformation.lineItems[].productCode</c> is "gift_card", this is the
    /// currency used for the gift card purchase.
    /// <para>
    /// For the possible values, see the <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes.</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("giftCardCurrency")]
    public int? GiftCardCurrency { get; init; }

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
    [JsonPropertyName("productSKU")]
    [MaxLength(255)]
    public string? ProductSku { get; init; }

    /// <summary>
    /// Brief description of item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productDescription")]
    public string? ProductDescription { get; init; }

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
    /// Contains travel-related passenger details used by DM service only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passenger")]
    public Passenger? Passenger { get; init; }

    /// <summary>
    /// Destination to where the item will be shipped. Example: Commercial, Residential, Store
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingDestinationTypes")]
    [MaxLength(50)]
    public string? ShippingDestinationTypes { get; init; }

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
    [JsonPropertyName("taxAmount")]
    [MaxLength(15)]
    public string? TaxAmount { get; init; }

    /// <summary>
    /// Address where item will be shipped
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAddress1")]
    [MaxLength(50)]
    public string? ShippingAddress1 { get; init; }

    /// <summary>
    /// Address where item will be shipped
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAddress2")]
    [MaxLength(50)]
    public string? ShippingAddress2 { get; init; }

    /// <summary>
    /// City where item will be shipped
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingCity")]
    [MaxLength(20)]
    public string? ShippingCity { get; init; }

    /// <summary>
    /// Country where item will be shipped
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingCountryCode")]
    [MaxLength(10)]
    public string? ShippingCountryCode { get; init; }

    /// <summary>
    /// Customer's first name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingFirstName")]
    [MaxLength(20)]
    public string? ShippingFirstName { get; init; }

    /// <summary>
    /// Customer's last name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingLastName")]
    [MaxLength(20)]
    public string? ShippingLastName { get; init; }

    /// <summary>
    /// Customer's middle name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingMiddleName")]
    [MaxLength(20)]
    public string? ShippingMiddleName { get; init; }

    /// <summary>
    /// Phone number where item will be shipped
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingPhone")]
    public int? ShippingPhone { get; init; }

    /// <summary>
    /// Postal code where item will be shipped
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingPostalCode")]
    public int? ShippingPostalCode { get; init; }

    /// <summary>
    /// State where item will be shipped
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingState")]
    [MaxLength(20)]
    public string? ShippingState { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
