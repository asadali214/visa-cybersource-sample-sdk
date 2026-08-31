using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BillTo74
{
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
    /// Payment card billing street address as it appears on the credit card issuer’s records.
    /// <para>
    /// #### SEPA
    /// Required for Create Mandate and Import Mandate
    /// </para>
    /// <para>
    /// #### Atos
    /// This field must not contain colons (:).
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// <b>Important</b> When you populate orderInformation.billTo.address1 and orderInformation.billTo.address2,
    /// CyberSource through VisaNet concatenates the two values. If the concatenated value exceeds 40 characters,
    /// CyberSource through VisaNet truncates the value at 40 characters before sending it to Visa and the issuing bank.
    /// Truncating this value affects AVS results and therefore might also affect risk decisions and chargebacks.
    /// Credit card networks cannot process transactions that contain non-ASCII characters. CyberSource through VisaNet
    /// accepts and stores non-ASCII characters correctly and displays them correctly in reports. However, the limitations
    /// of the credit card networks prevent CyberSource through VisaNet from transmitting non-ASCII characters to the
    /// credit card networks. Therefore, CyberSource through VisaNet replaces non-ASCII characters with meaningless
    /// ASCII characters for transmission to the credit card networks.
    /// </para>
    /// <para>
    /// #### FDMS Nashville
    /// When the street name is numeric, it must be sent in numeric format. For example, if the address is _One First Street_,
    /// it must be sent as _1 1st Street_.
    /// </para>
    /// <para>
    /// Required if keyed; not used if swiped.
    /// </para>
    /// <para>
    /// String (20)
    /// </para>
    /// <para>
    /// #### TSYS Acquiring Solutions
    /// Required when <c>processingInformation.billPaymentOptions.billPayment=true</c> and <c>pointOfSaleInformation.entryMode=keyed</c>.
    /// </para>
    /// <para>
    /// #### All other processors:
    /// Optional.
    /// String (60)
    /// </para>
    /// <para>
    /// #### For Payouts
    /// This field may be sent only for FDC Compass.
    /// </para>
    /// <para>
    /// <b>Important</b> It is your responsibility to determine whether a field is required for the transaction you are requesting.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(255)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Customer's email address, including the full domain name.
    /// <para>
    /// #### CyberSource through VisaNet
    /// Credit card networks cannot process transactions that contain non-ASCII characters. CyberSource through VisaNet accepts and stores non-ASCII characters correctly and displays them correctly in reports. However, the limitations of the credit card networks prevent CyberSource through VisaNet from transmitting non-ASCII characters to the credit card networks. Therefore, CyberSource through VisaNet replaces non-ASCII characters with meaningless ASCII characters for transmission to the credit card networks.
    /// </para>
    /// <para>
    /// <b>Important</b> It is your responsibility to determine whether a field is required for the transaction you are requesting.
    /// </para>
    /// <para>
    /// #### Invoicing
    /// Email address for the customer for sending the invoice. If the invoice is in SENT status and email is updated, the old email customer payment link won't work and you must resend the invoice with the new payment link.
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
    [JsonPropertyName("email")]
    [MaxLength(255)]
    public string? Email { get; init; }

    /// <summary>
    /// Payment card billing country. Use the two-character <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes</see>.
    /// <para>
    /// #### SEPA/BACS
    /// Required for Create Mandate and Import Mandate
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// Credit card networks cannot process transactions that contain non-ASCII characters. CyberSource through VisaNet
    /// accepts and stores non-ASCII characters correctly and displays them correctly in reports. However, the limitations
    /// of the credit card networks prevent CyberSource through VisaNet from transmitting non-ASCII characters to the
    /// credit card networks. Therefore, CyberSource through VisaNet replaces non-ASCII characters with meaningless ASCII
    /// characters for transmission to the credit card networks.
    /// </para>
    /// <para>
    /// <b>Important</b> It is your responsibility to determine whether a field is required for the transaction you are requesting.
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
    [JsonPropertyName("country")]
    [MaxLength(3)]
    public string? Country { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
