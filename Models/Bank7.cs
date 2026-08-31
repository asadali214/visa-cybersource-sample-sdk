using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Bank7
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public Account9? Account { get; init; }

    /// <summary>
    /// International Bank Account Number (IBAN).
    /// #### SEPA
    /// Required for mandates services
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    [MaxLength(34)]
    public string? Iban { get; init; }

    /// <summary>
    /// Bank’s SWIFT code. You can use this field only when scoring a direct debit transaction.
    /// #### BACS
    /// Required for mandates services
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swiftCode")]
    [MaxLength(20)]
    public string? SwiftCode { get; init; }

    /// <summary>
    /// The scheme that sets the rules for the direct
    /// debit process. Possible values:
    ///   - SEPA
    ///   - BACS
    /// #### SEPA/BACS
    /// Required for mandates services
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheme")]
    [MaxLength(25)]
    public string? Scheme { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountAlias")]
    public AccountAlias1? AccountAlias { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
