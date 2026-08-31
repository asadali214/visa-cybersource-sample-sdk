using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record FluidData7
{
    /// <summary>
    /// The identifier for a payment solution, which is sending the encrypted payment data for decryption. Valid values:
    /// Samsung Pay: RklEPUNPTU1PTi5TQU1TVU5HLklOQVBQLlBBWU1FTlQ=
    /// Note: For other payment solutions, the value may be specific to the terminal or device initiatinf the payment. For example, the descriptor for a Bluefin payment encryption would be a device-generated descriptor.
    /// Used by Authorization and Standalone Credits. Required for authorizations and standalone credits.
    /// <para>
    /// Card Present processing:
    /// Format of the encrypted payment data.
    /// The value for Bluefin PCI P2PE is <c>Ymx1ZWZpbg==</c>. paymentInformation.fluidData.encoding must be <c>Base64</c>.
    /// The value for Cybersource P2PE decryption depends on the encoding method used and identified in encoding field.
    /// If paymentInformation.fluidData.encoding is <c>Base64</c>, the value is: <c>RklEPUVNVi5QQVlNRU5ULkFQSQ==</c>
    /// If paymentInformation.fluidData.encoding is <c>HEX</c>, the value is: <c>4649443D454D562E5041594D454E542E41504</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("descriptor")]
    [MaxLength(128)]
    public string? Descriptor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
