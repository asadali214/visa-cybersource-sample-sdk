using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Payout fields request parameters
/// </summary>
public record PayoutOptions
{
    /// <summary>
    /// If <c>true</c> then provide attributes related to fund transfer/payouts. If payout information not found then response will have standard account lookup.
    /// <para>
    /// Possible values:
    /// - true
    /// - false
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutInquiry")]
    public bool? PayoutInquiry { get; init; }

    /// <summary>
    /// The networks specified in this field must be a subset of the information provided during program enrollment
    ///
    /// Possible values:
    /// - 0020 : Accel/Exchange
    /// - 0024 : CU24
    /// - 0003 : Interlink
    /// - 0016 : Maestro
    /// - 0018 : NYCE
    /// - 0027 : NYCE
    /// - 0009 : Pulse
    /// - 0017 : Pulse
    /// - 0019 : Pulse
    /// - 0008 : Star
    /// - 0010 : Star
    /// - 0011 : Star
    /// - 0012 : Star
    /// - 0015 : Star
    /// - 0002 : Visa/PLUS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; init; }

    /// <summary>
    /// BIN under which the Funds Transfer application is registered. This must match the information provided during enrollment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirerBin")]
    public string? AcquirerBin { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
