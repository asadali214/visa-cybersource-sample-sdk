using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

/// <summary>
/// Identifies the type of schedule as either recurring, one-off, split or usage.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : StringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Recurring = new("recurring");

    public static readonly Type1 Oneoff = new("oneoff");

    public static readonly Type1 Split = new("split");

    public static readonly Type1 Usage = new("usage");

    public static Type1 FromValue(string value) => FromValueCore(value);
}
