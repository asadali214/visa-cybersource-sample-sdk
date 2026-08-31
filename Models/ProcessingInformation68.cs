using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation68
{
    /// <summary>
    /// Bin Source File Identifier.
    /// <para>
    /// Possible values:
    /// - itmx
    /// - rupay
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("binSource")]
    public string? BinSource { get; init; }

    /// <summary>
    /// Payout fields request parameters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutOptions")]
    public PayoutOptions? PayoutOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
