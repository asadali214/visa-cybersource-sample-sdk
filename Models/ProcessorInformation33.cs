using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessorInformation33
{
    /// <summary>
    /// This field is returned by authorization and incremental authorization services.
    /// System trace number that must be printed on the customer’s receipt.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("systemTraceAuditNumber")]
    [MaxLength(6)]
    public string? SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Network transaction identifier (TID). This value can be used to identify a specific transaction when you are discussing the transaction with your processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionId")]
    [MaxLength(15)]
    public string? TransactionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
