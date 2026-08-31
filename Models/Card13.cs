using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Card13
{
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
    /// Value that indicates the card type. Possible Values v2 : v1:
    ///   * 001 : visa
    ///   * 002 : mastercard - Eurocard—European regional brand of Mastercard
    ///   * 003 : american express
    ///   * 004 : discover
    ///   * 005 : diners club
    ///   * 006 : carte blanche
    ///   * 007 : jcb
    ///   * 008 : optima
    ///   * 011 : twinpay credit
    ///   * 012 : twinpay debit
    ///   * 013 : walmart
    ///   * 014 : enRoute
    ///   * 015 : lowes consumer
    ///   * 016 : home depot consumer
    ///   * 017 : mbna
    ///   * 018 : dicks sportswear
    ///   * 019 : casual corner
    ///   * 020 : sears
    ///   * 021 : jal
    ///   * 023 : disney
    ///   * 024 : maestro uk domestic
    ///   * 025 : sams club consumer
    ///   * 026 : sams club business
    ///   * 028 : bill me later
    ///   * 029 : bebe
    ///   * 030 : restoration hardware
    ///   * 031 : delta online — use this value only for Ingenico ePayments. For other processors, use 001 for all Visa card types.
    ///   * 032 : solo
    ///   * 033 : visa electron
    ///   * 034 : dankort
    ///   * 035 : laser
    ///   * 036 : carte bleue — formerly Cartes Bancaires
    ///   * 037 : carta si
    ///   * 038 : pinless debit
    ///   * 039 : encoded account
    ///   * 040 : uatp
    ///   * 041 : household
    ///   * 042 : maestro international
    ///   * 043 : ge money uk
    ///   * 044 : korean cards
    ///   * 045 : style
    ///   * 046 : jcrew
    ///   * 047 : payease china processing ewallet
    ///   * 048 : payease china processing bank transfer
    ///   * 049 : meijer private label
    ///   * 050 : hipercard — supported only by the Comercio Latino processor.
    ///   * 051 : aura — supported only by the Comercio Latino processor.
    ///   * 052 : redecard
    ///   * 054 : elo — supported only by the Comercio Latino processor.
    ///   * 055 : capital one private label
    ///   * 056 : synchrony private label
    ///   * 057 : costco private label
    ///   * 060 : mada
    ///   * 062 : china union pay
    ///   * 063 : falabella private label
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Number of times a Maestro (UK Domestic) card has been issued to the account holder. The card might or might not have an issue number. The number can consist of one or two digits, and the first digit might be a zero. When you include this value in your request, include exactly what is printed on the card. A value of 2 is different than a value of 02. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card.
    /// <para>
    /// <b>Note</b> The issue number is not required for Maestro (UK Domestic) transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issueNumber")]
    [MaxLength(2)]
    public string? IssueNumber { get; init; }

    /// <summary>
    /// Month of the start of the Maestro (UK Domestic) card validity period. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card. <c>Format: MM</c>.
    /// Possible Values: 01 through 12.
    /// <para>
    /// <b>Note</b> The start date is not required for Maestro (UK Domestic) transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startMonth")]
    [MaxLength(2)]
    public string? StartMonth { get; init; }

    /// <summary>
    /// Year of the start of the Maestro (UK Domestic) card validity period. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card. <c>Format: YYYY</c>.
    /// <para>
    /// <b>Note</b> The start date is not required for Maestro (UK Domestic) transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startYear")]
    [MaxLength(4)]
    public string? StartYear { get; init; }

    /// <summary>
    /// 'Payment Instrument was created / updated as part of a pinless debit transaction.'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useAs")]
    public string? UseAs { get; init; }

    /// <summary>
    /// Hash value representing the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hash")]
    [StringLength(34, MinimumLength = 32)]
    public string? Hash { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenizedInformation")]
    public TokenizedInformation? TokenizedInformation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
