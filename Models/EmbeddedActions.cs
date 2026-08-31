using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains embedded actions, that includes status and response for every actions in the list.
/// </summary>
public record EmbeddedActions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CAPTURE")]
    public Capture1? Capture { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DECISION")]
    public Decision? Decision { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CONSUMER_AUTHENTICATION")]
    public Consumerauthentication? ConsumerAuthentication { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("VALIDATE_CONSUMER_AUTHENTICATION")]
    public Validateconsumerauthentication? ValidateConsumerAuthentication { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("WATCHLIST_SCREENING")]
    public Watchlistscreening? WatchlistScreening { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TOKEN_CREATE")]
    public Tokencreate? TokenCreate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TOKEN_UPDATE")]
    public Tokenupdate? TokenUpdate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
