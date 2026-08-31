using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Account18
{
    /// <summary>
    /// Last four digits of the customer’s payment account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suffix")]
    public string? Suffix { get; init; }

    /// <summary>
    /// Bank Identification Number (BIN). This is the initial four to six numbers on a credit card account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prefix")]
    public string? Prefix { get; init; }

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
    /// Name used on the bank account. You can use this field only when scoring a direct debit transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Code used to validate the customer’s account number.
    /// Required for some countries if you do not or are not
    /// allowed to provide the IBAN instead. You may use this
    /// field only when scoring a direct debit transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkDigit")]
    public string? CheckDigit { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
