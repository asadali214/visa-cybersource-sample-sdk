using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record PointOfSaleInformation14
{
    /// <summary>
    /// Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.
    /// <para>
    /// #### CyberSource through VisaNet
    /// A list of all possible values is stored in your CyberSource account. If terminal ID validation is enabled for
    /// your CyberSource account, the value you send for this field is validated against the list each time you include
    /// the field in a request. To enable or disable terminal ID validation, contact CyberSource Customer Support.
    /// </para>
    /// <para>
    /// When you do not include this field in a request, CyberSource uses the default value that is defined in your CyberSource account.
    /// </para>
    /// <para>
    /// #### FDC Nashville Global
    /// To have your account configured to support this field, contact CyberSource Customer Support. This value must be a value that FDC Nashville Global issued to you.
    /// </para>
    /// <para>
    /// #### For Payouts
    /// This field is applicable for CyberSource through VisaNet.
    /// </para>
    /// <para>
    /// #### GPX
    /// Identifier for the terminal at your retail location. A list of all possible values is stored in your account.
    /// If terminal ID validation is enabled for your account, the value you send for this field is validated against
    /// the list each time you include the field in a request. To enable or disable terminal ID validation, contact
    /// customer support.
    /// </para>
    /// <para>
    /// When you do not include this field in a request, the default value that is defined in your account is used.
    /// </para>
    /// <para>
    /// Optional for authorizations.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional for the following processors. When you do not include this field in a request, the default value that is
    /// defined in your account is used.
    ///   - American Express Direct
    ///   - Credit Mutuel-CIC
    ///   - FDC Nashville Global
    ///   - SIX
    /// - Chase Paymentech Solutions: Optional field. If you include this field in your request, you must also include <c>pointOfSaleInformation.catLevel</c>.
    /// - FDMS Nashville: The default value that is defined in your account is used.
    /// - GPX
    /// - OmniPay Direct: Optional field.
    /// </para>
    /// <para>
    /// For the following processors, this field is not used.
    /// - GPN
    /// - JCN Gateway
    /// - RBS WorldPay Atlanta
    /// - TSYS Acquiring Solutions
    /// - Worldpay VAP
    /// </para>
    /// <para>
    /// #### Card Present reply
    /// Terminal identifier assigned by the acquirer. This value must be printed on the receipt.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalId")]
    [MaxLength(8)]
    public string? TerminalId { get; init; }

    /// <summary>
    /// Method of entering payment card information into the POS terminal. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>contact</c>: Read from direct contact with chip card.</description></item>
    ///   <item><description><c>contactless</c>: Read from a contactless interface using chip data.</description></item>
    ///   <item><description><c>keyed</c>: Manually keyed into POS terminal. This value is not supported on OmniPay Direct.</description></item>
    ///   <item><description><c>msd</c>: Read from a contactless interface using magnetic stripe data (MSD). This value is not supported on OmniPay Direct.</description></item>
    ///   <item><description><c>swiped</c>: Read from credit card magnetic stripe.</description></item>
    /// </list>
    /// <para>
    /// The <c>contact</c>, <c>contactless</c>, and <c>msd</c> values are supported only for EMV transactions.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required field.
    /// </para>
    /// <para>
    /// #### Card Present
    /// Card present information about EMV applies only to credit card processing and PIN debit processing. All other
    /// card present information applies only to credit card processing.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Required for a PIN debit purchase and a PIN debit credit request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entryMode")]
    [MaxLength(11)]
    public string? EntryMode { get; init; }

    /// <summary>
    /// POS terminal’s capability. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>1</c>: Terminal has a magnetic stripe reader only.</description></item>
    ///   <item><description><c>2</c>: Terminal has a magnetic stripe reader and manual entry capability.</description></item>
    ///   <item><description><c>3</c>: Terminal has manual entry capability only.</description></item>
    ///   <item><description><c>4</c>: Terminal can read chip cards.</description></item>
    ///   <item><description><c>5</c>: Terminal can read contactless chip cards; cannot use contact to read chip cards.</description></item>
    /// </list>
    /// <para>
    /// For an EMV transaction, the value of this field must be <c>4</c> or <c>5</c>.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Required for PIN debit purchase and PIN debit credit request.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required for the following processors:
    /// - American Express Direct
    /// - Chase Paymentech Solutions
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - FDMS Nashville
    /// - OmniPay Direct
    /// - SIX
    /// - Worldpay VAP
    /// </para>
    /// <para>
    /// Optional for the following processors:
    /// - CyberSource through VisaNet
    /// - GPN
    /// - GPX
    /// - JCN Gateway
    /// - RBS WorldPay Atlanta
    /// - TSYS Acquiring Solutions
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalCapability")]
    [Minimum(1)]
    [Maximum(5)]
    public int? TerminalCapability { get; init; }

    /// <summary>
    /// Method that was used to verify the cardholder's identity. Possible values:
    /// <list type="bullet">
    ///   <item><description><c>0</c>: No verification</description></item>
    ///   <item><description><c>1</c>: Signature</description></item>
    ///   <item><description><c>2</c>: PIN</description></item>
    ///   <item><description><c>3</c>: Cardholder device CVM</description></item>
    ///   <item><description><c>4</c>: Biometric</description></item>
    ///   <item><description><c>5</c>: OTP</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardholderVerificationMethodUsed")]
    public int? CardholderVerificationMethodUsed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emv")]
    public Emv2? Emv { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
