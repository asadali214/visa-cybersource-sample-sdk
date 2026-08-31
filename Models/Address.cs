using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains address information related to the order
/// </summary>
public record Address
{
    /// <summary>
    /// First line of the street address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(60)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Second line of the street address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(60)]
    public string? Address2 { get; init; }

    /// <summary>
    /// City of the street address.
    /// Required when adding the address to a list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(50)]
    public string? Locality { get; init; }

    /// <summary>
    /// Country of the street address. Use the two-character codes located in the Support Center.
    /// Required if address1 is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

    /// <summary>
    /// State, province, or territory of the street address. Use the two-character codes located in the Support Center.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(2)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Postal code of the street address. Required when adding the address to a list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
