using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Ivr
{
    /// <summary>
    /// Flag to indicate if a valid IVR transaction was detected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabledMessage")]
    public bool? EnabledMessage { get; init; }

    /// <summary>
    /// Encryption key to be used in the event the ACS requires encryption of the credential field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionKey")]
    [MaxLength(16)]
    public string? EncryptionKey { get; init; }

    /// <summary>
    /// Flag to indicate if the ACS requires the credential to be encrypted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionMandatory")]
    public bool? EncryptionMandatory { get; init; }

    /// <summary>
    /// An indicator from the ACS to inform the type of encryption that should be used in the event the ACS requires encryption of the credential field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionType")]
    [MaxLength(20)]
    public string? EncryptionType { get; init; }

    /// <summary>
    /// An ACS Provided label that can be presented to the Consumer. Recommended use with an application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    [MaxLength(20)]
    public string? Label { get; init; }

    /// <summary>
    /// An ACS provided string that can be presented to the Consumer. Recommended use with an application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prompt")]
    [MaxLength(80)]
    public string? Prompt { get; init; }

    /// <summary>
    /// An ACS provided message that can provide additional information or details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusMessage")]
    [MaxLength(80)]
    public string? StatusMessage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
