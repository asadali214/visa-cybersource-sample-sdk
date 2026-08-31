using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RecipientInformation5
{
    /// <summary>
    /// Recipient's state. Use the State, Province, and Territory Codes for the United States and Canada.
    /// Value must be an ISO Standard State Code:
    /// https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(3)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Recipient's postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Recipient's country code. Check that this field contains 2-character alpha ISO 3166-1 standard values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [RegularExpression("^(\\s{0,2}|.{2})$")]
    public string? Country { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalIdentification")]
    public PersonalIdentification31? PersonalIdentification { get; init; }

    /// <summary>
    /// Recipient's first name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(35)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Middle Initial of recipient.
    /// This field is supported by FDC Compass.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleInitial")]
    [MaxLength(1)]
    public string? MiddleInitial { get; init; }

    /// <summary>
    /// Recipient’s middle name. This field is a pass through,
    /// which means that CyberSource does not verify the value or modify it in any way before sending it to the processor.
    /// If the field is not required for the transaction, CyberSource does not forward it to the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    [MaxLength(35)]
    public string? MiddleName { get; init; }

    /// <summary>
    /// Recipient's last name. Conditional field. If <c>recipientInformation.sameAsSender</c> = <c>false</c>, this field is mandatory.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(35)]
    public string? LastName { get; init; }

    /// <summary>
    /// Street address of recipient. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(60)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Second line of the recipient's address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(60)]
    public string? Address2 { get; init; }

    /// <summary>
    /// This field contains the house or the building number of the recipient address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buildingNumber")]
    [MaxLength(16)]
    public string? BuildingNumber { get; init; }

    /// <summary>
    /// Recipient city.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(25)]
    public string? Locality { get; init; }

    /// <summary>
    /// Government-issued identification number.
    /// <para>
    /// Conditional: This field is mandatory if the <c>processingInformation.businessApplicationId</c> is any of the following:
    /// - <c>AA</c>
    /// - <c>PP</c>
    /// - <c>TU</c>
    /// - <c>BI</c>
    /// - <c>WT</c>
    /// - <c>FT</c>
    /// - and country code = <c>BR</c>, <c>AR</c>, <c>CO</c>, <c>PE</c>, in <c>recipientInformation.countryCode</c> (Argentina, Brazil, Colombia, and Peru)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identificationNumber")]
    [MaxLength(35)]
    public string? IdentificationNumber { get; init; }

    /// <summary>
    /// <c>B</c> for Business or <c>I</c> for individual.
    /// <para>
    /// Conditional:  If <c>recipientInformation.identificationNumber</c> is present, then this field is mandatory.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(1)]
    public string? Type { get; init; }

    /// <summary>
    /// Recipient first name, this will be concatenated with the 4-digit originator abbreviation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("descriptor")]
    [MaxLength(25)]
    public string? Descriptor { get; init; }

    /// <summary>
    /// Identifier for the recipient’s account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountId")]
    [MaxLength(50)]
    public string? AccountId { get; init; }

    /// <summary>
    /// Identifies the recipient’s account type. This field is applicable for AFT transactions.
    /// <para>
    /// Valid values are:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>00</c> Other</description></item>
    ///   <item><description><c>01</c> Routing transit number (RTN) and bank account</description></item>
    ///   <item><description><c>02</c> IBAN</description></item>
    ///   <item><description><c>03</c> Card account</description></item>
    ///   <item><description><c>04</c> Email</description></item>
    ///   <item><description><c>05</c> Phone number</description></item>
    ///   <item><description><c>06</c> Bank account number (BAN) and bank identification code (BIC)</description></item>
    ///   <item><description><c>07</c> Wallet ID</description></item>
    ///   <item><description><c>08</c> Social network ID</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    [MaxLength(2)]
    public string? AccountType { get; init; }

    /// <summary>
    /// Account owner alias name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aliasName")]
    [MaxLength(50)]
    public string? AliasName { get; init; }

    /// <summary>
    /// Account Owner Country of Birth
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryOfBirth")]
    [RegularExpression("^(\\s{0,2}|.{2})$")]
    public string? CountryOfBirth { get; init; }

    /// <summary>
    /// Recipient’s date of birth. Format: YYYYMMDD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    [MaxLength(8)]
    public string? DateOfBirth { get; init; }

    /// <summary>
    /// Account Owner email address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(150)]
    public string? Email { get; init; }

    /// <summary>
    /// Account Owner Nationality
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    [RegularExpression("^(\\s{0,2}|.{2})$")]
    public string? Nationality { get; init; }

    /// <summary>
    /// Account Owner Occupation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occupation")]
    [MaxLength(50)]
    public string? Occupation { get; init; }

    /// <summary>
    /// This field contains the street name of the recipient's address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streetName")]
    [MaxLength(35)]
    public string? StreetName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
