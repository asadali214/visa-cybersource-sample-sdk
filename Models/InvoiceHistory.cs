using System;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InvoiceHistory
{
    /// <summary>
    /// The event triggered for the invoice.
    /// <para>
    /// Possible values:
    ///  - <c>UNKNOWN</c>
    ///  - <c>DRAFT</c>
    ///  - <c>CREATE</c>
    ///  - <c>UPDATE</c>
    ///  - <c>SEND</c>
    ///  - <c>RESEND</c>
    ///  - <c>REMINDER</c>
    ///  - <c>PAYMENT</c>
    ///  - <c>CANCEL</c>
    ///  - <c>PENDING</c>
    ///  - <c>REJECTED</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event")]
    public string? Event { get; init; }

    /// <summary>
    /// The date and time when the invoice event was triggered in ISO 8601 format. Format: YYYY-MM-DDThh:mm:ssZ
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; init; }

    /// <summary>
    /// These details are only returned when the invoice event is <c>payment</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDetails")]
    public TransactionDetails? TransactionDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
