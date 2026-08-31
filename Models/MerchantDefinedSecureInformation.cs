using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// The object containing the secure data that the merchant defines.
/// </summary>
public record MerchantDefinedSecureInformation
{
    /// <summary>
    /// The value you assign for your merchant-secure data field 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secure1")]
    [MaxLength(2048)]
    public string? Secure1 { get; init; }

    /// <summary>
    /// The value you assign for your merchant-secure data field 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secure2")]
    [MaxLength(2048)]
    public string? Secure2 { get; init; }

    /// <summary>
    /// The value you assign for your merchant-secure data field 3.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secure3")]
    [MaxLength(2048)]
    public string? Secure3 { get; init; }

    /// <summary>
    /// The value you assign for your merchant-secure data field 4.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secure4")]
    [MaxLength(2048)]
    public string? Secure4 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
