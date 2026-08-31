using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ShipTo
{
    /// <summary>
    /// The title of the person receiving the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    [MaxLength(60)]
    public string? Title { get; init; }

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
    /// Middle name of the recipient.
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
    [JsonPropertyName("middleName")]
    [MaxLength(60)]
    public string? MiddleName { get; init; }

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
    /// U.S. county if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("county")]
    [MaxLength(50)]
    public string? County { get; init; }

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
    /// Neighborhood, community, or region within a city or municipality.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("district")]
    [MaxLength(50)]
    public string? District { get; init; }

    /// <summary>
    /// Building number in the street address. For example, the building number is 187 in the following address:
    /// <para>
    /// Rua da Quitanda 187
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buildingNumber")]
    [MaxLength(15)]
    public string? BuildingNumber { get; init; }

    /// <summary>
    /// Phone number associated with the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(15)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// Email of the recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(255)]
    public string? Email { get; init; }

    /// <summary>
    /// Name of the customer’s company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    [MaxLength(60)]
    public string? Company { get; init; }

    /// <summary>
    /// Shipping destination of item. Example: Commercial, Residential, Store
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destinationTypes")]
    [MaxLength(25)]
    public string? DestinationTypes { get; init; }

    /// <summary>
    /// Indicates destination chosen for the transaction. Possible values:
    /// - 01- Ship to cardholder billing address
    /// - 02- Ship to another verified address on file with merchant
    /// - 03- Ship to address that is different than billing address
    /// - 04- Ship to store (store address should be populated on request)
    /// - 05- Digital goods
    /// - 06- Travel and event tickets, not shipped
    /// - 07- Other
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destinationCode")]
    public int? DestinationCode { get; init; }

    /// <summary>
    /// Shipping method for the product. Possible values:
    /// - lowcost: Lowest-cost service
    /// - sameday: Courier or same-day service
    /// - oneday: Next-day or overnight service
    /// - twoday: Two-day service
    /// - threeday: Three-day service
    /// - pickup: Store pick-up
    /// - other: Other shipping method
    /// - none: No shipping method because product is a service or subscription
    /// Required for American Express SafeKey (U.S.).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    [MaxLength(10)]
    public string? Method { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
