using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ElectronicVerificationResults3
{
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
