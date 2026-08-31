using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Converters;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains all of the shipping-related fields for the order.
/// </summary>
public record Freight
{
    /// <summary>
    /// Total freight or shipping and handling charges for the order. When you include this field in your request, you
    /// must also include the <b>totalAmount</b> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(NumericStringConverter))]
    [JsonPropertyName("amount")]
    [MaxLength(13)]
    public string? Amount { get; init; }

    /// <summary>
    /// Flag that indicates whether an order is taxable. This value must be true if the sum of all _lineItems[].taxAmount_ values &gt; 0.
    /// <para>
    /// If you do not include any <c>lineItems[].taxAmount</c> values in your request, CyberSource does not include
    /// <c>invoiceDetails.taxable</c> in the data it sends to the processor.
    /// </para>
    /// <para>
    /// Possible values:
    ///  - <b>true</b>
    ///  - <b>false</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxable")]
    public bool? Taxable { get; init; }

    /// <summary>
    /// Shipping Tax rate applied to the freight amount.
    /// <para>
    /// <b>Visa</b>: Valid range is 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional
    /// decimal places will be truncated).
    /// </para>
    /// <para>
    /// <b>Mastercard</b>: Valid range is 0.00001 to 0.99999 (0.001% to 99.999%).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(NumericStringConverter))]
    [JsonPropertyName("taxRate")]
    [MaxLength(7)]
    public string? TaxRate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
