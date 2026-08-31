using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InstrumentIdentifier2
{
    /// <summary>
    /// Unique identifier for the Instrument Identifier token used in the transaction.
    /// When you include this value in your request, many of the fields that can be supplied for an authorization or credit
    /// become optional.
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
