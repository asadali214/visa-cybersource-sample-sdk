using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ShippingDetails2
{
    /// <summary>
    /// Postal code for the address from which the goods are shipped, which is used to establish nexus. The default is
    /// the postal code associated with your CyberSource account.
    /// <para>
    /// The postal code must consist of 5 to 9 digits. When the billing country is the U.S., the 9-digit postal code
    /// must follow this format:
    /// </para>
    /// <para>
    /// <c>[5 digits][dash][4 digits]</c>
    /// </para>
    /// <para>
    /// Example 12345-6789
    /// </para>
    /// <para>
    /// When the billing country is Canada, the 6-digit postal code must follow this format:
    /// </para>
    /// <para>
    /// <c>[alpha][numeric][alpha][space] [numeric][alpha][numeric]</c>
    /// </para>
    /// <para>
    /// Example A1B 2C3
    /// </para>
    /// <para>
    /// This field is frequently used for Level II and Level III transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipFromPostalCode")]
    [MaxLength(10)]
    public string? ShipFromPostalCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
