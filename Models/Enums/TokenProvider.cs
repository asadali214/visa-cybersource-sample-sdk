using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TokenProvider>))]
public sealed record TokenProvider : StringEnum<TokenProvider>
{
    private TokenProvider(string value) : base(value)
    {
    }

    public static readonly TokenProvider Vts = new("vts");

    public static readonly TokenProvider Mdes = new("mdes");

    public static readonly TokenProvider Amex = new("amex");

    public static readonly TokenProvider Mscof = new("mscof");

    public static TokenProvider FromValue(string value) => FromValueCore(value);
}
