using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record EWallet9
{
    /// <summary>
    /// Payment method for the unit purchase.
    ///   Possible values:
    ///   UNRESTRICTED (default)—this value is
    ///   available only when configured by PayPal
    ///   for the merchant.
    ///   INSTANT.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    [MaxLength(30)]
    public string? FundingSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
