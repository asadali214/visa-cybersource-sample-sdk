using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentInstrumentList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public Links85? Links { get; init; }

    /// <summary>
    /// The offset parameter supplied in the request.
    /// </summary>
    [JsonPropertyName("offset")]
    public int? Offset { get; init; } = 0;

    /// <summary>
    /// The limit parameter supplied in the request.
    /// </summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; init; } = 20;

    /// <summary>
    /// The number of Payment Instruments returned in the array.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public int? Count { get; init; }

    /// <summary>
    /// The total number of Payment Instruments associated with the Customer or Instrument Identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public int? Total { get; init; }

    /// <summary>
    /// Payment Instrument Resources.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_embedded")]
    public Embedded12? Embedded { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
