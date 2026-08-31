using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains authentication information associated with the token, including details about authenticated identities.
/// </summary>
public record TokenAuthenticationInformation
{
    /// <summary>
    /// An array of authenticated identity objects containing verification data from identity providers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticatedIdentities")]
    public IReadOnlyList<AuthenticatedIdentity>? AuthenticatedIdentities { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
