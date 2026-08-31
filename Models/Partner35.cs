using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Partner35
{
    /// <summary>
    /// Value that links the previous transaction to the current follow-on request. This value is assigned by the client
    /// software that is installed on the POS terminal, which makes it available to the terminal’s software and to
    /// CyberSource. Therefore, you can use this value to reconcile transactions between CyberSource and the terminal’s
    /// software.
    /// <para>
    /// CyberSource does not forward this value to the processor. Instead, the value is forwarded to the CyberSource
    /// reporting functionality.
    /// </para>
    /// <para>
    /// This field is supported only on American Express Direct, FDC Nashville Global, and SIX.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalTransactionId")]
    [MaxLength(32)]
    public string? OriginalTransactionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
