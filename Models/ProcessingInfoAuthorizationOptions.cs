using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models.Enums;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInfoAuthorizationOptions
{
    /// <summary>
    /// Authorization type. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>AUTOCAPTURE</c>: automatic capture.</description></item>
    ///   <item><description><c>STANDARDCAPTURE</c>: standard capture.</description></item>
    ///   <item><description><c>VERBAL</c>: forced capture. Include it in the payment request for a forced capture. Include it in the capture request for a verbal payment.</description></item>
    /// </list>
    /// <para>
    /// #### Asia, Middle East, and Africa Gateway; Cielo; Comercio Latino; and CyberSource Latin American Processing
    /// Set this field to <c>AUTOCAPTURE</c> and include it in a bundled request to indicate that you are requesting an automatic capture. If your account is configured to enable automatic captures, set this field to <c>STANDARDCAPTURE</c> and include it in a standard authorization or bundled request to indicate that you are overriding an automatic capture.
    /// </para>
    /// <para>
    /// #### Forced Capture
    /// Set this field to <c>VERBAL</c> and include it in the authorization request to indicate that you are performing a forced capture; therefore, you receive the authorization code outside the CyberSource system.
    /// </para>
    /// <para>
    /// #### Verbal Authorization
    /// Set this field to <c>VERBAL</c> and include it in the capture request to indicate that the request is for a verbal authorization.
    /// </para>
    /// <para>
    /// #### for PayPal ptsV2CreateOrderPost400Response
    /// Set this field to 'AUTHORIZE' or 'CAPTURE' depending on whether you want to invoke delayed capture or sale respectively.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authType")]
    [MaxLength(15)]
    public string? AuthType { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// The field contains the PAN translation indicator for American Express Contactless Transaction. Valid value is
    /// <para>
    /// 1- Expresspay Translation, PAN request
    /// 2- Expresspay Translation, PAN and Expiry date request
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("panReturnIndicator")]
    [MaxLength(1)]
    public string? PanReturnIndicator { get; init; }

    /// <summary>
    /// Authorization code.
    /// <para>
    /// #### Forced Capture
    /// Use this field to send the authorization code you received from a payment that you authorized
    /// outside the CyberSource system.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Authorization code that is returned by the processor.
    /// </para>
    /// <para>
    /// Returned by PIN debit purchase.
    /// </para>
    /// <para>
    /// #### Verbal Authorization
    /// Use this field in CAPTURE API to send the verbally received authorization code.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verbalAuthCode")]
    [MaxLength(7)]
    public string? VerbalAuthCode { get; init; }

    /// <summary>
    /// Transaction ID (TID).
    /// <para>
    /// #### FDMS South
    /// This field is required for verbal authorizations and forced captures with the American Express card type to comply
    /// with the CAPN requirements:
    /// - Forced capture: Obtain the value for this field from the authorization response.
    /// - Verbal authorization: You cannot obtain a value for this field so CyberSource uses the default value of <c>000000000000000</c> (15
    /// zeros).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verbalAuthTransactionId")]
    [MaxLength(15)]
    public string? VerbalAuthTransactionId { get; init; }

    /// <summary>
    /// Flag that specifies the purpose of the authorization.
    /// <para>
    /// Possible values:
    ///  - <b>0</b>: Preauthorization
    ///  - <b>1</b>: Final authorization
    /// </para>
    /// <para>
    /// To set the default for this field, contact CyberSource Customer Support.
    /// </para>
    /// <para>
    /// #### Barclays and Elavon
    /// The default for Barclays and Elavon is 1 (final authorization). To change the default for this field, contact CyberSource Customer Support.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// When the value for this field is 0, it corresponds to the following data in the TC 33 capture file:
    ///  - Record: CP01 TCR0
    ///  - Position: 164
    ///  - Field: Additional Authorization Indicators
    /// When the value for this field is 1, it does not correspond to any data in the TC 33 capture file.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authIndicator")]
    [MaxLength(1)]
    public string? AuthIndicator { get; init; }

    /// <summary>
    /// Flag that indicates whether the transaction is enabled for partial authorization. When the request includes this
    /// field, this value overrides the information in your account. Possible values:
    /// - <c>true</c>: Enable the transaction for partial authorization.
    /// - <c>false</c>: Do not enable the transaction for partial authorization.
    /// <para>
    /// #### PIN debit
    /// Required field for partial authorizations that use PIN debit purchase; otherwise, not used.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// To set the default for this field, contact CyberSource Customer Support.
    /// The value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP01 TCR0
    /// - Position: 164
    /// - Field: Additional Authorization Indicators
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partialAuthIndicator")]
    public bool? PartialAuthIndicator { get; init; }

    /// <summary>
    /// Indicates Authorization extension transaction. Extension transaction is used to prolong the settlement period by one additional settlement cycle period.
    /// <para>
    /// Possible values:
    /// - true: Transaction is an Authorization Extension transaction.
    /// - false: Transaction is not an Authorization Extension transaction.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendAuthIndicator")]
    [MaxLength(5)]
    public string? ExtendAuthIndicator { get; init; }

    /// <summary>
    /// Flag that indicates whether to return balance information.
    /// <para>
    /// Possible values:
    /// - <c>true</c>: Return balance information.
    /// - <c>false</c>: Do not return balance information.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required for a balance inquiry; otherwise, not used.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Required for a balance inquiry request of a PIN debit purchase; otherwise, not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceInquiry")]
    public bool? BalanceInquiry { get; init; }

    /// <summary>
    /// Flag for a sale request that indicates whether to allow the capture service to run even when the authorization
    /// receives an AVS decline, as indicated by a reply flag value of DAVSNO.
    /// <para>
    /// Possible values:
    /// - <c>true</c>: Ignore the results of AVS checking and run the capture service.
    /// - <c>false</c> (default): If the authorization receives an AVS decline, do not run the capture service.
    /// When the value of this field is <c>true</c>, the list in the <c>processingInformation.authorizationOptions.declineAvsFlags</c> field is ignored.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional field.
    /// String (3)
    /// </para>
    /// </summary>
    [JsonPropertyName("ignoreAvsResult")]
    public bool? IgnoreAvsResult { get; init; } = false;

    /// <summary>
    /// Comma-separated list of AVS flags that cause the reply flag <c>DAVSNO</c> to be returned.
    /// <para>
    /// <b>Important</b> To receive declines for the AVS code <c>N</c>, you must include the value <c>N</c> in the comma-separated
    /// list.
    /// </para>
    /// <para>
    ///   ### AVS Codes for Cielo 3.0 and CyberSource Latin American Processing
    /// </para>
    /// <para>
    ///   <b>Note</b> CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports.
    ///   In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America.
    ///   The information in this section is for the specific processing connection called CyberSource Latin American Processing.
    ///   It is not for any other Latin American processors that CyberSource supports.
    /// </para>
    /// <para>
    /// |AVS Code|Description|
    /// |--- |--- |
    /// |D|Partial match: postal code and address match.|
    /// |E|Not supported: AVS is not supported for this card type. _or_ Invalid: the acquirer returned an unrecognized value for the AVS response.|
    /// |F|Partial match: postal code matches, but CPF and address do not match.*|
    /// |G|Not supported: AVS not supported or not verified.|
    /// |I|No match: AVS information is not available.|
    /// |K|Partial match: CPF matches, but postal code and address do not match.*|
    /// |L|Partial match: postal code and CPF match, but address does not match.*|
    /// |N|No match: postal code, CPF, and address do not match.*|
    /// |O|Partial match: CPF and address match, but postal code does not match.*|
    /// |R|Not supported: your implementation does not support AVS _or_ System unavailable.|
    /// |T|Partial match: address matches, but postal code and CPF do not match.*|
    /// |V|Match: postal code, CPF, and address match.*|
    /// |* CPF (Cadastro de Pessoas Fisicas) is required only for Redecard in Brazil.||
    /// </para>
    /// <para>
    /// ### AVS Codes for All Other Processors
    /// </para>
    /// <para>
    /// <b>Note</b> The list of AVS codes for all other processors follows these descriptions of the processor-specific information for these codes.
    /// </para>
    /// <para>
    /// #### American Express Cards
    /// For American Express cards only, you can receive Visa and CyberSource
    /// AVS codes in addition to the American Express AVS codes.
    /// </para>
    /// <para>
    /// <b>Note</b> For CyberSource through VisaNet, the American Express AVS codes are converted to Visa
    /// AVS codes before they are returned to you. As a result, you will not receive American Express AVS codes for
    /// the American Express card type.&lt;br/&gt;&lt;br/&gt;
    /// </para>
    /// <para>
    /// _American Express Card codes_: <c>F</c>, <c>H</c>, <c>K</c>, <c>L</c>, <c>O</c>, <c>T</c>, <c>V</c>
    /// </para>
    /// <para>
    /// #### Domestic and International Visa Cards
    /// The international and domestic alphabetic AVS codes are the Visa standard AVS codes. CyberSource maps
    /// the standard AVS return codes for other types of payment cards, including American Express cards, to
    /// the Visa standard AVS codes.
    /// </para>
    /// <para>
    /// AVS is considered either domestic or international, depending on the location of the bank that issued the
    /// customer's payment card:
    /// - When the bank is in the U.S., the AVS is domestic.
    /// - When the bank is outside the U.S., the AVS is international.
    /// </para>
    /// <para>
    /// You should be prepared to handle both domestic and international AVS result codes:
    /// - For international cards, you can receive domestic AVS codes in addition to the international AVS codes.
    /// - For domestic cards, you can receive international AVS codes in addition to the domestic AVS codes.
    /// </para>
    /// <para>
    /// _International Visa Codes_: <c>B</c>, <c>C</c>, <c>D</c>, <c>G</c>, <c>I</c>, <c>M</c>, <c>P</c>
    /// </para>
    /// <para>
    /// _Domestic Visa Codes_: <c>A</c>, <c>E</c>,<c>N</c>, <c>R</c>, <c>S</c>, <c>U</c>, <c>W</c>, <c>X</c>, <c>Y</c>, <c>Z</c>
    /// </para>
    /// <para>
    /// #### CyberSource Codes
    /// The numeric AVS codes are created by CyberSource
    /// and are not standard Visa codes. These AVS codes
    /// can be returned for any card type.
    /// </para>
    /// <para>
    /// _CyberSource Codes_: <c>1</c>, <c>2</c>, <c>3</c>, <c>4</c>
    /// </para>
    /// <para>
    /// ### Table of AVS Codes for All Other Processors
    /// </para>
    /// <para>
    /// |AVS Code|Description|
    /// |--- |--- |
    /// |A|Partial match: street address matches, but 5-digit and 9-digit postal codes do not match.|
    /// |B|Partial match: street address matches, but postal code is not verified. Returned only for Visa cards not issued in the U.S.|
    /// |C|No match: street address and postal code do not match. Returned only for Visa cards not issued in the U.S.|
    /// |D &amp; M|Match: street address and postal code match. Returned only for Visa cards not issued in the U.S.|
    /// |E|Invalid: AVS data is invalid or AVS is not allowed for this card type.|
    /// |F|Partial match: card member’s name does not match, but billing postal code matches.|
    /// |G|Not supported: issuing bank outside the U.S. does not support AVS.|
    /// |H|Partial match: card member’s name does not match, but street address and postal code match. Returned only for the American Express card type.|
    /// |I|No match: address not verified. Returned only for Visa cards not issued in the U.S.|
    /// |K|Partial match: card member’s name matches, but billing address and billing postal code do not match. Returned only for the American Express card type.|
    /// |L|Partial match: card member’s name and billing postal code match, but billing address does not match. Returned only for the American Express card type.|
    /// |M|See the entry for D &amp; M.|
    /// |N|No match: one of the following: street address and postal code do not match _or_ (American Express card type only) card member’s name, street address, and postal code do not match.|
    /// |O|Partial match: card member’s name and billing address match, but billing postal code does not match. Returned only for the American Express card type.|
    /// |P|Partial match: postal code matches, but street address not verified. Returned only for Visa cards not issued in the U.S.|
    /// |R|System unavailable.|
    /// |S|Not supported: issuing bank in the U.S. does not support AVS.|
    /// |T|Partial match: card member’s name does not match, but street address matches. Returned only for the American Express card type.|
    /// |U|System unavailable: address information unavailable for one of these reasons: The U.S. bank does not support AVS outside the U.S. _or_ The AVS in a U.S. bank is not functioning properly.|
    /// |V|Match: card member’s name, billing address, and billing postal code match. Returned only for the American Express card type.|
    /// |W|Partial match: street address does not match, but 9-digit postal code matches.|
    /// |X|Match: street address and 9-digit postal code match.|
    /// |Y|Match: street address and 5-digit postal code match.|
    /// |Z|Partial match: street address does not match, but 5-digit postal code matches.|
    /// |1|Not supported: one of the following: AVS is not supported for this processor or card type _or_ AVS is disabled for your CyberSource account. To enable AVS, contact CyberSource Customer Support.|
    /// |2|Unrecognized: the processor returned an unrecognized value for the AVS response.|
    /// |3|Match: address is confirmed. Returned only for PayPal Express Checkout.|
    /// |4|No match: address is not confirmed. Returned only for PayPal Express Checkout.|
    /// |5|No match: no AVS code was returned by the processor.|
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("declineAvsFlags")]
    public IReadOnlyList<string>? DeclineAvsFlags { get; init; }

    /// <summary>
    /// User-defined list of ANI (Address Name Inquiry) codes that will cause the system to decline a transaction.
    /// <para>
    /// Address Name Inquiry is a Verification suite product which checks whether the name shared in the
    /// transaction matches with the one stored at the issuing bank. This field replicates the same behavior
    /// as AVS (which uses DAVSNO flag), but for ANI verification using the DANINO flag.
    /// </para>
    /// <para>
    /// <b>Important</b>:
    /// - By default, no ANI codes cause declines (empty/null)
    /// - Merchant specifies which ANI codes should trigger declines
    /// - When triggered, returns reason code 217 with reply flag <c>DANINO</c>
    /// - Use space to separate values in the list
    /// - To receive declines for the ANI code N, include the value N in the list
    /// </para>
    /// <para>
    /// ### ANI Result Codes
    /// </para>
    /// <para>
    /// |ANI Code|Description|
    /// |--- |--- |
    /// |Y|Match: Full name match with issuing bank records|
    /// |O|Partial match: Partial name match with issuing bank records|
    /// |N|No match: Name does not match issuing bank records|
    /// |U|Unverified: ANI verification not performed or not supported|
    /// |R|Retry: System should retry the ANI check|
    /// </para>
    /// <para>
    /// ### Reply Flag When Triggered
    /// </para>
    /// <para>
    /// When a transaction's ANI result matches one of the codes in this list, the system returns:
    /// - <b>Reason Code</b>: 217
    /// - <b>Reply Flag</b>: <c>DANINO</c>
    /// - <b>Description</b>: Decline. The authorization request was approved by the issuing bank but was
    ///   flagged because it did not pass the Address Name Inquiry (ANI) check.
    /// - <b>Possible Action</b>: Review the order for the possibility of fraud.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional field for controlling ANI-based declines.
    /// </para>
    /// <para>
    /// #### API Ticket
    /// ACCAPI-2138
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("declineAniFlags")]
    public IReadOnlyList<DeclineAniFlag>? DeclineAniFlags { get; init; }

    /// <summary>
    /// Flag for a sale request that indicates whether to allow the capture service to run even when the authorization receives a CVN decline, as indicated by an <c>processorInformation.cardVerification.resultCode</c> value of <c>D</c> or <c>N</c>.
    /// Possible values:
    /// - <c>true</c>: Ignore the results of CVN checking and run the capture service.
    /// - <c>false</c> (default): If the authorization receives a CVN decline, do not run the capture service.
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonPropertyName("ignoreCvResult")]
    public bool? IgnoreCvResult { get; init; } = false;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initiator")]
    public Initiator? Initiator { get; init; }

    /// <summary>
    /// Indicates payment for bill or payment towards existing contractual loan.
    /// <para>
    /// Possible values:
    /// - <c>true</c>: Bill payment or loan payment.
    /// - <c>false</c> (default): Not a bill payment or loan payment.
    /// </para>
    /// <para>
    /// Optional request field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billPayment")]
    public bool? BillPayment { get; init; }

    /// <summary>
    /// Reason for the payment.
    /// <para>
    /// Possible values:
    /// - 001: Public utilities / Utility payment
    /// - 002: Government services
    /// - 003: Cellular / Mobile phone top-up
    /// - 004: Coupon payment
    /// - 005: Installment based repayment
    /// - 006: Billing payment
    /// - 007: Tax payment
    /// - 008: Tax payment refunds
    /// </para>
    /// <para>
    /// The value for this field corresponds to the following data in the TC 33A capture file (applicable to Brazil):
    /// - Record: CP07 TCR0
    /// - Position: 48-50
    /// - Field: Bill Payment Transaction Type Identifier
    /// </para>
    /// <para>
    /// The value for this field corresponds to the following data in the TC 33A capture file (applicable to Installment)
    /// based Repayment):
    /// - Record: CP01 TCR6
    /// - Position: 154-156
    /// - Field: Bill Payment Transaction Type Identifier
    /// </para>
    /// <para>
    ///
    /// This field is supported for
    /// 1. Bill payments in Brazil with Mastercard on CyberSource through VisaNet.
    /// 2. Installment based repayment transactions on Cybersource through VisaNet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billPaymentType")]
    public string? BillPaymentType { get; init; }

    /// <summary>
    /// Flag that indicates the payment request is a redemption inquiry.
    /// <para>
    /// Possible values:
    ///   - <c>true</c>
    ///   - <c>false</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redemptionInquiry")]
    public bool? RedemptionInquiry { get; init; }

    /// <summary>
    /// Type of transportation mode :
    /// <para>
    /// Possible Values:
    /// - 00 = Unknown
    /// - 01 = Urban bus
    /// - 02 = Interurban bus
    /// - 03=Lighttrainmasstransit(Underground Metro LTR)
    /// - 04 = Train
    /// - 05 = Commuter train
    /// - 06 = Water-borne vehicle
    /// - 07 = Toll
    /// - 08 = Parking
    /// - 09 = Taxi
    /// - 10 = High-speed train
    /// - 11 = Rural bus
    /// - 12 = Express commuter train
    /// - 13 = Para transit
    /// - 14 = Self drive vehicle
    /// - 15 = Coach
    /// - 16 = Locomotive
    /// - 17 = Powered motor coach
    /// - 18 = Trailer
    /// - 19 = Regional train
    /// - 20 = Inter-city
    /// - 21 = Funicular train
    /// - 22 = Cable car
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transportationMode")]
    public string? TransportationMode { get; init; }

    /// <summary>
    /// Indicates if transaction is an aggregated auth
    /// <para>
    /// Possible values:
    /// - <b>true</b>
    /// - <b>false</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aggregatedAuthIndicator")]
    public string? AggregatedAuthIndicator { get; init; }

    /// <summary>
    /// Indicates if transaction is a debt recovery request
    /// <para>
    /// Possible values:
    /// - <b>true</b>
    /// - <b>false</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debtRecoveryIndicator")]
    public string? DebtRecoveryIndicator { get; init; }

    /// <summary>
    /// Flag that indicates whether the authorization request was delayed because connectivity was interrupted.
    /// <para>
    /// Possible values:
    ///   - <c>true</c> (Deferred authorization)
    ///   - <c>false</c> (default: Not a deferred authorization)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deferredAuthIndicator")]
    public bool? DeferredAuthIndicator { get; init; }

    /// <summary>
    /// This API field enables the merchant to indicate that a given transaction is Cash Advance.
    /// <para>
    /// Cash advance or Cash disbursement functionality allows a merchant to dispense cash at a point of sale.
    /// It provides the ability of a POS system to act like an ATM. These terminals are typically seen in bank
    /// branches where customers can use their card and withdraw cash or at merchant locations where ATMs are sparse.
    /// </para>
    /// <para>
    /// Possible values:
    ///   - <c>true</c> (Cash advance is supported)
    ///   - <c>false</c> (default: cash advance is not supported)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashAdvanceIndicator")]
    public bool? CashAdvanceIndicator { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Indicates split payment transaction. A split payment allows the use of two payment methods for a single transaction.
    /// <para>
    /// Possible values:
    ///   - <c>true</c> (split payment transaction is supported)
    ///   - <c>false</c> (default: split payment transaction is not supported)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitPaymentTransaction")]
    public bool? SplitPaymentTransaction { get; init; }

    /// <summary>
    /// This API field will indicate whether a card verification check is being performed during the transaction
    /// <para>
    /// Possible values:
    ///   - <c>true</c>
    ///   - <c>false</c> (default value)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardVerificationIndicator")]
    public bool? CardVerificationIndicator { get; init; }

    /// <summary>
    /// Transaction mode identifier. Identifies the specific channel from which the transaction originates.
    /// <para>
    /// Possible values:
    /// - M – Mobile Order
    /// - T – Telephone Order
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionMode")]
    [MaxLength(1)]
    public string? TransactionMode { get; init; }

    /// <summary>
    /// Indicates whether the transaction is an Account Funding Transaction (AFT).
    /// This field is mandatory for Account Funding Transactions (AFT).
    /// <para>
    /// Possible values:
    ///   - <c>true</c> (This is an AFT transaction)
    ///   - <c>false</c> (default value) (This is not an AFT transaction)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aftIndicator")]
    public bool? AftIndicator { get; init; }

    /// <summary>
    /// Field is used for back-to-back funding transaction and can be defined as a payment flow that automatically transfers funds through a real-time
    /// funding or a live-load. This type of transaction can also be connected to a purchase.
    /// In back-to-back funding of general purpose card that is used to make a purchase, two separate accounts are involved:
    /// - account one is used to make the purchase
    /// - account two is used to automatically fund or reimburse account one
    /// <para>
    /// Possible values:
    /// - 0B = back to back funding transaction
    /// - 00 = normal transaction
    /// - 01 = originator hold
    /// - 02 = Visa deferred OCT hold, default interval
    /// - 03 = Visa deferred OCT hold, user-defined interval
    /// - 09 = Cancel pending deferred OCT request
    /// - 0I = Visa Direct custom program 1
    /// - 0Q = uery the status of the deferred OCT
    /// - A0 = Alias Directory 2
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceType")]
    [MaxLength(10)]
    public string? ServiceType { get; init; }

    /// <summary>
    /// Merchant to inform Cybersource whether a transaction is Money load with Balance Update.
    /// <para>
    /// Possible values:
    ///   - <c>true</c> (This is a Money load with balance update transaction)
    ///   - <c>false</c> (default value) (This is not a Money load with balance update transaction)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceUpdate")]
    public bool? BalanceUpdate { get; init; }

    /// <summary>
    /// Merchant to inform Cybersource whether a transaction is Money load with Money load only.
    /// <para>
    /// Possible values:
    ///   - <c>true</c> (This is a money load transaction)
    ///   - <c>false</c> (default value) (This is not a money load transaction)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("moneyLoad")]
    public bool? MoneyLoad { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
