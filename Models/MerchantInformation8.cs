using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantInformation8
{
    /// <summary>
    /// Local Time of the transaction
    /// Set the timestamp for the exchange rate by ISO 8601 UTC format.
    /// Format: “YYYYMMdd’T’HHmmss’Z’”  (20151103T123456Z)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionLocalDateTime")]
    [MaxLength(16)]
    public string? TransactionLocalDateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
