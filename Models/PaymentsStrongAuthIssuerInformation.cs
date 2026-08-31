using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentsStrongAuthIssuerInformation
{
    /// <summary>
    /// Possible values: Visa Platform Connect
    /// - <c>8401</c> Merchant not participating in Visa Trusted Listing Program.
    /// - <c>8402</c> Issuer not participating in Visa Trusted Listing Program.
    /// - <c>8403</c> Cardholder has not trusted the merchant (supplied by Visa Net).
    /// - <c>8404</c> Indeterminate or invalid issuer response.
    /// - <c>8473</c> Cardholder has not trusted the merchant (issuer-supplied).
    /// - <c>8474</c> Did not meet the exemption criteria (issuer-supplied).
    /// <para>
    /// Upto 20 Values may be received in a transaction.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskAnalysisExemptionResult")]
    [MaxLength(80)]
    public string? RiskAnalysisExemptionResult { get; init; }

    /// <summary>
    /// Possible values: Visa Platform Connect
    /// - <c>2</c> Trusted merchant exemption validated/honored.
    /// - <c>3</c> Trusted merchant exemption failed validation/not honored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trustedMerchantExemptionResult")]
    [MaxLength(4)]
    public string? TrustedMerchantExemptionResult { get; init; }

    /// <summary>
    /// This will be the value returned by Visanet when low value exemption has been requested.
    /// <para>
    /// Valid values: Visa Platform Connect
    /// - <c>2</c> Low value exemption validated/honored
    /// - <c>3</c> Low value exemption failed validation/not honored
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lowValueExemptionResult")]
    [MaxLength(1)]
    public string? LowValueExemptionResult { get; init; }

    /// <summary>
    /// This will be the value returned by Visanet when secure corporate payment (scp) exemption has been requested.
    /// <para>
    /// Valid values: Visa Platform Connect
    /// - <c>2</c> Secure corporate payment exemption validated/honored
    /// - <c>3</c> Secure corporate payment exemption failed validation/not honored
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secureCorporatePaymentResult")]
    [MaxLength(1)]
    public string? SecureCorporatePaymentResult { get; init; }

    /// <summary>
    /// This will be the value returned by Visanet when transaction risk analysis (TRA) exemption has been requested.
    /// <para>
    ///   Valid values: Visa Platform Connect
    ///   - <c>2</c> transaction risk analysis (TRA) exemption validated/honored
    ///   - <c>3</c> transaction risk analysis (TRA) exemption failed validation/not honored
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionRiskAnalysisExemptionResult")]
    [MaxLength(1)]
    public string? TransactionRiskAnalysisExemptionResult { get; init; }

    /// <summary>
    /// This will be the value returned by Visanet when delegated authentication has been requested.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delegatedAuthenticationResult")]
    [MaxLength(1)]
    public string? DelegatedAuthenticationResult { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
