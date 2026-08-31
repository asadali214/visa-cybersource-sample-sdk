using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record MerchantInformation4
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDescriptor")]
    public MerchantDescriptor? MerchantDescriptor { get; init; }

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
    /// Your government-assigned tax identification number.
    /// <para>
    /// #### Tax Calculation
    /// Required field for value added tax only. Not applicable to U.S. and Canadian taxes.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// For CtV processors, the maximum length is 20.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vatRegistrationNumber")]
    [MaxLength(21)]
    public string? VatRegistrationNumber { get; init; }

    /// <summary>
    /// Reference number that facilitates card acceptor/corporation communication and record keeping.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardAcceptorReferenceNumber")]
    [MaxLength(25)]
    public string? CardAcceptorReferenceNumber { get; init; }

    /// <summary>
    /// Your Cadastro Nacional da Pessoa Jurídica (CNPJ) number.
    /// <para>
    /// This field is supported only for BNDES transactions on CyberSource through VisaNet.
    /// </para>
    /// <para>
    /// The value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP07 TCR6
    /// - Position: 40-59
    /// - Field: BNDES Reference Field 1
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxId")]
    [MaxLength(15)]
    public string? TaxId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
