using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AuthorizationOptions
{
    /// <summary>
    /// #### Visa Platform Connect
    /// The field contains the PAN translation indicator for American Express Contactless Transaction. Valid value is
    /// <para>
    /// 1- Expresspay Translation, PAN request
    /// 2- Expresspay Translation, PAN and Expiry date request
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("panReturnIndicator")]
    [MaxLength(1)]
    public string? PanReturnIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
