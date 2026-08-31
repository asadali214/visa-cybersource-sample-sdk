using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record OrderInformation
{
    /// <summary>
    /// Request field for merchant to increase the AUTH expiry days for Klarna Advantage Plus.
    /// Applicable for Re-Authorization (AP_REAUTH) service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extensionDays")]
    [MaxLength(19)]
    public string? ExtensionDays { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountDetails")]
    public AmountDetails? AmountDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billTo")]
    public BillTo? BillTo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipTo")]
    public ShipTo? ShipTo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lineItems")]
    public IReadOnlyList<LineItem>? LineItems { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceDetails")]
    public InvoiceDetails? InvoiceDetails { get; init; }

    /// <summary>
    /// Contains shipping information not related to address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingDetails")]
    public ShippingDetails? ShippingDetails { get; init; }

    /// <summary>
    /// Digital currency information for the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("digitalCurrency")]
    public DigitalCurrency? DigitalCurrency { get; init; }

    /// <summary>
    /// This is only needed when you are requesting both payment and DM service at same time.
    /// <para>
    /// Boolean that indicates whether returns are accepted for this order.
    /// This field can contain one of the following values:
    /// - true: Returns are accepted for this order.
    /// - false: Returns are not accepted for this order.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnsAccepted")]
    public bool? ReturnsAccepted { get; init; }

    /// <summary>
    /// #### Visa Platform Connect :
    /// This API will contain the Flag that specifies whether the payment is for the purchase of cryptocurrency.
    /// Additional values to add :
    /// This API will contain the Flag that specifies whether the payment is for the purchase of cryptocurrency.
    /// valid values are
    /// - Y/y, true
    /// - N/n, false
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isCryptocurrencyPurchase")]
    public string? IsCryptocurrencyPurchase { get; init; }

    /// <summary>
    /// Starting date and time for an event or a journey that is independent of which transportation mechanism, in UTC. The cutoffDateTime will supersede travelInformation.transit.airline.legs[].departureDate and travelInformation.transit.airline.legs[].departureTime if these fields are supplied in the request.
    /// Format: YYYY-MM-DDThh:mm:ssZ. Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cutoffDateTime")]
    public string? CutoffDateTime { get; init; }

    /// <summary>
    /// Indicates whether cardholder is placing an order with a future availability or release date.
    /// This field can contain one of these values:
    /// - MERCHANDISE_AVAILABLE: Merchandise available
    /// - FUTURE_AVAILABILITY: Future availability
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preOrder")]
    public string? PreOrder { get; init; }

    /// <summary>
    /// Expected date that a pre-ordered purchase will be available. Format: YYYYMMDD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preOrderDate")]
    [MaxLength(10)]
    public string? PreOrderDate { get; init; }

    /// <summary>
    /// Indicates whether the cardholder is reordering previously purchased merchandise.
    /// This field can contain one of these values:
    /// - false: First time ordered
    /// - true: Reordered
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reordered")]
    public bool? Reordered { get; init; }

    /// <summary>
    /// Total number of articles/items in the order as a numeric decimal count.
    /// Possible values: 00 - 99
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalOffersCount")]
    [MaxLength(2)]
    public string? TotalOffersCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
