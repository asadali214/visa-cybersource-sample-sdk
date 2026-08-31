using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

/// <summary>
/// Indicates the kind of alias provided (phone, email, account number, business number, or organization ID).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : StringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 Phone = new("phone");

    public static readonly Type2 Email = new("email");

    public static readonly Type2 AccountNumber = new("accountNumber");

    public static readonly Type2 BusinessNumber = new("businessNumber");

    public static readonly Type2 AccountId = new("accountID");

    public static Type2 FromValue(string value) => FromValueCore(value);
}
