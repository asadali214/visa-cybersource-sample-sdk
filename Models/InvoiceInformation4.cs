using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains the updatable invoice information.
/// </summary>
public record InvoiceInformation4
{
    /// <summary>
    /// The description included in the invoice.
    /// </summary>
    [JsonPropertyName("description")]
    [MaxLength(2000)]
    public required string Description { get; init; }

    /// <summary>
    /// The invoice due date. This field is required for creating an invoice.
    /// Format: <c>YYYY-MM-DD</c>, where <c>YYYY</c> = year, <c>MM</c> = month, and <c>DD</c> = day
    /// </summary>
    [JsonPropertyName("dueDate")]
    public required DateTimeOffset DueDate { get; init; }

    /// <summary>
    /// Define an expiration date for the link.
    /// <para>
    /// Format: <c>YYYY-MM-DD</c>, where <c>YYYY</c> = year, <c>MM</c> = month, and <c>DD</c> = day
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationDate")]
    public DateTimeOffset? ExpirationDate { get; init; }

    /// <summary>
    /// If set to <c>true</c>, we send the invoice immediately. If set to <c>false</c>, the invoice remains in draft mode.
    /// </summary>
    [JsonPropertyName("sendImmediately")]
    public bool? SendImmediately { get; init; } = false;

    /// <summary>
    /// If set to <c>true</c>, the payer can make a partial invoice payment.
    /// </summary>
    [JsonPropertyName("allowPartialPayments")]
    public bool? AllowPartialPayments { get; init; } = false;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
