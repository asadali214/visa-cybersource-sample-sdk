using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record CaptureOptions
{
    /// <summary>
    /// Capture number when requesting multiple partial captures for one authorization.
    /// Used along with <c>totalCaptureCount</c> to track which capture is being processed.
    /// <para>
    /// For example, the second of five captures would be passed to CyberSource as:
    ///   - <c>captureSequenceNumber_ = 2</c>, and
    ///   - <c>totalCaptureCount = 5</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureSequenceNumber")]
    [Minimum(1)]
    [Maximum(99)]
    public int? CaptureSequenceNumber { get; init; }

    /// <summary>
    /// Total number of captures when requesting multiple partial captures for one payment.
    /// Used along with <c>captureSequenceNumber</c> field to track which capture is being processed.
    /// <para>
    /// For example, the second of five captures would be passed to CyberSource as:
    ///   - <c>captureSequenceNumber = 2</c>, and
    ///   - <c>totalCaptureCount = 5</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalCaptureCount")]
    [Minimum(1)]
    [Maximum(99)]
    public int? TotalCaptureCount { get; init; }

    /// <summary>
    /// Date on which you want the capture to occur. This field is supported only for CyberSource through VisaNet.
    /// Format: <c>MMDD</c>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateToCapture")]
    [MaxLength(4)]
    public string? DateToCapture { get; init; }

    /// <summary>
    /// Indicates whether to release the authorization hold on the remaining funds.
    /// Possible Values:
    /// - <c>true</c>
    /// - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isFinal")]
    [MaxLength(5)]
    public string? IsFinal { get; init; }

    /// <summary>
    /// An informational note about this settlement. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    [MaxLength(255)]
    public string? Notes { get; init; }

    /// <summary>
    /// Used for authbill request when capture field equals true
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reconciliationId")]
    [MaxLength(60)]
    public string? ReconciliationId { get; init; }

    /// <summary>
    /// Used by Nike merchant to send 12 digit order number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reconciliationIdAlternate")]
    [MaxLength(12)]
    public string? ReconciliationIdAlternate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
