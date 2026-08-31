using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record OrderInformation43
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountDetails")]
    public AmountDetails41? AmountDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billTo")]
    public BillTo69? BillTo { get; init; }

    /// <summary>
    /// #### Visa Platform Connect :
    /// This API will contain the Flag that specifies whether the payment is for the purchase of cryptocurrency.
    /// Additional values to add :
    /// This API will contain the Flag that specifies whether the payment is for the purchase of cryptocurrency.
    /// valid values are
    /// - Y/y, true
    /// - N/n, false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isCryptocurrencyPurchase")]
    public string? IsCryptocurrencyPurchase { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
