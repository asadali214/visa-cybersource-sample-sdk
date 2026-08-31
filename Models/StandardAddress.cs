using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record StandardAddress
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    public Address1? Address1 { get; init; }

    /// <summary>
    /// Second line of the standardized address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(255)]
    public string? Address2 { get; init; }

    /// <summary>
    /// Third line of the standardized address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address3")]
    [MaxLength(255)]
    public string? Address3 { get; init; }

    /// <summary>
    /// Fourth line of the standardized address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address4")]
    [MaxLength(255)]
    public string? Address4 { get; init; }

    /// <summary>
    /// Standardized city name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(255)]
    public string? Locality { get; init; }

    /// <summary>
    /// U.S. county if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("county")]
    [MaxLength(255)]
    public string? County { get; init; }

    /// <summary>
    /// Standardized country name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(255)]
    public string? Country { get; init; }

    /// <summary>
    /// Standardized city, state or province, and ZIP +4 code or postal code line.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("csz")]
    [MaxLength(255)]
    public string? Csz { get; init; }

    /// <summary>
    /// Standardized two-character ISO country code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isoCountry")]
    [MaxLength(255)]
    public string? IsoCountry { get; init; }

    /// <summary>
    /// U.S.P.S. standardized state or province abbreviation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(255)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Standardized U.S. ZIP + 4 postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(255)]
    public string? PostalCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
