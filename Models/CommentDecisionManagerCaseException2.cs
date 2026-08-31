using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CommentDecisionManagerCaseException2
{
    /// <summary>
    /// Time of request in UTC. Format: <c>YYYY-MM-DDThh:mm:ssZ</c>
    /// <b>Example</b> <c>2016-08-11T22:47:57Z</c> equals August 11, 2016, at 22:47:57 (10:47:57 p.m.).
    /// The <c>T</c> separates the date and the time. The <c>Z</c> indicates UTC.
    /// <para>
    /// Returned by Cybersource for all services.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("submitTimeUtc")]
    public string? SubmitTimeUtc { get; init; }

    /// <summary>
    /// The status of the submitted transaction.
    /// Possible values:
    /// - <c>INVALID_REQUEST</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The reason of the status.
    /// Possible Values:
    /// - <c>ACCESS_DENIED</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The request has an authorization failure.
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
