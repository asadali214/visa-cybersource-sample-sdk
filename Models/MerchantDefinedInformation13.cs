using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains merchant-defined key-value pairs.
/// </summary>
public record MerchantDefinedInformation13
{
    /// <summary>
    /// Fields that you can use to store information. The value
    /// appears in the Case Management Details window in the
    /// Business Center. The first four fields are the same fields
    /// that are used by the Secure Data services. See request
    /// code examples.
    /// <b>Warning</b> Merchant-defined data fields are not intended
    /// to and must not be used to capture personally identifying
    /// information. Accordingly, merchants are prohibited from
    /// capturing, obtaining, and/or transmitting any personally
    /// identifying information in or via the merchant-defined data
    /// fields. Personally identifying information includes, but is
    /// not limited to, address, credit card number, social security
    /// number, driver's license number, state-issued
    /// identification number, passport number, and card
    /// verification numbers (CVV, CVC2, CVV2, CID, CVN). In
    /// the event CyberSource discovers that a merchant is
    /// capturing and/or transmitting personally identifying
    /// information via the merchant-defined data fields, whether
    /// or not intentionally, CyberSource will immediately
    /// suspend the merchant's account, which will result in a
    /// rejection of any and all transaction requests submitted by
    /// the merchant after the point of suspension.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [MaxLength(255)]
    public string? Key { get; init; }

    /// <summary>
    /// String value for the key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [MaxLength(255)]
    public string? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
