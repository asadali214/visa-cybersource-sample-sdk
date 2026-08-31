using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// HTTP status code for client application
/// </summary>
public record ReportingV3PurchaseRefundDetailsGet404Response1
{
    /// <summary>
    /// Time of request in UTC.
    /// </summary>
    [JsonPropertyName("submitTimeUtc")]
    public required DateTimeOffset SubmitTimeUtc { get; init; }

    /// <summary>
    /// Documented reason code
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    /// <summary>
    /// Short descriptive message to the user.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    /// <summary>
    /// Error field list
    /// </summary>
    [JsonPropertyName("details")]
    public required IReadOnlyList<Detail131> Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
