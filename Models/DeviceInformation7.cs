using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record DeviceInformation7
{
    /// <summary>
    /// Value of the Accept header sent by the customer’s web browser.
    /// <b>Note</b> If the customer’s browser provides a value, you must include it in your request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpAcceptBrowserValue")]
    [MaxLength(255)]
    public string? HttpAcceptBrowserValue { get; init; }

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
