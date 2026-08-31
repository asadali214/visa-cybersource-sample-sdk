using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Network17
{
    /// <summary>
    /// This field contains a code that identifies the network.
    /// <see href="https://developer.visa.com/request_response_codes#network_id_and_sharing_group_code">List of Network ID and Sharing Group Code</see>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
