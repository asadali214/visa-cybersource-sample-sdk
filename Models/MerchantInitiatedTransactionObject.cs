using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantInitiatedTransactionObject
{
    /// <summary>
    /// Reason for the merchant-initiated transaction or incremental authorization. Possible values:
    /// - <c>1</c>: Resubmission
    /// - <c>2</c>: Delayed charge
    /// - <c>3</c>: Reauthorization for split shipment
    /// - <c>4</c>: No show
    /// - <c>5</c>: Account top up
    /// This field is required only for the five kinds of transactions in the preceding list.
    /// This field is supported only for merchant-initiated transactions and incremental authorizations.
    /// <para>
    /// #### CyberSource through VisaNet
    /// The value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP01 TCR0
    /// - Position: 160-163
    /// - Field: Message Reason Code
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    [MaxLength(1)]
    public string? Reason { get; init; }

    /// <summary>
    /// Network transaction identifier that was returned in the payment response field _processorInformation.transactionID_
    /// in the reply message for either the original merchant-initiated payment in the series or the previous
    /// merchant-initiated payment in the series.
    /// <para>
    /// If the current payment request includes a token instead of an account number, the following time limits apply for the value of this field:
    /// - For a <b>resubmission</b>, the transaction ID must be less than 14 days old.
    /// - For a <b>delayed charge</b> or <b>reauthorization</b>, the transaction ID must be less than 30 days old.
    /// </para>
    /// <para>
    /// <b>NOTE</b>: The value for this field does not correspond to any data in the TC 33 capture file5. This field is supported
    /// only for Visa transactions on CyberSource through VisaNet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("previousTransactionId")]
    [MaxLength(15)]
    public string? PreviousTransactionId { get; init; }

    /// <summary>
    /// Amount of the original authorization.
    /// <para>
    /// This field is supported only for Apple Pay, Google Pay, and Samsung Pay transactions with Discover on FDC Nashville Global and Chase Paymentech.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalAuthorizedAmount")]
    [MaxLength(61)]
    public string? OriginalAuthorizedAmount { get; init; }

    /// <summary>
    /// This field contains the predetermined agrement id with the merchant
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("agreementId")]
    public string? AgreementId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
