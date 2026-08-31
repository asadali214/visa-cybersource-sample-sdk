using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Card30
{
    /// <summary>
    /// The new last 4 digits of the card number associated to the Tokenized Card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last4")]
    [MaxLength(4)]
    public string? Last4 { get; init; }

    /// <summary>
    /// The new two-digit month of the card associated to the Tokenized Card.
    /// Format: <c>MM</c>.
    /// Possible Values: <c>01</c> through <c>12</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationMonth")]
    [MaxLength(2)]
    public string? ExpirationMonth { get; init; }

    /// <summary>
    /// The new four-digit year of the card associated to the Tokenized Card.
    /// Format: <c>YYYY</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationYear")]
    [MaxLength(4)]
    public string? ExpirationYear { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
