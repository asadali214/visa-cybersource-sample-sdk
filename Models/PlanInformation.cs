using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PlanInformation
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
    [JsonPropertyName("name")]
    [MaxLength(100)]
    public required string Name { get; init; }

    /// <summary>
    /// Plan description
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(255)]
    public string? Description { get; init; }

    /// <summary>
    /// Plan Status:
    ///  - <c>DRAFT</c>
    ///  - <c>ACTIVE</c> (default)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// Billing Frequency
    /// </summary>
    [JsonPropertyName("billingPeriod")]
    public required BillingPeriod BillingPeriod { get; init; }

    /// <summary>
    /// Number of times customer is going to be billed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingCycles")]
    public BillingCycles? BillingCycles { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
