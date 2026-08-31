using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record Lodging
{
    /// <summary>
    /// Date on which the guest checked in. In the case of a no-show or a reservation, the scheduled arrival date.
    /// Format: <c>MMDDYY</c>. For best interchange rates, make sure it is a valid date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkInDate")]
    [MaxLength(6)]
    public string? CheckInDate { get; init; }

    /// <summary>
    /// Date on which the guest checked out.
    /// Format: <c>MMDDYY</c>. For best interchange rates, make sure it is a valid date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkOutDate")]
    [MaxLength(6)]
    public string? CheckOutDate { get; init; }

    /// <summary>
    /// The object containing the number of nights and the daily rate that applies for that no of nights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("room")]
    public IReadOnlyList<Room>? Room { get; init; }

    /// <summary>
    /// Smoking preference of the guest.
    /// Possible values:
    /// - <c>Y</c>: smoking room
    /// - <c>N</c>: non-smoking room
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smokingPreference")]
    [MaxLength(1)]
    public string? SmokingPreference { get; init; }

    /// <summary>
    /// Number of rooms booked by the cardholder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfRooms")]
    [Minimum(1)]
    [Maximum(99)]
    public int? NumberOfRooms { get; init; }

    /// <summary>
    /// Number of guests staying in the room.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfGuests")]
    [Minimum(1)]
    [Maximum(99)]
    public int? NumberOfGuests { get; init; }

    /// <summary>
    /// Type of room, such as queen, king, or two doubles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roomBedType")]
    [MaxLength(12)]
    public string? RoomBedType { get; init; }

    /// <summary>
    /// Type of tax, such as tourist or hotel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roomTaxType")]
    [MaxLength(10)]
    public string? RoomTaxType { get; init; }

    /// <summary>
    /// Type of rate, such as corporate or senior citizen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roomRateType")]
    [MaxLength(12)]
    public string? RoomRateType { get; init; }

    /// <summary>
    /// Name of the guest under which the room is reserved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("guestName")]
    [MaxLength(40)]
    public string? GuestName { get; init; }

    /// <summary>
    /// Your toll-free customer service phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerServicePhoneNumber")]
    [MaxLength(17)]
    public string? CustomerServicePhoneNumber { get; init; }

    /// <summary>
    /// Code assigned to a business. You can use this code to identify corporate rates and discounts for guests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("corporateClientCode")]
    [MaxLength(17)]
    public string? CorporateClientCode { get; init; }

    /// <summary>
    /// Amount of an additional coupon or discount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalDiscountAmount")]
    [MaxLength(12)]
    public string? AdditionalDiscountAmount { get; init; }

    /// <summary>
    /// Location of room, such as lake view or ocean view.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roomLocation")]
    [MaxLength(10)]
    public string? RoomLocation { get; init; }

    /// <summary>
    /// Code that identifies special circumstances.
    /// Possible values:
    /// - <c>1</c>: lodging (default)
    /// - <c>2</c>: no show reservation
    /// - <c>3</c>: advanced deposit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("specialProgramCode")]
    [MaxLength(1)]
    public string? SpecialProgramCode { get; init; }

    /// <summary>
    /// Total tax amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalTaxAmount")]
    [MaxLength(12)]
    public string? TotalTaxAmount { get; init; }

    /// <summary>
    /// Prepaid amount, such as a deposit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prepaidCost")]
    [MaxLength(12)]
    public string? PrepaidCost { get; init; }

    /// <summary>
    /// Cost for all food and beverages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foodAndBeverageCost")]
    [MaxLength(12)]
    public string? FoodAndBeverageCost { get; init; }

    /// <summary>
    /// Total tax for the room.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roomTaxAmount")]
    [MaxLength(12)]
    public string? RoomTaxAmount { get; init; }

    /// <summary>
    /// Adjusted amount charged in addition to the reservation amount after the stay is complete.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustmentAmount")]
    [MaxLength(12)]
    public string? AdjustmentAmount { get; init; }

    /// <summary>
    /// Cost of telephone services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneCost")]
    [MaxLength(12)]
    public string? PhoneCost { get; init; }

    /// <summary>
    /// Cost of restaurant purchases
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restaurantCost")]
    [MaxLength(12)]
    public string? RestaurantCost { get; init; }

    /// <summary>
    /// Cost of room service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roomServiceCost")]
    [MaxLength(12)]
    public string? RoomServiceCost { get; init; }

    /// <summary>
    /// Cost of mini-bar purchases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("miniBarCost")]
    [MaxLength(12)]
    public string? MiniBarCost { get; init; }

    /// <summary>
    /// Cost of laundry services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("laundryCost")]
    [MaxLength(12)]
    public string? LaundryCost { get; init; }

    /// <summary>
    /// Miscellaneous costs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("miscellaneousCost")]
    [MaxLength(12)]
    public string? MiscellaneousCost { get; init; }

    /// <summary>
    /// Cost of gift shop purchases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("giftShopCost")]
    [MaxLength(12)]
    public string? GiftShopCost { get; init; }

    /// <summary>
    /// Cost of movies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("movieCost")]
    [MaxLength(12)]
    public string? MovieCost { get; init; }

    /// <summary>
    /// Cost of health club services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("healthClubCost")]
    [MaxLength(12)]
    public string? HealthClubCost { get; init; }

    /// <summary>
    /// Cost of valet parking services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valetParkingCost")]
    [MaxLength(12)]
    public string? ValetParkingCost { get; init; }

    /// <summary>
    /// Cost of the cash that was disbursed plus any associated service fees
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashDisbursementCost")]
    [MaxLength(12)]
    public string? CashDisbursementCost { get; init; }

    /// <summary>
    /// Cost of non-room purchases, such as meals and gifts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonRoomCost")]
    [MaxLength(12)]
    public string? NonRoomCost { get; init; }

    /// <summary>
    /// Cost of business center services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessCenterCost")]
    [MaxLength(12)]
    public string? BusinessCenterCost { get; init; }

    /// <summary>
    /// Cost of lounge and bar purchases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loungeBarCost")]
    [MaxLength(12)]
    public string? LoungeBarCost { get; init; }

    /// <summary>
    /// Cost of transportation services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transportationCost")]
    [MaxLength(12)]
    public string? TransportationCost { get; init; }

    /// <summary>
    /// Gratuity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gratuityAmount")]
    [MaxLength(12)]
    public string? GratuityAmount { get; init; }

    /// <summary>
    /// Cost of conference room services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conferenceRoomCost")]
    [MaxLength(12)]
    public string? ConferenceRoomCost { get; init; }

    /// <summary>
    /// Cost of audio visual services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audioVisualCost")]
    [MaxLength(12)]
    public string? AudioVisualCost { get; init; }

    /// <summary>
    /// Cost of banquet services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("banquestCost")]
    [MaxLength(12)]
    public string? BanquestCost { get; init; }

    /// <summary>
    /// Tax on non-room purchases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonRoomTaxAmount")]
    [MaxLength(12)]
    public string? NonRoomTaxAmount { get; init; }

    /// <summary>
    /// Service fee for early departure.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("earlyCheckOutCost")]
    [MaxLength(12)]
    public string? EarlyCheckOutCost { get; init; }

    /// <summary>
    /// Cost of Internet access.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("internetAccessCost")]
    [MaxLength(12)]
    public string? InternetAccessCost { get; init; }

    /// <summary>
    /// Name of the hotel for which the reservation is for. Mandatory in case the
    /// merchant’s business type is Hotel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The name of the hotel for which the reservation was made.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hotelName")]
    public string? HotelName { get; init; }

    /// <summary>
    /// The date of the check-in in GMT+8 offset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkInDateTime")]
    public string? CheckInDateTime { get; init; }

    /// <summary>
    /// The date of the check-out in GMT+8 offset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkOutDateTime")]
    public string? CheckOutDateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
