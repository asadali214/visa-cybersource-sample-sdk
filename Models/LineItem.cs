using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record LineItem
{
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
    [MaxLength(15)]
    public string? UnitPrice { get; init; }

    /// <summary>
    /// Unit of measure, or unit of measure code, for the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unitOfMeasure")]
    [MaxLength(12)]
    public string? UnitOfMeasure { get; init; }

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
    /// Tax rate applied to the item.
    /// <para>
    /// <b>Visa</b>: Valid range is 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional
    /// decimal places will be truncated).
    /// </para>
    /// <para>
    /// <b>Mastercard</b>: Valid range is 0.00001 to 0.99999 (0.001% to 99.999%).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxRate")]
    [MaxLength(7)]
    public string? TaxRate { get; init; }

    /// <summary>
    /// Flag to indicate how you handle discount at the line item level.
    /// <list type="bullet">
    ///   <item><description>0: no line level discount provided</description></item>
    ///   <item><description>1: tax was calculated on the post-discount line item total</description></item>
    ///   <item><description>2: tax was calculated on the pre-discount line item total</description></item>
    /// </list>
    /// <para>
    /// <c>Note</c> Visa will inset 0 (zero) if an invalid value is included in this field.
    /// </para>
    /// <para>
    /// This field relates to the value in the _lineItems[].discountAmount_ field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAppliedAfterDiscount")]
    [MaxLength(1)]
    public string? TaxAppliedAfterDiscount { get; init; }

    /// <summary>
    /// Flag to indicate whether tax is exempted or not included.
    /// <list type="bullet">
    ///   <item><description>0: tax not included</description></item>
    ///   <item><description>1: tax included</description></item>
    ///   <item><description>2: transaction is not subject to tax</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxStatusIndicator")]
    [MaxLength(1)]
    public string? TaxStatusIndicator { get; init; }

    /// <summary>
    /// Type of tax being applied to the item.
    /// <para>
    /// #### FDC Nashville Global
    /// - <c>alternate_tax_type_applied</c>
    /// - <c>alternate_tax_type_identifier</c>
    /// </para>
    /// <para>
    /// #### Worldpay VAP
    /// - <c>alternate_tax_type_identifier</c>
    /// </para>
    /// <para>
    /// #### RBS WorldPay Atlanta
    /// - <c>tax_type_applied</c>
    /// </para>
    /// <para>
    /// #### TSYS Acquiring Solutions
    /// - <c>tax_type_applied</c>
    /// - <c>local_tax_indicator</c>
    /// </para>
    /// <para>
    /// #### Chase Paymentech Solutions
    /// - <c>tax_type_applied</c>
    /// </para>
    /// <para>
    /// #### Elavon Americas
    /// - <c>local_tax_indicator</c>
    /// </para>
    /// <para>
    /// #### FDC Compass
    /// - <c>tax_type_applied</c>
    /// </para>
    /// <para>
    /// #### OmniPay Direct
    /// - <c>local_tax_indicator</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxTypeCode")]
    [MaxLength(4)]
    public string? TaxTypeCode { get; init; }

    /// <summary>
    /// Flag that indicates whether the tax amount is included in the Line Item Total.
    /// <para>
    /// Possible values:
    ///  - <b>true</b>
    ///  - <b>false</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountIncludesTax")]
    public bool? AmountIncludesTax { get; init; }

    /// <summary>
    /// Flag to indicate whether the purchase is categorized as goods or services.
    /// Possible values:
    /// <list type="bullet">
    ///   <item><description>00: goods</description></item>
    ///   <item><description>01: services</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("typeOfSupply")]
    [MaxLength(2)]
    public string? TypeOfSupply { get; init; }

    /// <summary>
    /// Commodity code or International description code used to classify the item. Contact your acquirer for a list of
    /// codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commodityCode")]
    [MaxLength(15)]
    public string? CommodityCode { get; init; }

    /// <summary>
    /// Discount applied to the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountAmount")]
    [MaxLength(13)]
    public string? DiscountAmount { get; init; }

    /// <summary>
    /// Flag that indicates whether the amount is discounted.
    /// <para>
    /// If you do not provide a value but you set Discount Amount to a value greater than zero, then CyberSource sets
    /// this field to <b>true</b>.
    /// </para>
    /// <para>
    /// Possible values:
    ///  - <b>true</b>
    ///  - <b>false</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountApplied")]
    public bool? DiscountApplied { get; init; }

    /// <summary>
    /// Rate the item is discounted. Maximum of 2 decimal places.
    /// <para>
    /// Example 5.25 (=5.25%)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountRate")]
    [MaxLength(6)]
    public string? DiscountRate { get; init; }

    /// <summary>
    /// Field to support an invoice number for a transaction. You must specify the number of line items that will
    /// include an invoice number. By default, the first line item will include an invoice number field. The invoice
    /// number field can be included for up to 10 line items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceNumber")]
    [MaxLength(23)]
    public string? InvoiceNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxDetails")]
    public IReadOnlyList<TaxDetail>? TaxDetails { get; init; }

    /// <summary>
    /// Information about the product code used for the line item.
    /// Possible values:
    /// - <c>E</c>: The product code is <c>electronic_software</c>.
    /// - <c>P</c>: The product code is not <c>electronic_software</c>.
    /// <para>
    /// For details, see the <c>fulfillmentType</c> field description in [Business Center Reporting User Guide.]
    /// (https://apps.cybersource.com/library/documentation/dev_guides/reporting_and_reconciliation/Reporting_User/html/)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillmentType")]
    public string? FulfillmentType { get; init; }

    /// <summary>
    /// Weight of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weight")]
    [MaxLength(9)]
    public string? Weight { get; init; }

    /// <summary>
    /// Type of weight.
    /// <para>
    /// Possible values:
    /// - B: Billed weight
    /// - N: Actual net weight
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weightIdentifier")]
    [MaxLength(1)]
    public string? WeightIdentifier { get; init; }

    /// <summary>
    /// Code that specifies the unit of measurement for the weight amount. For example, <c>OZ</c> specifies ounce and <c>LB</c> specifies pound. The possible values are defined by the ANSI Accredited Standards Committee (ASC).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weightUnit")]
    [MaxLength(2)]
    public string? WeightUnit { get; init; }

    /// <summary>
    /// Code that identifies the value of the corresponding <c>orderInformation.lineItems[].referenceDataNumber</c> field.
    /// <para>
    /// Possible values:
    /// - AN: Client-defined asset code
    /// - MG: Manufacturer's part number
    /// - PO: Purchase order number
    /// - SK: Supplier stock keeping unit number
    /// - UP: Universal product code
    /// - VC: Supplier catalog number
    /// - VP: Vendor part number
    /// </para>
    /// <para>
    /// This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way
    /// before sending it to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceDataCode")]
    [MaxLength(150)]
    public string? ReferenceDataCode { get; init; }

    /// <summary>
    /// Reference number.
    /// <para>
    /// The meaning of this value is identified by the value of the corresponding <c>referenceDataCode</c> field.
    /// See Numbered Elements.
    /// </para>
    /// <para>
    /// The maximum length for this field depends on the value of the corresponding <c>referenceDataCode</c> field:
    /// - When the code is <c>PO</c>, the maximum length for the reference number is 22.
    /// - When the code is <c>VC</c>, the maximum length for the reference number is 20.
    /// - For all other codes, the maximum length for the reference number is 30.
    /// </para>
    /// <para>
    /// This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way
    /// before sending it to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceDataNumber")]
    [MaxLength(30)]
    public string? ReferenceDataNumber { get; init; }

    /// <summary>
    /// Per-item tax amount of the product.
    /// Note The amount value must be a non-negative number containing 2 decimal places and limited to 7 digits before the decimal point.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unitTaxAmount")]
    [MaxLength(15)]
    public string? UnitTaxAmount { get; init; }

    /// <summary>
    /// This field would contain measurement of a line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement")]
    [MaxLength(10)]
    public string? Measurement { get; init; }

    /// <summary>
    /// Brief description of item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productDescription")]
    public string? ProductDescription { get; init; }

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
    /// Destination to where the item will be shipped. Example: Commercial, Residential, Store
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingDestinationTypes")]
    [MaxLength(50)]
    public string? ShippingDestinationTypes { get; init; }

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
    /// Contains travel-related passenger details used by DM service only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passenger")]
    public Passenger? Passenger { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedExportCountries")]
    public IReadOnlyList<string>? AllowedExportCountries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restrictedExportCountries")]
    public IReadOnlyList<string>? RestrictedExportCountries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
