using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CreateInvoiceRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientReferenceInformation")]
    public ClientReferenceInformation78? ClientReferenceInformation { get; init; }

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
    /// Contains all of the invoice-specific fields, such as the invoice number and due date.
    /// </summary>
    [JsonPropertyName("invoiceInformation")]
    public required InvoiceInformation InvoiceInformation { get; init; }

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
