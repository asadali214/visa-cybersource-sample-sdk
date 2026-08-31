using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RecurringOptions
{
    /// <summary>
    /// Flag that indicates whether this is a payment towards an existing contractual loan.
    /// <para>
    /// Possible values:
    /// - <c>true</c>: Loan payment
    /// - <c>false</c>: (default) Not a loan payment
    /// </para>
    /// </summary>
    [JsonPropertyName("loanPayment")]
    public bool? LoanPayment { get; init; } = false;

    /// <summary>
    /// Flag that indicates whether this transaction is the first in a series of recurring payments.
    /// <para>
    /// This field is supported only for <b>Atos</b>, <b>FDC Nashville Global</b>, and <b>OmniPay Direct</b>.
    /// </para>
    /// <para>
    /// Possible values:
    ///  - <c>true</c> Indicates this is the first payment in a series of recurring payments
    ///  - <c>false</c> (default) Indicates this is not the first payment in a series of recurring payments.
    /// </para>
    /// </summary>
    [JsonPropertyName("firstRecurringPayment")]
    public bool? FirstRecurringPayment { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
