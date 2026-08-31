using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Embedded2
{
    /// <summary>
    /// Bin Information of the PAN provided by BinLookUp Service. This is only retrieved when retrieveBinDetails=true is passed as a query parameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("binLookup")]
    public TmsBinLookup? BinLookup { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
