using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Bank2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public Account3? Account { get; init; }

    /// <summary>
    /// Bank routing number. This is also called the _transit number_.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routingNumber")]
    [MaxLength(9)]
    public string? RoutingNumber { get; init; }

    /// <summary>
    /// International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    [MaxLength(50)]
    public string? Iban { get; init; }

    /// <summary>
    /// Bank’s SWIFT code. You can use this field only when scoring a direct debit transaction.
    /// Required only for crossborder transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swiftCode")]
    public string? SwiftCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
