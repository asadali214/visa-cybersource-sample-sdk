using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// The expirationMonth, expirationYear and securityCode is sent to the issuer as part of network token enrollment and is not stored under the Instrument Identifier.
/// </summary>
public record Card14
{
    /// <summary>
    /// The customer’s payment card number, also known as the Primary Account Number (PAN). You can also use this field
    /// for encoded account numbers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [StringLength(19, MinimumLength = 12)]
    public string? Number { get; init; }

    /// <summary>
    /// Two-digit month in which the payment card expires.
    /// <para>
    /// Format: <c>MM</c>.
    /// </para>
    /// <para>
    /// Possible Values: <c>01</c> through <c>12</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationMonth")]
    [MaxLength(2)]
    public string? ExpirationMonth { get; init; }

    /// <summary>
    /// Four-digit year in which the credit card expires.
    /// <para>
    /// Format: <c>YYYY</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationYear")]
    [MaxLength(4)]
    public string? ExpirationYear { get; init; }

    /// <summary>
    /// Card Verification Code.
    /// This value is sent to the issuer to support the approval of a network token provision.
    /// It is not persisted against the Instrument Identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("securityCode")]
    [MaxLength(4)]
    public string? SecurityCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
