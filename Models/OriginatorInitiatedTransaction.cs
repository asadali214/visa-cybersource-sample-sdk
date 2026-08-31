using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record OriginatorInitiatedTransaction
{
    /// <summary>
    /// Contains a Visa-generated Transaction Identifier (TID) that is unique for each original authorization and financial request. The identifier links original messages to subsequent messages.
    /// <para>
    /// Conditional field. If the <c>processingInformation.fundingOptions.initiator.type</c>=<c>originator</c>, this field is mandatory.
    /// </para>
    /// <para>
    /// <b>Notes</b>:
    /// 1. If an Pull Funds Transfer (AFT) transaction has a corresponding Push Funds Transfer (OCT) transaction, originators are strongly recommended to take the Transaction ID from the AFT and populate it into the OCT to link the two transactions together.
    /// 2. Originators must link the Originator-Initiated Transaction with the original transaction using the Transaction Identifier that was generated for the original cardholder initiated transaction. However, for standing-instruction MITs (i.e., recurring), acquirers can use the Transaction Identifier generated for the previous transaction in the series to link the subsequent transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalTransactionId")]
    [MaxLength(15)]
    public string? OriginalTransactionId { get; init; }

    /// <summary>
    /// Possible values:
    /// - <c>1</c>: Resubmission
    /// - <c>2</c>: Delayed charge
    /// - <c>3</c>: Reauthorization for split shipment
    /// - <c>4</c>: No show
    /// - <c>5</c>: Account top up
    /// <para>
    /// Conditional: This field is not required for recurring transactions or when <c>processingInformation.fundingOptions.initiator.credentialStoredOnFile</c> = <c>True</c>. It is required for all other originator-initiated (MIT) transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    [RegularExpression("^(\\s{0,1}|.{1})$")]
    public string? Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
