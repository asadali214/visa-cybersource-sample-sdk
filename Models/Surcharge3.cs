using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Surcharge3
{
    /// <summary>
    /// Surcharge amount that you are charging the customer for this subscription. The surcharge amount will be added to the billing amount.
    /// The issuer can provide information about the surcharge amount to the customer.
    /// <para>
    /// <b>NOTE</b>: This field is supported only for CyberSource through VisaNet (CtV) for Payouts. For CtV, the maximum string length is 8.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    [MaxLength(15)]
    public string? Amount { get; init; }

    /// <summary>
    /// Description of the surcharge.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(255)]
    public string? Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
