using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Initiator1
{
    /// <summary>
    /// Indicates to an issuing bank whether a merchant-initiated transaction came from a card that was already stored on file.
    /// <para>
    /// Possible values:
    /// - <b>true</b> means the merchant-initiated transaction came from a card that was already stored on file.
    /// - <b>false</b>  means the merchant-initiated transaction came from a card that was not stored on file.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedCredentialUsed")]
    public bool? StoredCredentialUsed { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
