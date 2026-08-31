using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation69
{
    /// <summary>
    /// Bin Source File Identifier.
    /// Possible values:
    /// - itmx
    /// - rupay
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("binSource")]
    public string? BinSource { get; init; }

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
    /// Type of digital payment solution for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentSolution")]
    [MaxLength(50)]
    public string? PaymentSolution { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizationOptions")]
    public AuthorizationOptions5? AuthorizationOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankTransferOptions")]
    public BankTransferOptions23? BankTransferOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureOptions")]
    public CaptureOptions3? CaptureOptions { get; init; }

    /// <summary>
    /// Reference number for the transaction.
    /// Depending on how your Cybersource account is configured, this value could either be provided in the API request or generated by CyberSource.
    /// The actual value used in the request to the processor is provided back to you by Cybersource in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reconciliationId")]
    [MaxLength(60)]
    public string? ReconciliationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("japanPaymentOptions")]
    public JapanPaymentOptions3? JapanPaymentOptions { get; init; }

    /// <summary>
    /// Enter 1 for routing and account number validation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validationLevel")]
    public int? ValidationLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
