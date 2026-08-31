using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Initiator31
{
    /// <summary>
    /// &gt; This field is ignored when you provide the <c>subscriptionInformation.originalTransactionId</c> or update the subscription.
    /// <para>
    /// This field indicates whether the transaction is a merchant-initiated transaction or customer-initiated transaction.
    /// </para>
    /// <para>
    /// Valid values:
    /// - <b>customer</b>
    /// - <b>merchant</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
