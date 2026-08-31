using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Routing
{
    /// <summary>
    /// PIN Debit Services:
    /// Contains the ID of the debit network to which the transaction was routed.
    /// <para>
    /// | Code | Network |
    /// | --- | --- |
    /// | 0000 | Priority Routing or Generic File Update |
    /// | 0002 | Visa programs, Private Label and non-Visa Authorization Gateway Services |
    /// | 0003 | Interlink |
    /// | 0004 | Plus |
    /// | 0008 | Star |
    /// | 0009 | Pulse|
    /// | 0010 | Star |
    /// | 0011 | Star |
    /// | 0012 | Star (primary network ID) |
    /// | 0013 | AFFN |
    /// | 0015 | Star |
    /// | 0016 | Maestro |
    /// | 0017 | Pulse (primary network ID) |
    /// | 0018 | NYCE (primary network ID) |
    /// | 0019 | Pulse |
    /// | 0020 | Accel |
    /// | 0023 | NETS |
    /// | 0024 | CU24 |
    /// | 0025 | Alaska Option |
    /// | 0027 | NYCE |
    /// | 0028 | Shazam |
    /// | 0029 | EBT POS |
    /// </para>
    /// <para>
    /// FDC Nashville Global authorization service:
    /// </para>
    /// <para>
    /// Indicates whether the transaction was routed to a credit network, a debit network, or the STAR signature debit
    /// network.
    /// - <c>C</c>: Credit network
    /// - <c>D</c>: Debit network (without signature)
    /// - <c>S</c>: STAR signature debit network
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network")]
    [MaxLength(4)]
    public string? Network { get; init; }

    /// <summary>
    /// Name of the network to which the transaction was routed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkName")]
    [MaxLength(10)]
    public string? NetworkName { get; init; }

    /// <summary>
    /// Indicates whether you need to obtain the cardholder's signature.
    /// <para>
    /// Possible values:
    /// - <c>Y</c>: You need to obtain the cardholder's signature.
    /// - <c>N</c>: You do not need to obtain the cardholder's signature.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerSignatureRequired")]
    [MaxLength(1)]
    public string? CustomerSignatureRequired { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
