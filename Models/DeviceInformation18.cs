using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record DeviceInformation18
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

    /// <summary>
    /// DNS resolved hostname from <c>ipAddress</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hostName")]
    [MaxLength(60)]
    public string? HostName { get; init; }

    /// <summary>
    /// Whether the customer’s browser accepts cookies. This field can contain one of the following values:
    /// - <c>yes</c>: The customer’s browser accepts cookies.
    /// - <c>no</c>: The customer’s browser does not accept cookies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cookiesAccepted")]
    public string? CookiesAccepted { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
