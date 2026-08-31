using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Fee Funding Section
/// </summary>
public record FeeAndFundingDetail
{
    /// <summary>
    /// An unique identification number assigned by CyberSource to identify the submitted request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    [MaxLength(26)]
    public string? RequestId { get; init; }

    /// <summary>
    /// interchange Per Item Fee
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchangePerItemFee")]
    public string? InterchangePerItemFee { get; init; }

    /// <summary>
    /// interchange Description
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchangeDescription")]
    public string? InterchangeDescription { get; init; }

    /// <summary>
    /// interchange Percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchangePercentage")]
    public string? InterchangePercentage { get; init; }

    /// <summary>
    /// interchange Percentage Amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchangePercentageAmount")]
    public string? InterchangePercentageAmount { get; init; }

    /// <summary>
    /// Discount Percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountPercentage")]
    public string? DiscountPercentage { get; init; }

    /// <summary>
    /// Discount Amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountAmount")]
    public string? DiscountAmount { get; init; }

    /// <summary>
    /// Discount Per Item Fee
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountPerItemFee")]
    public string? DiscountPerItemFee { get; init; }

    /// <summary>
    /// Total Fee
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalFee")]
    public string? TotalFee { get; init; }

    /// <summary>
    /// Fee Currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeCurrency")]
    public string? FeeCurrency { get; init; }

    /// <summary>
    /// Dues Assessments
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duesAssessments")]
    public string? DuesAssessments { get; init; }

    /// <summary>
    /// Funding Amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingAmount")]
    public string? FundingAmount { get; init; }

    /// <summary>
    /// Funding Currency (ISO 4217)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingCurrency")]
    public string? FundingCurrency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
