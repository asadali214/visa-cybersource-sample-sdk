using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains detailed response information about the customer's IP address.
/// </summary>
public record IpAddress
{
    /// <summary>
    /// Indicates whether the transaction IP address is associated with a known anonymous proxy.
    /// <para>
    /// For all possible values, see the <c>score_ip_anonymizer_status</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("anonymizerStatus")]
    [MaxLength(255)]
    public string? AnonymizerStatus { get; init; }

    /// <summary>
    /// Name of the city decoded from the IP address used directly or indirectly by the customer to send the order.
    /// <para>
    /// For all possible values, see the <c>score_ip_city</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(255)]
    public string? Locality { get; init; }

    /// <summary>
    /// Name of the country decoded from the IP address used directly or indirectly by the customer to send the order.
    /// <para>
    /// For all possible values, see the <c>score_ip_country</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(255)]
    public string? Country { get; init; }

    /// <summary>
    /// Name of the state decoded from the IP address used directly or indirectly by the customer to send the order.
    /// <para>
    /// For all possible values, see the <c>score_ip_state</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(255)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Routing method decoded from the IP address used directly or indirectly by the customer to send the order.
    /// <para>
    /// For all possible values, see the <c>score_ip_routing_method</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routingMethod")]
    [MaxLength(255)]
    public string? RoutingMethod { get; init; }

    /// <summary>
    /// Provides the name of the organization that owns the ASN. The carrier is responsible for the traffic carried on the network or set of networks designated as an Autonomous System (AS) and identified by the ASN.
    /// While there are more than 27,000 active ASNs, there are fewer carriers, because a single carrier often manages several ASNs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrier")]
    [MaxLength(255)]
    public string? Carrier { get; init; }

    /// <summary>
    /// The Registering Organization is the entity responsible for the actions and content associated with a given block of IP addresses. This is in contrast to the carrier, which is responsible for the routing of traffic for network blocks. Registering Organizations include many types of entities, including corporate, government, or educational entities, and ISPs managing the allocation and use of network blocks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organization")]
    [MaxLength(255)]
    public string? Organization { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
