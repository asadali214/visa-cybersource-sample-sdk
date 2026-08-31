using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ErrorInformation1
{
    /// <summary>
    /// The reason of the status.
    /// <para>
    /// Possible values:
    ///   - AVS_FAILED
    ///   - CONTACT_PROCESSOR
    ///   - EXPIRED_CARD
    ///   - PROCESSOR_DECLINED
    ///   - INSUFFICIENT_FUND
    ///   - STOLEN_LOST_CARD
    ///   - ISSUER_UNAVAILABLE
    ///   - UNAUTHORIZED_CARD
    ///   - CVN_NOT_MATCH
    ///   - EXCEEDS_CREDIT_LIMIT
    ///   - INVALID_CVN
    ///   - BLOCKED_BY_CARDHOLDER
    ///   - BLACKLISTED_CUSTOMER
    ///   - SUSPENDED_ACCOUNT
    ///   - PAYMENT_REFUSED
    ///   - CV_FAILED
    ///   - INVALID_ACCOUNT
    ///   - GENERAL_DECLINE
    ///   - INVALID_MERCHANT_CONFIGURATION
    ///   - DECISION_PROFILE_REJECT
    ///   - SCORE_EXCEEDS_THRESHOLD
    ///   - CONSUMER_AUTHENTICATION_REQUIRED
    ///   - ALLOWABLE_PIN_RETRIES_EXCEEDED
    ///   - PROCESSOR_ERROR
    ///   - DAGGREJECTED
    ///   - DAGGDENIED
    ///   - DSYSREJECTED
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The detail message related to the status and reason listed above.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<Detail>? Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
