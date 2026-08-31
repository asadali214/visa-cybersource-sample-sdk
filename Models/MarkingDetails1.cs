using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Details for marking the transaction.
/// </summary>
public record MarkingDetails1
{
    /// <summary>
    /// Notes or details that explain the reasons for marking the transaction as suspect or otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    [MaxLength(120)]
    public string? Notes { get; init; }

    /// <summary>
    /// Reason for marking the transaction as suspect or otherwise. This field can contain one of the following values:
    /// - <c>fraud_chargeback:</c> You have received a fraud-related chargeback for the transaction.
    /// - <c>non_fraud_chargeback:</c> You have received a non-fraudulent chargeback for the transaction.
    /// - <c>suspected:</c> You believe that you will probably receive a chargeback for the transaction.
    /// - <c>creditback:</c> You issued a refund to the customer to avoid a chargeback for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    [MaxLength(25)]
    public string? Reason { get; init; }

    /// <summary>
    /// This field can contain one or more of the following values. When you specify more than one value, separate them with commas (,).
    /// - <c>account_key_hash</c>
    /// - <c>customer_account_id</c>
    /// - <c>customer_email</c>
    /// - <c>customer_ipaddress</c>
    /// - <c>customer_phone</c>
    /// - <c>device_fingerprint</c>
    /// - <c>ship_address</c>
    /// If no value is specified, <c>account_key_hash</c>, <c>customer_email</c>, and <c>ship_address</c> are used by default.
    /// Note <c>account_key_hash</c> adds the field that contains the card number (<c>customer_cc_number</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fieldsIncluded")]
    public IReadOnlyList<string>? FieldsIncluded { get; init; }

    /// <summary>
    /// This field can contain one of the following values:
    /// - add: Mark as Suspect.
    /// - clear: Clear Mark as Suspect.
    /// - hide: Remove from history.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public string? Action { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
