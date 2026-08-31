using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record LoanOptions
{
    /// <summary>
    /// Type of loan based on an agreement between you and the issuer.
    /// Examples: AGROCUSTEIO, AGRO-INVEST, BNDES-Type1, CBN, FINAME.
    /// This field is supported only for these kinds of payments:
    /// - BNDES transactions on CyberSource through VisaNet.
    /// - Installment payments with Mastercard on CyberSource through VisaNet in Brazil.
    /// <para>
    /// For BNDES transactions, the value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP07 TCR2, Position: 27-46, Field: Loan Type
    /// </para>
    /// <para>
    /// For installment payments with Mastercard in Brazil, the value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP07 TCR4, Position: 5-24,Field: Financing Type
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(20)]
    public string? Type { get; init; }

    /// <summary>
    /// Indicates whether a loan is for a recoverable item or a non-recoverable item.
    /// Possible values:
    /// - <c>N</c>: non-recoverable item
    /// - <c>R</c>: recoverable item
    /// This field is supported only for BNDES transactions on CyberSource through VisaNet.
    /// The value for this field corresponds to the following data in the TC 33 capture file5:
    ///  Record: CP07 TCR2, Position: 26, Field: Asset Indicator
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assetType")]
    [MaxLength(1)]
    public string? AssetType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
