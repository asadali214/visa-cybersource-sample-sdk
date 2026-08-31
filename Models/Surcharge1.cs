using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Surcharge1
{
    /// <summary>
    /// The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking. The issuer can provide information about the surcharge amount to the customer.
    /// <para>
    /// If the amount is positive, then it is a debit for the customer.
    /// If the amount is negative, then it is a credit for the customer.
    /// </para>
    /// <para>
    /// <b>NOTE</b>: This field is supported only for CyberSource through VisaNet (CtV) for Payouts. For CtV, the maximum string length is 8.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Surcharge amount that you are charging the customer for this transaction. If you include a surcharge amount
    /// in the request, you must also include the surcharge amount in the value for <c>orderInformation.amountDetails.totalAmount</c>.
    /// </para>
    /// <para>
    /// Optional field for transactions that use PIN debit credit or PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    [MaxLength(15)]
    public string? Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
