using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AuthorizationOptions3
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
