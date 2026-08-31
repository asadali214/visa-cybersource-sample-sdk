using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductType>))]
public sealed record ProductType : StringEnum<ProductType>
{
    private ProductType(string value) : base(value)
    {
    }

    public static readonly ProductType Invoicing = new("INVOICING");

    public static readonly ProductType Paybylink = new("PAYBYLINK");

    public static ProductType FromValue(string value) => FromValueCore(value);
}
