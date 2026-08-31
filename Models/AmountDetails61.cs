using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Converters;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains all of the amount-related fields.
/// </summary>
public record AmountDetails61
{
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
    [JsonPropertyName("totalAmount")]
    [JsonConverter(typeof(NumericStringConverter))]
    [MaxLength(19)]
    public string? TotalAmount { get; init; }

    /// <summary>
    /// Currency used for the order. Use the three-character <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes.</see>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required field.
    /// </para>
    /// <para>
    /// <b>Authorization Reversal</b>
    /// For an authorization reversal (<c>reversalInformation</c>) or a capture (<c>processingOptions.capture</c> is set to <c>true</c>), you must use the same currency that you used in your payment authorization request.
    /// </para>
    /// <para>
    /// #### PIN Debit
    /// Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes</see>.
    /// Returned by PIN debit purchase.
    /// </para>
    /// <para>
    /// For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing.
    /// For the possible values, see the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes</see>.
    /// </para>
    /// <para>
    /// Required field for PIN Debit purchase and PIN Debit credit requests.
    /// Optional field for PIN Debit reversal requests.
    /// </para>
    /// <para>
    /// #### GPX
    /// This field is optional for reversing an authorization or credit.
    /// </para>
    /// <para>
    /// #### DCC for First Data
    /// Your local currency.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Required for international tax and value added tax only.
    /// Optional for U.S. and Canadian taxes.
    /// Your local currency.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MaxLength(3)]
    public string? Currency { get; init; }

    /// <summary>
    /// Remaining balance on the account.
    /// <para>
    /// Returned by authorization service.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Remaining balance on the prepaid card.
    /// </para>
    /// <para>
    /// Returned by PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAmount")]
    [JsonConverter(typeof(NumericStringConverter))]
    [MaxLength(12)]
    public string? BalanceAmount { get; init; }

    /// <summary>
    /// Total discount amount applied to the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountAmount")]
    [MaxLength(15)]
    public string? DiscountAmount { get; init; }

    /// <summary>
    /// The total discount percentage applied to the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountPercent")]
    [MaxLength(7)]
    public string? DiscountPercent { get; init; }

    /// <summary>
    /// Sub-amount of the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subAmount")]
    [MaxLength(25)]
    public string? SubAmount { get; init; }

    /// <summary>
    /// The minimum partial amount required to pay the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minimumPartialAmount")]
    public string? MinimumPartialAmount { get; init; }

    /// <summary>
    /// Contains all of the tax-related fields for the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxDetails")]
    public TaxDetails13? TaxDetails { get; init; }

    /// <summary>
    /// Contains all of the shipping-related fields for the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("freight")]
    public Freight? Freight { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
