using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains program-specific indicators for transaction processing.
/// </summary>
public record ProgramIndicators
{
    /// <summary>
    /// Indicator for when a Quick Payment transaction. A Quick Payment Service (QPS) Transaction is a magnetic stripe-based or contact chip-based face-to-face Mastercard POS transaction that occurs at a Peruvian merchant in an eligible merchant category and for an amount equal or less to the CVM limit.
    /// <para>
    /// This field is supported for Mastercard transactions in Peru.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>true</c>: This is a Quick Payment Service transaction
    /// - <c>false</c>: This is not a Quick Payment Service transaction
    /// </para>
    /// <para>
    /// Default: null
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quickPayment")]
    public bool? QuickPayment { get; init; }

    /// <summary>
    /// Indicator that the transaction was made via QR Payment.
    /// <para>
    /// This field is supported for Mastercard QR e-commerce payment programs in Peru.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>true</c>: Transaction was initiated via QR code
    /// - <c>false</c>: Transaction was not initiated via QR code
    /// </para>
    /// <para>
    /// Default: null
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qrInitiated")]
    public bool? QrInitiated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
