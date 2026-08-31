using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentType19
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public Method19? Method { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
