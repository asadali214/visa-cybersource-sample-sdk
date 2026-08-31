using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Digital currency information for the order.
/// </summary>
public record DigitalCurrency
{
    /// <summary>
    /// Currently, Visa uses a broad "cryptocurrency" indicator. The enhancement will introduce specific values to identify the type of digital currency or coin involved, such as Central Bank Digital Currency (CBDC), stable coins, blockchain-native tokens, and Non-Fungible Tokens (NFTs). Values: - 1: CBDC_TOKENDEPOSIT - 2: STABLE_COIN - 3: BLOCKCHAIN_NATIVE_TOKEN - 4: NFT
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(10)]
    public string? Type { get; init; }

    /// <summary>
    /// Ramp is a platform where we can buy Digital currency, for example Coinbase. This value identifies the country where the Ramp provider is registered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rampProviderCountry")]
    [MaxLength(10)]
    public string? RampProviderCountry { get; init; }

    /// <summary>
    /// Affiliate is the platform for the digital currency transactions. The merchant provides the Affiliate country for transaction processing. The combination of affiliate country and ramp country helps to derive the foreign retail indicator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conversionAffiliate")]
    [MaxLength(10)]
    public string? ConversionAffiliate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
