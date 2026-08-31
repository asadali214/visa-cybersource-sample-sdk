using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Avs4
{
    /// <summary>
    /// AVS result code.
    /// <para>
    /// Code	Description
    /// - 'Y' Full Match
    /// - 'A' Partial Match (street address only)
    /// - 'Z' Partial Match (postal/zip only)
    /// - 'N' Non-Match
    /// - 'U' Unable to Verify
    /// - 'R' Indeterminate Outcome (Retry)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(1)]
    public string? Code { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
