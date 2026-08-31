using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Links223
{
    /// <summary>
    /// A GET link to the AFT
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("self")]
    public Self221? Self { get; init; }

    /// <summary>
    /// A POST link for a reversal
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reversal")]
    public Reversal6? Reversal { get; init; }

    /// <summary>
    /// A POST link for a refund
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public Refund1? Refund { get; init; }

    /// <summary>
    /// A GET link to the customer supplied in the AFT
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public Customer58? Customer { get; init; }

    /// <summary>
    /// A GET link to the payment instrument supplied in the AFT
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrument")]
    public PaymentInstrument24? PaymentInstrument { get; init; }

    /// <summary>
    /// A GET link to the instrument identifier used in the AFT
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instrumentIdentifier")]
    public InstrumentIdentifier35? InstrumentIdentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
