using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record HeaderStyle
{
    /// <summary>
    /// The invoice font color. The format is a valid hexadecimal code prefixed with <c>#</c>, such as <c>#000000</c> for black.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fontColor")]
    [MaxLength(7)]
    [RegularExpression("^#(?:[0-9a-fA-F]{3}){1,2}$")]
    public string? FontColor { get; init; }

    /// <summary>
    /// The invoice background color. The format is a valid hexadecimal code prefixed with <c>#</c>, such as <c>#ffffff</c> for white.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backgroundColor")]
    [MaxLength(7)]
    [RegularExpression("^#(?:[0-9a-fA-F]{3}){1,2}$")]
    public string? BackgroundColor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
