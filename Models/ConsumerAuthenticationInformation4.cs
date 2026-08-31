using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ConsumerAuthenticationInformation4
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("strongAuthentication")]
    public StrongAuthentication2? StrongAuthentication { get; init; }

    /// <summary>
    /// An override field that a merchant can pass in to set the challenge window size to display to the end cardholder.  The ACS (Active Control Server) will reply with content that is formatted appropriately to this window size to allow for the best user experience.  The sizes are width x height in pixels of the window displayed in the cardholder browser window.
    /// <para>
    /// 01 - 250x400
    /// </para>
    /// <para>
    /// 02 - 390x400
    /// </para>
    /// <para>
    /// 03 - 500x600
    /// </para>
    /// <para>
    /// 04 - 600x400
    /// </para>
    /// <para>
    /// 05 - Full page
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acsWindowSize")]
    [MaxLength(2)]
    public string? AcsWindowSize { get; init; }

    /// <summary>
    /// Data that documents and supports a specific authentication process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alternateAuthenticationData")]
    [MaxLength(2048)]
    public string? AlternateAuthenticationData { get; init; }

    /// <summary>
    /// Date and time in UTC of the cardholder authentication. Format: YYYYMMDDHHMM
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alternateAuthenticationDate")]
    [MaxLength(14)]
    public string? AlternateAuthenticationDate { get; init; }

    /// <summary>
    /// Mechanism used by the cardholder to authenticate to the 3D Secure requestor.
    /// Possible values:
    /// - <c>01</c>: No authentication occurred
    /// - <c>02</c>: Login using merchant system credentials
    /// - <c>03</c>: Login using Federated ID
    /// - <c>04</c>: Login using issuer credentials
    /// - <c>05</c>: Login using third-party authenticator
    /// - <c>06</c>: Login using FIDO Authenticator
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alternateAuthenticationMethod")]
    public string? AlternateAuthenticationMethod { get; init; }

    /// <summary>
    /// The date/time of the authentication at the 3DS servers. RISK update authorization service in auth request
    /// payload with value returned in <c>consumerAuthenticationInformation.alternateAuthenticationData</c> if merchant calls via CYBS or field can be
    /// provided by merchant in authorization request if calling an external 3DS provider.
    /// <para>
    /// This field is supported for Cartes Bancaires Fast'R transactions on Credit Mutuel-CIC.
    /// Format: YYYYMMDDHHMMSS
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationDate")]
    [MaxLength(14)]
    public string? AuthenticationDate { get; init; }

    /// <summary>
    /// Payer authentication transaction identifier passed to link the check enrollment
    /// and validate authentication messages.For Rupay,this is passed only in Re-Send OTP usecase.
    /// <b>Note</b>: Required for Standard integration, Rupay Seamless server to server integration for enroll service.
    /// Required for Hybrid integration for validate service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationTransactionId")]
    [MaxLength(26)]
    public string? AuthenticationTransactionId { get; init; }

    /// <summary>
    /// This  field is only applicable to Rupay and is optional. Merchant will have to pass a valid value from 01 through 07 which indicates the transaction flow. Below are the possible values.
    /// 01:NW- Transaction performed at domestic merchant.
    /// 02:TW- Transaction performed at domestic merchant along with Token provisioning.
    /// 03:IT- Transaction performed at International merchant.
    /// 04:AT- Authentication Transaction Only.
    /// 05:AW- Authentication transaction for provisioning.
    /// 06:DI- Domestic InApp Transaction.
    /// 07:II- International InApp transaction.
    /// 08:GC- Guest Checkout
    /// 09:ST- SI Authentication Transaction only
    /// 10:SW- SI Authorization along with token provisioning
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionFlowIndicator")]
    public int? TransactionFlowIndicator { get; init; }

    /// <summary>
    /// Possible values:
    /// - <c>01</c>: No preference
    /// - <c>02</c>: No challenge request
    /// - <c>03</c>: Challenge requested (3D Secure requestor preference)
    /// - <c>04</c>: Challenge requested (mandate)
    /// - <c>05</c>: No challenge requested (transactional risk analysis is already performed)
    /// - <c>06</c>: No challenge requested (Data share only)
    /// - <c>07</c>: No challenge requested (strong consumer authentication is already performed)
    /// - <c>08</c>: No challenge requested (utilize whitelist exemption if no challenge required)
    /// - <c>09</c>: Challenge requested (whitelist prompt requested if challenge required)
    /// <b>Note</b> This field will default to <c>01</c> on merchant configuration and can be overridden by the merchant.
    /// EMV 3D Secure version 2.1.0 supports values <c>01-04</c>. Version 2.2.0 supports values <c>01-09</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeCode")]
    public string? ChallengeCode { get; init; }

    /// <summary>
    /// The <c>consumerAuthenticationInformation.challengeCode</c> indicates the authentication type/level, or challenge, that was presented to the cardholder
    /// at checkout by the merchant when calling the Carte Bancaire 3DS servers via CYBS RISK services. It conveys to
    /// the issuer the alternative authentication methods that the consumer used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeStatus")]
    [MaxLength(2)]
    public string? ChallengeStatus { get; init; }

    /// <summary>
    /// An alias that uniquely identifies the customer's account and credit card on file.
    /// Note This field is required if Tokenization is enabled in the merchant profile settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerCardAlias")]
    [MaxLength(128)]
    public string? CustomerCardAlias { get; init; }

    /// <summary>
    /// Indicates whether the 3DS Requestor requests the ACS to utilize Decoupled Authentication and agrees to utilize Decoupled Authentication if the ACS confirms its use.
    /// <para>
    /// Possible Values:
    /// </para>
    /// <para>
    /// Y - Decoupled Authentication is supported and preferred if challenge is necessary
    /// </para>
    /// <para>
    /// N - Do not use Decoupled Authentication
    /// </para>
    /// <para>
    /// <b>Default Value</b>: N
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decoupledAuthenticationIndicator")]
    [MaxLength(1)]
    public string? DecoupledAuthenticationIndicator { get; init; }

    /// <summary>
    /// Indicates the maximum amount of time that the 3DS Requestor will wait for an ACS (Active control server) to provide the results of a Decoupled Authentication transaction (in minutes).
    /// Possible Values: Numeric values between 1 and 10080 accepted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decoupledAuthenticationMaxTime")]
    [MaxLength(5)]
    public string? DecoupledAuthenticationMaxTime { get; init; }

    /// <summary>
    /// Indicates that the card being used is the one designated as the primary payment card for purchase.
    /// Recommended for Discover ProtectBuy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultCard")]
    public bool? DefaultCard { get; init; }

    /// <summary>
    /// Determines the channel that the transaction came through. Possible Values: SDK/Browser/3RI. 3RI - 3DS request initiated.
    /// </summary>
    [JsonPropertyName("deviceChannel")]
    [MaxLength(10)]
    public required string DeviceChannel { get; init; }

    /// <summary>
    /// An integer value greater than 1 indicating the max number of permitted authorizations for installment payments.
    /// <b>Note</b> This is required if the merchant and cardholder have agreed to installment payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentTotalCount")]
    public int? InstallmentTotalCount { get; init; }

    /// <summary>
    /// Calculated by merchants as per PSD2<b> RTS</b> (EEA** card fraud divided by all EEA card volumes).
    /// Possible Values:
    /// 1 = Represents fraud rate &lt;=1
    /// <para>
    /// 2 = Represents fraud rate &gt;1 and &lt;=6
    /// </para>
    /// <para>
    /// 3 = Represents fraud rate &gt;6 and &lt;=13
    /// </para>
    /// <para>
    /// 4 = Represents fraud rate &gt;13 and &lt;=25
    /// </para>
    /// <para>
    /// 5 = Represents fraud rate &gt;25
    /// </para>
    /// <para>
    /// EEA** = European Economic Area
    /// RTS** = Regulatory Technical Standards
    /// PSD2** = Payment Services Directive
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantFraudRate")]
    [MaxLength(2)]
    public string? MerchantFraudRate { get; init; }

    /// <summary>
    /// Indicates whether the customer has opted in for marketing offers.
    /// Recommended for Discover ProtectBuy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("marketingOptIn")]
    public bool? MarketingOptIn { get; init; }

    /// <summary>
    /// Indicates origin of the marketing offer. Recommended for Discover ProtectBuy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("marketingSource")]
    [MaxLength(40)]
    public string? MarketingSource { get; init; }

    /// <summary>
    /// Merchant category code.
    /// <b>Important</b> Required only for Visa Secure transactions in Brazil.
    /// Do not use this request field for any other types of transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    [MaxLength(4)]
    public string? Mcc { get; init; }

    /// <summary>
    /// Risk Score provided by merchants. This is specific for CB transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantScore")]
    public int? MerchantScore { get; init; }

    /// <summary>
    /// Category of the message for a specific use case. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>01</c>: PA- payment authentication</description></item>
    ///   <item><description><c>02</c>: NPA- non-payment authentication</description></item>
    ///   <item><description><c>03-79</c>: Reserved for EMVCo future use (values invalid until defined by EMVCo)</description></item>
    ///   <item><description><c>80-99</c>: Reserved for DS use</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messageCategory")]
    public string? MessageCategory { get; init; }

    /// <summary>
    /// Non-Payer Authentication Indicator.
    /// Possible values:
    /// - <c>01</c>: Add card
    /// - <c>02</c>: Maintain card information
    /// - <c>03</c>: Cardholder verification for EMV token
    /// - <c>04-80</c> Reserved for EMVCo
    /// - <c>80-90</c> Reserved DS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("npaCode")]
    [MaxLength(2)]
    public string? NpaCode { get; init; }

    /// <summary>
    /// Specifies the Brazilian payment account type used for the transaction.
    /// This field overrides other payment types that might be specified in the request.
    /// Use one of the following values for this field:
    /// - <c>NA</c>: Not applicable. Do not override other payment types that are specified in the request.
    /// - <c>CR</c>: Credit card.
    /// - <c>DB</c>: Debit card.
    /// - <c>VSAVR</c>: Visa Vale Refeicao
    /// - <c>VSAVA</c>: Visa Vale Alimentacao
    /// <b>Important</b> Required only for Visa Secure transactions in Brazil.
    /// Do not use this request field for any other types of transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("overridePaymentMethod")]
    public string? OverridePaymentMethod { get; init; }

    /// <summary>
    /// Two-character <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes</see>..
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("overrideCountryCode")]
    [MaxLength(2)]
    public string? OverrideCountryCode { get; init; }

    /// <summary>
    /// This field carry data that the ACS can use to verify the authentication process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priorAuthenticationData")]
    [MaxLength(2048)]
    public string? PriorAuthenticationData { get; init; }

    /// <summary>
    /// Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor.
    /// <para>
    /// 01 - Frictionless authentication occurred by ACS
    /// </para>
    /// <para>
    /// 02 - Cardholder challenge occurred by ACS
    /// </para>
    /// <para>
    /// 03 - AVS verified
    /// </para>
    /// <para>
    /// 04 - Other issuer methods
    /// </para>
    /// <para>
    /// 05-79 - Reserved for EMVCo future use (values invalid until defined by EMVCo)
    /// </para>
    /// <para>
    /// 80-99 - Reserved for DS use
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priorAuthenticationMethod")]
    [MaxLength(2)]
    public string? PriorAuthenticationMethod { get; init; }

    /// <summary>
    /// This data element contains a ACS Transaction ID for a prior authenticated transaction.
    /// For example, the first recurring transaction that was authenticated with the cardholder
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priorAuthenticationReferenceId")]
    [MaxLength(36)]
    public string? PriorAuthenticationReferenceId { get; init; }

    /// <summary>
    /// Date and time in UTC of the prior cardholder authentication. Format – YYYYMMDDHHMM
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priorAuthenticationTime")]
    [MaxLength(12)]
    public string? PriorAuthenticationTime { get; init; }

    /// <summary>
    /// Specifies the product code, which designates the type of transaction.
    /// Specify one of the following values for this field:
    /// - AIR: Airline purchase
    /// Important Required for American Express SafeKey (U.S.).
    /// - <c>ACC</c>: Accommodation Rental
    /// - <c>ACF</c>: Account funding
    /// - <c>CHA</c>: Check acceptance
    /// - <c>DIG</c>: Digital Goods
    /// - <c>DSP</c>: Cash Dispensing
    /// - <c>GAS</c>: Fuel
    /// - <c>GEN</c>: General Retail
    /// - <c>LUX</c>: Luxury Retail
    /// - <c>PAL</c>: Prepaid activation and load
    /// - <c>PHY</c>: Goods or services purchase
    /// - <c>QCT</c>: Quasi-cash transaction
    /// - <c>REN</c>: Car Rental
    /// - <c>RES</c>: Restaurant
    /// - <c>SVC</c>: Services
    /// - <c>TBD</c>: Other
    /// - <c>TRA</c>: Travel
    /// <b>Important</b> Required for Visa Secure transactions in Brazil.
    /// Do not use this request field for any other types of transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productCode")]
    [MaxLength(3)]
    public string? ProductCode { get; init; }

    /// <summary>
    /// The URL of the merchant’s return page. CyberSource adds this return URL to the step-up JWT and returns it in the
    /// response of the Payer Authentication enrollment call. The merchant's return URL page serves as a listening URL.
    /// Once the bank session completes, the merchant receives a POST to their URL. This response contains the completed
    /// bank session’s transactionId. The merchant’s return page should capture the transaction ID and send it in the
    /// Payer Authentication validation call.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnUrl")]
    [MaxLength(2048)]
    public string? ReturnUrl { get; init; }

    /// <summary>
    /// Cardinal's directory server assigned 3DS Requestor ID value
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestorId")]
    [MaxLength(35)]
    public string? RequestorId { get; init; }

    /// <summary>
    /// Indicates the type of 3RI request.
    /// <para>
    /// Possible Values:
    /// </para>
    /// <para>
    /// 01 - Recurring transaction
    /// </para>
    /// <para>
    /// 02 - Installment transaction
    /// </para>
    /// <para>
    /// 03 - Add card
    /// </para>
    /// <para>
    /// 04 - Maintain card
    /// </para>
    /// <para>
    /// 05 - Account verification
    /// </para>
    /// <para>
    /// 06 - Split/delayed shipment
    /// </para>
    /// <para>
    /// 07 - Top-up
    /// </para>
    /// <para>
    /// 08 - Mail Order
    /// </para>
    /// <para>
    /// 09 - Telephone Order
    /// </para>
    /// <para>
    /// 10 - Whitelist status check
    /// </para>
    /// <para>
    /// 11 - Other payment
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestorInitiatedAuthenticationIndicator")]
    [MaxLength(2)]
    public string? RequestorInitiatedAuthenticationIndicator { get; init; }

    /// <summary>
    /// Cardinal's directory server assigned 3DS Requestor Name value
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestorName")]
    [MaxLength(40)]
    public string? RequestorName { get; init; }

    /// <summary>
    /// Reference ID that corresponds to the device fingerprinting data that was collected previously.
    /// Note Required for Hybrid integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceId")]
    [MaxLength(50)]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// This field indicates the maximum amount of time for all 3DS 2.0 messages to be communicated between all components (in minutes).
    /// <para>
    /// Possible Values:
    /// </para>
    /// <para>
    /// Greater than or equal to 05 (05 is the minimum timeout to set)
    /// </para>
    /// <para>
    /// Cardinal Default is set to 15
    /// </para>
    /// <para>
    /// NOTE: This field is a required 3DS 2.0 field and Cardinal sends in a default of 15 if nothing is passed
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkMaxTimeout")]
    [MaxLength(2)]
    public string? SdkMaxTimeout { get; init; }

    /// <summary>
    /// Indicates dedicated payment processes and procedures were used, potential secure corporate payment exemption applies.
    /// Possible Values : 0/1
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secureCorporatePaymentIndicator")]
    [MaxLength(1)]
    public string? SecureCorporatePaymentIndicator { get; init; }

    /// <summary>
    /// Transaction mode identifier. Identifies the channel from which the transaction originates.
    /// Possible values:
    /// <list type="bullet">
    ///   <item><description><c>M</c>: MOTO (Mail Order Telephone Order)</description></item>
    ///   <item><description><c>R</c>: Retail</description></item>
    ///   <item><description><c>S</c>: eCommerce</description></item>
    ///   <item><description><c>P</c>: Mobile Device</description></item>
    ///   <item><description><c>T</c>: Tablet</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionMode")]
    public string? TransactionMode { get; init; }

    /// <summary>
    /// Enables the communication of trusted beneficiary/whitelist status between the ACS, the DS and the 3DS Requestor.
    /// <para>
    /// Possible Values:
    /// </para>
    /// <para>
    /// Y - 3DS Requestor is whitelisted by cardholder
    /// </para>
    /// <para>
    /// N - 3DS Requestor is not whitelisted by cardholder
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whiteListStatus")]
    [MaxLength(1)]
    public string? WhiteListStatus { get; init; }

    /// <summary>
    /// Risk Assessment from Mastercard. This is to be sent by merchant if they would like to request a score
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scoreRequest")]
    public int? ScoreRequest { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
