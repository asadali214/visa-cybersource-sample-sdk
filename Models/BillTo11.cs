using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BillTo11
{
    /// <summary>
    /// Title.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    [MaxLength(60)]
    public string? Title { get; init; }

    /// <summary>
    /// Customer’s first name. This name must be the same as the name on the card.
    /// <para>
    /// <b>Important</b> It is your responsibility to determine whether a field is required for the transaction you are requesting.
    /// </para>
    /// <para>
    /// #### SEPA
    /// Required for Create Mandate and Import Mandate
    /// #### BACS
    /// Required for Import Mandate
    /// </para>
    /// <para>
    /// #### CyberSource Latin American Processing
    /// <b>Important</b> For an authorization request, CyberSource Latin American Processing concatenates <c>orderInformation.billTo.firstName</c> and <c>orderInformation.billTo.lastName</c>. If the concatenated value exceeds 30 characters, CyberSource Latin American Processing declines the authorization request.\
    /// <b>Note</b> CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called _CyberSource Latin American Processing_. It is not for any other Latin American processors that CyberSource supports.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// Credit card networks cannot process transactions that contain non-ASCII characters. CyberSource through VisaNet accepts and stores non-ASCII characters correctly and displays them correctly in reports. However, the limitations of the credit card networks prevent CyberSource through VisaNet from transmitting non-ASCII characters to the credit card networks. Therefore, CyberSource through VisaNet replaces non-ASCII characters with meaningless ASCII characters for transmission to the credit card networks.
    /// </para>
    /// <para>
    /// #### For Payouts:
    /// This field may be sent only for FDC Compass.
    /// </para>
    /// <para>
    /// #### Chase Paymentech Solutions
    /// Optional field.
    /// </para>
    /// <para>
    /// ####  Credit Mutuel-CIC
    /// Optional field.
    /// </para>
    /// <para>
    /// #### OmniPay Direct
    /// Optional field.
    /// </para>
    /// <para>
    /// #### SIX
    /// Optional field.
    /// </para>
    /// <para>
    /// #### TSYS Acquiring Solutions
    /// Required when <c>processingInformation.billPaymentOptions.billPayment=true</c> and <c>pointOfSaleInformation.entryMode=keyed</c>.
    /// </para>
    /// <para>
    /// #### Worldpay VAP
    /// Optional field.
    /// </para>
    /// <para>
    /// #### All other processors
    /// Not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(60)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Customer’s middle name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    [MaxLength(60)]
    public string? MiddleName { get; init; }

    /// <summary>
    /// Customer’s last name. This name must be the same as the name on the card.
    /// <para>
    /// <b>Important</b> It is your responsibility to determine whether a field is required for the transaction you are requesting.
    /// </para>
    /// <para>
    /// #### SEPA
    /// Required for Create Mandate and Import Mandate
    /// #### BACS
    /// Required for Import Mandate
    /// #### Chase Paymentech Solutions
    /// Optional field.
    /// </para>
    /// <para>
    /// ####  Credit Mutuel-CIC
    /// Optional field.
    /// </para>
    /// <para>
    /// #### CyberSource Latin American Processing
    /// <b>Important</b> For an authorization request, CyberSource Latin American Processing concatenates <c>orderInformation.billTo.firstName</c> and <c>orderInformation.billTo.lastName</c>. If the concatenated value exceeds 30 characters, CyberSource Latin American Processing declines the authorization request.\
    /// <b>Note</b> CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// Credit card networks cannot process transactions that contain non-ASCII characters. CyberSource through VisaNet accepts and stores non-ASCII characters correctly and displays them correctly in reports. However, the limitations of the credit card networks prevent CyberSource through VisaNet from transmitting non-ASCII characters to the credit card networks. Therefore, CyberSource through VisaNet replaces non-ASCII characters with meaningless ASCII characters for transmission to the credit card networks.
    /// </para>
    /// <para>
    /// #### For Payouts:
    /// This field may be sent only for FDC Compass.
    /// </para>
    /// <para>
    /// #### OmniPay Direct
    /// Optional field.
    /// </para>
    /// <para>
    /// #### RBS WorldPay Atlanta
    /// Optional field.
    /// </para>
    /// <para>
    /// #### SIX
    /// Optional field.
    /// </para>
    /// <para>
    /// #### TSYS Acquiring Solutions
    /// Required when <c>processingInformation.billPaymentOptions.billPayment=true</c> and <c>pointOfSaleInformation.entryMode=keyed</c>.
    /// </para>
    /// <para>
    /// #### Worldpay VAP
    /// Optional field.
    /// </para>
    /// <para>
    /// #### All other processors
    /// Not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(60)]
    public string? LastName { get; init; }

    /// <summary>
    /// Customer’s name suffix.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nameSuffix")]
    [MaxLength(60)]
    public string? NameSuffix { get; init; }

    /// <summary>
    /// First line of the billing street address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(60)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Second line of the billing street address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(60)]
    public string? Address2 { get; init; }

    /// <summary>
    /// City of the billing address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(50)]
    public string? Locality { get; init; }

    /// <summary>
    /// Postal code for the billing address. The postal code must consist of 5 to 9 digits.
    /// When the billing country is the U.S., the 9-digit postal code must follow this format:
    /// [5 digits][dash][4 digits]
    /// Example: 12345-6789
    /// When the billing country is Canada, the 6-digit postal code must follow this format:
    /// [alpha][numeric][alpha][space][numeric][alpha][numeric]
    /// Example: A1B 2C3
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// State or province of the billing address. Use the State, Province, and Territory Codes for the United States and Canada.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(2)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Country of the billing address. Use the two-character ISO Standard Country Codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(20)]
    public string? Country { get; init; }

    /// <summary>
    /// Customer's email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(256)]
    public string? Email { get; init; }

    /// <summary>
    /// Customer’s phone number.
    /// <para>
    /// It is recommended that you include the country code when the order is from outside the U.S.
    /// </para>
    /// <para>
    /// #### Chase Paymentech Solutions
    /// Optional field.
    /// </para>
    /// <para>
    /// ####  Credit Mutuel-CIC
    /// Optional field.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// Credit card networks cannot process transactions that contain non-ASCII characters. CyberSource through VisaNet accepts and stores non-ASCII characters correctly and displays them correctly in reports. However, the limitations of the credit card networks prevent CyberSource through VisaNet from transmitting non-ASCII characters to the credit card networks. Therefore, CyberSource through VisaNet replaces non-ASCII characters with meaningless ASCII characters for transmission to the credit card networks.
    /// </para>
    /// <para>
    /// #### For Payouts:
    /// This field may be sent only for FDC Compass.
    /// </para>
    /// <para>
    /// #### OmniPay Direct
    /// Optional field.
    /// </para>
    /// <para>
    /// #### SIX
    /// Optional field.
    /// </para>
    /// <para>
    /// #### TSYS Acquiring Solutions
    /// Optional field.
    /// </para>
    /// <para>
    /// #### Worldpay VAP
    /// Optional field.
    /// </para>
    /// <para>
    /// #### All other processors
    /// Not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(15)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// Whether buyer has verified their identity. Used in case of PayPal transactions.
    /// <para>
    /// Possible Values:
    /// * VERIFIED
    /// * UNVERIFIED
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationStatus")]
    public string? VerificationStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
