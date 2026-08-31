using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Fingerprint
{
    /// <summary>
    /// Customer’s true IP address detected by the application.
    /// <para>
    /// For details, see the <c>true_ipaddress</c> field description in _Device Fingerprinting Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Device Fingerprinting Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("true_ipaddress")]
    [MaxLength(255)]
    public string? TrueIpaddress { get; init; }

    /// <summary>
    /// The unique identifier of the device that is returned in the <c>riskInformation.providers.fingerprint.device_fingerprint_hash</c> API reply field.
    /// For more details about this field, see the <c>device_fingerprint_hash</c> field description in the _Device Fingerprinting Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Device Fingerprinting Guide_ (PDF link).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hash")]
    [MaxLength(255)]
    public string? Hash { get; init; }

    /// <summary>
    /// The device identifier generated from attributes collected during profiling. Returned by a 3rd party when you use device fingerprinting.
    /// <para>
    /// For details, see the <c>device_fingerprint_smart_id</c> field description in <see href="https://www.cybersource.com/developers/documentation/fraud_management">CyberSource Decision Manager Device Fingerprinting Guide.</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smartId")]
    [MaxLength(255)]
    public string? SmartId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
