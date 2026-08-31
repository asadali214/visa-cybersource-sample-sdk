using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AccountFeatures
{
    /// <summary>
    /// Type of account. This value is returned only if you requested a balance inquiry. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>00</c>: Not applicable or not specified</description></item>
    ///   <item><description><c>10</c>: Savings account</description></item>
    ///   <item><description><c>20</c>: Checking account</description></item>
    ///   <item><description><c>30</c>: Credit card account</description></item>
    ///   <item><description><c>40</c>: Universal account</description></item>
    /// </list>
    /// <para>
    /// #### PIN debit
    /// Type of account. This value is returned only if you requested a balance inquiry.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>00</c>: Not applicable or not specified
    /// - <c>10</c>: Savings account
    /// - <c>20</c>: Checking account
    /// - <c>40</c>: Universal account
    /// - <c>96</c>: Cash benefits account
    /// - <c>98</c>: Food stamp account
    /// </para>
    /// <para>
    /// Returned by PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    [MaxLength(2)]
    public string? AccountType { get; init; }

    /// <summary>
    /// Possible values:
    /// - <c>N</c>: Nonregulated
    /// - <c>R</c>: Regulated
    /// <para>
    /// Returned by PIN debit credit or PIN debit purchase.
    /// </para>
    /// <para>
    /// <b>Note</b> This field is returned only for CyberSource through VisaNet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountStatus")]
    [MaxLength(1)]
    public string? AccountStatus { get; init; }

    /// <summary>
    /// This is an array of multiple balances information an issuer can return for a given card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balances")]
    public IReadOnlyList<Balance>? Balances { get; init; }

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
    [MaxLength(12)]
    public string? BalanceAmount { get; init; }

    /// <summary>
    /// Type of amount. This value is returned only if you requested a balance inquiry. The issuer determines the value
    /// that is returned. Possible values for deposit accounts:
    /// <list type="bullet">
    ///   <item><description><c>01</c>: Current ledger (posted) balance.</description></item>
    ///   <item><description><c>02</c>: Current available balance, which is typically the ledger balance less outstanding authorizations.</description></item>
    /// </list>
    /// <para>
    /// Some depository institutions also include pending deposits and the credit or overdraft line associated with the
    /// account. Possible values for credit card accounts:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>01</c>: Credit amount remaining for customer (open to buy).</description></item>
    ///   <item><description><c>02</c>: Credit limit.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAmountType")]
    [MaxLength(2)]
    public string? BalanceAmountType { get; init; }

    /// <summary>
    /// Currency of the remaining balance on the account. For the possible values, see the <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes.</see>
    /// <para>
    /// Returned by authorization service.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Currency of the remaining balance on the prepaid card.
    /// </para>
    /// <para>
    /// Returned by PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MaxLength(5)]
    public string? Currency { get; init; }

    /// <summary>
    /// Sign for the remaining balance on the account. Returned only when the processor returns this value. Possible values:
    /// <para>
    /// Possible values:
    /// - <c>Positive</c>
    /// - <c>Negative</c>
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Sign for the remaining balance on the prepaid card. Returned only when the processor returns this value.
    /// </para>
    /// <para>
    /// Returned by PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceSign")]
    [MaxLength(8)]
    public string? BalanceSign { get; init; }

    /// <summary>
    /// <b>Chase Paymentech Solutions</b>
    /// <para>
    /// Indicates whether a customer has high credit limits. This information enables you to market high cost items to
    /// these customers and to understand the kinds of cards that high income customers are using.
    /// </para>
    /// <para>
    /// This field is supported for Visa, Mastercard, Discover, and Diners Club. Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>Y</c>: Yes</description></item>
    ///   <item><description><c>N</c>: No</description></item>
    ///   <item><description><c>X</c>: Not applicable / Unknown</description></item>
    /// </list>
    /// <para>
    /// #### Litle
    /// </para>
    /// <para>
    /// Flag that indicates that a Visa cardholder or Mastercard cardholder is in one of the affluent categories.
    /// Possible values:
    /// </para>
    /// <para>
    ///  - <c>AFFLUENT</c>: High income customer with high spending pattern (&gt;100k USD annual income and &gt;40k USD annual
    ///    card usage).
    ///  - <c>MASS AFFLUENT</c>: High income customer (&gt;100k USD annual income).
    /// </para>
    /// <para>
    ///  Maximum length is 13.
    /// </para>
    /// <para>
    /// #### Chase Paymentech Solutions
    ///  Maximum length is 1.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affluenceIndicator")]
    [MaxLength(13)]
    public string? AffluenceIndicator { get; init; }

    /// <summary>
    /// #### GPX
    /// Mastercard product ID associated with the primary account number (PAN).
    /// Returned by authorization service.
    /// <para>
    /// #### CyberSource through VisaNet
    /// Visa or Mastercard product ID that is associated with the primary account number (PAN).
    /// For descriptions of the Visa product IDs, see the Product ID table on the [Visa
    /// Request &amp; Response Codes web page.](https://developer.visa.com/guides/request_response_codes)
    /// </para>
    /// <para>
    /// Data Length: String (3)
    /// </para>
    /// <para>
    /// #### GPN
    /// Visa or Mastercard product ID that is associated with the primary account number (PAN).
    /// For descriptions of the Visa product IDs, see the Product ID table on the
    /// <see href="https://developer.visa.com/guides/request_response_codes">Visa Request &amp; Response Codes web page.</see>
    /// </para>
    /// <para>
    /// Data Length: String (3)
    /// </para>
    /// <para>
    /// #### Worldpay VAP
    /// <b>Important</b> Before using this field on Worldpay VAP,
    /// you must contact CyberSource Customer Support to have
    /// your account configured for this feature.
    /// </para>
    /// <para>
    /// Type of card used in the transaction. The only possible value is:
    /// - <c>PREPAID</c>: Prepaid Card
    /// </para>
    /// <para>
    /// Data Length: String (7)
    /// </para>
    /// <para>
    /// #### RBS WorldPay Atlanta
    /// Type of card used in the transaction. Possible values:
    /// - <c>B</c>: Business Card
    /// - <c>O</c>: Noncommercial Card
    /// - <c>R</c>: Corporate Card
    /// - <c>S</c>: Purchase Card
    /// - <c>Blank</c>: Purchase card not supported
    /// </para>
    /// <para>
    /// Data Length: String (1)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    [MaxLength(7)]
    public string? Category { get; init; }

    /// <summary>
    /// Indicates whether the card is a commercial card, which enables you to include Level II data in your transaction
    /// requests. This field is supported for Visa and Mastercard on <b>Chase Paymentech Solutions</b>. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>Y</c>: Yes</description></item>
    ///   <item><description><c>N</c>: No</description></item>
    ///   <item><description><c>X</c>: Not applicable / Unknown</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commercial")]
    [MaxLength(1)]
    public string? Commercial { get; init; }

    /// <summary>
    /// Type of commercial card. This field is supported only for CyberSource through VisaNet. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>B</c>: Business card</description></item>
    ///   <item><description><c>R</c>: Corporate card</description></item>
    ///   <item><description><c>S</c>: Purchasing card</description></item>
    ///   <item><description><c>0</c>: Noncommercial card</description></item>
    /// </list>
    /// <para>
    /// Returned by authorization service.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    [MaxLength(1)]
    public string? Group { get; init; }

    /// <summary>
    /// Indicates whether the card is a healthcare card. This field is supported for Visa and Mastercard on **Chase
    /// Paymentech Solutions**. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>Y</c>: Yes</description></item>
    ///   <item><description><c>N</c>: No</description></item>
    ///   <item><description><c>X</c>: Not applicable / Unknown</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("healthCare")]
    [MaxLength(1)]
    public string? HealthCare { get; init; }

    /// <summary>
    /// Indicates whether the card is a payroll card. This field is supported for Visa, Discover, Diners Club, and JCB
    /// on <b>Chase Paymentech Solutions</b>. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>Y</c>: Yes</description></item>
    ///   <item><description><c>N</c>: No</description></item>
    ///   <item><description><c>X</c>: Not applicable / Unknown</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payroll")]
    [MaxLength(1)]
    public string? Payroll { get; init; }

    /// <summary>
    /// Indicates whether the card is eligible for Level III interchange fees, which enables you to include Level III
    /// data in your transaction requests. This field is supported for Visa and Mastercard on **Chase Paymentech
    /// Solutions**. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>Y</c>: Yes</description></item>
    ///   <item><description><c>N</c>: No</description></item>
    ///   <item><description><c>X</c>: Not applicable / Unknown</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level3Eligible")]
    [MaxLength(1)]
    public string? Level3Eligible { get; init; }

    /// <summary>
    /// Indicates whether the card is a PINless debit card. This field is supported for Visa and Mastercard on **Chase
    /// Paymentech Solutions**. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>Y</c>: Yes</description></item>
    ///   <item><description><c>N</c>: No</description></item>
    ///   <item><description><c>X</c>: Not applicable / Unknown</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinlessDebit")]
    [MaxLength(1)]
    public string? PinlessDebit { get; init; }

    /// <summary>
    /// Indicates whether the card is a signature debit card.
    /// <para>
    /// This information enables you to alter the way an order is processed. For example, you might not want to reauthorize a transaction for a signature debit card, or you might
    /// want to perform reversals promptly for a signature debit card. This field is supported for Visa, Mastercard, and
    /// Maestro (International) on Chase Paymentech Solutions. Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>Y</c>: Yes</description></item>
    ///   <item><description><c>N</c>: No</description></item>
    ///   <item><description><c>X</c>: Not applicable / Unknown</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatureDebit")]
    [MaxLength(1)]
    public string? SignatureDebit { get; init; }

    /// <summary>
    /// Indicates whether the card is a prepaid card. This information enables you to determine when a gift card or
    /// prepaid card is presented for use when establishing a new recurring, installment, or deferred billing
    /// relationship.
    /// <para>
    /// This field is supported for Visa, Mastercard, Discover, Diners Club, and JCB on Chase Paymentech Solutions.
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>Y</c>: Yes</description></item>
    ///   <item><description><c>N</c>: No</description></item>
    ///   <item><description><c>X</c>: Not applicable / Unknown</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prepaid")]
    [MaxLength(1)]
    public string? Prepaid { get; init; }

    /// <summary>
    /// Indicates whether the card is regulated according to the Durbin Amendment. If the card is regulated, the card
    /// issuer is subject to price caps and interchange rules. This field is supported for Visa, Mastercard, Discover,
    /// Diners Club, and JCB on Chase Paymentech Solutions. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>Y</c>: Yes</description></item>
    ///   <item><description><c>N</c>: No</description></item>
    ///   <item><description><c>X</c>: Not applicable / Unknown</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("regulated")]
    [MaxLength(1)]
    public string? Regulated { get; init; }

    /// <summary>
    /// This is the account owner information, valid values are:
    /// - <c>01</c> : primary account holder
    /// - <c>02</c> : secondary account holder
    /// This is returned in the response of an account verification transaction by the Issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderType")]
    [MaxLength(25)]
    public string? AccountHolderType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
