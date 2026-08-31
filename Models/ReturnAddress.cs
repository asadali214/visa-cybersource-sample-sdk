using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ReturnAddress
{
    /// <summary>
    /// City where the auto was returned to the rental agency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    [MaxLength(25)]
    public string? City { get; init; }

    /// <summary>
    /// State in which the auto was returned to the rental agency. Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf">State, Province, and Territory Codes for the United States and Canada</see>.
    /// <para>
    /// For authorizations, this field is supported for Visa, MasterCard, and American Express.
    /// </para>
    /// <para>
    /// For captures, this field is supported only for MasterCard and American Express.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    [MaxLength(3)]
    public string? State { get; init; }

    /// <summary>
    /// Country where the auto was returned to the rental agency. Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(3)]
    public string? Country { get; init; }

    /// <summary>
    /// Code, address, phone number, etc. used to identify the location of the auto rental return.
    /// This field is supported only for MasterCard and American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locationId")]
    [MaxLength(10)]
    public string? LocationId { get; init; }

    /// <summary>
    /// When merchant wants to send the rental address's street address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(50)]
    public string? Address1 { get; init; }

    /// <summary>
    /// When merchant wants to send the return address's postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(50)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// This field contains the location where the taxi passenger was dropped off or where the auto rental vehicle was returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    [MaxLength(38)]
    public string? Location { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
