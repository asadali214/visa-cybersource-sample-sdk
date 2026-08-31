using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record IssuedBy
{
    /// <summary>
    /// The State or province where the customer’s driver’s license was issued.
    /// <para>
    /// Use the two-character State, Province, and Territory Codes for the United States and Canada.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(20)]
    public string? AdministrativeArea { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
