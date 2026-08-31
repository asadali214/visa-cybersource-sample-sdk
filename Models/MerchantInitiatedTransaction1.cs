using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantInitiatedTransaction1
{
    /// <summary>
    /// Network transaction identifier that was returned in the payment response field _processorInformation.transactionID_
    /// in the reply message for either the original merchant-initiated payment in the series or the previous
    /// merchant-initiated payment in the series.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("previousTransactionId")]
    [MaxLength(15)]
    public string? PreviousTransactionId { get; init; }

    /// <summary>
    /// Amount of the original authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalAuthorizedAmount")]
    [MaxLength(15)]
    public string? OriginalAuthorizedAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
