using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ShippingDetails5
{
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
