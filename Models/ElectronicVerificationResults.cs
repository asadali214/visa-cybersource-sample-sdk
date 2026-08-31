using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ElectronicVerificationResults
{
    /// <summary>
    /// Mapped Electronic Verification response code for the customer’s name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(1)]
    public string? Code { get; init; }

    /// <summary>
    /// Raw Electronic Verification response code from the processor for the customer’s last name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("codeRaw")]
    [MaxLength(1)]
    public string? CodeRaw { get; init; }

    /// <summary>
    /// Mapped Electronic Verification response code for the customer’s email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(1)]
    public string? Email { get; init; }

    /// <summary>
    /// Raw Electronic Verification response code from the processor for the customer’s email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emailRaw")]
    [MaxLength(1)]
    public string? EmailRaw { get; init; }

    /// <summary>
    /// Mapped Electronic Verification response code for the customer’s phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(1)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// Raw Electronic Verification response code from the processor for the customer’s phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumberRaw")]
    [MaxLength(1)]
    public string? PhoneNumberRaw { get; init; }

    /// <summary>
    /// Mapped Electronic Verification response code for the customer’s postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(1)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Raw Electronic Verification response code from the processor for the customer’s postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCodeRaw")]
    [MaxLength(1)]
    public string? PostalCodeRaw { get; init; }

    /// <summary>
    /// Mapped Electronic Verification response code for the customer’s street address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("street")]
    [MaxLength(1)]
    public string? Street { get; init; }

    /// <summary>
    /// Raw Electronic Verification response code from the processor for the customer’s street address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streetRaw")]
    [MaxLength(1)]
    public string? StreetRaw { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Mapped Electronic Verification response code for the customer’s name.
    /// <para>
    /// Valid values :
    /// </para>
    /// <para>
    /// 'Y'   Yes, the data Matches
    /// 'N'   No Match
    /// 'O'   Partial Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(30)]
    public string? Name { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Raw Electronic Verification response code from the processor for the customer’s name.
    /// <para>
    /// Valid values :
    /// </para>
    /// <para>
    /// '01'     Match
    /// '50'     Partial Match
    /// '99'     No Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nameRaw")]
    [MaxLength(30)]
    public string? NameRaw { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Raw electronic verification response code from the processor for the customer’s first name.
    /// <para>
    /// Valid values :
    /// </para>
    /// <para>
    /// '01'     Match
    /// '50'     Partial Match
    /// '99'     No Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstNameRaw")]
    [MaxLength(2)]
    public string? FirstNameRaw { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Mapped electronic verification response code from the processor for the customer’s first name.
    /// <para>
    /// Valid values :
    /// </para>
    /// <para>
    /// 'Y'   Yes, the data Matches
    /// 'N'   No Match
    /// 'O'   Partial Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(1)]
    public string? FirstName { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Raw electronic verification response code from the processor for the customer’s middle name.
    /// <para>
    /// Valid values :
    /// </para>
    /// <para>
    /// '01'     Match
    /// '50'     Partial Match
    /// '99'     No Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleNameRaw")]
    [MaxLength(2)]
    public string? MiddleNameRaw { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Mapped electronic verification response code from the processor for the customer’s middle name.
    /// <para>
    /// Valid values :
    /// </para>
    /// <para>
    /// 'Y'   Yes, the data Matches
    /// 'N'   No Match
    /// 'O'   Partial Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    [MaxLength(1)]
    public string? MiddleName { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Raw electronic verification response code from the processor for the customer’s last name.
    /// <para>
    /// Valid values :
    /// </para>
    /// <para>
    /// '01'     Match
    /// '50'     Partial Match
    /// '99'     No Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastNameRaw")]
    [MaxLength(2)]
    public string? LastNameRaw { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Mapped electronic verification response code from the processor for the customer’s last name.
    /// <para>
    /// Valid values :
    /// </para>
    /// <para>
    /// 'Y'   Yes, the data Matches
    /// 'N'   No Match
    /// 'O'   Partial Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(1)]
    public string? LastName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
