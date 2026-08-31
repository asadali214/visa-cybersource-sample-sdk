using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CaseManagementCommentsRequest
{
    /// <summary>
    /// Comments to be added to case.
    /// </summary>
    [JsonPropertyName("comments")]
    [MaxLength(4000)]
    public required string Comments { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
