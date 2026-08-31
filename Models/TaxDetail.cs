using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TaxDetail
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
    [JsonPropertyName("code")]
    [MaxLength(4)]
    public string? Code { get; init; }

    /// <summary>
    /// Your tax ID number to use for the alternate tax amount. Required if you set alternate tax amount to any value,
    /// including zero. You may send this field without sending alternate tax amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxId")]
    [MaxLength(15)]
    public string? TaxId { get; init; }

    /// <summary>
    /// Flag that indicates whether the alternate tax amount (<c>orderInformation.amountDetails.taxDetails[].amount</c>) is
    /// included in the request.
    /// <para>
    /// Possible values:
    /// - <c>false</c>: alternate tax amount is not included in the request.
    /// - <c>true</c>: alternate tax amount is included in the request.
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
