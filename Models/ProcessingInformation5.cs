using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation5
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

    /// <summary>
    /// Set this field to 3 to indicate that the request includes Level III data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseLevel")]
    [MaxLength(1)]
    public string? PurchaseLevel { get; init; }

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
    /// Mastercard Digital Enablement Service (MDES) digital service indicators for force capture scenarios.
    /// <para>
    /// This field is used when the client is doing authorization with a different gateway and capture with CyberSource.
    /// </para>
    /// <para>
    /// This field is in ANS, EBCDIC format and flows in Field 34, DSID 04 Tag DF1F, mapped to Mastercard Data Element DE119, Sub-element 004.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Capture Request</b>
    /// Request field for force capture support when auth is done with a different gateway.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("digitalServiceIndicator")]
    [MaxLength(104)]
    public string? DigitalServiceIndicator { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuer")]
    public Issuer? Issuer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizationOptions")]
    public AuthorizationOptions3? AuthorizationOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureOptions")]
    public CaptureOptions2? CaptureOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loanOptions")]
    public LoanOptions? LoanOptions { get; init; }

    /// <summary>
    /// Flag that indicates if the transaction is pay by points transaction
    /// true: Transaction uses loyalty points
    /// false: Transaction does not use loyalty points
    /// Default: false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payByPointsIndicator")]
    public bool? PayByPointsIndicator { get; init; }

    /// <summary>
    /// Array of actions (one or more) to be included in the capture to invoke bundled services along with capture.
    /// <para>
    /// Possible values :
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>AP_CAPTURE</c>: Use this when Alternative Payment Capture service is requested.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("japanPaymentOptions")]
    public JapanPaymentOptions1? JapanPaymentOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
