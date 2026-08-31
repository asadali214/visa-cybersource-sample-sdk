using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Reason for deleting the network token.
/// </summary>
public record Reason
{
    /// <summary>
    /// Reason code for deleting the network token.
    /// <para>
    /// Possible Values:
    ///   - FRAUD: Network token is being deleted due to fraud concerns.
    ///   - PAYMENT_METHOD_REMOVED: Network Token is being deleted because the payment method was removed.
    /// </para>
    /// <para>
    /// Default: PAYMENT_METHOD_REMOVED
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// Additional description providing context for the deletion reason.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(255)]
    public string? Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
