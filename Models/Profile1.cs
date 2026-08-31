using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Profile1
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

    /// <summary>
    /// Name of the queue where orders that are not automatically accepted are sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("desinationQueue")]
    [MaxLength(255)]
    public string? DesinationQueue { get; init; }

    /// <summary>
    /// Name of the profile selector rule that chooses the profile to use for the
    /// transaction. If no profile selector exists, the value is Default Active Profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectorRule")]
    [MaxLength(255)]
    public string? SelectorRule { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
