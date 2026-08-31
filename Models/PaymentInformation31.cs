using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains the payment data for this transaction.
/// </summary>
public record PaymentInformation31
{
    /// <summary>
    /// Use this for a non-tokenized payment card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card120? Card { get; init; }

    /// <summary>
    /// Use this object to submit a payment network token instead of card-based values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenizedCard")]
    public TokenizedCard14? TokenizedCard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank")]
    public Bank? Bank { get; init; }

    /// <summary>
    /// Method of payment used for the order. This field can contain one of the following values:
    ///   - <c>consumer</c> (default): Customer credit card
    ///   - <c>corporate</c>: Corporate credit card
    ///   - <c>debit</c>: Debit card, such as a Maestro (UK Domestic) card
    ///   - <c>cod</c>: Collect on delivery
    ///   - <c>check</c>: Electronic check
    ///   - <c>p2p</c>: Person-to-person payment
    ///   - <c>private1</c>: Private label credit card
    ///   - <c>other</c>: Other payment method
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    [MaxLength(10)]
    public string? Method { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
