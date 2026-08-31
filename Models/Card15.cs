using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Card15
{
    /// <summary>
    /// The latest customer’s payment card number associated to the network token.
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
    /// The type of card (Card Network).
    /// Possible Values:
    /// - 001: visa
    /// - 002: mastercard
    /// - 003: american express
    /// - 007: jcb
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The customer’s latest payment card number suffix.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suffix")]
    public string? Suffix { get; init; }

    /// <summary>
    /// Card issuance date. XML date format: YYYY-MM-DD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issueDate")]
    public DateTimeOffset? IssueDate { get; init; }

    /// <summary>
    /// Card activation date. XML date format: YYYY-MM-DD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activationDate")]
    public DateTimeOffset? ActivationDate { get; init; }

    /// <summary>
    /// Indicates if the expiration date is printed on the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationPrinted")]
    public bool? ExpirationPrinted { get; init; }

    /// <summary>
    /// Indicates if the Card Verification Number is printed on the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("securityCodePrinted")]
    public bool? SecurityCodePrinted { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termsAndConditions")]
    public TermsAndConditions? TermsAndConditions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
