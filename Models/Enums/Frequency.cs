using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

/// <summary>
/// Regularity with which the event occurs.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Frequency>))]
public sealed record Frequency : StringEnum<Frequency>
{
    private Frequency(string value) : base(value)
    {
    }

    public static readonly Frequency Annual = new("annual");

    public static readonly Frequency Monthly = new("monthly");

    public static readonly Frequency Quarterly = new("quarterly");

    public static readonly Frequency Semiannual = new("semiannual");

    public static readonly Frequency Weekly = new("weekly");

    public static readonly Frequency Daily = new("daily");

    public static readonly Frequency Adhoc = new("adhoc");

    public static readonly Frequency Intraday = new("intraday");

    public static readonly Frequency Fortnightly = new("fortnightly");

    public static Frequency FromValue(string value) => FromValueCore(value);
}
