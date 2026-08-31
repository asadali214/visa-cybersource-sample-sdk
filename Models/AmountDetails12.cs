using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails12
{
    /// <summary>
    /// This field contains the purchase cashback amount expressed in the acquirer transaction currency.
    /// Use this field only for clearing with your acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashbackAmount")]
    [MaxLength(12)]
    public string? CashbackAmount { get; init; }

    /// <summary>
    /// This is a multicurrency field. It contains the transaction amount (field 4), converted to the Currency used to bill the cardholder’s account.
    /// This field is returned for OCT transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementAmount")]
    [MaxLength(12)]
    public string? SettlementAmount { get; init; }

    /// <summary>
    /// This is a multicurrency-only field. It contains a 3-digit numeric code that identifies the currency used by the issuer to bill the cardholder's account.
    /// This field is returned for OCT transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementCurrency")]
    [MaxLength(3)]
    public string? SettlementCurrency { get; init; }

    /// <summary>
    /// Exchange rate returned by the DCC service. Includes a decimal point and a maximum of 4 decimal places.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeRate")]
    [MaxLength(13)]
    public string? ExchangeRate { get; init; }

    /// <summary>
    /// Set this field to the converted amount that was returned by the DCC provider.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foreignAmount")]
    [MaxLength(15)]
    public string? ForeignAmount { get; init; }

    /// <summary>
    /// Set this field to the converted amount that was returned by the DCC provider.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foreignCurrency")]
    [MaxLength(5)]
    public string? ForeignCurrency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
