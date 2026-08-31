using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// The images to be used as background on Klarna’s payment page (the
/// image best matching the resolution will be used). This is a pass-through
/// field. Check Klarna’s documentation for more information about the correct
/// format. This value can also be set in the merchant configuration.
/// </summary>
public record UserAgent
{
    /// <summary>
    /// Url for the image
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [MaxLength(255)]
    public string? Url { get; init; }

    /// <summary>
    /// Width of the image
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("width")]
    public int? Width { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
