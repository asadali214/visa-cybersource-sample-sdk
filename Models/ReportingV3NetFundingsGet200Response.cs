using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ReportingV3NetFundingsGet200Response
{
    /// <summary>
    /// Valid report Start Date in <b>ISO 8601 format</b>.
    /// Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>
    /// <para>
    /// <b>Example:</b>
    /// - yyyy-MM-dd'T'HH:mm:ss.SSSZZ
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startTime")]
    public DateTimeOffset? StartTime { get; init; }

    /// <summary>
    /// Valid report End Date in <b>ISO 8601 format</b>
    /// <b>Example date format:</b>
    /// - yyyy-MM-dd'T'HH:mm:ss.SSSZZ
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endTime")]
    public DateTimeOffset? EndTime { get; init; }

    /// <summary>
    /// List of Netfunding summary objects
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("netFundingSummaries")]
    public IReadOnlyList<NetFundingSummary>? NetFundingSummaries { get; init; }

    /// <summary>
    /// List of total purchases currency wise
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalPurchases")]
    public IReadOnlyList<TotalPurchase>? TotalPurchases { get; init; }

    /// <summary>
    /// List of total refunds currency wise
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalRefunds")]
    public IReadOnlyList<TotalRefund>? TotalRefunds { get; init; }

    /// <summary>
    /// List of total fees currency wise
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalFees")]
    public IReadOnlyList<TotalFee>? TotalFees { get; init; }

    /// <summary>
    /// List of total chargebacks currency wise
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalChargebacks")]
    public IReadOnlyList<TotalChargeback>? TotalChargebacks { get; init; }

    /// <summary>
    /// List of new total currency wise
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("netTotal")]
    public IReadOnlyList<NetTotal>? NetTotal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
