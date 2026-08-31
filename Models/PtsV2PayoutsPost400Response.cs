using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PtsV2PayoutsPost400Response
{
    /// <summary>
    /// Time of request in UTC. <c>Format: YYYY-MM-DDThh:mm:ssZ</c>
    /// <para>
    /// Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the
    /// time. The Z indicates UTC.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("submitTimeUtc")]
    public string? SubmitTimeUtc { get; init; }

    /// <summary>
    /// The status of the submitted transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The reason of the status.
    /// <para>
    /// Possible values:
    ///  - MISSING_FIELD
    ///  - INVALID_DATA
    ///  - DUPLICATE_REQUEST
    ///  - INVALID_CARD
    ///  - INVALID_MERCHANT_CONFIGURATION
    ///  - INVALID_AMOUNT
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
