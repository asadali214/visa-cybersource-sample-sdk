using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation26
{
    /// <summary>
    /// Array of actions (one or more) to be included in the void to invoke bundled services along with void.
    /// Possible values:
    /// - <c>AP_UPDATE_ORDER</c>: Use this when Alternative Payment Update order service is requested.
    /// - <c>AP_EXTEND_ORDER</c>: Use this when Alternative Payment extend order service is requested.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
