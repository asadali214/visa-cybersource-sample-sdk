using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ConsumerAuthentication1
{
    /// <summary>
    /// Cardholder authentication verification value (CAVV).
    /// <para>
    /// Conditional: this field is mandatory if the transaction is using either a Visa or Visa Electron card, and if the commerce indicator is = <c>VBV</c>.
    /// </para>
    /// <para>
    /// If in hexabinary format, length of field value must be =40.
    /// If in base64 format, length of field must be =28.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cavv")]
    [MaxLength(40)]
    public string? Cavv { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("strongAuthentication")]
    public StrongAuthentication4? StrongAuthentication { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
