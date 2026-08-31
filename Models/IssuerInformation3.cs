using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record IssuerInformation3
{
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
