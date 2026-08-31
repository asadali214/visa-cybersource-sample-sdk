using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AuthorizationOptions4
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
