using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Bin Information of the PAN provided by BinLookUp Service. This is only retrieved when retrieveBinDetails=true is passed as a query parameter.
/// </summary>
public record TmsBinLookup
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccountInformation")]
    public PaymentAccountInformation2? PaymentAccountInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerInformation")]
    public IssuerInformation6? IssuerInformation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
