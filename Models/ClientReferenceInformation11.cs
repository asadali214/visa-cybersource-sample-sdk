using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ClientReferenceInformation11
{
    /// <summary>
    /// Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each
    /// transaction so that you can perform meaningful searches for the transaction.
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required field.
    /// </para>
    /// <para>
    /// #### PIN Debit
    /// Requests for PIN debit reversals need to use the same merchant reference number that was used in the transaction that is being
    /// reversed.
    /// </para>
    /// <para>
    /// Required field for all PIN Debit requests (purchase, credit, and reversal).
    /// </para>
    /// <para>
    /// #### FDC Nashville Global
    /// Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(59)]
    public string? Code { get; init; }

    /// <summary>
    /// Date and time at your physical location.
    /// <para>
    /// Format: <c>YYYYMMDDhhmmss</c>, where YYYY = year, MM = month, DD = day, hh = hour, mm = minutes ss = seconds
    /// </para>
    /// <para>
    /// #### PIN Debit
    /// Optional field for PIN Debit purchase and credit requests.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("submitLocalDateTime")]
    [MaxLength(14)]
    public string? SubmitLocalDateTime { get; init; }

    /// <summary>
    /// Merchant ID that was used to create the subscription or customer profile for which the service was requested.
    /// <para>
    /// If your CyberSource account is enabled for Recurring Billing, this field is returned only if you are using
    /// subscription sharing and if your merchant ID is in the same merchant ID pool as the owner merchant ID.
    /// </para>
    /// <para>
    /// If your CyberSource account is enabled for Payment Tokenization, this field is returned only if you are using
    /// profile sharing and if your merchant ID is in the same merchant ID pool as the owner merchant ID.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerMerchantId")]
    public string? OwnerMerchantId { get; init; }

    /// <summary>
    /// A new ID which is created for refund
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnReconciliationId")]
    public string? ReturnReconciliationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
