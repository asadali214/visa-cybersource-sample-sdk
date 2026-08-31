using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation18
{
    /// <summary>
    /// Array of actions (one or more) to be included in the payment to invoke bundled services along with payment status.
    /// <para>
    /// Possible values are one or more of follows:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>AP_STATUS</c>: Use this when Alternative Payment check status service is requested.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AP_SESSION_STATUS</c>: Use this when Alternative Payment check status service for Paypal, Klarna is requested.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AP_INITIATE_STATUS</c>: Use this when Alternative Payment check status service for KCP is requested.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AP_ORDER_STATUS</c>: Use this when Alternative Payment check status service for order status request.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AP_AUTH_STATUS</c>: Use this when Alternative Payment check status service for auth status request.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AP_CAPTURE_STATUS</c>: Use this when Alternative Payment check status service for capture status request.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AP_REFUND_STATUS</c>: Use this when Alternative Payment check status service for refund status request.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
