using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AccountHistory
{
    /// <summary>
    /// Applicable when this is not a guest account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstUseOfShippingAddress")]
    public bool? FirstUseOfShippingAddress { get; init; }

    /// <summary>
    /// Date when the shipping address for this transaction was first used.
    /// Recommended for Discover ProtectBuy.
    /// If <c>firstUseOfShippingAddress</c> is false and not a guest account, then this date is entered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAddressUsageDate")]
    [MaxLength(10)]
    public string? ShippingAddressUsageDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
