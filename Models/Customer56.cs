using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Customer56
{
    /// <summary>
    /// Unique identifier for the Customer token used in the transaction. When you include this value in your request, many of the fields that are normally required become optional.
    /// <para>
    /// If you intend on using more than one token, please take note of the following conditions:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>In case a Customer token is accompanied by an Instrument Identifier token, the card number from the Instrument Identifier token will take precedence over the Customer token.</description></item>
    ///   <item><description>The Customer token and the Payment Instrument token are mutually exclusive. If both are present, you will receive an error.</description></item>
    /// </list>
    /// <para>
    /// For more information on TMS, please see our originator-facing documentation.
    /// </para>
    /// <para>
    /// Conditional: If the card and paymentInstrument object information is incomplete, this field becomes mandatory to retrieve missing information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(32)]
    public string? Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
