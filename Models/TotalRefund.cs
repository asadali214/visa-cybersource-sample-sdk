using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TotalRefund
{
    /// <summary>
    /// Valid ISO 4217 ALPHA-3 currency code
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
