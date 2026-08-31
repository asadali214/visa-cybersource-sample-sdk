using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantDescriptor11
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
    /// Email address of the merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(254)]
    public string? Email { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
