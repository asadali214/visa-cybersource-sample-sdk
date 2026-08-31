using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CustomLabel
{
    /// <summary>
    /// The invoice field key. Possible values:
    ///   - billTo
    ///   - invoiceNumber
    ///   - customerId
    ///   - companyName
    ///   - description
    ///   - shipping
    ///   - partialPayment
    ///   - discount
    ///   - tax
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// The new (overridden) field name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [MaxLength(25)]
    public string? Value { get; init; }

    /// <summary>
    /// Hides the specified field. This field is applicable for keys:
    ///   - customerId
    ///   - companyName
    ///   - description
    ///   - shipping
    ///   - partialPayment
    /// </summary>
    [JsonPropertyName("hidden")]
    public bool? Hidden { get; init; } = false;

    /// <summary>
    /// Hides the field at invoice level. This field is applicable for keys:
    ///   - discount
    ///   - tax
    /// </summary>
    [JsonPropertyName("hiddenForInvoice")]
    public bool? HiddenForInvoice { get; init; } = false;

    /// <summary>
    /// Hides the field at invoice item level. This field is applicable for keys:
    ///   - discount
    ///   - tax
    /// </summary>
    [JsonPropertyName("hiddenForItem")]
    public bool? HiddenForItem { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
