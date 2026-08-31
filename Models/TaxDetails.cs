using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TaxDetails
{
    /// <summary>
    /// Indicates the amount of tax based on the <c>type</c> field as described in the table below:
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

    /// <summary>
    /// Flag that indicates whether the tax amount (<c>travelInformation.autoRental.taxDetails.amount</c>) is
    /// included in the request.
    /// <para>
    /// Possible values:
    /// - <c>false</c>: tax amount is not included in the request.
    /// - <c>true</c>:  tax amount is included in the request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied")]
    public bool? Applied { get; init; }

    /// <summary>
    /// Status code for exemption from sales and use tax. This field is a pass-through, which means that
    /// CyberSource does not verify the value or modify it in any way before sending it to the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exemptionCode")]
    [MaxLength(1)]
    public string? ExemptionCode { get; init; }

    /// <summary>
    /// Different taxes the rental agency applies to the rental agreement such as tourist tax, airport tax, or rental tax.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxType")]
    [MaxLength(10)]
    public string? TaxType { get; init; }

    /// <summary>
    /// Summary of all tax types
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxSummary")]
    [MaxLength(12)]
    public string? TaxSummary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
