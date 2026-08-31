using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessorInformation21
{
    /// <summary>
    /// Authorization code. Returned only when the processor returns this value.
    /// <para>
    /// The length of this value depends on your processor.
    /// </para>
    /// <para>
    /// Returned by authorization service.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Authorization code that is returned by the processor.
    /// </para>
    /// <para>
    /// Returned by PIN debit credit.
    /// </para>
    /// <para>
    /// #### Elavon Encrypted Account Number Program
    /// The returned value is OFFLINE.
    /// </para>
    /// <para>
    /// #### TSYS Acquiring Solutions
    /// The returned value for a successful zero amount authorization is 000000.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("approvalCode")]
    [MaxLength(6)]
    public string? ApprovalCode { get; init; }

    /// <summary>
    /// For most processors, this is the error message sent directly from the bank. Returned only when the processor
    /// returns this value.
    /// <para>
    /// <b>Important</b> Do not use this field to evaluate the result of the authorization.
    /// #### SEPA/BACS
    /// Response code from the processor. Possible values: 00000–99999. See Appendix C,
    /// "Reason Codes and Processor Response
    /// Codes," on page 42.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Response value that is returned by the processor or bank.
    /// <b>Important</b> Do not use this field to evaluate the results of the transaction request.
    /// </para>
    /// <para>
    /// Returned by PIN debit credit, PIN debit purchase, and PIN debit reversal.
    /// </para>
    /// <para>
    /// #### AIBMS
    /// If this value is <c>08</c>, you can accept the transaction if the customer provides you with identification.
    /// </para>
    /// <para>
    /// #### Atos
    /// This value is the response code sent from Atos and it might also include the response code from the bank.
    /// Format: <c>aa,bb</c> with the two values separated by a comma and where:
    /// - <c>aa</c> is the two-digit error message from Atos.
    /// - <c>bb</c> is the optional two-digit error message from the bank.
    /// </para>
    /// <para>
    /// #### Comercio Latino
    /// This value is the status code and the error or response code received from the processor separated by a colon.
    /// Format: [status code]:E[error code] or [status code]:R[response code]
    /// Example <c>2:R06</c>
    /// </para>
    /// <para>
    /// #### JCN Gateway
    /// Processor-defined detail error code. The associated response category code is in the <c>processorInformation.responseCategoryCode</c> field.
    /// String (3)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseCode")]
    [MaxLength(10)]
    public string? ResponseCode { get; init; }

    /// <summary>
    /// Transaction ID assigned by the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionId")]
    [MaxLength(255)]
    public string? TransactionId { get; init; }

    /// <summary>
    /// Response code indicating that creating the agreement failed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseDetails")]
    [MaxLength(60)]
    public string? ResponseDetails { get; init; }

    /// <summary>
    /// Numeric value corresponding to the result of the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasonCode")]
    [MaxLength(5)]
    public string? ReasonCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
