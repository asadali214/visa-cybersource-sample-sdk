using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Account16
{
    /// <summary>
    /// Source of funds. Possible values:
    /// <para>
    ///   Paymentech, CTV, FDC Compass:
    ///  - 01: Credit card
    ///  - 02: Debit card
    ///  - 03: Prepaid card
    /// </para>
    /// <para>
    ///   Paymentech, CTV -
    ///  - 04: Cash
    ///  - 05: Debit or deposit account that is not linked to a Visa card. Includes checking accounts, savings
    ///        accounts, and proprietary debit or ATM cards.
    ///  - 06: Credit account that is not linked to a Visa card. Includes credit cards and proprietary lines
    ///        of credit.
    /// </para>
    /// <para>
    ///   FDCCompass -
    ///   - 04: Deposit Account
    /// </para>
    /// <para>
    /// <b>Funds Disbursement</b>
    /// </para>
    /// <para>
    /// This value is most likely 05 to identify that the originator used a deposit account to fund the
    /// disbursement.
    /// </para>
    /// <para>
    /// <b>Credit Card Bill Payment</b>
    /// </para>
    /// <para>
    /// This value must be 02, 03, 04, or 05.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundsSource")]
    [StringLength(2, MinimumLength = 2)]
    public string? FundsSource { get; init; }

    /// <summary>
    /// The account number of the entity funding the transaction. It is the sender’s account number. It can
    /// be a debit/credit card account number or bank account number.
    /// <para>
    /// <b>Funds disbursements and OCT transactions</b>
    /// </para>
    /// <para>
    /// This field is optional.
    /// </para>
    /// <para>
    /// <b>All other transactions</b>
    /// </para>
    /// <para>
    /// This field is required when the sender funds the transaction with a financial instrument, for example
    /// debit card.
    /// Length:
    /// * FDCCompass (&lt;= 19)
    /// * Paymentech (&lt;= 16)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [MaxLength(34)]
    public string? Number { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
