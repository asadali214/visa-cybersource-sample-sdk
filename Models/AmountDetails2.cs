using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails2
{
    /// <summary>
    /// Amount you requested for the payment or capture.
    /// <para>
    /// This value is returned for partial authorizations.
    /// This field is also returned on incremental authorizations will contain the aggregated amount from the original authorizations and all the incremental authorizations.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalAmount")]
    [MaxLength(15)]
    public string? TotalAmount { get; init; }

    /// <summary>
    /// Amount that was authorized.
    /// <para>
    /// Returned by authorization service.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Amount of the purchase.
    /// </para>
    /// <para>
    /// Returned by PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizedAmount")]
    [MaxLength(15)]
    public string? AuthorizedAmount { get; init; }

    /// <summary>
    /// This field contains the purchase cashback amount expressed in the acquirer transaction currency.
    /// Use this field only for clearing with your acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashbackAmount")]
    [MaxLength(12)]
    public string? CashbackAmount { get; init; }

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
    /// Amount up to N digit after the decimals separator as defined in ISO 4217 for the appropriate currency code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processorTransactionFee")]
    [MaxLength(15)]
    public string? ProcessorTransactionFee { get; init; }

    /// <summary>
    /// The rate of conversion of the currency given in the request to CNY. The conversion happens at the time when Alipay’s trade order is created
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeRate")]
    [MaxLength(17)]
    public string? ExchangeRate { get; init; }

    /// <summary>
    /// Currency code for the transaction performed in cross border currency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foreignCurrency")]
    [MaxLength(3)]
    public string? ForeignCurrency { get; init; }

    /// <summary>
    /// The transaction amount in CNY.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foreignAmount")]
    [MaxLength(11)]
    public string? ForeignAmount { get; init; }

    /// <summary>
    /// If coupons/vouchers are used in the transaction, the discount amount redeemed in the settlement currency will be returned. Otherwise, no return.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountAmount")]
    [MaxLength(11)]
    public string? DiscountAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
