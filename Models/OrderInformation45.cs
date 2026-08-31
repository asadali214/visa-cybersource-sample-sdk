using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record OrderInformation45
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountDetails")]
    public AmountDetails43? AmountDetails { get; init; }

    /// <summary>
    /// This indicates that the funds transfer is for a crypto currency transaction.
    /// Optional
    /// Y/y, true
    /// N/n, false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isCryptoCurrencyPurchase")]
    [MaxLength(5)]
    public string? IsCryptoCurrencyPurchase { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
