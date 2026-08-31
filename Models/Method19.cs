using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Method19
{
    /// <summary>
    /// A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal, 7Eleven, alfamart, etc
    /// #### Via PayPal ptsV2CreateOrderPost201Response
    ///   - 'payPal'
    ///   - 'venmo'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
