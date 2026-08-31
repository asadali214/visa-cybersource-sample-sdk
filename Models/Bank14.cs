using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Customer's bank account details
/// </summary>
public record Bank14
{
    /// <summary>
    /// Customer's bank account number. You can use this field only when scoring a direct debit transaction. Use this field if you do not or are not allowed to provide the IBAN. Note Do not use the IBAN in this field. Use nly the
    /// traditional account number information. For the IBAN, use bank_iban.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNumber")]
    [MaxLength(30)]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// Country-specific code used to identify the customer’s bank. Required for some countries if you do not or are not allowed to provide the IBAN instead. You can use this field only when scoring a direct debit transaction. For specific requirements, see "Required Bank Account Information by Country,"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(15)]
    public string? Code { get; init; }

    /// <summary>
    /// Country where the bank is located. Use the two-character ISO codes. You can use this field only when scoring a direct debit transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

    /// <summary>
    /// International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction.
    /// For specific requirements, see "Required Bank Account Information by Country,"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    [MaxLength(30)]
    public string? Iban { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
