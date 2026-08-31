using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PersonalIdentification31
{
    /// <summary>
    /// Issuing country of the identification. The field format should be a 2 character ISO 3166-1 alpha-2 country code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuingCountry")]
    [MaxLength(2)]
    public string? IssuingCountry { get; init; }

    /// <summary>
    /// This tag will contain an acquirer-populated id value associated with the API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(35)]
    public string? Id { get; init; }

    /// <summary>
    /// This tag will contain the type of recipient identification. The valid values are:
    /// <list type="bullet">
    ///   <item><description><c>BTHD</c>: (Date of birth)</description></item>
    ///   <item><description><c>CUID</c>: (Customer identification (unspecified))</description></item>
    ///   <item><description><c>NTID</c>: (National identification)</description></item>
    ///   <item><description><c>PASN</c>: (Passport number)</description></item>
    ///   <item><description><c>DRLN</c>: (Driver license)</description></item>
    ///   <item><description><c>TXIN</c>: (Tax identification)</description></item>
    ///   <item><description><c>CPNY</c>: (Company registration number)</description></item>
    ///   <item><description><c>PRXY</c>: (Proxy identification)</description></item>
    ///   <item><description><c>SSNB</c>: (Social security number)</description></item>
    ///   <item><description><c>ARNB</c>: (Alien registration number)</description></item>
    ///   <item><description><c>LAWE</c>: (Law enforcement identification)</description></item>
    ///   <item><description><c>MILI</c>: (Military identification)</description></item>
    ///   <item><description><c>TRVL</c>: (Travel identification (non-passport))</description></item>
    ///   <item><description><c>EMAL</c>: (Email)</description></item>
    ///   <item><description><c>PHON</c>: (Phone number)</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [RegularExpression("^(\\s{0,4}|.{4})$")]
    public string? Type { get; init; }

    /// <summary>
    /// This field denotes whether the Tax ID is a business or individual's Tax ID when idType contains the value of TXIN (Tax identification).
    /// The valid values are: B (Business) I (Individual)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalIdType")]
    [RegularExpression("^(\\s{0,1}|.{1})$")]
    public string? PersonalIdType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
