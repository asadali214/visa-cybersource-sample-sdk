using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantDescriptor13
{
    /// <summary>
    /// Alternate contact information for your business,such as an email address or URL.
    /// This value might be displayed on the cardholder’s statement.
    /// When you do not include this value in your capture or credit request, the merchant URL from your CyberSource account is used.
    /// Important This value must consist of English characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alternateName")]
    [MaxLength(13)]
    public string? AlternateName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
