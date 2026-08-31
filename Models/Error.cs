using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Error
{
    /// <summary>
    /// The type of error.
    /// <para>
    /// Possible Values:
    ///   - invalidHeaders
    ///   - missingHeaders
    ///   - invalidFields
    ///   - missingFields
    ///   - unsupportedPaymentMethodModification
    ///   - invalidCombination
    ///   - forbidden
    ///   - notFound
    ///   - instrumentIdentifierDeletionError
    ///   - tokenIdConflict
    ///   - conflict
    ///   - notAvailable
    ///   - serverError
    ///   - notAttempted
    /// </para>
    /// <para>
    /// A "notAttempted" error type is returned when the request cannot be processed because it depends on the existence of another token that does not exist. For example, creating a shipping address token is not attempted if the required customer token is missing.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The detailed message related to the type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<Detail43>? Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
