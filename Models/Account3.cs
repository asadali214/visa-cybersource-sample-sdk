using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Account3
{
    /// <summary>
    /// Account type.
    /// <para>
    /// Possible values:
    ///  - <b>C</b>: Checking.
    ///  - <b>G</b>: General ledger. This value is supported only on Wells Fargo ACH.
    ///  - <b>S</b>: Savings (U.S. dollars only).
    ///  - <b>X</b>: Corporate checking (U.S. dollars only).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(1)]
    public string? Type { get; init; }

    /// <summary>
    /// Account number.
    /// <para>
    /// When processing encoded account numbers, use this field for the encoded account number.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [MaxLength(30)]
    public string? Number { get; init; }

    /// <summary>
    /// Identifier for the bank that provided the customer’s encoded account number.
    /// <para>
    /// To obtain the bank identifier, contact your processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encoderId")]
    [MaxLength(3)]
    public string? EncoderId { get; init; }

    /// <summary>
    /// Check number.
    /// <para>
    /// Chase Paymentech Solutions - Optional.
    /// CyberSource ACH Service - Not used.
    /// RBS WorldPay Atlanta - Optional on debits. Required on credits.
    /// TeleCheck - Strongly recommended on debit requests. Optional on credits.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkNumber")]
    [MaxLength(8)]
    public string? CheckNumber { get; init; }

    /// <summary>
    /// Image reference number associated with the check. You cannot include any special characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkImageReferenceNumber")]
    [MaxLength(32)]
    public string? CheckImageReferenceNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
