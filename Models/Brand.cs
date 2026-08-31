using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Brand
{
    /// <summary>
    /// This field contains a 3-digit numeric value that indicates the card type within Cybersource eco-system.
    /// Possible values from BIN Lookup Service (based on availability and enablement):
    /// - <c>000</c>: Unsupported Card Type
    /// - <c>001</c>: Visa
    /// - <c>002</c>: Mastercard
    /// - <c>003</c>: American Express
    /// - <c>004</c>: Discover
    /// - <c>005</c>: Diners Club
    /// - <c>007</c>: JCB
    /// - <c>036</c>: Cartes Bancaire
    /// - <c>042</c>: Maestro
    /// - <c>054</c>: Elo
    /// - <c>058</c>: Carnet
    /// - <c>060</c>: MADA
    /// - <c>061</c>: RuPay
    /// - <c>062</c>: China UnionPay
    /// - <c>064</c>: Prompt Card
    /// - <c>067</c>: Meeza
    /// - <c>068</c>: PayPak
    /// - <c>070</c>: EFTPOS
    /// - <c>081</c>: Jaywan
    /// - <c>082</c>: TPN
    /// <para>
    /// Glossary of possible values in the payments ecosystem:
    /// - <c>001</c>: Visa
    /// - <c>002</c>: Mastercard
    /// - <c>003</c>: American Express
    /// - <c>004</c>: Discover
    /// - <c>005</c>: Diners Club
    /// - <c>006</c>: Carte Blanche
    /// - <c>007</c>: JCB
    /// - <c>008</c>: Optima
    /// - <c>009</c>: GE Private Label
    /// - <c>010</c>: Beneficial Private Label
    /// - <c>011</c>: Twinpay Credit Card
    /// - <c>012</c>: Twinpay Debit Card
    /// - <c>013</c>: Walmart
    /// - <c>014</c>: EnRoute
    /// - <c>015</c>: Lowe's Consumer
    /// - <c>016</c>: Home Depot Consumer
    /// - <c>017</c>: MBNA
    /// - <c>018</c>: Dick's Sportwear
    /// - <c>019</c>: Casual Corner
    /// - <c>020</c>: Sears
    /// - <c>021</c>: JAL
    /// - <c>023</c>: Disney Card
    /// - <c>024</c>: Switch/Solo
    /// - <c>025</c>: Sam's Club Consumer
    /// - <c>026</c>: Sam's Club Business
    /// - <c>027</c>: Nico's
    /// - <c>028</c>: Paymentech Bill Me Later
    /// - <c>029</c>: Bebe
    /// - <c>030</c>: Restoration Hardware
    /// - <c>031</c>: Delta Online
    /// - <c>032</c>: Solo
    /// - <c>033</c>: Visa Electron
    /// - <c>034</c>: Dankort
    /// - <c>035</c>: Laser
    /// - <c>036</c>: Cartes Bancaire
    /// - <c>037</c>: Carta Si
    /// - <c>040</c>: UATP
    /// - <c>041</c>: HOUSEHOLD
    /// - <c>042</c>: Maestro
    /// - <c>043</c>: GE MONEY
    /// - <c>044</c>: Korean Cards
    /// - <c>045</c>: Style Cards
    /// - <c>046</c>: J.Crew
    /// - <c>047</c>: Payeasecn eWallet
    /// - <c>048</c>: Payeasecn Bank Transfer
    /// - <c>049</c>: Meijer
    /// - <c>050</c>: Hipercard
    /// - <c>051</c>: Aura
    /// - <c>052</c>: Redecard
    /// - <c>053</c>: Orico Card
    /// - <c>054</c>: Elo
    /// - <c>055</c>: Capital One Private Label
    /// - <c>057</c>: Costco Private Label
    /// - <c>058</c>: Carnet
    /// - <c>059</c>: ValueLink
    /// - <c>060</c>: MADA
    /// - <c>061</c>: RuPay
    /// - <c>062</c>: China UnionPay
    /// - <c>063</c>: Falabella Private Label
    /// - <c>064</c>: Prompt Card
    /// - <c>065</c>: Korean Domestic
    /// - <c>066</c>: Banricompras
    /// - <c>067</c>: Meeza
    /// - <c>068</c>: PayPak
    /// - <c>070</c>: EFTPOS
    /// - <c>071</c>: Codensa
    /// - <c>072</c>: Olimpica
    /// - <c>073</c>: Colsubsidio
    /// - <c>074</c>: Tuya
    /// - <c>075</c>: Sodexo
    /// - <c>076</c>: Naranja
    /// - <c>077</c>: Cabal
    /// - <c>078</c>: DINELCO
    /// - <c>079</c>: PANAL
    /// - <c>080</c>: EPM
    /// - <c>081</c>: Jaywan
    /// - <c>082</c>: TPN
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(3)]
    public string? Type { get; init; }

    /// <summary>
    /// This field contains the card brand name.
    /// <para>
    /// Some of the possible values (not an exhaustive list) are -
    /// </para>
    /// <list type="bullet">
    ///   <item><description>VISA</description></item>
    ///   <item><description>MASTERCARD</description></item>
    ///   <item><description>AMERICAN EXPRESS</description></item>
    ///   <item><description>DISCOVER</description></item>
    ///   <item><description>DINERS CLUB</description></item>
    ///   <item><description>CARTE BLANCHE</description></item>
    ///   <item><description>JCB</description></item>
    ///   <item><description>OPTIMA</description></item>
    ///   <item><description>TWINPAY CREDIT CARD</description></item>
    ///   <item><description>TWINPAY DEBIT CARD</description></item>
    ///   <item><description>WALMART</description></item>
    ///   <item><description>ENROUTE</description></item>
    ///   <item><description>LOWES CONSUMER</description></item>
    ///   <item><description>HOME DEPOT CONSUMER</description></item>
    ///   <item><description>MBNA</description></item>
    ///   <item><description>DICKS SPORTWEAR</description></item>
    ///   <item><description>CASUAL CORNER</description></item>
    ///   <item><description>SEARS</description></item>
    ///   <item><description>JAL</description></item>
    ///   <item><description>DISNEY CARD</description></item>
    ///   <item><description>SWITCH/SOLO</description></item>
    ///   <item><description>SAMS CLUB CONSUMER</description></item>
    ///   <item><description>SAMS CLUB BUSINESS</description></item>
    ///   <item><description>NICOS HOUSE CARD</description></item>
    ///   <item><description>BEBE</description></item>
    ///   <item><description>RESTORATION HARDWARE</description></item>
    ///   <item><description>DELTA ONLINE</description></item>
    ///   <item><description>SOLO</description></item>
    ///   <item><description>VISA ELECTRON</description></item>
    ///   <item><description>DANKORT</description></item>
    ///   <item><description>LASER</description></item>
    ///   <item><description>CARTE BANCAIRE</description></item>
    ///   <item><description>CARTA SI</description></item>
    ///   <item><description>ENCODED ACCOUNT</description></item>
    ///   <item><description>UATP</description></item>
    ///   <item><description>HOUSEHOLD</description></item>
    ///   <item><description>MAESTRO</description></item>
    ///   <item><description>GE CAPITAL</description></item>
    ///   <item><description>KOREAN CARDS</description></item>
    ///   <item><description>STYLE CARDS</description></item>
    ///   <item><description>JCREW</description></item>
    ///   <item><description>MEIJER</description></item>
    ///   <item><description>HIPERCARD</description></item>
    ///   <item><description>AURA</description></item>
    ///   <item><description>REDECARD</description></item>
    ///   <item><description>ORICO HOUSE CARD</description></item>
    ///   <item><description>MADA</description></item>
    ///   <item><description>ELO</description></item>
    ///   <item><description>CAPITAL ONE PRIVATE LABEL</description></item>
    ///   <item><description>CARNET</description></item>
    ///   <item><description>RUPAY</description></item>
    ///   <item><description>CHINA UNION PAY</description></item>
    ///   <item><description>FALABELLA PRIVATE LABEL</description></item>
    ///   <item><description>PROMPTCARD</description></item>
    ///   <item><description>KOREAN DOMESTIC</description></item>
    ///   <item><description>BANRICOMPRAS</description></item>
    ///   <item><description>MEEZA</description></item>
    ///   <item><description>PAYPAK</description></item>
    ///   <item><description>JAYWAN</description></item>
    ///   <item><description>TPN</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brandName")]
    [MaxLength(20)]
    public string? BrandName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
