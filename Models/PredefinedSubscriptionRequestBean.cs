using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record PredefinedSubscriptionRequestBean
{
    /// <summary>
    /// Valid Report Definition Name
    /// </summary>
    [JsonPropertyName("reportDefinitionName")]
    [StringLength(80, MinimumLength = 1)]
    [RegularExpression("[a-zA-Z]+")]
    public required string ReportDefinitionName { get; init; }

    /// <summary>
    /// The subscription type for which report definition is required. Valid values are CLASSIC and STANDARD.
    /// Valid Values:
    ///   - CLASSIC
    ///   - STANDARD
    /// </summary>
    [JsonPropertyName("subscriptionType")]
    public required string SubscriptionType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportName")]
    [StringLength(128, MinimumLength = 1)]
    [RegularExpression("[a-zA-Z0-9-_ ]+")]
    public string? ReportName { get; init; }

    /// <summary>
    /// Report Format
    /// Valid Values:
    ///   - application/xml
    ///   - text/csv
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportMimeType")]
    public string? ReportMimeType { get; init; }

    /// <summary>
    /// 'The frequency for which subscription is created. For Standard we can have DAILY, WEEKLY and MONTHLY. But for Classic we will have only DAILY.'
    /// <b>NOTE: Do not document USER_DEFINED Frequency field in developer center</b>
    /// Valid Values:
    /// - 'DAILY'
    /// - 'WEEKLY'
    /// - 'MONTHLY'
    /// - 'USER_DEFINED'
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
    /// By Default the timezone for Standard subscription is PST. And for Classic subscription it will be GMT. If user provides any other time zone apart from PST for Standard subscription api should error out.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// The hour at which the report generation should start. It should be in hhmm format. By Default it will be 0000. The format is 24 hours format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startTime")]
    public string? StartTime { get; init; }

    /// <summary>
    /// This is the start day if the frequency is WEEKLY or MONTHLY. The value varies from 1-7 for WEEKLY and 1-31 for MONTHLY. For WEEKLY 1 means Sunday and 7 means Saturday. By default the value is 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDay")]
    [Minimum(1)]
    [Maximum(31)]
    public int? StartDay { get; init; }

    /// <summary>
    /// The status for subscription which is either created or updated. By default it is ACTIVE.
    /// Valid Values:
    ///   - ACTIVE
    ///   - INACTIVE
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionStatus")]
    public string? SubscriptionStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
