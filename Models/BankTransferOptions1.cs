using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BankTransferOptions1
{
    /// <summary>
    /// Method used for settlement.
    /// <para>
    /// Possible values:
    /// - <c>A</c>: Automated Clearing House (default for credits and for transactions using Canadian dollars)
    /// - <c>F</c>: Facsimile draft (U.S. dollars only)
    /// - <c>B</c>: Best possible (U.S. dollars only) (default if the field has not already been configured for your
    /// merchant ID)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementMethod")]
    [MaxLength(1)]
    public string? SettlementMethod { get; init; }

    /// <summary>
    /// Level of fraud screening.
    /// <para>
    /// Possible values:
    /// - <c>1</c>: Validation — default if the field has not already been configured for your merchant ID
    /// - <c>2</c>: Verification
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudScreeningLevel")]
    [MaxLength(1)]
    public string? FraudScreeningLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
