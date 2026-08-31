using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PullFundsReversal404Response1
{
    /// <summary>
    /// A unique identification number to identify the submitted request. It is also appended to the endpoint of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(26)]
    public string? Id { get; init; }

    /// <summary>
    /// Time of request in UTC.
    /// Format: <c>YYYY-MM-DDThh:mm:ssZ</c>
    /// <para>
    /// <b>Example</b>
    /// <c>2016-08-11T22:47:57Z</c> equals August 11, 2016, at 22:47:57 (10:47:57 p.m.).
    /// The <c>T</c> separates the date and the time.
    /// The <c>Z</c> indicates UTC.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("submitTimeUtc")]
    [StringLength(20, MinimumLength = 20)]
    public string? SubmitTimeUtc { get; init; }

    /// <summary>
    /// The reason of the status.
    /// <para>
    /// Possible values:
    /// - NOT_FOUND
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The detail message related to the status and reason listed above.
    /// <para>
    /// Possible values:
    /// - The requested resource does not exist
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
