using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation70
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
    /// Required for AFT and OCT transactions.
    /// <para>
    /// Given below is a list of all the BAI values available. However, the processors may support only few specific BAI values.
    /// </para>
    /// <list type="bullet">
    ///   <item><description>AA : Account-to-account</description></item>
    ///   <item><description>BB : Supplier Payments</description></item>
    ///   <item><description>BI : Bank-Initiated P2P Money Transfer</description></item>
    ///   <item><description>BP : Non-Card Bill Pay/Bill Pay</description></item>
    ///   <item><description>CD : Cash Deposit</description></item>
    ///   <item><description>CP : Credit card Bill Payment</description></item>
    ///   <item><description>FD : Funds disbursement</description></item>
    ///   <item><description>FT : Funds transfer</description></item>
    ///   <item><description>GD : Government Disbursement</description></item>
    ///   <item><description>GP : Gambling payout (non-online gambling)</description></item>
    ///   <item><description>LO : Loyalty credits and rebates</description></item>
    ///   <item><description>MD : Merchant Settlement</description></item>
    ///   <item><description>OG : Online Gambling Payout</description></item>
    ///   <item><description>PD : Payroll and pension disbursement</description></item>
    ///   <item><description>PP : Person-to-Person or Peer-to-Peer</description></item>
    ///   <item><description>TU : Top up, prepaid load</description></item>
    ///   <item><description>WT : Digital wallet</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessApplicationId")]
    public string? BusinessApplicationId { get; init; }

    /// <summary>
    /// Type of transaction. Some payment card companies use this information when determining discount rates.
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required payer authentication transactions; otherwise, optional.
    /// <b>Credit</b>
    /// Required for standalone credits on Chase Paymentech solutions; otherwise, optional.
    /// </para>
    /// <para>
    /// The list of valid values in this field depends on your processor.
    /// </para>
    /// <para>
    /// #### Ingenico ePayments
    /// When you omit this field for Ingenico ePayments, the processor uses the default transaction type they have on file for you instead of the default value
    /// </para>
    /// <para>
    /// #### Card Present
    /// You must set this field to <c>retail</c>. This field is required for a card-present transaction. Note that this should ONLY be
    /// used when the cardholder and card are present at the time of the transaction.
    /// For all keyed transactions originated from a POS terminal where the cardholder and card are not present, commerceIndicator
    /// should be submitted as “moto"
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commerceIndicator")]
    [MaxLength(20)]
    public string? CommerceIndicator { get; init; }

    /// <summary>
    /// Type of transaction. Some payment card companies use this information when determining discount rates.
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required payer authentication transactions; otherwise, optional.
    /// <b>Credit</b>
    /// Required for standalone credits on Chase Paymentech solutions; otherwise, optional.
    /// </para>
    /// <para>
    /// The list of valid values in this field depends on your processor.
    /// </para>
    /// <para>
    /// #### Ingenico ePayments
    /// When you omit this field for Ingenico ePayments, the processor uses the default transaction type they have on file for you
    /// instead of the default value
    /// </para>
    /// <para>
    /// #### Card Present
    /// You must set this field to <c>retail</c>. This field is required for a card-present transaction. Note that this should ONLY be
    /// used when the cardholder and card are present at the time of the transaction.
    /// For all keyed transactions originated from a POS terminal where the cardholder and card are not present, commerceIndicator
    /// should be submitted as <c>moto</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commerceIndicatorLabel")]
    [MaxLength(20)]
    public string? CommerceIndicatorLabel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
