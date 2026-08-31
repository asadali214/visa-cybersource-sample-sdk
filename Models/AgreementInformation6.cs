using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models.Enums;

namespace CyberSourceMergedSpec.Models;

public record AgreementInformation6
{
    /// <summary>
    /// Identifier for the mandate.
    /// #### SEPA/BACS
    /// Required for mandates services
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(50)]
    public string? Id { get; init; }

    /// <summary>
    /// Date the mandate has been signed.  Format YYYYMMdd
    /// #### SEPA/BACS
    /// Required for Import Mandate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateSigned")]
    [MaxLength(8)]
    public string? DateSigned { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
