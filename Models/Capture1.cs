using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Capture1
{
    /// <summary>
    /// The status of the submitted transaction.
    /// <para>
    /// Possible values:
    ///  - PENDING
    ///  - TRANSMITTED (Only for Online Capture enabled merchants)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The reason of the status.
    /// <para>
    /// Possible values:
    ///  - MISSING_FIELD
    ///  - INVALID_DATA
    ///  - DUPLICATE_REQUEST
    ///  - INVALID_MERCHANT_CONFIGURATION
    ///  - EXCEEDS_AUTH_AMOUNT
    ///  - AUTH_ALREADY_REVERSED
    ///  - TRANSACTION_ALREADY_SETTLED
    ///  - INVALID_AMOUNT
    ///  - MISSING_AUTH
    ///  - TRANSACTION_ALREADY_REVERSED_OR_SETTLED
    ///  - NOT_SUPPORTED
    /// </para>
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
