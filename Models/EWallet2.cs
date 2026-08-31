using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record EWallet2
{
    /// <summary>
    /// Payment mode for the authorization or order transaction.  INSTANT_TRANSFER  MANUAL_BANK_TRANSFER  DELAYED_TRANSFER  ECHECK  UNRESTRICTED (default)—this value is available only when configured by PayPal for the merchant. INSTANT
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    [MaxLength(30)]
    public string? FundingSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
