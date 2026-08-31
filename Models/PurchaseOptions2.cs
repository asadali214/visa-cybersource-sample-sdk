using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PurchaseOptions2
{
    /// <summary>
    /// Flag that indicates whether this transaction is an EBT transaction. Possible values:
    /// - <c>true</c>
    /// - <c>false</c>
    /// <para>
    /// #### PIN debit
    /// Required field for EBT and EBT voucher transactions that use PIN debit credit or PIN debit purchase; otherwise, not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isElectronicBenefitsTransfer")]
    public bool? IsElectronicBenefitsTransfer { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
