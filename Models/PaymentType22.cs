using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentType22
{
    /// <summary>
    /// A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit.
    /// Possible values:
    /// - <c>CARD</c> (use this for a PIN debit transaction)
    /// - <c>CHECK</c> (use this for all eCheck payment transactions - ECP Debit, ECP Follow-on Credit, ECP StandAlone Credit)
    /// - <c>bankTransfer</c> (use for Online Bank Transafer for methods such as P24, iDeal, Estonia Bank, KCP)
    /// - <c>localCard</c> (KCP Local card via Altpay)
    /// - <c>carrierBilling</c> (KCP Carrier Billing via Altpay)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Indicates the payment type used in this payment transaction. Example: credit card, check
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Indicates the payment method used in this payment transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public string? Method { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
