using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record UpdateInvoiceRequest
{
    /// <summary>
    /// Contains all of the customer-related fields for the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerInformation")]
    public CustomerInformation? CustomerInformation { get; init; }

    /// <summary>
    /// Contains processing information, such as collection details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingInformation")]
    public ProcessingInformation72? ProcessingInformation { get; init; }

    /// <summary>
    /// Contains the updatable invoice information.
    /// </summary>
    [JsonPropertyName("invoiceInformation")]
    public required InvoiceInformation4 InvoiceInformation { get; init; }

    /// <summary>
    /// Contains all of the order-related fields, such as the amount and line item details.
    /// </summary>
    [JsonPropertyName("orderInformation")]
    public required OrderInformation60 OrderInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDefinedFieldValues")]
    public IReadOnlyList<MerchantDefinedFieldValue>? MerchantDefinedFieldValues { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
