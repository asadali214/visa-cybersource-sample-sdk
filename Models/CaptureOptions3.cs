using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record CaptureOptions3
{
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
