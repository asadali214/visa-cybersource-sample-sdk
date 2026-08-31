using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AncillaryInformation2
{
    /// <summary>
    /// Ticket number, which consists of the carrier code, form, and serial number, without the check digit.
    /// <b>Important</b> This field is required in the U.S. in order for you to qualify for either the
    /// custom payment service (CPS) or the electronic interchange reimbursement fee (EIRF) program.
    /// Format: English characters only.
    /// Optional field for ancillary services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticketNumber")]
    [MaxLength(15)]
    public string? TicketNumber { get; init; }

    /// <summary>
    /// Name of the passenger. If the passenger’s name is not available, this value is the cardholder’s name. If neither the passenger’s name nor the cardholder’s name is available,
    /// this value is a description of the ancillary purchase.
    /// <b>Important</b> This field is required in the U.S. in order for you to qualify for either the custom payment service (CPS) or the electronic interchange reimbursement fee (EIRF)
    /// program.
    /// Format: English characters only.
    /// Optional field for ancillary service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passengerName")]
    [MaxLength(20)]
    public string? PassengerName { get; init; }

    /// <summary>
    /// Number for the airline ticket to which the ancillary purchase is connected.
    /// <para>
    /// If this purchase has a connection or relationship to another purchase such as a baggage fee for a passenger transport ticket, this field must contain the ticket number for the other purchase.
    /// </para>
    /// <para>
    /// For a stand-alone purchase, the value for this field must be the same as the value for the <c>travelInformation.transit.airline.ancillaryInformation.ticketNumber</c> field.
    /// <b>Important</b> This field is required in the U.S. in order for you to qualify for either the custom payment service (CPS) or the electronic interchange reimbursement fee (EIRF)
    /// program.
    /// Format: English characters only.
    /// Optional request field for ancillary services.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connectedTicketNumber")]
    [MaxLength(15)]
    public string? ConnectedTicketNumber { get; init; }

    /// <summary>
    /// Reason for the credit.
    /// Possible values:
    /// - <c>A</c>: Cancellation of the ancillary passenger transport purchase.
    /// - <c>B</c>: Cancellation of the airline ticket and the passenger transport ancillary purchase.
    /// - <c>C</c>: Cancellation of the airline ticket.
    /// - <c>O</c>: Other.
    /// - <c>P</c>: Partial refund of the airline ticket.
    /// Format: English characters only.
    /// Optional field for ancillary services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creditReasonIndicator")]
    [MaxLength(15)]
    public string? CreditReasonIndicator { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("service")]
    public IReadOnlyList<Service2>? Service { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
