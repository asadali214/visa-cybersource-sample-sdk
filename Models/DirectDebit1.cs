using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record DirectDebit1
{
    /// <summary>
    /// Mandate reference as returned on the first transaction in the
    /// sequence
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(255)]
    public string? Reference { get; init; }

    /// <summary>
    /// Date of the initial transaction, format is YYYY-MM-DD. Date
    /// can be taken from the finaltimestamp of the SUCCEEDED
    /// notification for the first transaction in the sequence.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatureDate")]
    [MaxLength(255)]
    public string? SignatureDate { get; init; }

    /// <summary>
    /// Valid URL pointing to the SEPA mandate, needs to be accessible
    /// by our risk and compliance department.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [MaxLength(255)]
    public string? Url { get; init; }

    /// <summary>
    /// Sequence type of the direct debit, defaults to “oneOff”. Valid
    /// values:
    /// oneOff The direct debit is executed once.
    /// first First direct debit in a series of recurring ones.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(255)]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
