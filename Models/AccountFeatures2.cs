using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AccountFeatures2
{
    /// <summary>
    /// Card type category.
    /// Type of card used in the transaction. Possible values:
    /// - <c>B</c>: Business card.
    /// - <c>O</c>: Noncommercial card.
    /// - <c>R</c>: Corporate card.
    /// - <c>S</c>: Purchase card.
    /// - <c>X</c>: Visa B2B Virtual Payments
    /// - <c>X1</c>: Flexible Rate B2B Virtual Program
    /// - <c>Blank</c>: Purchase card not supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    [MaxLength(7)]
    public string? Category { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
