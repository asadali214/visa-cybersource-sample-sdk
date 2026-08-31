using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PtsV2UpdateOrderPatch201Response
{
    /// <summary>
    /// The status of the submitted transaction.
    /// Possible values:
    ///   - CREATED
    ///   - SAVED
    ///   - APPROVED
    ///   - VOIDED
    ///   - COMPLETED
    ///   - PAYER_ACTION_REQUIRED
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processorInformation")]
    public ProcessorInformation27? ProcessorInformation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
