using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CreateAdhocReportRequest
{
    /// <summary>
    /// Valid CyberSource Organization Id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationId")]
    [RegularExpression("[a-zA-Z0-9-_]+")]
    public string? OrganizationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportDefinitionName")]
    [StringLength(80, MinimumLength = 1)]
    [RegularExpression("[a-zA-Z0-9-]+")]
    public string? ReportDefinitionName { get; init; }

    /// <summary>
    /// List of fields which needs to get included in a report
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportFields")]
    public IReadOnlyList<string>? ReportFields { get; init; }

    /// <summary>
    /// 'Format of the report'
    ///
    /// Valid values:
    /// - application/xml
    /// - text/csv
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportMimeType")]
    public string? ReportMimeType { get; init; }

    /// <summary>
    /// Name of the report
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportName")]
    [StringLength(128, MinimumLength = 1)]
    [RegularExpression("[a-zA-Z0-9-_ ]+")]
    public string? ReportName { get; init; }

    /// <summary>
    /// Timezone of the report
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// Start time of the report
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportStartTime")]
    public DateTimeOffset? ReportStartTime { get; init; }

    /// <summary>
    /// End time of the report
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportEndTime")]
    public DateTimeOffset? ReportEndTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportFilters")]
    public ReportFilters? ReportFilters { get; init; }

    /// <summary>
    /// Report Preferences
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportPreferences")]
    public ReportPreferences? ReportPreferences { get; init; }

    /// <summary>
    /// Specifies the group name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupName")]
    [RegularExpression("[0-9]*")]
    public string? GroupName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
