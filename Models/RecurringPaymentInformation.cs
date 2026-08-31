using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// This object contains recurring payment information.
/// </summary>
public record RecurringPaymentInformation
{
    /// <summary>
    /// The date after which no further recurring authorizations should be performed. Format: <c>YYYY-MM-DD</c>
    /// <b>Note</b> This field is required for recurring transactions.
    /// </summary>
    [JsonPropertyName("endDate")]
    [MaxLength(10)]
    public required string EndDate { get; init; }

    /// <summary>
    /// Integer value indicating the minimum number of days between recurring authorizations. A frequency
    /// of monthly is indicated by the value 28. Multiple of 28 days will be used to indicate months.
    /// <para>
    /// Example: 6 months = 168
    /// </para>
    /// <para>
    /// Example values accepted (31 days):
    /// - 31
    /// - 031
    /// - 0031
    /// </para>
    /// <para>
    /// <b>Note</b> This field is required for recurring transactions.
    /// </para>
    /// </summary>
    [JsonPropertyName("frequency")]
    public required int Frequency { get; init; }

    /// <summary>
    /// Total number of payments for the duration of the recurring subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfPayments")]
    public int? NumberOfPayments { get; init; }

    /// <summary>
    /// Date of original purchase. Required for recurring transactions.
    /// Format: <c>YYYY-MM-DDTHH:MM:SSZ</c>
    /// <b>Note</b>: If this field is empty, the current date is used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalPurchaseDate")]
    [MaxLength(17)]
    public string? OriginalPurchaseDate { get; init; }

    /// <summary>
    /// This field is mandatory for Cartes Bancaires recurring transactions on Credit Mutuel-CIC.
    /// This field records recurring sequence, e.g. 1st for initial,  2 for subsequent, 3 etc
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sequenceNumber")]
    public int? SequenceNumber { get; init; }

    /// <summary>
    /// This contains the type of recurring payment.
    /// Valid Values :
    /// 1 - Registration/First transaction
    /// 2 - Subsequent transaction
    /// 3 - Modification
    /// 4 - Cancellation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(1)]
    public string? Type { get; init; }

    /// <summary>
    /// This value indicates how often a recurring payment occurs.
    /// Valid Values :
    /// • 01 (Daily)
    /// • 02 (Twice weekly)
    /// • 03 (Weekly)
    /// • 04 (Ten days)
    /// • 05 (Fortnightly)
    /// • 06 (Monthly)
    /// • 07 (Every two months)
    /// • 08 (Trimester)
    /// • 09 (Quarterly)
    /// • 10 (Twice yearly)
    /// • 11 (Annually)
    /// • 12 (Unscheduled)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occurrence")]
    [MaxLength(2)]
    public string? Occurrence { get; init; }

    /// <summary>
    /// This tag will contain a value that indicates whether or not the recurring payment transaction has been validated.
    /// Valid values :
    /// 0- Not validated
    /// 1- Validated
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validationIndicator")]
    [MaxLength(1)]
    public string? ValidationIndicator { get; init; }

    /// <summary>
    /// Indicates recurring amount type agreed by the cardholder
    /// Valid Values :
    /// 1- Fixed amount recurring payment
    /// 2- Recurring payment with maximum amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountType")]
    [MaxLength(1)]
    public string? AmountType { get; init; }

    /// <summary>
    /// This API field will contain the maximum amount agreed to by the cardholder. The currency of this amount
    /// will be specified in Field 49—Currency Code,Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maximumAmount")]
    [MaxLength(12)]
    public string? MaximumAmount { get; init; }

    /// <summary>
    /// This will contain a unique reference number for the recurring payment transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceNumber")]
    [MaxLength(35)]
    public string? ReferenceNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
