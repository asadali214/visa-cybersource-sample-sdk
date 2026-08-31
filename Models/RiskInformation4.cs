using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RiskInformation4
{
    /// <summary>
    /// Type of filter. Possible values:
    /// - ACCEPT
    /// - PENDING
    /// - DENY
    /// - REPORT
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudDecision")]
    [MaxLength(60)]
    public string? FraudDecision { get; init; }

    /// <summary>
    /// possible values
    /// - AVS_NO_MATCH
    /// - AVS_PARTIAL_MATCH
    /// - AVS_UNAVAILABLE_OR_UNSUPPORTED
    /// - CARD_SECURITY_CODE_MISMATCH
    /// - MAXIMUM_TRANSACTION_AMOUNT
    /// - UNCONFIRMED_ADDRESS
    /// - COUNTRY_MONITOR
    /// - LARGE_ORDER_NUMBER
    /// - BILLING_OR_SHIPPING_ADDRESS_MISMATCH
    /// - RISKY_ZIP_CODE
    /// - SUSPECTED_FREIGHT_FORWARDER_CHECK
    /// - TOTAL_PURCHASE_PRICE_MINIMUM
    /// - IP_ADDRESS_VELOCITY
    /// - RISKY_EMAIL_ADDRESS_DOMAIN_CHECK
    /// - RISKY_BANK_IDENTIFICATION_NUMBER_CHECK,
    /// RISKY_IP_ADDRESS_RANGE
    /// - PAYPAL_FRAUD_MODEL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudDecisionReason")]
    [MaxLength(60)]
    public string? FraudDecisionReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
