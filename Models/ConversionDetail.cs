using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ConversionDetail
{
    /// <summary>
    /// Merchant reference number of a merchant
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReferenceNumber")]
    public string? MerchantReferenceNumber { get; init; }

    /// <summary>
    /// Date of conversion
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conversionTime")]
    public DateTimeOffset? ConversionTime { get; init; }

    /// <summary>
    /// Cybersource Transation request id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }

    /// <summary>
    /// Original decision
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalDecision")]
    public string? OriginalDecision { get; init; }

    /// <summary>
    /// New decision
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newDecision")]
    public string? NewDecision { get; init; }

    /// <summary>
    /// User name of the reviewer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reviewer")]
    public string? Reviewer { get; init; }

    /// <summary>
    /// Comments of the reviewer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reviewerComments")]
    public string? ReviewerComments { get; init; }

    /// <summary>
    /// Name of the queue
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("queue")]
    public string? Queue { get; init; }

    /// <summary>
    /// Name of the profile
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profile")]
    public string? Profile { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    public IReadOnlyList<Note>? Notes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
