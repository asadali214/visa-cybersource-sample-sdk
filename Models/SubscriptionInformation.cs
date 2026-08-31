using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record SubscriptionInformation
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
    [JsonPropertyName("name")]
    [MaxLength(100)]
    public required string Name { get; init; }

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
    [JsonPropertyName("startDate")]
    public required string StartDate { get; init; }

    /// <summary>
    /// Network transaction identifier that was returned in the payment response field _processorInformation.transactionId_
    /// in the reply message for the original subscription-initializing payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalTransactionId")]
    [MaxLength(50)]
    public string? OriginalTransactionId { get; init; }

    /// <summary>
    /// Amount of the original subscription-initializing payment.
    /// <para>
    /// *Required when using a Diners or Discover card*.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalTransactionAuthorizedAmount")]
    [MaxLength(19)]
    public string? OriginalTransactionAuthorizedAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
