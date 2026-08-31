using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Enum;

namespace CyberSourceMergedSpec.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AssetType>))]
public sealed record AssetType : StringEnum<AssetType>
{
    private AssetType(string value) : base(value)
    {
    }

    public static readonly AssetType CardArtCombined = new("card-art-combined");

    public static readonly AssetType BrandLogo = new("brand-logo");

    public static readonly AssetType IssuerLogo = new("issuer-logo");

    public static readonly AssetType IconLogo = new("icon-logo");

    public static AssetType FromValue(string value) => FromValueCore(value);
}
