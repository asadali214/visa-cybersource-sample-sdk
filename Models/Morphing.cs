using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Morphing
{
    /// <summary>
    /// Morphing count specified by the number #.
    /// <para>
    /// <b>Note</b> The count is not returned for the initial transaction.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public int? Count { get; init; }

    /// <summary>
    /// Field name of the morphing element. specified by the setting that you chose in the
    /// Velocity Editor.
    /// <para>
    /// For all possible values, see the <c>decisionReply_morphingElement_#_fieldName</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fieldName")]
    [MaxLength(255)]
    public string? FieldName { get; init; }

    /// <summary>
    /// Identifier that CyberSource assigned to the velocity rule specified by the number #.
    /// <para>
    /// For all possible values, see the <c>decision_velocity_morphing_#_info_code</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt;
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("informationCode")]
    [MaxLength(255)]
    public string? InformationCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
