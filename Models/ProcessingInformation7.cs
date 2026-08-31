using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation7
{
    /// <summary>
    /// Array of actions (one or more) to be included in the payment to invoke bundled services along with payment status.
    /// <para>
    /// Possible values are one or more of follows:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>AP_REFUND</c>: Use this when Alternative Payment Refund service is requested.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    /// <summary>
    /// Type of digital payment solution for the transaction. Possible Values:
    /// <list type="bullet">
    ///   <item><description><c>visacheckout</c>: Visa Checkout. This value is required for Visa Checkout transactions. For details, see <c>payment_solution</c> field description in <see href="https://developer.cybersource.com/content/dam/docs/cybs/en-us/apifields/reference/all/rest/api-fields.pdf">Visa Checkout Using the REST API.</see></description></item>
    ///   <item><description><c>001</c>: Apple Pay.</description></item>
    ///   <item><description><c>004</c>: Cybersource In-App Solution.</description></item>
    ///   <item><description><c>005</c>: Masterpass. This value is required for Masterpass transactions on OmniPay Direct.</description></item>
    ///   <item><description><c>006</c>: Android Pay.</description></item>
    ///   <item><description><c>007</c>: Chase Pay.</description></item>
    ///   <item><description><c>008</c>: Samsung Pay.</description></item>
    ///   <item><description><c>012</c>: Google Pay.</description></item>
    ///   <item><description><c>013</c>: Cybersource P2PE Decryption</description></item>
    ///   <item><description><c>014</c>: Mastercard credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token.</description></item>
    ///   <item><description><c>015</c>: Visa credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token.</description></item>
    ///   <item><description><c>027</c>: Click to Pay.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentSolution")]
    [MaxLength(12)]
    public string? PaymentSolution { get; init; }

    /// <summary>
    /// Please check with Cybersource customer support to see if your merchant account is configured correctly so you
    /// can include this field in your request.
    /// * For Payouts: max length for FDCCompass is String (22).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reconciliationId")]
    [MaxLength(60)]
    public string? ReconciliationId { get; init; }

    /// <summary>
    /// Value that links the current authorization request to the original authorization request or previous declined Merchant Initiated Debt Recovery Transactions . Set this value
    /// to the ID that was returned in the reply message from the original authorization request or previous declined Merchant Initiated Debt Recovery Transactions.
    /// <para>
    /// This value is used for:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Partial authorizations</description></item>
    ///   <item><description>Split shipments</description></item>
    ///   <item><description>Merchant Initiated Debt Recovery Transactions for Visa Platform Connect and China Union Pay merchants</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("linkId")]
    [MaxLength(26)]
    public string? LinkId { get; init; }

    /// <summary>
    /// Attribute that lets you define custom grouping for your processor reports. This field is supported only for <b>Worldpay VAP</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportGroup")]
    [MaxLength(25)]
    public string? ReportGroup { get; init; }

    /// <summary>
    /// Identifier for the <b>Visa Checkout</b> order. Visa Checkout provides a unique order ID for every transaction in
    /// the Visa Checkout <b>callID</b> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaCheckoutId")]
    [MaxLength(48)]
    public string? VisaCheckoutId { get; init; }

    /// <summary>
    /// Set this field to 3 to indicate that the request includes Level III data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseLevel")]
    [MaxLength(1)]
    public string? PurchaseLevel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringOptions")]
    public RecurringOptions1? RecurringOptions { get; init; }

    /// <summary>
    /// Indicates that the transaction includes industry-specific data.
    /// <para>
    /// Possible Values:
    /// - <c>airline</c>
    /// - <c>restaurant</c>
    /// - <c>lodging</c>
    /// - <c>auto_rental</c>
    /// - <c>transit</c>
    /// - <c>healthcare_medical</c>
    /// - <c>healthcare_transit</c>
    /// - <c>transit</c>
    /// </para>
    /// <para>
    /// #### Card Present, Airlines and Auto Rental
    /// You must set this field to <c>airline</c> in order for airline data to be sent to the processor. For example, if this
    /// field is not set to <c>airline</c> or is not included in the request, no airline data is sent to the processor.
    /// </para>
    /// <para>
    /// You must set this field to <c>restaurant</c> in order for restaurant data to be sent to the processor. When this field
    /// is not set to <c>restaurant</c> or is not included in the request, no restaurant data is sent to the processor.
    /// </para>
    /// <para>
    /// You must set this field to <c>auto_rental</c> in order for auto rental data to be sent to the processor. For example, if this
    /// field is not set to <c>auto_rental</c> or is not included in the request, no auto rental data is sent to the processor.
    /// </para>
    /// <para>
    /// Restaurant data is supported only on CyberSource through VisaNet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industryDataType")]
    [MaxLength(20)]
    public string? IndustryDataType { get; init; }

    /// <summary>
    /// Identifier for the payment type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentType")]
    public string? PaymentType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refundOptions")]
    public RefundOptions? RefundOptions { get; init; }

    /// <summary>
    /// This field is used identify the type of payment transaction taking place. This field is applicable for MasterCard transactions only.
    /// Possible values:
    /// - 201- Mastercard Rebate
    /// - 202- rePower Load Value
    /// - 203- Gaming Re-pay
    /// - 204- General Person-to-Person
    /// - 205- General Transfer to Own Account
    /// - 206- Agent Cash Out
    /// - 207- Payment of Own Credit Card Bill
    /// - 208- Business Disbursement
    /// - 209- Government/Non-Profit Disbursement
    /// - 210- Rapid Merchant Settlement
    /// - 211- Cash in at ATM (Usage limited to specific countries)
    /// - 212- Cash in at Point of Sale (Usage limited to specific countries)
    /// - 213- General Business to Business Transfer
    /// - 214- Mastercard Merchant Presented QR
    /// - 215- Mastercard Merchant Presented QR Refund Payment
    /// - 216- Utility Payments (for Brazil domestic use only)
    /// - 217- Government Services (for Brazil domestic use only)
    /// - 218- Mobile phone top-ups (for Brazil domestic use only)
    /// - 219- Coupon booklet payments (for Brazil domestic use only)
    /// - 220- General Person-to-Person Transfer
    /// - 221- Person-to-Person Transfer to Card Account
    /// - 222- General Transfer to Own Account
    /// - 223- Agent Cash Out
    /// - 224- Payment of Own Credit Card Bill
    /// - 225- Business Disbursement
    /// - 226- Transfer to Own Staged Digital Wallet Account
    /// - 227- Transfer to Own Debit or Prepaid Account
    /// - 228- General Business-to-Business Transfer
    /// - 229- Installment-based repayment
    /// - 230- Mastercard ATM Cash Pick-Up Transaction
    /// - 231- Cryptocurrency
    /// - 232- High-risk Securities
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionTypeIndicator")]
    [MaxLength(3)]
    public string? TransactionTypeIndicator { get; init; }

    /// <summary>
    /// The override value of the Merchant Verification Value (MVV) received by various card brands. MVV refers to the value assigned by the card brand/network to identify participation in select merchant programs.
    /// <para>
    /// Sample value for Visa: <c>101010</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantVerificationValue")]
    [MaxLength(25)]
    public string? MerchantVerificationValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
