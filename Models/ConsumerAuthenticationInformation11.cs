using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ConsumerAuthenticationInformation11
{
    /// <summary>
    /// Raw electronic commerce indicator (ECI).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eciRaw")]
    [MaxLength(2)]
    public string? EciRaw { get; init; }

    /// <summary>
    /// Cardholder authentication verification value (CAVV).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cavv")]
    [MaxLength(40)]
    public string? Cavv { get; init; }

    /// <summary>
    /// Transaction identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("xid")]
    [MaxLength(40)]
    public string? Xid { get; init; }

    /// <summary>
    /// Payer auth Transaction identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionId")]
    public string? TransactionId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("strongAuthentication")]
    public StrongAuthentication5? StrongAuthentication { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
