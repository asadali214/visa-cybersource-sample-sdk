using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BankTransferOptions2
{
    /// <summary>
    /// Payment related information.
    /// <para>
    /// This information is included on the customer’s statement.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerMemo")]
    [MaxLength(80)]
    public string? CustomerMemo { get; init; }

    /// <summary>
    /// Specifies the authorization method for the transaction.
    /// <para>
    /// #### TeleCheck
    /// Accepts only the following values:
    /// - <c>ARC</c>: account receivable conversion
    /// - <c>CCD</c>: corporate cash disbursement
    /// - <c>POP</c>: point of purchase conversion
    /// - <c>PPD</c>: prearranged payment and deposit entry
    /// - <c>TEL</c>: telephone-initiated entry
    /// - <c>WEB</c>: internet-initiated entry
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secCode")]
    [MaxLength(3)]
    public string? SecCode { get; init; }

    /// <summary>
    /// City in which the terminal is located. If more than four alphanumeric characters are submitted, the transaction
    /// will be declined.
    /// <para>
    /// You cannot include any special characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalCity")]
    [MaxLength(4)]
    public string? TerminalCity { get; init; }

    /// <summary>
    /// State in which the terminal is located. If more than two alphanumeric characters are submitted, the transaction
    /// will be declined.
    /// <para>
    /// You cannot include any special characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalState")]
    [MaxLength(2)]
    public string? TerminalState { get; init; }

    /// <summary>
    /// Effective date for the transaction. The effective date must be within 45 days of the current day. If you do not
    /// include this value, CyberSource sets the effective date to the next business day.
    /// <para>
    /// Format: <c>MMDDYYYY</c>
    /// </para>
    /// <para>
    /// Supported only for the CyberSource ACH Service.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveDate")]
    [MaxLength(8)]
    public string? EffectiveDate { get; init; }

    /// <summary>
    /// Identifier for a partial payment or partial credit.
    /// <para>
    /// The value for each debit request or credit request must be unique within the scope of the order.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partialPaymentId")]
    [MaxLength(25)]
    public string? PartialPaymentId { get; init; }

    /// <summary>
    /// Method used for settlement.
    /// <para>
    /// Possible values:
    /// - <c>A</c>: Automated Clearing House (default for credits and for transactions using Canadian dollars)
    /// - <c>F</c>: Facsimile draft (U.S. dollars only)
    /// - <c>B</c>: Best possible (U.S. dollars only) (default if the field has not already been configured for your
    /// merchant ID)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementMethod")]
    [MaxLength(1)]
    public string? SettlementMethod { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
