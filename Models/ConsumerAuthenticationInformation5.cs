using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ConsumerAuthenticationInformation5
{
    /// <summary>
    /// JSON Web Token (JWT) used to authenticate the consumer with the authentication provider, such as, CardinalCommerce or Rupay.
    /// Note - Max Length of this field is 2048 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; init; }

    /// <summary>
    /// Identifies the UI Type the ACS will use to complete the challenge. <b>NOTE</b>: Only available for App transactions using the Cardinal Mobile SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acsRenderingType")]
    public string? AcsRenderingType { get; init; }

    /// <summary>
    /// Unique transaction identifier assigned by the ACS to identify a single transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acsTransactionId")]
    [MaxLength(36)]
    public string? AcsTransactionId { get; init; }

    /// <summary>
    /// URL for the card-issuing bank’s authentication form that you receive when the card is enrolled.
    /// The value can be very large.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acsUrl")]
    [MaxLength(2048)]
    public string? AcsUrl { get; init; }

    /// <summary>
    /// Indicates what displays to the customer during the authentication process.
    /// This field can contain one of these values:
    /// - <c>ADS</c>: (Card not enrolled) customer prompted to activate the card during the checkout process.
    /// - <c>ATTEMPTS</c>: (Attempts processing) Processing briefly displays before the checkout process is completed.
    /// - <c>ENROLLED</c>: (Card enrolled) the card issuer’s authentication window displays.
    /// - <c>UNKNOWN</c>: Card enrollment status cannot be determined.
    /// - <c>NOREDIRECT</c>: (Card not enrolled, authentication unavailable, or error occurred) nothing displays to the customer.
    /// <para>
    /// The following values can be returned if you are using rules-based payer authentication.
    /// - <c>RIBA</c>: The card-issuing bank supports risk-based authentication, but whether the cardholder is likely
    /// to be challenged cannot be determined.
    /// - <c>RIBA_PASS</c>: The card-issuing bank supports risk-based authentication and it is likely that the
    /// cardholder will not be challenged to provide credentials, also known as _silent authentication_.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationPath")]
    public string? AuthenticationPath { get; init; }

    /// <summary>
    /// The Base64 encoded JSON Payload of CB specific Authorization Values returned in the challenge Flow
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizationPayload")]
    public string? AuthorizationPayload { get; init; }

    /// <summary>
    /// Indicates the type of authentication that will be used to challenge the card holder.
    /// <para>
    /// Possible Values:
    /// </para>
    /// <para>
    /// 01 - Static
    /// </para>
    /// <para>
    /// 02 - Dynamic
    /// </para>
    /// <para>
    /// 03 - OOB (Out of Band)
    /// </para>
    /// <para>
    /// 04 - Decoupled
    /// </para>
    /// <para>
    /// 20 - OTP hosted at merchant end. (Rupay S2S flow)
    /// <b>NOTE</b>:  EMV 3-D Secure version 2.1.0 supports values 01-03.  Version 2.2.0 supports values 01-04.  Decoupled authentication is not supported at this time.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationType")]
    [MaxLength(2)]
    public string? AuthenticationType { get; init; }

    /// <summary>
    /// Payer authentication transaction identifier is used to link the check
    /// enrollment and validate authentication messages. For Rupay, this field should be passed as request only for Resend OTP use case.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationTransactionId")]
    [MaxLength(26)]
    public string? AuthenticationTransactionId { get; init; }

    /// <summary>
    /// Payer authentication transaction identifier passed to link the validation and authorization calls.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationTransactionContextId")]
    [MaxLength(30)]
    public string? AuthenticationTransactionContextId { get; init; }

    /// <summary>
    /// Describes validity of OTP in minutes for incoming transaction.        .
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validityPeriod")]
    public int? ValidityPeriod { get; init; }

    /// <summary>
    /// Text provided by the ACS/Issuer to Cardholder during a Frictionless or Decoupled transaction.The Issuer can provide information to Cardholder.
    /// For example, “Additional authentication is needed for this transaction, please contact (Issuer Name) at xxx-xxx-xxxx.”.
    /// The Issuing Bank can optionally support this value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardholderMessage")]
    [MaxLength(128)]
    public string? CardholderMessage { get; init; }

    /// <summary>
    /// Unique identifier generated by the card-issuing bank for Visa, American Express, JCB, Diners Club, and
    /// Discover transactions after the customer is authenticated. The value is in base64. When you
    /// request the card authorization service, CyberSource automatically converts the value, not the field name,
    /// to the format required by your payment processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cavv")]
    [MaxLength(255)]
    public string? Cavv { get; init; }

    /// <summary>
    /// Field that is returned only when the CAVV is generated, which occurs when paresStatus
    /// contains the values Y (successful authentication) or A (attempted authentication). If
    /// you use the ATOS processor, send the value of this field in the <c>cavv_algorithm</c> request field of the
    /// authorization service. This field contains one of these values:
    /// - <c>2</c>: Visa, American Express, JCB, Diners Club, and Discover
    /// - <c>3</c>: Mastercard
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cavvAlgorithm")]
    [MaxLength(1)]
    public string? CavvAlgorithm { get; init; }

    /// <summary>
    /// An indicator as to why the transaction was canceled.
    /// Possible Values:
    /// <list type="bullet">
    ///   <item><description><c>01</c>: Cardholder selected Cancel.</description></item>
    ///   <item><description><c>02</c>: Reserved for future EMVCo use (values invalid until defined by EMVCo).</description></item>
    ///   <item><description><c>03</c>: Transaction Timed Out—Decoupled Authentication</description></item>
    ///   <item><description><c>04</c>: Transaction timed out at ACS—other timeouts</description></item>
    ///   <item><description><c>05</c>: Transaction Timed out at ACS - First CReq not received by ACS</description></item>
    ///   <item><description><c>06</c>: Transaction Error</description></item>
    ///   <item><description><c>07</c>: Unknown</description></item>
    ///   <item><description><c>08</c>: Transaction Timed Out at SDK</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeCancelCode")]
    [MaxLength(2)]
    public string? ChallengeCancelCode { get; init; }

    /// <summary>
    /// Indicates whether a challenge is required in order to complete authentication.
    /// <b>Note</b> Regional mandates might determine that a challenge is required.
    /// <para>
    /// Possible values:
    /// - <c>Y</c>: Challenge required
    /// - <c>N</c>: Challenge not required
    /// <b>Note</b>  Used by the Hybrid integration.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeRequired")]
    [MaxLength(1)]
    public string? ChallengeRequired { get; init; }

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
    /// The directory server error code indicating a problem with this transaction. Note - Max Length of this field is typically 3 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("directoryServerErrorCode")]
    public string? DirectoryServerErrorCode { get; init; }

    /// <summary>
    /// Directory server text and additional detail about the error for this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("directoryServerErrorDescription")]
    [MaxLength(4096)]
    public string? DirectoryServerErrorDescription { get; init; }

    /// <summary>
    /// Commerce indicator for cards not enrolled. This field contains one of these values:
    /// - <c>internet</c>: Card not enrolled, or card type not supported by payer authentication. No liability shift.
    /// - <c>js_attempted</c>: Card not enrolled, but attempt to authenticate is recorded. Liability shift.
    /// - <c>js_failure</c>: J/Secure directory service is not available. No liability shift.
    /// - <c>spa</c>: Mastercard card not enrolled in the SecureCode program. No liability shift.
    /// - <c>vbv_attempted</c>: Card not enrolled, but attempt to authenticate is recorded. Liability shift.
    /// - <c>vbv_failure</c>: For payment processor Barclays, Streamline, AIBMS, or FDC Germany, you receive
    /// this result if Visa’s directory service is not available. No liability shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ecommerceIndicator")]
    [MaxLength(255)]
    public string? EcommerceIndicator { get; init; }

    /// <summary>
    /// Note This field applies only to non-U.S-issued cards.
    /// <para>
    /// For enroll, Numeric electronic commerce indicator (ECI) returned only for Visa, American Express, JCB,
    /// Diners Club, and Discover transactions when the card is not enrolled. For more information, see
    /// "Interpreting the Reply," page 22.
    /// </para>
    /// <para>
    /// If you are not using the CyberSource payment services, you must send this value to your payment
    /// processor in the subsequent request for card authorization. This field contains one of these values:
    /// - <c>06</c>: The card can be enrolled. Liability shift.
    /// - <c>07</c>: The card cannot be enrolled. No liability shift.
    /// </para>
    /// <para>
    /// For validate, Numeric electronic commerce indicator (ECI) returned only for Visa, American Express, JCB,
    /// Diners Club, and Discover transactions. The field is absent when authentication fails.
    /// You must send this value to your payment processor in the subsequent request for card authorization.
    /// This field contains one of these values:
    /// - <c>05</c>: Successful authentication
    /// - <c>06</c>: Authentication attempted
    /// - <c>07</c>: Failed authentication (No response from the merchant because of a problem.)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eci")]
    public string? Eci { get; init; }

    /// <summary>
    /// ECI value that can be returned for Visa, Mastercard, American Express, JCB, Diners Club, and Discover.
    /// The field is absent when authentication fails. If your payment processor is Streamline, you must pass the
    /// value of this field instead of the value of <c>eci</c> or <c>ucafCollectionIndicator</c>.
    /// <para>
    /// This field can contain one of these values:
    /// - <c>01</c>: Authentication attempted (Mastercard)
    /// - <c>02</c>: Successful authentication (Mastercard)
    /// - <c>05</c>: Successful authentication (Visa, American Express, JCB, Diners Club, and Discover)
    /// - <c>06</c>: Authentication attempted (Visa, American Express, JCB, Diners Club, and Discover)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eciRaw")]
    public string? EciRaw { get; init; }

    /// <summary>
    /// This field describes the type of 3DS transaction flow that took place.  It can be one of three possible flows;
    /// CH - Challenge
    /// FR - Frictionless
    /// FD - Frictionless with delegation, (challenge not generated by the issuer but by the scheme on behalf of the issuer).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveAuthenticationType")]
    [MaxLength(2)]
    public string? EffectiveAuthenticationType { get; init; }

    /// <summary>
    /// Payer authentication exemption indicator for Carte Bancaire exemptions.
    /// This is used with unbundled authentication and authorizations calls, for example: "low fraud merchant program".
    /// The value returned in this field should be passed in the authorization request under the field -
    /// <c>consumerAuthenticationInformation.strongAuthentication.issuerInformation.exemptionDataRaw</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exemptionDataRaw")]
    [MaxLength(4)]
    public string? ExemptionDataRaw { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ivr")]
    public Ivr? Ivr { get; init; }

    /// <summary>
    /// The global score calculated by the CB scoring platform and returned to merchants.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkScore")]
    [MaxLength(2)]
    public string? NetworkScore { get; init; }

    /// <summary>
    /// Payer authentication request (PAReq) message that you need to forward to the ACS.
    /// The value can be very large. The value is in base64.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pareq")]
    public string? Pareq { get; init; }

    /// <summary>
    /// Raw result of the authentication check. If you are configured for Asia, Middle East, and Africa Gateway
    /// Processing, you need to send the value of this field in your authorization request. This field can contain
    /// one of these values:
    /// - <c>A</c>: Proof of authentication attempt was generated.
    /// - <c>N</c>: Customer failed or canceled authentication. Transaction denied.
    /// - <c>U</c>: Authentication not completed regardless of the reason.
    /// - <c>Y</c>: Customer was successfully authenticated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paresStatus")]
    public string? ParesStatus { get; init; }

    /// <summary>
    /// Date and time of the enrollment check combined with the VEReq and VERes elements. If you ever need
    /// to show proof of enrollment checking, you may need to parse the string for the information required by the
    /// payment card company. The value can be very large.
    /// For cards issued in the U.S. or Canada, Visa may require this data for specific merchant category codes.For cards not issued in the U.S. or Canada, your bank may require this data as proof of enrollment
    /// checking for any payer authentication transaction that you re-present because of a chargeback.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("proofXml")]
    public string? ProofXml { get; init; }

    /// <summary>
    /// Encrypted version of the card number used in the payer authentication request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("proxyPan")]
    public string? ProxyPan { get; init; }

    /// <summary>
    /// SDK unique transaction identifier that is generated on each new transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkTransactionId")]
    [MaxLength(36)]
    public string? SdkTransactionId { get; init; }

    /// <summary>
    /// Provides additional information as to why the PAResStatus has a specific value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signedParesStatusReason")]
    [MaxLength(2)]
    public string? SignedParesStatusReason { get; init; }

    /// <summary>
    /// This field contains the 3D Secure version that was used to process the transaction. For example: 2.2.0
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("specificationVersion")]
    public string? SpecificationVersion { get; init; }

    /// <summary>
    /// The fully qualified URL that the merchant uses to post a form to the cardholder in order to complete the Consumer Authentication transaction for the Cardinal Cruise API integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stepUpUrl")]
    [MaxLength(2048)]
    public string? StepUpUrl { get; init; }

    /// <summary>
    /// Unique transaction identifier assigned by the 3DS Server to identify a single transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSServerTransactionId")]
    [MaxLength(36)]
    public string? ThreeDsServerTransactionId { get; init; }

    /// <summary>
    /// AAV is a unique identifier generated by the card-issuing bank for Mastercard Identity Check
    /// transactions after the customer is authenticated. The value is in base64.
    /// Include the data in the card authorization request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ucafAuthenticationData")]
    public string? UcafAuthenticationData { get; init; }

    /// <summary>
    /// For enroll, Returned only for Mastercard transactions. Indicates that authentication is not required because the
    /// customer is not enrolled. Add the value of this field to the authorization field ucaf_collection_indicator.
    /// This field can contain these values: 0, 1.
    /// <para>
    /// For validate, Numeric electronic commerce indicator (ECI) returned only for Mastercard Identity Check
    /// transactions. The field is absent when authentication fails. You must send this value to your payment
    /// processor in the request for card authorization. This field contain one of these values:
    /// - <c>0</c>: Authentication data not collected, and customer authentication was not completed.
    /// - <c>1</c>: Authentication data not collected because customer authentication was not completed.
    /// - <c>2</c>: Authentication data collected because customer completed authentication.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ucafCollectionIndicator")]
    public string? UcafCollectionIndicator { get; init; }

    /// <summary>
    /// Result of the enrollment check. This field can contain one of these values:
    /// - <c>Y</c>: Card enrolled or can be enrolled; you must authenticate. Liability shift.
    /// - <c>N</c>: Card not enrolled; proceed with authorization. Liability shift.
    /// - <c>U</c>: Unable to authenticate regardless of the reason. No liability shift.
    /// <para>
    /// <b>Note</b> This field only applies to the Asia, Middle East, and Africa Gateway. If you are configured for
    /// this processor, you must send the value of this field in your authorization request.
    /// </para>
    /// <para>
    /// The following value can be returned if you are using rules-based Payer Authentication:
    /// - <c>B</c>: Indicates that authentication was bypassed.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("veresEnrolled")]
    public string? VeresEnrolled { get; init; }

    /// <summary>
    /// This data element will be populated by the system setting Whitelist Status. Possible Values: 01 - 3DS/ Server/ 02 – DS/03 - ACS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whiteListStatusSource")]
    [MaxLength(2)]
    public string? WhiteListStatusSource { get; init; }

    /// <summary>
    /// Transaction identifier generated by CyberSource for successful enrollment or validation checks.
    /// Use this value, which is in base64, to match an outgoing PAReq with an incoming PARes.
    /// CyberSource forwards the XID with the card authorization service to these payment processors in these cases:
    /// - Barclays
    /// - Streamline (when the <b>ecommerceIndicator</b><c>=spa</c>)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("xid")]
    public string? Xid { get; init; }

    /// <summary>
    /// The Directory Server Transaction ID is generated by the Mastercard Directory Server during the authentication transaction and passed back to the merchant with the authentication results.
    /// For Cybersource Through Visanet Gateway:
    /// The value for this field corresponds to the following data in the TC 33 capture file3: Record: CP01 TCR7, Position: 114-149, Field: MC AVV Verification—Directory Server Transaction ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("directoryServerTransactionId")]
    [MaxLength(36)]
    public string? DirectoryServerTransactionId { get; init; }

    /// <summary>
    /// Directory Server assigned ACS identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acsOperatorID")]
    public string? AcsOperatorId { get; init; }

    /// <summary>
    /// Unique identifier assigned by the EMVCo Secretariat upon Testing and Approval.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acsReferenceNumber")]
    [MaxLength(50)]
    public string? AcsReferenceNumber { get; init; }

    /// <summary>
    /// Decision on the Risk Assessment from Mastercard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idciDecision")]
    [MaxLength(20)]
    public string? IdciDecision { get; init; }

    /// <summary>
    /// ReasonCode from Mastercard
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idciReasonCode1")]
    [MaxLength(20)]
    public string? IdciReasonCode1 { get; init; }

    /// <summary>
    /// ReasonCode from Mastercard
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idciReasonCode2")]
    [MaxLength(20)]
    public string? IdciReasonCode2 { get; init; }

    /// <summary>
    /// Risk Assessment from Mastercard
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idciScore")]
    public int? IdciScore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
