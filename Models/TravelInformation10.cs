using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TravelInformation10
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legs")]
    public IReadOnlyList<Leg5>? Legs { get; init; }

    /// <summary>
    /// Number of passengers for whom the ticket was issued.
    /// If you do not include this field in your request, CyberSource uses a default value of 1.
    /// Required for American Express SafeKey (U.S.) for travel-related requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfPassengers")]
    public int? NumberOfPassengers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passengers")]
    public IReadOnlyList<Passenger3>? Passengers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
