using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Bank15
{
    /// <summary>
    /// Bank routing number. This is also called the transit number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routingNumber")]
    public string? RoutingNumber { get; init; }

    /// <summary>
    /// Code used to identify the branch of the customer’s bank.
    /// Required for some countries if you do not or are not
    /// allowed to provide the IBAN. Use this field only when
    /// scoring a direct debit transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("branchCode")]
    public string? BranchCode { get; init; }

    /// <summary>
    /// Bank’s SWIFT code. You can use this field only when scoring a direct debit transaction.
    /// Required only for crossborder transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swiftCode")]
    public string? SwiftCode { get; init; }

    /// <summary>
    /// Country-specific code used to identify the customer’s
    /// bank. Required for some countries if you do not or are not
    /// allowed to provide the IBAN instead. You can use this field
    /// only when scoring a direct debit transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankCode")]
    public string? BankCode { get; init; }

    /// <summary>
    /// International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    [MaxLength(50)]
    public string? Iban { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public Account18? Account { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mandate")]
    public Mandate1? Mandate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
