using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

/// <summary>
/// The method used to authenticate the user.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UserAuthenticationMethod>))]
public sealed record UserAuthenticationMethod : StringEnum<UserAuthenticationMethod>
{
    private UserAuthenticationMethod(string value) : base(value)
    {
    }

    public static readonly UserAuthenticationMethod UsernamePassword = new("USERNAME_PASSWORD");

    public static readonly UserAuthenticationMethod PasscodePassword = new("PASSCODE_PASSWORD");

    public static readonly UserAuthenticationMethod Passcode = new("PASSCODE");

    public static readonly UserAuthenticationMethod Password = new("PASSWORD");

    public static readonly UserAuthenticationMethod Pattern = new("PATTERN");

    public static readonly UserAuthenticationMethod BiometricFingerprint = new("BIOMETRIC_FINGERPRINT");

    public static readonly UserAuthenticationMethod BiometricFacial = new("BIOMETRIC_FACIAL");

    public static readonly UserAuthenticationMethod BiometricIris = new("BIOMETRIC_IRIS");

    public static readonly UserAuthenticationMethod BiometricVoice = new("BIOMETRIC_VOICE");

    public static readonly UserAuthenticationMethod BiometricBehavioral = new("BIOMETRIC_BEHAVIORAL");

    public static readonly UserAuthenticationMethod DeviceUnlockedMethodUnknown = new("DEVICE_UNLOCKED_METHOD_UNKNOWN");

    public static readonly UserAuthenticationMethod OtpSms = new("OTP_SMS");

    public static readonly UserAuthenticationMethod OtpEmail = new("OTP_EMAIL");

    public static readonly UserAuthenticationMethod OtpSmsKnowledge = new("OTP_SMS_KNOWLEDGE");

    public static readonly UserAuthenticationMethod KnowledgeBasedAuthentication = new("KNOWLEDGE_BASED_AUTHENTICATION");

    public static readonly UserAuthenticationMethod UserUnverified = new("USER_UNVERIFIED");

    public static readonly UserAuthenticationMethod Biometric = new("BIOMETRIC");

    public static UserAuthenticationMethod FromValue(string value) => FromValueCore(value);
}
