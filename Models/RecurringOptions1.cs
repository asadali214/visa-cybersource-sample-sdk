using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RecurringOptions1
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
