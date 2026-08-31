using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Address1
{
    /// <summary>
    /// First line of the standardized address, including apartment information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("withApartment")]
    [MaxLength(255)]
    public string? WithApartment { get; init; }

    /// <summary>
    /// First line of the standardized address, without apartment information.
    /// Returned for U.S. and Canadian addresses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("withoutApartment")]
    [MaxLength(255)]
    public string? WithoutApartment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
