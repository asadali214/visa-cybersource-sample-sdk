using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CardVerification1
{
    /// <summary>
    /// CVN result code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    [MaxLength(1)]
    public string? ResultCode { get; init; }

    /// <summary>
    /// CVN result code sent directly from the processor. Returned only when the processor returns this value.
    /// <para>
    /// <b>Important</b> Do not use this field to evaluate the result of card verification. Use for debugging purposes only.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCodeRaw")]
    [MaxLength(10)]
    public string? ResultCodeRaw { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
