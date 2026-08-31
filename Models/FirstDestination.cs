using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record FirstDestination
{
    /// <summary>
    /// Country of first destination on the route.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(90)]
    public string? Country { get; init; }

    /// <summary>
    /// City of first destination on the route.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(90)]
    public string? Locality { get; init; }

    /// <summary>
    /// Latitude of first destination on the route.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latitude")]
    [MaxLength(10)]
    public string? Latitude { get; init; }

    /// <summary>
    /// Longitude of first destination on the route.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("longitude")]
    [MaxLength(10)]
    public string? Longitude { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
