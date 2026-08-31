using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AutoRental
{
    /// <summary>
    /// No Show Indicator provides an indicator noting that the individual did not show up after making a reservation for a vehicle.
    /// Possible values:
    /// - true
    /// - false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noShowIndicator")]
    public bool? NoShowIndicator { get; init; }

    /// <summary>
    /// Name of the individual making the rental agreement.
    /// <para>
    /// Valid data lengths by card:
    /// </para>
    /// <para>
    /// |Card Specific Validation|VISA|MasterCard|Discover|AMEX|
    /// |--- |--- |--- |--- |
    /// | Filed Length| 40| 40| 29| 26|
    /// | Field Type| AN| ANS| AN| AN|
    /// | M/O/C| O| M| M| M|
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerName")]
    [MaxLength(40)]
    public string? CustomerName { get; init; }

    /// <summary>
    /// Classification of the rented auto.
    /// <para>
    /// <b>NOTE</b> For VISA, this is a 2-byte optional code.
    /// </para>
    /// <para>
    /// Valid values for American Express &amp; MasterCard:
    /// </para>
    /// <para>
    /// |American Express |MasterCard |Description|
    /// |--- |--- |--- |
    /// | 0001| 0001| Mini|
    /// | 0002| 0002| Subcompact|
    /// | 0003| 0003| Economy|
    /// | 0004| 0004| Compact|
    /// | 0005| 0005| Midsize|
    /// | 0006| 0006| Intermediate|
    /// | 0007| 0007| Standard|
    /// | 0008| 0008| Fulll size|
    /// | 0009| 0009| Luxury|
    /// | 0010| 0010| Premium|
    /// | 0011| 0011| Minivan|
    /// | 0012| 0012| 12-passenger van|
    /// | 0013| 0013| Moving van|
    /// | 0014| 0014| 15-passenger van|
    /// | 0015| 0015| Cargo van|
    /// | 0016| 0016| 12-foot truck|
    /// | 0017| 0017| 20-foot truck|
    /// | 0018| 0018| 24-foot truck|
    /// | 0019| 0019| 26-foot truck|
    /// | 0020| 0020| Moped|
    /// | 0021| 0021| Stretch|
    /// | 0022| 0022| Regular|
    /// | 0023| 0023| Unique|
    /// | 0024| 0024| Exotic|
    /// | 0025| 0025| Small/medium truck|
    /// | 0026| 0026| Large truck|
    /// | 0027| 0027| Small SUV|
    /// | 0028| 0028| Medium SUV|
    /// | 0029| 0029| Large SUV|
    /// | 0030| 0030| Exotic SUV|
    /// | 9999| 9999| Miscellaneous|
    /// </para>
    /// <para>
    /// Additional Values allowed <b>only</b> for <c>American Express</c>:
    /// </para>
    /// <para>
    /// |American Express|MasterCard|Description|
    /// |--- |--- |--- |
    /// | 0031| NA| Four Wheel Drive|
    /// | 0032| NA| Special|
    /// | 0099| NA| Taxi|
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vehicleClass")]
    [MaxLength(4)]
    public string? VehicleClass { get; init; }

    /// <summary>
    /// Total number of miles driven by the customer.
    /// This field is supported only for MasterCard and American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distanceTravelled")]
    [MaxLength(5)]
    public string? DistanceTravelled { get; init; }

    /// <summary>
    /// Miles/Kilometers Indicator shows whether the “miles” fields are expressed in miles or kilometers.
    /// <para>
    /// Allowed values:
    /// - <c>K</c> - Kilometers
    /// - <c>M</c> - Miles
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distanceUnit")]
    [MaxLength(1)]
    public string? DistanceUnit { get; init; }

    /// <summary>
    /// Date/time the auto was returned to the rental agency.
    /// Format: ``yyyy-MM-dd HH-mm-ss z``
    /// This field is supported for Visa, MasterCard, and American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnDateTime")]
    [MaxLength(21)]
    public string? ReturnDateTime { get; init; }

    /// <summary>
    /// Date/time the auto was picked up from the rental agency.
    /// Format: <c>yyyy-MM-dd HH-mm-ss z</c>
    /// This field is supported for Visa, MasterCard, and American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rentalDateTime")]
    [MaxLength(21)]
    public string? RentalDateTime { get; init; }

    /// <summary>
    /// Maximum number of free miles or kilometers allowed to a customer for the duration of the auto rental agreement.
    /// This field is supported only for MasterCard and American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxFreeDistance")]
    [MaxLength(4)]
    public string? MaxFreeDistance { get; init; }

    /// <summary>
    /// Used for MC and Discover
    /// <para>
    /// Valid values:
    /// - <c>true</c> - Yes (insurance was purchased)
    /// - <c>false</c> - No (insurance was not purchased)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insuranceIndicator")]
    public bool? InsuranceIndicator { get; init; }

    /// <summary>
    /// Used to identify special circumstances applicable to the Card Transaction or Cardholder, such as "renter” or ”show”.
    /// <para>
    /// This code is <c>2 digit</c> value agreed by Merchant and processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("programCode")]
    [MaxLength(2)]
    public string? ProgramCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnAddress")]
    public ReturnAddress? ReturnAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rentalAddress")]
    public RentalAddress? RentalAddress { get; init; }

    /// <summary>
    /// Auto rental agency’s agreement (invoice) number provided to the customer. It is used to trace any inquiries about transactions.
    /// This field is supported for Visa, MasterCard, and American Express.
    /// This Merchant-defined value, which may be composed of any combination of characters and/or numerals, may become
    /// part of the descriptive bill on the Cardmember's statement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("agreementNumber")]
    [MaxLength(25)]
    public string? AgreementNumber { get; init; }

    /// <summary>
    /// Odometer reading at time of vehicle rental.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("odometerReading")]
    [MaxLength(8)]
    public string? OdometerReading { get; init; }

    /// <summary>
    /// This field contains a unique identifier assigned by the company to the vehicle.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vehicleIdentificationNumber")]
    [MaxLength(20)]
    public string? VehicleIdentificationNumber { get; init; }

    /// <summary>
    /// Corporate Identifier provides the unique identifier of the corporation or entity renting the vehicle:
    /// <para>
    /// |Card Specific Validation|VISA|MasterCard|Discover|AMEX|
    /// |--- |--- |--- |--- |
    /// | Filed Length| NA| 12| NA| NA|
    /// | Field Type| NA| AN| NA| NA|
    /// | M/O/C| NA| O| NA| NA|
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("companyId")]
    [MaxLength(12)]
    public string? CompanyId { get; init; }

    /// <summary>
    /// The number of additional drivers included on the rental agreement not including the individual who signed the rental agreement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfAdditionalDrivers")]
    [MaxLength(1)]
    public string? NumberOfAdditionalDrivers { get; init; }

    /// <summary>
    /// Age of the driver renting the vehicle.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("driverAge")]
    [MaxLength(3)]
    public string? DriverAge { get; init; }

    /// <summary>
    /// Program code used to identify special circumstances, such as “frequent renter” or “no show” status for the renter.
    /// Possible values:
    /// - <c>0</c>: not applicable (default)
    /// - <c>1</c>: frequent renter
    /// - <c>2</c>: no show
    /// <para>
    /// For authorizations, this field is supported only for Visa.
    /// </para>
    /// <para>
    /// For captures, this field is supported for Visa, MasterCard, and American Express.
    /// </para>
    /// <para>
    /// Code for special programs applicable to the Card Transaction or the Cardholder.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("specialProgramCode")]
    [MaxLength(2)]
    public string? SpecialProgramCode { get; init; }

    /// <summary>
    /// Make of the vehicle being rented (e.g., Chevrolet or Ford).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vehicleMake")]
    [MaxLength(10)]
    public string? VehicleMake { get; init; }

    /// <summary>
    /// Model of the vehicle being rented (e.g., Cavalier or Focus).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vehicleModel")]
    [MaxLength(10)]
    public string? VehicleModel { get; init; }

    /// <summary>
    /// Indicates the time period for which the vehicle rental rate applies (e.g., daily, weekly or monthly). Daily, Weekly and Monthly are valid values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timePeriod")]
    [MaxLength(7)]
    public string? TimePeriod { get; init; }

    /// <summary>
    /// Commodity code or International description code used to classify the item. Contact your acquirer for a list of
    /// codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commodityCode")]
    [MaxLength(15)]
    public string? CommodityCode { get; init; }

    /// <summary>
    /// Customer service telephone number that is used to resolve questions or disputes. Include the area code, exchange, and number.
    /// This field is supported only for MasterCard and American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerServicePhoneNumber")]
    [MaxLength(17)]
    public string? CustomerServicePhoneNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxDetails")]
    public TaxDetails? TaxDetails { get; init; }

    /// <summary>
    /// Insurance charges.
    /// Field is conditional and can include decimal point.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insuranceAmount")]
    [MaxLength(12)]
    public string? InsuranceAmount { get; init; }

    /// <summary>
    /// Extra charges incurred for a one-way rental agreement for the auto.
    /// This field is supported only for Visa.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oneWayDropOffAmount")]
    [MaxLength(12)]
    public string? OneWayDropOffAmount { get; init; }

    /// <summary>
    /// For <b>MasterCard</b> and <b>Discover</b>:
    /// Adjusted amount indicator code that indicates
    /// any miscellaneous charges incurred after the
    /// auto was returned. Possible values:
    /// - <c>A</c> - Drop-off charges
    /// - <c>B</c> - Delivery charges
    /// - <c>C</c> - Parking expenses
    /// - <c>D</c> - Extra hours
    /// - <c>E</c> - Violations
    /// - <c>X</c> - More than one of the above charges
    /// <para>
    /// For <b>American Express</b>:
    /// Audit indicator code that indicates any
    /// adjustment for mileage, fuel, auto damage,
    /// etc. made to a rental agreement and whether
    /// the cardholder was notified.
    /// </para>
    /// <para>
    /// Possible value for the authorization service:
    /// - <c>A</c> (default): adjustment amount greater than 0 (zero)
    /// </para>
    /// <para>
    /// Possible values for the capture service:
    /// - <c>X</c> - Multiple adjustments
    /// - <c>Y</c> - One adjustment only; Cardmember notified
    /// - <c>Z</c> - One adjustment only; Cardmember not notified. This value is used as the default if the request does not include this field and includes an adjustment amount greater than 0 (zero).
    /// This is an optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustedAmountIndicator")]
    [MaxLength(1)]
    public string? AdjustedAmountIndicator { get; init; }

    /// <summary>
    /// Adjusted Amount indicates whether any miscellaneous charges were incurred after the vehicle was returned.
    /// <para>
    /// For authorizations, this field is supported only for American Express.
    /// </para>
    /// <para>
    /// For captures, this field is supported only for MasterCard and American Express.
    /// <b>NOTE</b> For American Express, this field is required if the <c>travelInformation.autoRental.adjustedAmountIndicator</c> field
    /// is included in the request and has a value; otherwise, this field is optional.
    /// </para>
    /// <para>
    /// For all other card types, this field is ignored.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustedAmount")]
    [MaxLength(12)]
    public string? AdjustedAmount { get; init; }

    /// <summary>
    /// Extra gasoline charges that extend beyond the basic rental agreement.
    /// This field is supported only for Visa.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fuelCharges")]
    [MaxLength(12)]
    public string? FuelCharges { get; init; }

    /// <summary>
    /// Weekly Rental Amount provides the amount charged for a seven-day rental period. Field - Time Period needs to be populated with Weekly if this field is present
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weeklyRentalRate")]
    [MaxLength(12)]
    public string? WeeklyRentalRate { get; init; }

    /// <summary>
    /// Daily auto rental rate charged.
    /// This field is supported only for MasterCard and American Express.
    /// <para>
    /// Field - Time Period needs to be populated with Daily if this field is present
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dailyRentalRate")]
    [MaxLength(12)]
    public string? DailyRentalRate { get; init; }

    /// <summary>
    /// Rate charged for each mile.
    /// This field is supported only for MasterCard and American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePerMile")]
    [MaxLength(12)]
    public string? RatePerMile { get; init; }

    /// <summary>
    /// Regular Mileage Charge provides the amount charged for regular miles traveled during vehicle rental. Two decimal places
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mileageCharge")]
    [MaxLength(12)]
    public string? MileageCharge { get; init; }

    /// <summary>
    /// Extra mileage charges that extend beyond the basic rental agreement.
    /// This field is supported only for Visa.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extraMileageCharge")]
    [MaxLength(12)]
    public string? ExtraMileageCharge { get; init; }

    /// <summary>
    /// Extra charges related to a late return of the rented auto.
    /// This field is supported only for Visa.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lateFeeAmount")]
    [MaxLength(12)]
    public string? LateFeeAmount { get; init; }

    /// <summary>
    /// (Towing Charges) provides the amount charged to tow the rental vehicle.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("towingCharge")]
    [MaxLength(4)]
    public string? TowingCharge { get; init; }

    /// <summary>
    /// (Extra Charges) provides the extra charges associated with the vehicle rental.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extraCharge")]
    [MaxLength(12)]
    public string? ExtraCharge { get; init; }

    /// <summary>
    /// Amount charged for renting a Global Positioning Service (GPS).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpsCharge")]
    [MaxLength(12)]
    public string? GpsCharge { get; init; }

    /// <summary>
    /// Additional charges incurred for phone usage included on the total bill.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneCharge")]
    [MaxLength(12)]
    public string? PhoneCharge { get; init; }

    /// <summary>
    /// Extra charges incurred due to a parking violation for the auto.
    /// This field is supported only for Visa.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parkingViolationCharge")]
    [MaxLength(12)]
    public string? ParkingViolationCharge { get; init; }

    /// <summary>
    /// Total amount charged for all other miscellaneous charges not previously defined.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("otherCharges")]
    [MaxLength(12)]
    public string? OtherCharges { get; init; }

    /// <summary>
    /// Merchant to send their auto rental company name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("companyName")]
    [MaxLength(50)]
    public string? CompanyName { get; init; }

    /// <summary>
    /// When merchant wants to send the affiliate name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affiliateName")]
    [MaxLength(50)]
    public string? AffiliateName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
