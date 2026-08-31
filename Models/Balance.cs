using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Balance
{
    /// <summary>
    /// Type of account.
    /// <para>
    /// This value is returned only if you request a balance inquiry.
    /// </para>
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>00</c>: Not applicable or not specified</description></item>
    ///   <item><description><c>10</c>: Savings account</description></item>
    ///   <item><description><c>20</c>: Checking account</description></item>
    ///   <item><description><c>30</c>: Credit card account</description></item>
    ///   <item><description><c>40</c>: Universal account</description></item>
    /// </list>
    /// <para>
    /// Balance Account Types returned on EBT Debit card transactions:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>96</c>: Cash Benefits Account (PIN Debit Gateway EBT only)</description></item>
    ///   <item><description><c>98</c>: Food Stamp Account (PIN Debit Gateway EBT only)</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    [MaxLength(2)]
    public string? AccountType { get; init; }

    /// <summary>
    /// Remaining balance on the account. If the processor returns the sign, positive or negative, this sign is prefixed
    /// to the amount value as (+/-).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    [MaxLength(13)]
    public string? Amount { get; init; }

    /// <summary>
    /// Type of amount. This value is returned only if you request a balance inquiry. The issuer determines the value
    /// that is returned.
    /// <para>
    /// Possible values for deposit accounts:
    /// </para>
    /// <para>
    ///  - <c>01</c>: Current ledger (posted) balance.
    ///  - <c>02</c>: Current available balance, which is typically the ledger balance minus outstanding authorizations. Some
    ///  depository institutions also include pending deposits and the credit or overdraft line associated with the account.
    /// </para>
    /// <para>
    /// Possible values for credit card accounts:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>01</c>: Credit amount remaining for customer (open to buy).</description></item>
    ///   <item><description><c>02</c>: Credit limit.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountType")]
    [MaxLength(2)]
    public string? AmountType { get; init; }

    /// <summary>
    /// Currency of the remaining balance on the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MaxLength(3)]
    public string? Currency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
