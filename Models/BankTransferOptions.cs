using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BankTransferOptions
{
    /// <summary>
    /// Space-separated list of AVS flags that cause the request to be declined for AVS reasons.
    /// <para>
    /// <b>Important</b> To receive declines for the AVS code <c>N</c>, you must include the value <c>N</c> in the space-separated list.
    /// </para>
    /// <para>
    /// ### AVS Codes for Cielo 3.0 and CyberSource Latin American Processing
    /// </para>
    /// <para>
    /// <b>Note</b> CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this section is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.
    /// </para>
    /// <para>
    /// |AVS Code|Description|
    /// |--- |--- |
    /// |D|Partial match: postal code and address match.|
    /// |E|Not supported: AVS is not supported for this card type. _or_ Invalid: the acquirer returned an unrecognized value for the AVS response.|
    /// |F|Partial match: postal code matches, but CPF and address do not match.*|
    /// |G|Not supported: AVS not supported or not verified.|
    /// |I|No match: AVS information is not available.|
    /// |K|Partial match: CPF matches, but postal code and address do not match.*|
    /// |L|Partial match: postal code and CPF match, but address does not match.*|
    /// |N|No match: postal code, CPF, and address do not match.*|
    /// |O|Partial match: CPF and address match, but postal code does not match.*|
    /// |R|Not supported: your implementation does not support AVS _or_ System unavailable.|
    /// |T|Partial match: address matches, but postal code and CPF do not match.*|
    /// |V|Match: postal code, CPF, and address match.*|
    /// |* CPF (Cadastro de Pessoas Fisicas) is required only for Redecard in Brazil.||
    /// </para>
    /// <para>
    /// ### AVS Codes for All Other Processors
    /// </para>
    /// <para>
    /// <b>Note</b> The list of AVS codes for all other processors follows these descriptions of the processor-specific information for these codes.
    /// </para>
    /// <para>
    /// #### American Express Cards
    /// For American Express cards only, you can receive Visa and CyberSource AVS codes in addition to the American Express AVS codes.
    /// </para>
    /// <para>
    /// <b>Note</b> For CyberSource through VisaNet, the American Express AVS codes are converted to Visa AVS codes before they are returned to you. As a result, you will not receive American Express AVS codes for the American Express card type.
    /// </para>
    /// <para>
    /// _American Express Card codes_: <c>F</c>, <c>H</c>, <c>K</c>, <c>L</c>, <c>O</c>, <c>T</c>, <c>V</c>
    /// </para>
    /// <para>
    /// #### Domestic and International Visa Cards
    /// The international and domestic alphabetic AVS codes are the Visa standard AVS codes. CyberSource maps the standard AVS return codes for other types of payment cards, including American Express cards, to the Visa standard AVS codes.
    /// </para>
    /// <para>
    /// AVS is considered either domestic or international, depending on the location of the bank that issued the customer’s payment card:
    /// - When the bank is in the U.S., the AVS is domestic.
    /// - When the bank is outside the U.S., the AVS is international.
    /// </para>
    /// <para>
    /// You should be prepared to handle both domestic and international AVS result codes:
    /// - For international cards, you can receive domestic AVS codes in addition to the international AVS codes.
    /// - For domestic cards, you can receive international AVS codes in addition to the domestic AVS codes.
    /// </para>
    /// <para>
    /// _International Visa Codes_: <c>B</c>, <c>C</c>, <c>D</c>, <c>G</c>, <c>I</c>, <c>M</c>, <c>P</c>
    /// </para>
    /// <para>
    /// _Domestic Visa Codes_: <c>A</c>, <c>E</c>,<c>N</c>, <c>R</c>, <c>S</c>, <c>U</c>, <c>W</c>, <c>X</c>, <c>Y</c>, <c>Z</c>
    /// </para>
    /// <para>
    /// #### CyberSource Codes
    /// The numeric AVS codes are created by CyberSource and are not standard Visa codes. These AVS codes can be returned for any card type.
    /// </para>
    /// <para>
    /// _CyberSource Codes_: <c>1</c>, <c>2</c>, <c>3</c>, <c>4</c>
    /// </para>
    /// <para>
    /// ### Table of AVS Codes for All Other Processors
    /// </para>
    /// <para>
    /// |AVS Code|Description|
    /// |--- |--- |
    /// |A|Partial match: street address matches, but 5-digit and 9-digit postal codes do not match.|
    /// |B|Partial match: street address matches, but postal code is not verified. Returned only for Visa cards not issued in the U.S.|
    /// |C|No match: street address and postal code do not match. Returned only for Visa cards not issued in the U.S.|
    /// |D &amp; M|Match: street address and postal code match. Returned only for Visa cards not issued in the U.S.|
    /// |E|Invalid: AVS data is invalid or AVS is not allowed for this card type.|
    /// |F|Partial match: card member’s name does not match, but billing postal code matches.|
    /// |G|Not supported: issuing bank outside the U.S. does not support AVS.|
    /// |H|Partial match: card member’s name does not match, but street address and postal code match. Returned only for the American Express card type.|
    /// |I|No match: address not verified. Returned only for Visa cards not issued in the U.S.|
    /// |K|Partial match: card member’s name matches, but billing address and billing postal code do not match. Returned only for the American Express card type.|
    /// |L|Partial match: card member’s name and billing postal code match, but billing address does not match. Returned only for the American Express card type.|
    /// |M|See the entry for D &amp; M.|
    /// |N|No match: one of the following: street address and postal code do not match _or_ (American Express card type only) card member’s name, street address, and postal code do not match.|
    /// |O|Partial match: card member’s name and billing address match, but billing postal code does not match. Returned only for the American Express card type.|
    /// |P|Partial match: postal code matches, but street address not verified. Returned only for Visa cards not issued in the U.S.|
    /// |R|System unavailable.|
    /// |S|Not supported: issuing bank in the U.S. does not support AVS.|
    /// |T|Partial match: card member’s name does not match, but street address matches. Returned only for the American Express card type.|
    /// |U|System unavailable: address information unavailable for one of these reasons: The U.S. bank does not support AVS outside the U.S. _or_ The AVS in a U.S. bank is not functioning properly.|
    /// |V|Match: card member’s name, billing address, and billing postal code match. Returned only for the American Express card type.|
    /// |W|Partial match: street address does not match, but 9-digit postal code matches.|
    /// |X|Match: street address and 9-digit postal code match.|
    /// |Y|Match: street address and 5-digit postal code match.|
    /// |Z|Partial match: street address does not match, but 5-digit postal code matches.|
    /// |1|Not supported: one of the following: AVS is not supported for this processor or card type _or_ AVS is disabled for your CyberSource account. To enable AVS, contact CyberSource Customer Support.|
    /// |2|Unrecognized: the processor returned an unrecognized value for the AVS response.|
    /// |3|Match: address is confirmed. Returned only for PayPal Express Checkout.|
    /// |4|No match: address is not confirmed. Returned only for PayPal Express Checkout.|
    /// |5|No match: no AVS code was returned by the processor.|
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("declineAvsFlags")]
    [MaxLength(15)]
    public string? DeclineAvsFlags { get; init; }

    /// <summary>
    /// Specifies the authorization method for the transaction.
    /// <para>
    /// #### TeleCheck
    /// Accepts only the following values:
    /// - <c>ARC</c>: account receivable conversion
    /// - <c>CCD</c>: corporate cash disbursement
    /// - <c>POP</c>: point of purchase conversion
    /// - <c>PPD</c>: prearranged payment and deposit entry
    /// - <c>TEL</c>: telephone-initiated entry
    /// - <c>WEB</c>: internet-initiated entry
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secCode")]
    [MaxLength(3)]
    public string? SecCode { get; init; }

    /// <summary>
    /// City in which the terminal is located. If more than four alphanumeric characters are submitted, the transaction
    /// will be declined.
    /// <para>
    /// You cannot include any special characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalCity")]
    [MaxLength(4)]
    public string? TerminalCity { get; init; }

    /// <summary>
    /// State in which the terminal is located. If more than two alphanumeric characters are submitted, the transaction
    /// will be declined.
    /// <para>
    /// You cannot include any special characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalState")]
    [MaxLength(2)]
    public string? TerminalState { get; init; }

    /// <summary>
    /// Effective date for the transaction. The effective date must be within 45 days of the current day. If you do not
    /// include this value, CyberSource sets the effective date to the next business day.
    /// <para>
    /// Format: <c>MMDDYYYY</c>
    /// </para>
    /// <para>
    /// Supported only for the CyberSource ACH Service.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveDate")]
    [MaxLength(8)]
    public string? EffectiveDate { get; init; }

    /// <summary>
    /// Identifier for a partial payment or partial credit.
    /// <para>
    /// The value for each debit request or credit request must be unique within the scope of the order.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partialPaymentId")]
    [MaxLength(25)]
    public string? PartialPaymentId { get; init; }

    /// <summary>
    /// Payment related information.
    /// <para>
    /// This information is included on the customer’s statement.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerMemo")]
    [MaxLength(80)]
    public string? CustomerMemo { get; init; }

    /// <summary>
    /// Flag that indicates whether to process the payment.
    /// <para>
    /// Use with deferred payments.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>0</c>: Standard debit with immediate payment (default).
    /// - <c>1</c>: For deferred payments, indicates that this is a deferred payment and that you will send a debit request
    /// with <c>paymentCategoryCode = 2</c> in the future.
    /// - <c>2</c>: For deferred payments, indicates notification to initiate payment.
    /// </para>
    /// <para>
    /// #### Chase Paymentech Solutions and TeleCheck
    /// Use for deferred and partial payments.
    /// </para>
    /// <para>
    /// #### CyberSource ACH Service
    /// Not used.
    /// </para>
    /// <para>
    /// #### RBS WorldPay Atlanta
    /// Not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentCategoryCode")]
    [MaxLength(1)]
    public string? PaymentCategoryCode { get; init; }

    /// <summary>
    /// Method used for settlement.
    /// <para>
    /// Possible values:
    /// - <c>A</c>: Automated Clearing House (default for credits and for transactions using Canadian dollars)
    /// - <c>F</c>: Facsimile draft (U.S. dollars only)
    /// - <c>B</c>: Best possible (U.S. dollars only) (default if the field has not already been configured for your
    /// merchant ID)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settlementMethod")]
    [MaxLength(1)]
    public string? SettlementMethod { get; init; }

    /// <summary>
    /// Level of fraud screening.
    /// <para>
    /// Possible values:
    /// - <c>1</c>: Validation — default if the field has not already been configured for your merchant ID
    /// - <c>2</c>: Verification
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudScreeningLevel")]
    [MaxLength(1)]
    public string? FraudScreeningLevel { get; init; }

    /// <summary>
    /// Indicates whether a customer is physically present and whether the customer is enrolling in CyberSource Recurring Billing.
    /// <para>
    /// Possible values:
    /// - <c>1</c>: Customer is present and not enrolling.
    /// - <c>2</c>: Customer is not present and not enrolling.
    /// - <c>3</c>: Customer is present and enrolling.
    /// - <c>4</c>: Customer is not present and enrolling.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerPresent")]
    [MaxLength(1)]
    public string? CustomerPresent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
