using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InstrumentIdentifier34
{
    /// <summary>
    /// Unique identifier for the Instrument Identifier token used in the transaction. When you use this in the request, the card number field becomes optional. Conditional: this field is only required if card number is not sent in through <c>senderInformation.paymentInformation.card.number</c>.
    /// <para>
    /// For more information on TMS, please see our originator-facing documentation.
    /// </para>
    /// <para>
    /// Conditional: this field is only required if card number is <b>not</b> sent in through <c>senderInformation.paymentInformation.card.number</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(32)]
    public string? Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
