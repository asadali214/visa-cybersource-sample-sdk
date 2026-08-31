using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Validateconsumerauthentication
{
    /// <summary>
    /// The status for payerAuthentication 201 enroll and validate calls. Possible values are:
    /// - <c>AUTHENTICATION_SUCCESSFUL</c>
    /// - <c>PENDING_AUTHENTICATION</c>
    /// - <c>AUTHENTICATION_FAILED</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The reason of the status. Possible values are:
    /// - <c>INVALID_MERCHANT_CONFIGURATION</c>
    /// - <c>CONSUMER_AUTHENTICATION_REQUIRED</c>
    /// - <c>CONSUMER_AUTHENTICATION_FAILED</c>
    /// - <c>AUTHENTICATION_FAILED</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The message describing the reason of the status. Value is:
    /// - Encountered a Payer Authentication problem. Payer could not be authenticated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
