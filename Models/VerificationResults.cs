using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Verification results returned by the issuer during the provisioning when Security Code or Billing Address data is provided on the request.
/// Supported only for VTS tokens.
/// </summary>
public record VerificationResults
{
    /// <summary>
    /// Indicates whether the security code (CVV/CVC) was verified by the issuer during the provisioning request.
    /// Supported only for VTS tokens.
    /// <para>
    /// Possible Values:
    /// - MATCH: Verified, CVV2 data matched.
    /// - NO_MATCH: Verified, CVV2 data did not match.
    /// - NOT_SUPPORTED: Verification not supported by card issuer.
    /// - SKIPPED: Verification was not performed.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("securityCode")]
    public string? SecurityCode { get; init; }

    /// <summary>
    /// Indicates whether the billing address was verified by the issuer during the provisioning request.
    /// Supported only for VTS tokens.
    /// <para>
    /// Possible Values:
    /// - MATCH: Verified, address and postal code data matched.
    /// - PARTIAL_MATCH: Verified, either address data matched or postal code data matched.
    /// - PARTIAL_MATCH_FORMAT_UNSUPPORTED: Verified, either address data matched or postal code data matched, but the other could not be verified due to format issues.
    /// - NO_MATCH: Verified, address and postal code data did not match.
    /// - NOT_SUPPORTED: Verification not supported by card issuer.
    /// - SKIPPED: Verification was not performed.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public string? Address { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
