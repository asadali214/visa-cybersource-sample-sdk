using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record UpdatePayments
{
    /// <summary>
    /// A list of billing cycles that are marked to be skipped.
    /// The payment cannot be added to the list if it is a retry attempt.
    /// The payment cannot be added to or removed from the list if it is on the same day as its scheduled processing time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingCyclesToSkip")]
    public IReadOnlyList<int>? BillingCyclesToSkip { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
