using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Surcharge2
{
    /// <summary>
    /// The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking.
    /// The issuer can provide information about the surcharge amount to the customer.
    /// <para>
    /// If the amount is positive, then it is a debit for the customer.
    /// </para>
    /// <para>
    /// If the amount is negative, then it is a credit for the customer.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    [MaxLength(15)]
    public string? Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
