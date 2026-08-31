using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Passenger3
{
    /// <summary>
    /// First name of the passenger to whom the ticket was issued.
    /// If there are multiple passengers, include all listed on the ticket.
    /// Do not include special characters such as commas, hyphens, or apostrophes.
    /// Only ASCII characters are supported.
    /// Required for American Express SafeKey (U.S.) for travel-related requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(60)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Last name of the passenger to whom the ticket was issued.
    /// If there are multiple passengers, include all listed on the ticket.
    /// Do not include special characters such as commas, hyphens, or apostrophes.
    /// Only ASCII characters are supported.
    /// Required for American Express SafeKey (U.S.) for travel-related requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(60)]
    public string? LastName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
