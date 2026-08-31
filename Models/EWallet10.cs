using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record EWallet10
{
    /// <summary>
    /// Payment mode for the transaction, possible values
    /// - INSTANT_TRANSFER
    /// - MANUAL_BANK_TRANSFER
    /// - DELAYED_TRANSFER
    /// - ECHECK
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    [MaxLength(24)]
    public string? FundingSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
