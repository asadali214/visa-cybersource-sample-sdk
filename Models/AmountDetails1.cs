using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails1
{
    /// <summary>
    /// Total amount that has been spent on healthcare in a transaction.
    /// Valid Values for <b>Visa</b>:
    /// - <c>healthcare</c> - Total Amount Healthcare
    /// - <c>healthcare-transit</c> - Amount Transit
    /// - <c>vision</c> - Amount Vision/Optical
    /// - <c>prescription</c> - Amount Prescription/RX
    /// - <c>clinic</c> - Amount Clinic/Other Qualified Medical
    /// - <c>dental</c> - Amount Dental
    /// <para>
    ///
    /// <c>Note:</c> -  Prescription, Clinic and dental amounts must be preceded with the total healthcare amount and cannot occur individually.  Vision and Transit must be sent individually and cannot be combined with total healthcare amount or any other amounts. Total Healthcare amount can be sent individually.
    /// </para>
    /// <para>
    /// Valid Values for <b>MasterCard</b>:
    /// - <c>prescription</c> - Amount Prescription/RX
    /// - <c>eligible-total</c> - Total Amount Healthcare
    /// </para>
    /// <para>
    ///
    /// <c>Note:</c> -  Prescription must be preceded with the total healthcare amount and cannot occur individually. Total Healthcare amount can be sent individually.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountType")]
    [MaxLength(35)]
    public string? AmountType { get; init; }

    /// <summary>
    /// Total Amount that has been spent on the corresponding amountType. This is 13 byte field including sign.
    /// If the amount is positive, then it is a debit for the customer.
    /// If the amount is negative, then it is a credit for the customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    [MaxLength(13)]
    public string? Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
