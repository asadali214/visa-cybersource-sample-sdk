using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Report Preferences
/// </summary>
public record ReportPreferences
{
    /// <summary>
    /// Indicator to determine whether negative sign infront of amount for all refunded transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signedAmounts")]
    public bool? SignedAmounts { get; init; }

    /// <summary>
    /// Specify the field naming convention to be followed in reports (applicable to only csv report formats)
    /// <para>
    /// Valid values:
    /// - SOAPI
    /// - SCMP
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fieldNameConvention")]
    public string? FieldNameConvention { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
