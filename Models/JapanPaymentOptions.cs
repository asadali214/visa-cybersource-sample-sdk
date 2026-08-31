using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record JapanPaymentOptions
{
    /// <summary>
    /// This value is a 2-digit code indicating the payment method.
    /// Use Payment Method Code value that applies to the tranasction.
    /// - 10 (One-time payment)
    /// - 21, 22, 23, 24  (Bonus(one-time)payment)
    /// - 61 (Installment payment)
    /// - 31, 32, 33, 34  (Integrated (Bonus + Installment)payment)
    /// - 80 (Revolving payment)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    [MaxLength(2)]
    public string? PaymentMethod { get; init; }

    /// <summary>
    /// An array of objects, each of which contains a bonus month and bonus amount.
    /// Length of bonuses array is equal to the number of bonuses.  Max length = 6.
    /// In case of bonus month and amount not specified, null objects to be returned in the array.
    /// Example: bonuses : [ {"month": "1","amount": "200"}, {"month": "3","amount": "2500"}, null]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bonuses")]
    public IReadOnlyList<Bonuse>? Bonuses { get; init; }

    /// <summary>
    /// This will contain the details of the kind of transaction that has been processe. Used only for Japan.
    /// Possible Values:
    /// - 0 = Normal (authorization with amount and clearing/settlement; data capture or paper draft)
    /// - 1 = Negative card authorization (authorization-only with 0 or 1 amount)
    /// - 2 = Reservation of authorization (authorization-only with amount)
    /// - 3 = Cancel transaction
    /// - 4 = Merchant-initiated reversal/refund transactions
    /// - 5 = Cancel reservation of authorization
    /// - 6 = Post authorization
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preapprovalType")]
    [MaxLength(1)]
    public string? PreapprovalType { get; init; }

    /// <summary>
    /// Number of Installments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installments")]
    public string? Installments { get; init; }

    /// <summary>
    /// Unique Japan Credit Card Association (JCCA) terminal identifier.
    /// <para>
    /// The difference between this field and the <c>pointOfSaleInformation.terminalID</c> field is that you can define
    /// <c>pointOfSaleInformation.terminalID</c>, but <c>processingInformation.japanPaymentOptions.terminalId</c> is
    /// defined by the JCCA and is used only in Japan.
    /// </para>
    /// <para>
    /// This field is supported only on CyberSource through VisaNet and JCN Gateway.
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalId")]
    [MaxLength(13)]
    public string? TerminalId { get; init; }

    /// <summary>
    /// Billing month in MM format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstBillingMonth")]
    [MaxLength(2)]
    public string? FirstBillingMonth { get; init; }

    /// <summary>
    /// Business name in Japanese characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessName")]
    [MaxLength(25)]
    public string? BusinessName { get; init; }

    /// <summary>
    /// Business name in Katakana characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessNameKatakana")]
    [MaxLength(25)]
    public string? BusinessNameKatakana { get; init; }

    /// <summary>
    /// Japanese Industrial Standard Type 2 (JIS2) track data from the front of the card.
    /// <para>
    /// This field is supported only on CyberSource through VisaNet and JCN Gateway.
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jis2TrackData")]
    [MaxLength(69)]
    public string? Jis2TrackData { get; init; }

    /// <summary>
    /// Business name in alphanumeric characters. This field is supported only on JCN Gateway and for the Sumitomo Mitsui Card Co. acquirer on CyberSource through VisaNet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessNameAlphaNumeric")]
    [MaxLength(25)]
    public string? BusinessNameAlphaNumeric { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
