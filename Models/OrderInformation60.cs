using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains all of the order-related fields, such as the amount and line item details.
/// </summary>
public record OrderInformation60
{
    /// <summary>
    /// Contains all of the amount-related fields.
    /// </summary>
    [JsonPropertyName("amountDetails")]
    public required AmountDetails60 AmountDetails { get; init; }

    /// <summary>
    /// List of the line items from the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lineItems")]
    [MaxLength(30)]
    public IReadOnlyList<LineItem17>? LineItems { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
