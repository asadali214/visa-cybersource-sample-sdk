using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record DeviceInformation3
{
    /// <summary>
    /// DNS resolved hostname from <c>ipAddress</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hostName")]
    [MaxLength(60)]
    public string? HostName { get; init; }

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
    /// Customer’s browser as identified from the HTTP header data. For example, <c>Mozilla</c> is the value that identifies
    /// the Netscape browser.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userAgent")]
    [MaxLength(40)]
    public string? UserAgent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
