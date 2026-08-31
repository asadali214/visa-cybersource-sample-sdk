using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TmsPointOfSaleInformation
{
    [JsonPropertyName("emvTags")]
    [MinLength(1)]
    [MaxLength(50)]
    public required IReadOnlyList<EmvTag> EmvTags { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
