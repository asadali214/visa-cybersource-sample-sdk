using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record EWallet1
{
    /// <summary>
    /// Payment mode for the reference transaction.
    /// Possible values:
    /// - <c>INSTANT_TRANSFER</c>
    /// - <c>MANUAL_BANK_TRANSFER</c>
    /// - <c>DELAYED_TRANSFER</c>
    /// - <c>ECHECK</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    [MaxLength(30)]
    public string? FundingSource { get; init; }

    /// <summary>
    /// The ID of the customer, passed in the return_url field by PayPal after customer approval.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountId")]
    [MaxLength(30)]
    public string? AccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
