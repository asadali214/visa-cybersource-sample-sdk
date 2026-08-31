using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ConsumerAuthenticationInformation9
{
    /// <summary>
    /// Payer authentication transaction identifier passed to link the check enrollment
    /// and validate authentication messages.For Rupay,this is passed only in Re-Send OTP usecase.
    /// <b>Note</b>: Required for Standard integration, Rupay Seamless server to server integration for enroll service.
    /// Required for Hybrid integration for validate service.
    /// </summary>
    [JsonPropertyName("authenticationTransactionId")]
    [MaxLength(26)]
    public required string AuthenticationTransactionId { get; init; }

    /// <summary>
    /// Authentication transaction context is used as a unique identifier to link enroll and validate call.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationTransactionContext")]
    [MaxLength(256)]
    public string? AuthenticationTransactionContext { get; init; }

    /// <summary>
    /// OTP entered by the card holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("otpToken")]
    [MaxLength(255)]
    public string? OtpToken { get; init; }

    /// <summary>
    /// JWT returned by the 3D Secure provider when the authentication is complete. Required for Hybrid integration if you use the Cybersource-generated access token. Note: Max. length of this field is 2048 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseAccessToken")]
    public string? ResponseAccessToken { get; init; }

    /// <summary>
    /// Provides additional information as to why the PAResStatus has a specific value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signedParesStatusReason")]
    [MaxLength(2)]
    public string? SignedParesStatusReason { get; init; }

    /// <summary>
    /// Payer authentication result (PARes) message returned by the card-issuing bank.
    /// If you need to show proof of enrollment checking, you may need to
    /// decrypt and parse the string for the information required by the payment card company.
    /// For more information, see "Storing Payer Authentication Data," page 160.
    /// Important The value is in base64. You must remove all carriage returns and line feeds before
    /// adding the PARes to the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signedPares")]
    public string? SignedPares { get; init; }

    /// <summary>
    /// Enables the communication of trusted beneficiary/whitelist status between the ACS, the DS and the 3DS Requestor.
    /// <para>
    /// Possible Values:
    /// </para>
    /// <para>
    /// Y - 3DS Requestor is whitelisted by cardholder
    /// </para>
    /// <para>
    /// N - 3DS Requestor is not whitelisted by cardholder
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whiteListStatus")]
    [MaxLength(1)]
    public string? WhiteListStatus { get; init; }

    /// <summary>
    /// A flag to indicate if the passed credential has been encrypted by the Merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credentialEncrypted")]
    [MaxLength(10)]
    public string? CredentialEncrypted { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
