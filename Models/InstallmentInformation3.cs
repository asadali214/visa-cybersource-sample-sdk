using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InstallmentInformation3
{
    /// <summary>
    /// #### American Express Direct, Cielo, and CyberSource Latin American Processing
    /// Flag that indicates the type of funding for the installment plan associated with the payment.
    /// <para>
    /// Possible values:
    /// - <c>1</c>: Merchant-funded installment plan
    /// - <c>2</c>: Issuer-funded installment plan
    /// If you do not include this field in the request, CyberSource uses the value in your CyberSource account.
    /// </para>
    /// <para>
    /// To change the value in your CyberSource account, contact CyberSource Customer Service.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet and American Express
    /// Defined code that indicates the type of installment plan for this transaction.
    /// </para>
    /// <para>
    /// Contact American Express for:
    /// - Information about the kinds of installment plans that American Express provides
    /// - Values for this field
    /// </para>
    /// <para>
    /// For installment payments with American Express in Brazil, the value for this field corresponds to the following data in the TC 33 capture file*:
    /// - Record: CP07 TCR3
    /// - Position: 5-6
    /// - Field: Plan Type
    /// </para>
    /// <list type="bullet">
    ///   <item><description>The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies.</description></item>
    /// </list>
    /// <para>
    /// #### CyberSource through VisaNet with Visa or Mastercard
    /// Flag indicating the type of funding for the installment plan associated with the payment.
    /// Possible values:
    /// - 1 or 01: Merchant-funded installment plan
    /// - 2 or 02: Issuer-funded installment plan
    /// - 43: Crediario installment plan—only with Visa in Brazil
    /// </para>
    /// <para>
    /// For installment payments with Visa in Brazil, the value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP07 TCR1
    /// - Position: 5-6
    /// - Field: Installment Type
    /// </para>
    /// <para>
    /// For all other kinds of installment payments, the value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP01 TCR5
    /// - Position: 39-40
    /// - Field: Installment Plan Type (Issuer or Merchant)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("planType")]
    [MaxLength(1)]
    public string? PlanType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
