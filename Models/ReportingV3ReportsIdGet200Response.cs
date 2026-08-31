using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Report Log
/// </summary>
public record ReportingV3ReportsIdGet200Response
{
    /// <summary>
    /// CyberSource merchant id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationId")]
    public string? OrganizationId { get; init; }

    /// <summary>
    /// Report ID Value
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportId")]
    public string? ReportId { get; init; }

    /// <summary>
    /// Report definition Id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportDefinitionId")]
    public string? ReportDefinitionId { get; init; }

    /// <summary>
    /// Report Name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportName")]
    public string? ReportName { get; init; }

    /// <summary>
    /// Report Format
    /// <para>
    /// Valid values:
    /// - application/xml
    /// - text/csv
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportMimeType")]
    public string? ReportMimeType { get; init; }

    /// <summary>
    /// Report Frequency Value
    /// <para>
    /// Valid values:
    /// - DAILY
    /// - WEEKLY
    /// - MONTHLY
    /// - ADHOC
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportFrequency")]
    public string? ReportFrequency { get; init; }

    /// <summary>
    /// List of Integer Values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportFields")]
    public IReadOnlyList<string>? ReportFields { get; init; }

    /// <summary>
    /// Report Status Value
    /// <para>
    /// Valid values:
    /// - COMPLETED
    /// - PENDING
    /// - QUEUED
    /// - RUNNING
    /// - ERROR
    /// - NO_DATA
    /// - RERUN
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportStatus")]
    public string? ReportStatus { get; init; }

    /// <summary>
    /// Report Start Time Value
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportStartTime")]
    public DateTimeOffset? ReportStartTime { get; init; }

    /// <summary>
    /// Report End Time Value
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportEndTime")]
    public DateTimeOffset? ReportEndTime { get; init; }

    /// <summary>
    /// Time Zone Value
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// List of filters to apply
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportFilters")]
    public IReadOnlyDictionary<string, object>? ReportFilters { get; init; }

    /// <summary>
    /// Report Preferences
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportPreferences")]
    public ReportPreferences? ReportPreferences { get; init; }

    /// <summary>
    /// Id for selected group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupId")]
    public string? GroupId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
