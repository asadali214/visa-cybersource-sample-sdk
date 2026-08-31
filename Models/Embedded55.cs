using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// This object includes either a capture or reversal object. They each has the status of the action and link to the GET method to the following-on capture transaction or reversal transaction.
/// </summary>
public record Embedded55
{
    /// <summary>
    /// This object includes the status of the action and link to the GET method to the following-on capture transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capture")]
    public Capture5? Capture { get; init; }

    /// <summary>
    /// This object includes the status of the action and link to the GET method to the following-on reversal transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reversal")]
    public Reversal5? Reversal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
