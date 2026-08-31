using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RentalAddress
{
    /// <summary>
    /// City in which the auto was rented.
    /// <para>
    /// For authorizations, this field is supported for Visa, MasterCard, and American Express.
    /// </para>
    /// <para>
    /// For captures, this field is supported only for American Express.
    /// </para>
    /// <para>
    /// For all other card types, this field is ignored.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    [MaxLength(25)]
    public string? City { get; init; }

    /// <summary>
    /// State in which the auto was rented. Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf">State, Province, and Territory Codes for the United States and Canada</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    [MaxLength(3)]
    public string? State { get; init; }

    /// <summary>
    /// Country where the auto was rented. Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes.</see>
    /// This field is supported only for American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(3)]
    public string? Country { get; init; }

    /// <summary>
    /// The agency code, address, phone number, etc., used to identify the location where the vehicle was rented.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locationId")]
    [MaxLength(10)]
    public string? LocationId { get; init; }

    /// <summary>
    /// Address from where the vehicle was rented.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(13)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Address from where the vehicle was rented.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(13)]
    public string? Address2 { get; init; }

    /// <summary>
    /// When merchant wants to send the rental address's postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(50)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// This field contains the location where a taxi passenger was picked up or where an auto rental vehicle was picked up. In most cases, this is the rental agency's business name that appears on the storefront and/or customer receipts, commonly referred to as the DBA (Doing Business As) name. However, if the vehicle was picked up at another location (e.g., a hotel,auto dealership, repair shop, etc.), the name of that location should be used. This entry must be easily recognized by the Cardmember to avoid unnecessary inquiries. If the name is more than 38  characters, use proper and meaningful abbreviation, when possible.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    [MaxLength(38)]
    public string? Location { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
