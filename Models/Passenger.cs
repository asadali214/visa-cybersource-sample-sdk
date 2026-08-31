using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains travel-related passenger details used by DM service only.
/// </summary>
public record Passenger
{
    /// <summary>
    /// Passenger classification associated with the price of the ticket. You can use one of the following values:
    /// - <c>ADT</c>: Adult
    /// - <c>CNN</c>: Child
    /// - <c>INF</c>: Infant
    /// - <c>YTH</c>: Youth
    /// - <c>STU</c>: Student
    /// - <c>SCR</c>: Senior Citizen
    /// - <c>MIL</c>: Military
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(32)]
    public string? Type { get; init; }

    /// <summary>
    /// Your company's passenger classification, such as with a frequent flyer program. In this case, you might use
    /// values such as <c>standard</c>, <c>gold</c>, or <c>platinum</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    [MaxLength(32)]
    public string? Status { get; init; }

    /// <summary>
    /// Passenger's phone number. If the order is from outside the U.S., CyberSource recommends that you include
    /// the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    [MaxLength(15)]
    public string? Phone { get; init; }

    /// <summary>
    /// Passenger's first name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(60)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Passenger's last name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(60)]
    public string? LastName { get; init; }

    /// <summary>
    /// ID of the passenger to whom the ticket was issued. For example, you can use this field for the frequent flyer
    /// number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(40)]
    public string? Id { get; init; }

    /// <summary>
    /// Passenger's email address, including the full domain name, such as jdoe@example.com.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(255)]
    public string? Email { get; init; }

    /// <summary>
    /// Passenger's nationality country. Use the two character <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    [MaxLength(2)]
    public string? Nationality { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
