using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Leg5
{
    /// <summary>
    /// Use to specify the airport code for the origin of the leg of the trip, which is designated by the pound (#)
    /// symbol in the field name. This code is usually three digits long, for example: SFO = San Francisco.
    /// Do not use the colon (:) or the dash (-). For airport codes, see the IATA Airline and Airport Code Search.
    /// The leg number can be a positive integer from 0 to N.
    /// For example:
    /// <c>travelInformation.legs.0.origination=SFO</c>
    /// <c>travelInformation.legs.1.origination=SFO</c>
    /// <para>
    /// <b>Note</b> In your request, send either the complete route or the individual legs (<c>legs.0.origination</c> and <c>legs.n.destination</c>). If you
    /// send all the fields, the complete route takes precedence over the individual legs.
    /// </para>
    /// <para>
    /// For details, see the <c>decision_manager_travel_leg#_orig</c> field description in _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origination")]
    [MaxLength(3)]
    public string? Origination { get; init; }

    /// <summary>
    /// Use to specify the airport code for the destination of the leg of the trip, which is designated by the pound (#)
    /// symbol in the field name. This code is usually three digits long, for example: SFO = San Francisco. Do not use the
    /// colon (:) or the dash (-). For airport codes, see <see href="https://www.iata.org/publications/Pages/code-search.aspx">IATA Airline and Airport Code Search</see>. The leg number can be a
    /// positive integer from 0 to N.
    /// For example:
    /// <para>
    /// <c>travelInformation.legs.0.destination=SFO</c>
    /// <c>travelInformation.legs.1.destination=SFO</c>
    /// </para>
    /// <para>
    /// <b>Note</b> In your request, send either the complete route or the individual legs (<c>legs.0.origination</c> and <c>legs.n.destination</c>). If you
    /// send all the fields, the complete route takes precedence over the individual legs.
    /// </para>
    /// <para>
    /// For details, see the <c>decision_manager_travel_leg#_dest</c> field description in _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destination")]
    [MaxLength(3)]
    public string? Destination { get; init; }

    /// <summary>
    /// International Air Transport Association (IATA) code for the carrier for this leg of the trip.
    /// Required for each leg.
    /// Required for American Express SafeKey (U.S.) for travel-related requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierCode")]
    [MaxLength(2)]
    public string? CarrierCode { get; init; }

    /// <summary>
    /// Departure date for the first leg of the trip. Format: YYYYMMDD.
    /// Required for American Express SafeKey (U.S.) for travel-related requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureDate")]
    public string? DepartureDate { get; init; }

    /// <summary>
    /// Time of departure for this leg of the trip. The format is military time and HHMM:
    /// If not all zeros, then the hours must be <c>00-23</c> and the minutes must be <c>00-59</c>.
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureTime")]
    public int? DepartureTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
