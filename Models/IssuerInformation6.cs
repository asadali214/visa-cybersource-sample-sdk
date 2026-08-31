using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record IssuerInformation6
{
    /// <summary>
    /// This field contains the issuer name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(200)]
    public string? Name { get; init; }

    /// <summary>
    /// This field contains <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">2-character ISO Country Codes</see> for the issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

    /// <summary>
    /// This field contains the length of the BIN. In some cases, this field may be absent if we do not receive accurate information from the network source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("binLength")]
    [MaxLength(2)]
    public string? BinLength { get; init; }

    /// <summary>
    /// This field contains the first 6 to 8 digits of a primary account number (PAN). The length of the field is determined by <see href="https://pcissc.secure.force.com/faq/articles/Frequently_Asked_Question/What-are-acceptable-formats-for-truncation-of-primary-account-numbers">PCI-DSS standards for truncation</see>.In case the input is not the full intrument (PAN or TOKEN), this field may be truncated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountPrefix")]
    [MaxLength(8)]
    public string? AccountPrefix { get; init; }

    /// <summary>
    /// This field contains the customer service phone number for the issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(50)]
    public string? PhoneNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
