using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains all of the customer-related fields for the invoice.
/// </summary>
public record CustomerInformation
{
    /// <summary>
    /// Payer name for the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(100)]
    public string? Name { get; init; }

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
    /// Your identifier for the customer.
    /// <para>
    /// When a subscription or customer profile is being created, the maximum length for this field for most processors is 30. Otherwise, the maximum length is 100.
    /// </para>
    /// <para>
    /// #### Comercio Latino
    /// For recurring payments in Mexico, the value is the customer’s contract number.
    /// Note Before you request the authorization, you must inform the issuer of the customer contract numbers that will be used for recurring transactions.
    /// </para>
    /// <para>
    /// #### Worldpay VAP
    /// For a follow-on credit with Worldpay VAP, CyberSource checks the following locations, in the order
    /// given, for a customer account ID value and uses the first value it finds:
    /// 1. <c>customer_account_id</c> value in the follow-on credit request
    /// 2. Customer account ID value that was used for the capture that is being credited
    /// 3. Customer account ID value that was used for the original authorization
    /// If a customer account ID value cannot be found in any of these locations, then no value is used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantCustomerId")]
    [MaxLength(100)]
    public string? MerchantCustomerId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public Company6? Company { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
