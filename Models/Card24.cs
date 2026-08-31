using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Card24
{
    /// <summary>
    /// The customer’s payment card number, also known as the Primary Account Number (PAN). You
    /// can also use this field for encoded account numbers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [StringLength(19, MinimumLength = 12)]
    public string? Number { get; init; }

    /// <summary>
    /// Two-digit month in which the payment card expires.
    /// Format: <c>MM</c>.
    /// Possible Values: <c>01</c> through <c>12</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationMonth")]
    [MaxLength(2)]
    public string? ExpirationMonth { get; init; }

    /// <summary>
    /// Four-digit year in which the credit card expires.
    /// Format: <c>YYYY</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationYear")]
    [MaxLength(4)]
    public string? ExpirationYear { get; init; }

    /// <summary>
    /// The type of card (Card Network).
    /// Possible Values:
    /// - 001: visa
    /// <b>Required when source is ISSUER.</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
