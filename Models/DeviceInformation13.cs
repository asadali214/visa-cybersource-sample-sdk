using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record DeviceInformation13
{
    /// <summary>
    /// Whether the customer’s browser accepts cookies. This field can contain one of the following values:
    /// - <c>yes</c>: The customer’s browser accepts cookies.
    /// - <c>no</c>: The customer’s browser does not accept cookies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cookiesAccepted")]
    public string? CookiesAccepted { get; init; }

    /// <summary>
    /// IP address of the customer.
    /// <para>
    /// #### Used by
    /// <b>Authorization, Capture, and Credit</b>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    [MaxLength(45)]
    public string? IpAddress { get; init; }

    /// <summary>
    /// DNS resolved hostname from <c>ipAddress</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hostName")]
    [MaxLength(60)]
    public string? HostName { get; init; }

    /// <summary>
    /// Field that contains the session ID that you send to Decision Manager to obtain the device fingerprint
    /// information. The string can contain uppercase and lowercase letters, digits, hyphen (-), and
    /// underscore (_). However, do not use the same uppercase and lowercase letters to indicate
    /// different session IDs.
    /// <para>
    /// The session ID must be unique for each merchant ID. You can use any string that you are already
    /// generating, such as an order number or web session ID.
    /// </para>
    /// <para>
    /// The session ID must be unique for each page load, regardless of an individual’s web session ID.
    /// If a user navigates to a profiled page and is assigned a web session, navigates away from the
    /// profiled page, then navigates back to the profiled page, the generated session ID should be different
    /// and unique. You may use a web session ID, but it is preferable to use an application GUID (Globally
    /// Unique Identifier). This measure ensures that a unique ID is generated every time the page is
    /// loaded, even if it is the same user reloading the page.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fingerprintSessionId")]
    public string? FingerprintSessionId { get; init; }

    /// <summary>
    /// Boolean that indicates whether request contains the device fingerprint information.
    /// Values:
    /// - <c>true</c>: Use raw fingerprintSessionId when looking up device details.
    /// - <c>false</c> (default): Use merchant id + fingerprintSessionId as the session id for Device detail collection.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useRawFingerprintSessionId")]
    public bool? UseRawFingerprintSessionId { get; init; }

    /// <summary>
    /// Email address set in the customer’s browser, which may differ from customer email.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserEmail")]
    public string? HttpBrowserEmail { get; init; }

    /// <summary>
    /// Customer’s browser as identified from the HTTP header data. For example, <c>Mozilla</c> is the value that identifies
    /// the Netscape browser.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userAgent")]
    [MaxLength(40)]
    public string? UserAgent { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rawData")]
    public IReadOnlyList<RawDatum>? RawData { get; init; }

    /// <summary>
    /// Value of the Accept header sent by the customer’s web browser.
    /// <b>Note</b> If the customer’s browser provides a value, you must include it in your request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpAcceptBrowserValue")]
    [MaxLength(255)]
    public string? HttpAcceptBrowserValue { get; init; }

    /// <summary>
    /// The exact content of the HTTP accept header.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpAcceptContent")]
    [MaxLength(256)]
    public string? HttpAcceptContent { get; init; }

    /// <summary>
    /// Value represents the browser language as defined in IETF BCP47.
    /// Example:en-US, refer  https://en.wikipedia.org/wiki/IETF_language_tag for more details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserLanguage")]
    [MaxLength(8)]
    public string? HttpBrowserLanguage { get; init; }

    /// <summary>
    /// A Boolean value that represents the ability of the cardholder browser to execute Java.
    /// Value is returned from the navigator.javaEnabled property. Possible Values:True/False
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserJavaEnabled")]
    public bool? HttpBrowserJavaEnabled { get; init; }

    /// <summary>
    /// A Boolean value that represents the ability of the cardholder browser to execute JavaScript. Possible Values:True/False.
    /// <b>Note</b>: Merchants should be able to know the values from fingerprint details of cardholder's browser.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserJavaScriptEnabled")]
    public bool? HttpBrowserJavaScriptEnabled { get; init; }

    /// <summary>
    /// Value represents the bit depth of the color palette for displaying images, in bits per pixel.
    /// Example : 24, refer https://en.wikipedia.org/wiki/Color_depth for more details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserColorDepth")]
    [MaxLength(2)]
    public string? HttpBrowserColorDepth { get; init; }

    /// <summary>
    /// Total height of the Cardholder's scree in pixels, example: 864.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserScreenHeight")]
    [MaxLength(6)]
    public string? HttpBrowserScreenHeight { get; init; }

    /// <summary>
    /// Total width of the cardholder's screen in pixels. Example: 1536.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserScreenWidth")]
    [MaxLength(6)]
    public string? HttpBrowserScreenWidth { get; init; }

    /// <summary>
    /// Time difference between UTC time and the cardholder browser local time, in minutes, Example:300
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserTimeDifference")]
    [MaxLength(5)]
    public string? HttpBrowserTimeDifference { get; init; }

    /// <summary>
    /// Value of the User-Agent header sent by the customer’s web browser.
    /// Note If the customer’s browser provides a value, you must include it in your request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userAgentBrowserValue")]
    [MaxLength(255)]
    public string? UserAgentBrowserValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
