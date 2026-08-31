using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PayoutInformation
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pushFunds")]
    public PushFunds? PushFunds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pullFunds")]
    public PullFunds? PullFunds { get; init; }

    /// <summary>
    /// This field indicates if the recipient issuer can accept transactions from the originator country.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geoRestrictionIndicator")]
    [MaxLength(1)]
    public string? GeoRestrictionIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
