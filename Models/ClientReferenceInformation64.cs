using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ClientReferenceInformation64
{
    /// <summary>
    /// Originator-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(50)]
    public string? Code { get; init; }

    /// <summary>
    /// The name of the Connection Method that the originator uses to send a transaction request to CyberSource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationName")]
    [MaxLength(50)]
    public string? ApplicationName { get; init; }

    /// <summary>
    /// Version of the CyberSource application or integration used for a transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationVersion")]
    [MaxLength(50)]
    public string? ApplicationVersion { get; init; }

    /// <summary>
    /// The entity that is responsible for running the transaction and submitting the processing request to CyberSource. This could be a person, a system, or a connection method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationUser")]
    [MaxLength(60)]
    public string? ApplicationUser { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
