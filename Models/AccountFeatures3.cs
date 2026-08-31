using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AccountFeatures3
{
    /// <summary>
    /// Remaining balance on the account.
    /// <para>
    /// Returned by authorization service.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Remaining balance on the prepaid card.
    /// </para>
    /// <para>
    /// Returned by PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAmount")]
    [MaxLength(12)]
    public string? BalanceAmount { get; init; }

    /// <summary>
    /// Remaining balance on the account.
    /// <para>
    /// Returned by authorization service.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Remaining balance on the prepaid card.
    /// </para>
    /// <para>
    /// Returned by PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("previousBalanceAmount")]
    [MaxLength(12)]
    public string? PreviousBalanceAmount { get; init; }

    /// <summary>
    /// Currency of the remaining balance on the account. For the possible values, see the <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes.</see>
    /// <para>
    /// Returned by authorization service.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Currency of the remaining balance on the prepaid card.
    /// </para>
    /// <para>
    /// Returned by PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MaxLength(5)]
    public string? Currency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
