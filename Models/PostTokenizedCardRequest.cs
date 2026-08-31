using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PostTokenizedCardRequest
{
    /// <summary>
    /// An identifier provided by the issuer for the account.
    /// <b>Required when source is ISSUER.</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountReferenceId")]
    public string? AccountReferenceId { get; init; }

    /// <summary>
    /// Identifier of the consumer within the wallet. Maximum 24 characters for VTS.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumerId")]
    [MaxLength(36)]
    public string? ConsumerId { get; init; }

    /// <summary>
    /// Specifies whether the Instrument Identifier should be created (true) or not (false) with the PAN provided for the Network Token Provision request.
    /// Possible Values:
    /// - <c>true</c>: The InstrumentIdentifier should be created.
    /// - <c>false</c>: The InstrumentIdentifier should not be created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createPanInstrumentIdentifier")]
    public bool? CreatePanInstrumentIdentifier { get; init; }

    /// <summary>
    /// Source of the card details.
    /// Possible Values:
    /// - ONFILE
    /// - TOKEN
    /// - ISSUER
    /// </summary>
    [JsonPropertyName("source")]
    public required string Source { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card24? Card { get; init; }

    /// <summary>
    /// Passcode by issuer for ID&amp;V.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passcode")]
    public Passcode? Passcode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billTo")]
    public BillTo20? BillTo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
