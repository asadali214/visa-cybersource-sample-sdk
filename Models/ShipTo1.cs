using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ShipTo1
{
    /// <summary>
    /// First name of the recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstname")]
    [MaxLength(60)]
    public string? Firstname { get; init; }

    /// <summary>
    /// Last name of the recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastname")]
    [MaxLength(60)]
    public string? Lastname { get; init; }

    /// <summary>
    /// First line of the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(100)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Second line of the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(100)]
    public string? Address2 { get; init; }

    /// <summary>
    /// City of the shipping address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(50)]
    public string? Locality { get; init; }

    /// <summary>
    /// State or province of shipping address. This is a State, Province, and Territory Codes for the United States and Canada.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(40)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Postal code of the shipping address. Consists of 5 to 9 digits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(20)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Country of shipping address. This is a two-character ISO Standard Country Codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

    /// <summary>
    /// Phone number of the recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(20)]
    public string? PhoneNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
