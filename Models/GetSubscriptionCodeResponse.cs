using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record GetSubscriptionCodeResponse
{
    /// <summary>
    /// Subscription code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(10)]
    public string? Code { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
