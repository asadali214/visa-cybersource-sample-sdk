using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Airline
{
    /// <summary>
    /// Specifies if the flight is:
    /// Domestic (01)
    /// International (02)
    /// If Y then 01 else 02
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isDomestic")]
    [MaxLength(255)]
    public string? IsDomestic { get; init; }

    /// <summary>
    /// Reference number for the airline booking.
    /// Required if ticket numbers are not issued.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bookingReferenceNumber")]
    [MaxLength(15)]
    public string? BookingReferenceNumber { get; init; }

    /// <summary>
    /// Airline that generated the ticket.
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    [MaxLength(15)]
    public string? CarrierName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticketIssuer")]
    public TicketIssuer? TicketIssuer { get; init; }

    /// <summary>
    /// Ticket number.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces;
    /// special characters are not included.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticketNumber")]
    [MaxLength(15)]
    public string? TicketNumber { get; init; }

    /// <summary>
    /// Check digit for the ticket number. CyberSource recommends that you validate the check digit.
    /// With Discover and Diners Club, a valid ticket number has these characteristics:
    /// - The value is numeric.
    /// - The first three digits are a valid IATA2 license plate carrier code.
    /// - The last digit is a check digit or zero (0).
    /// - All remaining digits are nonzero.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkDigit")]
    [MaxLength(1)]
    public string? CheckDigit { get; init; }

    /// <summary>
    /// Flag that indicates whether or not the ticket is restricted (nonrefundable).
    /// Possible values:
    /// - 0: No restriction (refundable)
    /// - 1: Restricted (nonrefundable)
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces;
    /// special characters are not included.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restrictedTicketIndicator")]
    public int? RestrictedTicketIndicator { get; init; }

    /// <summary>
    /// Type of charge.
    /// Possible values:
    /// - 01: Charge is for an airline ticket
    /// - 02: Charge is for an item that is not an airline ticket
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionType")]
    public int? TransactionType { get; init; }

    /// <summary>
    /// The field is not currently supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendedPaymentCode")]
    [MaxLength(3)]
    public string? ExtendedPaymentCode { get; init; }

    /// <summary>
    /// Name of the passenger to whom the ticket was issued.  This will always be a single passenger's name.
    /// If there are more than one passengers, provide only the primary passenger's name.
    /// Do not include special characters such as commas, hyphens, or apostrophes.
    /// Only ASCII characters are supported.
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passengerName")]
    [MaxLength(42)]
    public string? PassengerName { get; init; }

    /// <summary>
    /// Reference number or code that identifies the cardholder.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces;
    /// special characters are not included.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerCode")]
    [MaxLength(40)]
    public string? CustomerCode { get; init; }

    /// <summary>
    /// Airline document type code that specifies the purpose of the transaction.
    /// Format: English characters only.
    /// Optional request field.
    /// <para>
    /// | Code | Description |
    /// | --- | --- |
    /// | 01 | Passenger ticket |
    /// | 02 | Additional collection |
    /// | 03 | Excess baggage |
    /// | 04 | Miscellaneous charge order (MCO) or prepaid ticket authorization |
    /// | 05 | Special service ticket |
    /// | 06 | Supported refund |
    /// | 07 | Unsupported refund |
    /// | 08 | Lost ticket application |
    /// | 09 | Tour order voucher |
    /// | 10 | Ticket by mail |
    /// | 11 | Undercharge adjustment |
    /// | 12 | Group ticket |
    /// | 13 | Exchange adjustment |
    /// | 14 | SPD or air freight |
    /// | 15 | In-flight adjustment |
    /// | 16 | Agency passenger ticket |
    /// | 17 | Agency tour order or voucher |
    /// | 18 | Agency miscellaneous charge order (MCO) |
    /// | 19 | Agency exchange order |
    /// | 20 | Agency group ticket |
    /// | 21 | Debit adjustment for duplicate refund or use |
    /// | 22 | In-flight merchandise order |
    /// | 23 | Catalogue merchandise order |
    /// | 24 | In-flight phone charges |
    /// | 25 | Frequent flyer fee or purchase |
    /// | 26 | Kennel charge |
    /// | 27 | Animal transportation charge |
    /// | 28 | Firearms case |
    /// | 29 | Upgrade charge |
    /// | 30 | Credit for unused transportation |
    /// | 31 | Credit for class of service adjustment |
    /// | 32 | Credit for denied boarding |
    /// | 33 | Credit for miscellaneous refund |
    /// | 34 | Credit for lost ticket refund |
    /// | 35 | Credit for exchange refund |
    /// | 36 | Credit for overcharge adjustment |
    /// | 37 | Credit for multiple Unused tickets |
    /// | 38 | Exchange order |
    /// | 39 | Self-service ticket |
    /// | 41 | In-flight duty-free purchase |
    /// | 42 | Senior citizen discount booklets |
    /// | 43 | Club membership fee |
    /// | 44 | Coupon book |
    /// | 45 | In-flight charges |
    /// | 46 | Tour deposit |
    /// | 47 | Frequent flyer overnight delivery charge |
    /// | 48 | Frequent flyer fulfillment |
    /// | 49 | Small package delivery |
    /// | 50 | Vendor sale |
    /// | 51 | Miscellaneous taxes or fees |
    /// | 52 | Travel agency fee |
    /// | 60 | Vendor refund or credit |
    /// | 64 | Duty free sale |
    /// | 65 | Preferred seat upgrade |
    /// | 66 | Cabin upgrade |
    /// | 67 | Lounge or club access or day pass |
    /// | 68 | Agent assisted reservation or ticketing fee |
    /// | 69 | Ticket change or cancel fee |
    /// | 70 | Trip insurance |
    /// | 71 | Unaccompanied minor |
    /// | 72 | Standby fee |
    /// | 73 | Curbside baggage |
    /// | 74 | In-flight medical equipment |
    /// | 75 | Ticket or pass print fee |
    /// | 76 | Checked sporting or special equipment |
    /// | 77 | Dry ice fee |
    /// | 78 | Mail or postage fee |
    /// | 79 | Club membership fee or temporary trial |
    /// | 80 | Frequent flyer activation or reinstatement |
    /// | 81 | Gift certificate |
    /// | 82 | Onboard or in-flight prepaid voucher |
    /// | 83 | Optional services fee |
    /// | 84 | Advance purchase for excess baggage |
    /// | 85 | Advance purchase for preferred seat upgrade |
    /// | 86 | Advance purchase for cabin upgrade |
    /// | 87 | Advance purchase for optional services |
    /// | 88 | WiFi |
    /// | 89 | Packages |
    /// | 90 | In-flight entertainment or internet access |
    /// | 91 | Overweight bag fee |
    /// | 92 | Sleep sets |
    /// | 93 | Special purchase fee |
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentType")]
    [MaxLength(1)]
    public string? DocumentType { get; init; }

    /// <summary>
    /// The field is not currently supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentNumber")]
    [MaxLength(14)]
    public string? DocumentNumber { get; init; }

    /// <summary>
    /// The field is not currently supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentNumberOfParts")]
    public int? DocumentNumberOfParts { get; init; }

    /// <summary>
    /// Invoice number for the airline transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceNumber")]
    [MaxLength(25)]
    public string? InvoiceNumber { get; init; }

    /// <summary>
    /// Invoice date. The format is YYYYMMDD.
    /// If this value is
    /// included in the request, it is used in the creation of the invoice number. See "Invoice Number,"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceDate")]
    public int? InvoiceDate { get; init; }

    /// <summary>
    /// Description of the charge if the charge does not involve an airline ticket.
    /// For example: Excess baggage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalCharges")]
    [MaxLength(20)]
    public string? AdditionalCharges { get; init; }

    /// <summary>
    /// Total fee for the ticket. This value cannot exceed <c>99999999999999999999</c> (twenty 9s).
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalFeeAmount")]
    [MaxLength(12)]
    public string? TotalFeeAmount { get; init; }

    /// <summary>
    /// Number that identifies the clearing message when multiple clearing messages are allowed per authorized transaction.
    /// Each clearing message linked to one authorization request must include a unique clearing sequence number between 1 and the total number of clearing records.
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clearingSequence")]
    [MaxLength(2)]
    public string? ClearingSequence { get; init; }

    /// <summary>
    /// Total number of clearing messages associated with the authorization request.
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clearingCount")]
    [MaxLength(2)]
    public string? ClearingCount { get; init; }

    /// <summary>
    /// Total clearing amount for all transactions in the clearing count set.
    /// This value cannot exceed <c>99999999999999999999</c> (twenty 9s).
    /// Format: English characters only.
    /// If this field is not set and if the total amount from the original authorization is not NULL,
    /// the total clearing amount is set to the total amount from the original authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalClearingAmount")]
    [MaxLength(20)]
    public string? TotalClearingAmount { get; init; }

    /// <summary>
    /// Number of passengers for whom the ticket was issued.
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfPassengers")]
    public int? NumberOfPassengers { get; init; }

    /// <summary>
    /// Code that specifies the computerized reservation system used to make the reservation and purchase the ticket.
    /// Format: English characters only.
    /// Restricted string data type that indicates a sequence of letters, numbers, and spaces;
    /// special characters are not included.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reservationSystemCode")]
    [MaxLength(20)]
    public string? ReservationSystemCode { get; init; }

    /// <summary>
    /// Airline process identifier. This value is the airline’s three-digit IATA1 code
    /// which is used to process extended payment airline tickets.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processIdentifier")]
    [MaxLength(3)]
    public string? ProcessIdentifier { get; init; }

    /// <summary>
    /// Date on which the transaction occurred.
    /// Format: <c>YYYYMMDD</c>
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticketIssueDate")]
    [MaxLength(8)]
    public string? TicketIssueDate { get; init; }

    /// <summary>
    /// Flag that indicates whether an electronic ticket was issued.
    /// Possible values:
    /// - <c>true</c>
    /// - <c>false</c>
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("electronicTicketIndicator")]
    public bool? ElectronicTicketIndicator { get; init; }

    /// <summary>
    /// Original ticket number when the transaction is for a replacement ticket.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalTicketNumber")]
    [MaxLength(14)]
    public string? OriginalTicketNumber { get; init; }

    /// <summary>
    /// Type of purchase. Possible values:
    /// - <c>EXC</c>: Exchange ticket
    /// - <c>MSC</c>: Miscellaneous (not a ticket purchase and not a transaction related to an exchange ticket)
    /// - <c>REF</c>: Refund
    /// - <c>TKT</c>: Ticket
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseType")]
    [MaxLength(3)]
    public string? PurchaseType { get; init; }

    /// <summary>
    /// Reason for the credit.
    /// Possible values:
    /// - <c>A</c>: Cancellation of the ancillary passenger transport purchase.
    /// - <c>B</c>: Cancellation of the airline ticket and the passenger transport ancillary purchase.
    /// - <c>C</c>: Cancellation of the airline ticket.
    /// - <c>O</c>: Other.
    /// - <c>P</c>: Partial refund of the airline ticket.
    /// Format: English characters only.
    /// <para>
    /// Optional request field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creditReasonIndicator")]
    [MaxLength(1)]
    public string? CreditReasonIndicator { get; init; }

    /// <summary>
    /// Type of update.
    /// Possible values:
    /// - <c>C</c>: Change to the existing ticket.
    /// - <c>N</c>: New ticket.
    /// Format: English characters only
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticketChangeIndicator")]
    [MaxLength(1)]
    public string? TicketChangeIndicator { get; init; }

    /// <summary>
    /// Plan number based on the fare.
    /// This value is provided by the airline.
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("planNumber")]
    [MaxLength(1)]
    public string? PlanNumber { get; init; }

    /// <summary>
    /// Date of arrival for the last leg of the trip.
    /// Format: <c>MMDDYYYY</c>
    /// English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("arrivalDate")]
    [MaxLength(8)]
    public string? ArrivalDate { get; init; }

    /// <summary>
    /// Text that describes the ticket limitations, such as _nonrefundable_.
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restrictedTicketDesciption")]
    [MaxLength(20)]
    public string? RestrictedTicketDesciption { get; init; }

    /// <summary>
    /// Amount of the exchanged ticket.
    /// Format: English characters only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeTicketAmount")]
    [MaxLength(12)]
    public string? ExchangeTicketAmount { get; init; }

    /// <summary>
    /// Fee for exchanging the ticket.
    /// Format: English characters only.
    /// Optional request field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeTicketFeeAmount")]
    [MaxLength(12)]
    public string? ExchangeTicketFeeAmount { get; init; }

    /// <summary>
    /// The field is not currently supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reservationType")]
    [MaxLength(32)]
    public string? ReservationType { get; init; }

    /// <summary>
    /// Boarding fee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("boardingFeeAmount")]
    [MaxLength(12)]
    public string? BoardingFeeAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legs")]
    public IReadOnlyList<Leg>? Legs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ancillaryInformation")]
    public AncillaryInformation? AncillaryInformation { get; init; }

    /// <summary>
    /// Specifies the type of flight.
    /// One way (0)
    /// Return (1)
    /// Transit (2)
    /// Transit &amp; Return (3)
    /// Multi-City (4)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flightType")]
    [MaxLength(2)]
    public string? FlightType { get; init; }

    /// <summary>
    /// The total cost of the flight insurance. Example: 10000.00
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insuranceAmount")]
    [MaxLength(255)]
    public string? InsuranceAmount { get; init; }

    /// <summary>
    /// The consumer’s frequent flyer number. Leave 0 if there is no
    /// frequent flyer number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequentFlyerNumber")]
    [MaxLength(255)]
    public string? FrequentFlyerNumber { get; init; }

    /// <summary>
    /// Specifies if the travel agent joins the flight (0) or not (1)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thirdPartyStatus")]
    [MaxLength(255)]
    public string? ThirdPartyStatus { get; init; }

    /// <summary>
    /// List of passenger types in a booking code:
    /// A (Adult)
    /// C (Child)
    /// Comma separated values for total number of passenger
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passengerType")]
    [MaxLength(50)]
    public string? PassengerType { get; init; }

    /// <summary>
    /// Total insurance amount. We have per leg and not total
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalInsuranceAmount")]
    [MaxLength(50)]
    public string? TotalInsuranceAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
