using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record CreateReportSubscriptionRequest
{
    /// <summary>
    /// Valid CyberSource organizationId
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationId")]
    [RegularExpression("[a-zA-Z0-9-_]+")]
    public string? OrganizationId { get; init; }

    /// <summary>
    /// Valid Report Definition Name
    /// </summary>
    [JsonPropertyName("reportDefinitionName")]
    [StringLength(80, MinimumLength = 1)]
    [RegularExpression("[a-zA-Z0-9-]+")]
    public required string ReportDefinitionName { get; init; }

    [JsonPropertyName("reportFields")]
    public required IReadOnlyList<string> ReportFields { get; init; }

    /// <summary>
    /// Valid values:
    /// - application/xml
    /// - text/csv
    /// </summary>
    [JsonPropertyName("reportMimeType")]
    public required string ReportMimeType { get; init; }

    /// <summary>
    /// 'The frequency for which subscription is created.'
    /// <b>NOTE: Do not document USER_DEFINED Frequency field in developer center</b>
    /// Valid Values:
    ///   - 'DAILY'
    ///   - 'WEEKLY'
    ///   - 'MONTHLY'
    ///   - 'USER_DEFINED'
    /// </summary>
    [JsonPropertyName("reportFrequency")]
    public required string ReportFrequency { get; init; }

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

    [JsonPropertyName("reportName")]
    [StringLength(128, MinimumLength = 1)]
    [RegularExpression("[a-zA-Z0-9-_ ]+")]
    public required string ReportName { get; init; }

    [JsonPropertyName("timezone")]
    public required string Timezone { get; init; }

    /// <summary>
    /// The hour at which the report generation should start. It should be in hhmm format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; init; }

    /// <summary>
    /// This is the start day if the frequency is WEEKLY or MONTHLY. The value varies from 1-7 for WEEKLY and 1-31 for MONTHLY. For WEEKLY 1 means Sunday and 7 means Saturday. By default the value is 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDay")]
    [Minimum(1)]
    [Maximum(31)]
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

    /// <summary>
    /// Valid GroupName
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupName")]
    [RegularExpression("[a-zA-Z0-9-_ ]+")]
    public string? GroupName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
