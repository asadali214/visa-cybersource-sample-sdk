using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TransactionBatch
{
    /// <summary>
    /// Unique identifier assigned to the batch file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [StringLength(8, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9_+-]*$")]
    public string? Id { get; init; }

    /// <summary>
    /// Date when the batch template was update.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uploadDate")]
    public string? UploadDate { get; init; }

    /// <summary>
    /// The date when the batch template processing completed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completionDate")]
    public string? CompletionDate { get; init; }

    /// <summary>
    /// Number of transactions in the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionCount")]
    public int? TransactionCount { get; init; }

    /// <summary>
    /// Number of transactions accepted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptedTransactionCount")]
    public int? AcceptedTransactionCount { get; init; }

    /// <summary>
    /// Number of transactions rejected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rejectedTransactionCount")]
    public string? RejectedTransactionCount { get; init; }

    /// <summary>
    /// The status of you batch template processing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
