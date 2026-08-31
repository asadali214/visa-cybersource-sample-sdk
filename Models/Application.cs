using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Application
{
    /// <summary>
    /// The name of the CyberSource transaction type (such as CC settlement or CC authorization) that the merchant wants to process in a transaction request. More than one transaction type can included in a transaction request. Each transaction type separately returns their own status, reasonCode, rCode, and rFlag messages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The description for this field is not available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// 3-digit reason code that indicates why the customer profile payment succeeded or failed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasonCode")]
    public string? ReasonCode { get; init; }

    /// <summary>
    /// Indicates whether the service request was successful.
    /// Possible values:
    /// <list type="bullet">
    ///   <item><description><c>-1</c>: An error occurred.</description></item>
    ///   <item><description><c>0</c>: The request was declined.</description></item>
    ///   <item><description><c>1</c>: The request was successful.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rCode")]
    public string? RCode { get; init; }

    /// <summary>
    /// One-word description of the result of the application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rFlag")]
    public string? RFlag { get; init; }

    /// <summary>
    /// Reference number that you use to reconcile your CyberSource reports with your processor reports.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reconciliationId")]
    public string? ReconciliationId { get; init; }

    /// <summary>
    /// Message that explains the reply flag for the application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rMessage")]
    public string? RMessage { get; init; }

    /// <summary>
    /// The description for this field is not available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnCode")]
    public int? ReturnCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
