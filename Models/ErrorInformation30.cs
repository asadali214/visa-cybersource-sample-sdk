using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ErrorInformation30
{
    /// <summary>
    /// The reason of the status.
    /// <para>
    /// Possible values:
    /// - CONTACT_PROCESSOR
    /// - INVALID_MERCHANT_CONFIGURATION
    /// - STOLEN_LOST_CARD
    /// - PROCESSOR_DECLINED
    /// - PARTIAL_APPROVAL
    /// - PAYMENT_REFUSED
    /// - INVALID_ACCOUNT
    /// - ISSUER_UNAVAILABLE
    /// - INSUFFICIENT_FUND
    /// - EXPIRED_CARD
    /// - INVALID_PIN
    /// - UNAUTHORIZED_CARD
    /// - EXCEEDS_CREDIT_LIMIT
    /// - DEBIT_CARD_USAGE_LIMIT_EXCEEDED
    /// - CVN_NOT_MATCH
    /// - DUPLICATE_REQUEST
    /// - GENERAL_DECLINE
    /// - BLACKLISTED_CUSTOMER
    /// - GATEWAY_TIMEOUT
    /// - INVALID_DATA
    /// - SYSTEM_ERROR
    /// - SERVICE_UNAVAILABLE
    /// - PROCESSOR_TIMEOUT
    /// - PAYMENT_REJECTED
    /// - PULL_PAYMENT_REFUSED
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    [MaxLength(31)]
    public string? Reason { get; init; }

    /// <summary>
    /// The detail message related to the status and reason listed above.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    [MaxLength(256)]
    public string? Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<Detail102>? Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
