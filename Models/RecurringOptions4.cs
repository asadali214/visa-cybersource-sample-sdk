using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RecurringOptions4
{
    /// <summary>
    /// Indicates the transaction that is the first of a series of recurring payments.
    /// <list type="bullet">
    ///   <item><description><c>True</c> = is first recurring payment</description></item>
    ///   <item><description><c>False</c> = is not first recurring payment</description></item>
    /// </list>
    /// <para>
    /// Conditional for MITCOF transactions
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstRecurringPayment")]
    public bool? FirstRecurringPayment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
