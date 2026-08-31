using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Color
{
    /// <summary>
    /// Border Color
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("border")]
    [MaxLength(10)]
    public string? Border { get; init; }

    /// <summary>
    /// Selected Border Color
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("borderSelected")]
    [MaxLength(10)]
    public string? BorderSelected { get; init; }

    /// <summary>
    /// Button Color
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("button")]
    [MaxLength(10)]
    public string? Button { get; init; }

    /// <summary>
    /// Button Text Color
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buttonText")]
    [MaxLength(10)]
    public string? ButtonText { get; init; }

    /// <summary>
    /// Checkbox Color
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkbox")]
    [MaxLength(10)]
    public string? Checkbox { get; init; }

    /// <summary>
    /// Checkbox Checkmark Color
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkboxCheckMark")]
    [MaxLength(10)]
    public string? CheckboxCheckMark { get; init; }

    /// <summary>
    /// Header Color
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("header")]
    [MaxLength(10)]
    public string? Header { get; init; }

    /// <summary>
    /// Link Color
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    [MaxLength(10)]
    public string? Link { get; init; }

    /// <summary>
    /// Text Color
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    [MaxLength(10)]
    public string? Text { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
