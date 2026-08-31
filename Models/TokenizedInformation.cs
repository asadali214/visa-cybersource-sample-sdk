using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TokenizedInformation
{
    /// <summary>
    /// Value that identifies your business and indicates that the cardholder’s account number is tokenized. This value
    /// is assigned by the token service provider and is unique within the token service provider’s database.
    /// <para>
    /// <b>Note</b> This field is supported only through <b>VisaNet</b> and <b>FDC Nashville Global</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestorID")]
    [MaxLength(11)]
    public string? RequestorId { get; init; }

    /// <summary>
    /// Type of transaction that provided the token data. This value does not specify the token service provider; it
    /// specifies the entity that provided you with information about the token.
    /// <para>
    /// Set the value for this field to 1. An application on the customer’s mobile device provided the token data.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionType")]
    [MaxLength(1)]
    public string? TransactionType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
