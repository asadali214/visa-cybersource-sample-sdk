using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AutoRental5
{
    /// <summary>
    /// Merchant to send their auto rental company name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("companyName")]
    [MaxLength(50)]
    public string? CompanyName { get; init; }

    /// <summary>
    /// When merchant wants to send the affiliate name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affiliateName")]
    [MaxLength(50)]
    public string? AffiliateName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rentalAddress")]
    public RentalAddress? RentalAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnAddress")]
    public ReturnAddress? ReturnAddress { get; init; }

    /// <summary>
    /// Date/time the auto was returned to the rental agency.
    /// Format: ``yyyy-MM-dd HH-mm-ss z``
    /// This field is supported for Visa, MasterCard, and American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnDateTime")]
    [MaxLength(21)]
    public string? ReturnDateTime { get; init; }

    /// <summary>
    /// Date/time the auto was picked up from the rental agency.
    /// Format: <c>yyyy-MM-dd HH-mm-ss z</c>
    /// This field is supported for Visa, MasterCard, and American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rentalDateTime")]
    [MaxLength(21)]
    public string? RentalDateTime { get; init; }

    /// <summary>
    /// Name of the individual making the rental agreement.
    /// <para>
    /// Valid data lengths by card:
    /// </para>
    /// <para>
    /// |Card Specific Validation|VISA|MasterCard|Discover|AMEX|
    /// |--- |--- |--- |--- |
    /// | Filed Length| 40| 40| 29| 26|
    /// | Field Type| AN| ANS| AN| AN|
    /// | M/O/C| O| M| M| M|
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerName")]
    [MaxLength(40)]
    public string? CustomerName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
