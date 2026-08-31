using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PayoutOptions1
{
    /// <summary>
    /// If true then provide attributes related to fund transfer/payouts. If payout information not found then response will have standard account lookup.
    /// Possible values:
    /// - <c>true</c>
    /// - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutInquiry")]
    [MaxLength(5)]
    public string? PayoutInquiry { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
