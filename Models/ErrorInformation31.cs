using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ErrorInformation31
{
    /// <summary>
    /// The reason of the status.
    /// <para>
    /// Possible values:
    /// - EXPIRED_CARD
    /// - PROCESSOR_DECLINED
    /// - STOLEN_LOST_CARD
    /// - UNAUTHORIZED_CARD
    /// - CVN_NOT_MATCH
    /// - INVALID_CVN
    /// - BLACKLISTED_CUSTOMER
    /// - INVALID_ACCOUNT
    /// - GENERAL_DECLINE
    /// - RISK_CONTROL_DECLINE
    /// - PROCESSOR_RISK_CONTROL_DECLINE
    /// - DEBIT_CARD_USAGE_EXCEEDED_LIMIT
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
    public string? Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<Detail104>? Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
