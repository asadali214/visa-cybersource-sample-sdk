using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BuyerHistory
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerAccount")]
    public CustomerAccount? CustomerAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHistory")]
    public AccountHistory? AccountHistory { get; init; }

    /// <summary>
    /// Number of purchases with this cardholder account during the previous six months.
    /// Recommended for Discover ProtectBuy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountPurchases")]
    public int? AccountPurchases { get; init; }

    /// <summary>
    /// Number of add card attempts in the last 24 hours.
    /// Recommended for Discover ProtectBuy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addCardAttempts")]
    public int? AddCardAttempts { get; init; }

    /// <summary>
    /// Indicates whether the merchant experienced suspicious activity (including previous fraud) on the account.
    /// Recommended for Discover ProtectBuy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priorSuspiciousActivity")]
    public bool? PriorSuspiciousActivity { get; init; }

    /// <summary>
    /// This only applies for NEW_ACCOUNT and EXISTING_ACCOUNT in creationHistory. Possible values are:
    /// - PAYMENT_ACCOUNT_EXISTS
    /// - PAYMENT_ACCOUNT_ADDED_NOW
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccountHistory")]
    public string? PaymentAccountHistory { get; init; }

    /// <summary>
    /// Date applicable only for PAYMENT_ACCOUNT_EXISTS in paymentAccountHistory
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccountDate")]
    public int? PaymentAccountDate { get; init; }

    /// <summary>
    /// Number of transaction (successful or abandoned) for this cardholder account within the last 24 hours.
    /// Recommended for Discover ProtectBuy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionCountDay")]
    public int? TransactionCountDay { get; init; }

    /// <summary>
    /// Number of transaction (successful or abandoned) for this cardholder account within the last year.
    /// Recommended for Discover ProtectBuy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionCountYear")]
    public int? TransactionCountYear { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
