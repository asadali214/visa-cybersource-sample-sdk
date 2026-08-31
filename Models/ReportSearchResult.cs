using System;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Report Search Result Bean
/// </summary>
public record ReportSearchResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_link")]
    public Link? Link { get; init; }

    /// <summary>
    /// Unique Report Identifier of each report type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportDefinitionId")]
    public string? ReportDefinitionId { get; init; }

    /// <summary>
    /// Name of the report specified by merchant while creating the report
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportName")]
    public string? ReportName { get; init; }

    /// <summary>
    /// Format of the report to get generated
    /// Valid Values:
    /// - application/xml
    /// - text/csv
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportMimeType")]
    public string? ReportMimeType { get; init; }

    /// <summary>
    /// Frequency of the report to get generated
    /// Valid Values:
    /// - DAILY
    /// - WEEKLY
    /// - MONTHLY
    /// - ADHOC
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportFrequency")]
    public string? ReportFrequency { get; init; }

    /// <summary>
    /// Status of the report
    /// Valid Values:
    /// - COMPLETED
    /// - PENDING
    /// - QUEUED
    /// - RUNNING
    /// - ERROR
    /// - NO_DATA
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// Specifies the report start time in ISO 8601 format
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportStartTime")]
    public DateTimeOffset? ReportStartTime { get; init; }

    /// <summary>
    /// Specifies the report end time in ISO 8601 format
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportEndTime")]
    public DateTimeOffset? ReportEndTime { get; init; }

    /// <summary>
    /// Time Zone
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// Unique identifier generated for every reports
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportId")]
    public string? ReportId { get; init; }

    /// <summary>
    /// CyberSource Merchant Id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationId")]
    public string? OrganizationId { get; init; }

    /// <summary>
    /// Specifies the time of the report in queued  in ISO 8601 format
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("queuedTime")]
    public DateTimeOffset? QueuedTime { get; init; }

    /// <summary>
    /// Specifies the time of the report started to generate  in ISO 8601 format
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportGeneratingTime")]
    public DateTimeOffset? ReportGeneratingTime { get; init; }

    /// <summary>
    /// Specifies the time of the report completed the generation  in ISO 8601 format
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportCompletedTime")]
    public DateTimeOffset? ReportCompletedTime { get; init; }

    /// <summary>
    /// Specifies whether the subscription created is either Custom, Standard or Classic
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionType")]
    public string? SubscriptionType { get; init; }

    /// <summary>
    /// Id for selected group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupId")]
    public string? GroupId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
