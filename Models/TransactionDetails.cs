using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// These details are only returned when the invoice event is <c>payment</c>.
/// </summary>
public record TransactionDetails
{
    /// <summary>
    /// Payer auth Transaction identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionId")]
    public string? TransactionId { get; init; }

    /// <summary>
    /// Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters.
    /// CyberSource truncates the amount to the correct number of decimal places.
    /// <para>
    /// <b>Note</b> For CTV, FDCCompass, Paymentech processors, the maximum length for this field is 12.
    /// </para>
    /// <para>
    /// <b>Important</b> Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths.
    /// </para>
    /// <para>
    /// If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.
    /// </para>
    /// <para>
    /// #### Card Present
    /// Required to include either this field or <c>orderInformation.lineItems[].unitPrice</c> for the order.
    /// </para>
    /// <para>
    /// #### Invoicing / Pay By Link
    /// Required for creating a new invoice or payment link.
    /// </para>
    /// <para>
    /// #### PIN Debit
    /// Amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount.
    /// </para>
    /// <para>
    /// Required field for PIN Debit purchase and PIN Debit credit requests.
    /// Optional field for PIN Debit reversal requests.
    /// </para>
    /// <para>
    /// #### GPX
    /// This field is optional for reversing an authorization or credit; however, for all other processors, these fields are required.
    /// </para>
    /// <para>
    /// #### DCC with a Third-Party Provider
    /// Set this field to the converted amount that was returned by the DCC provider. You must include either this field or the 1st line item in the order and the specific line-order amount in your request.
    /// </para>
    /// <para>
    /// #### DCC for First Data
    /// Not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    [MaxLength(19)]
    public string? Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
