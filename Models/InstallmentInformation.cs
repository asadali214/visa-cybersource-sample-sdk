using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record InstallmentInformation
{
    /// <summary>
    /// Amount for the current installment payment.
    /// <para>
    /// This field is supported only for CyberSource through VisaNet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    [MaxLength(13)]
    public string? Amount { get; init; }

    /// <summary>
    /// Frequency of the installment payments. When you do not include this field in a request for a
    /// Crediario installment payment, CyberSource sends a space character to the processor.
    /// <para>
    /// This field is supported only for CyberSource through VisaNet. Possible values:
    /// - <c>B</c>: Biweekly
    /// - <c>M</c>: Monthly
    /// - <c>W</c>: Weekly
    /// </para>
    /// <para>
    /// For Crediario installment payments, the value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP01 TCR9
    /// - Position: 41
    /// - Field: Installment Frequency
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequency")]
    [MaxLength(1)]
    public string? Frequency { get; init; }

    /// <summary>
    /// #### American Express Direct, Cielo, and CyberSource Latin American Processing
    /// Flag that indicates the type of funding for the installment plan associated with the payment.
    /// <para>
    /// Possible values:
    /// - <c>1</c>: Merchant-funded installment plan
    /// - <c>2</c>: Issuer-funded installment plan
    /// If you do not include this field in the request, CyberSource uses the value in your CyberSource account.
    /// </para>
    /// <para>
    /// To change the value in your CyberSource account, contact CyberSource Customer Service.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet and American Express
    /// Defined code that indicates the type of installment plan for this transaction.
    /// </para>
    /// <para>
    /// Contact American Express for:
    /// - Information about the kinds of installment plans that American Express provides
    /// - Values for this field
    /// </para>
    /// <para>
    /// For installment payments with American Express in Brazil, the value for this field corresponds to the following data in the TC 33 capture file*:
    /// - Record: CP07 TCR3
    /// - Position: 5-6
    /// - Field: Plan Type
    /// </para>
    /// <list type="bullet">
    ///   <item><description>The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies.</description></item>
    /// </list>
    /// <para>
    /// #### CyberSource through VisaNet with Visa or Mastercard
    /// Flag indicating the type of funding for the installment plan associated with the payment.
    /// Possible values:
    /// - 1 or 01: Merchant-funded installment plan
    /// - 2 or 02: Issuer-funded installment plan
    /// - 43: Crediario installment plan—only with Visa in Brazil
    /// </para>
    /// <para>
    /// For installment payments with Visa in Brazil, the value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP07 TCR1
    /// - Position: 5-6
    /// - Field: Installment Type
    /// </para>
    /// <para>
    /// For all other kinds of installment payments, the value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP01 TCR5
    /// - Position: 39-40
    /// - Field: Installment Plan Type (Issuer or Merchant)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("planType")]
    [MaxLength(1)]
    public string? PlanType { get; init; }

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

    /// <summary>
    /// Total amount of the loan that is being paid in installments. This field is supported only for CyberSource
    /// through VisaNet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalAmount")]
    [MaxLength(13)]
    public string? TotalAmount { get; init; }

    /// <summary>
    /// Total number of installments when making payments in installments.
    /// <para>
    /// #### Chase Paymentech Solutions and FDC Compass
    /// This field is optional because this value is required in the merchant descriptors.
    /// </para>
    /// <para>
    /// #### American Express Direct, Cielo, and Comercio Latino
    /// This value is the total number of installments you approved.
    /// </para>
    /// <para>
    /// #### CyberSource Latin American Processing in Brazil
    /// This value is the total number of installments that you approved. The default is 1.
    /// </para>
    /// <para>
    /// #### All Other Processors
    /// This value is used along with _sequence_ to track which payment is being processed.
    /// </para>
    /// <para>
    /// For example, the second of 5 payments would be passed to CyberSource as _sequence_ = 2 and _totalCount_ = 5.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// For Crediario installment payments, the value for this field corresponds to the following data in the TC 33 capture file*:
    /// - Record: CP01 TCR9
    /// - Position: 23-25
    /// - Field: Number of Installments
    /// </para>
    /// <para>
    /// For installment payments with American Express in Brazil, the value for this field corresponds to the following data in the TC 33 capture file*:
    /// - Record: CP07 TCR3
    /// - Position: 7-8
    /// - Field: Number of Installments
    /// </para>
    /// <para>
    /// For installment payments with Visa in Brazil, the value for this field corresponds to the following data in the TC 33 capture file*:
    /// - Record: CP07 TCR1
    /// - Position: 7-8
    /// - Field: Number of Installments
    /// </para>
    /// <para>
    /// For all other kinds of installment payments, the value for this field corresponds to the following data in the TC 33 capture file*:
    /// - Record: CP01 TCR5
    /// - Position: 20-22
    /// - Field: Installment Total Count
    /// </para>
    /// <para>
    /// <b>Note</b> The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalCount")]
    [Maximum(999)]
    public int? TotalCount { get; init; }

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
    /// Invoice information that you want to provide to the issuer. This value is similar to a tracking number and is
    /// the same for all installment payments for one purchase.
    /// <para>
    /// This field is supported only for installment payments with Mastercard on CyberSource through VisaNet in Brazil.
    /// </para>
    /// <para>
    /// The value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP07 TCR4
    /// - Position: 51-70
    /// - Field: Purchase Identification
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceData")]
    [MaxLength(20)]
    public string? InvoiceData { get; init; }

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
    /// Indicates whether the authorization request is a Crediario eligibility inquiry.
    /// <para>
    /// Set the value for this field to <c>Crediario</c>.
    /// </para>
    /// <para>
    /// This field is supported only for Crediario installment payments in Brazil on CyberSource through VisaNet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eligibilityInquiry")]
    [MaxLength(9)]
    public string? EligibilityInquiry { get; init; }

    /// <summary>
    /// Grace period requested by the customer before the first installment payment is due.
    /// <para>
    /// When you include this field in a request, you must also include the grace period duration type field.
    /// </para>
    /// <para>
    /// The value for this field corresponds to the following data in the TC 33 capture file3: Record: CP01 TCR5, Position: 100-101, Field: Mastercard Grace Period Details.
    /// </para>
    /// <para>
    /// This field is supported only for Mastercard installment payments in Brazil and Greece.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gracePeriodDuration")]
    public string? GracePeriodDuration { get; init; }

    /// <summary>
    /// Unit for the requested grace period duration.
    /// <para>
    /// Possible values:
    /// - <c>D</c>: Days
    /// - <c>W</c>: Weeks
    /// - <c>M</c>: Months
    /// </para>
    /// <para>
    /// The value for this field corresponds to the following data in the TC 33 capture file3: Record: CP01 TCR5, Position: 99, Field: Mastercard Grace Period Details
    /// </para>
    /// <para>
    /// This field is supported only for Mastercard installment payments in Brazil and Greece on CyberSource through VisaNet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gracePeriodDurationType")]
    [MaxLength(1)]
    public string? GracePeriodDurationType { get; init; }

    /// <summary>
    /// Amount of the first installment payment. The issuer provides this value when the first installment payment is successful.
    /// This field is supported for Mastercard installment payments on CyberSource through VisaNet in all countries except Brazil,Croatia, Georgia, and Greece.
    /// The value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCR5
    /// - Position: 23-34
    /// - Field: Amount of Each Installment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstInstallmentAmount")]
    [MaxLength(13)]
    public string? FirstInstallmentAmount { get; init; }

    /// <summary>
    /// Standing Instruction/Installment validation indicator.
    /// - '1': Prevalidated
    /// - '2': Not Validated
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validationIndicator")]
    public string? ValidationIndicator { get; init; }

    /// <summary>
    /// Standing Instruction/Installment identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identifier")]
    public string? Identifier { get; init; }

    /// <summary>
    /// Annual interest rate.
    /// <para>
    /// This field is returned only for two kinds of installment payments on Visa Platform Connect:
    /// - Crediario with Visa in Brazil: this field is included in the authorization response for the Crediario eligibility request when the issuer approves the customer's request for Crediario installment payments.
    /// - Mastercard in all countries except Brazil, Croatia, Georgia, and Greece.
    /// </para>
    /// <para>
    ///
    /// Example: A value of 1.0 specifies 1%.
    /// </para>
    /// <para>
    /// Example: A value of 4.0 specifies 4%.
    /// </para>
    /// <para>
    /// #### Brazil
    /// The value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCR9
    /// - Position: 151-157
    /// - Field: Annual Interest Rate
    /// </para>
    /// <para>
    ///
    /// #### Other Countries
    /// The value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCR5
    /// - Position: 58-62 SCMP API Fields| 216
    /// - Field: Mastercard Annual Percentage Rate
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annualInterestRate")]
    [MaxLength(7)]
    public string? AnnualInterestRate { get; init; }

    /// <summary>
    /// Indicates if the installment plan has interest.
    /// <para>
    /// Possible values:
    /// -Y - with interest
    /// -N - without interest
    /// -NULL - Do not send the field if no information available
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interestIndicator")]
    [MaxLength(1)]
    public string? InterestIndicator { get; init; }

    /// <summary>
    /// Indicates if an installment plan is a government sponsored or part of a government program.
    /// <para>
    /// Possible values:
    /// </para>
    /// <para>
    /// -true
    /// -false
    /// </para>
    /// <para>
    /// This field defaults to false when no value is provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isGovernmentPlan")]
    public bool? IsGovernmentPlan { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
