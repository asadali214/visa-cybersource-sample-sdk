using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReferenceType>))]
public sealed record ReferenceType : StringEnum<ReferenceType>
{
    private ReferenceType(string value) : base(value)
    {
    }

    public static readonly ReferenceType Invoice = new("Invoice");

    public static readonly ReferenceType Purchase = new("Purchase");

    public static readonly ReferenceType Donation = new("Donation");

    public static ReferenceType FromValue(string value) => FromValueCore(value);
}
