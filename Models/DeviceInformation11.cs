using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record DeviceInformation11
{
    /// <summary>
    /// Platform type.
    /// <para>
    /// Possible Values:
    ///   - iOS: iOS app
    ///   - ANDROID: Android app
    ///   - WINDOWS: Windows app
    ///   - WEB: Browser-based app
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformType")]
    public string? PlatformType { get; init; }

    /// <summary>
    /// IP address of the customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    [MaxLength(45)]
    [RegularExpression("[0-9A-Fa-f.]")]
    public string? IpAddress { get; init; }

    /// <summary>
    /// The exact content of the HTTP accept header.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpAcceptContent")]
    [MaxLength(2048)]
    [RegularExpression("[A-Za-z0-9]+")]
    public string? HttpAcceptContent { get; init; }

    /// <summary>
    /// Value represents the browser language as defined in IETF BCP47.
    /// Example:en-US, refer  https://en.wikipedia.org/wiki/IETF_language_tag for more details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserLanguage")]
    [MaxLength(8)]
    [RegularExpression("[A-Za-z0-9]+")]
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
    [RegularExpression("[0-9]+")]
    public string? HttpBrowserColorDepth { get; init; }

    /// <summary>
    /// Total height of the Cardholder's screen in pixels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserScreenHeight")]
    [MaxLength(6)]
    [RegularExpression("[0-9]+")]
    public string? HttpBrowserScreenHeight { get; init; }

    /// <summary>
    /// Total width of the cardholder's screen in pixels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserScreenWidth")]
    [MaxLength(6)]
    [RegularExpression("[0-9]+")]
    public string? HttpBrowserScreenWidth { get; init; }

    /// <summary>
    /// Time difference between UTC time and the cardholder browser local time, in minutes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpBrowserTimeDifference")]
    [MaxLength(5)]
    [RegularExpression("[0-9]+")]
    public string? HttpBrowserTimeDifference { get; init; }

    /// <summary>
    /// Value of the User-Agent header sent by the customer’s web browser.
    /// Note If the customer’s browser provides a value, you must include it in your request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userAgentBrowserValue")]
    [MaxLength(2048)]
    [RegularExpression("[A-Za-z0-9]+")]
    public string? UserAgentBrowserValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
