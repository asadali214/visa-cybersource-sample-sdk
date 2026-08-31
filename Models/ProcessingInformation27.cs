using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation27
{
    /// <summary>
    /// Array of actions (one or more) to be included in the payment to invoke bundled services.
    /// Possible values are one or more of follows:
    /// <list type="bullet">
    ///   <item><description><c>TOKEN_RETRIEVE</c>: Use this when Alternative Payment token retrieval is requested.</description></item>
    ///   <item><description><c>TOKEN_DELETE</c>: Use this when Alternative Payment token deletion is requested.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
