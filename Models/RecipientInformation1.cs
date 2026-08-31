using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RecipientInformation1
{
    /// <summary>
    /// First name of recipient of the funds.
    /// * Required for Mastercard Payment of Winnings (POW) transactions.
    /// * Must not be all numeric.
    /// * Must contain only ASCII characters in range 32-122.
    /// * Must not be greater than 35 characters including spaces.
    /// * Required for POW on Barclays
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(35)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Last name of recipient of the funds.
    /// * Required for Mastercard Payment of Winnings (POW) transactions.
    /// * Must not be all numeric.
    /// * Must contain only ASCII characters in range 32-122.
    /// * Must not be greater than 35 characters including spaces.
    /// * Required for POW on Barclays
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(35)]
    public string? LastName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
