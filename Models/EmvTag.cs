using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record EmvTag
{
    /// <summary>
    /// EMV tag, 1-10 hex characters.
    /// </summary>
    [JsonPropertyName("tag")]
    [StringLength(10, MinimumLength = 1)]
    [RegularExpression("^[0-9A-Fa-f]{1,10}$")]
    public required string Tag { get; init; }

    /// <summary>
    /// EMV tag value, 1-64 characters.
    /// </summary>
    [JsonPropertyName("value")]
    [StringLength(64, MinimumLength = 1)]
    public required string Value { get; init; }

    /// <summary>
    /// Source of the tag.
    /// <para>
    /// Possible Values:
    ///   - CARD
    ///   - TERMINAL
    /// </para>
    /// </summary>
    [JsonPropertyName("source")]
    public required string Source { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
