using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentInstrument1
{
    /// <summary>
    /// Flag that specifies if the Payment Instrument should be made the Customers default.
    /// Possible values:
    /// - true
    /// - false : (default)
    /// </summary>
    [JsonPropertyName("default")]
    public bool? Default { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
