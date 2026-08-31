using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Partner16
{
    /// <summary>
    /// Identifier for the developer that helped integrate a partner solution to CyberSource.
    /// <para>
    /// Send this value in all requests that are sent through the partner solutions built by that developer.
    /// CyberSource assigns the ID to the developer.
    /// </para>
    /// <para>
    /// <b>Note</b> When you see a developer ID of 999 in reports, the developer ID that was submitted is incorrect.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("developerId")]
    [MaxLength(8)]
    public string? DeveloperId { get; init; }

    /// <summary>
    /// Identifier for the partner that is integrated to CyberSource.
    /// <para>
    /// Send this value in all requests that are sent through the partner solution. CyberSource assigns the ID to the partner.
    /// </para>
    /// <para>
    /// <b>Note</b> When you see a solutionId of 999 in reports, the solutionId that was submitted is incorrect.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("solutionId")]
    [MaxLength(8)]
    public string? SolutionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
