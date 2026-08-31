using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PlanInformation4
{
    /// <summary>
    /// Plan code is an optional field, If not provided system generates and assign one
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(10)]
    public string? Code { get; init; }

    /// <summary>
    /// Plan name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(100)]
    public string? Name { get; init; }

    /// <summary>
    /// Plan description
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(255)]
    public string? Description { get; init; }

    /// <summary>
    /// Updating to <c>DRAFT</c> is not allowed from <c>ACTIVE</c> and <c>INACTIVE</c> status.
    /// <para>
    /// Plan Status:
    ///  - <c>DRAFT</c>
    ///  - <c>ACTIVE</c>
    ///  - <c>INACTIVE</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// Billing Frequency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingPeriod")]
    public BillingPeriod? BillingPeriod { get; init; }

    /// <summary>
    /// Number of times customer is going to be billed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingCycles")]
    public BillingCycles? BillingCycles { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
