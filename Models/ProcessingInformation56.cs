using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Decides whether to call Payer Authentication or Watchlist Screening service along with DM or not.
/// </summary>
public record ProcessingInformation56
{
    /// <summary>
    /// <list type="bullet">
    ///   <item><description>Use <c>CONSUMER_AUTHENTICATION</c> to use Payer Authentication along with Decision Manager. For any other value, only Decision Manager will run.</description></item>
    ///   <item><description>Use <c>WATCHLIST_SCREENING</c>  when you want to call Watchlist Screening service.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
