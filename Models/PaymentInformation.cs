using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentInformation
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card? Card { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenizedCard")]
    public TokenizedCard? TokenizedCard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenizedPaymentMethod")]
    public TokenizedPaymentMethod? TokenizedPaymentMethod { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("directDebit")]
    public DirectDebit? DirectDebit { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fluidData")]
    public FluidData? FluidData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrument")]
    public PaymentInstrument? PaymentInstrument { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instrumentIdentifier")]
    public InstrumentIdentifier? InstrumentIdentifier { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAddress")]
    public ShippingAddress? ShippingAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legacyToken")]
    public LegacyToken? LegacyToken { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank")]
    public Bank? Bank { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public Options? Options { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentType")]
    public PaymentType? PaymentType { get; init; }

    /// <summary>
    /// Mastercard-defined code that indicates how the account information was obtained.
    /// <list type="bullet">
    ///   <item><description><c>00</c>: Card</description></item>
    ///   <item><description><c>01</c>: Mobile Network Operator (MNO) controlled removable secure element (SIM or UICC) personalized for use with a mobile phone or smartphone</description></item>
    ///   <item><description><c>02</c>: Key fob</description></item>
    ///   <item><description><c>03</c>: Watch using a contactless chip or a fixed (non-removable) secure element not controlled by the MNO</description></item>
    ///   <item><description><c>04</c>: Mobile tag</description></item>
    ///   <item><description><c>05</c>: Wristband</description></item>
    ///   <item><description><c>06</c>: Mobile phone case or sleeve</description></item>
    ///   <item><description><c>07</c>: Mobile phone or smartphone with a fixed (non-removable) secure element controlled by the MNO,for example, code division multiple access (CDMA)</description></item>
    ///   <item><description><c>08</c>: Removable secure element not controlled by the MNO, for example, memory card personalized forused with a mobile phone or smartphone</description></item>
    ///   <item><description><c>09</c>: Mobile Phone or smartphone with a fixed (non-removable) secure element not controlled by the MNO</description></item>
    ///   <item><description><c>10</c>: MNO controlled removable secure element (SIM or UICC) personalized for use with a tablet or e-book</description></item>
    ///   <item><description><c>11</c>: Tablet or e-book with a fixed (non-removable) secure element controlled by the MNO</description></item>
    ///   <item><description><c>12</c>: Removable secure element not controlled by the MNO, for example, memory card personalized foruse with a tablet or e-book</description></item>
    ///   <item><description><c>13</c>: Tablet or e-book with fixed (non-removable) secure element not controlled by the MNO</description></item>
    ///   <item><description><c>14</c>: Mobile phone or smartphone with a payment application running in a host processor</description></item>
    ///   <item><description><c>15</c>: Tablet or e-book with a payment application running in a host processor</description></item>
    ///   <item><description><c>16</c>: Mobile phone or smartphone with a payment application running in the Trusted ExecutionEnvironment (TEE) of a host processor</description></item>
    ///   <item><description><c>17</c>: Tablet or e-book with a payment application running in the TEE of a host processor</description></item>
    ///   <item><description><c>18</c>: Watch with a payment application running in the TEE of a host processor</description></item>
    ///   <item><description><c>19</c>: Watch with a payment application running in a host processor</description></item>
    /// </list>
    /// <para>
    /// Values from 20–99 exclusively indicate the form factor only without also indicating the storage technology
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>20</c>: Card</description></item>
    ///   <item><description><c>21</c>: Phone e.g. Mobile Phone</description></item>
    ///   <item><description><c>22</c>: Tablet/e-reader</description></item>
    ///   <item><description><c>23</c>: Watch/Wristband e.g. Watch or wristband, including a fitness band, smart strap, disposable band, watch add-on, and security/ID band</description></item>
    ///   <item><description><c>24</c>: Sticker</description></item>
    ///   <item><description><c>25</c>: PC</description></item>
    ///   <item><description><c>26</c>: Device Peripheral e.g. mobile phone case or sleeve</description></item>
    ///   <item><description><c>27</c>: Tag e.g. key fob or mobile tag</description></item>
    ///   <item><description><c>28</c>: Jewelry e.g. ring, bracelet, necklace and cuff links</description></item>
    ///   <item><description><c>29</c>: Fashion Accessory e.g. handbag, bag charm and glasses</description></item>
    ///   <item><description><c>30</c>: Garment e.g. dress</description></item>
    ///   <item><description><c>31</c>: Domestic Appliance e.g refrigerator, washing machine</description></item>
    ///   <item><description><c>32</c>: Vehicle e.g. vehicle, including vehicle attached devices</description></item>
    ///   <item><description><c>33</c>: Media/Gaming Device e.g. media or gaming device, including a set top box, media player and television</description></item>
    /// </list>
    /// <para>
    /// 34–99 are reserved for future form factors. Any value in this range may occur within form factor and transaction data without prior notice.
    /// </para>
    /// <para>
    /// This field is supported only for Mastercard on CyberSource through VisaNet.
    /// When initiation channel is not provided via this API field, the value is extracted from EMV tag 9F6E for Mastercard transactions. To enable this feature please call support.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initiationChannel")]
    [MaxLength(2)]
    public string? InitiationChannel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepa")]
    public Sepa? Sepa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eWallet")]
    public EWallet? EWallet { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccountReference")]
    public PaymentAccountReference? PaymentAccountReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thirdPartyToken")]
    public ThirdPartyToken? ThirdPartyToken { get; init; }

    /// <summary>
    /// Mastercard One Credential merchant limited acceptance indicator. Mastercard One Credential connects multiple Mastercard payment methods and allows cardhollers to access various options and set payment preferences.
    /// <para>
    /// This field indicates which Mastercard One Credential funding PAN acceptance brands should NOT be assigned for this transaction.
    /// </para>
    /// <para>
    /// This field flows in ISO field 34, DSID 02 tag DB, mapped to Mastercard Data Element (DE) 48, Sub element 02, Subfield 01.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>C</c>: Do not assign a Mastercard One Credential funding PAN containing the Mastercard Credit Acceptance Brand for this transaction
    /// - <c>D</c>: Do not assign a Mastercard One Credential funding PAN containing the Debit Mastercard Acceptance Brand for this transaction
    /// - <c>M</c>: Do not assign a Mastercard One Credential funding PAN containing the Maestro Acceptance Brand for this transaction
    /// </para>
    /// <para>
    /// This field is supported for all flavors of Authorization request only. Will not be received in response.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization Request</b>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantLimitedAcceptanceIndicator")]
    [MaxLength(1)]
    public string? MerchantLimitedAcceptanceIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
