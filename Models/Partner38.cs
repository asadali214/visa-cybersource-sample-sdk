using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Partner38
{
    /// <summary>
    /// Identifier for the developer that integrated a partner solution with Cybersource. Send this value with all requests that are sent through a partner solution built by that developer. Cybersource assigns the ID to the developer.
    /// <para>
    /// <b>Note</b> A developerId set to 999 means the submitted developer ID is incorrect.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("developerId")]
    [MaxLength(8)]
    public string? DeveloperId { get; init; }

    /// <summary>
    /// Identifier for the partner that integrated with Cybersource. Send this value with all requests sent through the partner solution. Cybersource assigns the ID to the partner.
    /// <para>
    /// <b>Note</b> A solutionId set to 999 means the submitted solutionId is incorrect.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("solutionId")]
    [MaxLength(8)]
    public string? SolutionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
