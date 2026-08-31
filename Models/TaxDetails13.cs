using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains all of the tax-related fields for the order.
/// </summary>
public record TaxDetails13
{
    /// <summary>
    /// Indicates the type of tax data for the _taxDetails_ object.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>alternate</c></description></item>
    ///   <item><description><c>local</c></description></item>
    ///   <item><description><c>national</c></description></item>
    ///   <item><description><c>vat</c></description></item>
    ///   <item><description><c>other</c></description></item>
    ///   <item><description><c>green</c></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Indicates the amount of tax based on the <c>type</c> field as described in the table below:
    /// <para>
    /// | type      | type description |
    /// | ------------- |:-------------:|
    /// | <c>alternate</c> | Total amount of alternate tax for the order. |
    /// | <c>local</c>     | Sales tax for the order. |
    /// | <c>national</c>  | National tax for the order. |
    /// | <c>vat</c>       | Total amount of value added tax (VAT) included in the order. |
    /// | <c>other</c>     | Other tax. |
    /// | <c>green</c>     | Green tax amount for Korean Processing. |
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    [MaxLength(13)]
    public string? Amount { get; init; }

    /// <summary>
    /// Rate of VAT or other tax for the order.
    /// <para>
    /// Example 0.040 (=4%)
    /// </para>
    /// <para>
    /// Valid range: 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional
    /// decimal places will be truncated)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rate")]
    [MaxLength(6)]
    public string? Rate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
