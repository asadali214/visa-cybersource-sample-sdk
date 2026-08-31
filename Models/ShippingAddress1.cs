using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ShippingAddress1
{
    /// <summary>
    /// Flag that specifies if the Shipping Address should be made the Customers default.
    /// Possible values:
    /// - true
    /// - false : (default)
    /// </summary>
    [JsonPropertyName("default")]
    public bool? Default { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
