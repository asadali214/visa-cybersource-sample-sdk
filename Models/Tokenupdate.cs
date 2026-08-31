using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Tokenupdate
{
    /// <summary>
    /// The status of the token update.
    /// <para>
    /// Possible value is:
    ///   - SUCCESS
    ///   - SERVER_ERROR
    ///   - INVALID_REQUEST
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The reason of the status.
    /// Possible values:
    ///  - INVALID_DATA
    ///  - SYSTEM_ERROR
    ///  - MISSING_FIELD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The detail message related to the status and reason listed above.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
