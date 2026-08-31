using System;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Settlement
{
    /// <summary>
    /// An unique identification number assigned by CyberSource to identify the submitted request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }

    /// <summary>
    /// Transaction Type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionType")]
    public string? TransactionType { get; init; }

    /// <summary>
    /// Submission Date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("submissionTime")]
    public DateTimeOffset? SubmissionTime { get; init; }

    /// <summary>
    /// Amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public string? Amount { get; init; }

    /// <summary>
    /// Valid ISO 4217 ALPHA-3 currency code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencyCode")]
    public string? CurrencyCode { get; init; }

    /// <summary>
    /// payment method
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public string? PaymentMethod { get; init; }

    /// <summary>
    /// Solution Type (Wallet)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletType")]
    public string? WalletType { get; init; }

    /// <summary>
    /// Payment Type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentType")]
    public string? PaymentType { get; init; }

    /// <summary>
    /// Account Suffix
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountSuffix")]
    public string? AccountSuffix { get; init; }

    /// <summary>
    /// Cybersource Batch Time
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cybersourceBatchTime")]
    public DateTimeOffset? CybersourceBatchTime { get; init; }

    /// <summary>
    /// Cybersource Batch Id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cybersourceBatchId")]
    public string? CybersourceBatchId { get; init; }

    /// <summary>
    /// Card Type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardType")]
    public string? CardType { get; init; }

    /// <summary>
    /// Debit Network
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debitNetwork")]
    public string? DebitNetwork { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
