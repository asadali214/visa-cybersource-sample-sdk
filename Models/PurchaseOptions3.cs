using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PurchaseOptions3
{
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
