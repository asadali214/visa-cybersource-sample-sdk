using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record SubscriptionInformation4
{
    /// <summary>
    /// Subscription code is an optional field, If not provided system generates and assign one
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(10)]
    public string? Code { get; init; }

    /// <summary>
    /// Plan Id. Use Plan Id from Create Plan Service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("planId")]
    [MaxLength(26)]
    public string? PlanId { get; init; }

    /// <summary>
    /// Subscription Name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(100)]
    public string? Name { get; init; }

    /// <summary>
    /// Start date of the Subscription
    /// <para>
    /// Start date must be in UTC. Format: YYYY-MM-DDThh:mm:ssZ
    /// The T separates the date and the time. The Z indicates UTC.
    /// </para>
    /// <para>
    /// Note: Subscription starts on the day provided in UTC.
    /// </para>
    /// <para>
    /// <b>Example</b> 2022-08-11T22:47:57Z equals August 11, 2022, at 22:47:57 (10:47:57 p.m.).
    /// Subscription will start on August 11,2022.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDate")]
    public string? StartDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
