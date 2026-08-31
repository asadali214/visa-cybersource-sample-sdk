using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record SenderInformation1
{
    /// <summary>
    /// First name of the sender of the funds. For Gaming Payment of Winnings transactions these are the merchant details.
    /// * Required for Mastercard Payment of Winnings (POW) transactions.
    /// * Must not be all numeric.
    /// * Must contain only ASCII characters in range 32-122.
    /// * Must not be greater than 35 characters including spaces.
    /// * Required for POW on Barclays.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(35)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Last name of the sender of the funds. For Gaming Payment of Winnings transactions these are the merchant details.
    /// * Optional for Mastercard Payment of Winnings (POW) transactions.
    /// * Must not be all numeric.
    /// * Must contain only ASCII characters in range 32-122.
    /// * Must not be greater than 35 characters including spaces.
    /// * Optional for POW on Barclays.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(35)]
    public string? LastName { get; init; }

    /// <summary>
    /// Street address of the sender of the funds. For Gaming Payment of Winnings transactions these are the merchant details.
    /// * Required for Mastercard Payment of Winnings (POW) transactions.
    /// * Must not be all numeric.
    /// * Must contain only ASCII characters in range 32-122.
    /// * Must not be greater than 50 characters including spaces.
    /// * Required for POW on Barclays.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(50)]
    public string? Address1 { get; init; }

    /// <summary>
    /// City of the sender of the funds. For Gaming Payment of Winnings transactions these are the merchant details.
    /// * Required for Mastercard Payment of Winnings (POW) transactions.
    /// * Must not be all numeric.
    /// * Must contain only ASCII characters in range 32-122.
    /// * Must not be greater than 25 characters including spaces.
    /// * Required for POW on Barclays.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(25)]
    public string? Locality { get; init; }

    /// <summary>
    /// Country of the sender of the funds. For Gaming Payment of Winnings transactions these are the merchant details.
    /// * Required for Mastercard Payment of Winnings (POW) transactions.
    /// * Must be a valid three character ISO country code as defined by ISO 3166.
    /// * Must not be greater than 3 characters.
    /// * Required for POW on Barclays.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    [MaxLength(3)]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The state or province of the sender.
    /// This field is applicable for AFT transactions when the sender country is US or CA. Else it is optional.
    /// <para>
    /// Must be a two character value
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(2)]
    public string? AdministrativeArea { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public Account6? Account { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
