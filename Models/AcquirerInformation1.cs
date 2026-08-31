using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AcquirerInformation1
{
    /// <summary>
    /// Acquirer bank ID number that  corresponds to a certificate that Cybersource already has.This ID has this format. 4XXXXX for Visa and 5XXXXX for Mastercard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirerBin")]
    [MaxLength(11)]
    public string? AcquirerBin { get; init; }

    /// <summary>
    /// Issuers need to be aware of the Acquirer's Country Code when the Acquirer country differs from the Merchant country and the Acquirer is in the EEA (European Economic Area).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

    /// <summary>
    /// Registered password for the Visa directory server.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    [MaxLength(8)]
    public string? Password { get; init; }

    /// <summary>
    /// Username for the visa directory server that is created when your acquirer sets up your account. This ID might be the same as your merchant ID. the username can be 15 or 23 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantId")]
    [MaxLength(15)]
    public string? MerchantId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
