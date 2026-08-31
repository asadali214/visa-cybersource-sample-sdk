using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ReportingV3InterchangeClearingLevelDetailsGet200Response
{
    /// <summary>
    /// Valid report Start Date in <b>ISO 8601 format</b>.
    /// Please refer the following link to know more about ISO 8601 format.
    /// - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14
    /// <para>
    /// <b>Example:</b>
    /// - yyyy-MM-dd'T'HH:mm:ss.SSSZZ
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDate")]
    public DateTimeOffset? StartDate { get; init; }

    /// <summary>
    /// Valid report Start Date in <b>ISO 8601 format</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endDate")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// List of InterchangeClearingLevelDetail
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchangeClearingLevelDetails")]
    public IReadOnlyList<InterchangeClearingLevelDetail>? InterchangeClearingLevelDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
