using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Details for marking the transaction as either positive or negative.
/// </summary>
public record MarkingDetails
{
    /// <summary>
    /// Notes or details that explain the reasons for adding the transaction to either the positive or negative list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    [MaxLength(120)]
    public string? Notes { get; init; }

    /// <summary>
    /// Reason for adding the transaction to the negative list. This field can contain one of the following values:
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
    /// Name of the customer’s record entered in the list.
    /// For the positive list, it is required if `action_
    /// code<c>=</c>add_positive<c>. If absent from the request, </c>ics_risk_update` creates the value for this field by concatenating the customer’s first and last names.
    /// For the negative and the review lists, <c>record_name</c>, <c>customer_firstname</c>, and <c>customer_lastname</c> are optional.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recordName")]
    [MaxLength(255)]
    public string? RecordName { get; init; }

    /// <summary>
    /// Indicates whether to add to or remove a customer’s identity from the negative or positive list. This field can
    /// contain one of the following values:
    /// - add: Add information to the list.
    /// - convert: moves the data.
    /// - delete: deletes the data from the list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public string? Action { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
