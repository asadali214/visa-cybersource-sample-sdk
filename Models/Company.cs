using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Company
{
    /// <summary>
    /// Name of the customer’s company.
    /// <para>
    /// <b>CyberSource through VisaNet</b>
    /// Credit card networks cannot process transactions that contain non-ASCII characters. CyberSource through VisaNet accepts and stores non-ASCII characters correctly and displays them correctly in reports. However, the limitations of the credit card networks prevent CyberSource through VisaNet from transmitting non-ASCII characters to the credit card networks. Therefore, CyberSource through VisaNet replaces non-ASCII characters with meaningless ASCII characters for transmission to the credit card networks.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(60)]
    public string? Name { get; init; }

    /// <summary>
    /// First line in the street address of the company purchasing the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(40)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Additional address information for the company purchasing the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(40)]
    public string? Address2 { get; init; }

    /// <summary>
    /// City in the address of the company purchasing the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(30)]
    public string? Locality { get; init; }

    /// <summary>
    /// State or province in the address of the company purchasing the product. Use the State, Province, and Territory
    /// Codes for the United States and Canada.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(50)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Postal code in the address of the company purchasing the product. The postal code must consist of 5 to 9 digits.
    /// <para>
    /// When the company country is the U.S., the 9-digit postal code must follow this format:
    /// <b>[5 digits][dash][4 digits]</b>
    /// </para>
    /// <example>
    /// <c>12345-6789</c>
    /// <para>
    /// When the company country is Canada, the 6-digit postal code must follow this format:
    /// <b>[alpha][numeric][alpha][space][numeric][alpha][numeric]</b>
    /// #### Example
    /// <c>A1B 2C3</c>
    /// </para>
    /// </example>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Country in the address of the company purchasing the product. Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
