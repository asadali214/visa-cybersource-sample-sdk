using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Avs1
{
    /// <summary>
    /// AVS result code sent directly from the processor. Returned only when the processor returns this value.
    /// <b>Important</b> Do not use this field to evaluate the result of AVS. Use for debugging purposes only.
    /// <para>
    /// Returned by authorization service.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("codeRaw")]
    [MaxLength(10)]
    public string? CodeRaw { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
