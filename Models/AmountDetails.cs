using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails
{
    /// <summary>
    /// The remaining amount which can be refunded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refundBalance")]
    [MaxLength(15)]
    public string? RefundBalance { get; init; }

    /// <summary>
    /// Amount being charged as gift wrap fee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("giftWrapAmount")]
    [MaxLength(19)]
    public string? GiftWrapAmount { get; init; }

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
    /// Subtotal amount of all the items.This amount (which is the value of all items in the cart, not including the additional amounts such as tax, shipping, etc.) cannot change after a sessions request.
    /// When there is a change to any of the additional amounts, this field should be resent in the order request. When the sub total amount changes, you must initiate a new transaction starting with a sessions request.
    /// Note The amount value must be a non-negative number containing 2 decimal places and limited to 7 digits before the decimal point. This value can not be changed after a sessions request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subTotalAmount")]
    [MaxLength(15)]
    public string? SubTotalAmount { get; init; }

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
    /// Total charges for any import or export duties included in the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dutyAmount")]
    [MaxLength(15)]
    public string? DutyAmount { get; init; }

    /// <summary>
    /// Gratuity or tip amount for restaurants. Allowed only when industryDatatype=restaurant.
    /// When your customer uses a debit card or prepaid card, and you receive a partial authorization, the payment networks recommend that you do not
    /// submit a capture amount that is higher than the authorized amount. When the capture amount exceeds the partial amount that was approved, the
    /// issuer has chargeback rights for the excess amount.
    /// <para>
    /// Used by <b>Capture</b>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// Restaurant data is supported only on CyberSource through VisaNet when card is present.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gratuityAmount")]
    [MaxLength(13)]
    public string? GratuityAmount { get; init; }

    /// <summary>
    /// Total tax amount for all the items in the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAmount")]
    [MaxLength(12)]
    public string? TaxAmount { get; init; }

    /// <summary>
    /// Flag that indicates whether a national tax is included in the order total.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>0</b>: national tax not included</description></item>
    ///   <item><description><b>1</b>: national tax included</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationalTaxIncluded")]
    [MaxLength(1)]
    public string? NationalTaxIncluded { get; init; }

    /// <summary>
    /// Flag that indicates how the merchant manages discounts.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>0</b>: no invoice level discount included</description></item>
    ///   <item><description><b>1</b>: tax calculated on the postdiscount invoice total</description></item>
    ///   <item><description><b>2</b>: tax calculated on the prediscount invoice total</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAppliedAfterDiscount")]
    [MaxLength(1)]
    public string? TaxAppliedAfterDiscount { get; init; }

    /// <summary>
    /// Flag that indicates how you calculate tax.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>0</b>: net prices with tax calculated at line item level</description></item>
    ///   <item><description><b>1</b>: net prices with tax calculated at invoice level</description></item>
    ///   <item><description><b>2</b>: gross prices with tax provided at line item level</description></item>
    ///   <item><description><b>3</b>: gross prices with tax provided at invoice level</description></item>
    ///   <item><description><b>4</b>: no tax applies on the invoice for the transaction</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAppliedLevel")]
    [MaxLength(1)]
    public string? TaxAppliedLevel { get; init; }

    /// <summary>
    /// For tax amounts that can be categorized as one tax type.
    /// <para>
    /// This field contains the tax type code that corresponds to the entry in the _lineItems.taxAmount_ field.
    /// </para>
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>056</b>: sales tax (U.S only)</description></item>
    ///   <item><description><b>TX~</b>: all taxes (Canada only)   Note ~ = space.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxTypeCode")]
    [MaxLength(3)]
    public string? TaxTypeCode { get; init; }

    /// <summary>
    /// Total freight or shipping and handling charges for the order. When you include this field in your request, you
    /// must also include the <b>totalAmount</b> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("freightAmount")]
    [MaxLength(13)]
    public string? FreightAmount { get; init; }

    /// <summary>
    /// Set this field to the converted amount that was returned by the DCC provider.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foreignAmount")]
    [MaxLength(15)]
    public string? ForeignAmount { get; init; }

    /// <summary>
    /// Set this field to the converted amount that was returned by the DCC provider.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foreignCurrency")]
    [MaxLength(5)]
    public string? ForeignCurrency { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge")]
    public Surcharge? Surcharge { get; init; }

    /// <summary>
    /// This is a multicurrency field. It contains the transaction amount (field 4), converted to the Currency used to bill the cardholder’s account.
    /// This field is returned for OCT transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementAmount")]
    [MaxLength(12)]
    public string? SettlementAmount { get; init; }

    /// <summary>
    /// This is a multicurrency-only field. It contains a 3-digit numeric code that identifies the currency used by the issuer to bill the cardholder's account.
    /// This field is returned for OCT transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementCurrency")]
    [MaxLength(3)]
    public string? SettlementCurrency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amexAdditionalAmounts")]
    public IReadOnlyList<AmexAdditionalAmount>? AmexAdditionalAmounts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxDetails")]
    public IReadOnlyList<TaxDetail>? TaxDetails { get; init; }

    /// <summary>
    /// Service fee. Required for service fee transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceFeeAmount")]
    [MaxLength(15)]
    public string? ServiceFeeAmount { get; init; }

    /// <summary>
    /// Amount in your original local pricing currency.
    /// <para>
    /// This value cannot be negative. You can include a decimal point (.) in this field to denote the currency
    /// exponent, but you cannot include any other special characters.
    /// </para>
    /// <para>
    /// If needed, CyberSource truncates the amount to the correct number of decimal places.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalAmount")]
    [MaxLength(15)]
    public string? OriginalAmount { get; init; }

    /// <summary>
    /// Your local pricing currency code.
    /// <para>
    /// For the possible values, see the <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes.</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalCurrency")]
    [MaxLength(15)]
    public string? OriginalCurrency { get; init; }

    /// <summary>
    /// Cashback amount in the acquirer’s currency. If a cashback amount is included in the request, it must be included
    /// in the <c>orderInformation.amountDetails.totalAmount</c> value.
    /// <para>
    /// This field is supported only on CyberSource through VisaNet.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional.
    /// <b>Authorization Reversal</b>
    /// Optional.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Optional field for PIN debit purchase, PIN debit credit or PIN debit reversal.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashbackAmount")]
    [MaxLength(13)]
    public string? CashbackAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencyConversion")]
    public CurrencyConversion? CurrencyConversion { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oct-surcharge")]
    public OctSurcharge? OctSurcharge { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public Order? Order { get; init; }

    /// <summary>
    /// This API Field contains the anticipated amount details. This supports use cases where the Merchant does not wish to have funds held against the account, but needs to confirm an amount prior to authorization, such as for a trial subscription, reservation service, or loyalty program. In an account verification, the anticipated amount is used to confirm the account has availability to accept purchases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("anticipatedAmount")]
    [MaxLength(15)]
    public string? AnticipatedAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
