using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Score
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("factorCodes")]
    public IReadOnlyList<string>? FactorCodes { get; init; }

    /// <summary>
    /// Name of the score model used for the transaction. If you did not include a custom model in your request,
    /// this field contains the name of CyberSource’s default model.
    /// <para>
    /// For all possible values, see the <c>score_model_used</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modelUsed")]
    [MaxLength(255)]
    public string? ModelUsed { get; init; }

    /// <summary>
    /// Total score calculated for this order. The value cannot be negative.
    /// <para>
    /// For all possible values, see the <c>score_score_result</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    [MaxLength(255)]
    public string? Result { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
