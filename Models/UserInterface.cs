using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record UserInterface
{
    /// <summary>
    /// Border Radius, Allowed Values - Number, Chars, SPACE, Percentage(%), DOT(.),
    /// Example '25px 10px 25px 10px'; '2em 1em 0.5em 3em'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("borderRadius")]
    [MaxLength(19)]
    public string? BorderRadius { get; init; }

    /// <summary>
    /// UI Theme Name/Design Name - Allowed Chars: Alpha Numeric, Dot (.), Hyphen (-), Underscore (_)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("theme")]
    [MaxLength(19)]
    public string? Theme { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color")]
    public Color? Color { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
