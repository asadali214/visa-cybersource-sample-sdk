using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RiskAddressVerificationInformation
{
    /// <summary>
    /// Contains the record type of the postal code with which the address was matched.
    /// <para>
    /// #### U.S. Addresses
    /// Depending on the quantity and quality of the address information provided,
    /// this field contains one or two characters:
    /// </para>
    /// <para>
    /// - One character: sufficient correct information was provided to result in accurate matching.
    /// - Two characters: standardization would provide a better address if more or better
    /// input address information were available. The second character is D (default).
    /// </para>
    /// <para>
    /// Blank fields are unassigned. When an address cannot be standardized, how the input
    /// data was parsed determines the address type. In this case, standardization may indicate a street, rural route,
    /// highway contract, general delivery, or PO box.
    /// </para>
    /// <para>
    /// #### All Other Countries
    /// This field contains one of the following values:
    /// - P: Post.
    /// - S: Street.
    /// - x: Unknown.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressType")]
    [MaxLength(255)]
    public string? AddressType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("barCode")]
    public BarCode? BarCode { get; init; }

    /// <summary>
    /// Value can be
    /// - Canada
    /// - US
    /// - International
    /// The values of errorCode and statusCode mean different things depending on the applicable region.
    /// Refer to the guide for more info.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicableRegion")]
    [MaxLength(255)]
    public string? ApplicableRegion { get; init; }

    /// <summary>
    /// Four-character error code returned for Canadian, US and international addresses.
    /// For possible values, see Verification Services guide.
    /// The meaning of the errorCode depends on value of applicableRegion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    [MaxLength(255)]
    public string? ErrorCode { get; init; }

    /// <summary>
    /// Four-to-ten character status code returned for Canadian, US and international addresses.
    /// For possible values, see Verification Services guide.
    /// The meaning of the errorCode depends on value of applicableRegion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusCode")]
    [MaxLength(255)]
    public string? StatusCode { get; init; }

    /// <summary>
    /// Care of data dropped from the standard address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("careOf")]
    [MaxLength(255)]
    public string? CareOf { get; init; }

    /// <summary>
    /// Indicates the probable correctness of the address match. Returned for U.S. and Canadian addresses.
    /// Returns a value from 0-9, where 0 is most likely to be correct and 9 is least
    /// likely to be correct, or -1 if there is no address match.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("matchScore")]
    public int? MatchScore { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("standardAddress")]
    public StandardAddress? StandardAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
