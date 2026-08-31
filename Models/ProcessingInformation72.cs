using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains processing information, such as collection details.
/// </summary>
public record ProcessingInformation72
{
    /// <summary>
    /// Collect the payers phone number during the payment.
    /// </summary>
    [JsonPropertyName("requestPhone")]
    public bool? RequestPhone { get; init; } = false;

    /// <summary>
    /// Collect the payers shipping address during the payment.
    /// </summary>
    [JsonPropertyName("requestShipping")]
    public bool? RequestShipping { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
