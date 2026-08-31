using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// PurchaseAndRefundDetails
/// </summary>
public record ReportingV3PurchaseRefundDetailsGet200Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset")]
    public int? Offset { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pageResults")]
    public int? PageResults { get; init; }

    /// <summary>
    /// List of Request Info values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestDetails")]
    public IReadOnlyList<RequestDetail>? RequestDetails { get; init; }

    /// <summary>
    /// List of Settlement Info values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlements")]
    public IReadOnlyList<Settlement>? Settlements { get; init; }

    /// <summary>
    /// List of Authorization Info values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizations")]
    public IReadOnlyList<Authorization>? Authorizations { get; init; }

    /// <summary>
    /// List of Fee Funding Info values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeAndFundingDetails")]
    public IReadOnlyList<FeeAndFundingDetail>? FeeAndFundingDetails { get; init; }

    /// <summary>
    /// List of Other Info values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("others")]
    public IReadOnlyList<Other>? Others { get; init; }

    /// <summary>
    /// List of Settlement Status Info values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementStatuses")]
    public IReadOnlyList<SettlementStatus>? SettlementStatuses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
