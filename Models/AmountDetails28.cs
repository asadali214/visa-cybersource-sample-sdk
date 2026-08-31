using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails28
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
    /// Total discount amount applied to the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountAmount")]
    [MaxLength(15)]
    public string? DiscountAmount { get; init; }

    /// <summary>
    /// Total tax amount for all the items in the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAmount")]
    [MaxLength(12)]
    public string? TaxAmount { get; init; }

    /// <summary>
    /// Total charges for any import or export duties included in the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dutyAmount")]
    [MaxLength(15)]
    public string? DutyAmount { get; init; }

    /// <summary>
    /// Exchange rate returned by the DCC service. Includes a decimal point and a maximum of 4 decimal places.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeRate")]
    [MaxLength(13)]
    public string? ExchangeRate { get; init; }

    /// <summary>
    /// Time stamp for the exchange rate. This value is returned by the DCC service.
    /// <para>
    /// Format: <c>YYYYMMDD~HH:MM</c>  where ~ denotes a space.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeRateTimeStamp")]
    [MaxLength(16)]
    public string? ExchangeRateTimeStamp { get; init; }

    /// <summary>
    /// This is a multicurrency-only field. It contains a 3-digit numeric code that identifies the currency used by the issuer to bill the cardholder's account.
    /// This field is returned for OCT transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementCurrency")]
    [MaxLength(3)]
    public string? SettlementCurrency { get; init; }

    /// <summary>
    /// Invoice amount.
    /// <para>
    /// The invoice amount issued by the Merchant to the Cardholder, which includes VAT (excluding items such as TIPS or CASHBACK).
    /// For transactions that do not have applicable Benefit Laws, the field may be entered as zeros.
    /// </para>
    /// <para>
    /// This field is only applicable for Uruguay market.
    /// </para>
    /// <para>
    /// Example: 100.00
    /// </para>
    /// <para>
    /// Uruguay
    /// </para>
    /// <para>
    /// The value for this field corresponds to the following data in the TC 33 capture file:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Record: CP01 TCR9</description></item>
    ///   <item><description>Position: 7-18</description></item>
    ///   <item><description>Field: Invoice Amount</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceAmount")]
    [MaxLength(12)]
    public string? InvoiceAmount { get; init; }

    /// <summary>
    /// giftwrap amount (RFU).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("giftwrapAmount")]
    [MaxLength(19)]
    public string? GiftwrapAmount { get; init; }

    /// <summary>
    /// handling amount (RFU)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("handlingAmount")]
    [MaxLength(19)]
    public string? HandlingAmount { get; init; }

    /// <summary>
    /// shipping amount (RFU)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAmount")]
    [MaxLength(19)]
    public string? ShippingAmount { get; init; }

    /// <summary>
    /// shipping discount amount (RFU)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingDiscountAmount")]
    [MaxLength(19)]
    public string? ShippingDiscountAmount { get; init; }

    /// <summary>
    /// insurance amount (RFU)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insuranceAmount")]
    [MaxLength(19)]
    public string? InsuranceAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
