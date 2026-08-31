using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record InstallmentInformation4
{
    /// <summary>
    /// Applicable only for SI. Required in case the authentication is initiated for SI registration.
    /// Valid Values:
    /// - <c>SMS</c>
    /// - <c>EMAIL</c>
    /// - <c>BOTH</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alertPreference")]
    [MaxLength(5)]
    public string? AlertPreference { get; init; }

    /// <summary>
    /// Date of the first installment payment. Format: YYMMDD. When you do not include this field, CyberSource sends a string of six zeros (000000) to the processor.
    /// <para>
    /// This field is supported only for Crediario installment payments in Brazil on CyberSource through VisaNet.
    /// </para>
    /// <para>
    /// The value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCR9
    /// - Position: 42-47
    /// - Field: Date of First Installment
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstInstallmentDate")]
    [MaxLength(6)]
    public string? FirstInstallmentDate { get; init; }

    /// <summary>
    /// Standing Instruction/Installment identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identifier")]
    public string? Identifier { get; init; }

    /// <summary>
    /// End date of the SI transactions.
    /// Cannot be later than card expiry date. Ideally this can be set to expiry date.
    /// Required in case the authentication is initiated for SI registration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastInstallmentDate")]
    [MaxLength(8)]
    public string? LastInstallmentDate { get; init; }

    /// <summary>
    /// Maximum Amount for which SI can be initiated.
    /// Required in case the authentication is initiated for SI registration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAmount")]
    [MaxLength(12)]
    public string? MaxAmount { get; init; }

    /// <summary>
    /// Minimum Amount for which SI can be initiated.
    /// Required in case the authentication is initiated for SI registration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minAmount")]
    [MaxLength(12)]
    public string? MinAmount { get; init; }

    /// <summary>
    /// Payment plan for the installments.
    /// This field is supported only for installment payments on Visa Platform Connect, RuPay and SPG-KSA seamless flow.
    /// <para>
    /// Possible values for a standing-instruction (SI) merchant-initiated transaction (MIT) with Diners Club or Mastercard in India or with an India-issued card:
    /// - 1: SI with a fixed amount.
    /// - 2: SI with a maximum amount.
    /// - 3: Other kind of SI.
    /// </para>
    /// <para>
    /// Possible values for a type of Installment transaction for on-soil transaction in Kingdom of Saudi Arabia
    /// - 1: Registration or first transaction.
    /// - 2: Subsequent transaction.
    /// </para>
    /// <para>
    /// Possible values for other kinds of installment payments:
    /// - 0 (default): Regular installment. This value is not allowed for airline transactions.
    /// - 1: Installment payment with down payment.
    /// - 2: Installment payment without down payment. This value is supported only for airline transactions.
    /// - 3: Installment payment; down payment and boarding fee will follow. This value is supported only for airline transactions.
    /// - 4: Down payment only; regular installment payment will follow.
    /// - 5: Boarding fee only. This value is supported only for airline transactions.
    /// - 6: SI de-registration on RuPay for the payer authentication seamless flow.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentType")]
    [MaxLength(1)]
    public string? PaymentType { get; init; }

    /// <summary>
    /// Preferred date for initiating the SI transaction every month.
    /// This field need not be sent in case the SI has to be initiated as and when required, e.g., topping up the wallet, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preferredDay")]
    [MaxLength(2)]
    public string? PreferredDay { get; init; }

    /// <summary>
    /// Installment number when making payments in installments. Used along with <c>totalCount</c> to track which payment is being processed.
    /// <para>
    /// For example, the second of 5 payments would be passed to CyberSource as <c>sequence</c> = 2 and <c>totalCount</c> = 5.
    /// </para>
    /// <para>
    /// #### Chase Paymentech Solutions and FDC Compass
    /// This field is optional because this value is required in the merchant descriptors.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// When you do not include this field in a request for a Crediario installment payment, CyberSource sends a value of 0 to the processor.
    /// </para>
    /// <para>
    /// For Crediario installment payments, the value for this field corresponds to the following data in the TC 33 capture file*:
    /// - Record: CP01 TCR9
    /// - Position: 38-40
    /// - Field: Installment Payment Number
    /// </para>
    /// <list type="bullet">
    ///   <item><description>The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sequence")]
    [Maximum(999)]
    public int? Sequence { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
