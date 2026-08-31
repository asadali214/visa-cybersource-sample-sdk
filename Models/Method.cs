using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Method
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

    /// <summary>
    /// The payment channel that facilitates the transactions. This parameter can be used if the payment channels are listed on the merchant’s site, and the payment channel is known.
    /// <para>
    /// Possible Values:
    /// </para>
    /// <para>
    /// #### Via PPRO
    /// - <c>alfaVa</c>
    /// - <c>kredivo</c>
    /// - <c>consumerBarCode</c>
    /// - <c>merchantQrCode</c>
    /// - <c>dokuWallet</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
