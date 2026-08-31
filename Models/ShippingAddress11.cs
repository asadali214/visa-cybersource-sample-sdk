using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ShippingAddress11
{
    /// <summary>
    /// Link to the Customers Shipping Addresses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
