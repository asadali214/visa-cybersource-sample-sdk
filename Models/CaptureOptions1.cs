using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CaptureOptions1
{
    /// <summary>
    /// Indicates whether you can make additional captures against the authorized payment.
    /// Set to true if you do not intend to capture additional payments against the authorization.
    /// Set to false if you intend to capture additional payments
    /// Possible Values:
    /// - <c>true</c>
    /// - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finalCapture")]
    [MaxLength(5)]
    public string? FinalCapture { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
