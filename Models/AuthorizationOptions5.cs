using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AuthorizationOptions5
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initiator")]
    public Initiator34? Initiator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
