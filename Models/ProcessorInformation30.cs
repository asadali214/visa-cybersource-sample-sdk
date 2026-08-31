using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessorInformation30
{
    /// <summary>
    /// Issuer-generated approval code for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("approvalCode")]
    [MaxLength(6)]
    public string? ApprovalCode { get; init; }

    /// <summary>
    /// Transaction status from the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseCode")]
    [MaxLength(10)]
    public string? ResponseCode { get; init; }

    /// <summary>
    /// Network transaction identifier (TID). This value can be used to identify a specific transaction when
    /// you are discussing the transaction with your processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionId")]
    [MaxLength(40)]
    public string? TransactionId { get; init; }

    /// <summary>
    /// This field is returned only for <b>American Express Direct</b> and <b>CyberSource through VisaNet</b>.
    /// Returned by authorization and incremental authorization services.
    /// <para>
    /// #### American Express Direct
    /// </para>
    /// <para>
    /// System trace audit number (STAN). This value identifies the transaction and is useful when investigating a
    /// chargeback dispute.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// </para>
    /// <para>
    /// System trace number that must be printed on the customer’s receipt.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("systemTraceAuditNumber")]
    [MaxLength(6)]
    public string? SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Used by Visa only and contains the response source/reason code that identifies the source of the response decision.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseCodeSource")]
    [MaxLength(1)]
    public string? ResponseCodeSource { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAdvice")]
    public MerchantAdvice2? MerchantAdvice { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avs")]
    public Avs4? Avs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public Customer54? Customer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("electronicVerificationResults")]
    public ElectronicVerificationResults1? ElectronicVerificationResults { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardVerification")]
    public CardVerification1? CardVerification { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
