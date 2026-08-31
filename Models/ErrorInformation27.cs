using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ErrorInformation27
{
    /// <summary>
    /// The reason of the status. Value can be
    ///   - <c>APARTMENT_NUMBER_NOT_FOUND</c>
    ///   - <c>INSUFFICIENT_ADDRESS_INFORMATION</c>
    ///   - <c>HOUSE_OR_BOX_NUMBER_NOT_FOUND</c>
    ///   - <c>MULTIPLE_ADDRESS_MATCHES</c>
    ///   - <c>BOX_NUMBER_NOT_FOUND</c>
    ///   - <c>ROUTE_SERVICE_NOT_FOUND</c>
    ///   - <c>STREET_NAME_NOT_FOUND</c>
    ///   - <c>POSTAL_CODE_NOT_FOUND</c>
    ///   - <c>UNVERIFIABLE_ADDRESS</c>
    ///   - <c>MULTIPLE_ADDRESS_MATCHES_INTERNATIONAL</c>
    ///   - <c>ADDRESS_MATCH_NOT_FOUND</c>
    ///   - <c>UNSUPPORTED_CHARACTER_SET</c>
    ///   - <c>INVALID_MERCHANT_CONFIGURATION</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The detail message related to the status and reason listed above.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<Detail>? Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
