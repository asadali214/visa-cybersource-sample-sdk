using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantInformation7
{
    /// <summary>
    /// The value for this field is a four-digit number that the payment card industry uses to classify
    /// merchants into market segments. A payment card company assigned one or more of these values to your business when you started
    /// accepting the payment card company's cards. When you do not include this field in your request, Cybersource uses the value in your
    /// Cybersource account. Use this field only for clearing with your acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryCode")]
    [MaxLength(4)]
    public string? CategoryCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
