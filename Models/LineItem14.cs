using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record LineItem14
{
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
