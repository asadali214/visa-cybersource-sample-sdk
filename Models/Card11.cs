using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Card11
{
    /// <summary>
    /// The customer’s payment card number, also known as the Primary Account Number (PAN). You can also use this field
    /// for encoded account numbers.
    /// <para>
    /// #### FDMS Nashville
    /// Required. String (19)
    /// </para>
    /// <para>
    /// #### GPX
    /// Required if <c>pointOfSaleInformation.entryMode=keyed</c>. However, this field is optional if your account is configured
    /// for relaxed requirements for address data and expiration date. <b>Important</b> It is your responsibility to determine
    /// whether a field is required for the transaction you are requesting.
    /// </para>
    /// <para>
    /// #### All other processors
    /// Required if <c>pointOfSaleInformation.entryMode=keyed</c>. However, this field is optional if your account is configured
    /// for relaxed requirements for address data and expiration date. <b>Important</b> It is your responsibility to determine
    /// whether a field is required for the transaction you are requesting.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [MaxLength(20)]
    public string? Number { get; init; }

    /// <summary>
    /// Two-digit month in which the payment card expires.
    /// <para>
    /// Format: <c>MM</c>.
    /// </para>
    /// <para>
    /// Valid values: <c>01</c> through <c>12</c>. Leading 0 is required.
    /// </para>
    /// <para>
    /// #### Barclays and Streamline
    /// For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value
    /// (<c>01</c> through <c>12</c>) but is not required to be a valid expiration date. In other words, an expiration date that is
    /// in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause
    /// the issuer to reject your request.
    /// </para>
    /// <para>
    /// #### Encoded Account Numbers
    /// For encoded account numbers (_type_=039), if there is no expiration date on the card, use <c>12</c>.
    /// </para>
    /// <para>
    /// #### FDMS Nashville
    /// Required field.
    /// </para>
    /// <para>
    /// #### All other processors
    /// Required if <c>pointOfSaleInformation.entryMode=keyed</c>. However, this field is optional if your account is configured
    /// for relaxed requirements for address data and expiration date. <b>Important</b> It is your responsibility to determine
    /// whether a field is required for the transaction you are requesting.
    /// </para>
    /// <para>
    /// #### Google Pay transactions
    /// For PAN-based Google Pay transactions, this field is returned in the API response.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationMonth")]
    [MaxLength(2)]
    public string? ExpirationMonth { get; init; }

    /// <summary>
    /// Four-digit year in which the payment card expires.
    /// <para>
    /// Format: <c>YYYY</c>.
    /// </para>
    /// <para>
    /// #### Barclays and Streamline
    /// For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (<c>1900</c> through <c>3000</c>) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.
    /// </para>
    /// <para>
    /// #### Encoded Account Numbers
    /// For encoded account numbers (<b>_type_</b><c>=039</c>), if there is no expiration date on the card, use <c>2021</c>.
    /// </para>
    /// <para>
    /// #### FDMS Nashville
    /// Required field.
    /// </para>
    /// <para>
    /// #### FDC Nashville Global and FDMS South
    /// You can send in 2 digits or 4 digits. If you send in 2 digits, they must be the last 2 digits of the year.
    /// </para>
    /// <para>
    /// #### All other processors
    /// Required if <c>pointOfSaleInformation.entryMode=keyed</c>. However, this field is optional if your account is configured
    /// for relaxed requirements for address data and expiration date. <b>Important</b> It is your responsibility to determine
    /// whether a field is required for the transaction you are requesting.
    /// </para>
    /// <para>
    /// #### Google Pay transactions
    /// For PAN-based Google Pay transactions, this field is returned in the API response.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationYear")]
    [MaxLength(4)]
    public string? ExpirationYear { get; init; }

    /// <summary>
    /// Three-digit value that indicates the card type.
    /// <para>
    /// <b>IMPORTANT</b> It is strongly recommended that you include the card type field in request messages even if it is
    /// optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>001</c>: Visa. Use card type value <c>001</c> for Visa Electron.
    /// - <c>002</c>: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard.
    /// - <c>003</c>: American Express
    /// - <c>004</c>: Discover
    /// - <c>005</c>: Diners Club
    /// - <c>006</c>: Carte Blanche[^1]
    /// - <c>007</c>: JCB[^1]
    /// - <c>008</c>: Optima
    /// - <c>009</c>: GE Private Label
    /// - <c>010</c>: Beneficial Private Label
    /// - <c>011</c>: Twinpay Credit Card
    /// - <c>012</c>: Twinpay Debit Card
    /// - <c>013</c>: WalMart
    /// - <c>014</c>: Enroute[^1]
    /// - <c>015</c>: Lowe's Consumer
    /// - <c>016</c>: Home Depot Consumer
    /// - <c>017</c>: MBNA
    /// - <c>018</c>: Dick's Sportswear
    /// - <c>019</c>: Casual Corner
    /// - <c>020</c>: Sears
    /// - <c>021</c>: JAL[^1]
    /// - <c>023</c>: Disney Card
    /// - <c>024</c>: Maestro (UK Domestic)[^1]
    /// - <c>025</c>: Sam's Club Consumer
    /// - <c>026</c>: Sam's Club Business
    /// - <c>027</c>: Nico's
    /// - <c>028</c>: Paymentech Bill Me Later
    /// - <c>029</c>: Bebe
    /// - <c>030</c>: Restoration Hardware
    /// - <c>031</c>: Delta Online
    /// - <c>032</c>: Solo
    /// - <c>033</c>: Visa Electron[^1]. Do not use this value. Use <c>001</c> for all Visa card types.
    /// - <c>034</c>: Dankort[^1]
    /// - <c>035</c>: Laser
    /// - <c>036</c>: Cartes Bancaires[^1,4]
    /// - <c>037</c>: Carta Si[^1]
    /// - <c>038</c>: Pinless Debit
    /// - <c>039</c>: Encoded account number[^1]
    /// - <c>040</c>: UATP[^1]
    /// - <c>041</c>: HOUSEHOLD
    /// - <c>042</c>: Maestro (International)[^1]
    /// - <c>043</c>: GE MONEY
    /// - <c>044</c>: Korean Cards
    /// - <c>045</c>: Style Cards
    /// - <c>046</c>: JCrew
    /// - <c>047</c>: Payeasecn eWallet
    /// - <c>048</c>: Payeasecn Bank Transfer
    /// - <c>049</c>: Meijer
    /// - <c>050</c>: Hipercard[^2,3]
    /// - <c>051</c>: Aura
    /// - <c>052</c>: Redecard
    /// - <c>053</c>: Orico card
    /// - <c>054</c>: Elo[^3]
    /// - <c>055</c>: Capitol One Private Label
    /// - <c>056</c>: Carnet
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
    /// - <c>067</c>: MEEZA
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
    /// </para>
    /// <para>
    /// [^1]: For this card type, you must include the <c>paymentInformation.card.type</c> or <c>paymentInformation.tokenizedCard.type</c> field in your request for an authorization or a stand-alone credit.
    /// [^2]: For this card type on Cielo 3.0, you must include the <c>paymentInformation.card.type</c> or <c>paymentInformation.tokenizedCard.type</c> field in a request for an authorization or a stand-alone credit. This card type is not supported on Cielo 1.5.
    /// [^3]: For this card type on Getnet and Rede, you must include the <c>paymentInformation.card.type</c> or <c>paymentInformation.tokenizedCard.type</c> field in a request for an authorization or a stand-alone credit.
    /// [^4]: For this card type, you must include the <c>paymentInformation.card.type</c> in your request for any payer authentication services.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required for Carte Blanche and JCB.
    /// Optional for all other card types.
    /// </para>
    /// <para>
    /// #### Card Present reply
    /// This field is included in the reply message when the client software that is installed on the POS terminal uses
    /// the token management service (TMS) to retrieve tokenized payment details. You must contact customer support to
    /// have your account enabled to receive these fields in the credit reply message.
    /// </para>
    /// <para>
    /// Returned by the Credit service.
    /// </para>
    /// <para>
    /// This reply field is only supported by the following processors:
    /// - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - OmniPay Direct
    /// - SIX
    /// </para>
    /// <para>
    /// #### Google Pay transactions
    /// For PAN-based Google Pay transactions, this field is returned in the API response.
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
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Card Verification Number.
    /// <para>
    /// #### FDMS Nashville
    /// Required for American Express or if swiped; otherwise, optional.
    /// </para>
    /// <para>
    /// #### Ingenico ePayments
    /// Do not include this field when <c>commerceIndicator=recurring</c>.
    /// <b>Note</b> Ingenico ePayments was previously called _Global Collect_.
    /// </para>
    /// <para>
    /// #### TSYS Acquiring Solutions
    /// Optional if pointOfSaleInformation.entryMode=keyed; otherwise, not used.
    /// </para>
    /// <para>
    /// #### GPX
    /// Optional.
    /// </para>
    /// <para>
    /// #### All other processors:
    /// Optional.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("securityCode")]
    [MaxLength(4)]
    public string? SecurityCode { get; init; }

    /// <summary>
    /// Flag that specifies the type of account associated with the card.  This field is available only for China UnionPay, Cielo, Comercio Latino and Visa Platform Connect.
    /// The cardholder provides this information during the payment process.  This field is required for:
    ///  - Debit transactions on Cielo and Comercio Latino.
    ///  - Transactions with Brazilian-issued cards on CyberSource through VisaNet.
    /// <para>
    /// <b>China UnionPayCard Transactions on China UnionPay:</b>
    /// Possible values:
    ///  - C: Domestic credit card
    ///  - D: Domestic debit card
    ///  - F: International credit card
    ///  - I: International debit card
    /// </para>
    /// <para>
    /// When the value is D, the e-commerce indicator and CAVV fields must be included in the authorization request.
    /// When the value is C, F or I the card verification number, expiration month and expiration year fields must in included in the authorization request.
    /// </para>
    /// <para>
    /// <b>Cielo and Comercio Latino Credit Card Transactions:</b>
    /// On these processors, this field is supported only for authorizations.  Possible values:
    ///  - CR: Credit card
    ///  - DB: Debit card
    /// </para>
    /// <para>
    /// <b>Visa Platform Connect Credit Card Transactions:</b>
    /// This field is supported for all card types on Visa Platform Connect.
    /// For combo <b>card present</b> transactions with Mastercard on Brazilian-issued cards, possible values:
    ///  - CR: Credit card
    ///  - DB: Debit Card
    /// </para>
    /// <para>
    /// For combo <b>card not present</b> transactions with Mastercard on Brazilian-issued cards, possible values:
    ///  - C: Credit card
    ///  - D: Debit card
    /// </para>
    /// <para>
    /// A value of CR or DB in the useAs field takes precedence over any value in the Source Account Type field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useAs")]
    [MaxLength(20)]
    public string? UseAs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
