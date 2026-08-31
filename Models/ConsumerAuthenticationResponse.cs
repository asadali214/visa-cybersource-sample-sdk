using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ConsumerAuthenticationResponse
{
    /// <summary>
    /// Mapped response code for Visa Secure and American Express SafeKey.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(3)]
    public string? Code { get; init; }

    /// <summary>
    /// Raw response code sent directly from the processor for Visa Secure and American Express SafeKey:
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("codeRaw")]
    [MaxLength(3)]
    public string? CodeRaw { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
