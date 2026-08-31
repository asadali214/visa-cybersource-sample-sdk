using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RecipientInformation3
{
    /// <summary>
    /// First name of the recipient.
    /// This field is applicable for AFT &amp; OCT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(30)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Middle name of the recipient.
    /// This field is applicable for AFT &amp; OCT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    [MaxLength(30)]
    public string? MiddleName { get; init; }

    /// <summary>
    /// Last name of the recipient.
    /// This field is applicable for AFT &amp; OCT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(30)]
    public string? LastName { get; init; }

    /// <summary>
    /// The street address of the recipient
    /// This field is applicable for AFT and OCT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(35)]
    public string? Address1 { get; init; }

    /// <summary>
    /// The city of the recipient.
    /// This field is applicable for AFT and OCT transactions.
    /// <para>
    /// Only alpha numeric values are supported.
    /// Special characters not in the standard ASCII character set are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(25)]
    public string? Locality { get; init; }

    /// <summary>
    /// The state or province of the recipient.
    /// This field is applicable for AFT and OCT transactions when the recipient country is US or CA. Else it is optional.
    /// <para>
    /// Must be a two character value
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(2)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// The country associated with the address of the recipient.
    /// This field is applicable for AFT and OCT transactions.
    /// <para>
    /// Must be a two character ISO country code.
    /// For example, see <see href="https://developer.cybersource.com/docs/cybs/en-us/country-codes/reference/all/na/country-codes/country-codes.html">ISO Country Code</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [StringLength(2, MinimumLength = 2)]
    public string? Country { get; init; }

    /// <summary>
    /// Recipient postal code. Required only for FDCCompass.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Recipient phone number. Required only for FDCCompass.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(20)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// Account owner alias name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aliasName")]
    [MaxLength(50)]
    public string? AliasName { get; init; }

    /// <summary>
    /// Account Owner Nationality
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    [MaxLength(10)]
    public string? Nationality { get; init; }

    /// <summary>
    /// Account Owner Country of Birth
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryOfBirth")]
    [MaxLength(10)]
    public string? CountryOfBirth { get; init; }

    /// <summary>
    /// Account Owner Occupation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occupation")]
    [MaxLength(50)]
    public string? Occupation { get; init; }

    /// <summary>
    /// Account Owner email address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(150)]
    public string? Email { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
