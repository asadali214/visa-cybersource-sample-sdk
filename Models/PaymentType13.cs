using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentType13
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public Method13? Method { get; init; }

    /// <summary>
    /// A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit.
    /// Possible values:
    /// - <c>EWALLET</c>
    /// - <c>directDebitSepa</c>
    /// - <c>directDebitBacs</c>
    /// #### SEPA/BACS
    /// Required for mandates services
    /// #### Paypal
    /// Required for billing agreements
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
