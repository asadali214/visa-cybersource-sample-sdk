using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AgreementInformation
{
    /// <summary>
    /// Identifier for the mandate being signed for. This mandate id is required for all the subsequent transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("agreementId")]
    public string? AgreementId { get; init; }

    /// <summary>
    /// The processor specific billing agreement ID. References an approved recurring payment for goods or services. This value is sent by merchant via Cybersource to processor. The value sent in this field is procured by the merchant from the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(128)]
    public string? Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
