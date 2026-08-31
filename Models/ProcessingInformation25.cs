using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation25
{
    /// <summary>
    /// The instruction to process an order.
    /// - default value: 'NO_INSTRUCTION'
    /// - 'ORDER_SAVED_EXPLICITLY'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingInstruction")]
    [MaxLength(36)]
    public string? ProcessingInstruction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizationOptions")]
    public AuthorizationOptions4? AuthorizationOptions { get; init; }

    /// <summary>
    /// Array of actions (one or more) to be included in the order to invoke bundled services along with order.
    /// Possible values:
    /// - <c>AP_ORDER</c>: Use this when Alternative Payment Order service is requested.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    /// <summary>
    /// Indicates if the transaction is flagged as high risk.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("highRiskTransactionFlag")]
    public string? HighRiskTransactionFlag { get; init; }

    /// <summary>
    /// Indicates if the transaction is a retry.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionRetry")]
    public string? TransactionRetry { get; init; }

    /// <summary>
    /// The number of transactions in the last one hour.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastOneHrTransactionCount")]
    public string? LastOneHrTransactionCount { get; init; }

    /// <summary>
    /// The number of transactions in the last one day.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastOneDayTransactionCount")]
    public string? LastOneDayTransactionCount { get; init; }

    /// <summary>
    /// The number of transactions in the last three months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastThreeMonthsTxnCount")]
    public string? LastThreeMonthsTxnCount { get; init; }

    /// <summary>
    /// The total number of transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalTransactionCount")]
    public string? TotalTransactionCount { get; init; }

    /// <summary>
    /// Indicates if PIN verification is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinVerification")]
    public string? PinVerification { get; init; }

    /// <summary>
    /// Indicates if face ID verification is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("faceIdVerification")]
    public string? FaceIdVerification { get; init; }

    /// <summary>
    /// Indicates if the user passed verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userPassedVerification")]
    public string? UserPassedVerification { get; init; }

    /// <summary>
    /// The IP address of the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; init; }

    /// <summary>
    /// The date of the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDate")]
    public string? TransactionDate { get; init; }

    /// <summary>
    /// Indicates if the transaction involves tangible goods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tangible")]
    public string? Tangible { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
