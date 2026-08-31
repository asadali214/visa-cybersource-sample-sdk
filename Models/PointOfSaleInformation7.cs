using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PointOfSaleInformation7
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
    /// Identifies the Zone PIN Key (ZPK) used for Online PIN processing by providing the 10‑digit Key Set Identifier (KSI).
    /// This value indicates that the PIN block is encrypted under a ZPK and enables the Payment Security Service (PSS) to perform
    /// the correct ZPK→ZPK PIN translation during card‑present EMV PIN transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedKeyId")]
    [MaxLength(100)]
    public string? EncryptedKeyId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
