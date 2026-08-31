using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ShipTo14
{
    /// <summary>
    /// First name of the recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(60)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Last name of the recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(60)]
    public string? LastName { get; init; }

    /// <summary>
    /// Company associated with the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    [MaxLength(60)]
    public string? Company { get; init; }

    /// <summary>
    /// First line of the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(60)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Second line of the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(60)]
    public string? Address2 { get; init; }

    /// <summary>
    /// City of the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(50)]
    public string? Locality { get; init; }

    /// <summary>
    /// State or province of the shipping address. Use 2 character the State,
    /// Province, and Territory Codes for the United States and Canada.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(20)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Postal code for the shipping address. The postal code must consist of 5 to 9 digits.
    /// <para>
    /// When the billing country is the U.S., the 9-digit postal code must follow this format:
    /// [5 digits][dash][4 digits]
    /// </para>
    /// <para>
    /// Example 12345-6789
    /// </para>
    /// <para>
    /// When the billing country is Canada, the 6-digit postal code must follow this format:
    /// [alpha][numeric][alpha][space][numeric][alpha][numeric]
    /// </para>
    /// <para>
    /// Example A1B 2C3
    /// </para>
    /// <para>
    /// <b>American Express Direct</b>\
    /// Before sending the postal code to the processor, all nonalphanumeric characters are removed and, if the
    /// remaining value is longer than nine characters, truncates the value starting from the right side.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Country of the shipping address. Use the two-character ISO Standard Country Codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

    /// <summary>
    /// Email associated with the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(320)]
    public string? Email { get; init; }

    /// <summary>
    /// Phone number associated with the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(15)]
    public string? PhoneNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
