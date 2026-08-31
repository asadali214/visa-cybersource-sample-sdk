using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantDescriptor38
{
    /// <summary>
    /// First line of merchant's address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(60)]
    public string? Address1 { get; init; }

    /// <summary>
    /// The state where the merchant is located.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(6)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Contact information for the merchant. This field contains additional information for contacting the merchant, such as an additional phone number or a contact name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contact")]
    [MaxLength(14)]
    public string? Contact { get; init; }

    /// <summary>
    /// Merchant's country.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

    /// <summary>
    /// Merchant's county. Used for US Merchants only.  Send a 3-digit numeric FIPS county code. https://www2.census.gov/programs-surveys/decennial/2010/partners/pdf/FIPS_StateCounty_Code.pdf
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("county")]
    [MaxLength(3)]
    public string? County { get; init; }

    /// <summary>
    /// Indicates customer service phone number of Merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerServicePhoneNumber")]
    [MaxLength(27)]
    public string? CustomerServicePhoneNumber { get; init; }

    /// <summary>
    /// Merchant's City.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(30)]
    public string? Locality { get; init; }

    /// <summary>
    /// Merchant's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(25)]
    public string? Name { get; init; }

    /// <summary>
    /// Merchant's phone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    [MaxLength(13)]
    public string? Phone { get; init; }

    /// <summary>
    /// Merchant's postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(14)]
    public string? PostalCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
