using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AgreementInformation10
{
    /// <summary>
    /// Indicates whether the transaction is a billing
    /// agreement. Possible values
    /// - true
    /// - false (default)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("indicator")]
    public string? Indicator { get; init; }

    /// <summary>
    /// Description of the billing agreement
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
