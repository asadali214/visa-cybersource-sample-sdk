using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Identifies a risk profile.
/// </summary>
public record Profile
{
    /// <summary>
    /// Name of the active profile chosen by the profile selector. If no profile selector exists,
    /// the default active profile is chosen.
    /// <para>
    /// <b>Note</b> By default, your default profile is the active profile, or the Profile Selector chooses the active profile. Use this field
    /// only if you want to specify the name of a different profile. The passed-in profile will then become the active profile.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(30)]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
