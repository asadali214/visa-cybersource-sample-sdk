using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantDescriptor37
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
