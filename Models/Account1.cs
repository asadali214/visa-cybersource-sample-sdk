using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Account1
{
    /// <summary>
    /// The account number of the entity funding the transaction. The value for this field can be a payment card account number or bank account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [MaxLength(50)]
    public string? Number { get; init; }

    /// <summary>
    /// Identifies the sender’s account type.
    /// This field is applicable for AFT transactions.
    /// <para>
    /// Valid values are:
    ///   - <c>00</c> for Other
    ///   - <c>01</c> for Routing Transit Number (RTN) + Bank Account Number (BAN)
    ///   - <c>02</c> for International Bank Account Number (IBAN)
    ///   - <c>03</c> for Card Account
    ///   - <c>04</c> for Email
    ///   - <c>05</c> for Phone Number
    ///   - <c>06</c> for Bank Account Number (BAN) + Bank Identification Code (BIC), also known as a SWIFT code
    ///   - <c>07</c> for Wallet ID
    ///   - <c>08</c> for Social Network ID
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(2)]
    public string? Type { get; init; }

    /// <summary>
    /// Source of funds.
    /// Possible Values:
    ///  - <c>01</c>: Credit.
    ///  - <c>02</c>: Debit.
    ///  - <c>03</c>: Prepaid.
    ///  - <c>04</c>: Deposit Account.
    ///  - <c>05</c>: Mobile Money Account.
    ///  - <c>06</c>: Cash.
    ///  - <c>07</c>: Other.
    ///  - <c>V5</c>: Debits / deposit access other than those linked to the cardholders’ scheme.
    ///  - <c>V6</c>: Credit accounts other than those linked to the cardholder’s scheme.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundsSource")]
    [MaxLength(2)]
    public string? FundsSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
