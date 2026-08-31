using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BillTo73
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
    /// Customer’s middle name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    [MaxLength(60)]
    public string? MiddleName { get; init; }

    /// <summary>
    /// Customer’s name suffix.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nameSuffix")]
    [MaxLength(60)]
    public string? NameSuffix { get; init; }

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
    /// Used for additional address information. For example: _Attention: Accounts Payable_
    /// Optional field.
    /// <para>
    /// For Payouts: This field may be sent only for FDC Compass.
    /// </para>
    /// <para>
    /// #### Atos
    /// This field must not contain colons (:).
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// <b>Important</b> When you populate <c>orderInformation.billTo.address1</c> and <c>orderInformation.billTo.address2</c>,
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
    /// #### Chase Paymentech Solutions, FDC Compass, and TSYS Acquiring Solutions
    /// This value is used for AVS.
    /// </para>
    /// <para>
    /// #### FDMS Nashville
    /// <c>orderInformation.billTo.address1</c> and <c>orderInformation.billTo.address2</c> together cannot exceed 20 characters.
    /// String (20)
    /// </para>
    /// <para>
    /// #### All Other Processors
    /// String (60)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(60)]
    public string? Address2 { get; init; }

    /// <summary>
    /// Payment card billing city.
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
    [JsonPropertyName("locality")]
    [MaxLength(50)]
    public string? Locality { get; init; }

    /// <summary>
    /// State or province of the billing address. Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf">State, Province, and Territory Codes for the United States and Canada</see>.
    /// <para>
    /// For Payouts: This field may be sent only for FDC Compass.
    /// </para>
    /// <para>
    /// ##### CyberSource through VisaNet
    /// Credit card networks cannot process transactions that contain non-ASCII characters. CyberSource through VisaNet
    /// accepts and stores non-ASCII characters correctly and displays them correctly in reports. However, the limitations
    /// of the credit card networks prevent CyberSource through VisaNet from transmitting non-ASCII characters to the
    /// credit card networks. Therefore, CyberSource through VisaNet replaces non-ASCII characters with meaningless
    /// ASCII characters for transmission to the credit card networks.
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
    [JsonPropertyName("administrativeArea")]
    [MaxLength(50)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Postal code for the billing address. The postal code must consist of 5 to 9 digits.
    /// <para>
    /// When the billing country is the U.S., the 9-digit postal code must follow this format:
    /// [5 digits][dash][4 digits]
    /// </para>
    /// <para>
    /// <b>Example</b> <c>12345-6789</c>
    /// </para>
    /// <para>
    /// When the billing country is Canada, the 6-digit postal code must follow this format:
    /// [alpha][numeric][alpha][space][numeric][alpha][numeric]
    /// </para>
    /// <para>
    /// <b>Example</b> <c>A1B 2C3</c>
    /// </para>
    /// <para>
    /// <b>Important</b> It is your responsibility to determine whether a field is required for the transaction you are requesting.
    /// </para>
    /// <para>
    /// #### SEPA
    /// Required for Create Mandate and Import Mandate
    /// </para>
    /// <para>
    /// #### For Payouts:
    ///  This field may be sent only for FDC Compass.
    /// </para>
    /// <para>
    /// #### American Express Direct
    /// Before sending the postal code to the processor, CyberSource removes all nonalphanumeric characters and, if the remaining value is longer than nine characters, truncates the value starting from the right side.
    /// </para>
    /// <para>
    /// #### Atos
    /// This field must not contain colons (:).
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
    /// #### FDMS Nashville
    /// Required if <c>pointOfSaleInformation.entryMode=keyed</c> and the address is in the U.S. or Canada.
    /// Optional if <c>pointOfSaleInformation.entryMode=keyed</c> and the address is <b>not</b> in the U.S. or Canada.
    /// Not used if swiped.
    /// </para>
    /// <para>
    /// #### RBS WorldPay Atlanta:
    /// For best card-present keyed rates, send the postal code if <c>pointOfSaleInformation.entryMode=keyed</c>.
    /// </para>
    /// <para>
    /// #### TSYS Acquiring Solutions
    /// Required when <c>processingInformation.billPaymentOptions.billPayment=true</c> and <c>pointOfSaleInformation.entryMode=keyed</c>.
    /// </para>
    /// <para>
    /// #### All other processors:
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Name of the customer’s company.
    /// <para>
    /// <b>CyberSource through VisaNet</b>
    /// Credit card networks cannot process transactions that contain non-ASCII characters. CyberSource through VisaNet accepts and stores non-ASCII characters correctly and displays them correctly in reports. However, the limitations of the credit card networks prevent CyberSource through VisaNet from transmitting non-ASCII characters to the credit card networks. Therefore, CyberSource through VisaNet replaces non-ASCII characters with meaningless ASCII characters for transmission to the credit card networks.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    [MaxLength(60)]
    public string? Company { get; init; }

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
    /// Title.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    [MaxLength(60)]
    public string? Title { get; init; }

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
