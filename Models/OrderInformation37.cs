using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record OrderInformation37
{
    /// <summary>
    /// Contains <c>currency</c> and <c>totalAmount</c> for this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountDetails")]
    public AmountDetails38? AmountDetails { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipTo")]
    public ShipTo27? ShipTo { get; init; }

    /// <summary>
    /// This array contains detailed information about individual products in the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lineItems")]
    public IReadOnlyList<LineItem12>? LineItems { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billTo")]
    public BillTo65? BillTo { get; init; }

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
