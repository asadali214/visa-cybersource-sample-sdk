using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation3
{
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuer")]
    public Issuer? Issuer { get; init; }

    /// <summary>
    /// Array of actions (one or more) to be included in the reversal
    /// Possible value:
    /// - <c>AP_AUTH_REVERSAL</c>: Use this when you want to reverse an Alternative Payment Authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
