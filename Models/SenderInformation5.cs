using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record SenderInformation5
{
    /// <summary>
    /// This field is applicable for AFT transactions.
    /// <para>
    /// Contains a transaction reference number provided by the Merchant. Only alpha numeric values are supported.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceNumber")]
    [MaxLength(19)]
    public string? ReferenceNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
