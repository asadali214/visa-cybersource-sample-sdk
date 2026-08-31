using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TicketIssuer
{
    /// <summary>
    /// IATA2 airline code.
    /// Format: English characters only.
    /// Required for Mastercard; optional for all other card types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(4)]
    public string? Code { get; init; }

    /// <summary>
    /// Name of the ticket issuer. If you do not include this field,
    /// CyberSource uses the value for your merchant name that is in the CyberSource merchant configuration database.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(20)]
    public string? Name { get; init; }

    /// <summary>
    /// Address of the company issuing the ticket.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    [MaxLength(16)]
    public string? Address { get; init; }

    /// <summary>
    /// City in which the transaction occurred.
    /// If the name of the city exceeds 18 characters, use meaningful abbreviations.
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(18)]
    public string? Locality { get; init; }

    /// <summary>
    /// State in which transaction occured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(18)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Zip code of the city in which transaction occured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(15)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Country in which transaction occured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(18)]
    public string? Country { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
