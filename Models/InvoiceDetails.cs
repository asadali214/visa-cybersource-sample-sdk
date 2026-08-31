using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record InvoiceDetails
{
    /// <summary>
    /// Invoice Number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; init; }

    /// <summary>
    /// Barcode Number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("barcodeNumber")]
    public string? BarcodeNumber { get; init; }

    /// <summary>
    /// Expiration Date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; init; }

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

    /// <summary>
    /// Identifier for the merchandise. This field is supported only on the processors listed in this field description.
    /// <para>
    /// #### American Express Direct
    /// Possible value:
    /// - 1000: Gift card
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// This value must be right justified. In Japan, this value is called a _goods code_.
    /// </para>
    /// <para>
    /// #### JCN Gateway
    /// This value must be right justified. In Japan, this value is called a _goods code_.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchandiseCode")]
    public int? MerchandiseCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionAdviceAddendum")]
    public IReadOnlyList<TransactionAdviceAddendum>? TransactionAdviceAddendum { get; init; }

    /// <summary>
    /// Code that identifies the value of the <c>referenceDataNumber</c> field.
    /// <para>
    /// This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way
    /// before sending it to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceDataCode")]
    [MaxLength(3)]
    public string? ReferenceDataCode { get; init; }

    /// <summary>
    /// Reference number. The meaning of this value is identified by the value of the <c>referenceDataCode</c> field.
    /// <para>
    /// This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way
    /// before sending it to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceDataNumber")]
    [MaxLength(30)]
    public string? ReferenceDataNumber { get; init; }

    /// <summary>
    /// Transaction identifier that is generated. You have the option of printing the sales slip number on the receipt.
    /// This field is supported only on Cybersource through Visanet and JCN gateway.
    /// <para>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### Card Present processing message
    /// If you included this field in the request, the returned value is the value that you sent in the request.
    /// If you did not include this field in the request, the system generated this value for you.
    /// </para>
    /// <para>
    /// The difference between this reply field and the <c>processorInformation.systemTraceAuditNumber</c> field is that the
    /// system generates the system trace audit number (STAN), and you must print the receipt number on the receipt;
    /// whereas you can generate the sales slip number, and you can choose to print the sales slip number on the receipt.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("salesSlipNumber")]
    [Maximum(99999)]
    public int? SalesSlipNumber { get; init; }

    /// <summary>
    /// Date of the tax calculation. Use format YYYYMMDD. You can provide a date in the past if you are calculating tax for a refund and want to know what the tax was on the date the order was placed.
    /// You can provide a date in the future if you are calculating the tax for a future date, such as an upcoming tax holiday.
    /// <para>
    /// The default is the date, in Pacific time, that the bank receives the request.
    /// Keep this in mind if you are in a different time zone and want the tax calculated with the rates that are applicable on a specific date.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Optional field for U.S., Canadian, international tax, and value added taxes.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceDate")]
    [MaxLength(8)]
    public string? InvoiceDate { get; init; }

    /// <summary>
    /// Cost centre of the merchant
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("costCenter")]
    [MaxLength(25)]
    public string? CostCenter { get; init; }

    /// <summary>
    /// Text message from the issuer. If you give the customer a receipt, display this value on the receipt.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerMessage")]
    [MaxLength(41)]
    public string? IssuerMessage { get; init; }

    /// <summary>
    /// Brief description of item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productDescription")]
    public string? ProductDescription { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
