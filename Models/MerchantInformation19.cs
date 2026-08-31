using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantInformation19
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDescriptor")]
    public MerchantDescriptor34? MerchantDescriptor { get; init; }

    /// <summary>
    /// Your company’s name as you want it to appear to the customer in the issuing bank’s authentication form.
    /// This value overrides the value specified by your merchant bank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantName")]
    [MaxLength(25)]
    public string? MerchantName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
