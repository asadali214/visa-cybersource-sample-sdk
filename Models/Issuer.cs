using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Issuer
{
    /// <summary>
    /// Data defined by the issuer.
    /// <para>
    /// The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.
    /// </para>
    /// <para>
    /// This field is supported only for Visa transactions on <b>CyberSource through VisaNet</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discretionaryData")]
    [MaxLength(255)]
    public string? DiscretionaryData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
