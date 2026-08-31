using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantDefinedInformation
{
    /// <summary>
    /// The number you assign for as the key for your merchant-defined data field. Valid values are 0 to 100.
    /// <para>
    /// For example, to set or access the key for the 2nd merchant-defined data field in the array, you would reference <c>merchantDefinedInformation[1].key</c>.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// For installment payments with Mastercard in Brazil, use <c>merchantDefinedInformation[0].key</c> and
    /// <c>merchantDefinedInformation[1].key</c> for data that you want to provide to the issuer to identify the
    /// transaction.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [MaxLength(50)]
    public string? Key { get; init; }

    /// <summary>
    /// The value you assign for your merchant-defined data field.
    /// <para>
    /// <b>Warning</b> Merchant-defined data fields are not intended to and must not be used to capture personally identifying information. Accordingly, merchants are prohibited from capturing, obtaining, and/or transmitting any personally identifying information in or via the merchant-defined data fields. Personally identifying information includes, but is not
    /// limited to, address, credit card number, social security number, driver's license number, state-issued identification number, passport number, and card verification numbers (CVV,
    /// CVC2, CVV2, CID, CVN). In the event CyberSource discovers that a merchant is capturing and/or transmitting personally identifying information via the merchant-defined data fields, whether or not intentionally, CyberSource will immediately suspend the merchant's account, which will result in a rejection of any and all transaction requests submitted by the merchant after the point of suspension.
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// For installment payments with Mastercard in Brazil, use <c>merchantDefinedInformation[0].value</c> and
    /// <c>merchantDefinedInformation[1].value</c> for data that you want to provide to the issuer to identify the
    /// transaction.
    /// </para>
    /// <para>
    /// For installment payments with Mastercard in Brazil:
    /// - The value for merchantDefinedInformation[0].value corresponds to the following data in the TC 33 capture file5:
    ///   - Record: CP07 TCR5
    ///   - Position: 25-44
    ///   - Field: Reference Field 2
    /// - The value for merchantDefinedInformation[1].value corresponds to the following data in the TC 33 capture file5:
    ///   - Record: CP07 TCR5
    ///   - Position: 45-64
    ///   - Field: Reference Field 3
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [MaxLength(800)]
    public string? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
