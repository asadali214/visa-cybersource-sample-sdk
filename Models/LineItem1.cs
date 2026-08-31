using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record LineItem1
{
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
