using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Leg
{
    /// <summary>
    /// IATA code for the carrier for this leg of the trip.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierCode")]
    [MaxLength(4)]
    public string? CarrierCode { get; init; }

    /// <summary>
    /// Flight number for this leg of the trip.
    /// Restrictions are limitations for the ticket based on the type of fare, such as a nonrefundable ticket or a 3-day minimum stay.
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flightNumber")]
    [MaxLength(6)]
    public string? FlightNumber { get; init; }

    /// <summary>
    /// IATA code for the originating airport for this leg of the trip.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originatingAirportCode")]
    [MaxLength(5)]
    public string? OriginatingAirportCode { get; init; }

    /// <summary>
    /// IATA code for the class of service for this leg of the trip.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("class")]
    [MaxLength(3)]
    public string? Class { get; init; }

    /// <summary>
    /// Code that indicates whether a stopover is allowed on this leg of the trip. Possible values:
    /// - <c>O</c> (capital letter “O”) (default): Stopover allowed
    /// - <c>X</c> (capital letter “X”): Stopover not allowed
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stopoverIndicator")]
    public int? StopoverIndicator { get; init; }

    /// <summary>
    /// Departure date for the first leg of the trip.
    /// Format: <c>YYYYMMDD</c>.
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureDate")]
    public int? DepartureDate { get; init; }

    /// <summary>
    /// IATA code for the destination airport for this leg of the trip.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destinationAirportCode")]
    [MaxLength(3)]
    public string? DestinationAirportCode { get; init; }

    /// <summary>
    /// Code for the fare basis for this leg of the trip.
    /// The fare basis is assigned by the carriers and indicates a particular ticket type,
    /// such as business class or discounted/nonrefundable.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Format: English characters only.
    /// Optional request field for travel legs.auto_rental_regular_mileage_cost
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fareBasis")]
    [MaxLength(15)]
    public string? FareBasis { get; init; }

    /// <summary>
    /// Amount of departure tax for this leg of the trip.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departTaxAmount")]
    [MaxLength(12)]
    public string? DepartTaxAmount { get; init; }

    /// <summary>
    /// Ticket that contains additional coupons for this leg of the trip on an itinerary that has more than four segments.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conjunctionTicket")]
    [MaxLength(25)]
    public string? ConjunctionTicket { get; init; }

    /// <summary>
    /// New ticket number that is issued when the ticket is exchanged for this leg of the trip.
    /// Restrictions are limitations for the ticket based on the type of fare, such as a nonrefundable ticket or a 3-day minimum stay.
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeTicketNumber")]
    [MaxLength(25)]
    public string? ExchangeTicketNumber { get; init; }

    /// <summary>
    /// Coupon number. Each leg on the ticket requires a separate coupon, and each coupon is identified by the coupon number.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("couponNumber")]
    [MaxLength(1)]
    public string? CouponNumber { get; init; }

    /// <summary>
    /// Time of departure for this leg of the trip. The format is military time and HHMM:
    /// If not all zeros, then the hours must be <c>00-23</c> and the minutes must be <c>00-59</c>.
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureTime")]
    public int? DepartureTime { get; init; }

    /// <summary>
    /// AM or PM for the departure time.
    /// Possible values:
    /// - A: 12:00 midnight to 11:59 a.m.
    /// - P: 12:00 noon to 11:59 p.m
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureTimeMeridian")]
    [MaxLength(1)]
    public string? DepartureTimeMeridian { get; init; }

    /// <summary>
    /// Time of arrival for this leg of the trip.
    /// The format is military time and HHMM:
    /// If not all zeros, then the hours must be <c>00-23</c> and the minutes must be <c>00-59</c>
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("arrivalTime")]
    public int? ArrivalTime { get; init; }

    /// <summary>
    /// AM or PM for the arrival time for this leg of the trip.
    /// Possible values:
    /// - <c>A</c>: 12:00 midnight to 11:59 a.m.
    /// - <c>P</c>: 12:00 noon to 11:59 p.m.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("arrivalTimeMeridian")]
    [MaxLength(1)]
    public string? ArrivalTimeMeridian { get; init; }

    /// <summary>
    /// Notes or notations about endorsements and restrictions for this leg of the trip.
    /// Endorsements can be notations added by the travel agency, including mandatory government-required notations such as value added tax.
    /// Restrictions are limitations for the ticket based on the type of fare, such as a nonrefundable ticket or a 3-day minimum stay.
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endorsementsRestrictions")]
    [MaxLength(20)]
    public string? EndorsementsRestrictions { get; init; }

    /// <summary>
    /// Total fare for this leg of the trip.
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalFareAmount")]
    [MaxLength(15)]
    public string? TotalFareAmount { get; init; }

    /// <summary>
    /// Fee for this leg of the trip, such as an airport fee or country fee.
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeAmount")]
    [MaxLength(12)]
    public string? FeeAmount { get; init; }

    /// <summary>
    /// Tax for this leg of the trip.
    /// Format: English characters only.
    /// Optional request field for travel legs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAmount")]
    [MaxLength(12)]
    public string? TaxAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
