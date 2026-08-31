using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains card verification control flags for transaction-level verification settings.
/// </summary>
public record CardVerification
{
    /// <summary>
    /// Verification control flag to opt-in or opt-out of Address Verification Service (AVS) for a transaction.
    /// <para>
    /// Possible values:
    /// - <c>Y</c>: Enable AVS verification for this transaction
    /// - <c>N</c>: Disable AVS verification for this transaction
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional field for controlling AVS verification at the transaction level.
    /// </para>
    /// <para>
    /// #### API Ticket
    /// ACCAPI-2156
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkAVS")]
    [MaxLength(1)]
    public string? CheckAvs { get; init; }

    /// <summary>
    /// Verification control flag to opt-in or opt-out of Address Name Inquiry (ANI) for a transaction.
    /// <para>
    /// Possible values:
    /// - <c>Y</c>: Enable ANI verification for this transaction
    /// - <c>N</c>: Disable ANI verification for this transaction
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional field for controlling ANI verification at the transaction level.
    /// </para>
    /// <para>
    /// #### API Ticket
    /// ACCAPI-2156
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkANI")]
    [MaxLength(1)]
    public string? CheckAni { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
