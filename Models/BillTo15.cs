using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BillTo15
{
    /// <summary>
    /// Customer’s first name. This name must be the same as the name on the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(60)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Customer’s last name. This name must be the same as the name on the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(60)]
    public string? LastName { get; init; }

    /// <summary>
    /// Name of the customer’s company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    [MaxLength(60)]
    public string? Company { get; init; }

    /// <summary>
    /// Payment card billing street address as it appears on the credit card issuer’s records.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(60)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Additional address information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(60)]
    public string? Address2 { get; init; }

    /// <summary>
    /// Payment card billing city.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(50)]
    public string? Locality { get; init; }

    /// <summary>
    /// State or province of the billing address. Use the State, Province, and Territory Codes for the United States
    /// and Canada.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(20)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Postal code for the billing address. The postal code must consist of 5 to 9 digits.
    /// <para>
    /// When the billing country is the U.S., the 9-digit postal code must follow this format:
    /// [5 digits][dash][4 digits]
    /// </para>
    /// <para>
    /// <b>Example</b> <c>12345-6789</c>
    /// </para>
    /// <para>
    /// When the billing country is Canada, the 6-digit postal code must follow this format:
    /// [alpha][numeric][alpha][space][numeric][alpha][numeric]
    /// </para>
    /// <para>
    /// <b>Example</b> <c>A1B 2C3</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Payment card billing country. Use the two-character ISO Standard Country Codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

    /// <summary>
    /// Customer's email address, including the full domain name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(255)]
    public string? Email { get; init; }

    /// <summary>
    /// Customer’s phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(15)]
    public string? PhoneNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
