using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InvoiceDetails5
{
    /// <summary>
    /// Indicates whether CyberSource sent the Level III information to the processor. The possible values are:
    /// <para>
    /// If your account is not enabled for Level III data or if you did not include the purchasing level field in your
    /// request, CyberSource does not include the Level III data in the request sent to the processor.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <b>Y</b> for true
    /// - <b>N</b> for false
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level3TransmissionStatus")]
    public string? Level3TransmissionStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
