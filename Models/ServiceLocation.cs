using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ServiceLocation
{
    /// <summary>
    /// #### Visa Platform Connect
    /// <para>
    /// Merchant’s service location city name. When merchant provides services from a location other than the location identified as merchant location.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(20)]
    public string? Locality { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// <para>
    /// Merchant’s service location country subdivision code. When merchant provides services from a location other than the location identified as merchant location.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countrySubdivisionCode")]
    [MaxLength(9)]
    public string? CountrySubdivisionCode { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// <para>
    /// Merchant’s service location country code. When merchant provides services from a location other than the location identified as merchant location.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    [MaxLength(3)]
    public string? CountryCode { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// <para>
    /// Merchant’s service location postal code. When merchant provides services from a location other than the location identified as merchant location.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
