using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record IssuerInformation35
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
    /// This field contains the length of the BIN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("binLength")]
    [MaxLength(2)]
    public string? BinLength { get; init; }

    /// <summary>
    /// This field contains the customer service phone number for the issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(50)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// In a Mastercard Transaction, this field contains the unique identifier (Transaction Link ID) for the first transaction in a transaction life cycle.
    /// This ID is crucial for maintaining continuity and linking subsequent operations to the original transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionInformation")]
    [MaxLength(36)]
    public string? TransactionInformation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
