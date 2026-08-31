using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InvoiceDetails4
{
    /// <summary>
    /// Value used by your customer to identify the order. This value is typically a purchase order number. CyberSource
    /// recommends that you do not populate the field with all zeros or nines.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseOrderNumber")]
    [MaxLength(50)]
    public string? PurchaseOrderNumber { get; init; }

    /// <summary>
    /// Date the order was processed. <c>Format: YYYY-MM-DD</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseOrderDate")]
    [MaxLength(10)]
    public string? PurchaseOrderDate { get; init; }

    /// <summary>
    /// The name of the individual or the company contacted for company authorized purchases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseContactName")]
    [MaxLength(36)]
    public string? PurchaseContactName { get; init; }

    /// <summary>
    /// Flag that indicates whether an order is taxable. This value must be true if the sum of all _lineItems[].taxAmount_ values &gt; 0.
    /// <para>
    /// If you do not include any <c>lineItems[].taxAmount</c> values in your request, CyberSource does not include
    /// <c>invoiceDetails.taxable</c> in the data it sends to the processor.
    /// </para>
    /// <para>
    /// Possible values:
    ///  - <b>true</b>
    ///  - <b>false</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxable")]
    public bool? Taxable { get; init; }

    /// <summary>
    /// VAT invoice number associated with the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vatInvoiceReferenceNumber")]
    [MaxLength(15)]
    public string? VatInvoiceReferenceNumber { get; init; }

    /// <summary>
    /// International description code of the overall order’s goods or services or the Categorizes purchases for VAT
    /// reporting. Contact your acquirer for a list of codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commodityCode")]
    [MaxLength(4)]
    public string? CommodityCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionAdviceAddendum")]
    public IReadOnlyList<TransactionAdviceAddendum>? TransactionAdviceAddendum { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
