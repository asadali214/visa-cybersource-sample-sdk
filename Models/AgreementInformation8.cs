using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models.Enums;

namespace CyberSourceMergedSpec.Models;

public record AgreementInformation8
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eSignIndicator")]
    [MaxLength(1)]
    public string? ESignIndicator { get; init; }

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
    /// Date the agreement was revoked (YYYYMMDD)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateRevoked")]
    [MaxLength(8)]
    public string? DateRevoked { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
