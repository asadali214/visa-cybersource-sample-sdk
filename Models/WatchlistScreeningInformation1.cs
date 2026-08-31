using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record WatchlistScreeningInformation1
{
    /// <summary>
    /// Likelihood that the country associated with the customer’s IP address was identified correctly.
    /// Returns a value from 1–100, where 100 indicates the highest likelihood.
    /// If the country cannot be determined, the value is –1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipCountryConfidence")]
    [Minimum(-1)]
    [Maximum(100)]
    public int? IpCountryConfidence { get; init; }

    /// <summary>
    /// Returned when the Denied Parties List check (first two codes) or the export service (all others) would have
    /// declined the transaction. This field can contain one or more of these values:
    /// - <c>MATCH-DPC</c>: Denied Parties List match.
    /// - <c>UNV-DPC</c>: Denied Parties List unavailable.
    /// - <c>MATCH-BCO</c>: Billing country restricted.
    /// - <c>MATCH-EMCO</c>: Email country restricted.
    /// - <c>MATCH-HCO</c>: Host name country restricted.
    /// - <c>MATCH-IPCO</c>: IP country restricted.
    /// - <c>MATCH-SCO</c>: Shipping country restricted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("infoCodes")]
    public IReadOnlyList<string>? InfoCodes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("watchList")]
    public ExportComplianceWatchList? WatchList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
