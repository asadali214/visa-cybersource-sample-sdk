using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantInitiatedTransaction
{
    /// <summary>
    /// Reason for the transaction. Possible values:
    /// - <c>1</c>: Resubmission
    /// - <c>2</c>: Delayed charge
    /// - <c>3</c>: Reauthorization for split shipment
    /// - <c>4</c>: No show
    /// - <c>5</c>: Account top up or Incremental authorization
    /// - <c>6</c>: Partial shipment
    /// - <c>7</c>: Fixed amount recurring (subscription)
    /// - <c>8</c>: Variable amount recurring (standing order)
    /// - <c>9</c>: Installment
    /// - <c>10</c>: Unscheduled Card-on-File
    /// <para>
    /// This field should be used to identify the kind of merchant-initiated transaction.
    /// Values 7 and 8 should be used on customer-initiated transactions that are establishing the relationship for Mastercard subscriptions or standing orders.
    /// </para>
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
    /// in the reply message for the original customer-initiated payment in the series.
    /// <para>
    /// If the current payment request includes a token instead of an account number, the following time limits apply for the value of this field:
    /// - For a <b>resubmission</b>, the transaction ID must be less than 14 days old.
    /// - For a <b>delayed charge</b> or <b>reauthorization</b>, the transaction ID must be less than 30 days old.
    /// </para>
    /// <para>
    /// <b>NOTE</b>: The value for this field does not correspond to any data in the TC 33 capture file5.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("previousTransactionId")]
    [MaxLength(15)]
    public string? PreviousTransactionId { get; init; }

    /// <summary>
    /// Amount of the original authorization in the series. This field is only needed for merchant-initiated transactions with Discover or Diners cards.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalAuthorizedAmount")]
    [MaxLength(61)]
    public string? OriginalAuthorizedAmount { get; init; }

    /// <summary>
    /// An API to carry the agreement ID generated for recurring and unscheduled Card on file transaction. the merchant generates this per card holder or per payment agreement and shares the generated unique ID in the subsequent transactions. This can contain foreign/arabic character set also. Cybersource forwards this value to the Saudi Payment processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("agreementId")]
    [MaxLength(140)]
    public string? AgreementId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
