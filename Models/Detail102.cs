using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Detail102
{
    /// <summary>
    /// This is the flattened JSON object field name/path that is either missing or invalid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    [MaxLength(256)]
    public string? Field { get; init; }

    /// <summary>
    /// Possible reasons for the error.
    /// <para>
    /// Possible values:
    /// - AUTH_ALREADY_REVERSED
    /// - CONTACT_PROCESSOR
    /// - DEBIT_CARD_USAGE_LIMIT_EXCEEDED
    /// - EXCEEDS_AUTH_AMOUNT
    /// - EXCEEDS_CREDIT_LIMIT
    /// - EXPIRED_CARD
    /// - GENERAL_DECLINE
    /// - INSUFFICIENT_FUND
    /// - INVALID_CVN
    /// - INVALID_DATA
    /// - MISSING_AUTH
    /// - PARTIAL_APPROVAL
    /// - PROCESSOR_DECLINED
    /// - SERVER_ERROR
    /// - STOLEN_LOST_CARD
    /// - SUCCESS
    /// - UNAUTHORIZED_CARD
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    [MaxLength(31)]
    public string? Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
