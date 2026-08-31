using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Subscription Details
/// </summary>
public record Subscription1
{
    /// <summary>
    /// Selected Organization Id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationId")]
    public string? OrganizationId { get; init; }

    /// <summary>
    /// Report Definition Id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportDefinitionId")]
    public string? ReportDefinitionId { get; init; }

    /// <summary>
    /// Report Definition Class
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportDefinitionName")]
    public string? ReportDefinitionName { get; init; }

    /// <summary>
    /// Report Format
    ///
    /// Valid values:
    /// - application/xml
    /// - text/csv
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportMimeType")]
    public string? ReportMimeType { get; init; }

    /// <summary>
    /// 'Report Frequency'
    /// <b>NOTE: Do not document USER_DEFINED Frequency field in developer center</b>
    /// <para>
    /// Valid values:
    /// - DAILY
    /// - WEEKLY
    /// - MONTHLY
    /// - USER_DEFINED
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportFrequency")]
    public string? ReportFrequency { get; init; }

    /// <summary>
    /// If the reportFrequency is User-defined, reportInterval should be in <b>ISO 8601 time format</b>
    /// Please refer the following link to know more about ISO 8601 format.<see href="https://en.wikipedia.org/wiki/ISO_8601#Durations">Rfc Time Format</see>
    /// <para>
    /// <b>Example time format for 2 hours and 30 Mins:</b>
    ///   - PT2H30M
    /// <b>NOTE: Do not document reportInterval field in developer center</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportInterval")]
    [RegularExpression("^PT((([1-9]|1[0-9]|2[0-3])H(([1-9]|[1-4][0-9]|5[0-9])M)?)|((([1-9]|1[0-9]|2[0-3])H)?([1-9]|[1-4][0-9]|5[0-9])M))$")]
    public string? ReportInterval { get; init; }

    /// <summary>
    /// Report Name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportName")]
    public string? ReportName { get; init; }

    /// <summary>
    /// Time Zone
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// Start Time
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startTime")]
    public DateTimeOffset? StartTime { get; init; }

    /// <summary>
    /// Start Day
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDay")]
    public int? StartDay { get; init; }

    /// <summary>
    /// List of all fields String values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportFields")]
    public IReadOnlyList<string>? ReportFields { get; init; }

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
    /// Id for the selected group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupId")]
    public string? GroupId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
