using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record EWallet5
{
    /// <summary>
    /// Valid Values:
    /// - CreditCard
    /// - BankTransfer
    /// - MobileTransfer
    /// - KakaoMoney
    /// - NaverPayPoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(30)]
    public string? Name { get; init; }

    /// <summary>
    /// Valid Values:
    /// - PAYCO
    /// - Kakaopay
    /// - NaverPay
    /// - SSG Pay
    /// - L.Pay
    /// - Apple Pay
    /// - TOSS Pay
    /// - Samsung Pay
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    [MaxLength(30)]
    public string? FundingSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
