using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AuthenticatedIdentity1
{
    /// <summary>
    /// The id from the authenticated identity.
    ///  Base64URL encoded string (RFC4648).
    ///  The encoding is the same as Base64, but uses '-' characters instead of '+' and '_' characters instead of '/'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(50)]
    [RegularExpression("[A-Za-z0-9=-_]+")]
    public string? Id { get; init; }

    /// <summary>
    /// The provider of the authenticated identity.
    /// <para>
    /// Possible Values:
    ///   - VISA_PAYMENT_PASSKEY
    ///   - CLIENT_DEVICE_CERT_JWS
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provider")]
    public string? Provider { get; init; }

    /// <summary>
    /// The data from the authenticated identity.
    /// For Passkey this could be the FIDO Attestation.
    /// For Classic Cloud Token Framework (CTF) this could be a JWS containing device authentication information signed by a devices private key.
    /// Base64URL encoded string (RFC4648).
    /// The encoding is the same as Base64, but uses '-' characters instead of '+' and '_' characters instead of '/'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    [MaxLength(17000)]
    [RegularExpression("[A-Za-z0-9=-_]+")]
    public string? Data { get; init; }

    /// <summary>
    /// The id of the Relying Party.
    ///  Base64URL encoded string (RFC4648).
    ///  The encoding is the same as Base64, but uses '-' characters instead of '+' and '_' characters instead of '/'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("relyingPartyId")]
    [MaxLength(2000)]
    [RegularExpression("[A-Za-z0-9=-_]+")]
    public string? RelyingPartyId { get; init; }

    /// <summary>
    /// The method used to authenticate the user.
    /// <para>
    /// Possible Values:
    ///   - USERNAME_PASSWORD
    ///   - PASSCODE_PASSWORD
    ///   - PASSCODE
    ///   - PASSWORD
    ///   - PATTERN
    ///   - BIOMETRIC_FINGERPRINT
    ///   - BIOMETRIC_FACIAL
    ///   - BIOMETRIC_IRIS
    ///   - BIOMETRIC_VOICE
    ///   - BIOMETRIC_BEHAVIORAL
    ///   - DEVICE_UNLOCKED_METHOD_UNKNOWN
    ///   - OTP_SMS
    ///   - OTP_EMAIL
    ///   - OTP_SMS_KNOWLEDGE
    ///   - KNOWLEDGE_BASED_AUTHENTICATION
    ///   - USER_UNVERIFIED
    ///   - BIOMETRIC
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("userAuthenticationMethod")]
    public string? UserAuthenticationMethod { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
