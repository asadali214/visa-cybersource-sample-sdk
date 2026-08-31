using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record IssuerInformation2
{
    /// <summary>
    /// Country in which the card was issued. This information enables you to determine whether the card was issued
    /// domestically or internationally. Use the two-character <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf">ISO Standard Country Codes</see>.
    /// <para>
    /// This field is supported for Visa, Mastercard, Discover, Diners Club, JCB, and Maestro (International) on Chase
    /// Paymentech Solutions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(3)]
    public string? Country { get; init; }

    /// <summary>
    /// Data defined by the issuer.
    /// <para>
    /// The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.
    /// </para>
    /// <para>
    /// This field is supported only for Visa transactions on <b>CyberSource through VisaNet</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discretionaryData")]
    [MaxLength(255)]
    public string? DiscretionaryData { get; init; }

    /// <summary>
    /// Data defined by the issuer.
    /// <para>
    /// This national use field contains two subfields for information unique to the processing of Visa transactions by members in Japan.
    /// This subfield contains the Katakana text to be printed on the receipt.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countrySpecificDiscretionaryData")]
    [MaxLength(140)]
    public string? CountrySpecificDiscretionaryData { get; init; }

    /// <summary>
    /// This is the raw Association/Issuer Response Codes. You can use ‘issuer/association’ response codes to identify when you can retry to authorize a declined transaction and increase successful transaction volumes. You’ll receive an association/issuer response code for the majority of transactions.
    /// <para>
    /// #### Processors supported:
    ///   - HSBC
    ///   - FDC Nashville Global
    ///   - SIX
    /// </para>
    /// <para>
    /// Currently SIX is not receiving Association/Issuer Response Codes here it receives the additional authorization code that must be printed on the receipt when returned by the processor.
    /// </para>
    /// <para>
    /// #### Possible values:
    /// | Card Type   | Response Code | Description                                                                    |
    /// | ----------- | ------------- | ------------------------------------------------------------------------------ |
    /// | VISA        | 000           | Successful approval/completion or that V.I.P. PIN verification is successful   |
    /// | VISA        | 001           | Refer to card issuer                                                           |
    /// | VISA        | 002           | Refer to card issuer, special condition                                        |
    /// | VISA        | 003           | Invalid merchant or service provider                                           |
    /// | VISA        | 004           | Pickup card                                                                    |
    /// | MasterCard  | 000           | Approved or completed successfully                                             |
    /// | MasterCard  | 001           | Refer to card issuer                                                           |
    /// | MasterCard  | 003           | Invalid merchant                                                               |
    /// | MasterCard  | 004           | Capture card                                                                   |
    /// | MasterCard  | 005           | Do not honor                                                                   |
    /// | AMEX        | 000           | Approved                                                                       |
    /// | AMEX        | 001           | Approve with ID                                                                |
    /// | AMEX        | 002           | Partial Approval (Prepaid Cards only)                                          |
    /// | AMEX        | 100           | Deny                                                                           |
    /// | AMEX        | 101           | Expired Card/Invalid Expiration Date                                           |
    /// | Discover    | 000           | Approved or completed successfully                                             |
    /// | Discover    | 001           | Reserved for future USE                                                        |
    /// | Discover    | 002           | Reserved for future USE                                                        |
    /// | Discover    | 003           | Invalid Merchant                                                               |
    /// | Discover    | 004           | Capture Card                                                                   |
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseCode")]
    [MaxLength(6)]
    public string? ResponseCode { get; init; }

    /// <summary>
    /// This field contains value ‘1’ which is sent by Issuer in the response when PIN is requested by issuer,
    /// <para>
    /// This field is only supported for Visa Platform Connect.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinRequestIndicator")]
    [MaxLength(1)]
    public string? PinRequestIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
