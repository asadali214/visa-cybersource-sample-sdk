using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Card127
{
    /// <summary>
    /// Three-digit value that indicates the card type. Mandatory if not present in a token.
    /// <para>
    /// Possible values:
    /// - <c>001</c>: Visa
    /// - <c>002</c>: Mastercard, Eurocard, which is a European regional brand of Mastercard.
    /// - <c>033</c>: Visa Electron
    /// - <c>024</c>: Maestro
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [RegularExpression("^(\\s{0,3}|.{3})$")]
    public string? Type { get; init; }

    /// <summary>
    /// 3-digit value that indicates the cardCvv2Value. Values can be 0-9.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("securityCode")]
    [RegularExpression("^(\\s{0,3}|.{3})$")]
    public string? SecurityCode { get; init; }

    /// <summary>
    /// The customer’s payment card number, also known as the Primary Account Number (PAN).
    /// <para>
    /// Conditional: this field is required if not using tokens.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [RegularExpression("^(\\s{0,19}|.{13,19})$")]
    public string? Number { get; init; }

    /// <summary>
    /// Two-digit month in which the payment card expires.
    /// <para>
    /// Format: <c>MM</c>.
    /// </para>
    /// <para>
    /// Valid values: <c>01</c> through <c>12</c>. Leading 0 is required.
    /// </para>
    /// <para>
    ///
    /// Conditional: this field is required if using neither a Customer nor Payment Instrument token.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationMonth")]
    [MaxLength(2)]
    public string? ExpirationMonth { get; init; }

    /// <summary>
    /// Four-digit year in which the payment card expires.
    /// <para>
    /// Format: <c>YYYY</c>.
    /// </para>
    /// <para>
    /// Conditional: this field is required if using neither a Customer nor Payment Instrument token.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationYear")]
    [MaxLength(4)]
    public string? ExpirationYear { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
