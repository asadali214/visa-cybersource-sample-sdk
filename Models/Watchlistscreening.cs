using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Watchlistscreening
{
    /// <summary>
    /// The status for the call can be:
    /// - COMPLETED
    /// - INVALID_REQUEST
    /// - DECLINED
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The reason of the status. Value can be
    ///   - <c>CUSTOMER_WATCHLIST_MATCH</c>
    ///   - <c>ADDRESS_COUNTRY_WATCHLIST_MATCH</c>
    ///   - <c>EMAIL_COUNTRY_WATCHLIST_MATCH</c>
    ///   - <c>IP_COUNTRY_WATCHLIST_MATCH</c>
    ///   - <c>INVALID_MERCHANT_CONFIGURATION</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The message describing the reason of the status. Value can be
    ///   - The customer matched the Denied Parties List
    ///   - The Export bill_country/ship_country  match
    ///   - Export email_country match
    ///   - Export hostname_country/ip_country match
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
