using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

/// <summary>
/// Provider of the authenticated identity. Identifies the authentication service or identity provider.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Provider>))]
public sealed record Provider : StringEnum<Provider>
{
    private Provider(string value) : base(value)
    {
    }

    public static readonly Provider ClientDeviceCertJws = new("CLIENT_DEVICE_CERT_JWS");

    public static readonly Provider VisaPaymentPasskey = new("VISA_PAYMENT_PASSKEY");

    public static Provider FromValue(string value) => FromValueCore(value);
}
