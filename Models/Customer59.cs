using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Customer59
{
    /// <summary>
    /// Unique identifier for the Customer token used in the transaction.
    /// When you include this value in your request, many of the fields that are normally required for an authorization or credit
    /// become optional.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(32, MinimumLength = 1)]
    public required string Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
