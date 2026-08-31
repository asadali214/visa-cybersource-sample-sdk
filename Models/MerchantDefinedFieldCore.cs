using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models.Enums;

namespace CyberSourceMergedSpec.Models;

public record MerchantDefinedFieldCore
{
    [JsonPropertyName("fieldType")]
    public required FieldType FieldType { get; init; }

    [JsonPropertyName("label")]
    [MaxLength(100)]
    public required string Label { get; init; }

    [JsonPropertyName("customerVisible")]
    public bool? CustomerVisible { get; init; } = false;

    /// <summary>
    /// Should be used only if fieldType = "text"
    /// </summary>
    [JsonPropertyName("textMinLength")]
    public int? TextMinLength { get; init; } = 0;

    /// <summary>
    /// Should be used only if fieldType = "text"
    /// </summary>
    [JsonPropertyName("textMaxLength")]
    public int? TextMaxLength { get; init; } = 100;

    /// <summary>
    /// Should be used only if fieldType = "text"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("textDefaultValue")]
    [MaxLength(100)]
    public string? TextDefaultValue { get; init; }

    /// <summary>
    /// Should be mandatory and used only if fieldType = "select"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("possibleValues")]
    [MaxLength(600)]
    public string? PossibleValues { get; init; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; init; } = false;

    [JsonPropertyName("merchantDefinedDataIndex")]
    public required int MerchantDefinedDataIndex { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
