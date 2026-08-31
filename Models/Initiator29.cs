using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Initiator29
{
    /// <summary>
    /// #### Visa Platform Connect :
    /// This API will contain a code that denotes whether the customer identification data belongs to the sender or the recipient.
    /// <para>
    /// The valid values are:
    /// • S (Payer (sender))
    /// • R (Payee (recipient))
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(1)]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
