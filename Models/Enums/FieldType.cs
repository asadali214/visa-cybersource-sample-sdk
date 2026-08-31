using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FieldType>))]
public sealed record FieldType : StringEnum<FieldType>
{
    private FieldType(string value) : base(value)
    {
    }

    public static readonly FieldType Text = new("text");

    public static readonly FieldType Select = new("select");

    public static FieldType FromValue(string value) => FromValueCore(value);
}
