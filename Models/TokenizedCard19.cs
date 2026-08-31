using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TokenizedCard19
{
    /// <summary>
    /// This field contains token cryptogram information
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cryptogram")]
    [MaxLength(255)]
    public string? Cryptogram { get; init; }

    /// <summary>
    /// One of two possible meanings:
    /// <para>
    /// The two-digit month in which a token expires.
    /// The two-digit month in which a card expires.
    /// </para>
    /// <para>
    /// Format: <c>MM</c>
    /// </para>
    /// <para>
    /// Possible values: 01 through 12
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationMonth")]
    [MaxLength(2)]
    public string? ExpirationMonth { get; init; }

    /// <summary>
    /// One of two possible meanings:
    /// <para>
    /// The four-digit year in which a token expires.
    /// The four-digit year in which a card expires.
    /// </para>
    /// <para>
    /// Format: <c>YYYY</c>
    /// </para>
    /// <para>
    /// Possible values: 1900 through 3000
    /// </para>
    /// <para>
    /// Data type: Non-negative integer
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationYear")]
    [MaxLength(4)]
    public string? ExpirationYear { get; init; }

    /// <summary>
    /// Customer’s payment network token value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [MaxLength(20)]
    public string? Number { get; init; }

    /// <summary>
    /// Card Verification Number (CVN).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("securityCode")]
    [MaxLength(4)]
    public string? SecurityCode { get; init; }

    /// <summary>
    /// Three-digit value that indicates the card type. Mandatory if not present in a token.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>001</c>: Visa</description></item>
    ///   <item><description><c>002</c>: Mastercard, Eurocard, which is a European regional brand of Mastercard.</description></item>
    ///   <item><description><c>033</c>: Visa Electron</description></item>
    ///   <item><description><c>024</c>: Maestro</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(3)]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
