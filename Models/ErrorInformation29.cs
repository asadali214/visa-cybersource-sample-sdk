using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ErrorInformation29
{
    /// <summary>
    /// The reason of the status.
    /// <para>
    /// Possible values:
    ///  - EXPIRED_CARD
    ///  - PROCESSOR_DECLINED
    ///  - STOLEN_LOST_CARD
    ///  - UNAUTHORIZED_CARD
    ///  - CVN_NOT_MATCH
    ///  - INVALID_CVN
    ///  - BLOCKED_BY_CARDHOLDER
    ///  - BLACKLISTED_CUSTOMER
    ///  - INVALID_ACCOUNT
    ///  - GENERAL_DECLINE
    ///  - RISK_CONTROL_DECLINE
    ///  - PROCESSOR_RISK_CONTROL_DECLINE
    ///  - ALLOWABLE_PIN_RETRIES_EXCEEDED
    ///  - PROCESSOR_ERROR
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
