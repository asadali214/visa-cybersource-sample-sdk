using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AccountFeatures1
{
    /// <summary>
    /// #### GPX
    /// Mastercard product ID associated with the primary account number (PAN).
    /// Returned by authorization service.
    /// <para>
    /// #### CyberSource through VisaNet
    /// Visa or Mastercard product ID that is associated with the primary account number (PAN).
    /// For descriptions of the Visa product IDs, see the Product ID table on the [Visa
    /// Request &amp; Response Codes web page.](https://developer.visa.com/guides/request_response_codes)
    /// </para>
    /// <para>
    /// Data Length: String (3)
    /// </para>
    /// <para>
    /// #### GPN
    /// Visa or Mastercard product ID that is associated with the primary account number (PAN).
    /// For descriptions of the Visa product IDs, see the Product ID table on the
    /// <see href="https://developer.visa.com/guides/request_response_codes">Visa Request &amp; Response Codes web page.</see>
    /// </para>
    /// <para>
    /// Data Length: String (3)
    /// </para>
    /// <para>
    /// #### Worldpay VAP
    /// <b>Important</b> Before using this field on Worldpay VAP,
    /// you must contact CyberSource Customer Support to have
    /// your account configured for this feature.
    /// </para>
    /// <para>
    /// Type of card used in the transaction. The only possible value is:
    /// - <c>PREPAID</c>: Prepaid Card
    /// </para>
    /// <para>
    /// Data Length: String (7)
    /// </para>
    /// <para>
    /// #### RBS WorldPay Atlanta
    /// Type of card used in the transaction. Possible values:
    /// - <c>B</c>: Business Card
    /// - <c>O</c>: Noncommercial Card
    /// - <c>R</c>: Corporate Card
    /// - <c>S</c>: Purchase Card
    /// - <c>Blank</c>: Purchase card not supported
    /// </para>
    /// <para>
    /// Data Length: String (1)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    [MaxLength(7)]
    public string? Category { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
