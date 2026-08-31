using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AuthorizationInformation
{
    /// <summary>
    /// The authorization code returned by the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("approvalCode")]
    [MaxLength(6)]
    public string? ApprovalCode { get; init; }

    /// <summary>
    /// Reply flag for the original transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasonCode")]
    [MaxLength(50)]
    public string? ReasonCode { get; init; }

    /// <summary>
    /// Flag indicating whether a full authorization reversal was successfully submitted.
    /// <para>
    /// Possible values:
    /// - Y: The authorization reversal was successfully submitted.
    /// - N: The authorization reversal was not successfully submitted. You must send a credit request for a refund.
    /// </para>
    /// <para>
    /// This field is supported only for <b>FDC Nashville Global</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reversalSubmitted")]
    [MaxLength(1)]
    public string? ReversalSubmitted { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
