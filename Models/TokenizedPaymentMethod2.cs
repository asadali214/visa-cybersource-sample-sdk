using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TokenizedPaymentMethod2
{
    /// <summary>
    /// Description of the vaulted payment method shown to the buyer during checkout and in their PayPal account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(128)]
    public string? Description { get; init; }

    /// <summary>
    /// Indicates how the merchant will primarily use the vaulted payment method. Valid values:
    /// - “IMMEDIATE”: For on-demand, instant payments. These payments are variable in both amount and frequency and will be used to pay for goods or services before they are rendered to the buyer
    /// - “DEFERRED”: For post-pay payments; that is, payments for goods or services that have already been rendered to the buyer
    /// - “RECURRING_PREPAID”: For recurring payments before services are rendered.
    /// - “RECURRING_POSTPAID”: For recurring payments after services are rendered.
    /// - “THRESHOLD_PREPAID”: For payments when a pre-defined threshold is reached before services are rendered.
    /// - “THRESHOLD_POSTPAID”: For payments when a pre-defined threshold is reached after services are rendered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usagePattern")]
    [MaxLength(30)]
    public string? UsagePattern { get; init; }

    /// <summary>
    /// Indicates the type of vaulting relationship. Valid values:
    /// - “MERCHANT”: Single merchant relationship.
    /// - “PLATFORM”: Platform hosting multiple merchants.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usageType")]
    [MaxLength(255)]
    public string? UsageType { get; init; }

    /// <summary>
    /// Create multiple payment tokens for the same payer, merchant/platform combination. This helps to identify customers distinctly even though they may share the same PayPal account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowMultipleTokens")]
    public string? AllowMultipleTokens { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
