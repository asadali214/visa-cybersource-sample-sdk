using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Card3
{
    /// <summary>
    /// Flag that specifies the type of account associated with the card.
    /// The cardholder provides this information during the payment process.
    /// <para>
    /// This field is required in the following cases:
    ///   - Debit transactions on Cielo and Comercio Latino.
    ///   - Transactions with Brazilian-issued cards on CyberSource through VisaNet.
    ///   - Applicable only for CyberSource through VisaNet (CtV).
    /// </para>
    /// <para>
    /// <b>Note</b> Combo cards in Brazil contain credit and debit functionality in a single card. Visa systems use a credit bank
    /// identification number (BIN) for this type of card. Using the BIN to determine whether a card is debit or
    /// credit can cause transactions with these cards to be processed incorrectly. CyberSource strongly recommends
    /// that you include this field for combo card transactions.
    /// </para>
    /// <para>
    /// Possible values include the following.
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>CH</c>: Checking account</description></item>
    ///   <item><description><c>CR</c>: Credit card account</description></item>
    ///   <item><description><c>SA</c>: Saving account</description></item>
    ///   <item><description><c>LI</c>: Line of credit or credit portion of combo card</description></item>
    ///   <item><description><c>PP</c>: Prepaid card account or prepaid portion of combo card</description></item>
    ///   <item><description><c>UA</c>: Universal account</description></item>
    /// </list>
    /// <para>
    /// If useAs is set to credit/debit and there is a value in SourceAccountType, the value in the SourceAccountType field will take precedence.
    /// If useAs is set to CR/DB and there is a value in SourceAccountType, the value in the useAs field will take precedence.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceAccountType")]
    [MaxLength(20)]
    public string? SourceAccountType { get; init; }

    /// <summary>
    /// Type of account that is being used when the value for the override_payment_method field is line of credit (LI) or prepaid card (PP).
    /// Possible values for line of credit:
    /// - <c>AGRC</c>: Visa Agro Custeio
    /// - <c>AGRE</c>: Visa Agro Electron
    /// - <c>AGRI</c>: Visa Agro Investimento
    /// - <c>AGRO</c>: Visa Agro
    /// Possible values for prepaid card:
    /// - <c>VVA</c>: Visa Vale Alimentacao
    /// - <c>VVF</c>: Visa Vale Flex
    /// - <c>VVR</c>: Visa Vale Refeicao
    /// This field is supported only for combo card transactions in Brazil on CyberSource through VisaNet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceAccountTypeDetails")]
    [MaxLength(4)]
    public string? SourceAccountTypeDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
