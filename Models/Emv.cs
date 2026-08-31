using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Emv
{
    /// <summary>
    /// EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV
    /// data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.
    /// <para>
    /// For information about the individual tags, see the “Application Specification” section in the EMV 4.3 Specifications: http://emvco.com
    /// </para>
    /// <para>
    /// <b>Note</b> Card present information about EMV applies only to credit card processing and PIN debit processing.
    /// All other card present information applies only to credit card processing. PIN debit processing is available only
    /// on FDC Nashville Global.
    /// </para>
    /// <para>
    /// <b>Important</b> The following tags contain sensitive information and <b>must not</b> be included in this field:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>56</c>: Track 1 equivalent data</description></item>
    ///   <item><description><c>57</c>: Track 2 equivalent data</description></item>
    ///   <item><description><c>5A</c>: Application PAN</description></item>
    ///   <item><description><c>5F20</c>: Cardholder name</description></item>
    ///   <item><description><c>5F24</c>: Application expiration date (This sensitivity has been relaxed for Credit Mutuel-CIC, American Express Direct, FDC Nashville Global, First Data Merchant Solutions, and SIX)</description></item>
    ///   <item><description><c>99</c>: Transaction PIN</description></item>
    ///   <item><description><c>9F0B</c>: Cardholder name (extended)</description></item>
    ///   <item><description><c>9F1F</c>: Track 1 discretionary data</description></item>
    ///   <item><description><c>9F20</c>: Track 2 discretionary data</description></item>
    /// </list>
    /// <para>
    /// For captures, this field is required for contact EMV transactions. Otherwise, it is optional.
    /// </para>
    /// <para>
    /// For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits.
    /// Otherwise, it is optional.
    /// </para>
    /// <para>
    /// <b>Important</b> For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits,
    /// you must include the following tags in this field. For all other types of EMV transactions, the following tags
    /// are optional.
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>95</c>: Terminal verification results</description></item>
    ///   <item><description><c>9F10</c>: Issuer application data</description></item>
    ///   <item><description><c>9F26</c>: Application cryptogram</description></item>
    /// </list>
    /// <para>
    ///
    /// #### CyberSource through VisaNet
    /// - In Japan: 199 bytes
    /// - In other countries: String (252)
    /// </para>
    /// <para>
    /// For Mastercard Transactions, Optionally Tag 9F60 (Authenticated Application Data) and
    /// Tag 96 (Kernel Identifier - Terminal) can be included in the Field.
    /// </para>
    /// <para>
    /// #### GPX
    /// This field only supports transactions from the following card types:
    /// - Visa
    /// - Mastercard
    /// - AMEX
    /// - Discover
    /// - Diners
    /// - JCB
    /// - Union Pay International
    /// </para>
    /// <para>
    /// #### JCN Gateway
    /// The following tags must be included:
    /// - <c>4F</c>: Application identifier
    /// - <c>84</c>: Dedicated file name
    /// </para>
    /// <para>
    /// Data length: 199 bytes
    /// </para>
    /// <para>
    /// #### All other processors:
    /// String (999)
    /// </para>
    /// <para>
    /// #### Used by
    /// Authorization: Optional
    /// Authorization Reversal: Optional
    /// Credit: Optional
    /// PIN Debit processing (purchase, credit and reversal): Optional
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    [MaxLength(1998)]
    public string? Tags { get; init; }

    /// <summary>
    /// Method that was used to verify the cardholder's identity.
    /// <para>
    /// Possible values:
    ///  - <c>0</c>: No verification
    ///  - <c>1</c>: Signature
    /// </para>
    /// <para>
    /// This field is supported only on <b>American Express Direct</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardholderVerificationMethodUsed")]
    public int? CardholderVerificationMethodUsed { get; init; }

    /// <summary>
    /// Number assigned to a specific card when two or more cards are associated with the same primary account number.
    /// <para>
    /// This value enables issuers to distinguish among multiple cards that are linked to the same account.
    /// </para>
    /// <para>
    /// This value can also act as a tracking tool when reissuing cards.
    /// </para>
    /// <para>
    /// When this value is available, it is provided by the chip reader.
    /// </para>
    /// <para>
    /// When the chip reader does not provide this value, do not include this field in your request.
    /// </para>
    /// <para>
    /// When sequence number is not provided via this API field, the value is extracted from EMV tag 5F34 for Visa and Mastercard transactions. To enable this feature please call support.
    /// </para>
    /// <para>
    /// <b>Note</b> Card present information about EMV applies only to credit card processing and PIN debit processing.
    /// </para>
    /// <para>
    /// All other card present information applies only to credit card processing.
    /// </para>
    /// <para>
    /// PIN debit processing is available only on CyberSource through VisaNet and FDC Nashville Global.
    /// </para>
    /// <para>
    /// #### Used by
    /// Authorization: Optional
    /// PIN Debit processing: Optional
    /// </para>
    /// <para>
    /// #### GPX
    /// </para>
    /// <para>
    /// This field only supports transactions from the following card types:
    /// - Visa
    /// - Mastercard
    /// - AMEX
    /// - Discover
    /// - Diners
    /// - JCB
    /// - Union Pay International
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardSequenceNumber")]
    [MaxLength(3)]
    public string? CardSequenceNumber { get; init; }

    /// <summary>
    /// Indicates whether a fallback method was used to enter credit card information into the POS terminal. When a
    /// technical problem prevents a successful exchange of information between a chip card and a chip-capable terminal:
    /// <para>
    ///  1. Swipe the card or key the credit card information into the POS terminal.
    ///  2. Use the pointOfSaleInformation.entryMode field to indicate whether the information was swiped or keyed.
    /// </para>
    /// <para>
    ///
    /// Possible values:
    /// - <c>true</c>: Fallback method was used.
    /// - <c>false</c> (default): Fallback method was not used.
    /// </para>
    /// <para>
    /// This field is supported only on American Express Direct, Chase Paymentech Solutions, CyberSource through VisaNet,
    /// FDC Nashville Global, GPN, JCN Gateway, OmniPay Direct, and SIX.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fallback")]
    public bool? Fallback { get; init; }

    /// <summary>
    /// Reason for the EMV fallback transaction. An EMV fallback transaction occurs when an EMV transaction fails for
    /// one of these reasons:
    /// <para>
    ///  - Technical failure: the EMV terminal or EMV card cannot read and process chip data.
    ///  - Empty candidate list failure: the EMV terminal does not have any applications in common with the EMV card.
    ///    EMV terminals are coded to determine whether the terminal and EMV card have any applications in common.
    ///    EMV terminals provide this information to you.
    /// </para>
    /// <para>
    /// Possible values:
    /// </para>
    /// <para>
    ///  - <c>1</c>: Transaction was initiated with information from a magnetic stripe, and the previous transaction at the
    ///     EMV terminal either used information from a successful chip read or it was not a chip transaction.
    ///  - <c>2</c>: Transaction was initiated with information from a magnetic stripe, and the previous transaction at the
    ///     EMV terminal was an EMV fallback transaction because the attempted chip read was unsuccessful.
    /// </para>
    /// <para>
    /// This field is supported only on <b>GPN</b> and <b>JCN Gateway</b>.
    /// <b>NOTE</b>: This field is required when an EMV transaction fails for a technical reason. Do not include this field
    /// when the EMV terminal does not have any applications in common with the EMV card.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fallbackCondition")]
    public int? FallbackCondition { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Value “true” indicates this transaction is intentionally duplicated . The field contains value “true” which
    /// indicates that merchant has intentionally duplicated single tap transaction. Merchant is intentionally sending
    /// a duplicate auth request for a single tap txn because the issuer requested a PIN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isRepeat")]
    public bool? IsRepeat { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
