using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record SellerProtection
{
    /// <summary>
    /// The level of seller protection in force for the transaction.
    /// Possible values:
    /// - <c>ELIGIBLE</c>
    /// - <c>PARTIALLY_ELIGIBLE</c>
    /// - <c>INELIGIBLE</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eligibilty")]
    [MaxLength(60)]
    public string? Eligibilty { get; init; }

    /// <summary>
    /// The kind of seller protection in force for the transaction. This field is returned only when the protection eligibility is set to ELIGIBLE or PARTIALLY_ELIGIBLE.
    /// Possible values:
    /// - <c>ITEM_NOT_RECEIVED_ELIGIBLE: Sellers are protected against claims for items not received.</c>
    /// - <c>UNAUTHORIZED_PAYMENT_ELIGIBLE: Sellers are protected against claims for unauthorized payments.One or both values can be returned.</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(60)]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
