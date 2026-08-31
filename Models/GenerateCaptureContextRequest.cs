using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// This is a server-to-server API request to generate the capture context that can be used to initiate an instance of Microform on an acceptance page.   The capture context is a digitally signed JWT that provides authentication, one-time keys, and the target origin to the Microform Integration application.
/// </summary>
public record GenerateCaptureContextRequest
{
    /// <summary>
    /// Specify the version of Microform that you want to use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; init; }

    /// <summary>
    /// The <see href="https://developer.mozilla.org/en-US/docs/Glossary/Origin">target origin</see> of the website on which you will be launching Microform is defined by the scheme (protocol), hostname (domain) and port number (if used).
    /// <para>
    /// You must use https://hostname (unless you use http://localhost)
    /// Wildcards are NOT supported.  Ensure that subdomains are included.
    /// Any valid top-level domain is supported (e.g. .com, .co.uk, .gov.br etc)
    /// </para>
    /// <para>
    /// Examples:
    ///   - https://example.com
    ///   - https://subdomain.example.com
    ///   - https://example.com:8080&lt;br&gt;&lt;br&gt;
    /// </para>
    /// <para>
    /// If you are embedding within multiple nested iframes you need to specify the origins of all the browser contexts used, for example:
    /// </para>
    /// <para>
    ///   targetOrigins: [
    ///     "https://example.com",
    ///     "https://basket.example.com",
    ///     "https://ecom.example.com"
    ///   ]&lt;br&gt;&lt;br&gt;
    /// </para>
    /// <para>
    /// You can supply up to nine origins within the targetOrigins field for nested iframes.
    /// If the list of origins exceeds five ensure that you:
    ///   - Compare the list of origins in the v2/sessions targetOrigins field against the location.ancestorOrigins of the browser.
    ///   - Ensure that the count of origins and their content matches in both.  If any origins are absent or mismatched, the system will prevent Microform from loading and display a client-side error message.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetOrigins")]
    public IReadOnlyList<string>? TargetOrigins { get; init; }

    /// <summary>
    /// The list of card networks you want to use for this Microform transaction.
    /// <para>
    /// Microform currently supports the following card networks:
    ///     - VISA
    ///     - MASTERCARD
    ///     - AMEX
    ///     - CARNET
    ///     - CARTESBANCAIRES
    ///     - CUP
    ///     - DINERSCLUB
    ///     - DISCOVER
    ///     - EFTPOS
    ///     - ELO
    ///     - JAYWAN
    ///     - JCB
    ///     - JCREW
    ///     - KCP
    ///     - MADA
    ///     - MAESTRO
    ///     - MEEZA
    ///     - PAYPAK
    ///     - UATP
    /// </para>
    /// <para>
    /// <b>Important:</b>
    ///   - When integrating Microform (Card) at least one card network should be specified in the allowedCardNetworks field in the capture context request.
    ///   - When integrating Microform (ACH/eCheck) the allowedCardNetworks field is not required in the capture context request.
    ///   - When integrating both Microform (Card) and Microform (ACH/eCheck) at least one card network should be specified in the allowedCardNetworks field in the capture context request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedCardNetworks")]
    public IReadOnlyList<string>? AllowedCardNetworks { get; init; }

    /// <summary>
    /// The payment types that are allowed for the merchant.
    /// <para>
    /// Possible values when launching Microform:
    /// - CARD
    /// - CHECK &lt;br&gt;&lt;br&gt;
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedPaymentTypes")]
    public IReadOnlyList<string>? AllowedPaymentTypes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transientTokenResponseOptions")]
    public TransientTokenResponseOptions? TransientTokenResponseOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
