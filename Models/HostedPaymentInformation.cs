using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record HostedPaymentInformation
{
    /// <summary>
    /// The title of the hosted payment page, displayed in the browser’s tab. If
    /// not set, defaults to the title set in the merchant configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hostName")]
    [MaxLength(255)]
    public string? HostName { get; init; }

    /// <summary>
    /// URL of the merchant’s logo to be displayed in Klarna’s hosted payment
    /// page. If not set, defaults to the logo set in the merchant configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    [MaxLength(255)]
    public string? IpAddress { get; init; }

    /// <summary>
    /// The images to be used as background on Klarna’s payment page (the
    /// image best matching the resolution will be used). This is a pass-through
    /// field. Check Klarna’s documentation for more information about the correct
    /// format. This value can also be set in the merchant configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userAgent")]
    public UserAgent? UserAgent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
