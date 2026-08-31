using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains shipping details information for Klarna Advantage Plus Capture transactions.
/// </summary>
public record ShippingDetails1
{
    /// <summary>
    /// Postal code for the address from which the goods are shipped, which is used to establish nexus. The default is
    /// the postal code associated with your CyberSource account.
    /// <para>
    /// The postal code must consist of 5 to 9 digits. When the billing country is the U.S., the 9-digit postal code
    /// must follow this format:
    /// </para>
    /// <para>
    /// <c>[5 digits][dash][4 digits]</c>
    /// </para>
    /// <para>
    /// Example 12345-6789
    /// </para>
    /// <para>
    /// When the billing country is Canada, the 6-digit postal code must follow this format:
    /// </para>
    /// <para>
    /// <c>[alpha][numeric][alpha][space] [numeric][alpha][numeric]</c>
    /// </para>
    /// <para>
    /// Example A1B 2C3
    /// </para>
    /// <para>
    /// This field is frequently used for Level II and Level III transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipFromPostalCode")]
    [MaxLength(10)]
    public string? ShipFromPostalCode { get; init; }

    /// <summary>
    /// Shipment tracking number provided by the merchant.
    /// Used to track the shipment of goods to the customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trackingNumber")]
    [MaxLength(100)]
    public string? TrackingNumber { get; init; }

    /// <summary>
    /// URL where the customer can track their shipment.
    /// Provides real-time tracking information for the delivery.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trackingUrl")]
    [MaxLength(1024)]
    public string? TrackingUrl { get; init; }

    /// <summary>
    /// Name of the shipping carrier/company handling the delivery.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingCarrier")]
    [MaxLength(255)]
    public string? ShippingCarrier { get; init; }

    /// <summary>
    /// Estimated delivery date for the shipment provided by Merchant.
    /// Format: YYYYMMDD (e.g., 20251115 for November 15, 2025)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimatedDeliveryDate")]
    [RegularExpression("^[0-9]{8}$")]
    public string? EstimatedDeliveryDate { get; init; }

    /// <summary>
    /// Shipping method for the product. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>lowcost</c>: Lowest-cost service</description></item>
    ///   <item><description><c>sameday</c>: Courier or same-day service</description></item>
    ///   <item><description><c>oneday</c>: Next-day or overnight service</description></item>
    ///   <item><description><c>twoday</c>: Two-day service</description></item>
    ///   <item><description><c>threeday</c>: Three-day service</description></item>
    ///   <item><description><c>pickup</c>: Store pick-up</description></item>
    ///   <item><description><c>other</c>: Other shipping method</description></item>
    ///   <item><description><c>none</c>: No shipping method because product is a service or subscription</description></item>
    /// </list>
    /// <para>
    /// Klarna Advantage Plus additional values:
    ///  - <c>TO_DOOR</c>: Delivery to door
    ///  - <c>TO_CURB</c>: Delivery to curb
    ///  - <c>TO_MAILBOX</c>: Delivery to mailbox
    ///  - <c>PICKUP_BOX</c>: Pickup from box
    ///  - <c>PICKUP_POINT</c>: Pickup from point
    ///  - <c>PICKUP_STORE</c>: Pickup from store
    ///  - <c>PICKUP_WAREHOUSE</c>: Pickup from warehouse
    ///  - <c>DIGITAL_EMAIL</c>: Digital delivery via email
    ///  - <c>DIGITAL_DOWNLOAD</c>: Digital download
    ///  - <c>DIGITAL_OTHER</c>: Other digital delivery
    ///  - <c>PHYSICAL_OTHER</c>: Other physical delivery
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingMethod")]
    [MaxLength(32)]
    public string? ShippingMethod { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
