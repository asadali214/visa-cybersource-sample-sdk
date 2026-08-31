using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CreateBundledDecisionManagerCaseRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientReferenceInformation")]
    public ClientReferenceInformation48? ClientReferenceInformation { get; init; }

    /// <summary>
    /// Contains information related to the payment processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processorInformation")]
    public ProcessorInformation29? ProcessorInformation { get; init; }

    /// <summary>
    /// Decides whether to call Payer Authentication or Watchlist Screening service along with DM or not.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingInformation")]
    public ProcessingInformation56? ProcessingInformation { get; init; }

    /// <summary>
    /// Contains the payment data for this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInformation")]
    public PaymentInformation31? PaymentInformation { get; init; }

    /// <summary>
    /// Contains detailed order-level information.
    /// </summary>
    [JsonPropertyName("orderInformation")]
    public required OrderInformation35 OrderInformation { get; init; }

    /// <summary>
    /// Contains information about the buyer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyerInformation")]
    public BuyerInformation37? BuyerInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceInformation")]
    public DeviceInformation13? DeviceInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskInformation")]
    public RiskInformation5? RiskInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("travelInformation")]
    public TravelInformation9? TravelInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDefinedInformation")]
    public IReadOnlyList<MerchantDefinedInformation13>? MerchantDefinedInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantInformation")]
    public MerchantInformation19? MerchantInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirerInformation")]
    public AcquirerInformation1? AcquirerInformation { get; init; }

    /// <summary>
    /// This object contains recurring payment information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringPaymentInformation")]
    public RecurringPaymentInformation? RecurringPaymentInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumerAuthenticationInformation")]
    public ConsumerAuthenticationInformation4? ConsumerAuthenticationInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("watchlistScreeningInformation")]
    public WatchlistScreeningInformation? WatchlistScreeningInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenInformation")]
    public TokenInformation5? TokenInformation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
