using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InstrumentIdentifier3
{
    /// <summary>
    /// Unique identifier for the Instrument Identifier token that was created as part of a bundled TOKEN_CREATE action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [StringLength(32, MinimumLength = 12)]
    public string? Id { get; init; }

    /// <summary>
    /// Issuers state for the card number.
    /// Valid values:
    /// - ACTIVE
    /// - CLOSED : The account has been closed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
