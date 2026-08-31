using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record ReportDefinition
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// | Id  |         Definition Class          |
    /// | --- | --------------------------------- |
    /// | 210 | TransactionRequestClass           |
    /// | 211 | PaymentBatchDetailClass           |
    /// | 212 | ExceptionDetailClass              |
    /// | 213 | ProcessorSettlementDetailClass    |
    /// | 214 | ProcessorEventsDetailClass        |
    /// | 215 | FundingDetailClass                |
    /// | 216 | AgingDetailClass                  |
    /// | 217 | ChargebackAndRetrievalDetailClass |
    /// | 218 | DepositDetailClass                |
    /// | 219 | FeeDetailClass                    |
    /// | 220 | InvoiceSummaryClass               |
    /// | 221 | PayerAuthDetailClass              |
    /// | 222 | ConversionDetailClass             |
    /// | 225 | BillableTransactionsDetailClass   |
    /// | 270 | JPTransactionDetailClass          |
    /// | 271 | ServiceFeeDetailClass             |
    /// | 310 | GatewayTransactionRequestClass    |
    /// | 400 | DecisionManagerEventDetailClass   |
    /// | 401 | DecisionManagerDetailClass        |
    /// | 410 | FeeSummaryClass                   |
    /// | 420 | TaxCalculationClass               |
    /// | 520 | POSTerminalExceptionClass         |
    /// | 620 | SubscriptionDetailClass           |
    /// | 630 | StandardBillingDataPackageClass   |
    /// | 706 | StandardMonthlyFeeClass           |
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportDefinitionId")]
    public int? ReportDefinitionId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportDefintionName")]
    public string? ReportDefintionName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportedFormats")]
    [UniqueItems]
    public IReadOnlyList<string>? SupportedFormats { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultSettings")]
    public ReportDefinitionDefaultSettings? DefaultSettings { get; init; }

    /// <summary>
    /// 'The subscription type for which report definition is required. By default the type will be CUSTOM.'
    /// Valid Values:
    /// - CLASSIC
    /// - CUSTOM
    /// - STANDARD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionType")]
    public string? SubscriptionType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
