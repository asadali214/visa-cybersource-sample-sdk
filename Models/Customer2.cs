using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Customer2
{
    /// <summary>
    /// Personal identifier result. This field is supported only for Redecard in Brazil for CyberSource Latin
    /// American Processing. If you included <c>buyerInformation.personalIdentification[].ID</c> in the request, this
    /// value indicates whether or not <c>buyerInformation.personalIdentification[].ID</c> matched a value in a record
    /// on file. Returned only when the personal ID result is returned by the processor.
    /// <para>
    /// Possible values:
    /// </para>
    /// <para>
    ///  - <c>Y</c>: Match
    ///  - <c>N</c>: No match
    ///  - <c>K</c>: Not supported
    ///  - <c>U</c>: Unknown
    ///  - <c>Z</c>: No response returned
    /// <b>Note</b> CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America.The information in this field description is for the specific processing
    /// connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalIdResult")]
    [MaxLength(1)]
    public string? PersonalIdResult { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
