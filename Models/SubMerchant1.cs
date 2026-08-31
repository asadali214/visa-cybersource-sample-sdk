using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record SubMerchant1
{
    /// <summary>
    /// Sub-merchant’s business name.
    /// <para>
    /// #### American Express Direct
    /// The maximum length of the sub-merchant name depends on the length of the aggregator name. The combined length for both values must not exceed 36 characters.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// With American Express, the maximum length of the sub-merchant name depends on the length of the aggregator name. The combined length for both values must not exceed 36 characters. The value for this field does not map to the TC 33 capture file5.
    /// </para>
    /// <para>
    /// #### FDC Compass
    /// This value must consist of uppercase characters.
    /// </para>
    /// <para>
    /// #### FDC Nashville Global
    /// With Mastercard, the maximum length of the sub-merchant name depends on the length of the aggregator name:
    /// - If aggregator name length is 1 through 3, maximum sub-merchant name length is 21.
    /// - If aggregator name length is 4 through 7, maximum sub-merchant name length is 17.
    /// - If aggregator name length is 8 through 12, maximum sub-merchant name length is 12.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(37)]
    public string? Name { get; init; }

    /// <summary>
    /// First line of the sub-merchant’s street address.
    /// <para>
    /// #### CyberSource through VisaNet
    /// The value for this field does not map to the TC 33 capture file5.
    /// </para>
    /// <para>
    /// #### FDC Compass
    /// This value must consist of uppercase characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(38)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Sub-merchant’s city.
    /// <para>
    /// #### CyberSource through VisaNet
    /// The value for this field does not map to the TC 33 capture file5.
    /// </para>
    /// <para>
    /// #### FDC Compass
    /// This value must consist of uppercase characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(21)]
    public string? Locality { get; init; }

    /// <summary>
    /// Sub-merchant’s state or province.
    /// <para>
    /// #### CyberSource through VisaNet
    /// The value for this field does not map to the TC 33 capture file5.
    /// </para>
    /// <para>
    /// #### FDC Compass
    /// This value must consist of uppercase characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(50)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Partial postal code for the sub-merchant’s address.
    /// <para>
    /// #### CyberSource through VisaNet
    /// The value for this field does not map to the TC 33 capture file5.
    /// </para>
    /// <para>
    /// #### FDC Compass
    /// This value must consist of uppercase characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(15)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Sub-merchant’s country. Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes</see>.
    /// <para>
    /// #### CyberSource through VisaNet
    /// The value for this field does not map to the TC 33 capture file.
    /// </para>
    /// <para>
    /// #### FDC Compass
    /// This value must consist of uppercase characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(3)]
    public string? Country { get; init; }

    /// <summary>
    /// Sub-merchant’s email address.
    /// <para>
    /// <b>Maximum length for processors</b>
    /// </para>
    /// <list type="bullet">
    ///   <item><description>American Express Direct: 40</description></item>
    ///   <item><description>CyberSource through VisaNet: 40</description></item>
    ///   <item><description>FDC Compass: 40</description></item>
    ///   <item><description>FDC Nashville Global: 19</description></item>
    /// </list>
    /// <para>
    /// #### CyberSource through VisaNet
    /// With American Express, the value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCRB
    /// - Position: 25-64
    /// - Field: American Express Seller E-mail Address
    /// </para>
    /// <para>
    /// <b>Note</b> The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(40)]
    public string? Email { get; init; }

    /// <summary>
    /// Sub-merchant’s telephone number.
    /// <para>
    /// <b>Maximum length for procesors</b>
    /// </para>
    /// <list type="bullet">
    ///   <item><description>American Express Direct: 20</description></item>
    ///   <item><description>CyberSource through VisaNet: 20</description></item>
    ///   <item><description>FDC Compass: 13</description></item>
    ///   <item><description>FDC Nashville Global: 10</description></item>
    /// </list>
    /// <para>
    /// #### CyberSource through VisaNet
    /// With American Express, the value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP01 TCRB
    /// - Position: 5-24
    /// - Field: American Express Seller Telephone Number
    /// </para>
    /// <para>
    /// <b>FDC Compass</b>\
    /// This value must consist of uppercase characters. Use one of these recommended formats:\
    /// <c>NNN-NNN-NNNN</c>\
    /// <c>NNN-AAAAAAA</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(20)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The ID you assigned to your sub-merchant.
    /// CyberSource through VisaNet: For American Express transaction, the value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCRB
    /// - Position: 65-84
    /// - Field: American Express Seller ID
    /// For  Mastercard transactions, the value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCR6
    /// - Position: 117-131
    /// - Field: Sub-Merchant ID
    /// FDC Compass: This value must consist of uppercase characters.
    /// <para>
    /// American Express Direct: String (20)
    /// CyberSource through VisaNet with American Express: String (20)
    /// CyberSource through VisaNet with Visa,Mastercard and Discover: String (15)
    /// FDC Compass: String (20)
    /// FDC Nashville Global: String (14)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(20)]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantCategoryCode")]
    public double? MerchantCategoryCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
