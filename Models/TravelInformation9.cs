using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TravelInformation9
{
    /// <summary>
    /// IATA Code for the actual final destination that the customer intends to travel to.
    /// It should be a destination on the completeRoute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actualFinalDestination")]
    [MaxLength(3)]
    public string? ActualFinalDestination { get; init; }

    /// <summary>
    /// Concatenation of individual travel legs in the format ORIG1-DEST1[:ORIG2-DEST2...:ORIGn-DESTn], for
    /// example, SFO-JFK:JFK-LHR:LHR-CDG. For airport codes, see the IATA Airline and Airport Code Search.
    /// Note In your request, send either the complete route or the individual legs (_leg#_orig and _leg#_dest). If you
    /// send all the fields, the value of _complete_route takes precedence over that of the _leg# fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completeRoute")]
    [MaxLength(255)]
    public string? CompleteRoute { get; init; }

    /// <summary>
    /// Departure date and time of the first leg of the trip. Use one of the following formats:
    ///   - yyyy-MM-dd HH:mm z
    ///   - yyyy-MM-dd hh:mm a z
    ///   - yyyy-MM-dd hh:mma z
    ///   HH = hour in 24-hour format
    ///   hh = hour in 12-hour format
    ///   a = am or pm (case insensitive)
    ///   z = time zone of the departing flight, for example: If the
    ///   airline is based in city A, but the flight departs from city
    ///   B, z is the time zone of city B at the time of departure.
    /// Important For travel information, use GMT instead of UTC, or use the local time zone.
    /// Examples
    /// 2011-03-20 11:30 PM PDT
    /// 2011-03-20 11:30pm GMT
    /// 2011-03-20 11:30pm GMT-05:00
    /// Eastern Standard Time: GMT-05:00 or EST
    /// Note When specifying an offset from GMT, the format must be exactly as specified in the example. Insert no
    /// spaces between the time zone and the offset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureTime")]
    [MaxLength(25)]
    public string? DepartureTime { get; init; }

    /// <summary>
    /// Type of travel, for example one way or round trip.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("journeyType")]
    [MaxLength(32)]
    public string? JourneyType { get; init; }

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
