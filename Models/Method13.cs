using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Method13
{
    /// <summary>
    /// Identifier for the payment type.
    /// Possible Values:
    ///   - SENTENIAL
    ///   - PAYPAL
    /// #### SEPA/BACS
    /// Required for mandates services
    /// #### Paypal
    /// Required for billing agreements
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
