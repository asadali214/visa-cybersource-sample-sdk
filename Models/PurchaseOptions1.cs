using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PurchaseOptions1
{
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
    /// Data mapped received in response from MasterCard.
    /// Possible values:
    /// - 01 = Meal Voucher - Employee Nutrition Program
    /// - 02 = Food Voucher - Employee Nutrition Program
    /// - 03 = Culture Voucher - Worker's Culture Program
    /// - 04 = Meal Voucher - Consolidation of Labor Laws
    /// - 05 = Food Voucher - Consolidation of Labor Laws
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(20)]
    public string? Type { get; init; }

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
