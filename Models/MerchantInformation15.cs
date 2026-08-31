using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantInformation15
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDescriptor")]
    public MerchantDescriptor? MerchantDescriptor { get; init; }

    /// <summary>
    /// customer would be redirected to this url based on the decision of the transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancelUrl")]
    [MaxLength(255)]
    public string? CancelUrl { get; init; }

    /// <summary>
    /// customer would be redirected to this url based on the decision of the transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("successUrl")]
    [MaxLength(2048)]
    public string? SuccessUrl { get; init; }

    /// <summary>
    /// customer would be redirected to this url based on the decision of the transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failureUrl")]
    [MaxLength(255)]
    public string? FailureUrl { get; init; }

    /// <summary>
    /// Free-form text field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noteToBuyer")]
    [MaxLength(25)]
    public string? NoteToBuyer { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
