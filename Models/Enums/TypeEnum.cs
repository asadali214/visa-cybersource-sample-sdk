using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

/// <summary>
/// Indicates the kind of alias (phone, email, account number, business number, or account ID)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Phone = new("phone");

    public static readonly TypeEnum Email = new("email");

    public static readonly TypeEnum AccountNumber = new("accountNumber");

    public static readonly TypeEnum BusinessNumber = new("businessNumber");

    public static readonly TypeEnum AccountId = new("accountID");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
