using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Emv2
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
