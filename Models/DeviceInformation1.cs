using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record DeviceInformation1
{
    /// <summary>
    /// Account Entry Device Type for Tap to More transactions. This field flows in ISO Field 34 DSID 02 Tag 89.
    /// <para>
    /// Valid Values:
    /// - <c>1</c>: Off-the-shelf mobile consumer
    /// </para>
    /// <para>
    /// Mastercard is introducing changes to support commercialization of Tap to More transactions.
    /// Acquirers globally must be prepared to send a value of 1 (Off-the-shelf mobile-consumer)
    /// in Field 34—Acceptance Environment Data (TLV Format), Dataset ID 02—Acceptance Environment
    /// Additional Data, Tag 89—Account Entry Device Type for Tap to More transactions. Visa will
    /// map this value to a value of 8 (Remote terminal) in Mastercard Data Element 61.10.
    /// </para>
    /// <para>
    /// #### Mapping
    /// - SCMP API Field: customer_device_type
    /// - Simple Order API Field: billTo_deviceType
    /// - CCS: device.type
    /// - NRTF Key: customer_device_type
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceType")]
    [MaxLength(1)]
    public string? DeviceType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
