using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RewardPointsDetails
{
    /// <summary>
    /// Loyalty points total balance before redemption.
    /// For Example: Points, such as 100
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pointsBeforeRedemption")]
    [MaxLength(10)]
    public string? PointsBeforeRedemption { get; init; }

    /// <summary>
    /// The total value of loyalty points before redemption in the default currency. Max characters is 12 excluding the "." symbol
    /// For Example: Points, such as 20.00
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pointsValueBeforeRedemption")]
    [MaxLength(12)]
    public string? PointsValueBeforeRedemption { get; init; }

    /// <summary>
    /// Number of loyalty points that were redeemed.
    /// For Example: Points, such as 100
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pointsRedeemed")]
    [MaxLength(10)]
    public string? PointsRedeemed { get; init; }

    /// <summary>
    /// The value of the loyalty points that were redeemed in the default currency. Max characters is 12 excluding the "." symbol
    /// For Example: Points, such as 100.00
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pointsValueRedeemed")]
    [MaxLength(12)]
    public string? PointsValueRedeemed { get; init; }

    /// <summary>
    /// Loyalty Points remaining total balance after redemption.
    /// For Example: Points, such as 20.00
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pointsAfterRedemption")]
    [MaxLength(10)]
    public string? PointsAfterRedemption { get; init; }

    /// <summary>
    /// The value of the remaining loyalty points after redumption in the default currency. Max characters is 12 excluding the "." symbol
    /// For Example: Points, such as 20.00
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pointsValueAfterRedemption")]
    [MaxLength(12)]
    public string? PointsValueAfterRedemption { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
