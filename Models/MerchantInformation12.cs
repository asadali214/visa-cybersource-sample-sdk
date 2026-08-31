using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record MerchantInformation12
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDescriptor")]
    public MerchantDescriptor6? MerchantDescriptor { get; init; }

    /// <summary>
    /// The value for this field is a four-digit number that the payment card industry uses to classify
    /// merchants into market segments. A payment card company assigned one or more of these values to your business when you started
    /// accepting the payment card company’s cards. When you do not include this field in your request, CyberSource uses the value in your
    /// CyberSource account.
    /// <para>
    /// #### CyberSource through VisaNet
    /// The value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP01 TCR4
    /// - Position: 150-153
    /// - Field: Merchant Category Code
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryCode")]
    [Maximum(9999)]
    public int? CategoryCode { get; init; }

    /// <summary>
    /// The state where the merchant is located.
    /// <para>
    /// #### PIN debit
    /// State code or region code for your business. Use the Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf">State, Province, and Territory Codes for the United States and Canada</see> This value might be displayed on the cardholder’s statement.
    /// </para>
    /// <para>
    /// When you do not include this value in your PIN debit request, the merchant name from your account is used.
    /// <b>Important</b> This value must consist of English characters.
    /// </para>
    /// <para>
    /// <b>Note</b> This field is supported only for businesses located in the U.S. or Canada.
    /// </para>
    /// <para>
    /// Optional field for PIN debit credit or PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Date and time at your physical location.
    /// <para>
    /// Format: <c>YYYYMMDDhhmmss</c>, where:
    ///  - <c>YYYY</c> = year
    ///  - <c>MM</c> = month
    ///  - <c>DD</c> = day
    ///  - <c>hh</c> = hour
    ///  - <c>mm</c> = minutes
    ///  - <c>ss</c> = seconds
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required for these processors:
    /// - American Express Direct                                                                                                                                                                                                                                                                                                                         - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - SIX
    /// </para>
    /// <para>
    /// Optional for all other processors.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionLocalDateTime")]
    [MaxLength(14)]
    public string? TransactionLocalDateTime { get; init; }

    /// <summary>
    /// URL to which the customer is directed if they fail to sign the mandate.
    /// #### SEPA
    /// Required for Create Mandate and Update Mandate
    /// #### BACS
    /// Required for Create Mandate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancelUrl")]
    [MaxLength(255)]
    public string? CancelUrl { get; init; }

    /// <summary>
    /// URL to which the customer is directed if they fail to sign the mandate.
    /// #### SEPA
    /// Required for Create Mandate and Update Mandate
    /// #### BACS
    /// Required for Create Mandate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("successUrl")]
    [MaxLength(255)]
    public string? SuccessUrl { get; init; }

    /// <summary>
    /// URL to which the customer is directed if they fail to sign the mandate.
    /// #### SEPA
    /// Required for Create Mandate and Update Mandate
    /// #### BACS
    /// Required for Create Mandate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failureUrl")]
    [MaxLength(255)]
    public string? FailureUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
