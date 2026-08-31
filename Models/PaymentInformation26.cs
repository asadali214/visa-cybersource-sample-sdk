using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentInformation26
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentType")]
    public PaymentType19? PaymentType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenizedPaymentMethod")]
    public TokenizedPaymentMethod2? TokenizedPaymentMethod { get; init; }

    /// <summary>
    /// Indicates the industry type. Possible Values:
    /// - “Events”
    /// - "Ticketing"
    /// - "Fuel"
    /// - "GAMING"
    /// - "DIGITAL GOODS"
    /// - "TELCO"
    /// - "Token Service Providers"
    /// - "Gambling"
    /// - "CFDs"
    /// - "car rental"
    /// - "hotel"
    /// - "transportation"
    /// - "travel package"
    /// - "Cruise Line"
    /// - "P2P"
    /// - "Retail"
    /// - "Food"
    /// - "Groceries"
    /// - "Ride Sharing"
    /// - "Taxi"
    /// - "Remittance"
    /// - "Crypto"
    /// - "Marketplaces"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industryType")]
    public string? IndustryType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eWallet")]
    public EWallet13? EWallet { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
