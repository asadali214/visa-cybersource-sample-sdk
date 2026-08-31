using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation
{
    /// <summary>
    /// Array of actions (one or more) to be included in the payment to invoke bundled services along with payment.
    /// <para>
    /// Possible values are one or more of follows:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>DECISION_SKIP</c>: Use this when you want to skip Decision Manager service(s).</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>TOKEN_CREATE</c>: Use this when you want to create a token from the card/bank data in your payment request.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>CONSUMER_AUTHENTICATION</c>: Use this when you want to check if a card is enrolled in Payer Authentication along with your payment request.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>VALIDATE_CONSUMER_AUTHENTICATION</c>: Use this after you acquire a Payer Authentication result that needs to be included for your payment request.</description></item>
    ///   <item><description><c>AP_INITIATE</c>: Use this when Alternative Payment Initiate service is requested.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>WATCHLIST_SCREENING</c> : Use this when you want to call Watchlist Screening service.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AP_SALE</c> : Use this when Alternative Payment Sale service is requested.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AP_AUTH</c> : Use this when Alternative Payment Authorize service is requested.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AP_REAUTH</c> : Use this when Alternative Payment Reauthorize service is requested.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    /// <summary>
    /// Indicates whether to use the customer’s escrow agreement.
    /// Possible values:
    /// - <c>true</c>: yes, use the customer’s escrow agreement.
    /// - <c>false</c>: no, do not use the customer’s escrow agreement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableEscrowOption")]
    public bool? EnableEscrowOption { get; init; }

    /// <summary>
    /// CyberSource tokens types you are performing a create on.
    /// If not supplied the default token type for the merchants token vault will be used.
    /// <para>
    /// Valid values:
    /// - customer
    /// - paymentInstrument
    /// - instrumentIdentifier
    /// - shippingAddress
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionTokenTypes")]
    public IReadOnlyList<string>? ActionTokenTypes { get; init; }

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
    /// Indicates whether to also include a capture  in the submitted authorization request or not.
    /// <para>
    /// Possible values:
    /// - <c>true</c>: Include a capture with an authorization request.
    /// - <c>false</c>: (default) Do not include a capture with an authorization request.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization and Capture</b>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonPropertyName("capture")]
    public bool? Capture { get; init; } = false;

    /// <summary>
    /// Value that identifies the processor/acquirer to use for the transaction. This value is supported only for
    /// <b>CyberSource through VisaNet</b>.
    /// <para>
    /// Contact CyberSource Customer Support to get the value for this field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processorId")]
    [MaxLength(3)]
    public string? ProcessorId { get; init; }

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
    /// Set this field to 3 to indicate that the request includes Level III data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseLevel")]
    [MaxLength(1)]
    public string? PurchaseLevel { get; init; }

    /// <summary>
    /// The time-out limit in seconds for the transaction. The time-out limit starts when the customer is directed to the merchant URL that is included in the sale service response. The maximum value is 99999 (about 27 hours). When the transaction times out, the payment system changes the status to abandoned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionTimeout")]
    [Maximum(99999)]
    public int? TransactionTimeout { get; init; }

    /// <summary>
    /// Set to the value of the requestID field returned in the order service response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("intentsId")]
    [MaxLength(26)]
    public string? IntentsId { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizationOptions")]
    public ProcessingInfoAuthorizationOptions? AuthorizationOptions { get; init; }

    /// <summary>
    /// Contains card verification control flags for transaction-level verification settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardVerification")]
    public CardVerification? CardVerification { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureOptions")]
    public CaptureOptions? CaptureOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringOptions")]
    public RecurringOptions? RecurringOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankTransferOptions")]
    public BankTransferOptions? BankTransferOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseOptions")]
    public PurchaseOptions? PurchaseOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("electronicBenefitsTransfer")]
    public ElectronicBenefitsTransfer? ElectronicBenefitsTransfer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loanOptions")]
    public LoanOptions? LoanOptions { get; init; }

    /// <summary>
    /// This field carries the wallet type in authorization requests and credit requests. Possible value are:
    /// - <c>101</c>: Masterpass remote payment. The customer created the wallet by manually interacting with a customer-controlled device such as a computer, tablet, or phone. This value is supported only for Masterpass transactions on Chase Paymentech Solutions and CyberSource through VisaNet.
    /// - <c>102</c>: Masterpass remote near field communication (NFC) payment. The customer created the wallet by tapping a PayPass card or customer-controlled device at a contactless card reader. This value is supported only for card-present Masterpass transactions on CyberSource through VisaNet.
    /// - <c>103</c>: Masterpass Apple Pay payment. The payment was made with a combination of Masterpass and Apple Pay. This value is supported only for Masterpass Apple Pay transactions on CyberSource through VisaNet.
    /// - <c>216</c>: Masterpass Google Pay payment. The payment was made with a combination of Masterpass and Google Pay. This value is supported only for Masterpass Google Pay transactions on CyberSource through VisaNet.
    /// - <c>217</c>: Masterpass Samsung Pay payment. The payment was made with a combination of Masterpass and Samsung Pay. This value is supported only for Masterpass Samsung Pay transactions on CyberSource through VisaNet.
    /// - <c>SDW</c>: Staged digital wallet. An issuer or operator created the wallet. This value is supported only for Masterpass transactions on Chase Paymentech Solutions.
    /// - <c>VCIND</c>: Visa Checkout payment. This value is supported only on CyberSource through VisaNet, FDC Compass, FDC Nashville Global, FDI Australia, and TSYS Acquiring Solutions. See Getting Started with Visa Checkout. For Visa Checkout transactions, the way CyberSource processes the value for this field depends on the processor. See the Visa Checkout section below.
    /// For all other values, this field is a passthrough; therefore, CyberSource does not verify the value or modify it in any way before sending it to the processor.
    /// Masterpass (101, 102, 103, 216, and 217): The Masterpass platform generates the wallet type value and passes it to you along with the customer’s checkout information.
    /// <para>
    /// Visa Checkout:
    /// This field is optional for Visa Checkout authorizations on FDI Australia. For all other processors, this field is required for Visa Checkout authorizations.
    /// For Visa Checkout transactions on the following processors, CyberSource sends the value that the processor expects for this field:FDC Compass,FDC Nashville Global,FDI Australia,TSYS Acquiring
    /// Solutions For all other processors, this field is a passthrough; therefore, CyberSource does not verify the value or modify it in any way before sending it to the processor.
    /// For incremental authorizations, this field is supported only for Mastercard and the supported values are 101 and 102.
    /// Payment card companies can introduce new values without notice. Your order management system should be able to process new values without problems.
    /// </para>
    /// <para>
    /// CyberSource through VisaNet
    /// When the value for this field is 101, 102, 103, 216, or 217, it corresponds to the following data in the TC 33 capture file5: Record: CP01 TCR6, Position: 88-90,  Field: Mastercard Wallet Identifier.
    /// When the value for this field is VCIND, it corresponds to the following data in the TC 33 capture file5: Record: CP01 TCR8, Position: 72-76, Field: Agent Unique ID.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletType")]
    [MaxLength(5)]
    public string? WalletType { get; init; }

    /// <summary>
    /// Supplementary domestic transaction information provided by the acquirer for National Net Settlement Service (NNSS) transactions. NNSS is a settlement service that Visa provides.
    /// For transactions on CyberSource through VisaNet in countries that subscribe to NNSS:
    /// VisaNet clears transactions; VisaNet transfers funds to the acquirer after deducting processing fees and interchange fees.
    /// VisaNet settles transactions in the local pricing currency through a local financial institution.
    /// This field is supported only on CyberSource through VisaNet for domestic data in Colombia
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationalNetDomesticData")]
    [MaxLength(123)]
    public string? NationalNetDomesticData { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("japanPaymentOptions")]
    public JapanPaymentOptions? JapanPaymentOptions { get; init; }

    /// <summary>
    /// Type of payment initiated from a cardholder's mobile device. Possible values:
    /// - <c>1</c> :  Consumer-initiated remote purchase, face-to-face
    /// - <c>2</c> :  Consumer-initiated remote purchase, e-commerce
    /// - <c>3</c> :  Consumer-initiated remote purchase, mail order / telephone order
    /// - <c>4</c> :  Consumer-initiated bill pay
    /// - <c>5</c> :  Consumer-initiated top up
    /// - <c>6</c> :  Consumer-initiated cash out
    /// - <c>7</c> :  ATM triggered or agent-initiated cash out
    /// - <c>8</c> :  Merchant-initiated remote purchase, face-to-face
    /// - <c>9</c> :  Merchant-initiated remote purchase, e-commerce
    /// <para>
    /// This field is supported only for Mastercard transactions on CyberSource through VisaNet.
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// <para>
    /// <b>Note</b> On CyberSource through VisaNet, the value for this field corresponds to the following data in the
    /// TC 33 capture file:
    /// - Record: CP01 TCR6
    /// - Position: 94
    /// - Field: Mastercard Mobile Remote Payment Program Indicator
    /// </para>
    /// <para>
    /// The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource.
    /// CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the
    /// merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment networks.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobileRemotePaymentType")]
    [MaxLength(1)]
    public string? MobileRemotePaymentType { get; init; }

    /// <summary>
    /// A private national-use field submitted by acquirers and issuers in South Africa for South Africa-domestic (intra-country) authorizations and financial requests.
    /// Values for this field are 00 through 99.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendedCreditTotalCount")]
    [MaxLength(1)]
    public string? ExtendedCreditTotalCount { get; init; }

    /// <summary>
    /// On PIN Debit Gateways: This U.S.-only field is optionally used by  participants (merchants and acquirers) to specify the network access priority.
    /// VisaNet checks to determine if there are issuer routing preferences for any of the networks specified by the sharing group code.
    /// If an issuer preference exists for one of the specified debit networks, VisaNet makes a routing selection based on the issuer’s preference.
    /// If an issuer preference exists for more than one of the specified debit networks, or if no issuer preference exists,
    /// VisaNet makes a selection based on the acquirer’s routing priorities.
    /// <para>
    /// #### PIN debit
    /// Priority order of the networks through which he transaction will be routed. Set this value to a series of one-character network codes in your preferred order. This is a list of the network codes:
    /// </para>
    /// <para>
    /// | Network | Code |
    /// | --- | --- |
    /// | Accel | E |
    /// | AFFN | U |
    /// | Alaska Option | 3 |
    /// | CU24 | C |
    /// | Interlink | G |
    /// | Maestro | 8 |
    /// | NETS | P |
    /// | NYCE | F |
    /// | Pulse | H |
    /// | Shazam | 7 |
    /// | Star | M |
    /// | Visa | V |
    /// </para>
    /// <para>
    /// For example, if the Star network is your first preference and Pulse is your second preference, set this field to a value of <c>MH</c>.
    /// </para>
    /// <para>
    /// When you do not include this value in your PIN debit request, the list of network codes from your account is used.
    /// <b>Note</b> This field is supported only for businesses located in the U.S.
    /// </para>
    /// <para>
    /// Optional field for PIN debit credit or PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkRoutingOrder")]
    [MaxLength(30)]
    public string? NetworkRoutingOrder { get; init; }

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
    /// Minutes until a pending MyBank transaction will be timed out. Value
    /// must be between 5 and 30. Default is 5.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeout")]
    public int? Timeout { get; init; }

    /// <summary>
    /// Flag that indicates the functionality we are having for merchants for which auth is done through Cybersource but
    /// settlement is done by themselves.
    /// true: functionality is supported. Processor should send raw processor auth response to Merchant.
    /// false: functionality is not supported.
    /// Default: false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isReturnAuthRecordEnabled")]
    public bool? IsReturnAuthRecordEnabled { get; init; }

    /// <summary>
    /// Merchant payment gateway ID that is assigned by Mastercard and is provided by the acquirer when a registered merchant payment gateway service provider is involved in the transaction.
    /// This field is supported for Visa Platform Connect, Chase Paymentech Salem.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkPartnerId")]
    [MaxLength(11)]
    public string? NetworkPartnerId { get; init; }

    /// <summary>
    /// Identifier for the payment type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentType")]
    [MaxLength(3)]
    public string? PaymentType { get; init; }

    /// <summary>
    /// Enablers are payment processing entities that are not acquiring members and are often the primary relationship owner with merchants and originators. Enablers own technical solutions through which the merchant or originator will access acceptance. The Enabler ID is a five-character hexadecimal identifier that will be used by Visa to identify enablers. Enabler ID assignment will be determined by Visa. Visa will communicate Enablers assignments to enablers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablerId")]
    [MaxLength(15)]
    public string? EnablerId { get; init; }

    /// <summary>
    /// The instruction to process an order.
    /// - default value: 'NO_INSTRUCTION'
    /// - 'ORDER_SAVED_EXPLICITLY'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingInstruction")]
    [MaxLength(36)]
    public string? ProcessingInstruction { get; init; }

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
    /// This field is applicable for AFT and OCT transactions. For list of supported values, please refer to Developer Guide.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purposeOfPayment")]
    [MaxLength(25)]
    public string? PurposeOfPayment { get; init; }

    /// <summary>
    /// Contains the ISO 639-2 defined language Code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("languageCode")]
    [MaxLength(10)]
    public string? LanguageCode { get; init; }

    /// <summary>
    /// This value is used for linking Authorization extension transaction to the original Authorization transaction
    /// and for linking MIT (Merchant initiated transaction) with the respective CIT (Customer initiated transaction).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalPaymentId")]
    [MaxLength(26)]
    public string? OriginalPaymentId { get; init; }

    /// <summary>
    /// Effective with the April 2025 release, American Express is introducing the following new Indirect Acceptor models :
    /// - Digital Wallet Operator
    ///   - Staged back to back transaction
    ///   - Peer to peer (P2P) transaction
    ///   - Stored value transaction
    /// - Marketplace
    /// <para>
    /// Each model must have a separate American Express Merchant Account number and will be assigned a unique Indirect Model Type value.
    /// </para>
    /// <para>
    /// Valid/Sample Values :
    /// - <c>1</c>: Bill payment provider
    /// - <c>2</c>: Installment payment transaction
    /// - <c>3</c>: Marketplace
    /// - <c>4</c>: Peer to peer transaction
    /// - <c>5</c>: Staged back to back transaction
    /// - <c>6</c>: Stored value transaction
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amexIndirectModelType")]
    [MaxLength(2)]
    public string? AmexIndirectModelType { get; init; }

    /// <summary>
    /// Identifies the type of operation being performed by the staged digital wallet operator. The value distinguishes between a Cash-in transaction (coded as “02”), where funds are loaded into the digital wallet from a registered payment card, and a Purchase transaction (coded as “01”), where the wallet is used to make a payment to a merchant or transfer funds between wallets. This distinction is essential for transaction processing, reporting, and ensuring compliance with the specific rules and requirements associated with each card brand and transaction type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletTransactionIntent")]
    public double? WalletTransactionIntent { get; init; }

    /// <summary>
    /// Identifies the destination/purpose of the cash-in:
    /// • 04: M2M (Same ownership, same portfolio/arrangement)
    /// • 05: P2P (For another holder, same wallet/arrangement)
    /// • 06: Transfer to another arrangement (same ownership)
    /// • 07: Transfer to another arrangement (other ownership)
    /// • 08: Transfer to stored value digital wallet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destinationType")]
    public double? DestinationType { get; init; }

    /// <summary>
    /// Contains program-specific indicators for transaction processing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("programIndicators")]
    public ProgramIndicators? ProgramIndicators { get; init; }

    /// <summary>
    /// Type of inquiry for Zero dollar transactions. Mastercard is introducing Mastercard One Credential, a single, digitally connected credential that offers cardholders the ability to access multiple payment methods.
    /// <para>
    /// This field is used for Product Status Inquiry (PSI), Account Status Inquiry with Product Status Inquiry (ASI with PSI), and Account Status Inquiry with Product Status Inquiry and Probability Indicator.
    /// </para>
    /// <para>
    /// This field is supported for Zero dollar transactions only.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>01</c>: Product status inquiry
    /// - <c>02</c>: Account status inquiry with product status inquiry
    /// - <c>03</c>: Account status Inquiry with Product Status Inquiry and Probability Indicator
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization (Zero dollar transactions)</b>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inquiryType")]
    [MaxLength(2)]
    public string? InquiryType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
