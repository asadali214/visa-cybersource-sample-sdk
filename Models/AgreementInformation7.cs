using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models.Enums;

namespace CyberSourceMergedSpec.Models;

public record AgreementInformation7
{
    /// <summary>
    /// Identifier for the mandate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(50)]
    public string? Id { get; init; }

    /// <summary>
    /// Date the mandate has been signed.  Format YYYYMMdd
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateSigned")]
    [MaxLength(8)]
    public string? DateSigned { get; init; }

    /// <summary>
    /// Date the mandate has been created.  Format YYYYMMdd
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateCreated")]
    [MaxLength(8)]
    public string? DateCreated { get; init; }

    /// <summary>
    /// Identifies the type of schedule as either recurring, one-off, split or usage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type1? Type { get; init; }

    /// <summary>
    /// Regularity with which the event occurs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequency")]
    public Frequency? Frequency { get; init; }

    /// <summary>
    /// Number of occurrences during the specified period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occurrencesPerPeriod")]
    public int? OccurrencesPerPeriod { get; init; }

    /// <summary>
    /// Start date of the schedule.  Format YYYYMMdd
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDate")]
    [MaxLength(8)]
    public string? StartDate { get; init; }

    /// <summary>
    /// End date of the schedule.  Format YYYYMMdd
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endDate")]
    [MaxLength(8)]
    public string? EndDate { get; init; }

    /// <summary>
    /// Base64 encoded html string
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encodedHtml")]
    public string? EncodedHtml { get; init; }

    /// <summary>
    /// Base64 encoded popup html string
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encodedHtmlPopup")]
    public string? EncodedHtmlPopup { get; init; }

    /// <summary>
    /// URL for redirecting the customer for creating
    /// the mandate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [MaxLength(2048)]
    public string? Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
