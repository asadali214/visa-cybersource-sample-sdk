using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PersonalIdentification32
{
    /// <summary>
    /// Issuing country of the identification.
    /// The field format should be a 2 character ISO 3166-1 alpha-2 country code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuingCountry")]
    [RegularExpression("^(\\s{0,2}|.{2})$")]
    public string? IssuingCountry { get; init; }

    /// <summary>
    /// The ID number/value.
    /// <para>
    /// Visa Direct(35 characters)
    /// This tag will contain an acquirer-populated id value associated with the API.
    /// If <c>senderInformation.personalIdentification.type</c>=<c>BTHD</c>, then the id format must be <c>YYYYMMDD</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(80)]
    public string? Id { get; init; }

    /// <summary>
    /// Visa Direct
    /// This tag will contain the type of sender identification.
    /// The valid values are:
    /// • <c>BTHD</c> (Date of birth)
    /// • <c>CUID</c> (Customer identification (unspecified))
    /// • <c>NTID</c> (National identification)
    /// • <c>PASN</c> (Passport number)
    /// • <c>DRLN</c> (Driver license)
    /// • <c>TXIN</c> (Tax identification)
    /// • <c>CPNY</c> (Company registration number)
    /// • <c>PRXY</c> (Proxy identification)
    /// • <c>SSNB</c> (Social security number)
    /// • <c>ARNB</c> (Alien registration number)
    /// • <c>LAWE</c> (Law enforcement identification)
    /// • <c>MILI</c> (Military identification)
    /// • <c>TRVL</c> (Travel identification (non-passport))
    /// • <c>EMAL</c> (Email)
    /// • <c>PHON</c> (Phone number)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [RegularExpression("^(\\s{0,4}|.{4})$")]
    public string? Type { get; init; }

    /// <summary>
    /// It denotes whether the tax ID is a business or individual tax ID.
    /// The valid values are:
    /// • <c>B</c> (Business)
    /// • <c>I</c> (Individual)
    /// <para>
    /// Visa Direct
    /// This field is required when <c>senderInformation.personalIdentification.type</c> has the value of <c>TXIN</c> (Tax identification).
    /// A value for <c>senderInformation.personalInformation.id</c> is required when <c>senderInformation.personalIdentification.personalIdType</c> is present in a request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalIdType")]
    [RegularExpression("^(\\s{0,1}|.{1})$")]
    public string? PersonalIdType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
