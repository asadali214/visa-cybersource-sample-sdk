using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Method12
{
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
