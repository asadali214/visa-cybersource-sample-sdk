using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DeclineAniFlag>))]
public sealed record DeclineAniFlag : StringEnum<DeclineAniFlag>
{
    private DeclineAniFlag(string value) : base(value)
    {
    }

    public static readonly DeclineAniFlag Y = new("Y");

    public static readonly DeclineAniFlag O = new("O");

    public static readonly DeclineAniFlag N = new("N");

    public static readonly DeclineAniFlag U = new("U");

    public static readonly DeclineAniFlag R = new("R");

    public static DeclineAniFlag FromValue(string value) => FromValueCore(value);
}
