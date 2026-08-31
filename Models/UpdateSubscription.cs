using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record UpdateSubscription
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientReferenceInformation")]
    public ClientReferenceInformation3? ClientReferenceInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingInformation")]
    public ProcessingInformation65? ProcessingInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("planInformation")]
    public PlanInformation11? PlanInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionInformation")]
    public SubscriptionInformation4? SubscriptionInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderInformation")]
    public OrderInformation55? OrderInformation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
