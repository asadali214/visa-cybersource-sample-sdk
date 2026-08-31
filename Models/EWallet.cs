using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record EWallet
{
    /// <summary>
    /// The ID of the customer, passed in the return_url field by PayPal after customer approval.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountId")]
    [MaxLength(26)]
    public string? AccountId { get; init; }

    /// <summary>
    /// Payment method for the unit purchase.
    /// Possible values:
    /// - `UNRESTRICTED (default)—this value
    /// is only available if configured by PayPal
    /// for the merchant.`
    /// - <c>INSTANT</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    [MaxLength(30)]
    public string? FundingSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
