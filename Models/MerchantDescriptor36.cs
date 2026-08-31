using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantDescriptor36
{
    /// <summary>
    /// Your merchant name.
    /// <para>
    /// <b>Note</b> For Paymentech processor using Cybersource Payouts, the maximum data length is 22.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Your business name. This name is displayed on the cardholder’s statement. When you
    /// include more than one consecutive space, extra spaces are removed.
    /// </para>
    /// <para>
    /// When you do not include this value in your PIN debit request, the merchant name from your account is used.
    /// <b>Important</b> This value must consist of English characters.
    /// </para>
    /// <para>
    /// Optional field for PIN debit credit or PIN debit purchase requests.
    /// </para>
    /// <para>
    /// #### Airline processing
    /// Your merchant name. This name is displayed on the cardholder’s statement. When you include more than one consecutive space, extra spaces are removed.
    /// </para>
    /// <para>
    /// <b>Note</b> Some airline fee programs may require the original ticket number (ticket identifier) or the ancillary service description in positions 13 through 23 of this field.
    /// </para>
    /// <para>
    /// <b>Important</b> This value must consist of English characters.
    /// </para>
    /// <para>
    /// Required for captures and credits.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Merchant's City.
    /// <para>
    /// #### PIN debit
    /// City for your business location. This value might be displayed on the cardholder’s statement.
    /// </para>
    /// <para>
    /// When you do not include this value in your PIN debit request, the merchant name from your account is used.
    /// <b>Important</b> This value must consist of English characters.
    /// </para>
    /// <para>
    /// Optional field for PIN debit credit or PIN debit purchase requests.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(30)]
    public string? Locality { get; init; }

    /// <summary>
    /// Merchant's country.
    /// <para>
    /// #### PIN debit
    /// Country code for your business location. Use the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes</see>
    /// This value might be displayed on the cardholder’s statement.
    /// </para>
    /// <para>
    /// When you do not include this value in your PIN debit request, the merchant name from your account is used.
    /// <b>Important</b> This value must consist of English characters.
    /// <b>Note</b> If your business is located in the U.S. or Canada and you include this field in a
    /// request, you must also include <c>merchantInformation.merchantDescriptor.administrativeArea</c>.
    /// </para>
    /// <para>
    /// Optional field for PIN debit credit or PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(3)]
    public string? Country { get; init; }

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
    /// Merchant's postal code.
    /// <para>
    /// #### PIN debit
    /// Postal code for your business location. This value might be displayed on the cardholder’s statement.
    /// </para>
    /// <para>
    /// If your business is domiciled in the U.S., you can use a 5-digit or 9-digit postal code. A 9-digit postal code must follow this format:
    /// [5 digits][dash][4 digits]
    /// Example: <c>12345-6789</c>
    /// </para>
    /// <para>
    /// If your business is domiciled in Canada, you can use a 6-digit or 9-digit postal code. A 6-digit postal code must follow this format:
    /// [alpha][numeric][alpha][space]
    /// [numeric][alpha][numeric]
    /// Example: <c>A1B 2C3</c>
    /// </para>
    /// <para>
    /// When you do not include this value in your PIN debit request, the merchant name from your account is used.
    /// <b>Important</b> This value must consist of English characters.
    /// </para>
    /// <para>
    /// <b>Note</b> This field is supported only for businesses located in the U.S. or Canada.
    /// <b>Important</b> Mastercard requires a postal code for any country that uses postal codes.
    /// You can provide the postal code in your account or you can include this field in your request.
    /// </para>
    /// <para>
    /// Optional field for PIN debit credit or PIN debit purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(14)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Contact information for the merchant.
    /// <para>
    /// <b>Note</b> These are the maximum data lengths for the following payment processors:
    /// - FDCCompass (13)
    /// - Paymentech (13)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contact")]
    [MaxLength(25)]
    public string? Contact { get; init; }

    /// <summary>
    /// First line of merchant's address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(60)]
    public string? Address1 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
