using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PurchaseOptions
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

    /// <summary>
    /// Flag that indicates an EBT voucher transaction. Possible value:
    /// - <c>EBT_VOUCHER</c>: Indicates the PIN debit transaction is an EBT voucher.
    /// - <c>BUY</c>
    /// - <c>RENT</c>
    /// - <c>BOOK</c>
    /// - <c>SUBSCRIBE</c>
    /// - <c>DOWNLOAD</c>
    /// - <c>ORDER</c>
    /// - <c>CONTINUE</c>
    /// <para>
    /// #### PIN debit
    /// Required field for EBT voucher transactions that use PIN debit purchase; otherwise, not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(20)]
    public string? Type { get; init; }

    /// <summary>
    /// This field contains installment data defined by MasterCard.
    /// Possible values:
    ///   - Y = eligible
    ///   - N = not eligile
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eligibilityIndicator")]
    [MaxLength(20)]
    public string? EligibilityIndicator { get; init; }

    /// <summary>
    /// Workplace benefit amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("benefitAmount")]
    [MaxLength(20)]
    public string? BenefitAmount { get; init; }

    /// <summary>
    /// Workplace benefit type.
    /// Possible values:
    /// - 70 = employee benefit
    /// - 4T = transportation / transit
    /// - 52 = general benefit
    /// - 53 = meal voucher
    /// - 54 = fuel
    /// - 55 = ecological / sustainability
    /// - 58 = philanthropy / patronage / consumption
    /// - 59 = gift
    /// - 5S = sport / culture
    /// - 5T = book / education
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("benefitType")]
    [MaxLength(100)]
    public string? BenefitType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
