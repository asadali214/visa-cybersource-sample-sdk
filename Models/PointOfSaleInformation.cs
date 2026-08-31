using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record PointOfSaleInformation
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
    /// Terminal serial number assigned by the hardware manufacturer. This value is provided by the client software that
    /// is installed on the POS terminal.
    /// <para>
    /// This value is not forwarded to the processor. Instead, the value is forwarded to the reporting functionality.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization and Credit</b>
    /// Optional. This field is supported only by client software that is installed on your POS terminals for the
    /// following processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - OmniPay Direct
    /// - SIX
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalSerialNumber")]
    [MaxLength(32)]
    public string? TerminalSerialNumber { get; init; }

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

    /// <summary>
    /// Identifier for an alternate terminal at your retail location. You define the value for this field.
    /// <para>
    /// This field is supported only for MasterCard transactions on FDC Nashville Global. Otherwise, this field is not used by all other processors.
    /// Use the <c>terminalId</c> field to identify the main terminal at your retail location. If your retail location has multiple terminals,
    /// use this <c>laneNumber</c> field to identify the terminal used for the transaction.
    /// </para>
    /// <para>
    /// This field is a pass-through, which means that the value is not checked or modified in any way before sending it to the processor.
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### Card present reply messaging
    /// Identifier for an alternate terminal at your retail location. You defined the value for this field in the request
    /// message. This value must be printed on the receipt.
    /// </para>
    /// <para>
    /// This field is supported only for MasterCard transactions on FDC Nashville Global.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("laneNumber")]
    [MaxLength(8)]
    public string? LaneNumber { get; init; }

    /// <summary>
    /// Type of cardholder-activated terminal. Possible values:
    /// <para>
    ///  - 1: Automated dispensing machine
    ///  - 2: Self-service terminal
    ///  - 3: Limited amount terminal
    ///  - 4: In-flight commerce (IFC) terminal
    ///  - 5: Radio frequency device
    ///  - 6: Mobile acceptance terminal
    ///  - 7: Electronic cash register
    ///  - 8: E-commerce device at your location
    ///  - 9: Terminal or cash register that uses a dialup connection to connect to the transaction processing network
    ///  - 10: Card Activated Fuel Dispenser
    ///  - 11: Travel ticket vending machine
    /// #### Chase Paymentech Solutions
    /// Only values 1, 2, and 3 are supported.
    /// </para>
    /// <para>
    /// Required if <c>pointOfSaleInformation.terminalID</c> is included in the request; otherwise, optional.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// Values 1 through 6 are supported on
    /// CyberSource through VisaNet, but some
    /// acquirers do not support all six values.
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### FDC Nashville Global
    /// Only values 7, 8, and 9 are supported.
    /// </para>
    /// <para>
    /// Optional field for EMV transactions; otherwise, not used.
    /// </para>
    /// <para>
    /// #### GPN
    /// Only values 6, 7, 8, and 9 are supported.
    /// </para>
    /// <para>
    /// Required field.
    /// </para>
    /// <para>
    /// #### JCN Gateway
    /// Only values 6, 7, 8, and 9 are supported.
    /// </para>
    /// <para>
    /// Required field.
    /// </para>
    /// <para>
    /// #### TSYS Acquiring Solutions
    /// Only value 6 is supported.
    /// </para>
    /// <para>
    /// Required for transactions from mobile devices; otherwise, not used.
    /// </para>
    /// <para>
    /// #### All other processors
    /// Not used.
    /// </para>
    /// <para>
    /// Nonnegative integer.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catLevel")]
    [Minimum(1)]
    [Maximum(11)]
    public int? CatLevel { get; init; }

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
    /// Operating environment.
    /// <para>
    /// Possible values for all card types except Mastercard:
    /// - <c>0</c>: No terminal used or unknown environment.
    /// - <c>1</c>: On merchant premises, attended.
    /// - <c>2</c>: On merchant premises, unattended. Examples: oil, kiosks, self-checkout, mobile telephone, personal digital assistant (PDA).
    /// - <c>3</c>: Off merchant premises, attended. Examples: portable POS devices at trade shows, at service calls, or in taxis.
    /// - <c>4</c>: Off merchant premises, unattended. Examples: vending machines, home computer, mobile telephone, PDA.
    /// - <c>5</c>: On premises of cardholder, unattended.
    /// - <c>9</c>: Unknown delivery mode.
    /// - <c>S</c>: Electronic delivery of product. Examples: music, software, or eTickets that are downloaded over the internet.
    /// - <c>T</c>: Physical delivery of product. Examples: music or software that is delivered by mail or by a courier.
    /// </para>
    /// <para>
    /// #### Possible values for Mastercard:
    /// - <c>2</c>: On merchant premises, unattended, or cardholder terminal. Examples: oil, kiosks, self-checkout, home computer, mobile telephone, personal digital assistant (PDA). Cardholder terminal is supported only for Mastercard transactions on CyberSource through VisaNet.
    /// - <c>4</c>: Off merchant premises, unattended, or cardholder terminal. Examples: vending machines, home computer, mobile telephone, PDA. Cardholder terminal is supported only for Mastercard transactions on CyberSource through VisaNet.
    /// </para>
    /// <para>
    /// This field is supported only for American Express Direct and CyberSource through VisaNet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("operatingEnvironment")]
    [MaxLength(1)]
    public string? OperatingEnvironment { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emv")]
    public Emv? Emv { get; init; }

    /// <summary>
    /// Point-of-sale details for the transaction. This value is returned only for <b>American Express Direct</b>.
    /// CyberSource generates this value, which consists of a series of codes that identify terminal capability,
    /// security data, and specific conditions present at the time the transaction occurred. To comply with the CAPN
    /// requirements, this value must be included in all subsequent follow-on requests, such as captures and follow-on
    /// credits.
    /// <para>
    /// When you perform authorizations, captures, and credits through CyberSource, CyberSource passes this value from
    /// the authorization service to the subsequent services for you. However, when you perform authorizations through
    /// CyberSource and perform subsequent services through other financial institutions, you must ensure that your
    /// requests for captures and credits include this value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amexCapnData")]
    [MaxLength(15)]
    public string? AmexCapnData { get; init; }

    /// <summary>
    /// Card’s track 1 and 2 data. For all processors except FDMS Nashville, this value consists of
    /// one of the following:
    /// <list type="bullet">
    ///   <item><description>Track 1 data</description></item>
    ///   <item><description>Track 2 data</description></item>
    ///   <item><description>Data for both tracks 1 and 2</description></item>
    /// </list>
    /// <para>
    /// For FDMS Nashville, this value consists of one of the following:
    ///  - Track 1 data
    ///  - Data for both tracks 1 and 2
    /// </para>
    /// <para>
    /// Example: %B4111111111111111^SMITH/JOHN ^1612101976110000868000000?;4111111111111111=16121019761186800000?
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required for Chase Paymentech Solutions, Credit Mutuel-CIC, CyberSource through VisaNet, FDC Nashville Global,
    /// JCN Gateway, OmniPay Direct, and SIX if <c>pointOfSaleInformation.entryMode</c> is equal to one of these values:
    /// - <c>contact</c>
    /// - <c>contactless</c>
    /// - <c>msd</c>
    /// - <c>swiped</c>
    /// Otherwise, this field not used.
    /// </para>
    /// <para>
    /// Required for all other processors if <c>pointOfSaleInformation.entryMode=swiped</c>; otherwise, this field is not used.
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
    /// #### PIN debit
    /// Track 2 data from the debit card. The sentinels are required.
    /// Required field for a PIN debit purchase and a PIN debit credit.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trackData")]
    public string? TrackData { get; init; }

    /// <summary>
    /// When connectivity is unavailable, the client software that is installed on the POS terminal can store a
    /// transaction in its memory and send it for authorization when connectivity is restored. This value is provided by
    /// the client software that is installed on the POS terminal.
    /// <para>
    /// This value is not forwarded to the processor. Instead, the value is forwarded to the reporting functionality.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>Y</c>: Transaction was stored and then forwarded.
    /// - <c>N</c> (default): Transaction was not stored and then forwarded.
    /// </para>
    /// <para>
    /// For authorizations and credits, this field is supported only on these processors:
    /// - American Express Direct
    /// - FDC Nashville Global
    /// - OmniPay Direct
    /// - SIX
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeAndForwardIndicator")]
    [MaxLength(1)]
    public string? StoreAndForwardIndicator { get; init; }

    /// <summary>
    /// Complete list of cardholder verification methods (CVMs) supported by the terminal.
    /// Optional field.
    /// Possible values:
    /// - <c>PIN</c>: For terminals with a PIN Pad
    /// - <c>Signature</c>: For terminals capable of receiving a signature
    /// - <c>pinOnGlass</c>: For terminals where PIN is entered on a glass-based capture mechanism
    /// <para>
    /// <b>EXAMPLE</b>: ["PIN","Signature"]; ["pinOnGlass","Signature"]
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardholderVerificationMethod")]
    public IReadOnlyList<string>? CardholderVerificationMethod { get; init; }

    /// <summary>
    /// Indicates the type of terminal.
    /// <para>
    /// Possible values:
    /// - <c>AFD</c>: Automated Fuel Dispenser
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalCategory")]
    [MaxLength(3)]
    public string? TerminalCategory { get; init; }

    /// <summary>
    /// Complete list of card input methods supported by the terminal.
    /// <para>
    /// Possible values:
    /// - <c>Keyed</c>: Terminal can accept card data that is entered manually.
    /// - <c>Swiped</c>: Terminal can accept card data from a magnetic stripe reader.
    /// - <c>Contact</c>: Terminal can accept card data in EMV contact mode ("dipping a card").
    /// - <c>Contactless</c>: Terminal can accept card data in EMV contactless mode ("tapping a card").
    /// - <c>BarCode</c>: Terminal can read bar codes.
    /// - <c>QRcode</c>: Terminal can read or scan QR codes.
    /// - <c>OCR</c>: Terminal can perform optical character recognition (OCT) on the card.
    /// </para>
    /// <para>
    /// <b>EXAMPLE</b>: ["Keyed","Swiped","Contact","Contactless"]
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization and Credit</b>
    /// Optional. This field is supported only by client software that is installed on your POS terminals for the
    /// following processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - OmniPay Direct
    /// - SIX
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalInputCapability")]
    public IReadOnlyList<string>? TerminalInputCapability { get; init; }

    /// <summary>
    /// Indicates whether the terminal can capture the card.
    /// <para>
    /// Possible values:
    /// - <c>1</c>: Terminal can capture card.
    /// - <c>0</c>: Terminal cannot capture card.
    /// </para>
    /// <para>
    /// For authorizations and credits, this field is supported only by these processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - OmniPay Direct
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalCardCaptureCapability")]
    [MaxLength(1)]
    public string? TerminalCardCaptureCapability { get; init; }

    /// <summary>
    /// Indicates whether the terminal can print or display messages.
    /// <para>
    /// Possible values:
    /// - 1: Neither
    /// - 2: Print only
    /// - 3: Display only
    /// - 4: Print and display
    /// - 5: Merchant terminal supports purchase only approvals
    /// </para>
    /// <para>
    /// This field is supported for authorizations and credits only on the following processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - OmniPay Direct
    /// - SIX
    /// - VisaNet
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalOutputCapability")]
    [MaxLength(1)]
    public string? TerminalOutputCapability { get; init; }

    /// <summary>
    /// Maximum PIN length that the terminal can capture.
    /// <para>
    /// Possible values:
    /// -  0: No PIN capture capability
    /// -  1: PIN capture capability unknown
    /// -  2: PIN Pad down
    /// -  4: Four characters
    /// -  5: Five characters
    /// -  6: Six characters
    /// -  7: Seven characters
    /// -  8: Eight characters
    /// -  9: Nine characters
    /// - 10: Ten characters
    /// - 11: Eleven characters
    /// - 12: Twelve characters
    /// </para>
    /// <para>
    /// This field is supported for authorizations and credits only on the following processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - OmniPay Direct
    /// - SIX
    /// - Visa Platform Connect
    /// </para>
    /// <para>
    /// Required field for authorization or credit of PIN transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalPinCapability")]
    public int? TerminalPinCapability { get; init; }

    /// <summary>
    /// This field will contain the type of Pin Pad the terminal has.
    /// <para>
    /// Possible values:
    /// -   PCI-SPoC: Where the pin is being put on screen
    /// -   PCI-PTS: Where the pin is being put on actual hardware pin pad
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinEntrySolution")]
    public string? PinEntrySolution { get; init; }

    /// <summary>
    /// Value created by the client software that uniquely identifies the POS device. This value is provided by the
    /// client software that is installed on the POS terminal.
    /// <para>
    /// CyberSource does not forward this value to the processor. Instead, the value is forwarded to the CyberSource
    /// reporting functionality.
    /// </para>
    /// <para>
    /// This field is supported only on American Express Direct, FDC Nashville Global, and SIX.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    [MaxLength(32)]
    public string? DeviceId { get; init; }

    /// <summary>
    /// Format that is used to encode the PIN block. This value is provided by the client software that is installed on
    /// the POS terminal.
    /// <para>
    /// Possible values:
    /// - <c>0</c>: ISO 9564 format 0
    /// - <c>1</c>: ISO 9564 format 1
    /// - <c>2</c>: ISO 9564 format 2
    /// - <c>3</c>: ISO 9564 format 3
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization, PIN Debit</b>
    /// - Required when the cardholder enters a PIN and the card cannot verify the PIN, which means that the issuer must verify the PIN.
    /// - Required for PIN debit credit or PIN debit purchase.
    /// </para>
    /// <para>
    /// For authorizations, this field is supported only on these processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - OmniPay Direct
    /// - SIX
    /// </para>
    /// <para>
    /// This field is also supported by processors that support chip and online PIN transactions. The following table lists the EMV Cards
    /// and Cardholder Verification Methods (CVMs) that these processors support:
    /// </para>
    /// <para>
    /// | Processor | Chip and Offline PIN | Chip and Online PIN | Chip and Signature |
    /// | --- | --- | --- | --- |
    /// | American Express Direct | Yes | Yes | Yes |
    /// | Chase Paymentech Solutions | No | No | Yes |
    /// | Credit Mutuel-CIC | Yes | Yes | Yes |
    /// | CyberSource through VisaNet | Yes | No | Yes |
    /// | FDC Nashville Global | Yes | Yes | Yes |
    /// | GPN | No | No | Yes |
    /// | OmniPay Direct | Yes | No | Yes |
    /// | SIX | Yes | Yes | Yes |
    /// </para>
    /// <para>
    /// #### GPX
    /// For chip and online PIN transactions for authorization, GPX supports the following EMV Cards and Cardholder Verification Methods (CVMs):
    /// - Chip and Offline PIN
    /// - Chip and Signature
    /// </para>
    /// <para>
    /// For PIN Debit Purchase and Credit Service transactions, GPX supports the following EMV Cards and Cardholder Verification Methods (CVMs):
    /// - Chip and Online PIN
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinBlockEncodingFormat")]
    [Maximum(9)]
    public int? PinBlockEncodingFormat { get; init; }

    /// <summary>
    /// Encrypted PIN.
    /// <para>
    /// This value is provided by the client software that is installed on the POS terminal.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization, PIN Debit</b>
    /// Required when the cardholder enters a PIN and the card cannot verify the PIN, which means that the issuer must verify the PIN.
    /// Required for PIN debit credit or PIN debit purchase.
    /// Required for online PIN transactions.
    /// </para>
    /// <para>
    /// For authorizations, this field is supported only on these processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - OmniPay Direct
    /// - SIX
    /// </para>
    /// <para>
    /// This field is also used by processors that support chip and online PIN transactions. The following table lists the EMV Cards
    /// and Cardholder Verification Methods (CVMs) that these processors support:
    /// </para>
    /// <para>
    /// | Processor | Chip and Offline PIN | Chip and Online PIN | Chip and Signature |
    /// | --- | --- | --- | --- |
    /// | American Express Direct | Yes | Yes | Yes |
    /// | Chase Paymentech Solutions | No | No | Yes |
    /// | Credit Mutuel-CIC | Yes | Yes | Yes |
    /// | CyberSource through VisaNet | Yes | No | Yes |
    /// | FDC Nashville Global | Yes | Yes | Yes |
    /// | GPN | No | No | Yes |
    /// | OmniPay Direct | Yes | No | Yes |
    /// | SIX | Yes | Yes | Yes |
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedPin")]
    [MaxLength(16)]
    public string? EncryptedPin { get; init; }

    /// <summary>
    /// Combination of the device's unique identifier and a transaction counter that is used in the process of
    /// decrypting the encrypted PIN. The entity that injected the PIN encryption keys into the terminal decrypts the
    /// encrypted PIN and creates this value.
    /// <para>
    /// For all terminals that are using derived unique key per transaction (DUKPT) encryption, this is generated as a
    /// single number within the terminal.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization, PIN Debit</b>
    /// - Required when the cardholder enters a PIN and the card cannot verify the PIN, which means that the issuer must verify the PIN.
    /// - Required for PIN debit credit or PIN debit purchase.
    /// - Required for online PIN transactions
    /// </para>
    /// <para>
    /// For authorizations, this field is supported only on these processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - OmniPay Direct
    /// - SIX
    /// </para>
    /// <para>
    /// This field is also used by processors that support chip and online PIN transactions. The following table lists the EMV Cards
    /// and Cardholder Verification Methods (CVMs) that these processors support:
    /// </para>
    /// <para>
    /// | Processor | Chip and Offline PIN | Chip and Online PIN | Chip and Signature |
    /// | --- | --- | --- | --- |
    /// | American Express Direct | Yes | Yes | Yes |
    /// | Chase Paymentech Solutions | No | No | Yes |
    /// | Credit Mutuel-CIC | Yes | Yes | Yes |
    /// | CyberSource through VisaNet | Yes | No | Yes |
    /// | FDC Nashville Global | Yes | Yes | Yes |
    /// | GPN | No | No | Yes |
    /// | OmniPay Direct | Yes | No | Yes |
    /// | SIX | Yes | Yes | Yes |
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedKeySerialNumber")]
    [MaxLength(20)]
    public string? EncryptedKeySerialNumber { get; init; }

    /// <summary>
    /// Identifies the Zone PIN Key (ZPK) used for Online PIN processing by providing the 10‑digit Key Set Identifier (KSI).
    /// This value indicates that the PIN block is encrypted under a ZPK and enables the Payment Security Service (PSS) to perform
    /// the correct ZPK→ZPK PIN translation during card‑present EMV PIN transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedKeyId")]
    [MaxLength(100)]
    public string? EncryptedKeyId { get; init; }

    /// <summary>
    /// Version of the software installed on the POS terminal. This value is provided by the client software that is
    /// installed on the POS terminal.
    /// <para>
    /// CyberSource does not forward this value to the processor. Instead, the value is forwarded to the CyberSource
    /// reporting functionality.
    /// </para>
    /// <para>
    /// This field is supported only on American Express Direct, FDC Nashville Global, and SIX.
    /// </para>
    /// <para>
    /// For authorizations and credits, this field is supported only on these processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - OmniPay Direct
    /// - SIX
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partnerSdkVersion")]
    [MaxLength(32)]
    public string? PartnerSdkVersion { get; init; }

    /// <summary>
    /// This 32 byte length-maximum EBCDIC-K value is used to identify which chip application was performed between the terminal and the chip product.
    /// The included values are the Application Identifier (AID) and the Dedicated File (DF) name. It is available to early- or full-option VSDC issuers.
    /// Only single byte Katakana characters that can map to the EBCDIC-K table expected in the name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emvApplicationIdentifierAndDedicatedFileName")]
    [MaxLength(32)]
    public string? EmvApplicationIdentifierAndDedicatedFileName { get; init; }

    /// <summary>
    /// Flag that indicates whether the terminal is compliant with standards mandated by the Reserve Bank of India for card-present domestic transactions in India.
    /// <para>
    /// Format:
    /// - First character indicates whether the terminal supports terminal line encryption (TLE). Possible values:
    ///   - 1: Not certified
    ///   - 2: Certified
    /// - Second character indicates whether the terminal supports Unique Key Per Transaction (UKPT) and Derived Unique Key Per Transaction (DUKPT). Possible values:
    ///   - 1: Not certified
    ///   - 2: Certified
    /// </para>
    /// <para>
    /// <b>Example</b> <c>21</c> indicates that the terminal supports TLE but does not support UKPT/DUKPT.
    /// </para>
    /// <para>
    /// You and the terminal vendors are responsible for terminal certification. If you have questions, contact your acquirer.
    /// </para>
    /// <para>
    /// This field is supported only for Mastercard transactions on CyberSource through VisaNet.
    /// </para>
    /// <para>
    /// <b>Note</b> On CyberSource through VisaNet, the value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCR6
    /// - Position: 92-93
    /// - Field: Mastercard Terminal Compliance Indicator
    /// </para>
    /// <para>
    /// The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment networks.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required for card-present transactions in India. Otherwise, not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalCompliance")]
    [MaxLength(2)]
    public string? TerminalCompliance { get; init; }

    /// <summary>
    /// Type of mPOS device. Possible values:
    /// - 0: Dongle
    /// - 1: Phone or tablet
    /// <para>
    /// This optional field is supported only for Mastercard transactions on CyberSource through VisaNet.
    /// </para>
    /// <para>
    /// The value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCR6
    /// - Position: 141
    /// - Field: Mastercard mPOS Transaction
    /// </para>
    /// <para>
    /// The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource.
    /// CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s
    /// acquirer, who uses this information to facilitate end-of-day clearing processing with payment networks.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isDedicatedHardwareTerminal")]
    [MaxLength(1)]
    public string? IsDedicatedHardwareTerminal { get; init; }

    /// <summary>
    /// This is the model name of the reader which is used to accept the payment.
    /// Possible values:
    ///  - E3555
    ///  - P400
    ///  - A920
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalModel")]
    [MaxLength(32)]
    public string? TerminalModel { get; init; }

    /// <summary>
    /// This is the manufacturer name of the reader which is used to accept the payment.
    /// Possible values:
    ///  - PAX
    ///  - Verifone
    ///  - Ingenico
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalMake")]
    [MaxLength(32)]
    public string? TerminalMake { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// Mastercard service code that is included in the track data.  This field is supported only for Mastercard on Visa Platform Connect.
    /// You can extract the service code from the track data and provide it in this API field.
    /// <para>
    /// When not provided it will be extracted from:
    ///   - Track2Data for MSR transactions
    ///   - EMV tag 5F30 for EMV transactions
    /// </para>
    /// <para>
    /// To enable this feature please call support.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceCode")]
    [MaxLength(3)]
    public string? ServiceCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
