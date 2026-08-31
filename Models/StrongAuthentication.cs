using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record StrongAuthentication
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerInformation")]
    public IssuerInformation1? IssuerInformation { get; init; }

    /// <summary>
    /// This field will contain the low value exemption indicator with one of the following values:
    /// Possible values:
    /// - <c>0</c>  ( low value exemption does not apply to the transaction)
    /// - <c>1</c> (Transaction exempt from SCA as the merchant/acquirer has determined it to be a low value payment)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lowValueExemptionIndicator")]
    [MaxLength(1)]
    public string? LowValueExemptionIndicator { get; init; }

    /// <summary>
    /// This field will contain the transaction risk analysis exemption indicator with one of the following values:
    /// Possible values:
    /// - <c>0</c>  (TRA exemption does not apply to the transaction)
    /// - <c>1</c> (Transaction exempt from SCA as the merchant/acquirer has determined it to be low risk in accordance with the criteria defined by PSD2/RTS)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskAnalysisExemptionIndicator")]
    [MaxLength(1)]
    public string? RiskAnalysisExemptionIndicator { get; init; }

    /// <summary>
    /// Possible values:
    /// - <c>0</c>  (Trusted merchant exemption does not apply to the transaction)
    /// - <c>1</c> (Transaction exempt from SCA as it originated at a merchant trusted by the cardholder)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trustedMerchantExemptionIndicator")]
    [MaxLength(1)]
    public string? TrustedMerchantExemptionIndicator { get; init; }

    /// <summary>
    /// This field will contain the secure corporate payment exemption indicator with one of the following values:
    /// Possible values:
    /// - <c>0</c>  (SCA exemption does not apply to the transaction)
    /// - <c>1</c> (Transaction exempt from SCA as the merchant/acquirer has determined it as a secure corporate payment)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secureCorporatePaymentIndicator")]
    [MaxLength(1)]
    public string? SecureCorporatePaymentIndicator { get; init; }

    /// <summary>
    /// This field will contain the delegated authentication exemption indicator with one of the following values:
    /// Possible values:
    /// - <c>0</c>  (delegated Authentication exemption does not apply to the transaction)
    /// - <c>1</c> (Transaction exempt from SCA as authentication has been delegated to other provider (PSP,Acquirer))
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delegatedAuthenticationExemptionIndicator")]
    [MaxLength(1)]
    public string? DelegatedAuthenticationExemptionIndicator { get; init; }

    /// <summary>
    /// This field will contain the outage exemption indicator with one of the following values:
    /// Possible values:
    /// - <c>0</c>  (Outage Authentication exemption does not apply to the transaction)
    /// - <c>1</c> (Outage exempt from SCA as authentication could not be done due to outage)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outageExemptionIndicator")]
    [MaxLength(1)]
    public string? OutageExemptionIndicator { get; init; }

    /// <summary>
    /// Indicates the type of Authentication request
    /// <para>
    /// 01 - Payment transaction
    /// </para>
    /// <para>
    /// 02 - Recurring transaction
    /// </para>
    /// <para>
    /// 03 - Installment transaction
    /// </para>
    /// <para>
    /// 04 - Add card
    /// </para>
    /// <para>
    /// 05 - Maintain card
    /// </para>
    /// <para>
    /// 06 - Cardholder verification as part of EMV token ID and V
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationIndicator")]
    [MaxLength(2)]
    public string? AuthenticationIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
