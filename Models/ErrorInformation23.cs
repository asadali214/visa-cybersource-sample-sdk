using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ErrorInformation23
{
    /// <summary>
    /// The reason of the status.
    /// <para>
    /// Possible values:
    ///  - <c>EXPIRED_CARD</c>
    ///  - <c>SCORE_EXCEEDS_THRESHOLD</c>
    ///  - <c>DECISION_PROFILE_REVIEW</c>
    ///  - <c>DECISION_PROFILE_REJECT</c>
    ///  - <c>CONSUMER_AUTHENTICATION_REQUIRED</c>
    ///  - <c>INVALID_MERCHANT_CONFIGURATION</c>
    ///  - <c>CONSUMER_AUTHENTICATION_FAILED</c>
    ///  - <c>DECISION_PROFILE_CHALLENGE</c>
    ///  - <c>CUSTOMER_WATCHLIST_MATCH</c>
    ///  - <c>ADDRESS_COUNTRY_WATCHLIST_MATCH</c>
    ///  - <c>EMAIL_COUNTRY_WATCHLIST_MATCH</c>
    ///  - <c>IP_COUNTRY_WATCHLIST_MATCH</c>
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
