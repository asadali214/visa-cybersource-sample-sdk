using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation28
{
    /// <summary>
    /// Array of actions (one or more) to be included in the tokenize request.
    /// <para>
    /// Possible Values:
    ///  - <c>TOKEN_CREATE</c>: Use this when you want to create a token from the card/bank data in your tokenize request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    /// <summary>
    /// TMS tokens types you want to perform the action on.
    /// <para>
    /// Possible Values:
    /// - customer
    /// - paymentInstrument
    /// - instrumentIdentifier
    /// - shippingAddress
    /// - tokenizedCard
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionTokenTypes")]
    public IReadOnlyList<string>? ActionTokenTypes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
