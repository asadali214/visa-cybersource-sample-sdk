using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Converters;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains all of the invoice-specific fields, such as the invoice number and due date.
/// </summary>
public record InvoiceInformation1
{
    /// <summary>
    /// Invoice Number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; init; }

    /// <summary>
    /// The description included in the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(2000)]
    public string? Description { get; init; }

    /// <summary>
    /// The invoice due date. This field is required for creating an invoice.
    /// Format: <c>YYYY-MM-DD</c>, where <c>YYYY</c> = year, <c>MM</c> = month, and <c>DD</c> = day
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dueDate")]
    [JsonConverter(typeof(DateOnlyDateTimeOffsetConverter))]
    public DateTimeOffset? DueDate { get; init; }

    /// <summary>
    /// Define an expiration date for the link.
    /// <para>
    /// Format: <c>YYYY-MM-DD</c>, where <c>YYYY</c> = year, <c>MM</c> = month, and <c>DD</c> = day
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationDate")]
    [JsonConverter(typeof(DateOnlyDateTimeOffsetConverter))]
    public DateTimeOffset? ExpirationDate { get; init; }

    /// <summary>
    /// If set to <c>true</c>, the payer can make a partial invoice payment.
    /// </summary>
    [JsonPropertyName("allowPartialPayments")]
    public bool? AllowPartialPayments { get; init; } = false;

    /// <summary>
    /// Returns the payment link to an invoice when the invoice status is <c>SENT</c>, <c>CREATED</c>, <c>PARTIAL</c>, or <c>PAID</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentLink")]
    public string? PaymentLink { get; init; }

    /// <summary>
    /// If this field is set to 'None', an invoice will be generated with the status 'CREATED', but no email will be dispatched.
    /// <para>
    /// Possible values:
    ///  - <c>None</c>
    ///  - <c>Email</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryMode")]
    public string? DeliveryMode { get; init; }

    /// <summary>
    /// A list of custom labels that allows you to override (rename) default field names and control the visibility of specific fields on invoices and items. If the list is empty, the labels will not be overwritten.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customLabels")]
    public IReadOnlyList<CustomLabel>? CustomLabels { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
