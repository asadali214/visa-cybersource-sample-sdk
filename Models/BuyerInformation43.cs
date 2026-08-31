using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Customer information used during Follow-On Transaction.
/// </summary>
public record BuyerInformation43
{
    /// <summary>
    /// Merchant identifier for the customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantCustomerID")]
    [MaxLength(100)]
    public string? MerchantCustomerId { get; init; }

    /// <summary>
    /// Customer's primary email address, including the full domain name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(255)]
    public string? Email { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
