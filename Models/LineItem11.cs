using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record LineItem11
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
    /// Per-item price of the product. If line items are present in the request, the unit price is a mandatory field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unitPrice")]
    [MaxLength(15)]
    public string? UnitPrice { get; init; }

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
    /// Indicates the level of risk for the product. This field can contain one of the following values:
    /// - <c>low</c>: The product is associated with few chargebacks.
    /// - <c>normal</c>: The product is associated with a normal number of chargebacks.
    /// - <c>high</c>: The product is associated with many chargebacks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productRisk")]
    [MaxLength(6)]
    public string? ProductRisk { get; init; }

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
    /// Type of product. The value for this field is used to identify the product category (electronic, handling, physical,
    /// service, or shipping). The default value is <c>default</c>.
    /// <para>
    /// If you are performing an authorization transaction (<c>processingOptions.capture</c> is set to <c>false</c>), and you set
    /// this field to a value other than <c>default</c> or one of the values related to shipping and/or handling, then
    /// <c>orderInformation.lineItems[].quantity</c>, <c>orderInformation.lineItems[].productName</c>, and
    /// <c>orderInformation.lineItems[].productSku</c> fields are required.
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S., Canadian, international tax, and value added taxes.
    /// </para>
    /// <para>
    /// The Product Codes for the tax service are located in the Cybersource Tax Codes guide. Contact Customer Support to request the guide. If you don’t send a tax service Product Code in your tax request, product-based rules or exemptions will not be applied and the transaction will default to fully taxable in the locations where you’ve indicated you need to collect tax [by way of nexus, no nexus, or seller registration number fields].
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productCode")]
    [MaxLength(255)]
    public string? ProductCode { get; init; }

    /// <summary>
    /// This field is only used in DM service.
    /// <para>
    /// Determines whether to assign risk to the order if the billing and shipping addresses specify different cities,
    /// states, or countries. This field can contain one of the following values:
    /// - true: Orders are assigned only slight additional risk if billing and shipping addresses are different.
    /// - false: Orders are assigned higher additional risk if billing and shipping addresses are different.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift")]
    public bool? Gift { get; init; }

    /// <summary>
    /// Product’s identifier code. This field is inserted into the outgoing message without being parsed or formatted.
    /// This field is included as Distributor product SKU (Offer) in the list of API fields with which you can create
    /// custom rules.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distributorProductSku")]
    [MaxLength(15)]
    public string? DistributorProductSku { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedExportCountries")]
    public IReadOnlyList<string>? AllowedExportCountries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restrictedExportCountries")]
    public IReadOnlyList<string>? RestrictedExportCountries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
