using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Method2
{
    /// <summary>
    /// A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal, 7Eleven, alfamart, bofaPayByBank, payToPayByBank, etc
    /// <para>
    /// For Japan Payment Processing Valid Values:
    /// - 1 Banking Data
    /// - 2 Authorization Data
    /// </para>
    /// <para>
    /// #### Via KCP
    /// - <c>KCP</c> : Local Card, Bank Transfer and Carrier Billing.
    /// - <c>PAYCO</c>
    /// - <c>KAKAOPAY</c>
    /// - <c>NAVERPAY</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
