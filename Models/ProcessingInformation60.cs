using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation60
{
    /// <summary>
    /// Follow-on action to apply to the case after the decision is successfully applied. Possible values are one of the following:
    /// - <c>CAPTURE</c>
    /// - <c>REVERSE</c>
    /// <para>
    /// If decision is ACCEPT, then CAPTURE can be used in actionList.
    /// If decision is REJECT, then REVERSE can be used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
