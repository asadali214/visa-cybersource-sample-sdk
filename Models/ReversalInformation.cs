using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ReversalInformation
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountDetails")]
    public AmountDetails5? AmountDetails { get; init; }

    /// <summary>
    /// Reason for the authorization reversal. Possible value:
    /// <list type="bullet">
    ///   <item><description><c>34</c>: Suspected fraud</description></item>
    /// </list>
    /// <para>
    /// This field is ignored for processors that do not support this value.
    /// </para>
    /// <para>
    /// Returned by authorization reversal.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
