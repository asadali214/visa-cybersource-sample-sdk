using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record MerchantInformation
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDescriptor")]
    public MerchantDescriptor? MerchantDescriptor { get; init; }

    /// <summary>
    /// This field will contain either the merchant url or the reverse domain as per the requirement for DSRP Format 3. This might vary transaction to transaction and might not be static. Merchant needs to have access to send this value for all DSRP program.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domainName")]
    [MaxLength(127)]
    public string? DomainName { get; init; }

    /// <summary>
    /// Company ID assigned to an independent sales organization. Get this value from Mastercard.
    /// <para>
    /// #### CyberSource through VisaNet
    /// The value for this field corresponds to the following data in the TC 33 capture file:
    /// - Record: CP01 TCR6
    /// - Position: 106-116
    /// - Field: Independent Sales Organization ID
    /// </para>
    /// <para>
    /// This field is supported for Visa, Mastercard and Discover Transactions.
    /// </para>
    /// <para>
    /// <b>Note</b> The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("salesOrganizationId")]
    [MaxLength(11)]
    public string? SalesOrganizationId { get; init; }

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
    /// Merchant category code for domestic transactions. The value for this field is a four-digit number that the payment
    /// card industry uses to classify merchants into market segments. A payment card company assigned one or more of these
    /// values to your business when you started accepting the payment card company’s cards. Including this field in a request
    /// for a domestic transaction might reduce interchange fees.
    /// <para>
    /// When you include this field in a request:
    /// - Do not include the <c>merchant_category_code</c> field.
    /// - The value for this field overrides the value in your CyberSource account.
    /// </para>
    /// <para>
    /// This field is supported only for:
    /// - Domestic transactions with Mastercard in Spain. Domestic means that you and the cardholder are in the same country.
    /// - Merchants enrolled in the OmniPay Direct interchange program.
    /// - First Data Merchant Solutions (Europe) on OmniPay Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryCodeDomestic")]
    [Maximum(9999)]
    public int? CategoryCodeDomestic { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceFeeDescriptor")]
    public ServiceFeeDescriptor? ServiceFeeDescriptor { get; init; }

    /// <summary>
    /// customer would be redirected to this url based on the decision of the transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancelUrl")]
    [MaxLength(255)]
    public string? CancelUrl { get; init; }

    /// <summary>
    /// customer would be redirected to this url based on the decision of the transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("successUrl")]
    [MaxLength(2048)]
    public string? SuccessUrl { get; init; }

    /// <summary>
    /// customer would be redirected to this url based on the decision of the transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failureUrl")]
    [MaxLength(255)]
    public string? FailureUrl { get; init; }

    /// <summary>
    /// URL for displaying payment results to the consumer (notifications) after the transaction is processed. Usually this URL belongs to merchant and its behavior is defined by merchant
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnUrl")]
    [StringLength(255, MinimumLength = 7)]
    public string? ReturnUrl { get; init; }

    /// <summary>
    /// #### Visa Platform Connect
    /// This field may be used for transactions on accounts issued under co-branding agreements when one of the
    /// co-branding partners.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partnerIdCode")]
    [MaxLength(10)]
    public string? PartnerIdCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceLocation")]
    public ServiceLocation? ServiceLocation { get; init; }

    /// <summary>
    /// Free-form text field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noteToBuyer")]
    [MaxLength(165)]
    public string? NoteToBuyer { get; init; }

    /// <summary>
    /// Use this field only if you are requesting payment with Payer Authentication serice together.
    /// <para>
    /// Your company’s name as you want it to appear to the customer in the issuing bank’s authentication form.
    /// This value overrides the value specified by your merchant bank.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantName")]
    [MaxLength(25)]
    public string? MerchantName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
