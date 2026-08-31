using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MultiProcessorRouting
{
    /// <summary>
    /// Name of the Processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(30)]
    public string? Name { get; init; }

    /// <summary>
    /// For most processors, this is the error message sent directly from the bank. Returned only when the processor
    /// returns this value.
    /// <para>
    /// <b>Important</b> Do not use this field to evaluate the result of the authorization.
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
    /// <para>
    /// #### paypalgateway
    /// Processor generated ID for the itemized detail.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseCode")]
    [MaxLength(10)]
    public string? ResponseCode { get; init; }

    /// <summary>
    /// Indicates the reason why a request succeeded or failed and possible action to take if a request fails.
    /// <para>
    /// For details, see the appendix of reason codes in the documentation for the relevant payment method.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasonCode")]
    public string? ReasonCode { get; init; }

    /// <summary>
    /// The order in which the transaction was routed to the processor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sequence")]
    public string? Sequence { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
