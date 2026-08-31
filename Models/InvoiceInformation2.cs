using System;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InvoiceInformation2
{
    /// <summary>
    /// The invoice due date. This field is required for creating an invoice.
    /// Format: <c>YYYY-MM-DD</c>, where <c>YYYY</c> = year, <c>MM</c> = month, and <c>DD</c> = day
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dueDate")]
    public DateTimeOffset? DueDate { get; init; }

    /// <summary>
    /// Define an expiration date for the link.
    /// <para>
    /// Format: <c>YYYY-MM-DD</c>, where <c>YYYY</c> = year, <c>MM</c> = month, and <c>DD</c> = day
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationDate")]
    public DateTimeOffset? ExpirationDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
