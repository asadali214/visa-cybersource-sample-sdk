using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Card art associated with the tokenized card.
/// </summary>
public record TmsCardArt
{
    /// <summary>
    /// Card foreground color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foregroundColor")]
    public string? ForegroundColor { get; init; }

    /// <summary>
    /// Card background color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; init; }

    /// <summary>
    /// Card label color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("labelColor")]
    public string? LabelColor { get; init; }

    /// <summary>
    /// Combined card art asset associated with the tokenized card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("combinedAsset")]
    public CombinedAsset? CombinedAsset { get; init; }

    /// <summary>
    /// Brand logo card art asset associated with the tokenized card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brandLogoAsset")]
    public BrandLogoAsset? BrandLogoAsset { get; init; }

    /// <summary>
    /// Issuer logo card art asset associated with the tokenized card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerLogoAsset")]
    public IssuerLogoAsset? IssuerLogoAsset { get; init; }

    /// <summary>
    /// Icon card art asset associated with the tokenized card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iconAsset")]
    public IconAsset? IconAsset { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
