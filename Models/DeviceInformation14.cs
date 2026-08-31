using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record DeviceInformation14
{
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
    [JsonPropertyName("httpAcceptContent")]
    [MaxLength(256)]
    public required string HttpAcceptContent { get; init; }

    /// <summary>
    /// Value represents the browser language as defined in IETF BCP47.
    /// Example:en-US, refer  https://en.wikipedia.org/wiki/IETF_language_tag for more details.
    /// </summary>
    [JsonPropertyName("httpBrowserLanguage")]
    [MaxLength(8)]
    public required string HttpBrowserLanguage { get; init; }

    /// <summary>
    /// A Boolean value that represents the ability of the cardholder browser to execute Java.
    /// Value is returned from the navigator.javaEnabled property. Possible Values:True/False
    /// </summary>
    [JsonPropertyName("httpBrowserJavaEnabled")]
    public required bool HttpBrowserJavaEnabled { get; init; }

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
    [JsonPropertyName("httpBrowserColorDepth")]
    [MaxLength(2)]
    public required string HttpBrowserColorDepth { get; init; }

    /// <summary>
    /// Total height of the Cardholder's scree in pixels, example: 864.
    /// </summary>
    [JsonPropertyName("httpBrowserScreenHeight")]
    [MaxLength(6)]
    public required string HttpBrowserScreenHeight { get; init; }

    /// <summary>
    /// Total width of the cardholder's screen in pixels. Example: 1536.
    /// </summary>
    [JsonPropertyName("httpBrowserScreenWidth")]
    [MaxLength(6)]
    public required string HttpBrowserScreenWidth { get; init; }

    /// <summary>
    /// Time difference between UTC time and the cardholder browser local time, in minutes, Example:300
    /// </summary>
    [JsonPropertyName("httpBrowserTimeDifference")]
    [MaxLength(5)]
    public required string HttpBrowserTimeDifference { get; init; }

    /// <summary>
    /// Value of the User-Agent header sent by the customer’s web browser.
    /// Note If the customer’s browser provides a value, you must include it in your request.
    /// </summary>
    [JsonPropertyName("userAgentBrowserValue")]
    [MaxLength(255)]
    public required string UserAgentBrowserValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
