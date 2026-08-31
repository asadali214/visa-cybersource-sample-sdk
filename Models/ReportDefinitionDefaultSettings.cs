using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ReportDefinitionDefaultSettings
{
    /// <summary>
    /// Report Format
    /// Valid values:
    ///   - application/xml
    ///   - text/csv
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportMimeType")]
    public string? ReportMimeType { get; init; }

    /// <summary>
    /// Report Frequency Value
    /// Valid Values:
    ///   - DAILY
    ///   - WEEKLY
    ///   - MONTHLY
    ///   - ADHOC
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportFrequency")]
    public string? ReportFrequency { get; init; }

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
    public string? StartTime { get; init; }

    /// <summary>
    /// Start Day
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDay")]
    public int? StartDay { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
