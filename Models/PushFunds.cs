using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PushFunds
{
    /// <summary>
    /// This field indicates if cross-border money transfer OCTs (fast push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("moneyTransferFastFundsCrossBorder")]
    [MaxLength(1)]
    public string? MoneyTransferFastFundsCrossBorder { get; init; }

    /// <summary>
    /// This field indicates if domestic money transfer OCTs (fast push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("moneyTransferFastFundsDomestic")]
    [MaxLength(1)]
    public string? MoneyTransferFastFundsDomestic { get; init; }

    /// <summary>
    /// This field indicates if cross-border money transfer OCTs (push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("moneyTransferCrossBorder")]
    [MaxLength(1)]
    public string? MoneyTransferCrossBorder { get; init; }

    /// <summary>
    /// This field indicates if domestic money transfer OCTs (push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("moneyTransferDomestic")]
    [MaxLength(1)]
    public string? MoneyTransferDomestic { get; init; }

    /// <summary>
    /// This field indicates if cross-border non-money transfer OCTs (fast push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonMoneyTransferFastFundsCrossBorder")]
    [MaxLength(1)]
    public string? NonMoneyTransferFastFundsCrossBorder { get; init; }

    /// <summary>
    /// This field indicates if domestic non-money transfer OCTs (fast push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonMoneyTransferFastFundsDomestic")]
    [MaxLength(1)]
    public string? NonMoneyTransferFastFundsDomestic { get; init; }

    /// <summary>
    /// This field indicates if cross-border non-money transfer OCTs (push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonMoneyTransferCrossBorder")]
    [MaxLength(1)]
    public string? NonMoneyTransferCrossBorder { get; init; }

    /// <summary>
    /// This field indicates if domestic non-money transfer OCTs (push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonMoneyTransferDomestic")]
    [MaxLength(1)]
    public string? NonMoneyTransferDomestic { get; init; }

    /// <summary>
    /// This field indicates if cross-border gambling OCTs (fast push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onlineGamblingFastFundsCrossBorder")]
    [MaxLength(1)]
    public string? OnlineGamblingFastFundsCrossBorder { get; init; }

    /// <summary>
    /// This field indicates if domestic gambling OCTs (fast push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onlineGamblingFastFundsDomestic")]
    [MaxLength(1)]
    public string? OnlineGamblingFastFundsDomestic { get; init; }

    /// <summary>
    /// This field indicates if cross-border gambling OCTs (push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onlineGamblingCrossBorder")]
    [MaxLength(1)]
    public string? OnlineGamblingCrossBorder { get; init; }

    /// <summary>
    /// This field indicates if domestic gambling OCTs (push funds) are allowed.
    /// Possible values:
    ///   - <c>Y</c>
    ///   - <c>N</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onlineGamblingDomestic")]
    [MaxLength(1)]
    public string? OnlineGamblingDomestic { get; init; }

    /// <summary>
    /// This field indicates if domestic OCTs (push funds) are allowed.
    /// Possible values:
    ///   - <c>true</c>
    ///   - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domesticParticipant")]
    [MaxLength(5)]
    public string? DomesticParticipant { get; init; }

    /// <summary>
    /// This field indicates if cross-border OCTs (push funds) are allowed.
    /// Possible values:
    ///   - <c>true</c>
    ///   - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("crossBorderParticipant")]
    [MaxLength(5)]
    public string? CrossBorderParticipant { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
