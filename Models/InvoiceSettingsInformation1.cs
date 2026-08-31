using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InvoiceSettingsInformation1
{
    /// <summary>
    /// The image file, which must be encoded in Base64 format. Supported file formats are <c>png</c>, <c>jpg</c>, and <c>gif</c>. The image file size restriction is 1 MB.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantLogo")]
    [MaxLength(10000000)]
    public string? MerchantLogo { get; init; }

    /// <summary>
    /// The merchant's display name shown on the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDisplayName")]
    [MaxLength(100)]
    public string? MerchantDisplayName { get; init; }

    /// <summary>
    /// The content of the email message that we send to your customers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customEmailMessage")]
    [MaxLength(2000)]
    public string? CustomEmailMessage { get; init; }

    /// <summary>
    /// Whether you would like us to send an auto-generated reminder email to your invoice recipients. Currently, this reminder email is sent five days before the invoice is due and one day after it is past due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableReminders")]
    public bool? EnableReminders { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headerStyle")]
    public HeaderStyle? HeaderStyle { get; init; }

    /// <summary>
    /// The language of the email that we send to your customers. Possible values are <c>zh-CN</c>, <c>zh-TW</c>, <c>en-US</c>, <c>fr-FR</c>, <c>de-DE</c>, <c>ja-JP</c>, <c>pt-BR</c>, <c>ru-RU</c> and <c>es-419</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryLanguage")]
    [MaxLength(6)]
    public string? DeliveryLanguage { get; init; }

    /// <summary>
    /// Currency used for the order. Use the three-character <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes.</see>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required field.
    /// </para>
    /// <para>
    /// <b>Authorization Reversal</b>
    /// For an authorization reversal (<c>reversalInformation</c>) or a capture (<c>processingOptions.capture</c> is set to <c>true</c>), you must use the same currency that you used in your payment authorization request.
    /// </para>
    /// <para>
    /// #### PIN Debit
    /// Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes</see>.
    /// Returned by PIN debit purchase.
    /// </para>
    /// <para>
    /// For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing.
    /// For the possible values, see the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes</see>.
    /// </para>
    /// <para>
    /// Required field for PIN Debit purchase and PIN Debit credit requests.
    /// Optional field for PIN Debit reversal requests.
    /// </para>
    /// <para>
    /// #### GPX
    /// This field is optional for reversing an authorization or credit.
    /// </para>
    /// <para>
    /// #### DCC for First Data
    /// Your local currency.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Required for international tax and value added tax only.
    /// Optional for U.S. and Canadian taxes.
    /// Your local currency.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultCurrencyCode")]
    [MaxLength(3)]
    public string? DefaultCurrencyCode { get; init; }

    /// <summary>
    /// The 3D Secure payer authentication status for a merchant's invoice payments.
    /// </summary>
    [JsonPropertyName("payerAuthentication3DSVersion")]
    public bool? PayerAuthentication3DsVersion { get; init; } = false;

    /// <summary>
    /// Display VAT number on Invoice.
    /// </summary>
    [JsonPropertyName("showVatNumber")]
    public bool? ShowVatNumber { get; init; } = false;

    /// <summary>
    /// Your government-assigned tax identification number.
    /// <para>
    /// #### Tax Calculation
    /// Required field for value added tax only. Not applicable to U.S. and Canadian taxes.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vatRegistrationNumber")]
    [MaxLength(21)]
    public string? VatRegistrationNumber { get; init; }

    /// <summary>
    /// Collect the payers shipping address.
    /// </summary>
    [JsonPropertyName("shipTo")]
    public bool? ShipTo { get; init; } = false;

    /// <summary>
    /// Collect the payers phone number.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public bool? PhoneNumber { get; init; } = false;

    /// <summary>
    /// Collect the payers email address when the email address is not known or confirm it if it is known at the time of invoice creation.
    /// </summary>
    [JsonPropertyName("email")]
    public bool? Email { get; init; } = false;

    /// <summary>
    /// Whether you would like to receive payment notification for successful transaction
    /// </summary>
    [JsonPropertyName("enableMerchantEmailNotifications")]
    public bool? EnableMerchantEmailNotifications { get; init; } = false;

    /// <summary>
    /// A list of custom labels that allows you to override (rename) default field names and control the visibility of specific fields on invoices and items. If the list is empty, the labels will not be overwritten.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customLabels")]
    public IReadOnlyList<CustomLabel>? CustomLabels { get; init; }

    /// <summary>
    /// Object containing custom redirect URLs for different payment outcomes. Each property allows specifying a URL to which the customer will be redirected after a payment event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customRedirectUrls")]
    public CustomRedirectUrls? CustomRedirectUrls { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
