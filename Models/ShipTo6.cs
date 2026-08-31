using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ShipTo6
{
    /// <summary>
    /// First name of the recipient.
    /// <para>
    /// #### Litle
    /// Maximum length: 25
    /// </para>
    /// <para>
    /// #### All other processors
    /// Maximum length: 60
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(60)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Last name of the recipient.
    /// <para>
    /// #### Litle
    /// Maximum length: 25
    /// </para>
    /// <para>
    /// #### All other processors
    /// Maximum length: 60
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(60)]
    public string? LastName { get; init; }

    /// <summary>
    /// First line of the shipping address.
    /// <para>
    /// Required field for authorization if any shipping address information is included in the request; otherwise, optional.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes.
    /// Billing address objects will be used to determine the cardholder’s location when shipTo objects are not present.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(60)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Second line of the shipping address.
    /// <para>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes.
    /// Billing address objects will be used to determine the cardholder’s location when shipTo objects are not present.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(60)]
    public string? Address2 { get; init; }

    /// <summary>
    /// City of the shipping address.
    /// <para>
    /// Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or
    /// Canada; otherwise, optional.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes.
    /// Billing address objects will be used to determine the cardholder’s location when shipTo objects are not present.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(50)]
    public string? Locality { get; init; }

    /// <summary>
    /// State or province of the shipping address. Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf">State, Province, and Territory Codes for the United States and Canada</see> (maximum length: 2)
    /// <para>
    /// Required field for authorization if any shipping address information is included in the request and shipping to the U.S.
    /// or Canada; otherwise, optional.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes.
    /// Billing address objects will be used to determine the cardholder’s location when shipTo objects are not present.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(50)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Postal code for the shipping address. The postal code must consist of 5 to 9 digits.
    /// <para>
    /// Required field for authorization if any shipping address information is included in the request and
    /// shipping to the U.S. or Canada; otherwise, optional.
    /// </para>
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
    /// #### American Express Direct
    /// Before sending the postal code to the processor, all nonalphanumeric characters are removed and, if the
    /// remaining value is longer than nine characters, the value is truncated starting from the right side.
    /// #### Tax Calculation
    /// Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes.
    /// Billing address objects will be used to determine the cardholder’s location when shipTo objects are not present.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(32)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Country of the shipping address. Use the two-character <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes.</see>
    /// <para>
    /// Required field for authorization if any shipping address information is included in the request; otherwise, optional.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S., Canadian, international tax, and value added taxes.
    /// Billing address objects will be used to determine the cardholder’s location when shipTo objects are not present.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(3)]
    public string? Country { get; init; }

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
