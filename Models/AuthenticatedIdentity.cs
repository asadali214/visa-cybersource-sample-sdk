using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models.Enums;

namespace CyberSourceMergedSpec.Models;

public record AuthenticatedIdentity
{
    /// <summary>
    /// Data related to the authenticated identity. Contains verification payload from the identity provider.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    [MaxLength(22000)]
    public string? Data { get; init; }

    /// <summary>
    /// Provider of the authenticated identity. Identifies the authentication service or identity provider.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provider")]
    public Provider? Provider { get; init; }

    /// <summary>
    /// Unique identifier for the authenticated identity. A distinctive and non-transparent identifier for correlation purposes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(50)]
    public string? Id { get; init; }

    /// <summary>
    /// Identifier of the relying party that requested the authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("relyingPartyId")]
    [MaxLength(2000)]
    public string? RelyingPartyId { get; init; }

    /// <summary>
    /// The method used to authenticate the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userAuthenticationMethod")]
    public UserAuthenticationMethod? UserAuthenticationMethod { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
