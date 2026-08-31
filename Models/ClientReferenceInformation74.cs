using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ClientReferenceInformation74
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partner")]
    public Partner16? Partner { get; init; }

    /// <summary>
    /// The name of the Connection Method client (such as Virtual Terminal or SOAP Toolkit API) that the merchant uses to send a transaction request to CyberSource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationName")]
    public string? ApplicationName { get; init; }

    /// <summary>
    /// Version of the CyberSource application or integration used for a transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationVersion")]
    public string? ApplicationVersion { get; init; }

    /// <summary>
    /// The entity that is responsible for running the transaction and submitting the processing request to CyberSource. This could be a person, a system, or a connection method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationUser")]
    public string? ApplicationUser { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
