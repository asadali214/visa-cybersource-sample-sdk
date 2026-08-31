using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Flags indicating what authentication, binding, and trusted-beneficiary enrollment capabilities the issuer supports.
/// Supported only for VTS Tokens.
/// </summary>
public record Capabilities
{
    /// <summary>
    /// Indicates if the issuer supports device binding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceBindingSupported")]
    public bool? DeviceBindingSupported { get; init; }

    /// <summary>
    /// Indicates if the issuer participates in step-up authentication that requires cardholder verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardholderVerificationSupported")]
    public bool? CardholderVerificationSupported { get; init; }

    /// <summary>
    /// Indicates if the issuer supports trusted beneficiary enrollment.
    /// e.g allowing cardholders to designate trusted merchants or payment recipients that can be exempt from step-up authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trustedBeneficiaryEnrollmentSupported")]
    public bool? TrustedBeneficiaryEnrollmentSupported { get; init; }

    /// <summary>
    /// Indicates if the issuer supports delegated authentication.
    /// e.g allowing approved thrird parties to perform authentication on behalf of the issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delegatedAuthenticationSupported")]
    public bool? DelegatedAuthenticationSupported { get; init; }

    /// <summary>
    /// Indicates if the issuer supports on-behalf-of device binding.
    /// e.g allowing approved third parties to perform device binding on behalf of the issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oboDeviceBindingSupported")]
    public bool? OboDeviceBindingSupported { get; init; }

    /// <summary>
    /// Indicates if the issuer supports receiving token lifecycle management notifications.
    /// e.g receiving updates on changes to the token's status or attributes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenLcmNotificationsSupported")]
    public bool? TokenLcmNotificationsSupported { get; init; }

    /// <summary>
    /// Indicates if the issuer supports receiving PAN lifecycle management notifications.
    /// e.g receiving updates on changes to the underlying card's status or attributes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fpanLcmNotificationsSupported")]
    public bool? FpanLcmNotificationsSupported { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
